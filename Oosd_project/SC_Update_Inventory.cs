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
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.stock_inventory where product_name like'" + textBox1.Text + "%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Write product name to search");
            }
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

        //set inventory values to stock inventory object
        public void setInventoryDetails(DataGridViewRow row)
        {
            StockI.product_id = int.Parse(row.Cells[0].Value.ToString());
            StockI.product_name = row.Cells[1].Value.ToString();
            StockI.dimensions = row.Cells[2].Value.ToString();
            StockI.dollar_price = float.Parse(row.Cells[3].Value.ToString());
            StockI.euro_price = float.Parse(row.Cells[4].Value.ToString());
            StockI.quantity = int.Parse(row.Cells[5].Value.ToString());
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

        //load form stock inventory deatils
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
