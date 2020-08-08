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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
        }
        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, " Enter your full name");
            }
            else if (cmbGender.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGender, "Select your gender");
            }
           
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Enter your password");
            }
            
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Confirm your password");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Enter the your email");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUsername, "Enter the your username");
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Enter correct mail");
            }
            else if (txtPassword.Text!=txtConfirmPassword.Text)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Different password");
                errorProvider1.SetError(txtConfirmPassword, "Different password");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool IfUserExist(string name, string email, string username)
        {
            connection con = new connection();
            con.dataGet("select 1 from login where fullname = '" + name + "' or email= '" + email + "' or username='" + username + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (IfUserExist(txtFullName.Text, txtEmail.Text, txtUsername.Text))
                {
                    MessageBox.Show(" User already exist", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Text = txtFullName.Text=txtPassword.Text=txtUsername.Text=txtConfirmPassword.Text = "";
                    cmbGender.SelectedIndex = 0;
                    this.ActiveControl = txtFullName;
                   
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("Are you sure you want to register this user?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogresult == DialogResult.Yes)
                    {
                        try
                        {
                            string connectionString2 = null;

                            connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                            string Query = "INSERT into login (fullname, email, username, gender, password) values ('" + txtFullName.Text + " ', '" + txtEmail.Text + " ','" + txtUsername.Text + " ', '" + cmbGender.SelectedItem + "', '" + txtPassword.Text + "')";



                            MySqlConnection con = new           MySqlConnection(connectionString2);
                            MySqlCommand command = new MySqlCommand(Query, con);
                            MySqlDataReader reader;
                            con.Open();
                            reader = command.ExecuteReader();
                            MessageBox.Show("Sucessfully Register");
                            txtConfirmPassword.Clear();
                            txtEmail.Clear();
                            txtFullName.Clear();
                            txtPassword.Clear();
                            txtUsername.Clear();
                            cmbGender.SelectedIndex = 0;
                            txtConfirmPassword.Clear();


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
    
