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
    public partial class AddEmployee : Form
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=softwaredb";
        
        public AddEmployee()
        {
            InitializeComponent();
            
        }

        private void DefaultFormSettings()
        {
            Control[] ctr = { tbFullname, tbFname, tbLname, tbPosition, tbResident, tbEmail, tbDept, tbAddress, tbMobile, cbGender, dtDob, dtHire,tbSalary };
            foreach (Control c in ctr)
            {
                c.ResetText();               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DefaultFormSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DefaultFormSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO employeedatabase(Full_Name,First_Name,Last_Name,Date_of_Birth,Department,Designation,Gender,Email,Residence_Telephone,Mobile_Number,Hire_Date,Address,Basic_Salary) VALUES(@full,@fname,@lname,@dob,@dept,@pos,@gender,@email,@resid,@mobile,@hire,@address,@salary)";

            command.Parameters.AddWithValue("@full", tbFullname.Text);
            command.Parameters.AddWithValue("@fname", tbFname.Text);
            command.Parameters.AddWithValue("@lname", tbLname.Text);
            command.Parameters.AddWithValue("@dob", dtDob.Value.ToString("dd/MM/yyyy"));
            command.Parameters.AddWithValue("@dept", tbDept.Text);
            command.Parameters.AddWithValue("@pos", tbPosition.Text);
            command.Parameters.AddWithValue("@gender", cbGender.Text);
            command.Parameters.AddWithValue("@email", tbEmail.Text);
            command.Parameters.AddWithValue("@resid", tbResident.Text);
            command.Parameters.AddWithValue("@mobile", tbMobile.Text);
            command.Parameters.AddWithValue("@hire", dtHire.Value.ToString("dd/MM/yyyy"));
            command.Parameters.AddWithValue("@address", tbAddress.Text);
            command.Parameters.AddWithValue("@salary", tbSalary.Text);
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                                
                MessageBox.Show("Employee Added Succesfully!","Message",MessageBoxButtons.OK);

                con.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }


        private void AddEmployee_Load_1(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                MySqlConnection conLoad = new MySqlConnection(conString);
                string query2 = "SHOW TABLE STATUS LIKE 'employeedatabase'";
                MySqlCommand command2 = conLoad.CreateCommand();
                command2.CommandText = query2;

                conLoad.Open();
                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    tbId.Text = reader.GetString(10);
                }
                conLoad.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void setButtonEnabledState()
        {
            if ((this.tbFullname.Text.Trim().Length > 0 && this.tbFullname.Text.All(c=>char.IsLetter(c)||c==' '))
                && (this.tbFname.Text.Trim().Length > 0 && this.tbFname.Text.All(c => char.IsLetter(c) || c == ' '))
                && (this.tbLname.Text.Trim().Length > 0 && this.tbLname.Text.All(c=>char.IsLetter(c)||c==' '))
                && (this.tbSalary.Text.Trim().Length > 0 && this.tbSalary.Text.All(char.IsDigit))
                && this.tbResident.Text.All(c=>char.IsDigit(c) || c== '+')
                && this.tbMobile.Text.All(c => char.IsDigit(c) || c == '+')
                && this.tbDept.Text.All(c => char.IsLetter(c) || c == ' ')
                && this.tbPosition.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void tbLname_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbFullname_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbSalary_TextChanged(object sender, EventArgs e)
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

        private void tbResident_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabledState();
        }
    }
}
