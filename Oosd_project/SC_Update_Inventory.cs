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
using System.IO;

namespace Oosd_project
{
    public partial class SC_Update_Inventory : Form
    {
        public static SC_Update_Inventory Current;
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
        Stock_Inventory StockI = new Stock_Inventory();
        bool selected=false;

        public SC_Update_Inventory()
        {
            Current = this;
            InitializeComponent();
            disp_data();
        }

        //new product
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Product NP = new New_Product(StockI.product_id, StockI.product_name, StockI.dimensions, StockI.dollar_price, StockI.euro_price, StockI.quantity, StockI.product_image);
            NP.txtBtn("Add");
            NP.ShowDialog();
        }

        //search
        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.stock_inventory where product_name like'" + textBox1.Text + "%'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //display all
        private void button6_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //load page
        private void SC_Update_Inventory_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            if (selected == true){
                this.Hide();
                New_Product NP = new New_Product(StockI.product_id, StockI.product_name, StockI.dimensions, StockI.dollar_price, StockI.euro_price, StockI.quantity, StockI.product_image);
                NP.txtBtn("Edit");
                NP.ShowDialog();
                selected = false;
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        //method to show data in the gridview
        public void disp_data()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from softwaredb.stock_inventory",con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //back button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_Control_Form.Current.ShowDialog();
        }

        //log_out
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

        //set inventory values to stock inventory object
        public void setInventoryDetails(DataGridViewRow row)
        {
            StockI.product_id = row.Cells[0].Value.ToString();
            StockI.product_name = row.Cells[1].Value.ToString();
            StockI.dimensions = row.Cells[2].Value.ToString();
            StockI.dollar_price = row.Cells[3].Value.ToString();
            StockI.euro_price = row.Cells[4].Value.ToString();
            StockI.quantity = row.Cells[5].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])row.Cells[6].Value);
            StockI.product_image = Image.FromStream(ms);
        }

        //select datagridview row
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {          
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;

            }
        }

        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                i = dataGridView1.SelectedCells[0].RowIndex;
                MySqlCommand cmd = new MySqlCommand();
                if(dataGridView1.Rows.Count>1 && i != dataGridView1.Rows.Count - 1)
                {
                    cmd.CommandText = "DELETE FROM stock_inventory WHERE product_id=" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "";
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i].Index);
                    MessageBox.Show("Record Deleted Successfully!");
                    disp_data();
                }
 
            }
            else
            {
                MessageBox.Show("please select a row");
            }
        }

        //lload form stock inventory deatils
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (selected == true)
            {
                Stock_Inventory_Details detail = new Stock_Inventory_Details(StockI.product_id, StockI.product_name, StockI.dimensions, StockI.dollar_price, StockI.euro_price, StockI.quantity, StockI.product_image);
                detail.Show();
                selected = false;
            }
            else
            {
                MessageBox.Show("Select a product detail row");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) { }
        private void button10_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void button11_Click(object sender, EventArgs e) { }
    }
}
