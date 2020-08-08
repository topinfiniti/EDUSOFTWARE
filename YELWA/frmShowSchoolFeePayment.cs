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
    public partial class frmShowSchoolFeePayment : Form
    {
        public frmShowSchoolFeePayment()
        {
            InitializeComponent();
        }

        private void frmShowSchoolFeePayment_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        //private void LoadData()
        //{
        //    connection con = new connection();
        //    con.dataGet("select * from schoolfees");
        //    DataTable dt = new DataTable();
        //    dataGridView1.Rows.Clear();
        //    con.sda.Fill(dt);
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        int n = dataGridView1.Rows.Add();
        //        dataGridView1.Rows[n].Cells["dgSN"].Value = n + 1;
        //        dataGridView1.Rows[n].Cells["dgStudentName"].Value = row["fullname"].ToString();
        //        dataGridView1.Rows[n].Cells["dgDepartment"].Value = row["department"].ToString();
        //        dataGridView1.Rows[n].Cells["dgMatricNumber"].Value = row["matricnumber"].ToString(); 
        //        dataGridView1.Rows[n].Cells["dgAcademicSession"].Value = row["academicsession"].ToString();
        //        dataGridView1.Rows[n].Cells["dgGender"].Value = row["gender"].ToString();
        //        dataGridView1.Rows[n].Cells["dgYear"].Value = row["year"].ToString();
        //        dataGridView1.Rows[n].Cells["dgDateOfPayment"].Value = row["dateofpayment"].ToString();
        //        dataGridView1.Rows[n].Cells["dgLastAmountPaid"].Value = row["amountpaid"].ToString();
        //        dataGridView1.Rows[n].Cells["dgModeOfPayment"].Value = row["modeofpayment"].ToString();
                
               
                

        //    }
        //}

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

            string query = @"select id ,fullname, gender,  year, department, amountpaid, dateofpayment FROM schoolfees where CONCAT (fullname,  gender,  year, department, amountpaid)
                                like '%" + valueToSearch + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
