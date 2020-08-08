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
    public partial class frmMedicalYear1CourseForm : Form
    {
        public frmMedicalYear1CourseForm()
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
                errorProvider1.SetError(txtDepartment, "Enter your department");
            }
            else if (cmbYear.SelectedIndex==0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Please select year");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
       

        private void printMedical1stYear1stSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            e.Graphics.DrawString("YEAR:                           1               ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 280));
            e.Graphics.DrawString("DEPARTMENT:            MEDICAL LABORATORY SCIENCE    ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("FIRST SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 400));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                        COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 440));
            e.Graphics.DrawString("ELS101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            e.Graphics.DrawString("Communication Skills I", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 480));
            e.Graphics.DrawString("CSC101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 520));
            e.Graphics.DrawString("Introduction to IT I", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 520));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 520));
            e.Graphics.DrawString("BIO101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 560));
            e.Graphics.DrawString("General Biology I", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 560));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 560));
            e.Graphics.DrawString("CHM101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 600));
            e.Graphics.DrawString("General Chemistry", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 600));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 600));
            e.Graphics.DrawString("MTH101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 640));
            e.Graphics.DrawString("General Mathematics I", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 640));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 640));
            e.Graphics.DrawString("GST101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 680));
            e.Graphics.DrawString("Citizenship Education", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 680));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 680));
            e.Graphics.DrawString("GST103", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            e.Graphics.DrawString("History and Philosophy of Science", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 720));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 720));
            e.Graphics.DrawString("EHT101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 760));
            e.Graphics.DrawString("Introduction to Environmental Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 760));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 760));
            e.Graphics.DrawString("FRN101", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 800));
            e.Graphics.DrawString("Functional French I", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 800));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 800));
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(330, 835));
            e.Graphics.DrawString("20", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 835));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 950));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 970));
            e.Graphics.DrawString("Powered by YELWA C.M.S ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        }

        private void PrintMedical1stYear2ndSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            e.Graphics.DrawString("YEAR:                           1       ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 280));
            e.Graphics.DrawString("DEPARTMENT:           MEDICAL LABORATORY SCIENCE", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("SECOND SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 400));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                         COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 440));
            e.Graphics.DrawString("ELS102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            e.Graphics.DrawString("Communication Skills II", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 480));
            e.Graphics.DrawString("CSC102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 520));
            e.Graphics.DrawString("Introduction to IT II", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 520));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 520));
            e.Graphics.DrawString("BIO102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 560));
            e.Graphics.DrawString("General Biology II", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 560));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 560));
            e.Graphics.DrawString("CHM102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 600));
            e.Graphics.DrawString("Organic Chemistry", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 600));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 600));
            e.Graphics.DrawString("MTH102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 640));
            e.Graphics.DrawString("General Mathematics II", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 640));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 640));
            e.Graphics.DrawString("FAP102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 680));
            e.Graphics.DrawString("First Aid and Primary Healthcare", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 680));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 680));
            e.Graphics.DrawString("GST102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            e.Graphics.DrawString("Philosophy & Logic/Critical Reasoning", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 720));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 720));
            e.Graphics.DrawString("FRN102", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 760));
            e.Graphics.DrawString("Functional French II", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 760));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 760));
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(330, 795));
            e.Graphics.DrawString("18", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 795));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 950));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 970));
            e.Graphics.DrawString("Powered by YELWA C.M.S ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
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
        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void frmMedicalYear1CourseForm_Load(object sender, EventArgs e)
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
