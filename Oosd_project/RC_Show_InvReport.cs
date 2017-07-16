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
    public partial class RC_Show_InvReport : Form
    {
        public static RC_Show_InvReport Current;
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        Resoure_Inventory RI = new Resoure_Inventory();
        bool selected = false;

        public RC_Show_InvReport()
        {
            Current = this;
            InitializeComponent();
        }

        //Display method of grid view
        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from softwaredb.Resource_inventory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.resource_inventory where name like'" + textBox1.Text + "%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Write resource name to search");
            }
        }

        //display button
        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //back button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resource_Control_Form.Current.ShowDialog();
        }

        //form load
        private void RC_Show_InvReport_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //display supplier details
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier_Detail_Report SupplierD = new Supplier_Detail_Report();
            SupplierD.Show();
        }

        //view resource details
        private void button6_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                Show_Resource_Details NR = new Show_Resource_Details(RI.id, RI.name, RI.quantity, RI.supplier_id,RI.reorder_level);
                NR.ShowDialog();
                selected = false;
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        //method to set inventory values of text boxes
        public void setInventoryDetails(DataGridViewRow row)
        {
            RI.id = int.Parse(row.Cells[0].Value.ToString());
            RI.name = row.Cells[1].Value.ToString();
            RI.quantity = int.Parse(row.Cells[2].Value.ToString());
            RI.supplier_id = int.Parse(row.Cells[3].Value.ToString());
            RI.reorder_level = int.Parse(row.Cells[4].Value.ToString());
        }

        //select row of datagrid view
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
