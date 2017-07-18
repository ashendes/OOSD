using MySql.Data.MySqlClient;
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
    
    public partial class SalaryInfo : Form
    {
        MySqlConnection db;
        double EPF_Rate;
        double ETF_Rate;
        double OT_Rate;
        SalaryRecord currentRecord;

        public SalaryInfo(MySqlConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void onLoad()
        {                       
            getPayslipID();
            EPF_Rate = Convert.ToDouble(getRate("EPF"));
            ETF_Rate = Convert.ToDouble(getRate("ETF"));
            OT_Rate = Convert.ToDouble(getRate("OT"));
            btnConfirm.Enabled = false;
            btnViewPS.Enabled = false;
            lblEPF.Text = "EPF (" + EPF_Rate.ToString() + "%)";
            lblETF.Text = "ETF (" + ETF_Rate.ToString() + "%)";
            lblOT.Text = "OT Pay (" + OT_Rate.ToString() + "%)";
        }

        private void SalaryInfo_Load(object sender, EventArgs e)
        {
            
            loadTocbxEmpID();
            
            onLoad();
        }

        private string getRate(string ratename)
        {
            var value = "";
            try
            {
                using (db)
                {

                    var query = "SELECT * FROM rates where `rate name`=@ratename";
                    using (var command = new MySqlCommand(query, db))
                    {
                        command.Parameters.AddWithValue("@ratename", ratename);
                        db.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();
                            value = reader.GetString("Value");

                        }
                        db.Close();
                        return value;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void loadTocbxEmpID()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

       
        private void getPayslipID()
        {
            try
            {
                using (db)
                {
                    var query = "SHOW TABLE STATUS";
                    using (var command = new MySqlCommand(query, db))
                    {
                        db.Open();
                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                if (reader.GetString("Name") == "salaryinfo") { tbxPSID.Text = reader.GetString(10); }
                                
                            }
                        }
                        db.Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchIndex();
        }
        private void searchIndex()
        {
            if(cbxEmpID.Text != "")
            {
                try
                {
                    using (db)
                    {

                        var query = "SELECT * FROM employeedatabase where ID= '" + cbxEmpID.Text + "'";
                        using (var command = new MySqlCommand(query, db))
                        {
                            db.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                reader.Read();
                                tbxEmpName.Text = reader.GetString("First_Name") + " " + reader.GetString("Last_Name");
                                tbxDept.Text = reader.GetString("Department");
                                tbxDesignation.Text = reader.GetString("Designation");
                                tbxBasicSal.Text = Convert.ToDouble(reader.GetString("Basic_Salary")).ToString("0.00");
                                tbxArrears.Text = Convert.ToDouble(reader.GetString("Arrears")).ToString("0.00");
                            }
                            db.Close();
                        }
                        calculateTotalHours(cbxEmpID.Text, month, year);
                        getAmendments(cbxEmpID.Text, month, year);
                        formatTemp();
                    }
                }
                catch (Exception ex)
                {
                    if(ex is MySqlException)
                    {
                        MessageBox.Show("No such employee in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxEmpID.Text = "";
                        reset();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No employee selected" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void calculateTotalHours(string EmpID, DateTimePicker month, DateTimePicker year)
        {
            double totalHoursWorked=0;
            double totalOTHours=0;
            try
            {
                using (db)
                {
                    var query = "SELECT * FROM attendance where Emp_ID= '" + EmpID + "' AND MONTH(date) = '" + Convert.ToDateTime(month.Value).Month + "' AND YEAR(date) = '"+ Convert.ToDateTime(year.Value).Year +"'";
                    using (var command = new MySqlCommand(query, db))
                    {
                        db.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalHoursWorked += Convert.ToDouble(reader.GetString("Hours worked"));
                                totalOTHours += Convert.ToDouble(reader.GetString("OT Hours"));
                            }
                        }
                        db.Close();
                        tbxWHours.Text = totalHoursWorked.ToString();
                        tbxOTHours.Text = totalOTHours.ToString();
                    }    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getAmendments(string EmpID, DateTimePicker month, DateTimePicker year)
        {
            double totalAllowances = 0;
            double totalAdvances = 0;
            double totalBonuses = 0;
            try
            {
                using (db)
                {
                    var query = "SELECT * FROM `salary amendments` where Emp_ID= '" + EmpID + "' AND MONTH(date_of_amendment) = '" + Convert.ToDateTime(month.Value).Month + "' AND YEAR(date_of_amendment) = '" + Convert.ToDateTime(year.Value).Year + "'";
                    using (var command = new MySqlCommand(query, db))
                    {
                        db.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if(reader.GetString("Amendment_type") == "Allowance")
                                {
                                    totalAllowances += Convert.ToDouble(reader.GetString("Amount"));
                                }
                                else if(reader.GetString("Amendment_type") == "Advance")
                                {
                                    totalAdvances += Convert.ToDouble(reader.GetString("Amount"));
                                }
                                else if (reader.GetString("Amendment_type") == "Bonuses")
                                {
                                    totalBonuses += Convert.ToDouble(reader.GetString("Amount"));
                                }                             
                            }
                        }
                        db.Close();
                        tbxAllowances.Text = totalAllowances.ToString();
                        tbxAdvances.Text = totalAdvances.ToString();
                        tbxBonuses.Text = totalBonuses.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            onLoad();
            reset();

        }
        private void reset()
        {
            tbxBasicSal.ReadOnly = false;
            tbxWHours.ReadOnly = false;
            tbxOTHours.ReadOnly = false;
            tbxAllowances.ReadOnly = false;
            tbxAdvances.ReadOnly = false;
            tbxBonuses.ReadOnly = false;
            tbxArrears.ReadOnly = false;
            cbxEmpID.Text = "";
            tbxGSal.Text = "";
            tbxOTPay.Text = "";
            tbxEPF.Text = "";
            tbxETF.Text = "";
            tbxNetSal.Text = "";
            tbxEmpName.Text = "";
            tbxDept.Text = "";
            tbxDesignation.Text = "";
            tbxBasicSal.Text = "";
            tbxWHours.Text = "";
            tbxOTHours.Text = "";
            tbxArrears.Text = "";
            tbxAllowances.Text = "";
            tbxAdvances.Text = "";
            tbxBonuses.Text = "";
            btnConfirm.Enabled = false;
            btnViewPS.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                calculateSalary();
                tbxBasicSal.ReadOnly = true;
                tbxWHours.ReadOnly = true;
                tbxOTHours.ReadOnly = true;
                tbxAllowances.ReadOnly = true;
                tbxAdvances.ReadOnly = true;
                tbxBonuses.ReadOnly = true;
                tbxArrears.ReadOnly = true;
                btnConfirm.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void calculateSalary()
        {
            double GSal = Math.Round((Convert.ToDouble(tbxBasicSal.Text) + Convert.ToDouble(tbxAllowances.Text) + Convert.ToDouble(tbxArrears.Text) + Convert.ToDouble(tbxBonuses.Text)),2,MidpointRounding.AwayFromZero);
            double OTFactor = (Convert.ToDouble(tbxBasicSal.Text) / 200) * (OT_Rate / 100);
            double OTPay = Math.Round((Convert.ToDouble(tbxOTHours.Text) * OTFactor),2, MidpointRounding.AwayFromZero);
            double EPF = Math.Round((GSal * (EPF_Rate / 100)),2, MidpointRounding.AwayFromZero);
            double ETF = Math.Round((GSal * (ETF_Rate / 100)),2, MidpointRounding.AwayFromZero);
            double NetSal = Math.Round((GSal + OTPay - EPF),2, MidpointRounding.AwayFromZero);

            tbxGSal.Text = GSal.ToString();
            tbxOTPay.Text = OTPay.ToString();
            tbxEPF.Text = EPF.ToString();
            tbxETF.Text = ETF.ToString();
            tbxNetSal.Text = NetSal.ToString();
            currentRecord = new SalaryRecord(tbxPSID.Text, cbxEmpID.Text,tbxEmpName.Text, tbxDesignation.Text, tbxDept.Text, DateTime.Now.Date.ToString("yyyy-MM-dd"), month.Value.Month.ToString(), year.Text, tbxBasicSal.Text, tbxWHours.Text, tbxOTHours.Text, tbxAllowances.Text, tbxAdvances.Text, tbxAdvances.Text, tbxArrears.Text, tbxGSal.Text, tbxOTPay.Text, tbxEPF.Text, tbxETF.Text, tbxNetSal.Text);
            formatCalc();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (db)
                {
                    var query = "INSERT INTO salaryinfo (`EmpID`, `Date_of_Calculation`, `Month`, `Year`, `Basic Salary`, `Total hours worked`, `Total OT hours`, `Total Allowances`, `Total Advances`, `Total bonuses`, `Arrears`,`GrossSalary`, `OTPay`, `EPF`, `ETF`, `NetSalary`) VALUES (@EmpID,@DateOfCalculation,@month,@year,@BasicSal,@totalhours,@totalOThours, @totalAllowances,@totalAdvances,@totalBonuses,@arrears,@GSal,@OTPay,@EPF,@ETF,@NetSal)";
                    using (var command = new MySqlCommand(query, db))
                    {
                        db.Open();                        
                        command.Parameters.AddWithValue("@EmpID", cbxEmpID.Text);
                        command.Parameters.AddWithValue("@DateOfCalculation", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@month", month.Value.Month);
                        command.Parameters.AddWithValue("@year", year.Text);
                        command.Parameters.AddWithValue("@BasicSal", tbxBasicSal.Text);
                        command.Parameters.AddWithValue("@totalhours", tbxWHours.Text);
                        command.Parameters.AddWithValue("@totalOThours", tbxOTHours.Text);
                        command.Parameters.AddWithValue("@totalAllowances", tbxAllowances.Text);
                        command.Parameters.AddWithValue("@totalAdvances", tbxAdvances.Text);
                        command.Parameters.AddWithValue("@totalBonuses", tbxBonuses.Text);                        
                        command.Parameters.AddWithValue("@arrears", tbxArrears.Text);                       
                        command.Parameters.Add("@GSal", MySqlDbType.Double);
                        command.Parameters["@GSal"].Value = tbxGSal.Text;
                        command.Parameters.Add("@OTPay", MySqlDbType.Double);
                        command.Parameters["@OTPay"].Value = tbxOTPay.Text;
                        command.Parameters.Add("@EPF", MySqlDbType.Double);
                        command.Parameters["@EPF"].Value = tbxEPF.Text;
                        command.Parameters.Add("@ETF", MySqlDbType.Double);
                        command.Parameters["@ETF"].Value = tbxETF.Text;
                        command.Parameters.Add("@NetSal", MySqlDbType.Double);
                        command.Parameters["@NetSal"].Value = tbxNetSal.Text;
                        command.ExecuteNonQuery();
                        db.Close();
                    }

                    MessageBox.Show("Salary details added for " + cbxEmpID.Text + ": " + tbxEmpName.Text, "" + month.Text + " " + year.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnViewPS.Enabled = true;
                    btnConfirm.Enabled = false;
                }


            } catch (Exception ex)
            {
                if(ex is MySqlException)
                {
                    MessageBox.Show("Salary record of this month for current employee already exists.", "Already exists", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        private void filterNonNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnViewPS_Click(object sender, EventArgs e)
        {
            var form = new PayslipViewer();
            form.showReport(currentRecord);
            form.Show();
        }

        private void tbxBasicSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        private void tbxWHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        private void tbxOTHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        private void tbxAllowances_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        private void tbxAdvances_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        private void tbxBonuses_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        private void tbxArrears_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }

        

        private void setFormat(TextBox tbx)
        {
            tbx.Text = string.Format("{0:#,0.00}", double.Parse(tbx.Text));
            
        }

        private void tbxBasicSal_Leave(object sender, EventArgs e)
        {
            //setFormat(tbxBasicSal);
        }

        private void formatTemp()
        {
            tbxBasicSal.Text = string.Format("{0:#,0.00}", double.Parse(tbxBasicSal.Text));
            tbxAllowances.Text = string.Format("{0:#,0.00}", double.Parse(tbxAllowances.Text));
            tbxAdvances.Text = string.Format("{0:#,0.00}", double.Parse(tbxAdvances.Text));
            tbxBonuses.Text = string.Format("{0:#,0.00}", double.Parse(tbxBonuses.Text));
            tbxArrears.Text = string.Format("{0:#,0.00}", double.Parse(tbxArrears.Text));
            tbxWHours.Text = string.Format("{0:#,0.#}", double.Parse(tbxWHours.Text));
            tbxOTHours.Text = string.Format("{0:#,0.#}", double.Parse(tbxOTHours.Text));
        }
        private void formatCalc()
        {
            tbxGSal.Text = string.Format("{0:#,0.00}", double.Parse(tbxGSal.Text));
            tbxOTPay.Text = string.Format("{0:#,0.00}", double.Parse(tbxOTPay.Text));
            tbxEPF.Text = string.Format("{0:#,0.00}", double.Parse(tbxEPF.Text));
            tbxETF.Text = string.Format("{0:#,0.00}", double.Parse(tbxETF.Text));
            tbxNetSal.Text = string.Format("{0:#,0.00}", double.Parse(tbxNetSal.Text));
            
        }

        private void tbxOTHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbxEmpID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxEmpID_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbxEmpID_TextChanged(object sender, EventArgs e)
        {      

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxID.Text == "")
            {
                MessageBox.Show("Enter an ID or Name", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbxID.Text != "" )
            {
                try
                {
                    using (db)
                    {
                        string query = "SELECT * FROM employeedatabase WHERE ID = '" + tbxID.Text + "'";
                        using (var command = new MySqlCommand(query, db))
                        {
                            db.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                reader.Read();
                                tbxEmpName.Text = reader.GetString("First_Name") + " " + reader.GetString("Last_Name");
                                tbxDept.Text = reader.GetString("Department");
                                tbxDesignation.Text = reader.GetString("Designation");
                                tbxBasicSal.Text = Convert.ToDouble(reader.GetString("Basic_Salary")).ToString("0.00");
                                tbxArrears.Text = Convert.ToDouble(reader.GetString("Arrears")).ToString("0.00");
                            }
                            db.Close();
                        }
                        cbxEmpID.Text = tbxID.Text;
                        calculateTotalHours(cbxEmpID.Text, month, year);
                        getAmendments(cbxEmpID.Text, month, year);
                        formatTemp();
                    }
                }
                catch (Exception ex)
                {
                    if (ex is MySqlException)
                    {
                        MessageBox.Show("No such employee in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxEmpID.Text = "";
                        reset();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            
            }
        
            
        }

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterNonNumericInput(sender, e);
        }
    }
}
