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
    public partial class PayslipViewer : Form
    {
        public PayslipViewer()
        {
            InitializeComponent();
        }

        public void showReport(SalaryRecord salaryRecord)
        {
            Payslip1.SetParameterValue("pPSID", salaryRecord.PayslipID);
            Payslip1.SetParameterValue("pEmpID", salaryRecord.EmpID);
            Payslip1.SetParameterValue("pEmpName", salaryRecord.EmpName);
            Payslip1.SetParameterValue("pDesignation", salaryRecord.designation);
            Payslip1.SetParameterValue("pDept", salaryRecord.department);
            Payslip1.SetParameterValue("pDate", salaryRecord.date_of_calculation);
            Payslip1.SetParameterValue("pMonth", salaryRecord.month);
            Payslip1.SetParameterValue("pYear", salaryRecord.year);
            Payslip1.SetParameterValue("pBasicSal", "Rs." +salaryRecord.BasicSalary);
            Payslip1.SetParameterValue("pAllowances", "Rs." + salaryRecord.allowances);
            Payslip1.SetParameterValue("pAdvances", "Rs." + salaryRecord.advances);
            Payslip1.SetParameterValue("pBonuses", "Rs." + salaryRecord.bonuses);
            Payslip1.SetParameterValue("pGSal", "Rs." + salaryRecord.GrossSalary);
            Payslip1.SetParameterValue("pOTPay", "Rs." + salaryRecord.OTPay);
            Payslip1.SetParameterValue("pArrears", "Rs." + salaryRecord.arrears);
            Payslip1.SetParameterValue("pEPF", "Rs." + salaryRecord.EPF);
            Payslip1.SetParameterValue("pNetSal", "Rs." + salaryRecord.NetSalary);
            crystalReportViewer1.ReportSource = Payslip1;
        }

        private void PayslipViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
