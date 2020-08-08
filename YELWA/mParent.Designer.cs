namespace YELWA
{
    partial class mParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSchoolUnit = new System.Windows.Forms.Button();
            this.btnClinic = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStaffLoan = new System.Windows.Forms.Button();
            this.btnSchoolFeesPayment = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExpensesRecord = new System.Windows.Forms.Button();
            this.btnCourseForm = new System.Windows.Forms.Button();
            this.btnStaffAttendance = new System.Windows.Forms.Button();
            this.btnStaffRecord = new System.Windows.Forms.Button();
            this.btnStudentRecord = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.accountToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem1});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // addNewUserToolStripMenuItem1
            // 
            this.addNewUserToolStripMenuItem1.Name = "addNewUserToolStripMenuItem1";
            this.addNewUserToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.addNewUserToolStripMenuItem1.Text = "Add new user";
            this.addNewUserToolStripMenuItem1.Click += new System.EventHandler(this.addNewUserToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSchoolUnit);
            this.panel1.Controls.Add(this.btnClinic);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStaffLoan);
            this.panel1.Controls.Add(this.btnSchoolFeesPayment);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnExpensesRecord);
            this.panel1.Controls.Add(this.btnCourseForm);
            this.panel1.Controls.Add(this.btnStaffAttendance);
            this.panel1.Controls.Add(this.btnStaffRecord);
            this.panel1.Controls.Add(this.btnStudentRecord);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(-3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 713);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(132, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "WELCOME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(533, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "RIJAU, NIGER STATE.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(406, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(545, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "YELWA COLLEGE OF MEDICAL SCIENCES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(357, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(810, 46);
            this.label4.TabIndex = 31;
            this.label4.Text = "KNOWLEDGE COMES FROM LEARNING";
            // 
            // btnSchoolUnit
            // 
            this.btnSchoolUnit.BackColor = System.Drawing.Color.White;
            this.btnSchoolUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchoolUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnSchoolUnit.Image")));
            this.btnSchoolUnit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSchoolUnit.Location = new System.Drawing.Point(230, 503);
            this.btnSchoolUnit.Name = "btnSchoolUnit";
            this.btnSchoolUnit.Size = new System.Drawing.Size(163, 116);
            this.btnSchoolUnit.TabIndex = 30;
            this.btnSchoolUnit.Text = "SCHOOL UNITS";
            this.btnSchoolUnit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSchoolUnit.UseVisualStyleBackColor = false;
            // 
            // btnClinic
            // 
            this.btnClinic.BackColor = System.Drawing.Color.White;
            this.btnClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinic.Image = ((System.Drawing.Image)(resources.GetObject("btnClinic.Image")));
            this.btnClinic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClinic.Location = new System.Drawing.Point(419, 503);
            this.btnClinic.Name = "btnClinic";
            this.btnClinic.Size = new System.Drawing.Size(163, 116);
            this.btnClinic.TabIndex = 29;
            this.btnClinic.Text = "SETTINGS";
            this.btnClinic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClinic.UseVisualStyleBackColor = false;
            this.btnClinic.Click += new System.EventHandler(this.btnClinic_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.White;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecord.Location = new System.Drawing.Point(598, 503);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(163, 116);
            this.btnRecord.TabIndex = 28;
            this.btnRecord.Text = "REPORTS";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(985, 503);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 116);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "EXIT APPLICATION";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(790, 503);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 116);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaffLoan
            // 
            this.btnStaffLoan.BackColor = System.Drawing.Color.White;
            this.btnStaffLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffLoan.Image")));
            this.btnStaffLoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffLoan.Location = new System.Drawing.Point(985, 372);
            this.btnStaffLoan.Name = "btnStaffLoan";
            this.btnStaffLoan.Size = new System.Drawing.Size(163, 116);
            this.btnStaffLoan.TabIndex = 25;
            this.btnStaffLoan.Text = "STAFF SALARY";
            this.btnStaffLoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffLoan.UseVisualStyleBackColor = false;
            // 
            // btnSchoolFeesPayment
            // 
            this.btnSchoolFeesPayment.BackColor = System.Drawing.Color.White;
            this.btnSchoolFeesPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchoolFeesPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSchoolFeesPayment.Image")));
            this.btnSchoolFeesPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSchoolFeesPayment.Location = new System.Drawing.Point(790, 372);
            this.btnSchoolFeesPayment.Name = "btnSchoolFeesPayment";
            this.btnSchoolFeesPayment.Size = new System.Drawing.Size(163, 116);
            this.btnSchoolFeesPayment.TabIndex = 24;
            this.btnSchoolFeesPayment.Text = "SCHOOL FEES PAYMENT";
            this.btnSchoolFeesPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSchoolFeesPayment.UseVisualStyleBackColor = false;
            this.btnSchoolFeesPayment.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(598, 372);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 116);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "PRINT RECEIPT";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExpensesRecord
            // 
            this.btnExpensesRecord.BackColor = System.Drawing.Color.White;
            this.btnExpensesRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnExpensesRecord.Image")));
            this.btnExpensesRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpensesRecord.Location = new System.Drawing.Point(419, 372);
            this.btnExpensesRecord.Name = "btnExpensesRecord";
            this.btnExpensesRecord.Size = new System.Drawing.Size(163, 116);
            this.btnExpensesRecord.TabIndex = 22;
            this.btnExpensesRecord.Text = "EXPENSES RECORD";
            this.btnExpensesRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpensesRecord.UseVisualStyleBackColor = false;
            this.btnExpensesRecord.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCourseForm
            // 
            this.btnCourseForm.BackColor = System.Drawing.Color.White;
            this.btnCourseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseForm.Image")));
            this.btnCourseForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCourseForm.Location = new System.Drawing.Point(230, 372);
            this.btnCourseForm.Name = "btnCourseForm";
            this.btnCourseForm.Size = new System.Drawing.Size(163, 116);
            this.btnCourseForm.TabIndex = 21;
            this.btnCourseForm.Text = "STUDENT COURSE  FORM";
            this.btnCourseForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCourseForm.UseVisualStyleBackColor = false;
            this.btnCourseForm.Click += new System.EventHandler(this.btnCourseForm_Click);
            // 
            // btnStaffAttendance
            // 
            this.btnStaffAttendance.BackColor = System.Drawing.Color.White;
            this.btnStaffAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffAttendance.Image")));
            this.btnStaffAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffAttendance.Location = new System.Drawing.Point(985, 239);
            this.btnStaffAttendance.Name = "btnStaffAttendance";
            this.btnStaffAttendance.Size = new System.Drawing.Size(163, 116);
            this.btnStaffAttendance.TabIndex = 20;
            this.btnStaffAttendance.Text = "STAFF ATTENDANCE";
            this.btnStaffAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffAttendance.UseVisualStyleBackColor = false;
            this.btnStaffAttendance.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnStaffRecord
            // 
            this.btnStaffRecord.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnStaffRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffRecord.Image")));
            this.btnStaffRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffRecord.Location = new System.Drawing.Point(790, 239);
            this.btnStaffRecord.Name = "btnStaffRecord";
            this.btnStaffRecord.Size = new System.Drawing.Size(163, 116);
            this.btnStaffRecord.TabIndex = 19;
            this.btnStaffRecord.Text = "STAFF RECORD";
            this.btnStaffRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffRecord.UseVisualStyleBackColor = false;
            this.btnStaffRecord.Click += new System.EventHandler(this.btnStaffRecord_Click);
            // 
            // btnStudentRecord
            // 
            this.btnStudentRecord.BackColor = System.Drawing.Color.White;
            this.btnStudentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentRecord.Image")));
            this.btnStudentRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudentRecord.Location = new System.Drawing.Point(598, 239);
            this.btnStudentRecord.Name = "btnStudentRecord";
            this.btnStudentRecord.Size = new System.Drawing.Size(163, 116);
            this.btnStudentRecord.TabIndex = 18;
            this.btnStudentRecord.Text = "STUDENT RECORD";
            this.btnStudentRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentRecord.UseVisualStyleBackColor = false;
            this.btnStudentRecord.Click += new System.EventHandler(this.btnStudentRecord_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.White;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.Image")));
            this.btnAddStaff.Location = new System.Drawing.Point(419, 239);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(157, 116);
            this.btnAddStaff.TabIndex = 17;
            this.btnAddStaff.Text = "ADD STAFF";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1101, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "DATE:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.White;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStudent.Location = new System.Drawing.Point(230, 239);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(163, 116);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "ADD STUDENT";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1101, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "TIME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "WELCOME:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1204, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 17);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "DATE:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1204, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 17);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "TIME:";
            // 
            // mParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YELWA  COLLEGE OF MEDICAL SCIENCES SYSTEM SOFTWARE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mParent_FormClosing);
            this.Load += new System.EventHandler(this.mParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStaffAttendance;
        private System.Windows.Forms.Button btnStaffRecord;
        private System.Windows.Forms.Button btnStudentRecord;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem1;
        private System.Windows.Forms.Button btnSchoolUnit;
        private System.Windows.Forms.Button btnClinic;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStaffLoan;
        private System.Windows.Forms.Button btnSchoolFeesPayment;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExpensesRecord;
        private System.Windows.Forms.Button btnCourseForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}



