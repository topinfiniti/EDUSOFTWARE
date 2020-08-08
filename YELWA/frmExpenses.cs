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
    public partial class frmExpenses : Form
    {
        public frmExpenses()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPrice, " Enter the price of item");
            }
            else if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDepartment, "Enter department/unit");
            }
           
            else if (string.IsNullOrEmpty(txtItemsServices.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtItemsServices, "Enter name of item bought/service");
            }
            else if (txtItemsServices.Text.Length>35)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtItemsServices, "Too long, not more than 35 characters");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (Validation()){
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to record this expenses?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString2 = null;
                        string x = user_info.username.ToUpper();
                        connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                        string Query = "INSERT into expenses (item, price, department, recordedby) values ('" + txtItemsServices.Text+ " ', '"+txtPrice.Text+"','" + txtDepartment.Text + " ', '" + x.ToString() + "')";
                        MySqlConnection con = new
                        MySqlConnection(connectionString2);
                        MySqlCommand command = new MySqlCommand(Query, con);
                        MySqlDataReader reader;
                        con.Open();
                        reader = command.ExecuteReader();
                        MessageBox.Show("SUCCESSFUL", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemsServices.Clear();
                  txtPrice.Clear();
                  txtDepartment.Clear();
                        
                        while (reader.Read())
                        {

                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("YELWA COLLEGE OF HEALTH & TECHNOLOGY", new Font("Adobe Ming Std L", 17, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            //e.Graphics.DrawString("Rijau, Niger State ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(350, 38));
            //e.Graphics.DrawString("BURSARY UNIT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 80));
            //e.Graphics.DrawString("CASH RECEIPT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 120));
            //e.Graphics.DrawString("ORIGINAL", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(450, 120));
            //e.Graphics.DrawString("RECEIPT NO:" + txtReceipt.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 90));
            //e.Graphics.DrawString("This is to certify that", new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(20, 180));
            //e.Graphics.DrawString("STUDENT NAME:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 220));
            //e.Graphics.DrawString(txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 220));
            //e.Graphics.DrawString("MATRIC NUMBER:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 270));
            //e.Graphics.DrawString(txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 270));
            //e.Graphics.DrawString("DEPARTMENT:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 320));
            //e.Graphics.DrawString(cmbDepartment.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 320));
            //e.Graphics.DrawString("HAS PAID THE SUM OF:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 370));
            //e.Graphics.DrawString(txtAmount.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 370));
            //e.Graphics.DrawString("PURPOSE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 420));
            //e.Graphics.DrawString(cmbPurpose.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 420));
            //e.Graphics.DrawString("ON:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 470));
            //e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 470));
            //e.Graphics.DrawString("-----------------------------------", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(580, 520));
            //e.Graphics.DrawString("BURSAR'S SIGNATURE", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 539));
            //e.Graphics.DrawString("Kindly keep your receipt very well ", new Font("Tahoma", 10, FontStyle.Italic), Brushes.Black, new Point(10, 545));
            //e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 560));
            //e.Graphics.DrawString("YELWA COLLEGE OF HEALTH & TECHNOLOGY", new Font("Adobe Ming Std L", 17, FontStyle.Bold), Brushes.Black, new Point(200, 600));
            //e.Graphics.DrawString("Rijau, Niger State ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(350, 630));
            //e.Graphics.DrawString("BURSARY UNIT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 670));
            //e.Graphics.DrawString("CASH RECEIPT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 700));
            //e.Graphics.DrawString("(DUPLICATE)", new Font("Tahoma", 12, FontStyle.Italic), Brushes.Black, new Point(450, 700));
            //e.Graphics.DrawString("RECEIPT NO:" + txtReceipt.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 670));
            //e.Graphics.DrawString("This is to certify that", new Font("Tahoma", 12, FontStyle.Regular), Brushes.Black, new Point(20, 730));
            //e.Graphics.DrawString("STUDENT NAME:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 770));
            //e.Graphics.DrawString(txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 770));
            //e.Graphics.DrawString("MATRIC NUMBER:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 810));
            //e.Graphics.DrawString(txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 810));
            //e.Graphics.DrawString("DEPARTMENT:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 850));
            //e.Graphics.DrawString(cmbDepartment.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 850));
            //e.Graphics.DrawString("HAS PAID THE SUM OF:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 890));
            //e.Graphics.DrawString(txtAmount.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 890));
            //e.Graphics.DrawString("PURPOSE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 930));
            //e.Graphics.DrawString(cmbPurpose.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 930));
            //e.Graphics.DrawString("ON:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 970));
            //e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 970));
            //e.Graphics.DrawString("-----------------------------------", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(580, 1040));
            //e.Graphics.DrawString("BURSAR'S SIGNATURE", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1050));          
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
