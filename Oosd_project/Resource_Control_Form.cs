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
    public partial class Resource_Control_Form : Form
    {
        public static Resource_Control_Form Current;

        public Resource_Control_Form()
        {
            Current = this;
            InitializeComponent();
        }

        //show inventory report button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_Show_InvReport s1 = new RC_Show_InvReport();
            s1.Show();
        }

        //show resource inventory button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_UpdateReport s1 = new RC_UpdateReport();
            s1.Show();
        }
        
        //back button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e){}
    }
}
