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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text.Length > 0)
            {
                try
                {
                    string connectionString2 = null;
                    //mySqlConnection con;
                    connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                    string query = "select * from login where email = '" + txtEmail.Text + "';";
                    MySqlConnection con = new MySqlConnection(connectionString2);
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataReader dr;
                    con.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        user_info.username = dr["username"].ToString();
                        user_info.email = dr["email"].ToString();


                        MessageBox.Show("Email validated", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmNewPassword nn = new frmNewPassword();
                        nn.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email does not match, you have no account with us before", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("A registered email is required to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
  }