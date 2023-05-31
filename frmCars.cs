using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.AxHost;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = C:\data\hire.db"); //connects to the Database
        public frmCars()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordCounter("first"); //go to first position
            getData(); //get data of current position

        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            recordCounter("previous"); //go to previous position
            getData(); //get data of current position
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            recordCounter("next"); //go to next position
            getData(); //get data of current position
        }



        private void btnLast_Click(object sender, EventArgs e)
        {
            recordCounter("last"); //go to last position
            getData(); //get data of current position
        }



        int recordControlNo = 1;//USED IN NUMBER DISPLAY AT BOTTOM OF for
        int totalRecords; //WHERE WE STORE TOTAL AMOUNT OF RECORDS



        public void recTotal()
        {
            string findTotal = @"SELECT COUNT(*) FROM tblCar";

            databaseConnection.Open();
            var command = databaseConnection.CreateCommand();
            command.CommandText = findTotal;
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var total = reader.GetInt32(0);
                    totalRecords = total;
                }
            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
            databaseConnection.Close();

        }


        public void recordCounter(string frmBtn)
        {//UPDATES RECORD BOX DEPENDING ON BUTTONS PRESSED AND ALSO USED AS A REFERENCE FOR CYCLING THROUGH  -> getData()

            if (frmBtn == "next")
            {
                //Determine behaviour of next button
             if (recordControlNo < totalRecords)
                { recordControlNo += 1; }
            }

            if (frmBtn == "previous")
            {
                if (recordControlNo > 1)
                { recordControlNo -= 1; }
            }
            if (frmBtn == "first")
            { recordControlNo = 1; }

            if (frmBtn == "last")
            { recordControlNo = totalRecords; }

        }




        private void recordCount_TextChanged(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }



        private void frmCars_Load(object sender, EventArgs e)
        {
            //This is what happens when form loads
            try
            {
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load database. Check database connection");
            }

            btnUpdate.Enabled = false; //Update button unusable until use conditions are met
            btnCancel.Enabled = false; //Cancel button unusable until use conditions are met
            updatePanel.Visible = false; //Panel button unusable until use conditions are met

            if (btnUpdate.Enabled == true)
            {
                updatePanel.Visible = true; //if update button is onn then we can see text telling us we are updating the record
            }
        }


        Details details = new Details();

        public void getData()
        {
            int rowPosition = recordControlNo - 1;

            try
            {
                databaseConnection.Open();
                //string getDB = $@"SELECT * FROM tblCar LIMIT 1 OFF SET {rowPosition}";
                string getDB = @"SELECT * FROM tblCar LIMIT 1 OFFSET $rowPosition";

                SQLiteCommand cmd = new SQLiteCommand(getDB, databaseConnection);

                cmd.Parameters.AddWithValue("$rowPosition", rowPosition);//extra added later 

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                //frmDataGrid.DataSource = dt;           

                databaseConnection.Close(); //closing connection to database

                frmVehicleReg.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                frmMake.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                frmEngine.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                frmDateReg.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                frmRentalPerDay.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                int available = Convert.ToInt32(dt.Rows[0].ItemArray[6]);
                if (available == 1)
                {// If database returns 1 then we check the checkbox
                    frmAvailable.Checked = true;
                }
                else
                {// If databesa returns 0 then we uncheck the checkbox
                    frmAvailable.Checked = false;
                }

                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                updatePanel.Visible = false;

                details.VehicleReg = frmVehicleReg.Text;
                details.Make = frmMake.Text;
                details.Engine = frmEngine.Text;
                details.DateReg = frmDateReg.Text;
                details.RentalPerDay = frmRentalPerDay.Text;
                details.Available = available;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Cannot find data"); // If getdata fails to work this message box appears
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }


        private int availability;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd openAddForm = new frmAdd();
            this.Hide();
            openAddForm.ShowDialog();
            this.Close();
        }

        private void updateRecord()
        {//UPDATES RECORD BASED ON INFORMATION IN TEXT FIELDS
            int offsetNumber = recordControlNo - 1;
            try
            {
                if (frmAvailable.Checked == true)
                {
                    availability = 1;
                }
                if (frmAvailable.Checked == false)
                {
                    availability = 0;
                }
                string updateARecord = $@"UPDATE tblCar SET VehicleRegNo = '" + frmVehicleReg.Text + "', Make = '" + frmMake.Text + "', EngineSize ='" + frmEngine.Text + "', DataRegistered = '" + frmDateReg.Text + "', RentalPerDay = '" + frmRentalPerDay.Text + "', Available = '" + availability + "'WHERE VehicleRegNo = (SELECT VehicleRegNo from tblCar limit 1 OFFSET" + offsetNumber + ");";
                databaseConnection.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(databaseConnection);
                insertSQL.CommandText = updateARecord;
                insertSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data");
                return;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult toDelete = MessageBox.Show($"Are you sure you'd like to delete this record\nVehicle Registration: {details.VehicleReg}\nMake: {details.Make}\nEngine Size: {details.Engine}\nDate Registered: {details.DateReg}\nRental Per Day: {details.RentalPerDay}\nAvailable: {details.Available}", "Delete Record", MessageBoxButtons.YesNo);
            if (toDelete == DialogResult.Yes)
            {
                deleteData();
                MessageBox.Show("Record Deleted");
            }
            else if (toDelete == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
        }



        private void deleteData()
        {//DELETES CURRENT DISPLAYED DATA FROM DATABASE
            try
            {
                string deleteRecord = $@"DELETE FROM tblCar WHERE VehicleRegNo = '{frmVehicleReg.Text}'";

                databaseConnection.Open();
                string sendData2 = deleteRecord;
                SQLiteCommand deleteSQL = new SQLiteCommand(databaseConnection);
                deleteSQL.CommandText = sendData2;
                deleteSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                recordCounter("last");
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data");
            }

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            getData();
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            updatePanel.Visible = false;
            frmMake.BackColor = Color.White;
            frmEngine.BackColor = Color.White;
            frmDateReg.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRentalPerDay.BackColor = Color.White;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult toUpdate = MessageBox.Show("Are you sure you'd like to Update this record?", "Update Record", MessageBoxButtons.YesNo);
            if (toUpdate == DialogResult.Yes)
            {
                updateRecord();
                MessageBox.Show("Record updated.");
            }
            else if (toUpdate == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
            frmMake.BackColor = Color.White;
            frmEngine.BackColor = Color.White;
            frmDateReg.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRentalPerDay.BackColor = Color.White;

        }



        private void frmMake_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }


        private void frmEngine_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }


        private void frmDateReg_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }


        private void frmRentalPerDay_ValueChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void frmMake_KeyDown(object sender, KeyEventArgs e)
        {
            frmMake.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmVehicleReg_KeyDown(object sender, KeyEventArgs e)
        {
            frmVehicleReg.BackColor = Color.LightGoldenrodYellow;

        }

        //private void frmEngine_KeyDown(object sender, EventArgs e)
        
        
                 

        private void frmEngine_KeyDown(object sender, KeyEventArgs e)
        {
            frmEngine.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmDateReg_keyDown(object sender, KeyEventArgs e)
        {
            frmDateReg.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmRentalPerDay_KeyDown(object sender, KeyEventArgs e)
        {
            frmRentalPerDay.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmAvailable_KeyDown(object sender, KeyEventArgs e)
        {
            frmAvailable.BackColor = Color.LightGoldenrodYellow;
        }

        //private void frmRentalPerDay_ValueChanged_1(object sender, EventArgs e)
        

        
    }
}
