using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewEmployeeDatabase
{
    public partial class Update : Form
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=softwaredb";

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

        public Update(string id, string full, string fname, string lname, string dept, string des, string res, string mob, string addr, string email, string dob, string hire, string gender)
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

        }

        private void Update_Load(object sender, EventArgs e)
        {
            setDefaultValues();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setDefaultValues()
        {
            tbId.Text = id;
            tbFullname.Text = fullName;
            tbFname.Text = fName;
            tbLname.Text = lName;
            tbDept.Text = dept;
            tbPosition.Text = desig;
            tbResident.Text = resTel;
            tbMobile.Text = mobNum;
            tbAddress.Text = address;
            dtDob.Value = DateTime.ParseExact(dob, "dd/MM/yyyy", null);
            tbEmail.Text = email;
            cbGender.SelectedValue = gender;
            dtHire.Value = DateTime.ParseExact(hireDate, "dd/MM/yyyy", null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setDefaultValues();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "UPDATE employeedatabase SET Full_Name = @full,First_Name = @fname,Last_Name = @lname,Date_of_Birth = @dob,Department = @dept,Designation = @des,Gender = @gen,Email = @email,Residence_Telephone = @res,Mobile_Number = @mob,Hire_Date = @hire,Address = @addr WHERE ID = @id";

            command.Parameters.AddWithValue("@full", tbFullname.Text);
            command.Parameters.AddWithValue("@fname", tbFname.Text);
            command.Parameters.AddWithValue("@lname", tbLname.Text);
            command.Parameters.AddWithValue("@dob", dtDob.Value.ToString("dd/MM/yyyy"));
            command.Parameters.AddWithValue("@dept", tbDept.Text);
            command.Parameters.AddWithValue("@des", tbPosition.Text);
            command.Parameters.AddWithValue("@gen", cbGender.Text);
            command.Parameters.AddWithValue("@email", tbEmail.Text);
            command.Parameters.AddWithValue("@res", tbResident.Text);
            command.Parameters.AddWithValue("@mob", tbMobile.Text);
            command.Parameters.AddWithValue("@hire", dtHire.Value.ToString("dd/MM/yyyy"));
            command.Parameters.AddWithValue("@addr", tbAddress.Text);
            command.Parameters.AddWithValue("@id", tbId.Text);

            DialogResult dr = MessageBox.Show("Are you sure you want to update this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) 
            {
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully!", "Message", MessageBoxButtons.OK);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void setButtonEnabledState()
        {
            if ((this.tbFullname.Text.Trim().Length > 0 && this.tbFullname.Text.All(c => char.IsLetter(c) || c == ' '))
                && (this.tbFname.Text.Trim().Length > 0 && this.tbFname.Text.All(c => char.IsLetter(c) || c == ' '))
                && (this.tbLname.Text.Trim().Length > 0 && this.tbLname.Text.All(c => char.IsLetter(c) || c == ' '))
                && (this.tbResident.Text.All(char.IsDigit))
                && (this.tbMobile.Text.All(char.IsDigit))
                && this.tbDept.Text.All(c => char.IsLetter(c) || c == ' ')
                && this.tbPosition.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void tbFullname_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbLname_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbDept_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbPosition_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbResident_TextChanged(object sender, EventArgs e)
        {
            if (this.tbResident.Text.Length == 10 || this.tbResident.Text.Length == 0)
            {
                setButtonEnabledState();
            }
            else { btnUpdate.Enabled = false; }
        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {
            if (this.tbMobile.Text.Length == 10 || this.tbMobile.Text.Length == 0)
            {
                setButtonEnabledState();
            }
            else { btnUpdate.Enabled = false; }
        }
    }
}
