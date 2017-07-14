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
    public partial class Form1 : Form
    {
        public static Form1 Current;

        public Form1()
        {
            Current = this;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_Control_Form s1 = new Stock_Control_Form();
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resource_Control_Form s1 = new Resource_Control_Form();
            s1.Show();
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
