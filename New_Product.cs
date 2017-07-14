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
    public partial class New_Product : Form
    {
        public static New_Product Current;

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
        public string product_id;
        public string product_name;
        public string dimensions;
        public string dollar_price;
        public string euro_price;
        public string quantity;
        public Image product_image;

        public New_Product(string product_id,string product_name, string dimensions, string dollar_price, string euro_price, string quantity, Image product_image)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Edit")
            {
                MySqlConnection con2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=softwaredb");
                MySqlCommand command = con2.CreateCommand();
                command.CommandText = "UPDATE stock_inventory SET product_name=@name,dimensions=@dimensions,dollar_price=@dollar_price,euro_price=@euro_price,quantity=@qun,product_image=@product_image where product_id=@product_id";
                command.Parameters.AddWithValue("@product_id", textBox1.Text);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                command.Parameters.AddWithValue("@dimensions", textBox3.Text);
                command.Parameters.AddWithValue("@dollar_price", textBox4.Text);
                command.Parameters.AddWithValue("@euro_price", textBox5.Text);
                command.Parameters.AddWithValue("@qun", textBox6.Text);
                command.Parameters.AddWithValue("@product_image", pictureBox1.Image);
                try
                {
                    con2.Open();
                    command.ExecuteNonQuery();
                    con2.Close();
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
                    result = MessageBox.Show("Do you need to update?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        if ((pictureBox1.Image != null) && (!string.IsNullOrEmpty(textBox1.Text)) && (!string.IsNullOrEmpty(textBox2.Text)) && (!string.IsNullOrEmpty(textBox3.Text)) && (!string.IsNullOrEmpty(textBox4.Text)) && (!string.IsNullOrEmpty(textBox5.Text)) && (!string.IsNullOrEmpty(textBox6.Text)))
                        {
                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            MySqlCommand command = con.CreateCommand();
                            String insertQuery = "INSERT INTO stock_inventory(product_name,dimensions,dollar_price,euro_price,quantity,product_image) VALUES(@name,@dm,@dollar,@euro,@qun,@img)";

                            con.Open();

                            command = new MySqlCommand(insertQuery, con);
                            command.Parameters.Add("@id", MySqlDbType.VarChar, 4);
                            command.Parameters.Add("@name", MySqlDbType.VarChar, 20);
                            command.Parameters.Add("@dm", MySqlDbType.VarChar, 10);
                            command.Parameters.Add("@dollar", MySqlDbType.VarChar, 10);
                            command.Parameters.Add("@euro", MySqlDbType.VarChar, 10);
                            command.Parameters.AddWithValue("@qun", textBox6.Text);
                            command.Parameters.Add("@img", MySqlDbType.Blob);

                            command.Parameters["@id"].Value = textBox1.Text;
                            command.Parameters["@name"].Value = textBox2.Text;
                            command.Parameters["@dm"].Value = textBox3.Text;
                            command.Parameters["@dollar"].Value = textBox4.Text;
                            command.Parameters["@euro"].Value = textBox5.Text;
                            //command.Parameters["@qun"].Value = textBox6.Text;
                            command.Parameters["@img"].Value = img;

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data Inserted");
                            }

                            con.Close();
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
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "image files(*.jpg;*png;*.gif)|*.jpg;*png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            pictureBox1.Image = null;
        }


        public void txtBtn(string txt)
        {
            button2.Text = txt;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void New_Product_Load(object sender, EventArgs e)
        {
            setToDefault();
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
        }

        public void setToDefault()
        {
            textBox1.Text = product_id;
            textBox2.Text = product_name;
            textBox3.Text = dimensions;
            textBox4.Text = dollar_price;
            textBox5.Text = euro_price;
            textBox6.Text = quantity;
            pictureBox1.Image = product_image;
        }
    }
}