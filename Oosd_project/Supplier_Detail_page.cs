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
    public partial class Supplier_Detail_page : Form
    {
        public string supplier_id;
        public string name;
        public string email;
        public string phone_number;
        public string address;

        public Supplier_Detail_page(string supplier_id, string name, string email, string phone_number, string address)
        {
            InitializeComponent();
            this.supplier_id = supplier_id;
            this.name = name;
            this.email = email;
            this.phone_number = phone_number;
            this.address = address;
        }

        //close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //load form
        private void Supplier_Detail_page_Load(object sender, EventArgs e)
        {
            label8.Text = supplier_id;
            label9.Text = name;
            label10.Text = email;
            label11.Text = phone_number;
            label12.Text = address;
        }
    }
}
