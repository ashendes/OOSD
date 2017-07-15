using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeDatabase
{
    class Employee
    {
        private string id;
        private string fullName;
        private string fName;
        private string lName;
        private string dept;
        private string desig;
        private string address;
        private string resTel;
        private string mobNum;
        private string dob;
        private string email;
        private string hireDate;
        private string gender;
        private string salary;

        public void setId(string id)
        {
            this.id = id;
        }

        public string getId()
        {
            return this.id;
        }

        public void setFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public string getFullName()
        {
            return this.fullName;
        }

        public void setFname(string fName)
        {
            this.fName = fName;
        }

        public string getFname()
        {
            return this.fName;
        }

        public void setLname(string lName)
        {
            this.lName = lName;
        }

        public string getLname()
        {
            return this.lName;
        }

        public void setDept(string dept)
        {
            this.dept = dept;
        }

        public string getDept()
        {
            return this.dept;
        }

        public void setDesig(string desig)
        {
            this.desig = desig;
        }

        public string getDesig()
        {
            return this.desig;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setResTel(string resTel)
        {
            this.resTel = resTel;
        }

        public string getResTel()
        {
            return this.resTel;
        }

        public void setMob(string mob)
        {
            this.mobNum = mob;
        }

        public string getMob()
        {
            return this.mobNum;
        }

        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public string getDob()
        {
            return this.dob;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setHireDate(string hireDate)
        {
            this.hireDate = hireDate;
        }

        public string getHireDate()
        {
            return this.hireDate;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setSalary(string salary)
        {
            this.salary = salary;
        }

        public string getSalary()
        {
            return this.salary;
        }

    }


}
