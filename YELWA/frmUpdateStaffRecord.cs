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
    public partial class frmUpdateStaffRecord : Form
    {
        public frmUpdateStaffRecord()
        {
            InitializeComponent();
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
            else if (txtSchoolGraduated.Text.Length > 60)
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to up the student data?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    try
                    {
                        
                        string connectionString = null;
                        connectionString = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                        string query = @"UPDATE STAFF SET gender='" + cmbGender.SelectedItem + "', email='" + txtEmail.Text.ToUpper() + "',  phonenumber='" + txtPhoneNumber.Text + "', stateoforigin='" + cmbStateOfOrigin.SelectedItem + "', statelga='" + txtLGA.Text.ToUpper() + "', maritalstatus='" + cmbMaritalStatus.SelectedItem + "', residentialaddress='" + txtResidentialAddress.Text.ToUpper() + "', certificate='" + cmbDischarge.SelectedItem + "', qualification='" + cmbQualification.SelectedItem + "', coursespecialisation='" + txtCourseSpecialisation.Text.ToUpper() + "', modeofemployment='" + cmbModeOfEmployment.SelectedItem + "', genotype='" + cmbGenotype.SelectedItem + "', bloodgroup='" + cmbBloodGroup.SelectedItem + "', bankname='" + txtBankName.Text.ToUpper() + "', accountnumber='" + txtAccountNo.Text + "', banksortcode='" + txtBankSortCode.Text + "', accounttype='" + cmbAccountType.SelectedItem + "', accountname='" + txtAccountName.Text.ToUpper() + "', schoolgraduated='" + txtSchoolGraduated.Text.ToUpper() + "', grade='" + cmbGradeClass.SelectedItem + "' WHERE staffname  = '" + txtFullName.Text + "'";
                        MySqlConnection con = new MySqlConnection(connectionString);
                        MySqlCommand command = new MySqlCommand(query, con);
                        MySqlDataReader dr;
                        con.Open();
                        dr = command.ExecuteReader();

                        MessageBox.Show("Staff data has been updated", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmStaffRecord nn = new frmStaffRecord();
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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBankSortCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try{
             
                    string connectionString = null;

                    connectionString = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                    string query = "DELETE from staff WHERE staffname  = '" + txtFullName.Text + "'";
                    MySqlConnection con = new MySqlConnection(connectionString);
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr;
                    con.Open();
                    dr = command.ExecuteReader();

                    MessageBox.Show("Staff record deleted", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmStaffRecord nn = new frmStaffRecord();
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

