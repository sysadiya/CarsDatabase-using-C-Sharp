namespace CarsDatabase
{
    partial class frmAdd
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
            this.frmVehicleRegLable = new System.Windows.Forms.Label();
            this.frmMakeLable = new System.Windows.Forms.Label();
            this.frmEngineLabel = new System.Windows.Forms.Label();
            this.frmDateLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmDateReg = new System.Windows.Forms.TextBox();
            this.frmRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // frmVehicleRegLable
            // 
            this.frmVehicleRegLable.AutoSize = true;
            this.frmVehicleRegLable.Location = new System.Drawing.Point(45, 64);
            this.frmVehicleRegLable.Name = "frmVehicleRegLable";
            this.frmVehicleRegLable.Size = new System.Drawing.Size(141, 13);
            this.frmVehicleRegLable.TabIndex = 0;
            this.frmVehicleRegLable.Text = "Vehicle Registration Number";
            // 
            // frmMakeLable
            // 
            this.frmMakeLable.AutoSize = true;
            this.frmMakeLable.Location = new System.Drawing.Point(45, 114);
            this.frmMakeLable.Name = "frmMakeLable";
            this.frmMakeLable.Size = new System.Drawing.Size(34, 13);
            this.frmMakeLable.TabIndex = 1;
            this.frmMakeLable.Text = "Make";
            // 
            // frmEngineLabel
            // 
            this.frmEngineLabel.AutoSize = true;
            this.frmEngineLabel.Location = new System.Drawing.Point(45, 162);
            this.frmEngineLabel.Name = "frmEngineLabel";
            this.frmEngineLabel.Size = new System.Drawing.Size(63, 13);
            this.frmEngineLabel.TabIndex = 2;
            this.frmEngineLabel.Text = "Engine Size";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.Location = new System.Drawing.Point(45, 203);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(84, 13);
            this.frmDateLabel.TabIndex = 3;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.Location = new System.Drawing.Point(45, 244);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(79, 13);
            this.frmRentalLabel.TabIndex = 4;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.Location = new System.Drawing.Point(45, 269);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(50, 13);
            this.frmAvailLabel.TabIndex = 5;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(205, 278);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(15, 14);
            this.frmAvailable.TabIndex = 6;
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.CheckedChanged += new System.EventHandler(this.frmAvailable_CheckedChanged);
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(205, 64);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(100, 20);
            this.frmVehicleReg.TabIndex = 7;
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(205, 114);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(191, 20);
            this.frmMake.TabIndex = 8;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(205, 159);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(100, 20);
            this.frmEngine.TabIndex = 9;
            this.frmEngine.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(205, 203);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(100, 20);
            this.frmDateReg.TabIndex = 10;
            this.frmDateReg.TextChanged += new System.EventHandler(this.frmDateReg_TextChanged);
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Location = new System.Drawing.Point(205, 244);
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(120, 20);
            this.frmRentalPerDay.TabIndex = 11;
            this.frmRentalPerDay.ValueChanged += new System.EventHandler(this.frmRentalPerDay_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(54, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(183, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(312, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(446, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.frmDateReg);
            this.Controls.Add(this.frmEngine);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.frmVehicleReg);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmAvailLabel);
            this.Controls.Add(this.frmRentalLabel);
            this.Controls.Add(this.frmDateLabel);
            this.Controls.Add(this.frmEngineLabel);
            this.Controls.Add(this.frmMakeLable);
            this.Controls.Add(this.frmVehicleRegLable);
            this.Name = "frmAdd";
            this.Text = "Task A Add";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmVehicleRegLable;
        private System.Windows.Forms.Label frmMakeLable;
        private System.Windows.Forms.Label frmEngineLabel;
        private System.Windows.Forms.Label frmDateLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmDateReg;
        private System.Windows.Forms.NumericUpDown frmRentalPerDay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}