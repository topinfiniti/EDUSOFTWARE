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
    public partial class frmShowExpensesRecord : Form
    {
        public frmShowExpensesRecord()
        {
            InitializeComponent();
        }
        DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;

        private void frmShowExpensesRecord_Load(object sender, EventArgs e)
        {
           
            string query = @"select id AS ID, item AS ITEM, price AS COSTOFITEM, department as PURCHASEDUNIT, timeandateofsubmission AS DATEANDTIME FROM expenses";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd); 
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            /* 
            
             * try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from logs where Date between @date1 and @date2 order by Date", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value;
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgw.Rows.Clear();
                while ((rdr.Read() == true))
                {
                    dgw.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             * try
             {
                 Timer1.Enabled = false;
                 CamMgr.CurrentCamera.Dispose();
                 CamMgr.Cameras.ElementAt(cmbCamera.SelectedIndex).Dispose();
                 CamMgr.Dispose();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             *  if ((dtpDateFrom.Value.Date) > (dtpDateTo.Value.Date))
             {
                 MessageBox.Show("Invalid Selection", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 dtpDateTo.Focus();
             }
             */
            
        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string query = @"select id as ID ,item AS ITEM, price AS PRICE, department AS DEPARTMENT, timeandateofsubmission AS DATEANDTIME FROM expenses ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd); 
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            txtDepartment.Text = txtItem.Text = txtPrice.Text = "";
        }
        
        
        
        //SEARCH BY ITEM
        public void searchData3(string valueToSearch)
        {

            string query = @"select id as ID ,item AS ITEM, price AS PRICE, department AS DEPARTMENT, timeandateofsubmission AS DATEANDTIME FROM expenses where ITEM like '%" + txtItem.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }     
    private void button3_Click(object sender, EventArgs e)
        {
        if (txtItem.Text == "")
            {
                MessageBox.Show("You must enter an Item", "SORRY");
            }
            else
            {
                string valueTosearch = txtItem.Text.ToString();
                searchData3(valueTosearch);
            }
        }
        //search by department
    public void searchData2(string valueToSearch)
    {

        string query = @"select id as ID ,item AS ITEM, price AS PRICE, department AS DEPARTMENT, timeandateofsubmission AS DATEANDTIME FROM expenses where department like '%" + txtDepartment.Text + "%' ";
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
            string valueTosearch = txtItem.Text.ToString();
            searchData2(valueTosearch);
        }
    }
        //SEARCH BY PRICE
 public void searchData1(string valueToSearch)
    {

        string query = @"select id as ID ,item AS ITEM, price AS PRICE, department AS DEPARTMENT, timeandateofsubmission AS DATEANDTIME FROM expenses where price like '%" + txtPrice.Text + "%' ";
        cmd = new MySqlCommand(query, con);
        sda = new MySqlDataAdapter(cmd);
        dt = new DataTable();
        sda.Fill(dt);
        dataGridView1.DataSource = dt;
    }     
    private void button2_Click(object sender, EventArgs e)
    {
        if (txtPrice.Text == "")
        {
            MessageBox.Show("You must enter a Price", "SORRY");
        }
        else
        {
            string valueTosearch = txtItem.Text.ToString();
            searchData1(valueTosearch);
        }
    }

    private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
        {
            e.Handled = true;
        }
    }

        }
    }

