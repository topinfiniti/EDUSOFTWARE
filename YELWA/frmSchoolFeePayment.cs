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
    public partial class frmSchoolFeePayment : Form
    {
        public frmSchoolFeePayment()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtMatricNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMatricNumber, " Enter your matric number");
            }
            
            else if (cmbAcademicSession.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbAcademicSession, "Select the academic session");
            }
            else if (cmbLevel.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbLevel, "Select your level");
            }
            else if (cmbGender.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGender, "Select your level");
            }
            else if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDepartment, "Enter department");
            }
            else if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Enter your full name");
            }
            
            else if (string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAmountPaid, "Enter amount you are paying");
            }
            else if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPhoneNumber, "Enter your valid number");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure you want to record the payment?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    //printPreviewDialog1.Document = printDocument1;
                    //printPreviewDialog1.ShowDialog();
                    try
                    {
                        string connectionString2 = null;
                        string x = user_info.username.ToUpper();
                        connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                        string Query = "INSERT into schoolfees (fullname, department, phonenumber, gender, year, matricnumber, academicsession, amountpaid, dateofpayment,  cashier) values ('" + txtFullName.Text + " ', '" + txtDepartment.Text.ToUpper() + " ','" + txtPhoneNumber.Text + " ', '" + cmbGender.SelectedItem + "', '" + cmbLevel.SelectedItem + "','" + txtMatricNumber.Text + "', '" + cmbAcademicSession.SelectedItem + "', '" + txtAmountPaid.Text + "', '" + dtpDop.Value.ToString("yyyy/MM/dd") + "', '" + x.ToString() + "')";
                        MySqlConnection con = new
                        MySqlConnection(connectionString2);
                        MySqlCommand command = new MySqlCommand(Query, con);
                        MySqlDataReader reader;
                        con.Open();
                        reader = command.ExecuteReader();
                        MessageBox.Show("PAYMENT SUCCESSFUL","MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFullName.Clear();
                        txtAmountPaid.Clear();
                        txtMatricNumber.Clear();
                        txtMatricNumber.Clear();
                        txtPhoneNumber.Clear();
                        cmbAcademicSession.SelectedIndex = 0;
                        txtDepartment.Clear();
                        cmbGender.SelectedIndex = 0;
                        cmbLevel.SelectedIndex = 0;
                        
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

        private void frmSchoolFeePayment_Load(object sender, EventArgs e)
        {
            cmbAcademicSession.SelectedIndex = 0;
            
            cmbGender.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;
            
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
