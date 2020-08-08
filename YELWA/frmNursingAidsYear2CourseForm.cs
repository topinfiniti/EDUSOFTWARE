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
    public partial class frmNursingAidsYear2CourseForm : Form
    {
        public frmNursingAidsYear2CourseForm()
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
            else if (cmbYear.SelectedIndex==0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Select year");
            }
            else if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDepartment, "Enter your Department");
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
       private void printingNursingAid2ndYear1stYearSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.yelqq;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 20, 45, newImage.Width, newImage.Height);

            e.Graphics.DrawString("YELWA COLLEGE OF MEDICAL SCIENCES", new Font("Adobe Ming Std L", 20, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            e.Graphics.DrawString("RIJAU, NIGER STATE ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(370, 50));
            e.Graphics.DrawString("2019/2020 Academic Session", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 95));
            e.Graphics.DrawString("(OFFICE OF REGISTRAR: ACADEMIC DIVISION)", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(260, 130));
            e.Graphics.DrawString("COURSE FORM REGISTRATION", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 190));
            e.Graphics.DrawString("STUDENT NAME:        " + txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 240));
            e.Graphics.DrawString(" YEAR:                           2               ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 280));
            e.Graphics.DrawString("DEPARTMENT:             NURSING AIDS      ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("FIRST SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 400));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                        COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 440));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            e.Graphics.DrawString("Basic Human Nutrition", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 480));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("Communicable & Non-Communicable Diseases", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 550));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 550));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 620));
            e.Graphics.DrawString("Clinical Procedure", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 620));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 620));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 690));
            e.Graphics.DrawString("School Health Services", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 690));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 690));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50,760));
            e.Graphics.DrawString("Management & Essential Drugs", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 760));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 760));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 830));
            e.Graphics.DrawString("Family  Planning", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 830));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 830));
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(330, 870));
            e.Graphics.DrawString("14", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 870));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 950));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 970));
            e.Graphics.DrawString("Powered by YELWA C.M.S ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        }

        private void printingNursingAid2ndYear2ndYearSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.yelqq;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 20, 15, newImage.Width, newImage.Height);

            e.Graphics.DrawString("YELWA COLLEGE OF MEDICAL SCIENCES", new Font("Adobe Ming Std L", 20, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            e.Graphics.DrawString("RIJAU, NIGER STATE ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(370, 50));
            e.Graphics.DrawString("2019/2020 Academic Session", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 95));
            e.Graphics.DrawString("(OFFICE OF REGISTRAR: ACADEMIC DIVISION)", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(260, 130));
            e.Graphics.DrawString("COURSE FORM REGISTRATION", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 190));
            e.Graphics.DrawString("STUDENT NAME:       " + txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 240));
            e.Graphics.DrawString("YEAR:                            2              ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 280));
            e.Graphics.DrawString("DEPARTMENT:             NURSING AIDS     ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("SECOND SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 400));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                         COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 440));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            e.Graphics.DrawString("Medical Laboratory Practices", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("4", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 480));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 565));
            e.Graphics.DrawString("Clinical Skills", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 565));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 565));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 655));
            e.Graphics.DrawString("Medical Terminology", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 655));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 655));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 745));
            e.Graphics.DrawString("Occupational Health & Safety", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 745));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 745));
            e.Graphics.DrawString("*****", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 835));
            e.Graphics.DrawString("Maternal & Child Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 835));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 835));
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(330, 870));
            e.Graphics.DrawString("13", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 870));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 950));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 970));
            e.Graphics.DrawString("Powered by YCMS ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        
        }

        private void frmNursingAidsYear2CourseForm_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
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
