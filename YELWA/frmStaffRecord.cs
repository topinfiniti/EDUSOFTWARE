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
    public partial class frmStaffRecord : Form
    {
        public frmStaffRecord()
        {
            InitializeComponent();
        }

        private void frmStaffRecord_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        

        public void searchData(string valueToSearch)
        {

            string query = @"select staffid as ID,  staffname as STAFFNAME, gender AS GENDER, email as EMAIL,  bloodgroup as BLOODGROUP, genotype as GENOTYPE, modeofemployment as MODEOFEMPLOYMENT, coursespecialisation as SPECIALIZATION, dateofbirth as DOB, phonenumber as PHONENUMBER, stateoforigin as STATEOFORIGIN, maritalstatus AS MARITALSTATUS, statelga AS LGA, residentialaddress AS CONTACTADDRESS, bankname AS BANKNAME, accountnumber AS ACCOUNTNUMBER, accounttype AS ACCOUNTTYPE, accountname AS ACCOUNTNAME, banksortcode AS BANKSORTCODE, certificate AS NYSCDISCHARGE, qualification AS QUALIFICATION, schoolgraduated AS SCHOOLGRADUATEDFROM, classgrade AS GRADE, graduationyear AS GRADUATIONYEAR, coursespecialisation AS SPECIALISATION, image AS PASSPORT FROM staff2 where CONCAT (staffname, gender)  like '%" + valueToSearch + "%' ";
            //string query = @"select id as ID, staffname STAFFNAME, gender AS GENDER, email AS EMAIL, dateofbirth DATEOFBIRTH, phonenumber AS PHONENUMBER, stateoforigin AS STATEORIGIN, statelga AS LGA, maritalstatus AS MARITALSTATUS ,residentialaddress AS CONTACTADDRESS, certificate NYSCCERTIFICATE, qualification AS QUALIFICATION, coursespecialisation AS COURSESPECIALIZATION, modeofemployment AS EMPLOYMENTMODE,  genotype AS GENOTYPE,bloodgroup AS BLOODGROUP,bankname AS BANKNAME, accountnumber AS ACCOUNTNUMBER, banksortcode SORTCODE, accounttype AS ACCOUNTTYPE, accountname AS ACCOUNTNAME, schoolgraduated AS NAMEOFGRADUATED, grade AS GRADE, graduationyear AS GRADUATEYEAR, image as PASSPORT, timeanddateofregistration AS ENTRYDATE FROM staff2 where CONCAT (staffname, bloodgroup,genotype, stateoforigin, gender, maritalstatus)  like '%" + valueToSearch + "%' ";
            cmd = new MySqlCommand(query, con);
            sda = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[25];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            sda.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchData(valueTosearch);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("UPDATE STAFF DETAILS?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {

                frmUpdateStaffRecord nn = new frmUpdateStaffRecord();
                nn.txtFullName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                nn.cmbGender.SelectedItem = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                nn.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                nn.txtPhoneNumber.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                nn.cmbStateOfOrigin.SelectedItem = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                nn.txtLGA.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                nn.cmbMaritalStatus.SelectedItem = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                nn.cmbBloodGroup.SelectedItem = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nn.cmbGenotype.SelectedItem = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                
                nn.txtResidentialAddress.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
              nn.cmbDischarge.SelectedItem= this.dataGridView1.CurrentRow.Cells[19].Value.ToString(); 
                nn.cmbQualification.SelectedItem = this.dataGridView1.CurrentRow.Cells[20].Value.ToString();
                nn.txtCourseSpecialisation.Text = this.dataGridView1.CurrentRow.Cells[24].Value.ToString();
                nn.cmbModeOfEmployment.SelectedItem = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                nn.cmbGenotype.SelectedItem = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                nn.cmbBloodGroup.SelectedItem = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nn.txtBankName.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
                nn.txtAccountNo.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            nn.txtBankSortCode.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
              nn.cmbAccountType.SelectedItem = this.dataGridView1.CurrentRow.Cells[16].Value.ToString(); 
                nn.txtAccountName.Text= this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
                
                 nn.txtSchoolGraduated.Text = this.dataGridView1.CurrentRow.Cells[21].Value.ToString();
                 nn.cmbGradeClass.SelectedItem = this.dataGridView1.CurrentRow.Cells[22].Value.ToString();
               
               
                nn.Show();
            }
        }
    }
}