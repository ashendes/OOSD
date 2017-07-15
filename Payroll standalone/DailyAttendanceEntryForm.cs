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
using System.Globalization;

namespace Payroll_standalone
{
    public partial class DailyAttendanceEntryForm : Form
    {
        MySqlConnection db;
        DateTimePicker picker;
        

        public DailyAttendanceEntryForm()
        {
            InitializeComponent();
            
        }

        private void DailyAttendanceEntryForm_Load(object sender, EventArgs e)
        {
            db = DBConnection.getDBConnection();
            dateTimePicker2.Value = DateTime.Now;
            loadTocbxEmpID();
            loadToDataTable();
            picker = new DateTimePicker();
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "h:mm tt";
            picker.ShowUpDown = true;
            picker.Visible = false;
            dataGridView1.Controls.Add(picker);
            picker.ValueChanged += this.picker_ValueChanged;

        }

        
        public void clearDataGrid()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                clearRow(row, true);
            }
            
        }

        public void clearRow(DataGridViewRow row, bool clearAll)
        {
            row.Cells[2].Value = row.Cells[2].DefaultNewRowValue;
            row.Cells[3].Value = row.Cells[3].DefaultNewRowValue;
            if (clearAll) { row.Cells[4].Value = row.Cells[4].DefaultNewRowValue; }
            
        }

        private void btnAddSingle_Click(object sender, EventArgs e)
        {
            panelTableEntry.Visible = false;
            panelSingleEntry.Visible = true;
            

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            panelTableEntry.Visible = true;
            panelSingleEntry.Visible = false;
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
                                cBxEmpID.Items.Add(reader.GetString("ID"));
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
        
        public void loadToDataTable()
        {
            dataGridView1.Rows.Add();
            
            using (db)
            {
                
                var query = "SELECT `ID`, `First_Name`, `Last_Name` FROM employeedatabase";
                using (var command = new MySqlCommand(query, db))
                {
                    db.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                            row.Cells[0].Value = reader.GetString("ID");
                            row.Cells[1].Value = reader.GetString("First_Name") + " " + reader.GetString("Last_Name");
                            dataGridView1.Rows.Add(row);
                        }
                    }
                    db.Close();
                }
                
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }

        }
   

        private void cBxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (db)
                {
                    db.Open();
                    var query = "SELECT * FROM employeedatabase where ID= '" + cBxEmpID.Text + "'";
                    using (var command = new MySqlCommand(query, db))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();
                            tbxEmpName.Text = reader.GetString("First_Name") + " " + reader.GetString("Last_Name");
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

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void picker_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = picker.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Focused && (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3) && !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[4].Value))
                {
                    picker.Location = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    picker.Width = dataGridView1.CurrentCell.Size.Width;
                    picker.Visible = true;

                    if (dataGridView1.CurrentCell.Value != null)
                    {
                        picker.Value = DateTime.ParseExact(dataGridView1.CurrentCell.Value.ToString(), "h:mm tt", System.Globalization.CultureInfo.InvariantCulture) ;
                    }
                    else
                    {
                        picker.Value = DateTime.Now;
                    }
                }
                else
                {
                    picker.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cBxEmpID.Text = "";
            tbxEmpName.Text = "";
            //dateTimePicker3.Value= ;
        }

        private double calculateHoursWorked(DateTimePicker dt1, DateTimePicker dt2)
        {
            var ts = (dt2.Value - dt1.Value).TotalHours;
            if (ts >= 0)
            {
                return ((Math.Round(ts * 2, MidpointRounding.AwayFromZero)) / 2);
            }
            else
            {
                MessageBox.Show("Invalid times entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt1.Focus();
                return 0;
            }            
        }

        private double calculateHoursWorked(DateTime dt1, DateTime dt2)
        {
            var ts = (dt2 - dt1).TotalHours;
            if (ts >= 0)
            {
                return ((Math.Round(ts * 2, MidpointRounding.AwayFromZero)) / 2);
            }
            else
            {
                MessageBox.Show("Invalid times entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            double hours_worked = calculateHoursWorked(dateTimePicker3, dateTimePicker4);
            
            double OThours;
            if (hours_worked != 0)
            {
                if (hours_worked >= 8) {
                     OThours = hours_worked - 8;
                }
                else
                {
                    OThours = 0;
                }
                
                try
                {
                    using (db)
                    {

                        var query = "INSERT into attendance VALUES (" + Convert.ToInt32(cBxEmpID.Text) + ",'" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "','" + dateTimePicker3.Value.TimeOfDay + "','" + dateTimePicker4.Value.TimeOfDay + "','" + hours_worked + "','" + OThours + "')";
                        using (var command = new MySqlCommand(query, db))
                        {
                            db.Open();
                            command.ExecuteNonQuery();                 
                            db.Close();
                        }
                        MessageBox.Show("Attendance updated for Employee " + cBxEmpID.Text + ":" + tbxEmpName.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cBxEmpID.SelectedIndex = cBxEmpID.SelectedIndex + 1;
                    }
            
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (db)
                {
                    
                    double hours_worked;
                    double OThours;
                    var query = "INSERT into attendance (Emp_ID, Date, In_Time, Out_Time, `Hours Worked`, `OT Hours`) VALUES (@EmpID, @Date, @InTime, @OutTime, @HoursWorked, @OTHours)";
                    using (var command = new MySqlCommand(query, db))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {                            
                            if(Convert.ToBoolean(row.Cells[4].Value))
                            {
                                continue;
                            }
                            hours_worked = calculateHoursWorked(Convert.ToDateTime(row.Cells[2].Value), Convert.ToDateTime(row.Cells[3].Value));


                            if (hours_worked != 0)
                            {
                                if (hours_worked >= 8)
                                {
                                    OThours = hours_worked - 8;
                                }
                                else
                                {
                                    OThours = 0;
                                }
                                db.Open();
                                command.Parameters.AddWithValue("@EmpID", Convert.ToInt32(row.Cells[0].Value));
                                command.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@InTime", row.Cells[2].Value);
                                command.Parameters.AddWithValue("@OutTime", row.Cells[3].Value);
                                command.Parameters.AddWithValue("@HoursWorked", hours_worked.ToString());
                                command.Parameters.AddWithValue("@OTHours", OThours.ToString());
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();
                                db.Close();
                            }
                        }                      
                    }
                    
                    MessageBox.Show("Attendance updated for " + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"),"" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clearDataGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Focused && dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    if (Convert.ToBoolean(dataGridView1.CurrentCell.Value))
                    {
                        clearRow(dataGridView1.Rows[e.RowIndex], false);
                        dataGridView1.CurrentRow.Cells[2].ReadOnly = true;
                        dataGridView1.CurrentRow.Cells[2].ReadOnly = true;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnClrRow_Click(object sender, EventArgs e)
        {
            clearRow(dataGridView1.CurrentRow, true);
        }

        private void btnClrAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Clear all entered data?", "Clear Table ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                clearDataGrid();
                dateTimePicker1.Focus();
            }

                
        }
    }
}
