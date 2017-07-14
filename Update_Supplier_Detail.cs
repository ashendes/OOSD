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
        SupplierInfo SI = new SupplierInfo();
        bool selected = false;

        public Update_Supplier_Detail()
        {
            InitializeComponent();
        }

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

        private void button8_Click(object sender, EventArgs e)
        {
            Supplier_info s1 = new Supplier_info(SI.supplier_id,SI.name,SI.email,SI.phone_number,SI.address);
            s1.btnText("Add");
            s1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewRow delrow = dataGridView2.Rows[i];
                if (delrow.Selected == true)
                {
                    dataGridView2.Rows.RemoveAt(i);
                    try
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from softwaredb.suppliers_info where CustCode=" + i + "";
                        cmd.Connection = con;
                        int count = cmd.ExecuteNonQuery();
                        /**delcmd.CommandText = "DELETE FROM Receive WHERE CustCode=" + i + "";
                        delcmd.Connection = oleConn;
                        int count = delcmd.ExecuteNonQuery();**/
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        //search
        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.suppliers_info where supplier_id like'" + textBox2.Text + "%'", con);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void Update_Supplier_Detail_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_UpdateReport.Current.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
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


        private void button10_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
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

        public void setInventoryDetails(DataGridViewRow row)
        {
            SI.supplier_id = row.Cells[0].Value.ToString();
            SI.name = row.Cells[1].Value.ToString();
            SI.email = row.Cells[2].Value.ToString();
            SI.phone_number = row.Cells[3].Value.ToString();
            SI.address = row.Cells[4].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                setInventoryDetails(row);
                selected = true;
            }
        }

    }
}
