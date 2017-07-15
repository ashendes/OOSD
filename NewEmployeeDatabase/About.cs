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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            var pos = this.PointToScreen(btnOk.Location);
            pos = pictureBox1.PointToClient(pos);
            btnOk.Location = pos;
            btnOk.Parent = pictureBox1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
