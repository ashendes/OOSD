using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oosd_project
{
    public partial class Stock_Control_Form : Form
    {
        public static Stock_Control_Form Current;

        public Stock_Control_Form()
        {
            Current = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SC_Show_InvReport s1 = new SC_Show_InvReport();
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SC_Update_Inventory s1 = new SC_Update_Inventory();
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Current.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
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
