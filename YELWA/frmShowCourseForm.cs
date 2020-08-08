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
    public partial class frmShowCourseForm : Form
    {
        public frmShowCourseForm()
        {
            InitializeComponent();
        }

        private void frmShowCourseForm_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchData(valueTosearch);
        }
      
        public void searchData(string valueToSearch)
        { DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;
            try
            {
                string query = @"select studentname,  matricnumber,  year, department FROM courseform where CONCAT (studentname,  matricnumber,  year, department)
                                like '%" + valueToSearch + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }
           

       
        }
    }
}
