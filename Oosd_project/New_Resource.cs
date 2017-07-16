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

        public int id;
        public string name;
        public int quantity;
        public int supplier_id;
        public int reorder_level;
        bool notify;

        public New_Resource(int id, string name, int quantity, int supplier_id,int reorder_level)
        {
            InitializeComponent();
            Fillcombo();
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.supplier_id = supplier_id;
            this.reorder_level = reorder_level;
        }

        //cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_UpdateReport RC = new RC_UpdateReport();
            RC.Show();
        }

        //method to set combo box values
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
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add and Edit button
        private void button2_Click(object sender, EventArgs e)
        {
            notify= false;
            int i;
            if (button2.Text == "Add")
            {
                DialogResult result;

                try
                {
                    result = MessageBox.Show("Do you need to add?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        
                        if ((!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(comboBox1.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (int.TryParse(textBox3.Text, out i)) && (int.TryParse(textBox4.Text, out i)) && (!textBox2.Text.All(char.IsDigit)))
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into resource_inventory values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Successfully");
                            if (!notify)
                            {
                                this.Hide();
                                RC_UpdateReport RC = new RC_UpdateReport();
                                RC.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("please insert data correctly");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (button2.Text == "Edit")
            {
                DialogResult result;
                try
                {
                    result = MessageBox.Show("Do you need to add?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if ((!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(comboBox1.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (int.TryParse(textBox3.Text, out i)) && (int.TryParse(textBox4.Text, out i)) &&  (!textBox2.Text.All(char.IsDigit)))
                        {
                            if (int.Parse(textBox3.Text) >= int.Parse(textBox4.Text))
                            {
                                MySqlConnection con3 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
                                MySqlCommand command = con3.CreateCommand();
                                command.CommandText = "UPDATE resource_inventory SET name=@name,quantity=@qun,supplier_id=@sid,reorder_level=@rlevel where id=@id";
                                command.Parameters.AddWithValue("@id", textBox1.Text);
                                command.Parameters.AddWithValue("@name", textBox2.Text);
                                command.Parameters.AddWithValue("@qun", textBox3.Text);
                                command.Parameters.AddWithValue("@sid", comboBox1.Text);
                                command.Parameters.AddWithValue("@rlevel", textBox4.Text);
                                con3.Open();
                                command.ExecuteNonQuery();
                                con3.Close();
                                if (!notify)
                                {
                                    this.Hide();
                                    RC_UpdateReport RC = new RC_UpdateReport();
                                    RC.ShowDialog();
                                }
                            }

                            else
                            {
                                MessageBox.Show("Resource Quantity is below the minimum reorder level.Do you need to get information about the supplier?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                if (result == DialogResult.Yes)
                                {
                                    try
                                    {
                                        string query2 = "SELECT *FROM suppliers_info WHERE suppliers_id = '" + comboBox1.Text + "'";
                                        MySqlCommand command2 = new MySqlCommand(query2, con);
                                        con.Open();
                                        MySqlDataReader reader = command2.ExecuteReader();
                                        while (reader.Read())
                                        {
                                            int id = int.Parse(reader.GetString(0));
                                            string name = reader.GetString(1);
                                            string email = reader.GetString(2);
                                            int phnNumber = int.Parse(reader.GetString(3));
                                            string address = reader.GetString(4);
                                            Supplier_Detail_page supplier = new Supplier_Detail_page(id, name, email, phnNumber, address);
                                            supplier.Show();
                                            this.Hide();
                                            notify = true;
                                            supplier.txtBtn("Close");
                                        }
                                        con.Close();
                                    }
                                    catch(Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                else if (result == DialogResult.No)
                                {
                                    this.Show();
                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("Please insert data correctly");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        //method to change text in add remove button
        public void txtBtn(string txt)
        {
            button2.Text = txt;
        }

        //method to clear data in text boxes
        public void clear_data()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
        }

        //Form load
        private void New_Resource_Load(object sender, EventArgs e)
        {
            if(button2.Text == "Edit")
            {
                setToDefault();
            }
            
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

        //method to set to default values
        public void setToDefault()
        {
            textBox1.Text = id.ToString();
            textBox2.Text = name;
            comboBox1.Text = supplier_id.ToString();
            textBox3.Text = quantity.ToString();
            textBox4.Text = reorder_level.ToString();

        }

        //clear button
        private void button4_Click_1(object sender, EventArgs e)
        {
            clear_data();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

    }
}


