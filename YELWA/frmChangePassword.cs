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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Enter your old password");
            }

            else if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNewPassword, "Enter the your new password");
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Confirm your new password");
            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNewPassword, "Both must be same");
                errorProvider1.SetError(txtConfirmPassword, "Both must be same");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to change your password?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    string connectionString2 = null;

                    connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                    string query = "select * from login where password = '" + txtPassword.Text + "';";
                    MySqlConnection con = new MySqlConnection(connectionString2);
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr;
                    con.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        user_info.password = dr["password"].ToString();
                      //  MessageBox.Show("password correct");
                        try
                        {
                            string connectionString = null;
                           
                            connectionString = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                            string quey = "UPDATE login SET password='" + txtNewPassword.Text + "' WHERE password = '" + txtPassword.Text + "';";
                            MySqlConnection cn = new MySqlConnection(connectionString);
                            MySqlCommand command2 = new MySqlCommand(quey, cn);
                            MySqlDataReader dr2;
                            cn.Open();
                            dr2 = command2.ExecuteReader();

                            MessageBox.Show("Password Changed Successfully", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtConfirmPassword.Clear();
                            txtNewPassword.Clear();
                            txtPassword.Clear();
                            while
                                (dr2.Read())
                            {
                            }
                            cn.Close();
                            dr2.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Sorry, current password typed is wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
