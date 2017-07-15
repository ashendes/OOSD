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
    public partial class Search : Form
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=softwaredb";
        Employee emp = new Employee();
        public Search()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            btnEdit.Enabled = false;
            string text = tbSearch.Text;
            dataGridViewSearch.Enabled = true;
            try
            {
                MySqlConnection connection = new MySqlConnection(conString);

                MySqlCommand cmd = connection.CreateCommand();
                string query = "SELECT *FROM employeedatabase WHERE ID = '"+text+ "' OR First_Name = '" + text + "' OR Last_Name = '" + text + "' OR Department = '" + text + "' OR Designation = '" + text + "' OR Address = '" + text + "' OR Full_Name = '" + text + "' OR Residence_Telephone = '" + text + "' OR Mobile_Number = '" + text + "' OR Email = '" + text + "' OR Date_of_Birth = '" + text + "' OR Hire_Date = '" + text+"'";
                cmd.CommandText = query;

                DataTable dTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dataGridViewSearch.AutoGenerateColumns = false;
                    dataGridViewSearch.Columns[0].DataPropertyName = "ID";
                    dataGridViewSearch.Columns[1].DataPropertyName = "First_Name";
                    dataGridViewSearch.Columns[2].DataPropertyName = "Last_Name";
                    dataGridViewSearch.Columns[3].DataPropertyName = "Department";
                    dataGridViewSearch.Columns[4].DataPropertyName = "Designation";
                    dataGridViewSearch.Columns[5].DataPropertyName = "Mobile_Number";
                    dataGridViewSearch.Columns[6].DataPropertyName = "Address";
                    dataGridViewSearch.Columns[7].DataPropertyName = "Date_of_Birth";
                    dataGridViewSearch.Columns[8].DataPropertyName = "Gender";
                    dataGridViewSearch.Columns[9].DataPropertyName = "Email";
                    dataGridViewSearch.Columns[10].DataPropertyName = "Full_Name";
                    dataGridViewSearch.Columns[11].DataPropertyName = "Residence_Telephone";
                    dataGridViewSearch.Columns[12].DataPropertyName = "Hire_Date";
                    dataGridViewSearch.Columns[13].DataPropertyName = "Basic_Salary";

                    dataGridViewSearch.DataSource = dTable;
                }
                else
                {
                    MessageBox.Show("No results found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewSearch.DataSource = null;
                    dataGridViewSearch.Rows.Clear();
                    dataGridViewSearch.Refresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridViewSearch.Enabled = false;
            btnEdit.Enabled = false;
            btnView.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.DataSource = null;
            tbSearch.Clear();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form updateNew = new Update(emp.getId(), emp.getFullName(), emp.getFname(), emp.getLname(), emp.getDept(), emp.getDesig(), emp.getResTel(), emp.getMob(), emp.getAddress(), emp.getEmail(), emp.getDob(), emp.getHireDate(), emp.getGender());
            updateNew.ShowDialog();
        }

        private void dataGridViewSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEdit.Enabled = true;
            btnView.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSearch.Rows[e.RowIndex];
                setEmployeeAttributes(row);
                

            }
        }

        private void setEmployeeAttributes(DataGridViewRow row)
        {
            emp.setId(row.Cells["ColumnID"].Value.ToString());
            emp.setFullName(row.Cells["ColumnFull"].Value.ToString());
            emp.setFname(row.Cells["ColumnFirst"].Value.ToString());
            emp.setLname(row.Cells["ColumnLast"].Value.ToString());
            emp.setDept(row.Cells["ColumnDept"].Value.ToString());
            emp.setDesig(row.Cells["ColumnDes"].Value.ToString());
            emp.setMob(row.Cells["ColumnMob"].Value.ToString());
            emp.setAddress(row.Cells["ColumnAddress"].Value.ToString());
            emp.setDob(row.Cells["ColumnDob"].Value.ToString());
            emp.setGender(row.Cells["ColumnGen"].Value.ToString());
            emp.setEmail(row.Cells["ColumnEmail"].Value.ToString());
            emp.setResTel(row.Cells["ColumnRes"].Value.ToString());
            emp.setHireDate(row.Cells["ColumnHire"].Value.ToString());
            emp.setSalary(row.Cells["ColumnSalary"].Value.ToString());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form viewEmp = new ViewEmployee(emp.getId(), emp.getFullName(), emp.getFname(), emp.getLname(), emp.getDept(), emp.getDesig(), emp.getResTel(), emp.getMob(), emp.getAddress(), emp.getEmail(), emp.getDob(), emp.getHireDate(), emp.getGender(), emp.getSalary());
            viewEmp.ShowDialog();
        }
    }
}
