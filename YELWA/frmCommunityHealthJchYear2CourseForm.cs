using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace YELWA
{
    public partial class frmCommunityHealthJchYear2CourseForm : Form
    {
        public frmCommunityHealthJchYear2CourseForm()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtMatricNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMatricNumber, " Enter your matric number");
            }
            else if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Enter your full name");
            }
               else if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDepartment, "Enter your Department");
            }
                else if (cmbYear.SelectedIndex==0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Select Year");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private bool IfUserExist(string name, string matricnumber)
        {
            connection con = new connection();
            con.dataGet("select 1 from courseform where studentname = '" + name + "' or matricnumber= '" + matricnumber + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void btnHealth_Click(object sender, EventArgs e)
        {
            
        }


        private void printCommunityHealthJch2ndYear1stSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.yelqq;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 20, 45, newImage.Width, newImage.Height);

            e.Graphics.DrawString("YELWA COLLEGE OF MEDICAL SCIENCES", new Font("Adobe Ming Std L", 20, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            e.Graphics.DrawString("RIJAU, NIGER STATE ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(370, 50));
            e.Graphics.DrawString("2019/2020 Academic Session", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 95));
            e.Graphics.DrawString("(OFFICE OF REGISTRAR: ACADEMIC DIVISION)", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(260, 130));
            e.Graphics.DrawString("COURSE FORM REGISTRATION", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 160));
            e.Graphics.DrawString("STUDENT NAME:        " + txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 220));
            e.Graphics.DrawString("YEAR:                             2 ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(450, 260));
            e.Graphics.DrawString("DEPARTMENT:              COMMUNITY HEALTH (JCHEW)        ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("FIRST SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 420));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                         COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 460));
            e.Graphics.DrawString("JCH131", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 510));
            e.Graphics.DrawString("Primary Eye Care", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 510));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 510));
            e.Graphics.DrawString("JCH132", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 540));
            e.Graphics.DrawString("Primary Ear, Nose and Throat (ENT)", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 540));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 540));
            e.Graphics.DrawString("JCH133", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 570));
            e.Graphics.DrawString("Oral Health Care", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 570));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 570));
            e.Graphics.DrawString("JCH134", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 600));
            e.Graphics.DrawString("Child Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 600));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 600));
            e.Graphics.DrawString("JCH135", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 630));
            e.Graphics.DrawString("Family Planning", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 630));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 630));
            e.Graphics.DrawString("JCH136", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 660));
            e.Graphics.DrawString("Community Mental Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 660));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 660));
            e.Graphics.DrawString("JCH137", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 690));
            e.Graphics.DrawString("Non-Communicable Diseases", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 690));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 690));
            e.Graphics.DrawString("JCH138", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            e.Graphics.DrawString("Principles of Primary Health Care", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 720));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 720));
            e.Graphics.DrawString("JCH139", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 750));
            e.Graphics.DrawString("Community Based Newborn Care", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 750));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 750));
            e.Graphics.DrawString("JCH140", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 780));
            e.Graphics.DrawString("Supervised Community-Based Experience ", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 780));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 780));
            e.Graphics.DrawString("JCH141", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 810));
            e.Graphics.DrawString("Use of Standing Order ", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 810));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 810));
            e.Graphics.DrawString("EHT111", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 840));
            e.Graphics.DrawString("Introduction to Environmental Health ", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 840));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 840));
          
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(350, 880));
            e.Graphics.DrawString("25", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 880));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 980));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 980));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1000));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 1000));
            e.Graphics.DrawString("Powered by YCMS ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        }

        private void printCommunityHealthJch2ndYear2ndSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = Properties.Resources.yelqq;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 20, 45, newImage.Width, newImage.Height);

            e.Graphics.DrawString("YELWA COLLEGE OF MEDICAL SCIENCES", new Font("Adobe Ming Std L", 20, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            e.Graphics.DrawString("RIJAU, NIGER STATE ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(370, 50));
            e.Graphics.DrawString("2019/2020 Academic Session", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 95));
            e.Graphics.DrawString("(OFFICE OF REGISTRAR: ACADEMIC DIVISION)", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(260, 130));
            e.Graphics.DrawString("COURSE FORM REGISTRATION", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 160));
            e.Graphics.DrawString("STUDENT NAME:         " + txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 220));
            e.Graphics.DrawString("YEAR:                             2 ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(450, 260));
            e.Graphics.DrawString("DEPARTMENT:             COMMUNITY HEALTH (JCHEW)        ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("FIRST SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 420));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                         COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 460));
            e.Graphics.DrawString("JCH142", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 510));
            e.Graphics.DrawString("School Health Programme", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 510));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 510));
            e.Graphics.DrawString("JCH143", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 540));
            e.Graphics.DrawString("Adolescent Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 540));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 540));
            e.Graphics.DrawString("JCH144", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 570));
            e.Graphics.DrawString("Adult Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 570));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 570));
            e.Graphics.DrawString("JCH145", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 600));
            e.Graphics.DrawString("Care of Persons With Special Needs", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 600));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 600));
            e.Graphics.DrawString("JCH146", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 630));
            e.Graphics.DrawString("Care of the Older People", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 630));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 630));
            e.Graphics.DrawString("JCH147", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 660));
            e.Graphics.DrawString("Essential Medicines", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 660));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 660));
            e.Graphics.DrawString("JCH148", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 690));
            e.Graphics.DrawString("Health Management Information System", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 690));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 690));
            e.Graphics.DrawString("JCH149", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            e.Graphics.DrawString("Occupational Health and Safety Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 720));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 720));
            e.Graphics.DrawString("JCH150", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 750));
            e.Graphics.DrawString("Care and Management of HIV and AIDS", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 750));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 750));
            e.Graphics.DrawString("JCH151", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 780));
            e.Graphics.DrawString("Human Resourced for Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 780));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 780));
            e.Graphics.DrawString("JCH152", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 810));
            e.Graphics.DrawString("Referrals and Outreacg Services ", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 810));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 810));
            e.Graphics.DrawString("JCH153", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 840));
            e.Graphics.DrawString("Family Case Study ", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 840));
            e.Graphics.DrawString("4", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 840));
            
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(350, 870));
            e.Graphics.DrawString("21", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 870));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 980));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 980));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1000));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 1000));
            e.Graphics.DrawString("Powered by YCMS ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        }

        private void frmCommunityHealthJchYear2CourseForm_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {

                if (IfUserExist(txtFullName.Text, txtMatricNumber.Text))
                {
                    MessageBox.Show(" Student has already done course registration", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDepartment.Clear();
                    txtFullName.Clear();
                    txtMatricNumber.Clear();
                    cmbYear.SelectedIndex = 0;
                    this.ActiveControl = txtFullName;

                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("PROCEED TO REGISTRATION", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogresult == DialogResult.Yes)
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                        printPreviewDialog2.Document = printDocument2;
                        printPreviewDialog2.ShowDialog();
                        MessageBox.Show("COURSE REGISTRATION DONE", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            string connectionString2 = null;

                            connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                            string Query = "INSERT into courseform (studentname, matricnumber, year, department) values ('" + txtFullName.Text.ToUpper() + " ','" + txtMatricNumber.Text.ToUpper() + " ', '" + cmbYear.SelectedItem + "', '" + txtDepartment.Text.ToUpper() + "')";
                            MySqlConnection con = new MySqlConnection(connectionString2);
                            MySqlCommand command = new MySqlCommand(Query, con);
                            MySqlDataReader reader;
                            con.Open();
                            reader = command.ExecuteReader();
                            txtFullName.Clear();
                            txtDepartment.Clear();
                            txtMatricNumber.Clear();
                            cmbYear.SelectedIndex = 0;

                            while (reader.Read())
                            {

                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
