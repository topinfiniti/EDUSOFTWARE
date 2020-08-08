using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YELWA
{
    public partial class mParent : Form
    {


        public mParent()
        {
            InitializeComponent();
            Settooltip();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to exit?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {
                Form1 nn = new Form1();
                this.Close();
            }
        }

        private void mParent_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString("MM/dd/yyy hh:mm:ss");
            timer2.Enabled = true;
            timer2.Interval = 5;
            label9.Text = user_info.username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString("HH:mm:ss");
            DateTime date = DateTime.Now;
            this.lblDate.Text = date.ToString("MM-dd-yyy");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label4.Left < 0 && (Math.Abs(label4.Left) > label4.Width))
                label4.Left = this.Width;
            label4.Left -= 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("DO YOU WANT LOG OUT?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {
                Form1 nn = new Form1();
                this.Hide();
                nn.ShowDialog();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("EXIT THE APPLICATION?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStaffAttendance nn = new frmStaffAttendance();
            nn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStaff nn = new frmStaff();
            nn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddStudent nn = new frmAddStudent();
            nn.ShowDialog();
        }

        private void btnCourseForm_Click(object sender, EventArgs e)
        {
            frmCourseRegister nn = new frmCourseRegister();
            nn.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReceipt nn = new frmReceipt();
            nn.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmExpenses mm = new frmExpenses();
            mm.Show();
        }

        private void addNewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewUser bb = new frmAddNewUser();
            bb.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword nn = new frmChangePassword();
            nn.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSchoolFeePayment oo = new frmSchoolFeePayment();
            oo.ShowDialog();
        }
        private void Settooltip()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btnRecord, "Show all school record");
            tip.SetToolTip(this.btnStudentRecord, "Show all student record");
            tip.SetToolTip(this.btnSchoolFeesPayment, "Pay school");
            tip.SetToolTip(this.btnSchoolUnit, "show all school unit information");
            tip.SetToolTip(this.btnAddStaff, "Add a new staff");
            tip.SetToolTip(this.btnAddStudent, "Add a new student");
            tip.SetToolTip(this.btnCourseForm, "Course form registration");
            tip.SetToolTip(this.btnLogout, "Log out your account");
            tip.SetToolTip(this.btnPrint, "Print your receipt");
            tip.SetToolTip(this.btnStaffAttendance, "Daily staff attendance");
            tip.SetToolTip(this.btnStaffRecord, "Show staff record");
            tip.SetToolTip(this.btnStaffLoan, "Staff salary management");
            tip.SetToolTip(this.btnExit, "Exit the application");
            tip.SetToolTip(this.btnRecord, "Show all school record");
            tip.SetToolTip(this.btnExpensesRecord, "Record all expenses in school");
            tip.SetToolTip(this.btnClinic, "show clinic record");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout nn = new frmAbout();
            nn.Show();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            frmAllRecord nn = new frmAllRecord();
            nn.ShowDialog();
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            frmStudentRecord nn = new frmStudentRecord();
            nn.ShowDialog();
        }

        private void btnStaffRecord_Click(object sender, EventArgs e)
        {
            frmStaffRecord nn = new frmStaffRecord();
            nn.ShowDialog();
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {

        }
        bool close = true;

        private void mParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to exit the Application?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
            }
        }
        }
    }


        
