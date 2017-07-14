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

        public SalaryInfo()
        {
            InitializeComponent();
        }

        private void onLoad()
        {                       
            getPayslipID();
            EPF_Rate = Convert.ToDouble(getRate("EPF"));
            ETF_Rate = Convert.ToDouble(getRate("ETF"));
            OT_Rate = Convert.ToDouble(getRate("OT"));
            lblEPF.Text = "EPF (" + EPF_Rate.ToString() + "%)";
            lblETF.Text = "ETF (" + ETF_Rate.ToString() + "%)";
            lblOT.Text = "OT Pay (" + OT_Rate.ToString() + "%)";
        }

        private void SalaryInfo_Load(object sender, EventArgs e)
        {
            db = DBConnection.getDBConnection();
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
                    var query = "SELECT * FROM salaryinfo ORDER BY PayslipID DESC LIMIT 1";
                    using (var command = new MySqlCommand(query, db))
                    {
                        db.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            
                            reader.Read();
                            tbxPSID.Text = Convert.ToString(reader.GetInt32("PayslipID") + 1);                            
                            

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
                            tbxEmpName.Text = reader.GetString("First name") + " " + reader.GetString("Last name");
                            tbxDept.Text = reader.GetString("Department");
                            tbxDesignation.Text = reader.GetString("Designation");
                            tbxBasicSal.Text = reader.GetString("Basic Salary");
                            tbxArrears.Text = reader.GetString("Arrears");
                        }
                        db.Close();
                    }
                    calculateTotalHours(cbxEmpID.Text , month, year);
                    getAmendments(cbxEmpID.Text, month, year);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateSalary();

        }

        private void calculateSalary()
        {
            double GSal = Convert.ToDouble(tbxBasicSal.Text) + Convert.ToDouble(tbxAllowances.Text) + Convert.ToDouble(tbxArrears.Text) + Convert.ToDouble(tbxBonuses.Text);
            double OTFactor = (Convert.ToDouble(tbxBasicSal.Text) / 200) * (OT_Rate / 100);
            double OTPay = Convert.ToDouble(tbxOTHours.Text) * OTFactor;
            double EPF = GSal * (EPF_Rate / 100);
            double ETF = GSal * (ETF_Rate / 100);
            double NetSal = GSal + OTPay - EPF;

            tbxGSal.Text = GSal.ToString();
            tbxOTPay.Text = OTPay.ToString();
            tbxEPF.Text = EPF.ToString();
            tbxETF.Text = ETF.ToString();
            tbxNetSal.Text = NetSal.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (db)
                {
                    var query = "INSERT into salaryinfo  VALUES (@PayslipID, @EmpID, @DateOfCalculation, @month, @year, @BasicSal, @totalhours, @totalOThours, @totalAllowances, @totalAdvances, @totalBonuses, @arrears, @GSal, @OTPay, @EPF, @ETF, @NetSal)";
                    using (var command = new MySqlCommand(query, db))
                    {                       
                        db.Open();
                        command.Parameters.AddWithValue("@PayslipID", tbxPSID.Text);
                        command.Parameters.AddWithValue("@EmpID", cbxEmpID.Text);
                        command.Parameters.AddWithValue("@DateOfCalculation", DateTime.Now.ToString());
                        command.Parameters.AddWithValue("@month", month.Text);
                        command.Parameters.AddWithValue("@year", year.Text);
                        command.Parameters.AddWithValue("@BasicSal", tbxBasicSal.Text);
                        command.Parameters.AddWithValue("@totalhours", tbxWHours.Text);
                        command.Parameters.AddWithValue("@totalOThours", tbxOTHours.Text);
                        command.Parameters.AddWithValue("@totalAllowances", tbxAllowances.Text);
                        command.Parameters.AddWithValue("@totalAdvances", tbxAdvances.Text);
                        command.Parameters.AddWithValue("@totalBonuses", tbxBonuses.Text);                        
                        command.Parameters.AddWithValue("@arrears", tbxArrears.Text);
                        command.Parameters.AddWithValue("@GSal,", tbxGSal.Text);
                        command.Parameters.AddWithValue("@OTPay,", tbxOTPay.Text);
                        command.Parameters.AddWithValue("@EPF", tbxEPF.Text);
                        command.Parameters.AddWithValue("@ETF", tbxETF.Text);
                        command.Parameters.AddWithValue("@NetSal", tbxNetSal.Text);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        db.Close();                           
                    }

                    MessageBox.Show("Salary details added for " + cbxEmpID.Text + ": " + tbxEmpName, ""+ month.Text + " " + year.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
