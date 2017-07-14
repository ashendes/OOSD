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
    public partial class ViewDatabase : Form
    {
        string conString = "datasource=127.0.0.1;port=3306;username=root;password=;database=softwaredb";
        public ViewDatabase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conString);

                MySqlCommand cmd = connection.CreateCommand();
                string query = "SELECT *FROM employeedatabase";
                cmd.CommandText = query;

                DataTable dTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dTable);
                dataGridViewDatabase.AutoGenerateColumns = false;
                dataGridViewDatabase.Columns[0].DataPropertyName = "ID";
                dataGridViewDatabase.Columns[1].DataPropertyName = "First_Name";
                dataGridViewDatabase.Columns[2].DataPropertyName = "Last_Name";
                dataGridViewDatabase.Columns[3].DataPropertyName = "Department";
                dataGridViewDatabase.Columns[4].DataPropertyName = "Designation";
                dataGridViewDatabase.Columns[5].DataPropertyName = "Mobile_Number";
                dataGridViewDatabase.Columns[6].DataPropertyName = "Address";
                dataGridViewDatabase.Columns[7].DataPropertyName = "Date_of_Birth";
                dataGridViewDatabase.Columns[8].DataPropertyName = "Gender";
                dataGridViewDatabase.Columns[9].DataPropertyName = "Email";
                dataGridViewDatabase.Columns[10].DataPropertyName = "Full_Name";
                dataGridViewDatabase.Columns[11].DataPropertyName = "Residence_Telephone";
                dataGridViewDatabase.Columns[12].DataPropertyName = "Hire_Date";
                dataGridViewDatabase.Columns[13].DataPropertyName = "Basic_Salary";

                dataGridViewDatabase.DataSource = dTable;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
