using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_standalone
{
    class SalaryRecord
    {
        private string PayslipID { get; set; }

        private string EmpID { get; set; }

        private string date_of_calculation { get; set; }

        private string month { get; set; }
        private string year { get; set; }
        private string BasicSalary { get; set; }
        private string totalWHours { get; set; }
        private string totalOTHours { get; set; }
        private string allowances { get; set; }
        private string advances { get; set; }
        private string bonuses { get; set; }
        private string arrears { get; set; }
        private string GrossSalary { get; set; }
        private string OTPay { get; set; }
        private string EPF { get; set; }
        private string ETF { get; set; }
        private string NetSalary { get; set; }

        public SalaryRecord(string PayslipID, string EmpID, string date_of_calculation, string month, string year, string BasicSalary, string totalWHours, string totalOTHours, string allowances, string advances, string bonuses, string arrears, string GrossSalary, string OTPay, string EPF, string ETF, string NetSalary)
        {
            this.PayslipID = PayslipID;
            this.EmpID = EmpID;
            this.date_of_calculation = date_of_calculation;
            this.month = month;
            this.year = year;
            this.BasicSalary = BasicSalary;
            this.totalWHours = totalWHours;
            this.totalOTHours = totalOTHours;
            this.allowances = allowances;
            this.advances = advances;
            this.bonuses = bonuses;
            this.arrears = arrears;
            this.GrossSalary = GrossSalary;
            this.OTPay = OTPay;
            this.EPF = EPF;
            this.ETF = ETF;
            this.NetSalary = NetSalary;
        }
    }
}
