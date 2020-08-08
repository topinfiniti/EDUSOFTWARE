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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            cmbBloodGroup.SelectedIndex=0;
            cmbDischarge.SelectedIndex = 0;
            cmbGenotype.SelectedIndex = 0;
            cmbStateOfOrigin.SelectedIndex = 0;
            cmbMaritalStatus.SelectedIndex = 0;
            cmbQualification.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            cmbModeOfEmployment.SelectedIndex = 0;
            cmbGradeClass.SelectedIndex=0;
            cmbAccountType.SelectedIndex=0;
           
            this.ActiveControl = txtFullName;
        }

        private bool Validation()
        {
            bool result = false;

            if (txtResidentialAddress.Text.Length > 70)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtResidentialAddress, "Not more than 70 characters");
            
            }
           else if (txtLGA.Text.Length > 30)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLGA, "Not more than 30 characters");
           }
            else if (txtFullName.Text.Length > 30)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Not more than 30 characters");
            }
                else if (txtEmail.Text.Length > 30)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Not more than 30 characters");
            }
                
            else if (string.IsNullOrEmpty(txtCourseSpecialisation.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtCourseSpecialisation, "Write your course specialisation");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Enter a valid email address");
            }
            else if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Enter your full name");
            }
            else if (string.IsNullOrEmpty(txtLGA.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLGA, "Write your state of originnLGA");
            }
            else if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPhoneNumber, "Write your phone number");
            }
            else if (string.IsNullOrEmpty(txtResidentialAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtResidentialAddress, "Enter your residential address");
            }
            else if (string.IsNullOrEmpty(txtAccountName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAccountName, "Enter your bank account name");
            }
            else if (txtAccountName.Text.Length > 30)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAccountName, "Character must not be more than 30");
            }
            else if (string.IsNullOrEmpty(txtAccountNo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAccountNo, "Enter your valid account number");
            }
            else if (string.IsNullOrEmpty(txtBankName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBankName, "Enter your the name of your bank");
            }
            else if (txtBankName.Text.Length > 20)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBankName, "Must not be greater 20 characters");
            }

            else if (string.IsNullOrEmpty(txtBankSortCode.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBankSortCode, "Enter your bank sort code");
            }
            else if (string.IsNullOrEmpty(txtSchoolGraduated.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSchoolGraduated, "Enter your the school graduated from");
            }
            else if (txtSchoolGraduated.Text.Length>60)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSchoolGraduated, "Must not be more than 60 characters");
            }
            else if (cmbGradeClass.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGradeClass, "kindly class of grade");
            }
            else if (cmbBloodGroup.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbBloodGroup, "kindly choose your blood group");
            }
            else if (cmbDischarge.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbDischarge, "kindly choose your an answer");
            }

            else if (cmbGender.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGender, "kindly choose your gender");
            }
            else if (cmbGenotype.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGenotype, "kindly choose your genotype");
            }
            else if (cmbMaritalStatus.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMaritalStatus, "kindly choose your marital status");
            }
            else if (cmbModeOfEmployment.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbModeOfEmployment, "kindly choose your employment mode");
            }
            else if (cmbQualification.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbQualification, "kindly choose your qualification");
            }
            else if (cmbStateOfOrigin.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbStateOfOrigin, "kindly choose your state of origin");
            }
            else if (cmbAccountType.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbAccountType, "kindly choose your account type");
            }

            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        
        private bool IfUserExist(string name, string email)
        {
            connection con = new connection();
            con.dataGet("select 1 from staff2 where staffname = '" + name + "' or email= '" + email + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files | *.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label32.Text = openFileDialog1.FileName;
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
            this.label32.Click += new System.EventHandler(this.pictureBox2_Click);
            this.label32.Enter += new System.EventHandler(this.pictureBox2_Click);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (IfUserExist(txtFullName.Text, txtEmail.Text))
                {
                    MessageBox.Show(" STAFF HAS FILLED THIS FORM ALREADY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            string FileName = label32.Text;
                            byte[] ImageData;
                            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                            br = new BinaryReader(fs);
                            ImageData = br.ReadBytes((int)fs.Length);
                            br.Close();
                            fs.Close();

                            string CmdString = "INSERT INTO staff2 (staffname,  gender, email, dateofbirth, phonenumber, stateoforigin, maritalstatus, statelga, bloodgroup, genotype, modeofemployment, coursespecialization, residentialaddress, bankname, accountnumber, accounttype, accountname, banksortcode, certificate, qualification, schoolgraduated, classgrade, graduationyear,coursespecialisation, image) VALUES(@staffname, @gender, @email, @dateofbirth, @phonenumber, @stateoforigin, @maritalstatus,@statelga, @bloodgroup, @genotype, @modeofemployment, @coursespecialization, @residentialaddress, @bankname, @accountnumber, @accounttype, @accountname, @banksortcode, @certificate, @qualification, @schoolgraduated, @classgrade, @graduationyear, @coursespecialization, @image)";
                            cmd = new MySqlCommand(CmdString, con);
                            cmd.Parameters.Add("@staffname", MySqlDbType.VarChar, 45);
                            cmd.Parameters.Add("@gender", MySqlDbType.VarChar, 45);
                            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 46);
                            cmd.Parameters.Add("@dateofbirth", MySqlDbType.VarChar, 22);
                            cmd.Parameters.Add("@phonenumber", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@stateoforigin", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@maritalstatus", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@statelga", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@bloodgroup", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@genotype", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@modeofemployment", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@coursespecialization", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@residentialaddress", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@bankname", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@accountnumber", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@accounttype", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@accountname", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@banksortcode", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@certificate", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@qualification", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@schoolgraduated", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@classgrade", MySqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@graduationyear", MySqlDbType.VarChar, 100);
                            
                            cmd.Parameters.Add("@image", MySqlDbType.MediumBlob);

                            cmd.Parameters["@staffname"].Value = txtFullName.Text.ToUpper();
                            cmd.Parameters["@gender"].Value = cmbGender.SelectedItem;
                            cmd.Parameters["@email"].Value = txtEmail.Text.ToUpper();
                            cmd.Parameters["@dateofbirth"].Value = dtpDateOfBirth.Value.ToString();
                            cmd.Parameters["@phonenumber"].Value = txtPhoneNumber.Text.ToUpper();
                            cmd.Parameters["@stateoforigin"].Value = cmbStateOfOrigin.SelectedItem;
                            cmd.Parameters["@maritalstatus"].Value = cmbMaritalStatus.SelectedItem;
                            cmd.Parameters["@statelga"].Value = txtLGA.Text.ToUpper();
                            cmd.Parameters["@bloodgroup"].Value = cmbBloodGroup.SelectedItem;
                            cmd.Parameters["@genotype"].Value = cmbGenotype.SelectedItem;
                            cmd.Parameters["@modeofemployment"].Value = cmbModeOfEmployment.SelectedItem;
                            cmd.Parameters["@coursespecialization"].Value = txtCourseSpecialisation.Text.ToUpper();
                            cmd.Parameters["@residentialaddress"].Value = txtResidentialAddress.Text;
                            cmd.Parameters["@bankname"].Value = txtBankName.Text.ToUpper();
                            cmd.Parameters["@accountnumber"].Value = txtAccountNo.Text.ToUpper();
                            cmd.Parameters["@accounttype"].Value = cmbAccountType.SelectedItem;
                            cmd.Parameters["@accountname"].Value = txtAccountName.Text.ToUpper();
                            cmd.Parameters["@banksortcode"].Value = txtBankSortCode.Text.ToUpper();
                            cmd.Parameters["@certificate"].Value = cmbDischarge.SelectedItem;
                            cmd.Parameters["@qualification"].Value = cmbQualification.SelectedItem;
                            cmd.Parameters["@schoolgraduated"].Value = txtSchoolGraduated.Text.ToUpper();
                            cmd.Parameters["@classgrade"].Value = cmbGradeClass.SelectedItem;
                            cmd.Parameters["@graduationyear"].Value = dtpGraduation.Value.ToString("yyyy");
                           
                            cmd.Parameters["@Image"].Value = ImageData;

                            con.Open();
                            int RowsAffected = cmd.ExecuteNonQuery();
                            if (RowsAffected > 0)
                            {
                                MessageBox.Show("STAFF DATA SUBMITTED SUCESSFULLY!", "CONGRATULATIONS");
                                txtResidentialAddress.Text = txtCourseSpecialisation.Text = txtSchoolGraduated.Text = txtLGA.Text = txtAccountNo.Text = txtBankName.Text = txtAccountName.Text = txtSchoolGraduated.Text = txtBankSortCode.Text = txtFullName.Text = txtEmail.Text = txtPhoneNumber.Text = txtLGA.Text = "";
                                dtpGraduation.Value = dtpDateOfBirth.Value = DateTime.Now;
                                cmbGender.SelectedIndex = cmbStateOfOrigin.SelectedIndex = cmbMaritalStatus.SelectedIndex = cmbAccountType.SelectedIndex = cmbDischarge.SelectedIndex = cmbQualification.SelectedIndex = 0;
                                pictureBox2.Image = null;
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                        }

                    }

                }
            }

        }
        private void txtBankSortCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
