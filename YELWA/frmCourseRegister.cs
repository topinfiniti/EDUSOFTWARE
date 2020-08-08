using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YELWA
{
    public partial class frmCourseRegister : Form
    {
        public frmCourseRegister()
        {
            InitializeComponent();
            Settooltip();
        }

        private void Settooltip()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btnCommChewYear1, "Click for Community Health(CHEW) Year 1 Course registration");
            tip.SetToolTip(this.btnCommChewYear2, "Click for Community Health(CHEW) Year 2 Course registration");
            tip.SetToolTip(this.btnCommChewYear3, "Click for Community Health(CHEW) Year 3 Course registration");
            tip.SetToolTip(this.btnCommJhewYear1, "Click for Community Health(JCHEW) Year 1 Course registration");
            tip.SetToolTip(this.btnCommJhewYear2, "Click for Community Health(JCHEW) Year 2 Course registration");
            tip.SetToolTip(this.btnHealthEduYear1, "Click for Health Education Year 1 Course Registration");
            tip.SetToolTip(this.btnHealthEduYear2, "Click for Health Education Year 2 Course Registration");
            tip.SetToolTip(this.btnHealthEduYear3, "Click for Health Education Year 3 Course Registration");
            tip.SetToolTip(this.btnMLSYear1, "Click for Medical Lab. Science Year 1 Course Registration");
            tip.SetToolTip(this.btnMLSYear2, "Click for Medical Lab. Science Year 2 Course Registration");
            tip.SetToolTip(this.btnMLSYear3, "Click for Medical Lab. Science Year 3 Course Registration");
            tip.SetToolTip(this.btnNursingAidsYear1, "Click for Nursing Aids Year 1 Course Registration");
            tip.SetToolTip(this.btnNursingAidsYear2, "Click for Nursing Aids Year 2 Course Registration");
            tip.SetToolTip(this.btnNursingAidsYear3, "Click for Nursing Aids Year 1 Course Registration");
            tip.SetToolTip(this.btnPhamacyYear1, "Click for Pharmacy Year 1 Course Registration");
            tip.SetToolTip(this.btnPhamacyYear2, "Click for Pharmacy Year 2 Course Registration");
            tip.SetToolTip(this.btnPhamacyYear3, "Click for Pharmacy Year 3 Course Registration");
            
        }
        

       

        private void button9_Click(object sender, EventArgs e)
        {
        //frmHeathYear1CourseForm nn = new frmHeathYear1CourseForm();
        //    nn.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
         //frmHeathYear2CourseForm nn = new frmHeathYear2CourseForm();
         //   nn.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
         //frmHeathYear3CourseForm nn = new frmHeathYear3CourseForm();
         //   nn.ShowDialog();
        }

        

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            frmHeathYear2CourseForm nn = new frmHeathYear2CourseForm();
            nn.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCourseRegister_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMLSYear1_Click(object sender, EventArgs e)
        {
            frmMedicalYear1CourseForm nn = new frmMedicalYear1CourseForm();
            nn.ShowDialog();
        }

        private void btnMLSYear2_Click(object sender, EventArgs e)
        {
            frmMedicalYear2CourseForm nn = new frmMedicalYear2CourseForm();
            nn.ShowDialog();
        }

        private void btnMLSYear3_Click(object sender, EventArgs e)
        {
            frmMedicalYear3CourseForm nn = new frmMedicalYear3CourseForm();
            nn.ShowDialog();
        }

        private void btnPhamacyYear1_Click(object sender, EventArgs e)
        {
            frmPharmacyYear1CourseForm nn = new frmPharmacyYear1CourseForm();
            nn.ShowDialog();
        }

        private void btnPhamacyYear2_Click(object sender, EventArgs e)
        {
            frmPharmacyYear2CourseForm nn = new frmPharmacyYear2CourseForm();
            nn.ShowDialog();
        }

        private void btnPhamacyYear3_Click(object sender, EventArgs e)
        {
            frmPharmacyYear3CourseForm nn = new frmPharmacyYear3CourseForm();
            nn.ShowDialog();
        }

        private void btnCommChewYear1_Click(object sender, EventArgs e)
        {
            frmCommunityHealthCheYear1CourseForm nn = new frmCommunityHealthCheYear1CourseForm();
            nn.ShowDialog();
        }

        private void btnCommChewYear2_Click(object sender, EventArgs e)
        {
            frmCommunityHealthCheYear2CourseForm nn = new frmCommunityHealthCheYear2CourseForm();
            nn.ShowDialog();
        }

        private void btnCommChewYear3_Click(object sender, EventArgs e)
        {
            frmCommunityHealthCheYear3CourseForm nn = new frmCommunityHealthCheYear3CourseForm();
            nn.ShowDialog();
        }

        private void btnCommJhewYear1_Click(object sender, EventArgs e)
        {
            frmCommunityHealthJchYear1CourseForm nn = new frmCommunityHealthJchYear1CourseForm();
            nn.ShowDialog();
        }

        private void btnCommJhewYear2_Click(object sender, EventArgs e)
        {
            frmCommunityHealthJchYear2CourseForm nn = new frmCommunityHealthJchYear2CourseForm();
            nn.ShowDialog();
        }

        private void btnNursingAidsYear1_Click(object sender, EventArgs e)
        {
            frmNursingAidsYear1CourseForm nn = new frmNursingAidsYear1CourseForm();
            nn.ShowDialog();
        }

        private void btnNursingAidsYear2_Click(object sender, EventArgs e)
        {
            frmNursingAidsYear2CourseForm nn = new frmNursingAidsYear2CourseForm();
            nn.ShowDialog();
        }

        private void btnNursingAidsYear3_Click(object sender, EventArgs e)
        {
            frmNursingAidsYear3CourseForm nn = new frmNursingAidsYear3CourseForm();
            nn.ShowDialog();
        }

        private void btnHealthEduYear3_Click(object sender, EventArgs e)
        {
            frmHeathYear3CourseForm nn = new frmHeathYear3CourseForm();
            nn.ShowDialog();
        }

        private void btnHealthEduYear2_Click(object sender, EventArgs e)
        {
            frmHeathYear2CourseForm nn = new frmHeathYear2CourseForm();
            nn.ShowDialog();
        }

        private void btnHealthEduYear1_Click(object sender, EventArgs e)
        {
            frmHeathYear1CourseForm nn = new frmHeathYear1CourseForm();
            nn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        }
     }
   

