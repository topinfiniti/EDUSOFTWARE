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
    public partial class frmAllRecord : Form
    {
        public frmAllRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShowSchoolFeePayment nn = new frmShowSchoolFeePayment();
            nn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmShowExpensesRecord nn = new frmShowExpensesRecord();
            nn.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmShowReceiptRecord nn = new frmShowReceiptRecord();
            nn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmShowStaffAttendanceRecord nn = new frmShowStaffAttendanceRecord();
            nn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmshowcourse nn = new frmshowcourse();
            nn.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmShowReport nn = new frmShowReport();
            nn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmShowLogins nn = new frmShowLogins();
            nn.ShowDialog();
        }
        
    }
}
