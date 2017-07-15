using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_standalone
{
    public class SalaryRecord
    {
        public string PayslipID { get; set; }

        public string EmpID { get; set; }

        public string EmpName { get; set; }
        public string designation { get; set; }
        public string department { get; set; }

        public string date_of_calculation { get; set; }

        public string month { get; set; }
        public string year { get; set; }
        public string BasicSalary { get; set; }
        public string totalWHours { get; set; }
        public string totalOTHours { get; set; }
        public string allowances { get; set; }
        public string advances { get; set; }
        public string bonuses { get; set; }
        public string arrears { get; set; }
        public string GrossSalary { get; set; }
        public string OTPay { get; set; }
        public string EPF { get; set; }
        public string ETF { get; set; }
        public string NetSalary { get; set; }

        public SalaryRecord(string PayslipID, string EmpID,string EmpName, string designation, string department, string date_of_calculation, string month, string year, string BasicSalary, string totalWHours, string totalOTHours, string allowances, string advances, string bonuses, string arrears, string GrossSalary, string OTPay, string EPF, string ETF, string NetSalary)
        {
            this.PayslipID = PayslipID;
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.department = department;
            this.designation = designation;
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
