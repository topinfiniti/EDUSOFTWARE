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
using System.IO;
namespace YELWA
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, " Enter your full name");
            }
            else if (cmbCourse.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbCourse, "choose a course");
            }
            else if (cmbProgramme.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbProgramme, "kindly choose your programme course");
            }

            else if (string.IsNullOrEmpty(txtJambRegistrationNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambRegistrationNumber, "Enter your jamb registration number");
            }
            else if (string.IsNullOrEmpty(txtParentNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtParentNumber, "Type your parent number");
            }
            else if (cmbYear.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "kindly select the result year");
            }
            else if (cmbExamType.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbExamType, "kindly choose your exam type");
            }
            else if (string.IsNullOrEmpty(txtExamNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtExamNumber, "Enter your exam/registration number");
            }
            else if (string.IsNullOrEmpty(txtJambSubject2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambSubject2, "Enter your jamb subject");
            }
            else if (string.IsNullOrEmpty(txtJambEnglishScore.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambEnglishScore, "Enter your score");
            }

            else if (cmbEnglishGrade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbEnglishGrade, "kindly choose your grade");
            }
            else if (cmbMathGrade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMathGrade, "kindly choose your grade");
            }

            else if (cmbSubject3Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject3Grade, "kindly choose your grade");
            }
            else if (cmbLevel.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbLevel, "kindly choose your level");
            }
            else if (cmbProgramme.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbProgramme, "kindly choose your programme");
            }
            else if (cmbMaritalStatus.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMaritalStatus, "kindly choose your marital status");
            }
            else if (cmbGenotype.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGenotype, "kindly choose your grade");
            }
            else if (cmbBloodGroup.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbBloodGroup, "kindly choose your blood group");
            }
            else if (cmbMaritalStatus.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMaritalStatus, "kindly choose your grade");
            }
            else if (cmbSubject4Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject4Grade, "kindly choose your grade");
            }
            else if (cmbSubject5Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject5Grade, "kindly choose your grade");
            }
            else if (cmbSubject6Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject6Grade, "kindly choose your grade");
            }
            else if (cmbSubject7Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject7Grade, "kindly choose your grade");
            }
            else if (cmbSubject9Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject9Grade, "kindly choose your grade");
            }
            else if (cmbSubject8Grade.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbSubject8Grade, "kindly choose your grade");
            }

            else if (cmbBloodGroup.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbBloodGroup, "kindly choose your gender");
            }
            else if (cmbStateOfOrigin.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbStateOfOrigin, "kindly choose your state of origin");
            }
            else if (cmbCourse.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbCourse, "kindly choose your course");
            }
            else if (cmbNumberOfSitting.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbNumberOfSitting, "kindly choose your number of sitting");
            }
            else if (string.IsNullOrEmpty(txtsubject3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtsubject3, "kindly fill the subject taken here");
            }
            else if (txtStateLga.Text.Length > 50)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtStateLga, "Not more than 50 characters");
            }
            else if (string.IsNullOrEmpty(txtsubject4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtsubject4, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtsubject5.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtsubject5, "kindly fill the subject taken here");
            }

            else if (string.IsNullOrEmpty(txtJambSubject3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambSubject3, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtJambSubject4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambSubject4, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtSubject6.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSubject6, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtSubject7.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSubject7, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtSubject8.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSubject8, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtSubject9.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSubject9, "kindly fill the subject taken here");
            }
            else if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPhoneNumber, "kindly fill your number");
            }
            else if (string.IsNullOrEmpty(txtResidentialAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtResidentialAddress, "kindly fill in your current contact address");
            }
            else if (string.IsNullOrEmpty(txtResidentialAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtResidentialAddress, "Not more than 50 characters");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "kindly enter your email");
            }
            else if (string.IsNullOrEmpty(txtStateLga.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtStateLga, "kindly enter your State of origin local govt. area");
            }


            else if (txtParentNumber.Text.Length > 11)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtParentNumber, "Not more than 11 characters");
            }
            else if (txtPhoneNumber.Text.Length > 11)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPhoneNumber, "Not more than 11 characters");
            }
            else if (string.IsNullOrEmpty(txtJambSubject2Score.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambSubject2Score, "please enter the subject score");
            }
            else if (string.IsNullOrEmpty(txtJambSubject3Score.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambSubject3Score, "please enter the subject score");
            }
            else if (string.IsNullOrEmpty(txtJambSubject4Score.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtJambSubject4Score, "please enter the subject score");
            }

            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            cmbMaritalStatus.SelectedIndex = 0;
            cmbGenotype.SelectedIndex = 0;
            cmbStateOfOrigin.SelectedIndex = 0;
            cmbBloodGroup.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;
            cmbBloodGroup.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbCourse.SelectedIndex = 0;
            cmbEnglishGrade.SelectedIndex = 0;
            cmbExamType.SelectedIndex = 0;
            cmbMathGrade.SelectedIndex = 0;
            cmbNumberOfSitting.SelectedIndex = 0;
            cmbProgramme.SelectedIndex = 0;
            cmbSubject3Grade.SelectedIndex = 0;
            cmbSubject4Grade.SelectedIndex = 0;
            cmbSubject5Grade.SelectedIndex = 0;
            cmbSubject6Grade.SelectedIndex = 0;
            cmbSubject7Grade.SelectedIndex = 0;
            cmbSubject7Grade.SelectedIndex = 0;
            cmbSubject8Grade.SelectedIndex = 0;
            cmbSubject9Grade.SelectedIndex = 0;
            ActiveControl = txtName;

        }


        private void txtJambSubject2Score_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtParentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private bool IfUserExist(string name, string email)
        {
            connection con = new connection();
            con.dataGet("select 1 from admission2 where studentname = '" + name + "' or email = '" + email + "' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }string fileName;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    label22.Text = fileName;
                    pictureBox1.Image = Image.FromFile(fileName);
                }
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (IfUserExist(txtName.Text, txtEmail.Text))
                {
                    MessageBox.Show(" STUDENT HAS FILLED THE FORM ALREADY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("SUBMIT DATA?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogresult == DialogResult.Yes)
                    {
                        string connectionString2 = null;
                        connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";

                        MySqlConnection con = new MySqlConnection(connectionString2);
                        MySqlCommand cmd;
                        FileStream fs;
                        BinaryReader br;

                        try
                        {
                            int a;
                            a = Int32.Parse(txtJambEnglishScore.Text) + Int32.Parse(txtJambSubject2Score.Text) + Int32.Parse(txtJambSubject3Score.Text) + Int32.Parse(txtJambSubject4Score.Text);
                            label43.Text = a.ToString();
                            string FileName = label22.Text;
                            byte[] ImageData;
                            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                            br = new BinaryReader(fs);
                            ImageData = br.ReadBytes((int)fs.Length);
                            br.Close();
                            fs.Close();

                            string CmdString = "INSERT INTO admission2 (studentname, dateofbirth, gender, image, phonenumber,email, bloodgroup, genotype, stateoforigin, statelga, maritalstatus, parentnumber, residentialaddress, programme, course, years, jambregistrationnumber, jambenglishscore, jambsubj2, jambsubj2score, jambsubj3, jambsubj3score, jambsubj4, jambsubj4score, jambtotal, examyear, numberofsitting, examtype, centrenumber, englishgrade, mathematicsgrade, subj3, subj3grade, subj4, subj4grade, subj5, subj5grade, subj6, subj6grade,  subj7, subj7grade,  subj8, subj8grade,  subj9, subj9grade) VALUES (@studentname, @dateofbirth, @gender, @image, @phonenumber, @email, @bloodgroup, @genotype, @stateoforigin, @statelga, @maritalstatus, @parentnumber, @residentialaddress, @programme, @course, @years, @jambregistrationnumber, @jambenglishscore, @jambsubj2, @jambsubj2score, @jambsubj3, @jambsubj3score, @jambsubj4, @jambsubj4score, @jambtotal, @examyear, @numberofsitting, @examtype, @centrenumber, @englishgrade, @mathematicsgrade, @subj3, @subj3grade, @subj4, @subj4grade, @subj5, @subj5grade, @subj6, @subj6grade, @subj7, @subj7grade,  @subj8, @subj8grade,  @subj9, @subj9grade)";
                            cmd = new MySqlCommand(CmdString, con);
                            cmd.Parameters.Add("@studentname", MySqlDbType.VarChar, 45);
                            cmd.Parameters.Add("@dateofbirth", MySqlDbType.VarChar, 45);
                            cmd.Parameters.Add("@gender", MySqlDbType.VarChar, 46);
                            cmd.Parameters.Add("@image", MySqlDbType.MediumBlob);
                            cmd.Parameters.Add("@phonenumber", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@bloodgroup", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@genotype", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@stateoforigin", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@statelga", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@maritalstatus", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@parentnumber", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@residentialaddress", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@programme", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@course", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@years", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambregistrationnumber", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambenglishscore", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambsubj2", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambsubj2score", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambsubj3", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambsubj3score", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambsubj4", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambsubj4score", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@jambtotal", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@examyear", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@numberofsitting", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@examtype", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@centrenumber", MySqlDbType.VarChar, 22);
                            // cmd.Parameters.Add("@centrenumber", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@englishgrade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@mathematicsgrade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj3", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj3grade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj4", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj4grade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj5", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj5grade", MySqlDbType.VarChar, 22);
                            //cmd.Parameters.Add("@subj6", MySqlDbType.VarChar, 22);
                            //cmd.Parameters.Add("@subj6grade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj6", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj6grade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj7", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj7grade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj8", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj8grade", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj9", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@subj9grade", MySqlDbType.VarChar, 22);

                            cmd.Parameters["@studentname"].Value = txtName.Text.ToUpper();
                            cmd.Parameters["@dateofbirth"].Value = dtpDob.Value.ToString("yyyy/MM/dd");
                            cmd.Parameters["@gender"].Value = cmbGender.SelectedItem;
                            cmd.Parameters["@Image"].Value = ImageData;
                            cmd.Parameters["@phonenumber"].Value = txtPhoneNumber.Text;
                            cmd.Parameters["@email"].Value = txtEmail.Text.ToUpper();
                            cmd.Parameters["@bloodgroup"].Value = cmbBloodGroup.SelectedItem;
                            cmd.Parameters["@genotype"].Value = cmbGenotype.SelectedItem;
                            cmd.Parameters["@stateoforigin"].Value = cmbStateOfOrigin.SelectedItem;
                            cmd.Parameters["@statelga"].Value = cmbGenotype.SelectedItem;
                            cmd.Parameters["@maritalstatus"].Value = cmbMaritalStatus.SelectedItem;
                            cmd.Parameters["@parentnumber"].Value = txtParentNumber.Text;
                            cmd.Parameters["@residentialaddress"].Value = cmbMaritalStatus.SelectedItem;
                            cmd.Parameters["@programme"].Value = cmbProgramme.SelectedItem;
                            cmd.Parameters["@course"].Value = cmbCourse.SelectedItem;
                            cmd.Parameters["@years"].Value = cmbLevel.SelectedItem;
                            cmd.Parameters["@jambregistrationnumber"].Value = txtJambRegistrationNumber.Text.ToUpper();
                            cmd.Parameters["@jambenglishscore"].Value = txtJambEnglishScore.Text.ToUpper();
                            cmd.Parameters["@jambsubj2"].Value = txtJambSubject2.Text.ToUpper();
                            cmd.Parameters["@jambsubj2score"].Value = txtJambSubject2Score.Text;
                            cmd.Parameters["@jambsubj3"].Value = txtJambSubject3.Text.ToUpper();
                            cmd.Parameters["@jambsubj3score"].Value = txtJambSubject3Score.Text;
                            cmd.Parameters["@jambsubj4"].Value = txtJambSubject4.Text.ToUpper();
                            cmd.Parameters["@jambsubj4score"].Value = txtJambSubject4Score.Text;
                            cmd.Parameters["@jambtotal"].Value = label43.Text;
                            cmd.Parameters["@examyear"].Value = cmbYear.SelectedItem;
                            cmd.Parameters["@numberofsitting"].Value = cmbNumberOfSitting.SelectedItem;
                            cmd.Parameters["@examtype"].Value = cmbExamType.SelectedItem;
                            cmd.Parameters["@centrenumber"].Value = txtExamNumber.Text.ToUpper();
                            cmd.Parameters["@englishgrade"].Value = cmbEnglishGrade.SelectedItem;
                            cmd.Parameters["@mathematicsgrade"].Value = cmbMathGrade.SelectedItem;
                            cmd.Parameters["@subj3"].Value = txtsubject3.Text.ToUpper();
                            cmd.Parameters["@subj3grade"].Value = cmbSubject3Grade.SelectedItem;
                            cmd.Parameters["@subj4"].Value = txtsubject4.Text.ToUpper();
                            cmd.Parameters["@subj4grade"].Value = cmbSubject4Grade.SelectedItem;
                            cmd.Parameters["@subj5"].Value = txtsubject5.Text.ToUpper();
                            cmd.Parameters["@subj5grade"].Value = cmbSubject5Grade.SelectedItem;
                            cmd.Parameters["@subj6"].Value = txtSubject6.Text.ToUpper();
                            cmd.Parameters["@subj6grade"].Value = cmbSubject6Grade.SelectedItem;
                            cmd.Parameters["@subj7"].Value = txtSubject7.Text.ToUpper();
                            cmd.Parameters["@subj7grade"].Value = cmbSubject7Grade.SelectedItem;
                            cmd.Parameters["@subj8"].Value = txtSubject6.Text.ToUpper();
                            cmd.Parameters["@subj8grade"].Value = cmbSubject6Grade.SelectedItem;
                            cmd.Parameters["@subj9"].Value = txtSubject9.Text.ToUpper();
                            cmd.Parameters["@subj9grade"].Value = cmbSubject9Grade.SelectedItem;
                            con.Open();
                            int RowsAffected = cmd.ExecuteNonQuery();
                            if (RowsAffected > 0)
                            {
                                MessageBox.Show("STUDENT DATA SUBMITTED SUCESSFULLY!", "CONGRATULATIONS");
                                printPreviewDialog1.Document = printDocument1;
                                printPreviewDialog1.ShowDialog();
                                txtEmail.Text = txtExamNumber.Text = txtJambEnglishScore.Text = txtJambRegistrationNumber.Text = txtJambSubject2.Text = txtJambSubject2Score.Text = txtJambSubject3.Text = txtJambSubject3Score.Text = txtJambSubject4.Text = txtJambSubject4Score.Text = txtName.Text = txtParentNumber.Text = txtPhoneNumber.Text = txtResidentialAddress.Text = txtStateLga.Text = txtsubject3.Text = txtsubject4.Text = txtsubject5.Text = txtSubject6.Text = txtSubject7.Text = txtSubject8.Text = txtSubject9.Text = "";
                                cmbBloodGroup.SelectedIndex = cmbCourse.SelectedIndex = cmbEnglishGrade.SelectedIndex = cmbExamType.SelectedIndex = cmbGender.SelectedIndex = cmbLevel.SelectedIndex = cmbMaritalStatus.SelectedIndex = cmbMathGrade.SelectedIndex = cmbNumberOfSitting.SelectedIndex = cmbProgramme.SelectedIndex = cmbStateOfOrigin.SelectedIndex = cmbSubject3Grade.SelectedIndex = cmbSubject4Grade.SelectedIndex = cmbSubject5Grade.SelectedIndex = cmbSubject6Grade.SelectedIndex = cmbSubject7Grade.SelectedIndex = cmbSubject8Grade.SelectedIndex = cmbSubject9Grade.SelectedIndex = cmbYear.SelectedIndex = 0;
                                dtpDob.Value = DateTime.Now;
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
        
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.yelqq;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 300, 45, newImage.Width, newImage.Height);

            e.Graphics.DrawString("YELWA COLLEGE OF MEDICAL SCIENCES, RIJAU, NIGER STATE", new Font("Adobe Ming Std L", 15, FontStyle.Bold), Brushes.Black, new Point(40, 10));
            e.Graphics.DrawString("2019/2020 Academic Session", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 200));
            e.Graphics.DrawString("(OFFICE OF REGISTRAR: ACADEMIC DIVISION)", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(180, 230));
            e.Graphics.DrawString("STUDENT DETAILS(CLEARANCE SLIP)", new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(300, 270));
            e.Graphics.DrawString("STUDENT NAME:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 310));
            e.Graphics.DrawString(txtName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(220, 310));
            e.Graphics.DrawString("DATE OF BIRTH:      ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 340));
            e.Graphics.DrawString(dtpDob.Value.ToString("dd/mm//yyy"), new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(220, 340));
            e.Graphics.DrawString("PHONE NUMBER: ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString(txtPhoneNumber.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(220, 370));
            e.Graphics.DrawString("BLOOD GROUP: ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString(cmbBloodGroup.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(220, 400));
            e.Graphics.DrawString("GENOTYPE:                                        ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(520, 310));
            e.Graphics.DrawString(cmbGenotype.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(730, 310));
            e.Graphics.DrawString("STATE OF ORIGIN:                           ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(520, 340));
            e.Graphics.DrawString(cmbStateOfOrigin.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(730, 340));
            e.Graphics.DrawString("MARITAL STATUS:                            ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(520, 370));
            e.Graphics.DrawString(cmbMaritalStatus.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(730, 370));
            e.Graphics.DrawString("PARENT NUMBER:                            ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(520, 400));
            e.Graphics.DrawString(txtParentNumber.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(700, 400));
            e.Graphics.DrawString("PROGRAMME DETAILS                      ", new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(300, 450));
            e.Graphics.DrawString("PROGRAMME COURSE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 490));
            e.Graphics.DrawString(cmbProgramme.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(330, 490));
            e.Graphics.DrawString("COURSE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 520));
            e.Graphics.DrawString(cmbCourse.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(330, 520));
            e.Graphics.DrawString("HOW MANY COURSE YEAR:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString(cmbLevel.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(330, 550));
            e.Graphics.DrawString("O'LEVEL DETAILS", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(300, 600));
            e.Graphics.DrawString("EXAM TYPE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 640));
            e.Graphics.DrawString(cmbExamType.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(330, 640));
            e.Graphics.DrawString("EXAM YEAR: ", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 670));
            e.Graphics.DrawString(cmbYear.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(330, 670));
            e.Graphics.DrawString("NUMBER OF STTING:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 700));
            e.Graphics.DrawString(cmbNumberOfSitting.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(330, 700));
            e.Graphics.DrawString("EXAM/CENTRE NUMBER:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 730));
            e.Graphics.DrawString(txtExamNumber.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(330, 730));
            e.Graphics.DrawString(label18.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 760));
            e.Graphics.DrawString(cmbEnglishGrade.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(345, 760));
            e.Graphics.DrawString(label19.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 790));
            e.Graphics.DrawString(cmbMathGrade.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(345, 790));
            e.Graphics.DrawString(txtsubject3.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 820));
            e.Graphics.DrawString(cmbSubject3Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(345, 820));
            e.Graphics.DrawString(txtsubject4.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 850));
            e.Graphics.DrawString(cmbSubject4Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(345, 850));
            e.Graphics.DrawString(txtsubject5.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(50, 880));
            e.Graphics.DrawString(cmbSubject5Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(345, 880));
            e.Graphics.DrawString(txtSubject6.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 760));
            e.Graphics.DrawString(cmbSubject6Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(700, 760));
            e.Graphics.DrawString(txtSubject7.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 790));
            e.Graphics.DrawString(cmbSubject7Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(700, 790));
            e.Graphics.DrawString(txtSubject8.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 820));
            e.Graphics.DrawString(cmbSubject8Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(700, 820));
            e.Graphics.DrawString(txtSubject9.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(460, 850));
            e.Graphics.DrawString(cmbSubject9Grade.Text, new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(700, 850));
            e.Graphics.DrawString("JAMB DETAILS                      ", new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(300, 910));
            e.Graphics.DrawString("JAMB REGISTRATION NUMBER:", new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(50, 950));
            e.Graphics.DrawString(txtJambRegistrationNumber.Text.ToUpper(), new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(400, 950));
            e.Graphics.DrawString(label4.Text.ToUpper(), new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(50, 980));
            e.Graphics.DrawString(txtJambEnglishScore.Text, new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(400, 980));
            e.Graphics.DrawString(txtJambSubject2.Text.ToUpper(), new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(50, 1010));
            e.Graphics.DrawString(txtJambSubject2Score.Text, new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(400, 1010));
            e.Graphics.DrawString(txtJambSubject3.Text.ToUpper(), new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(550, 950));
            e.Graphics.DrawString(txtJambSubject3Score.Text, new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(750, 950));
            e.Graphics.DrawString(txtJambSubject4.Text.ToUpper(), new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(550, 980));
            e.Graphics.DrawString(txtJambSubject4Score.Text, new Font("Tahoma", 15, FontStyle.Regular), Brushes.Black, new Point(750, 980));
            e.Graphics.DrawString("TOTAL:      " + label43.Text, new Font("Tahoma", 15, FontStyle.Bold), Brushes.Black, new Point(560, 1010));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void cmbNumberOfSitting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbExamType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtJambRegistrationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtSubject8_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject8Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject9_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject9Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject7_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject7Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject5Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExamNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cmbProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject4Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsubject4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject6Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsubject5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject3Grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsubject3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMathGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEnglishGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void txtJambSubject2Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJambSubject4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJambSubject3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJambSubject2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtJambSubject3Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtJambSubject4Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJambEnglishScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void txtParentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResidentialAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStateLga_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStateOfOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGenotype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
