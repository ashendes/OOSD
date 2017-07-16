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
    public partial class Update_Supplier_Detail : Form
    {
        public static Update_Supplier_Detail Current;
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        Supplier SI = new Supplier();
        bool selected = false;

        public Update_Supplier_Detail()
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
            dataGridView2.DataSource = dt;
            con.Close();
        }

        //load supplier info page to add new supplier
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier_info s1 = new Supplier_info(SI.supplier_id,SI.name,SI.email,SI.phone_number,SI.address);
            s1.btnText("Add");
            s1.Show();
        }

        //display all button
        private void button12_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //search
        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.suppliers_info where supplier_id like'" + textBox2.Text + "%'", con);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
        }

        //load form
        private void Update_Supplier_Detail_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //back button
        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_UpdateReport.Current.ShowDialog();
        }

        //load supplier info form to update supplier details
        private void button10_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                this.Hide();
                Supplier_info s1 = new Supplier_info(SI.supplier_id, SI.name, SI.email, SI.phone_number, SI.address);
                s1.btnText("Edit");
                s1.Show();
                selected = false;
            }
            else
            {
                MessageBox.Show("Select a Row ");
            }
        }

        //set inventory value to supplier object
        public void setInventoryDetails(DataGridViewRow row)
        {
            SI.supplier_id = int.Parse(row.Cells[0].Value.ToString());
            SI.name = row.Cells[1].Value.ToString();
            SI.email = row.Cells[2].Value.ToString();
            SI.phone_number = int.Parse(row.Cells[3].Value.ToString());
            SI.address = row.Cells[4].Value.ToString();

        }

        //select row of datagridview
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;
            }
        }

        //load supplier detail page to show details of each supplier
        private void button1_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                Supplier_Detail_page SInfo = new Supplier_Detail_page(SI.supplier_id, SI.name, SI.email, SI.phone_number, SI.address);
                SInfo.Show();
                SInfo.txtBtn("Cancel");
            }
            else
            {
                MessageBox.Show("Select a supplier detail row");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
