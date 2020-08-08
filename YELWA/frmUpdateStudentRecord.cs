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
    public partial class frmUpdateStudentRecord : Form
    {
        public frmUpdateStudentRecord()
        {
            InitializeComponent();
        }

        private void frmUpdateStudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

            //else if (string.IsNullOrEmpty(txtJambRegistrationNumber.Text))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtJambRegistrationNumber, "Enter your jamb registration number");
            //}
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
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to up the student data?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    try
                    {
                        int a;
                        a = Int32.Parse(txtJambEnglishScore.Text) + Int32.Parse(txtJambSubject2Score.Text) + Int32.Parse(txtJambSubject3Score.Text) + Int32.Parse(txtJambSubject4Score.Text);

                        label43.Text = a.ToString();
                        string connectionString = null;

                        connectionString = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                        string query = @"UPDATE admission SET fullname='" + txtName.Text.ToUpper() + "', phonenumber='" + txtPhoneNumber.Text.ToUpper() + "',email='" + txtEmail.Text.ToUpper() + "', gender= '" + cmbGender.SelectedItem + "', bloodgroup='" + cmbBloodGroup.SelectedItem + "', genotype='" + cmbGenotype.SelectedItem + "', stateoforigin='" + cmbStateOfOrigin.SelectedItem + "', statelga='" + txtStateLga.Text.ToUpper() + "', maritalstatus='" + cmbMaritalStatus.SelectedItem + "', parentnumber='" + txtParentNumber.Text.ToUpper() + "', residentialaddress ='" + txtResidentialAddress.Text.ToUpper() + "', programme='" + cmbProgramme.SelectedItem + "', course ='" + cmbCourse.SelectedItem + "', year='" + cmbLevel.SelectedItem + "', jambenglishscore ='" + txtJambEnglishScore.Text + "', jambsubject2='" + txtJambSubject2.Text.ToUpper() + "',jambsubject2score= '" + txtJambSubject2Score.Text + "',jambsubject3='" + txtJambSubject3.Text.ToUpper() + "', jambsubject3score='" + txtJambSubject3Score.Text + "', jambsubject4='" + txtJambSubject4.Text.ToUpper() + "',   Jambsubject4score = '" + txtJambSubject4Score.Text + "',  examyear= '" + cmbYear.SelectedItem + "', numberofsittings='" + cmbNumberOfSitting.SelectedItem + "', examtype='" + cmbExamType.SelectedItem + "', examcentrenumber='" + txtExamNumber.Text.ToUpper() + "', englishgrade= '" + cmbEnglishGrade.SelectedItem + "', mathgrade='" + cmbMathGrade.Text + "', subject3='" + txtsubject3.Text.ToUpper() + "', subject3grade='" + cmbSubject3Grade.SelectedItem + "', subject4='" + txtsubject4.Text.ToUpper() + "', subject4grade='" + cmbSubject4Grade.SelectedItem + "', subject5='" + txtsubject5.Text.ToUpper() + "', subject5grade='" + cmbSubject5Grade.SelectedItem + "', subject6='" + txtSubject6.Text.ToUpper() + "', subject6grade='" + cmbSubject6Grade.SelectedItem + "',subject7='" + txtSubject7.Text.ToUpper() + "', subject7grade='" + cmbSubject7Grade.SelectedItem + "', subject8='" + txtSubject8.Text.ToUpper() + "', subject8grade='" + cmbSubject8Grade.SelectedItem + "', subject9='" + txtSubject9.Text.ToUpper() + "', subject9grade='" + cmbSubject9Grade.SelectedItem + "' WHERE jambregistrationnumber  = '" + txtJambRegistrationNumber.Text + "'";
                        //  ,  
                        MySqlConnection con = new MySqlConnection(connectionString);
                        MySqlCommand command = new MySqlCommand(query, con);
                        MySqlDataReader dr;
                        con.Open();
                        dr = command.ExecuteReader();

                        MessageBox.Show("Your data has been updated", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmStudentRecord nn = new frmStudentRecord();
                        nn.ShowDialog();
                        while
                            (dr.Read())
                        {
                        }
                        con.Close();
                        dr.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void txtParentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtJambEnglishScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtJambEnglishScore_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to up the student data?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {                                    
                    int a;
                    a = Int32.Parse(txtJambEnglishScore.Text) + Int32.Parse(txtJambSubject2Score.Text) + Int32.Parse(txtJambSubject3Score.Text) + Int32.Parse(txtJambSubject4Score.Text);

                    label43.Text = a.ToString();
                    string connectionString = null;

                    connectionString = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                    string query = "DELETE from admission WHERE jambregistrationnumber  = '" + txtJambRegistrationNumber.Text + "'";
                    //  ,  
                    MySqlConnection con = new MySqlConnection(connectionString);
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr;
                    con.Open();
                    dr = command.ExecuteReader();

                    MessageBox.Show("Student record deleted", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmStudentRecord nn = new frmStudentRecord();
                    nn.ShowDialog();
                    while
                        (dr.Read())
                    {
                    }
                    con.Close();
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
