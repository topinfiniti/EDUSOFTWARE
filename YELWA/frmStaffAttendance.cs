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
    public partial class frmStaffAttendance : Form
    {
        public frmStaffAttendance()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtStaffName, " Enter your name");
            }
            else if (cmbMode.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMode, "Select the mode");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        //private bool IfUserExist(string name, string email)
        //{
        //    connection con = new connection();
        //    con.dataGet("select 1 from staffattendance where staffname = '" + name + "' or mode= '" + email + "'");
        //    DataTable dt = new DataTable();
        //    con.sda.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //        return true;
        //    else
        //        return false;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
               
                    DialogResult dialogresult = MessageBox.Show("Are you sure you want to mark attendance?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogresult == DialogResult.Yes)
                    {
                        string connectionString2 = null;
                        string x = user_info.username;
                        connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                        string Query = "INSERT into staffattendance (staffname, mode, markedby) values ('" + txtStaffName.Text.ToUpper() + " ',  '" + cmbMode.SelectedItem + "', '" + x.ToString() + "')";
                        MySqlConnection con = new MySqlConnection(connectionString2);
                        MySqlCommand command = new MySqlCommand(Query, con);
                        MySqlDataReader reader;
                        con.Open();
                        reader = command.ExecuteReader();
                        MessageBox.Show(" MARKED SUCCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStaffName.Clear();
                        cmbMode.SelectedIndex = 0;

                        while (reader.Read())
                        {

                        }
                        con.Close();
                    }
                }
                txtStaffName.Clear();
                cmbMode.SelectedIndex = 0;

            
        }
  private void frmStaffAttendance_Load(object sender, EventArgs e)
        {
            cmbMode.SelectedIndex = 0;
        }
    }
}
