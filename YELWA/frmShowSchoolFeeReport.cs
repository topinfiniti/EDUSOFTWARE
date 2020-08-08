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
using System.IO;
namespace YELWA
{
    public partial class frmShowReport : Form
    {
        public frmShowReport()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;

        private void loadData(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dtg_list.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }
        private void rdo_daily_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = " YELWA SCHOOL FEE PAYMENT DAILY REPORT";
            sql = @"SELECT  matricnumber as 'MATRICNUMBER', fullname as 'STUDENTNAME', 
                    gender as GENDER, `year` as 'YEAR',`department` as 'DEPARTMENT', amountpaid as AMOUNTPAID, 
                    dateofpayment as DATEOFPAYMENT FROM `schoolfees` WHERE DATE(`dateofpayment`) =CURDATE()";
            
            loadData(sql);
        }

        private void rdo_weekly_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "YELWA SCHOOL FEE PAYMENT WEEKLY REPORT";
            sql = "SELECT  matricnumber as 'MATRICNUMBER', `fullname` as 'STUDENTNAME', gender as GENDER, year as YEAR, `department` as 'DEPARTMENT', `amountpaid` as 'AMOUNTPAID',dateofpayment as DATEOFPAYMENT FROM `schoolfees` WHERE WEEK(`dateofpayment`) =WEEK(NOW())";
            loadData(sql);
        }
        private void rdo_monthly_CheckedChanged(object sender, EventArgs e)
        {

            lblTitle.Text = "YELWA SCHOOL FEE PAYMENT MONTHLY REPORT";
            sql = "SELECT   matricnumber as 'MATRICNUMBER', fullname as'STUDENTNAME', gender as GENDER, `year` as 'YEAR',  `department` as 'DEPARTMENT',  amountpaid as AMOUNTPAID, dateofpayment as DATEOFPAYMENT FROM schoolfees WHERE MONTH(`dateofpayment`) =MONTH(NOW())";
            loadData(sql);
        }

        private void frmShowReport_Load(object sender, EventArgs e)
        {
            sql = "SELECT  matricnumber as MATRICNUMBER, fullname as 'STUDENTNAME', gender as GENDER, `year` as 'YEAR',  `department` as 'DEPARTMENT',  amountpaid as AMOUNTPAID, dateofpayment as DATEOFPAYMENT FROM schoolfees WHERE MONTH(`dateofpayment`) =MONTH(NOW())";
            loadData(sql);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("excel.exe");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //System.Diagnostics.Process.Start("Winword.exe");
            //System.Diagnostics.Process.Start("Wordpad.exe");
            //System.Diagnostics.Process.Start("Calc.exe");
            //System.Diagnostics.Process.Start("Notepad.exe");
        }

        MySqlDataAdapter sda;

        //search by studename
        public void searchData(string valueToSearch)
        {
            try
            {

                string query = @"select matricnumber AS MATRICNUMBER,id AS ID, fullname AS STUDENTNAME, gender AS GENDER, year AS YEAR, department AS DEPARTMENT,amountpaid AMOUNTPAID, dateofpayment as DATEOFPAYMENT FROM schoolfees where fullname  like '%" + txtStudentName.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dtg_list.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        //search by amount 
        public void searchData1(string valueToSearch)
        {
            try
            {
                string query = @"select id AS ID, fullname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT,amountpaid AMOUNTPAID FROM schoolfees where amountpaid  like '%" + txtAmount.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dtg_list.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sql = "SELECT  matricnumber as MATRICNUMBER, fullname as 'STUDENTNAME', gender as GENDER, `year` as 'YEAR',  `department` as 'DEPARTMENT',  amountpaid as AMOUNTPAID, dateofpayment as DATEOFPAYMENT FROM schoolfees WHERE MONTH(`dateofpayment`) =MONTH(NOW())";
            loadData(sql);
            txtAmount.Text = txtDepartment.Text = txtStudentName.Text = txtYear.Text = "";
        }
      
        //search by DEPARTMENT 
        public void searchData3(string valueToSearch)
        {
            try
            {
                string query = @"select id AS ID, fullname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT,amountpaid AMOUNTPAID FROM schoolfees where department  like '%" + txtDepartment.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dtg_list.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("You must enter a Department", "SORRY");
            }
            else
            {
                string valueTosearch = txtStudentName.Text.ToString();
                searchData3(valueTosearch);
            }
        }
        //search by year
        public void searchData4(string valueToSearch)
        {
            try
            {
                string query = @"select id AS ID, fullname AS STUDENTNAME, gender AS GENDER,matricnumber AS MATRICNUMBER, year AS YEAR, department AS DEPARTMENT,amountpaid AMOUNTPAID FROM schoolfees where year  like '%" + txtYear.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                sda = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dtg_list.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                searchData4(valueTosearch);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("excel.exe");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        //    string connectionString = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
        //    string sql = "SELECT matricnumber,fullname,gender,year,department,amountpaid FROM schoolfees";
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //   MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
        //    DataSet ds = new DataSet();
        //    connection.Open();
        //    dataadapter.Fill(ds, "Author_table");
        //    connection.Close();
        //    dtg_list.DataSource = ds;
        //    //dtg_list.DataMember = "schoolfees";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dtg_list.Width, this.dtg_list.Height);
            dtg_list.DrawToBitmap(bm, new Rectangle(0, 0, this.dtg_list.Width, this.dtg_list.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void ConvertToCSV(DataGridView dGV, string filename)
        {
            string stOutput = "";

            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();

            //On Your Save/OpenFile/ExportToExcel ButtonClick

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|.xls*";
            sfd.FileName = "C#.Net_Example.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                ConvertToCSV(dtg_list, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
    }
}

