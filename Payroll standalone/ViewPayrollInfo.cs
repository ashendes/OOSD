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
    public partial class ViewPayrollInfo : Form
    {
        MySqlConnection db;
        public ViewPayrollInfo(MySqlConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (db)
                {
                    var query1 = "SELECT * FROM salaryinfo where Month = @month AND Year = @year";
                    
                    DataTable dt = new DataTable();
                    db.Open();
                    using (var command = new MySqlCommand(query1, db))
                    {
                        command.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                        command.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);
                        
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dt);
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.Columns[0].DataPropertyName = "PayslipID";
                        dataGridView1.Columns[1].DataPropertyName = "EmpID";
                        dataGridView1.Columns[2].DataPropertyName = "";
                        dataGridView1.Columns[3].DataPropertyName = "";
                        dataGridView1.Columns[4].DataPropertyName = "";
                        dataGridView1.Columns[5].DataPropertyName = "Date_of_Calculation";
                        dataGridView1.Columns[6].DataPropertyName = "Basic Salary";
                        dataGridView1.Columns[7].DataPropertyName = "Total hours worked";
                        dataGridView1.Columns[8].DataPropertyName = "Total OT hours";
                        dataGridView1.Columns[9].DataPropertyName = "Total Allowances";
                        dataGridView1.Columns[10].DataPropertyName = "Total Advances";
                        dataGridView1.Columns[11].DataPropertyName = "Total bonuses";
                        dataGridView1.Columns[12].DataPropertyName = "Arrears";
                        dataGridView1.Columns[13].DataPropertyName = "GrossSalary";
                        dataGridView1.Columns[14].DataPropertyName = "OTPay";
                        dataGridView1.Columns[15].DataPropertyName = "EPF";
                        dataGridView1.Columns[16].DataPropertyName = "ETF";
                        dataGridView1.Columns[17].DataPropertyName = "NetSalary";

                        dataGridView1.DataSource = dt;

                    }

                    db.Close();
                    
                }
                getEmpData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void getEmpData()
        {
            try
            {
                DataTable dt2 = new DataTable();
                using (db)
                {
                    var query2 = "SELECT ID, Full_Name, Department, Designation FROM employeedatabase";

                    using (var command = new MySqlCommand(query2, db))
                    {
                        db.Open();
                        
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dt2);
                        db.Close();
                    }
                }
               
                for(int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    /*foreach(DataRow datarow in dt2.Rows)
                    {
                        
                        if(dataGridView1.Rows[i].Cells[1].Value == datarow["ID"])
                        {
                            dataGridView1.Rows[i].Cells[2].Value = datarow["Full_Name"];
                            dataGridView1.Rows[i].Cells[3].Value = datarow["Designation"];
                            dataGridView1.Rows[i].Cells[4].Value = datarow["Department"];
                        }*/
                    DataRow[] rows = dt2.Select("ID = " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                    foreach(DataRow datarow in rows)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = datarow["Full_Name"];
                        dataGridView1.Rows[i].Cells[3].Value = datarow["Designation"];
                        dataGridView1.Rows[i].Cells[4].Value = datarow["Department"];
                    }
                        
                    
                }
            }catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewPayslip_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No record selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                SalaryRecord record = new SalaryRecord(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(), row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString(), row.Cells[17].Value.ToString());
                var payslip = new PayslipViewer();
                payslip.showReport(record);
                payslip.Show();
            }
        }
    }
}
