using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmAdd : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = c:\data\hire.db"); //connects to the Database
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            if (frmVehicleReg.Text != "" && frmMake.Text != "" && frmDateReg.Text != "" && frmEngine.Text != "" && frmRentalPerDay.Value != 0)
            {
                try
                {
                    string isRegInDB = $@"SELECT VehicleRegNo FROM tblCar WHERE VehicleRegNo = '" + frmVehicleReg.Text + "'";
                    databaseConnection.Open();

                    var command = databaseConnection.CreateCommand();
                    command.CommandText = isRegInDB;

                    using (var reader = command)
                    {

                    }

                    string addARecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available)";

                    SQLiteCommand insertSQL = new SQLiteCommand(isRegInDB, databaseConnection);
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(insertSQL);
                    adapter3.Fill(dt);
                    databaseConnection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot ");
                    return;
                }
            }
        }
        private int Availability;
        private string returnedReg;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmVehicleReg.Text != "" && frmMake.Text != "" && frmDateReg.Text != "" && frmEngine.Text != "" && frmRentalPerDay.Value != 0)
            {
                try
                {//STRING USED FOR DB
                    string isRegInDb = $@"SELECT VehicleRegNo FROM tblCar WHERE VehicleRegNo = '" + frmVehicleReg.Text + "'";
                    databaseConnection.Open();

                    var command = databaseConnection.CreateCommand();
                    command.CommandText = isRegInDb;

                    using (var reader = command.ExecuteReader())
                    {//GETTING MATCHING RECORD
                        while (reader.Read())
                        {
                            var reg = reader.GetString(0);
                            returnedReg = reg;
                        }
                        if (frmVehicleReg.Text == returnedReg)
                        {
                            MessageBox.Show("Vehicle Registration Number may already exist in the database.");
                        }
                        if (frmVehicleReg.Text != returnedReg)
                        {
                            if (frmAvailable.Checked == true)
                            {
                                Availability = 1;
                            }
                            if (frmAvailable.Checked == false)
                            {
                                Availability = 0;
                            }
                            string addRecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES
                                ('" + frmVehicleReg.Text + "', '" + frmMake.Text + "', '" + frmEngine.Text + "', '" + frmDateReg.Text + "', '" + frmRentalPerDay.Value + "', '" + Availability + "')";
                            SQLiteCommand insertSQL = new SQLiteCommand(addRecord, databaseConnection);
                            insertSQL.CommandText = addRecord;
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("You have succesfully added a new record to the database");
                            databaseConnection.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot add data");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are completed");
            }
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmMake_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmEngine_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmDateReg_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmRentalPerDay_ValueChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void frmAvailable_CheckedChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
            btnClose.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmVehicleReg.Text = "";
            frmEngine.Text = "";
            frmDateReg.Text = "";
            frmMake.Text = "";
            frmRentalPerDay.Text = "0";
            frmAvailable.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCars goTofrmCars = new frmCars();
            this.Hide();
            goTofrmCars.ShowDialog();
            this.Close();
        }
    }
 }

