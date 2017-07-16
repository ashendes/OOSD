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
using System.IO;

namespace MainUI
{
    public partial class MainSwitchboard : Form
    {
        string[] images = { "hotwheels.jpg", "stuffed.jpg", "kid.jpg","puzzle.jpg","block.jpg" };
        int i = 0;
        public MainSwitchboard()
        {            
            InitializeComponent();
            DBConnection.setupDBConnection();            
        }

        private void btnDAE_Click(object sender, EventArgs e)
        {
            var dailyForm = new DailyAttendanceEntryForm();
            dailyForm.ShowDialog();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            var salaryForm = new SalaryAmendmentForm();
            salaryForm.ShowDialog();
        }

        private void btnEditRates_Click(object sender, EventArgs e)
        {
            var rateForm = new Amendment_Rates();
            rateForm.ShowDialog();
        }

        private void btnSalCalc_Click(object sender, EventArgs e)
        {
            var salCalForm = new SalaryInfo();
            salCalForm.ShowDialog();
        }

        

        private void mainButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web2.sltnet.lk/iwc_static/layout/login.html?lang=en-US&17.01_231235&svcs=abs,im,mail,calendar,c11n");
        }

        private void MainSwitchboard_Load(object sender, EventArgs e)
        {
            
            pbSlide.Image = Image.FromFile("C:/Users/ASUS/Documents/Repos/OOSD/MainUI/Images/" + images[0]);
            label2.Text = DateTime.Now.Date.ToString("dd-MMMM-yyyy");
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
            var stockForm = new Stock_Control_Form();
            stockForm.ShowDialog();
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            var resForm = new Resource_Control_Form();
            resForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEmployee();
            addForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewDatabase();
            viewForm.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new Search();
            searchForm.ShowDialog();
        }

        private void payrolltimeleft_Click(object sender, EventArgs e)
        {

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            var leaveForm = new Leave();
            leaveForm.ShowDialog();
        }

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            var payForm = new ViewPayrollInfo();
            payForm.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var abtForm = new About();
            abtForm.ShowDialog();
        }

        private void displayDate()
        {
            label2.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            i++;
            if (images.Length == i)
            {
                i = 0;
            }
            timer2.Enabled = true;
            
            pbSlide.Image = Image.FromFile("C:/Users/ASUS/Documents/Repos/OOSD/MainUI/Images/" + images[i]);
            
        }
    }
}
