using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_standalone
{
    public partial class Switchboard : Form
    {
        public Switchboard()
        {
            InitializeComponent();
            DBConnection.setupDBConnection();
        }

        private void btnDAE_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DailyAttendanceEntryForm();
            form.Show();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new SalaryAmendmentForm();
            form.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web2.sltnet.lk/iwc_static/layout/login.html?lang=en-US&17.01_231235&svcs=abs,im,mail,calendar,c11n");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalCalc_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new SalaryInfo();
            form.Show();
        }

        private void btnEditRates_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Amendment_Rates();
            form.Show();
        }
    }
}
