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

        //back button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resource_Control_Form.Current.ShowDialog();
        }

        //method to display data in grid view
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

        //load form
        private void RC_UpdateReport_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //display all button
        private void button6_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //search button
        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.resource_inventory where name like '" + textBox1.Text + "%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("write product name to search");
            }
        }

        //Laod new resource form to add new resource
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Resource s1 = new New_Resource(RI.id,RI.name,RI.quantity,RI.supplier_id,RI.reorder_level);
            s1.txtBtn("Add");
            s1.Show();
        }

        //Load update resource form to edit resource details
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Supplier_Detail s1 = new Update_Supplier_Detail();
            s1.Show();
        }



        //Load update inventory page
        private void button3_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                this.Hide();
                New_Resource NR = new New_Resource(RI.id, RI.name, RI.quantity, RI.supplier_id, RI.reorder_level);
                NR.txtBtn("Edit");
                NR.ShowDialog();
                selected = false;
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        //select gridview row 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;
            }
        }

        //set inventory values to text boxes
        public void setInventoryDetails(DataGridViewRow row)
        {
            RI.id = int.Parse(row.Cells[0].Value.ToString());
            RI.name = row.Cells[1].Value.ToString();
            RI.quantity = int.Parse(row.Cells[2].Value.ToString());
            RI.supplier_id = int.Parse(row.Cells[3].Value.ToString());
            RI.reorder_level = int.Parse(row.Cells[4].Value.ToString());
        }

        //view resource detail page for each resource
        private void button2_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e) { }
    }
}
