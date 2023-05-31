namespace CarsDatabase
{
    partial class frmSearch
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.frmDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.valueTextbox = new System.Windows.Forms.TextBox();
            this.frmValueLabel = new System.Windows.Forms.Label();
            this.frmOperatorLabel = new System.Windows.Forms.Label();
            this.frmFieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(526, 59);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 39);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(526, 104);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDataGrid
            // 
            this.frmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmDataGrid.Location = new System.Drawing.Point(27, 214);
            this.frmDataGrid.Name = "frmDataGrid";
            this.frmDataGrid.Size = new System.Drawing.Size(520, 169);
            this.frmDataGrid.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.cboOperator);
            this.panel1.Controls.Add(this.cboField);
            this.panel1.Controls.Add(this.valueTextbox);
            this.panel1.Controls.Add(this.frmValueLabel);
            this.panel1.Controls.Add(this.frmOperatorLabel);
            this.panel1.Controls.Add(this.frmFieldLabel);
            this.panel1.Location = new System.Drawing.Point(27, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 116);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(546, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(66, 10);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(147, 57);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(121, 21);
            this.cboOperator.TabIndex = 5;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(20, 57);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 4;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // valueTextbox
            // 
            this.valueTextbox.Location = new System.Drawing.Point(299, 58);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.Size = new System.Drawing.Size(100, 20);
            this.valueTextbox.TabIndex = 3;
            // 
            // frmValueLabel
            // 
            this.frmValueLabel.AutoSize = true;
            this.frmValueLabel.Location = new System.Drawing.Point(278, 17);
            this.frmValueLabel.Name = "frmValueLabel";
            this.frmValueLabel.Size = new System.Drawing.Size(34, 13);
            this.frmValueLabel.TabIndex = 2;
            this.frmValueLabel.Text = "Value";
            // 
            // frmOperatorLabel
            // 
            this.frmOperatorLabel.AutoSize = true;
            this.frmOperatorLabel.Location = new System.Drawing.Point(159, 17);
            this.frmOperatorLabel.Name = "frmOperatorLabel";
            this.frmOperatorLabel.Size = new System.Drawing.Size(48, 13);
            this.frmOperatorLabel.TabIndex = 1;
            this.frmOperatorLabel.Text = "Operator";
            // 
            // frmFieldLabel
            // 
            this.frmFieldLabel.AutoSize = true;
            this.frmFieldLabel.Location = new System.Drawing.Point(38, 17);
            this.frmFieldLabel.Name = "frmFieldLabel";
            this.frmFieldLabel.Size = new System.Drawing.Size(29, 13);
            this.frmFieldLabel.TabIndex = 0;
            this.frmFieldLabel.Text = "Field";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmDataGrid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Name = "frmSearch";
            this.Text = "Task A Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView frmDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.TextBox valueTextbox;
        private System.Windows.Forms.Label frmValueLabel;
        private System.Windows.Forms.Label frmOperatorLabel;
        private System.Windows.Forms.Label frmFieldLabel;
    }
}