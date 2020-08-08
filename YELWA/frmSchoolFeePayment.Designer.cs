namespace YELWA
{
    partial class frmSchoolFeePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolFeePayment));
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDop = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAcademicSession = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricNumber = new System.Windows.Forms.Label();
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(230, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 30;
            this.button1.Text = "RECORD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(74, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "DATE OF PAYMENT:";
            // 
            // dtpDop
            // 
            this.dtpDop.CustomFormat = "yyyy/MM/dd";
            this.dtpDop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDop.Location = new System.Drawing.Point(267, 448);
            this.dtpDop.Name = "dtpDop";
            this.dtpDop.Size = new System.Drawing.Size(182, 20);
            this.dtpDop.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(76, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "AMOUNT PAID:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(267, 393);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(182, 20);
            this.txtAmountPaid.TabIndex = 70;
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);
            // 
            // cmbLevel
            // 
            this.cmbLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "-----------------------SELECT----------------------",
            "1",
            "2",
            "3"});
            this.cmbLevel.Location = new System.Drawing.Point(267, 244);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(182, 21);
            this.cmbLevel.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(76, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "YEAR:";
            // 
            // cmbAcademicSession
            // 
            this.cmbAcademicSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAcademicSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicSession.FormattingEnabled = true;
            this.cmbAcademicSession.Items.AddRange(new object[] {
            "----------------------SELECT----------------------------",
            "2018/2019",
            "2019/2020"});
            this.cmbAcademicSession.Location = new System.Drawing.Point(267, 339);
            this.cmbAcademicSession.Name = "cmbAcademicSession";
            this.cmbAcademicSession.Size = new System.Drawing.Size(182, 21);
            this.cmbAcademicSession.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(76, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "ACADEMIC SESSION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 67;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(267, 145);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 20);
            this.txtPhoneNumber.TabIndex = 66;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(76, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "PHONE NUMBER:";
            // 
            // cmbGender
            // 
            this.cmbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "-------------------SELECT-------------------",
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(267, 194);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(182, 21);
            this.cmbGender.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "GENDER:";
            // 
            // lblMatricNumber
            // 
            this.lblMatricNumber.AutoSize = true;
            this.lblMatricNumber.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricNumber.ForeColor = System.Drawing.Color.Transparent;
            this.lblMatricNumber.Location = new System.Drawing.Point(76, 293);
            this.lblMatricNumber.Name = "lblMatricNumber";
            this.lblMatricNumber.Size = new System.Drawing.Size(106, 16);
            this.lblMatricNumber.TabIndex = 61;
            this.lblMatricNumber.Text = "MATRIC NUMBER:";
            // 
            // txtMatricNumber
            // 
            this.txtMatricNumber.Location = new System.Drawing.Point(267, 291);
            this.txtMatricNumber.Name = "txtMatricNumber";
            this.txtMatricNumber.Size = new System.Drawing.Size(182, 20);
            this.txtMatricNumber.TabIndex = 60;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Location = new System.Drawing.Point(76, 102);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(85, 16);
            this.lblDepartment.TabIndex = 57;
            this.lblDepartment.Text = "DEPARTMENT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 56;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Transparent;
            this.lblFullName.Location = new System.Drawing.Point(76, 54);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(78, 16);
            this.lblFullName.TabIndex = 55;
            this.lblFullName.Text = "FULL NAME:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(267, 54);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(182, 20);
            this.txtFullName.TabIndex = 54;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(267, 98);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(182, 20);
            this.txtDepartment.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LettrGoth12 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(123, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "SUBMIT ALL REQUESTED DETAILS TO MAKE PAYMENT";
            // 
            // frmSchoolFeePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(518, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAcademicSession);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMatricNumber);
            this.Controls.Add(this.txtMatricNumber);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchoolFeePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SCHOOL PAYMENT PORTAL";
            this.Load += new System.EventHandler(this.frmSchoolFeePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAcademicSession;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricNumber;
        private System.Windows.Forms.TextBox txtMatricNumber;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label3;
    }
}