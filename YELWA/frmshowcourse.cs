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
    public partial class frmshowcourse : Form
    {
        public frmshowcourse()
        {
            InitializeComponent();
        }
        DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;

        private void frmshowcourse_Load(object sender, EventArgs e)
        { 
            string query = @"select id as ID ,studentname AS STUDENTNAME, matricnumber AS MATRICNUMBER,  year AS YEAR, department AS DEPARTMENT FROM courseform";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

           
        }

        //SEARCH BY MATRIC NUMBER
        public void searchData3(string valueToSearch)
        {
            
                string query = @"select id as ID ,studentname AS STUDENTNAME, matricnumber MATRICNUMBER,  year AS YEAR, department AS DEPARTMENT FROM courseform where matricnumber like '%" + txtMatricNumber.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMatricNumber.Text == "")
            {
                MessageBox.Show("You must enter a matric number", "SORRY");
            }
            else
            {
                string valueTosearch = txtMatricNumber.Text.ToString();
                searchData3(valueTosearch);
            }
        }
       
        //SEARCH BY DEPARTMENT
        public void searchData1(string valueToSearch)
        {

            string query = @"select id as ID ,studentname AS STUDENTNAME, matricnumber MATRICNUMBER,  year AS YEAR, department AS DEPARTMENT FROM courseform where department like '%" + txtDepartment.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("Kindly type a department","SORRY");
            }
            else
            {
                string valueTosearch = txtDepartment.Text.ToString();
                searchData1(valueTosearch);
            }
        }
        //search BY year
        public void searchData2(string valueToSearch)
        {

            string query = @"select id as ID ,studentname AS STUDENTNAME, matricnumber MATRICNUMBER,  year AS YEAR, department AS DEPARTMENT FROM courseform where year like '%" + txtYear.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                MessageBox.Show("A year is required to search", "SORRY");
            }
            else
            {
                string valueTosearch = txtYear.Text.ToString();
                searchData2(valueTosearch);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string query = @"select id as ID ,studentname AS STUDENTNAME, matricnumber MATRICNUMBER,  year AS YEAR, department AS DEPARTMENT FROM courseform";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            txtYear.Text = txtDepartment.Text = txtMatricNumber.Text = "";
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMatricNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        

        
    }
}
