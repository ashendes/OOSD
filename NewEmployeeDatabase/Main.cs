using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmployeeDatabase
{
    public partial class Main : Form
    {
        Form addNew = new AddEmployee();
        Form aboutNew = new About();
        Form viewNew = new ViewDatabase();
        Form searchNew = new Search();
        
        public Main()
        {
            InitializeComponent();
            
            label1.Parent = pictureBox1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewNew.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutNew.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchNew.ShowDialog();
        }
    }
}
