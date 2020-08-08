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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Settooltip();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text.Length>0 && txtPassword.Text.Length>0)
            {
            try
            {
                string connectionString2 = null;
                //mySqlConnection con;
                connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                string query = "select * from login where username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "';";
                
                MySqlConnection con = new MySqlConnection(connectionString2);
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader dr;
                con.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    user_info.username = txtUsername.Text.ToUpper();
                    this.Hide();
                    mParent frm = new mParent();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Check Username or Password! Your Credential did not match our records", "MESSAGE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
                    {
                    MessageBox.Show("Type your username and password to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }    
       }
        private void Settooltip()
        {
            ToolTip tip = new ToolTip();
            //tip.Settooltip(this.txtUsername, "Enter yourusername");
            //tip.Settooltip(this.txtPassword, "Please enter your password");
            tip.SetToolTip(this.txtPassword, "Enter your password here");
            tip.SetToolTip(this.txtUsername, "Enter your username here");
            tip.SetToolTip(this.btnLogin, "Click to login");
            tip.SetToolTip(this.btnExit, "Close Application");
            tip.SetToolTip(this.cmbShowPassword, "show my password");
         
            tip.SetToolTip(this.linkLabel1, "Reset your password");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                  txtPassword.Focus();
             }
             else {
                 txtUsername.Focus();
                }
            }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.Enter)
            {
                  btnLogin.Focus();
             }
             else {
                 txtPassword.Focus();
                }
        }

        private void cmbShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (!cmbShowPassword.Checked)
            {
                //hide password
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword nn = new frmForgotPassword();
            this.Hide();
            nn.ShowDialog();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            frmHelp nn = new frmHelp();
            nn.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        }

        }
