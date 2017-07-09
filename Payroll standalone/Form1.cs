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

namespace Payroll_standalone
{
    public partial class Form1 : Form
    {
        MySqlConnection dbconnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tbxPassword.Focus();
            }
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Please enter a username", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Enter password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxPassword.Focus();
                return;
            }
            else
            {

                try
                {
                    i = 0;
                    dbconnection.Open();
                    MySqlCommand command = dbconnection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * from user list where username ='" + tbxUsername.Text + "' and password = '" + tbxPassword.Text + "'";
                    //command.ExecuteNonQuery();
                    //string command = "SELECT * from user list where username ='" + tbxUsername.Text + "' and password = '" + tbxPassword.Text + "'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                    i = dt.Rows.Count;

                    if (i != 0)
                    {
                        dbconnection.Close();
                        this.Hide();
                        Switchboard next = new Switchboard();
                        next.Show();
                        this.Close();
                    }
                    else
                    {
                        dbconnection.Close();
                        MessageBox.Show("Invalid username or password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbxUsername.Focus();
                    }
                }
                catch (Exception ex)
                {

                    //logger.ErrorException("Error accessing database", ex);
                    MessageBox.Show("Error accessing database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
