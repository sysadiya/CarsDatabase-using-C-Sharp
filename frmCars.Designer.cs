namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmDateReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmVehicleRegLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmEngineLabel = new System.Windows.Forms.Label();
            this.frmDateLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.recordCount = new System.Windows.Forms.TextBox();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.updatePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(562, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 42);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(186, 21);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(119, 20);
            this.frmVehicleReg.TabIndex = 10;
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            this.frmVehicleReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVehicleReg_KeyDown);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(252, 123);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(217, 20);
            this.frmMake.TabIndex = 11;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            this.frmMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMake_KeyDown);
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(186, 103);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(119, 20);
            this.frmEngine.TabIndex = 12;
            this.frmEngine.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            this.frmEngine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEngine_KeyDown);
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(252, 212);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(119, 20);
            this.frmDateReg.TabIndex = 13;
            this.frmDateReg.TextChanged += new System.EventHandler(this.frmDateReg_TextChanged);
            this.frmDateReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDateReg_keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bowman Car Hire";
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(16, 24);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(141, 13);
            this.frmVehicleRegLabel.TabIndex = 15;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Location = new System.Drawing.Point(16, 68);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(34, 13);
            this.frmMakeLabel.TabIndex = 16;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmEngineLabel
            // 
            this.frmEngineLabel.AutoSize = true;
            this.frmEngineLabel.Location = new System.Drawing.Point(19, 106);
            this.frmEngineLabel.Name = "frmEngineLabel";
            this.frmEngineLabel.Size = new System.Drawing.Size(63, 13);
            this.frmEngineLabel.TabIndex = 17;
            this.frmEngineLabel.Text = "Engine Size";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.Location = new System.Drawing.Point(19, 157);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(84, 13);
            this.frmDateLabel.TabIndex = 18;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.Location = new System.Drawing.Point(19, 202);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(82, 13);
            this.frmRentalLabel.TabIndex = 19;
            this.frmRentalLabel.Text = "Rental  Per Day";
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Location = new System.Drawing.Point(252, 262);
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(119, 20);
            this.frmRentalPerDay.TabIndex = 20;
            //this.frmRentalPerDay.ValueChanged += new System.EventHandler(this.frmRentalPerDay_ValueChanged_1);
            this.frmRentalPerDay.Click += new System.EventHandler(this.frmRentalPerDay_ValueChanged);
            this.frmRentalPerDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRentalPerDay_KeyDown);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(186, 239);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(15, 14);
            this.frmAvailable.TabIndex = 21;
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAvailable_KeyDown);
            // 
            // recordCount
            // 
            this.recordCount.Location = new System.Drawing.Point(346, 385);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(114, 20);
            this.recordCount.TabIndex = 22;
            this.recordCount.Text = "1 of 15";
            this.recordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recordCount.TextChanged += new System.EventHandler(this.recordCount_TextChanged);
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.Location = new System.Drawing.Point(19, 239);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(50, 13);
            this.frmAvailLabel.TabIndex = 23;
            this.frmAvailLabel.Text = "Available";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(562, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 45);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(562, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 41);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(562, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 38);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(562, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 42);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(562, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 46);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(124, 373);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 40);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(233, 373);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 40);
            this.btnPrevious.TabIndex = 30;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(457, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 43);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(549, 370);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(98, 42);
            this.btnLast.TabIndex = 32;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.frmVehicleRegLabel);
            this.updatePanel.Controls.Add(this.frmMakeLabel);
            this.updatePanel.Controls.Add(this.frmEngineLabel);
            this.updatePanel.Controls.Add(this.frmDateLabel);
            this.updatePanel.Controls.Add(this.frmRentalLabel);
            this.updatePanel.Controls.Add(this.frmAvailLabel);
            this.updatePanel.Controls.Add(this.frmVehicleReg);
            this.updatePanel.Controls.Add(this.frmEngine);
            this.updatePanel.Controls.Add(this.frmAvailable);
            this.updatePanel.Location = new System.Drawing.Point(66, 61);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(477, 274);
            this.updatePanel.TabIndex = 33;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmDateReg);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updatePanel);
            this.Name = "frmCars";
            this.Text = "Task A";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmDateReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frmVehicleRegLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmEngineLabel;
        private System.Windows.Forms.Label frmDateLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.NumericUpDown frmRentalPerDay;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.TextBox recordCount;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel updatePanel;
    }
}

