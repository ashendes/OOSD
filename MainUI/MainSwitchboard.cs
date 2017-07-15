using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_standalone;
using NewEmployeeDatabase;
using Oosd_project;

namespace MainUI
{
    public partial class MainSwitchboard : Form
    {
        public MainSwitchboard()
        {
            InitializeComponent();
            DBConnection.setupDBConnection();
        }

        private void btnDAE_Click(object sender, EventArgs e)
        {
            var form = new DailyAttendanceEntryForm();
            form.Show();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            var form = new SalaryAmendmentForm();
            form.Show();
        }

        private void btnEditRates_Click(object sender, EventArgs e)
        {
            var form = new Amendment_Rates();
            form.Show();
        }

        private void btnSalCalc_Click(object sender, EventArgs e)
        {
            var form = new SalaryInfo();
            form.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            var form = new Main();
            form.Show();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web2.sltnet.lk/iwc_static/layout/login.html?lang=en-US&17.01_231235&svcs=abs,im,mail,calendar,c11n");
        }

        private void MainSwitchboard_Load(object sender, EventArgs e)
        {
            
            payrolltimeleft.Minimum = 0;
            payrolltimeleft.Maximum = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            payrolltimeleft.Value = DateTime.Now.Day;


        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Stock_Control_Form();
            form.Show();
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            var form = new Resource_Control_Form();
            form.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEmployee();
            form.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var form = new ViewDatabase();
            form.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var form = new Search();
            form.Show();
        }

        private void payrolltimeleft_Click(object sender, EventArgs e)
        {

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            var form = new Leave();
            form.Show();
        }

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            var form = new ViewPayrollInfo();
            form.Show();
        }
    }
}
