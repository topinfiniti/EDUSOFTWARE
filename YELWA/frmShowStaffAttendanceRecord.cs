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
    public partial class frmShowStaffAttendanceRecord : Form
    {
        public frmShowStaffAttendanceRecord()
        {
            InitializeComponent();
        }
  MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;
        DataTable dtable = new DataTable();
        
        private void frmShowStaffAttendanceRecord_Load(object sender, EventArgs e)
        {
            searchData3("");
        }      
        
      
        public void searchData3(string valueToSearch)
        {
            string query = @"select id AS ID, staffname as STAFFNAME, mode AS MODE, timeanddateofsubmission as DATEANDTIME FROM staffattendance where CONCAT (staffname,mode) like '%" + valueToSearch + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchData3(valueTosearch);
        }
    }
}
