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
    public partial class Supplier_Details : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public Supplier_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM softwaredb.suppliers_info where supplier_id like'" + textBox1.Text + "%'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supplier_Details_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_Show_InvReport.Current.ShowDialog();
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
    }
}
