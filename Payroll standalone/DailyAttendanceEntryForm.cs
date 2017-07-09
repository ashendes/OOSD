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

namespace Payroll_standalone
{
    public partial class DailyAttendanceEntryForm : Form
    {
        MySqlConnection db = new MySqlConnection("datasource=localhost;port=3306;database=softwaredb;username=root;password=");
        DateTimePicker picker;
        //DataTable dt = new DataTable();

        public DailyAttendanceEntryForm()
        {
            InitializeComponent();
            //fillData();
            
        }

        /*public void fillData()
        {
            string selectQuery = "SELECT Emp_ID,Date,In_Time,Out_Time FROM softwaredb.attendance";
            var adapter = new MySqlDataAdapter(selectQuery, dbconnection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }*/
        public void clearDataGrid()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Remove(row);
            }
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
        
        public void loadToDataTable()
        {
            dataGridView1.Rows.Add();
            using (db)
            {
                db.Open();
                var query = "SELECT `ID`, `First Name`, `Last Name` FROM employeedatabase";
                using (var command = new MySqlCommand(query, db))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                            row.Cells[0].Value = reader.GetString("ID");
                            row.Cells[1].Value = reader.GetString("First name") + " " + reader.GetString("Last name");
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
                db.Close();
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }

        }
        private void DailyAttendanceEntryForm_Load(object sender, EventArgs e)
        {
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
            dataGridView1.CellBeginEdit += this.dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit += this.dataGridView1_CellEndEdit;
        }

        private void cBxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (db)
            {
                db.Open();
                var query = "SELECT * FROM employeedatabase where ID= '"+ cBxEmpID.Text + "'";
                using (var command = new MySqlCommand(query, db))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        tbxEmpName.Text = reader.GetString("First name") +" "+ reader.GetString("Last name");                        
                    }
                }
                db.Close();
            }
        }

        private void panelSingleEntry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picker_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = picker.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Focused && (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3))
                {
                    picker.Location = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    picker.Width = dataGridView1.CurrentCell.Size.Width;
                    picker.Visible = true;

                    if (dataGridView1.CurrentCell.Value != null)
                    {
                        picker.Value = (DateTime)dataGridView1.CurrentCell.Value;
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
            dateTimePicker3.Value= ;
        }
    }
}
