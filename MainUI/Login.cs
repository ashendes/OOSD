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

namespace MainUI
{
    public partial class Login : Form
    {
        MySqlConnection db;
        int i;
       

        private static Login loginform = null;

        public static Login getLoginForm()
        {
            if (loginform == null)
            {
                loginform = new Login();
                return loginform;
            }
            
            return loginform;
        }
        private Login()
        {
            InitializeComponent();
            DBConnection.setupDBConnection();
            db = DBConnection.getDBConnection();
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
                btnLogin_Click(sender, e);
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
                    
                    db.Open();
                    MySqlCommand command = db.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM `user list` WHERE user ='" + tbxUsername.Text + "' and password = '" + tbxPassword.Text + "'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                    i = dt.Rows.Count;

                    if (i != 0)
                    {
                        db.Close();
                                               
                        this.Hide();
                        var switchboard = new MainSwitchboard(tbxUsername.Text);
                        switchboard.ShowDialog();
                        

                    }
                    else
                    {
                        db.Close();
                        MessageBox.Show("Invalid username or password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbxUsername.Focus();
                        tbxPassword.Clear();
                    }
                }
                /*catch (Exception ex)
                {

                    //logger.ErrorException("Error accessing database", ex);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                    tbxUsername.Focus();
                }*/
                finally {  }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
