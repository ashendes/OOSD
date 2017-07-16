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
    public partial class Leave : Form
    {
        MySqlConnection db;
        public Leave(MySqlConnection db)
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            this.db = db;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlCommand command = db.CreateCommand();
                command.CommandText = "INSERT INTO leavedatabase(Leave_ID,Employee_ID,Employee_Name,Start_Date,End_Date,Leave_Type) VALUES(@lid,@eid,@name,@sdate,@edate,@type)";

                command.Parameters.AddWithValue("@lid", tbLeave.Text);
                command.Parameters.AddWithValue("@eid", tbId.Text);
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@sdate", dtStart.Value.ToShortDateString());
                command.Parameters.AddWithValue("@edate", dtEnd.Value.ToShortDateString());
                command.Parameters.AddWithValue("@type", cbType.Text);

                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Record added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearForm();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query2 = "SHOW TABLE STATUS LIKE 'leavedatabase'";
                MySqlCommand command2 = new MySqlCommand(query2, db);
                db.Open();
                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    tbLeave.Text = reader.GetString(10);
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnAdd.Enabled = false;
        }


        private void tabControlLeave_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                MySqlCommand cmd = db.CreateCommand();
                string query = "SELECT *FROM leavedatabase";
                cmd.CommandText = query;

                DataTable dTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dTable);
                dataGridViewLeave.AutoGenerateColumns = false;
                dataGridViewLeave.Columns[0].DataPropertyName = "Leave_ID";
                dataGridViewLeave.Columns[1].DataPropertyName = "Employee_ID";
                dataGridViewLeave.Columns[2].DataPropertyName = "Employee_Name";
                dataGridViewLeave.Columns[4].DataPropertyName = "Start_Date";
                dataGridViewLeave.Columns[5].DataPropertyName = "End_Date";
                dataGridViewLeave.Columns[3].DataPropertyName = "Leave_Type";


                dataGridViewLeave.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonEnableState();
        }

        public void setButtonEnableState()
        {
            if (this.tbId.Text.Trim().Length > 0 && this.tbName.Text.Trim().Length > 0 && this.cbType.Text.Trim().Length > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        public void clearForm()
        {
            Control[] ctrl = { tbId,tbName,dtStart,dtEnd,cbType};
            foreach (Control c in ctrl)
            {
                c.ResetText();
            }
        }

        private void tbUleave_TextChanged(object sender, EventArgs e)
        {
            if (tbUleave.Text.Trim().Length > 0)
            {
                try
                {

                    string query3 = "SELECT Employee_ID, Employee_Name, Start_Date, End_Date, Leave_Type FROM leavedatabase WHERE Leave_ID = '" + tbUleave.Text + "'";
                    MySqlCommand comm = new MySqlCommand(query3, db);
                    db.Open();
                    MySqlDataReader reader2 = comm.ExecuteReader();
                    //while (reader2.Read())
                    //{
                    reader2.Read();
                    tbUid.Text = reader2.GetString(0);
                    tbUname.Text = reader2.GetString(1);
                    dtUstart.Value = DateTime.ParseExact(reader2.GetString(2), "dd/MM/yyyy", null);
                    dtUend.Value = DateTime.ParseExact(reader2.GetString(3), "dd/MM/yyyy", null);
                    cbType.Text = reader2.GetString(4);
                    //}
                    db.Close();
                }
                catch (MySqlException err)
                {
                    MessageBox.Show("Please enter a valid Leave ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.Close();
                }
                
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            MySqlCommand com =  db.CreateCommand();
            com.CommandText = "UPDATE leavedatabase SET Start_Date = @start, End_Date = @end, Leave_Type = @type WHERE Leave_ID = @lid";

            com.Parameters.AddWithValue("@start", dtUstart.Value.ToShortDateString());
            com.Parameters.AddWithValue("@end", dtUend.Value.ToShortDateString());
            com.Parameters.AddWithValue("@type", cbUtype.Text);
            com.Parameters.AddWithValue("@lid", tbUleave.Text);

            try
            {
                db.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Update Successfull!", "Message", MessageBoxButtons.OK);
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setUpdateButtonState()
        {
            if (this.cbType.Text.Trim().Length > 0)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void cbUtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            setUpdateButtonState();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}