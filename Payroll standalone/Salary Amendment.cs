using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_standalone
{
    public partial class SalaryAmendmentForm : Form
    {
        
        MySqlConnection db;
        
        int typeIndex;
        public SalaryAmendmentForm(MySqlConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void tbxAmount_Leave(object sender, EventArgs e)
        {
            tbxAmount.Text = string.Format("{0:#,0.00}", double.Parse(tbxAmount.Text));
        }

        private void SalaryAmendmentForm_Load(object sender, EventArgs e)
        {
            
            loadTocbxEmpID();
            cbxEmpID.Focus();
        }

        private void cbxAmendType_DropDown(object sender, EventArgs e)
        {
            lblSelect.Visible = false;
        }

        private void cbxAmendType_SelectedValueChanged(object sender, EventArgs e)
        {
            lblSelect.Visible = false;
        }

        public void loadTocbxEmpID()
        {
            try
            {
                using (db)
                {
                    db.Open();
                    var query = "SELECT ID FROM employeedatabase";
                    using (var command = new MySqlCommand(query, db))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbxEmpID.Items.Add(reader.GetString("ID"));
                            }
                        }
                    }
                    db.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmpID.SelectedIndex != -1)
            {
                lblSelect2.Visible = false;
                try
                {
                    using (db)
                    {
                        db.Open();
                        var query = "SELECT * FROM employeedatabase where ID= '" + cbxEmpID.Text + "'";
                        using (var command = new MySqlCommand(query, db))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                reader.Read();
                                tbxEmpName.Text = reader.GetString("First_name") + " " + reader.GetString("Last_name");
                            }
                        }
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cbxEmpID.Text=="" && cbxAmendType.Text == "" && tbxAmount.Text == "")
            {
                this.Close();
            }
            else if (MessageBox.Show("Discard all entered data?", "Salary Amendment ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                cbxEmpID.Focus();
            }
        }

        private void cbxAmendType_Leave(object sender, EventArgs e)
        {
            if (cbxAmendType.Text == "")
            {
                lblSelect.Visible = true;
            }
            if(cbxAmendType.Text == "Advance")
            {
                typeIndex = 1;
            }
            else if (cbxAmendType.Text == "Allowance")
            {
                typeIndex = 2;
            }
            else if (cbxAmendType.Text == "Bonus")
            {
                typeIndex = 3;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (db)
                {

                    var query = "INSERT into `salary amendments` (`Emp_ID`, `Date_of_amendment` , `Amount` , `Amendment_type`) VALUES (" + Convert.ToInt32(cbxEmpID.Text) + ",'" + dateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "'," + tbxAmount.Text + "," + typeIndex + ")";
                    using (var command = new MySqlCommand(query, db))
                    {
                        db.Open();
                        command.ExecuteNonQuery();
                        db.Close();
                    }
                    MessageBox.Show("Salary amendments added for Employee " + cbxEmpID.Text + ":" + tbxEmpName.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Add another amendment?", "Salary Amendment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private String convertCurrency(string input)
        {
            string value = input.Substring("float;#".Length);

            if (value.Contains("."))
            {
                value = value.TrimEnd('0');
                
                if (value.EndsWith("."))
                {
                    value = value.Substring(0, value.Length - 1);
                }
            }
            return value;
        }

        private void tbxAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblSelect2_Click(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            cbxEmpID.SelectedIndex = -1;
            cbxAmendType.SelectedIndex = -1;
            lblSelect.Visible = true;
            tbxEmpName.Text = "";
            tbxAmount.Text = "0.00";
        }
    }
}
