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

        //Stock control button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_Control_Form s1 = new Stock_Control_Form();
            s1.Show();
        }

        //resource control button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resource_Control_Form s1 = new Resource_Control_Form();
            s1.Show();
        }

        private void Form1_Load(object sender, EventArgs e){}
    }
}
