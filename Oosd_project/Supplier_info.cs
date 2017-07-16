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
    public partial class Supplier_info : Form
    {
        public static New_Resource Current;
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
        public int supplier_id;
        public string name;
        public string email;
        public int phone_number;
        public string address;

        public Supplier_info(int supplier_id, string name, string email,int phone_number,string address)
        {
            InitializeComponent();
            this.supplier_id = supplier_id;
            this.name = name;
            this.email = email;
            this.phone_number = phone_number;
            this.address = address;

        }

        //set textbox value to default values
        public void setToDefault()
        {
            textBox5.Text = supplier_id.ToString();
            textBox1.Text = name;
            textBox2.Text = email;
            textBox3.Text = phone_number.ToString();
            textBox4.Text = address;
        }

        //cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Add or Edit Supplier details
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Add")
            {
                DialogResult result;
                int i;
                try
                {
                    result = MessageBox.Show("Do you need to add?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if ((!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (!string.IsNullOrEmpty(textBox5.Text)) && (!textBox2.Text.All(char.IsDigit)) && (!int.TryParse(textBox4.Text, out i)) && (!textBox1.Text.All(char.IsDigit))) { 
                            if (!this.textBox2.Text.Contains('@') || !this.textBox2.Text.Contains('.') )
                            {
                                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if ((int.TryParse(textBox3.Text, out i)) && (textBox3.Text.Length!=10))
                            {
                                MessageBox.Show("Please Enter A Valid Phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                con.Open();
                                MySqlCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "insert into suppliers_info values('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Record Successfully");
                                this.Hide();
                                Update_Supplier_Detail SupInfo = new Update_Supplier_Detail();
                                SupInfo.Show();
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(button2.Text == "Edit")
            {
                DialogResult result;
                int i;
                try
                {
                    result = MessageBox.Show("Do you need to update?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if ((!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (!string.IsNullOrEmpty(textBox5.Text)) && (int.TryParse(textBox3.Text, out i)) && (!int.TryParse(textBox4.Text, out i))  && (!textBox1.Text.All(char.IsDigit)))
                        {
                            if (!this.textBox2.Text.Contains('@') || !this.textBox2.Text.Contains('.'))
                            {
                                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if ((int.TryParse(textBox3.Text, out i)) && (textBox3.Text.Length != 10))
                            {
                                MessageBox.Show("Please Enter A Valid Phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MySqlConnection con2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
                                MySqlCommand command = con2.CreateCommand();
                                command.CommandText = "UPDATE suppliers_info SET name=@name,email=@email,phone_number=@phone_number,address=@address where suppliers_id=@id";
                                command.Parameters.AddWithValue("@id", textBox5.Text);
                                command.Parameters.AddWithValue("@name", textBox1.Text);
                                command.Parameters.AddWithValue("@email", textBox2.Text);
                                command.Parameters.AddWithValue("@phone_number", textBox3.Text);
                                command.Parameters.AddWithValue("@address", textBox4.Text);
                                con2.Open();
                                command.ExecuteNonQuery();
                                con2.Close();
                                MessageBox.Show("Record Successfully");
                                this.Hide();
                                Update_Supplier_Detail SupInfo = new Update_Supplier_Detail();
                                SupInfo.Show();
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

        //clear button
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        //set button as add or edit
        public void btnText(string txt)
        {
            button2.Text = txt;
        }

        //load form
        private void Supplier_info_Load(object sender, EventArgs e)
        {
            if (button2.Text == "Edit")
            {
                setToDefault();
            }

            if (button2.Text == "Add")
            {
                string query2 = "SHOW TABLE STATUS LIKE 'suppliers_info'";
                MySqlCommand command2 = new MySqlCommand(query2, con);
                con.Open();
                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    textBox5.Text = reader.GetString(10);
                }
                con.Close();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
