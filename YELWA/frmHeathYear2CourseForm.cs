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
    public partial class frmHeathYear2CourseForm : Form
    {
        public frmHeathYear2CourseForm()
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
            else if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Enter your Department");
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
       
        private void printHealth2ndYear1stSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            e.Graphics.DrawString("YEAR:                            2               ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 280));
            e.Graphics.DrawString("DEPARTMENT:             HEALTH EDUCATION ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("FIRST SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 400));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                         COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 440));
            e.Graphics.DrawString("HED211", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            e.Graphics.DrawString("Health Exhibition", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 480));
            e.Graphics.DrawString("HED212", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 530));
            e.Graphics.DrawString("Developmental Psychology", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 530));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 530));
            e.Graphics.DrawString("HED213", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 580));
            e.Graphics.DrawString("Basic Vital Stattistics and Hospital Record", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 580));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 580));
            e.Graphics.DrawString("HED214", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 630));
            e.Graphics.DrawString("Nutrional Health", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 630));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 630));
            e.Graphics.DrawString("HED215", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 680));
            e.Graphics.DrawString("Health Communication", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 680));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 680));
            e.Graphics.DrawString("HED216", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 730));
            e.Graphics.DrawString("Hospital Waste Management Techniques", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 730));
            e.Graphics.DrawString("1", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 730));
            e.Graphics.DrawString("HED217", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 780));
            e.Graphics.DrawString("Occupational Industrial Safety", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 780));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 780));
            e.Graphics.DrawString("GSE210", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 830));
            e.Graphics.DrawString("Use of English II", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 830));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 830));
            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(330, 870));
            e.Graphics.DrawString("16", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 870));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 950));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 970));
            e.Graphics.DrawString("Powered by YCMS ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        }

        private void printHealth2ndYear2ndSemester(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            e.Graphics.DrawString("YEAR:                            2               ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("DATE:    " + DateTime.Now, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 280));
            e.Graphics.DrawString("DEPARTMENT:            HEALTH EDUCATION      ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("MATRIC NUMBER:       " + txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString("SECOND SEMESTER ", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(370, 400));
            e.Graphics.DrawString("  COURSE CODE                    COURSE TITLE                        COURSE UNIT", new Font("Carmina Md BT", 15, FontStyle.Bold), Brushes.Black, new Point(20, 440));
            e.Graphics.DrawString("HED221", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            e.Graphics.DrawString("Health Practicum", new Font("Calibri (Body) BT", 15, FontStyle.Regular), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("3", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 480));
            e.Graphics.DrawString("HED222", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 530));
            e.Graphics.DrawString("Research For Health Care Professions", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 530));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 530));
            e.Graphics.DrawString("HED223", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 580));
            e.Graphics.DrawString("Contemporary Health Issues", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 580));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 580));
            e.Graphics.DrawString("HED224", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 630));
            e.Graphics.DrawString("Substance Use and Abuse", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 630));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 630));
            e.Graphics.DrawString("HED225", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 680));
            e.Graphics.DrawString("Human Anatomy and Physiology", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 680));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 680));
            e.Graphics.DrawString("HED226", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 730));
            e.Graphics.DrawString("Health Administration and Management", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 730));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 730));
            e.Graphics.DrawString("HED227", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(50, 780));
            e.Graphics.DrawString("Family Health Education", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(250, 780));
            e.Graphics.DrawString("2", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(750, 780));

            e.Graphics.DrawString("TOTAL", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(330, 810));
            e.Graphics.DrawString("16", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(740, 810));
            e.Graphics.DrawString("----------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(40, 950));
            e.Graphics.DrawString("---------------------------------------", new Font("Calibri (Body)", 15, FontStyle.Regular), Brushes.Black, new Point(520, 950));
            e.Graphics.DrawString("STUDENT'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("HOD'S SIGNATURE/DATE", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(520, 970));
            e.Graphics.DrawString("Powered by YCMS ICT Unit", new Font("Calibri (Body)", 9, FontStyle.Italic), Brushes.Black, new Point(20, 1050));
        }

        private void frmHeathYear2CourseForm_Load(object sender, EventArgs e)
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
