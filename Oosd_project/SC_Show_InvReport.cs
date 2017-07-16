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
    public partial class SC_Show_InvReport : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public static SC_Show_InvReport Current;
        Stock_Inventory StockI = new Stock_Inventory();
        bool selected = false;

        public SC_Show_InvReport()
        {
            Current = this;
            InitializeComponent();
        }

        //method to display data in grid view
        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from softwaredb.stock_inventory";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.stock_inventory where product_name like '" + textBox1.Text + "%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Write product name to search");
            }
        }

        //back button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_Control_Form.Current.ShowDialog();
        }


        //display all button
        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //load form
        private void SC_Show_InvReport_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //select datagridview row
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;

            }
        }

        //set inventory values
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

        //viw product detail page for each product
        private void button5_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
