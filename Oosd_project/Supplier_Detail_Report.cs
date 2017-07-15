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
    public partial class Supplier_Detail_Report : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        Supplier SI = new Supplier();
        bool selected = false;

        public Supplier_Detail_Report()
        {
            InitializeComponent();
        }

        //method to load data to datagridview
        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from softwaredb.suppliers_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //display all button
        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.suppliers_info where name like'" + textBox1.Text + "%'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //load form
        private void Supplier_Detail_Report_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //log out button
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

        //back button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_Show_InvReport.Current.ShowDialog();
        }

        //view supplier details for each supplier
        private void button5_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                Supplier_Detail_page SInfo = new Supplier_Detail_page(SI.supplier_id, SI.name, SI.email, SI.phone_number, SI.address);
                SInfo.Show();
            }
            else
            {
                MessageBox.Show("Select a supplier detail row");
            }
        }


        //set supplier details supplier object
        public void setSupplierDetails(DataGridViewRow row)
        {
            SI.supplier_id = row.Cells[0].Value.ToString();
            SI.name = row.Cells[1].Value.ToString();
            SI.email = row.Cells[2].Value.ToString();
            SI.phone_number = row.Cells[3].Value.ToString();
            SI.address = row.Cells[4].Value.ToString();

        }

        //select row of datagridview
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                setSupplierDetails(row);
                selected = true;
            }
        }
    }
}
