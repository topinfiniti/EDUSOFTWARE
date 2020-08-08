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
    public partial class frmShowReceiptRecord : Form
    {
        public frmShowReceiptRecord()
        {
            InitializeComponent();
        }

        private void frmShowReceiptRecord_Load(object sender, EventArgs e)
        {
            string query = @"select id AS ID, studentname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT, purpose AS PURPOSE,amountpaid AMOUNTPAID, receiptno AS RECEIPPTNO FROM receipt ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;
        
        //search by studename
        public void searchData(string valueToSearch)
        {
            string query = @"select id AS ID, studentname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT, purpose AS PURPOSE,amountpaid AMOUNTPAID, receiptno AS RECEIPPTNO FROM receipt where studentname  like '%" + txtStudentName.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                MessageBox.Show("You must enter a student name", "SORRY");
            }
            else
            {
                string valueTosearch = txtStudentName.Text.ToString();
                searchData(valueTosearch);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string query = @"select id AS ID, studentname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT, purpose AS PURPOSE,amountpaid AMOUNTPAID, receiptno AS RECEIPPTNO FROM receipt ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            txtStudentName.Text = txtDepartment.Text = txtAmount.Text = "";
        }
        
        //search by amount
        public void searchData1(string valueToSearch)
        {
            string query = @"select id AS ID, studentname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT, purpose AS PURPOSE,amountpaid AMOUNTPAID, receiptno AS RECEIPPTNO FROM receipt where amountpaid  like '%" + txtAmount.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("You must enter an Amouunt", "SORRY");
            }
            else
            {
                string valueTosearch = txtAmount.Text.ToString();
                searchData1(valueTosearch);
            }
        }
       //search by department
        public void searchData2(string valueToSearch)
        {
            string query = @"select id AS ID, studentname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT, purpose AS PURPOSE,amountpaid AMOUNTPAID, receiptno AS RECEIPPTNO FROM receipt where department  like '%" + txtDepartment.Text + "%' ";
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
                MessageBox.Show("You must enter a Department", "SORRY");
            }
            else
            {
                string valueTosearch = txtStudentName.Text.ToString();
                searchData2(valueTosearch);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        //search by year
        public void searchData3(string valueToSearch)
        {
            string query = @"select id AS ID, studentname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT, purpose AS PURPOSE,amountpaid AMOUNTPAID, receiptno AS RECEIPPTNO FROM receipt where year  like '%" + txtYear.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                MessageBox.Show("You must enter a Year", "SORRY");
            }
            else
            {
                string valueTosearch = txtYear.Text.ToString();
                searchData3(valueTosearch);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
