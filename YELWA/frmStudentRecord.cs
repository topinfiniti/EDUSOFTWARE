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
    public partial class frmStudentRecord : Form
    {
        public frmStudentRecord()
        {
            InitializeComponent();
        }
        MySqlConnection cn = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand command;
        MySqlDataAdapter da;
        private void frmStudentRecord_Load(object sender, EventArgs e)
        {
            //string select = @"SELECT  studentid as STUDENTID, fullname STUDENTNAME, dateofbirth AS DATEOFBIRTH, bloodgroup AS BLOODGROUP, genotype AS GENOTYPE, gender AS GENDER, phonenumber AS PHONENUMBER, programme as PROGRAMME, course as COURSE, year as YEAR, jambregistrationnumber as JAMBREGISTRATIONNUMBER, jambenglishscore as JAMBENGLISHSCORE,jambSubject2 AS JAMBSUBJ2, jambSubject2Score AS SCORE2, jambSubject3 as JAMBSUBJ3,jambSubject3Score AS SCORE3,  jambSubject4 as JAMBSUBJ4,jambSubject4Score AS SCORE4, jambtotal as JAMBTOTAL, examyear as EXAMYEAR, examtype as EXAMTYPE, numberofsitting as NUMBEROFSITTINGS, examnumber as EXAMNUBER, math as MATH , english as ENGLISH, subject3 AS SUBJ3,Subject3Grade AS GRADE3, subject4 SUBJ4,Subject4Grade AS GRADE4,subject5 AS SUBJ5,Subject5Grade as GRADE5,subject6 AS SUBJ6,Subject6Grade GRADE6,subject7 AS SUBJ7,Subject7Grade AS GRADE7,subject8 AS SUBJ8,Subject8Grade AS GRADE8,subject9 SUBJ9,Subject9Grade AS GRADE9,email AS EMAIL, maritalstatus AS MARITALSTATUS, stateoforigin AS STATEOFORIGIN, statelga AS LGAAREA, residentialaddress CONTACT_ADDRESS, parentnumber AS PARENTNUMBER, image AS PASSPORT FROM image";
            //command = new MySqlCommand(select, cn);
            //da = new MySqlDataAdapter(command);

            //DataTable dt = new DataTable();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dataGridView1.RowTemplate.Height = 120;
            //dataGridView1.AllowUserToAddRows = false;
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img = (DataGridViewImageColumn)dataGridView1.Columns[45];
            //img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //da.Dispose();

            searchData("");
        }
        DataTable dtable = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=ycmsdb;uid=root;pwd= '';");
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        DataTable dt;

        public void searchData(string valueToSearch)
        {
            string select = @"SELECT  studentid as STUDENTID, studentname as STUDENTNAME, dateofbirth AS DOB, bloodgroup AS BLOODGROUP, genotype AS GENOTYPE, gender AS GENDER, phonenumber AS PHONENUMBER, programme as PROGRAMME, course as COURSE, years as YEAR, jambregistrationnumber as JAMBREGISTRATIONNUMBER, jambenglishscore as JAMBENGLISHSCORE,jambSubj2 AS JAMBSUBJ2, jambSubj2Score AS SCORE2, jambSubj3 as JAMBSUBJ3,jambSubj3Score AS SCORE3,  jambSubj4 as JAMBSUBJ4,jambSubj4Score AS SCORE4, jambtotal as JAMBTOTAL, examyear as EXAMYEAR, examtype as EXAMTYPE, numberofsitting as NUMBEROFSITTINGS, centrenumber as EXAMNUBER, mathematicsgrade as MATH , englishgrade as ENGLISH, subj3 AS SUBJ3,Subj3Grade AS GRADE3, subj4 SUBJ4,Subj4Grade AS GRADE4,subj5 AS SUBJ5,Subj5Grade as GRADE5,subj6 AS SUBJ6,Subj6Grade GRADE6,subj7 AS SUBJ7,Subj7Grade AS GRADE7,subj8 AS SUBJ8,Subj8Grade AS GRADE8,subj9 SUBJ9,Subj9Grade AS GRADE9,email AS EMAIL, maritalstatus AS MARITALSTATUS, stateoforigin AS STATEOFORIGIN, statelga AS LGAAREA, residentialaddress CONTACT_ADDRESS, parentnumber AS PARENTNUMBER, image AS PASSPORT FROM admission2 where CONCAT (studentname, bloodgroup,genotype, stateoforigin, gender, maritalstatus,  years)  like '%" + valueToSearch + "%' ";
            command = new MySqlCommand(select, cn);
            da = new MySqlDataAdapter(command);

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[45];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            da.Dispose();

            //string query = @"select id as ID, fullname as STUDENTNAME, dateofbirth as DATEOFBIRTH, phonenumber as PHONENUMBER, email as EMAIL, gender as GENDER, bloodgroup as BLOODGROUP, genotype as GENOTYPE, stateoforigin as STATEOFORIGIN, statelga AS LOCALGOVERNMENT, maritalstatus AS MARITALSTATUS, parentnumber AS PARENTPHONENUMBER, residentialaddress AS CONTACTADDRESS, programme as PROGRAMME, course as COURSE, year as YEAR, jambregistrationnumber AS JAMBREGNO, jambenglishscore AS JAMBENGLISHSCORE, jambsubject2 AS JAMBSUBJECT2,jambsubject2score AS JAMBSUBJECT2SCORE , jambsubject3 as JAMBSUBJECT3, jambsubject3score as JAMBSUBJECT3SCORE , jambsubject4 as JAMBSUBJECT4, jambsubject4score as JAMBSUBJECT4SCORE, total as TOTAL, examyear as EXAMYEAR, numberofsittings AS NUMBEROFSITTING, examtype AS EXAMTYPE, examcentrenumber AS EXAMINATIONNUMBER, englishgrade AS  ENGLISHGRADE,mathgrade AS GRADE, subject3 AS SUBJECT3, subject3grade AS GRADE3, subject4 AS SUBJECT4, subject4grade AS GRADE4, subject5 AS SUBJECT5, subject5grade AS GRADE5, subject6 AS SUBJECT6, subject6grade AS GRADE6, subject7 AS SUBJECT7, subject7grade AS GRADE7, subject8 AS SUBJECT8,  subject8grade AS GRADE8, subject9 AS SUBJECT9, subject9grade AS GRADE9 FROM admission where CONCAT (fullname, bloodgroup,genotype, stateoforigin, gender, maritalstatus,  year)  like '%" + valueToSearch + "%' ";
            //cmd = new MySqlCommand(query, con);
            //sda = new MySqlDataAdapter(cmd);
            //dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        { 
            DialogResult dialogresult = MessageBox.Show("UPDATE STUDENT DETAILS?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {
                
                frmUpdateStudentRecord nn = new frmUpdateStudentRecord();
                nn.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                nn.txtPhoneNumber.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                nn.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[39].Value.ToString();
                nn.txtStateLga.Text = this.dataGridView1.CurrentRow.Cells[42].Value.ToString();
                nn.txtParentNumber.Text = this.dataGridView1.CurrentRow.Cells[44].Value.ToString();
                nn.txtResidentialAddress.Text = this.dataGridView1.CurrentRow.Cells[43].Value.ToString();
                nn.txtJambRegistrationNumber.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
                nn.txtJambEnglishScore.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                nn.txtJambSubject2.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                nn.txtJambSubject2Score.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
                nn.txtJambSubject3.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
                nn.txtJambSubject3Score.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
                nn.txtJambSubject4.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
                nn.txtJambSubject4Score.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
                nn.cmbLevel.SelectedItem = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                nn.txtExamNumber.Text = this.dataGridView1.CurrentRow.Cells[22].Value.ToString();
              
                nn.cmbNumberOfSitting.SelectedItem = this.dataGridView1.CurrentRow.Cells[21].Value.ToString();
                nn.cmbExamType.SelectedItem = this.dataGridView1.CurrentRow.Cells[20].Value.ToString();
                nn.cmbProgramme.SelectedItem = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                nn.cmbCourse.SelectedItem = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                nn.cmbGender.SelectedItem = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();  
                nn.cmbYear.SelectedItem = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
                nn.cmbBloodGroup.SelectedItem = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                nn.cmbGenotype.SelectedItem = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nn.cmbStateOfOrigin.SelectedItem = this.dataGridView1.CurrentRow.Cells[41].Value.ToString();
                nn.cmbMaritalStatus.SelectedItem = this.dataGridView1.CurrentRow.Cells[40].Value.ToString();
                nn.cmbEnglishGrade.SelectedItem = this.dataGridView1.CurrentRow.Cells[24].Value.ToString();
                nn.cmbMathGrade.SelectedItem = this.dataGridView1.CurrentRow.Cells[23].Value.ToString();
                nn.txtsubject3.Text = this.dataGridView1.CurrentRow.Cells[25].Value.ToString();
                nn.cmbSubject3Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[26].Value.ToString();
                nn.txtsubject4.Text = this.dataGridView1.CurrentRow.Cells[27].Value.ToString();
                nn.cmbSubject4Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[28].Value.ToString();
                nn.txtsubject5.Text = this.dataGridView1.CurrentRow.Cells[29].Value.ToString();
                nn.cmbSubject5Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[30].Value.ToString();
                nn.txtSubject6.Text = this.dataGridView1.CurrentRow.Cells[31].Value.ToString();
                nn.cmbSubject6Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[32].Value.ToString();
                nn.txtSubject7.Text = this.dataGridView1.CurrentRow.Cells[33].Value.ToString();
                nn.cmbSubject7Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[34].Value.ToString();
                nn.txtSubject8.Text = this.dataGridView1.CurrentRow.Cells[35].Value.ToString();
                nn.cmbSubject8Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[36].Value.ToString();
                nn.txtSubject9.Text = this.dataGridView1.CurrentRow.Cells[37].Value.ToString();
                nn.cmbSubject9Grade.SelectedItem = this.dataGridView1.CurrentRow.Cells[38].Value.ToString();
                nn.Show();

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueTosearch = textBox1.Text.ToString();
            searchData(valueTosearch);
        }
    }
}
