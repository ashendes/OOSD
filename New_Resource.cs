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
    public partial class New_Resource : Form
    {
        public static New_Resource Current;
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");

        public string id;
        public string name;
        public string quantity;
        public string supplier_id;

        public New_Resource(string id, string name, string quantity, string supplier_id)
        {
            InitializeComponent();
            Fillcombo();
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.supplier_id = supplier_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Fillcombo()
        {
            string query = "select * from suppliers_info";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader.GetString("suppliers_id");
                    comboBox1.Items.Add(sName);
                }

            }
            catch(Exception ex)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Add")
            {
                DialogResult result;

                try
                {
                    result = MessageBox.Show("Do you need to update?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if ((!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(comboBox1.Text)))
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into resource_inventory values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Insert data correctly");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Show();
                    }
                }
                catch
                {

                }

            }
            if (button2.Text == "Edit")
            {
                DialogResult result;

                MySqlConnection con2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
                MySqlCommand command = con2.CreateCommand();
                command.CommandText = "UPDATE resource_inventory SET name=@name,quantity=@qun,supplier_id=@sid where id=@id";
                command.Parameters.AddWithValue("@id", textBox1.Text);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                command.Parameters.AddWithValue("@qun", textBox3.Text);
                command.Parameters.AddWithValue("@sid", comboBox1.Text);
                try
                {
                    result = MessageBox.Show("Do you need to update?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        con2.Open();
                        command.ExecuteNonQuery();
                        con2.Close();
                        this.Hide();
                        RC_UpdateReport s1 = new RC_UpdateReport();
                        s1.ShowDialog();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Show();
                    }
                }
                catch
                {

                }

            }

        }
        public void txtBtn(string txt)
        {
            button2.Text = txt;
        }

        public void clear_data()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void New_Resource_Load(object sender, EventArgs e)
        {
            setToDefault();
            if (button2.Text == "Add")
            {
                string query2 = "SHOW TABLE STATUS LIKE 'resource_inventory'";
                MySqlConnection con2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
                MySqlCommand command2 = new MySqlCommand(query2, con2);
                con2.Open();
                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader.GetString(10);
                }
                con2.Close();
            }
        }

        public void setToDefault()
        {
            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = quantity;
            comboBox1.Text = supplier_id;
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


