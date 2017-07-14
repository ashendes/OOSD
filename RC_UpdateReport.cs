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

namespace Oosd_project
{
    public partial class RC_UpdateReport : Form
    {
        public static RC_UpdateReport Current;
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
        Resoure_Inventory RI = new Resoure_Inventory();
        bool selected = false;

        public RC_UpdateReport()
        {
            Current = this;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resource_Control_Form.Current.ShowDialog();
        }

        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from softwaredb.resource_inventory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void RC_UpdateReport_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.resource_inventory where name like '" + textBox1.Text+"%'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            /**con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.resource_inventory where id like " + int.Parse(textBox1.Text), con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();**/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;

            try
            {
                result = MessageBox.Show("Are you sure to Quit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    this.Show();
                }

            }
            catch
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Resource s1 = new New_Resource(RI.id,RI.name,RI.quantity,RI.supplier_id);
            s1.txtBtn("Add");
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow delrow = dataGridView1.Rows[i];
                if (delrow.Selected == true)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    try
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from softwaredb.resource_inventory where CustCode=" + i + "";
                        cmd.Connection = con;
                        int count = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                    }
                }
            }
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Supplier_Detail s1 = new Update_Supplier_Detail();
            s1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                New_Resource NR = new New_Resource(RI.id, RI.name, RI.quantity, RI.supplier_id);
                NR.txtBtn("Edit");
                NR.ShowDialog();
                selected = false;
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            /**New_Resource frm = new New_Resource();

            frm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

            frm.ShowDialog();**/
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;
            }
        }

        public void setInventoryDetails(DataGridViewRow row)
        {
            RI.id = row.Cells[0].Value.ToString();
            RI.name = row.Cells[1].Value.ToString();
            RI.quantity = row.Cells[2].Value.ToString();
            RI.supplier_id = row.Cells[3].Value.ToString();

        }
    }
}
