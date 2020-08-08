namespace YELWA
{
    partial class frmCommunityHealthCheYear1CourseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommunityHealthCheYear1CourseForm));
            this.btnMedicalThirdYear = new System.Windows.Forms.Button();
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicalThirdYear
            // 
            this.btnMedicalThirdYear.BackColor = System.Drawing.Color.White;
            this.btnMedicalThirdYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicalThirdYear.FlatAppearance.BorderSize = 6;
            this.btnMedicalThirdYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalThirdYear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalThirdYear.ForeColor = System.Drawing.Color.White;
            this.btnMedicalThirdYear.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicalThirdYear.Image")));
            this.btnMedicalThirdYear.Location = new System.Drawing.Point(492, 106);
            this.btnMedicalThirdYear.Name = "btnMedicalThirdYear";
            this.btnMedicalThirdYear.Size = new System.Drawing.Size(83, 59);
            this.btnMedicalThirdYear.TabIndex = 57;
            this.btnMedicalThirdYear.UseVisualStyleBackColor = false;
            this.btnMedicalThirdYear.Click += new System.EventHandler(this.btnMedicalThirdYear_Click);
            // 
            // txtMatricNumber
            // 
            this.txtMatricNumber.Location = new System.Drawing.Point(256, 115);
            this.txtMatricNumber.Name = "txtMatricNumber";
            this.txtMatricNumber.Size = new System.Drawing.Size(211, 20);
            this.txtMatricNumber.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(126, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "MATRIC NUMBER:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(256, 69);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(211, 20);
            this.txtFullName.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(126, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "STUDENT NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(162, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Kindly Provide the following details to proceed:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCommunityHealthChe1stYear1stSemester);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCommunityHealthChe1stYear12ndSemester);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.ForeColor = System.Drawing.Color.Transparent;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "-----------------SELECT-------------------",
            "1",
            "2",
            "3"});
            this.cmbYear.Location = new System.Drawing.Point(256, 215);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(211, 21);
            this.cmbYear.TabIndex = 58;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDepartment.Location = new System.Drawing.Point(256, 162);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(211, 20);
            this.txtDepartment.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(130, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "DEPARTMENT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(126, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "YEAR:";
            // 
            // frmCommunityHealthCheYear1CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(604, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnMedicalThirdYear);
            this.Controls.Add(this.txtMatricNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCommunityHealthCheYear1CourseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMMUNITY HEALTH CHEW YEAR 1 COURSE REGISTRATION FORM";
            this.Load += new System.EventHandler(this.frmCommunityHealthCheYear1CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedicalThirdYear;
        private System.Windows.Forms.TextBox txtMatricNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;

    }
}