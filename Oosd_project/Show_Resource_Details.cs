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
        public string id;
        public string name;
        public string quantity;
        public string supplier_id;

        public Show_Resource_Details(string id, string name, string quantity, string supplier_id)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.supplier_id = supplier_id;
        }

        //close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //load form
        private void Show_Resource_Details_Load(object sender, EventArgs e)
        {
            label5.Text = id;
            label6.Text = name;
            label7.Text = quantity;
            label8.Text = supplier_id;
        }
    }
}
