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
    public partial class Show_Resource_Details : Form
    {
        public int id;
        public string name;
        public int quantity;
        public int supplier_id;
        public int reorder_level;

        public Show_Resource_Details(int id, string name, int quantity, int supplier_id,int reorder_level)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.supplier_id = supplier_id;
            this.reorder_level = reorder_level;
        }

        //close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //load form
        private void Show_Resource_Details_Load(object sender, EventArgs e)
        {
            label5.Text = id.ToString();
            label6.Text = name;
            label7.Text = quantity.ToString();
            label8.Text = supplier_id.ToString();
            label10.Text = reorder_level.ToString();
        }
    }
}
