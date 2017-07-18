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
using SemProject;
using Microsoft.Office.Interop.Word;

namespace MainUI
{
    public partial class MainSwitchboard : Form
    {
        string[] images = { "hotwheels.jpg", "stuffed.jpg", "kid.jpg", "puzzle.jpg", "block.jpg" };
        int i = 0;
        UserType newUser;
        
        public MainSwitchboard(string user)
        {
            InitializeComponent();
            username.Text = user;
            newUser = new UserType(user);
        }

        private void btnDAE_Click(object sender, EventArgs e)
        {
            var dailyForm = new DailyAttendanceEntryForm(DBConnection.getDBConnection());
            dailyForm.ShowDialog();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            var salaryForm = new SalaryAmendmentForm(DBConnection.getDBConnection());
            salaryForm.ShowDialog();
        }

        private void btnEditRates_Click(object sender, EventArgs e)
        {
            var rateForm = new Amendment_Rates(DBConnection.getDBConnection());
            rateForm.ShowDialog();
        }

        private void btnSalCalc_Click(object sender, EventArgs e)
        {
            var salCalForm = new SalaryInfo(DBConnection.getDBConnection());
            salCalForm.ShowDialog();
        }



        private void mainButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web2.sltnet.lk/iwc_static/layout/login.html?lang=en-US&17.01_231235&svcs=abs,im,mail,calendar,c11n");
        }

        private void MainSwitchboard_Load(object sender, EventArgs e)
        {
            pbSlide.Image = Image.FromFile("C:/Users/ASUS/Desktop/OOSD/MainUI/Images/" + images[0]);
            label2.Text = DateTime.Now.Date.ToString("dd-MMMM-yyyy");
            /*lbldaysleft.Parent = payrolltimeleft;
            label1.Parent = payrolltimeleft;
            lbldaysleft.BringToFront();
            label1.BringToFront();*/
            payrolltimeleft.Minimum = 0;
            payrolltimeleft.Maximum = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            payrolltimeleft.Value = DateTime.Now.Day;
            lbldaysleft.Text = Convert.ToString(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day) + " days";
            lbldaysleft.Visible = true;

            grantPrivileges(newUser.getType());
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
            var leaveForm = new Leave(DBConnection.getDBConnection());
            leaveForm.ShowDialog();
        }

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            var payForm = new ViewPayrollInfo(DBConnection.getDBConnection());
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
            var savedocform = new SaveDocumentForm();
            savedocform.ShowDialog();
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

            pbSlide.Image = Image.FromFile("C:/Users/ASUS/Desktop/OOSD/MainUI/Images/" + images[i]);          

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if(frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }                
            }
        }

        private void MainSwitchboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DisposeAllButThis(this);
                    Hide();                    
                }
                finally
                {
                    Login.getLoginForm().Show();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnFindDoc_Click(object sender, EventArgs e)
        {
            var finddoc = new FindDocumentForm();
            finddoc.ShowDialog();
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
                Document document = ap.Documents.Open(@"C:\Users\ASUS\Desktop\Templates\template.doc", ReadOnly:false);
                ap.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void grantPrivileges(string type)
        {
            if (type.Equals("admin"))
            {
                btnSalCalc.Enabled = false;
            }
            else if (type.Equals("acc"))
            {
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
                btnSalCalc.Enabled = false;
                btnSA.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSlide_Click(object sender, EventArgs e)
        {

        }
    }
}
