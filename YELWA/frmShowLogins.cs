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
    public partial class frmShowLogins : Form
    {
        public frmShowLogins()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchData(valueTosearch);
        }
        DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;
        public void searchData(string valueToSearch)
        {
            try
            {
                string query = @"select id AS ID, username as USERNAME, timeanddateoflogins as TIMEDATEOFLOGINS FROM login where CONCAT (username, mode) like '%" + valueToSearch + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmShowLogins_Load(object sender, EventArgs e)
        {
           searchData("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchData(valueTosearch);
        }
    }
}
