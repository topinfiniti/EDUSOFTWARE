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
    public partial class frmNewPassword : Form
    {
        public frmNewPassword()
        {
            InitializeComponent();
        }
        string email;
        private void frmNewPassword_Load(object sender, EventArgs e)
        {
            label2.Text = user_info.username;
            email = user_info.email;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length > 0))
            {
                if ((textBox1.Text == textBox2.Text))
                {
                    DialogResult dialogresult = MessageBox.Show("CHANGE MY PASSWORD", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogresult == DialogResult.Yes)
                    {
                        try
                        {
                            string connectionString2 = null;
                            //MySqlConnection con;
                            connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                            string query = "UPDATE login SET password='" + textBox1.Text + "' WHERE email = '" + user_info.email.ToString() + "';";
                            MySqlConnection con = new MySqlConnection(connectionString2);
                            MySqlCommand command = new MySqlCommand(query, con);
                            MySqlDataReader dr;
                            con.Open();
                            dr = command.ExecuteReader();

                            MessageBox.Show("Password Resetted Successfully", "CONGRATULATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form1 nn = new Form1();
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
                else
                    {
                        MessageBox.Show("Password are not the same thing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ActiveControl = textBox1;
                    }
                
            }
            else
                {
                    MessageBox.Show("Please kindly type your new password", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Focus();
                }
        }
    }
}
