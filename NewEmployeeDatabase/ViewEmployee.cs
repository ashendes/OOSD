using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmployeeDatabase
{
    public partial class ViewEmployee : Form
    {
        //string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=softwaredb";

        public string id;
        public string fullName;
        public string fName;
        public string lName;
        public string dept;
        public string desig;
        public string address;
        public string resTel;
        public string mobNum;
        public string dob;
        public string email;
        public string hireDate;
        public string gender;
        public string salary;

        public ViewEmployee(string id, string full, string fname, string lname, string dept, string des, string res, string mob, string addr, string email, string dob, string hire, string gender,string salary)
        {
            InitializeComponent();
            this.id = id;
            this.fullName = full;
            this.fName = fname;
            this.lName = lname;
            this.dept = dept;
            this.desig = des;
            this.resTel = res;
            this.mobNum = mob;
            this.address = addr;
            this.dob = dob;
            this.email = email;
            this.hireDate = hire;
            this.gender = gender;
            this.salary = salary;
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            this.lbName.Text = fName + " " + lName;
            this.lbId.Text = id;
            this.lbFull.Text = fullName;
            this.lbAddr.Text = address;
            this.lbDob.Text = dob;
            this.lbGen.Text = gender;
            this.lbDept.Text = dept;
            this.lbDes.Text = desig;
            this.lbHire.Text = hireDate;
            this.lbEmail.Text = email;
            this.lbRes.Text = resTel;
            this.lbMob.Text = mobNum;
            this.lbSalary.Text = salary;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
