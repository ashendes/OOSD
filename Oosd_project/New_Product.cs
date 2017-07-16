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
using System.Text.RegularExpressions;

namespace Oosd_project
{
    public partial class New_Product : Form
    {
        public static New_Product Current;

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
        public int product_id;
        public string product_name;
        public string dimensions;
        public float dollar_price;
        public float euro_price;
        public int quantity;
        public Image product_image;

        public New_Product(int product_id,string product_name, string dimensions, float dollar_price, float euro_price, int quantity, Image product_image)
        {
            InitializeComponent();
            this.product_id = product_id;
            this.product_name = product_name;
            this.dimensions = dimensions;
            this.dollar_price = dollar_price;
            this.euro_price = euro_price;
            this.quantity = quantity;
            this.product_image = product_image;
        }

        //cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SC_Update_Inventory Stock = new SC_Update_Inventory();
            Stock.Show();
        }
        
        //Add and Edit button
        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            float j;
            if (button2.Text == "Edit")
            {
                DialogResult result;
                
                try
                {
                    result = MessageBox.Show("Do you need to update?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        
                        if ((pictureBox1.Image != null) && (!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (!string.IsNullOrEmpty(textBox5.Text)) && (!string.IsNullOrEmpty(textBox6.Text)) && (int.TryParse(textBox6.Text, out i)) && (float.TryParse(textBox4.Text, out j)) && (float.TryParse(textBox6.Text, out j)) && (!textBox2.Text.All(char.IsDigit)) && (int.TryParse(textBox3.Text, out i)))
                        {

                                MemoryStream ms = new MemoryStream();
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                byte[] img = ms.ToArray();

                                MySqlConnection con2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
                                MySqlCommand command = con2.CreateCommand();
                                command.CommandText = "UPDATE stock_inventory SET product_name=@name,dimensions=@dimensions,dollar_price=@dollar_price,euro_price=@euro_price,quantity=@qun,product_image=@product_image where product_id=@product_id";
                                command.Parameters.AddWithValue("@product_id", textBox1.Text);
                                command.Parameters.AddWithValue("@name", textBox2.Text);
                                command.Parameters.AddWithValue("@dimensions", textBox3.Text);
                                command.Parameters.AddWithValue("@dollar_price", textBox4.Text);
                                command.Parameters.AddWithValue("@euro_price", textBox5.Text);
                                command.Parameters.AddWithValue("@qun", textBox6.Text);
                                command.Parameters.Add("@product_image", MySqlDbType.Blob);
                                command.Parameters["@product_image"].Value = img;
                                con2.Open();
                                command.ExecuteNonQuery();
                                con2.Close();
                                this.Hide();
                                SC_Update_Inventory stockU = new SC_Update_Inventory();
                                stockU.Show();
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
            if(button2.Text =="Add")
            {
                DialogResult result;

                try
                {
                    result = MessageBox.Show("Do you need to add?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if ((pictureBox1.Image != null) && (!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (!string.IsNullOrEmpty(textBox5.Text)) && (!string.IsNullOrEmpty(textBox6.Text)) && (int.TryParse(textBox6.Text, out i)) && (float.TryParse(textBox5.Text, out j)) && (float.TryParse(textBox4.Text, out j)) && (float.TryParse(textBox6.Text, out j)) && (!textBox2.Text.All(char.IsDigit)) && (int.TryParse(textBox3.Text,out i)))
                        {

                                MemoryStream ms = new MemoryStream();
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                byte[] img = ms.ToArray();
                                MySqlCommand command = con.CreateCommand();
                                String insertQuery = "INSERT INTO stock_inventory(product_name,dimensions,dollar_price,euro_price,quantity,product_image) VALUES(@name,@dm,@dollar,@euro,@qun,@img)";

                                con.Open();

                                command = new MySqlCommand(insertQuery, con);
                                command.Parameters.AddWithValue("@id", textBox1.Text);
                                command.Parameters.AddWithValue("@name", textBox2.Text);
                                command.Parameters.AddWithValue("@dm", textBox3.Text);
                                command.Parameters.AddWithValue("@dollar", textBox4.Text);
                                command.Parameters.AddWithValue("@euro", textBox5.Text);
                                command.Parameters.AddWithValue("@qun", textBox6.Text);
                                command.Parameters.Add("@img", MySqlDbType.Blob);
                                command.Parameters["@img"].Value = img;

                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Data Inserted");
                                }

                                con.Close();
                                this.Hide();
                                SC_Update_Inventory stockU = new SC_Update_Inventory();
                                stockU.Show();

                        }
                        else
                        {
                            MessageBox.Show("Please Insert data correctly");
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

        }

        //Add image button
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "image files(*.jpg;*png;*.gif)|*.jpg;*png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        public void clear_data()
        {
            textBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            pictureBox1.Image = null;
        }
        //clear button
        private void button4_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        //method to change button2 as edit or add
        public void txtBtn(string txt)
        {
            button2.Text = txt;
        }

        //Form load
        private void New_Product_Load(object sender, EventArgs e)
        {
            if (button2.Text == "Add")
            {
                string query2 = "SHOW TABLE STATUS LIKE 'stock_inventory'";
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
            if(button2.Text == "Edit")
            {
                setToDefault();
            }
        }

        //set textboxes to the default values
        public void setToDefault()
        {
            textBox1.Text = product_id.ToString();
            textBox2.Text = product_name;
            textBox3.Text = dimensions;
            textBox4.Text = dollar_price.ToString();
            textBox5.Text = euro_price.ToString();
            textBox6.Text = quantity.ToString();
            pictureBox1.Image = product_image;
        }

        private void textBox6_TextChanged(object sender, EventArgs e){}
        private void label7_Click(object sender, EventArgs e){}
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

    }
}