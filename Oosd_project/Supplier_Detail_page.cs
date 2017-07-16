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
        public int supplier_id;
        public string name;
        public string email;
        public int phone_number;
        public string address;

        public Supplier_Detail_page(int supplier_id, string name, string email, int phone_number, string address)
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
            if (button1.Text == "Close")
            {
                this.Hide();
                Form Rc = new RC_UpdateReport();
                Rc.ShowDialog();
            }
            else
            {
                this.Hide();
            }
        }

        //load form
        private void Supplier_Detail_page_Load(object sender, EventArgs e)
        {
            label8.Text = supplier_id.ToString();
            label9.Text = name;
            label10.Text = email;
            label11.Text = phone_number.ToString();
            label12.Text = address;
        }

        //method to change text in add remove button
        public void txtBtn(string txt)
        {
            button1.Text = txt;
        }
    }
}
