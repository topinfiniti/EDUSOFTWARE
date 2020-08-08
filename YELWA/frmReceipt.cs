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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
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
                     
            else if (cmbLevel.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbLevel, "Select your level");
            }
            else if (cmbGender.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbGender, "Select your gender");
            }
            else if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFullName, "Enter your full name");
            }
              else if (string.IsNullOrEmpty(txtDepartment.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDepartment, "Enter department");
            }
            else if(cmbPurpose.SelectedIndex==0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbPurpose, "Please select purpose of payment");
            }
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAmount, "Enter amount you are paying");
            }
            else if (string.IsNullOrEmpty(txtReceipt.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtReceipt, "Enter the receipt");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {  if (Validation())
            {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to generate the receipt?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
           
              printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();

                        try
                        {
                            string connectionString2 = null;
                            string x = user_info.username;
                            connectionString2 = "server=localhost;database=ycmsdb;uid=root;pwd= '';";
                            string Query = "INSERT into receipt (studentname, gender, matricnumber, year, department, purpose, amountpaid, receiptno, issuedby) values ('" + txtFullName.Text.ToUpper() + " ', '" + cmbGender.SelectedItem + "','" + txtMatricNumber.Text.ToUpper() + "', '" + cmbLevel.SelectedItem + "','" + txtDepartment.Text.ToUpper() + " ', '" + cmbPurpose.SelectedItem + "','" + txtAmount.Text + "', '" + txtReceipt.Text + "', '" + x.ToString() + "')";
                            MySqlConnection con = new MySqlConnection(connectionString2);
                            MySqlCommand command = new MySqlCommand(Query, con);
                            MySqlDataReader reader;
                            con.Open();
                            reader = command.ExecuteReader();
                            //    MessageBox.Show("SUCCESSFUL", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          txtDepartment.Text=  txtFullName.Text = txtAmount.Text = txtMatricNumber.Text = txtReceipt.Text = "";
                            cmbGender.SelectedIndex  = cmbLevel.SelectedIndex = cmbPurpose.SelectedIndex = 0;



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
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.yelqq;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 5, 15, newImage.Width, newImage.Height);
            e.Graphics.DrawString("YELWA COLLEGE OF HEALTH & TECHNOLOGY", new Font("Adobe Ming Std L", 17, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            e.Graphics.DrawString("Rijau, Niger State ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(350, 38));
            e.Graphics.DrawString("BURSARY UNIT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 80));
            e.Graphics.DrawString("CASH RECEIPT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 120));
            e.Graphics.DrawString("ORIGINAL", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("RECEIPT NO:" + txtReceipt.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 90));
            e.Graphics.DrawString("THIS IS TO CERTIFY THAT:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("STUDENT NAME:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 220));
            e.Graphics.DrawString(txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 220));
            e.Graphics.DrawString("MATRIC NUMBER:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 270));
            e.Graphics.DrawString(txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 270));
            e.Graphics.DrawString("DEPARTMENT:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 320));
            e.Graphics.DrawString(txtDepartment.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 320));
            e.Graphics.DrawString("HAS PAID THE SUM OF:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 370));
            e.Graphics.DrawString(txtAmount.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 370));
            e.Graphics.DrawString("PURPOSE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 420));
            e.Graphics.DrawString(cmbPurpose.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 420));
            e.Graphics.DrawString("ON:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 470));
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 470));
            e.Graphics.DrawString("-----------------------------------", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(580, 525));
            e.Graphics.DrawString("BURSAR'S SIGNATURE", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 539));
            e.Graphics.DrawString("Kindly keep your receipt very well ", new Font("Tahoma", 10, FontStyle.Italic), Brushes.Black, new Point(10, 545));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 575));
            
            e.Graphics.DrawString("YELWA COLLEGE OF HEALTH & TECHNOLOGY", new Font("Adobe Ming Std L", 17, FontStyle.Bold), Brushes.Black, new Point(200, 600));
            e.Graphics.DrawString("Rijau, Niger State ", new Font("Calibri (Body)", 15, FontStyle.Bold), Brushes.Black, new Point(350, 630));
            e.Graphics.DrawString("BURSARY UNIT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 670));
            e.Graphics.DrawString("CASH RECEIPT", new Font("Tahoma", 12, FontStyle.Underline), Brushes.Black, new Point(320, 700));
            e.Graphics.DrawString("(DUPLICATE)", new Font("Tahoma", 12, FontStyle.Italic), Brushes.Black, new Point(450, 700));
            e.Graphics.DrawString("RECEIPT NO:" + txtReceipt.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 670));
            e.Graphics.DrawString("THIS IS TO CERTIFY THAT:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 760));
            e.Graphics.DrawString("STUDENT NAME:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 790));
            e.Graphics.DrawString(txtFullName.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 790));
            e.Graphics.DrawString("MATRIC NUMBER:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 830));
            e.Graphics.DrawString(txtMatricNumber.Text.ToUpper(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 830));
            e.Graphics.DrawString("DEPARTMENT:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 870));
            e.Graphics.DrawString(txtDepartment.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 870));
            e.Graphics.DrawString("HAS PAID THE SUM OF:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 910));
            e.Graphics.DrawString(txtAmount.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 910));
            e.Graphics.DrawString("PURPOSE:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 950));
            e.Graphics.DrawString(cmbPurpose.Text, new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 950));
            e.Graphics.DrawString("ON:", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(20, 990));
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(250, 990));
            e.Graphics.DrawString("-----------------------------------", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(580, 1030));
            e.Graphics.DrawString("BURSAR'S SIGNATURE", new Font("Tahoma", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1050));
            Bitmap bp = Properties.Resources.yelqq;
            Image neImage = bp;
            e.Graphics.DrawImage(newImage, 10, 600, neImage.Width, newImage.Height);
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            cmbPurpose.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;
           
            cmbGender.SelectedIndex = 0;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
