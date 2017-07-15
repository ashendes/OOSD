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
    public partial class Stock_Inventory_Details : Form
    {
        public string product_id;
        public string product_name;
        public string dimensions;
        public string dollar_price;
        public string euro_price;
        public string quantity;
        public Image product_image;

        public Stock_Inventory_Details(string product_id, string product_name, string dimensions, string dollar_price, string euro_price, string quantity, Image product_image)
        {
            InitializeComponent();
            this.product_id = product_id;
            this.product_name = product_name;
            this.dimensions = dimensions;
            this.dollar_price = dollar_price;
            this.euro_price = euro_price;
            this.quantity = quantity;
            this.product_image = product_image;
        }

        //load form
        private void Stock_Inventory_Details_Load(object sender, EventArgs e)
        {
            label8.Text = product_id;
            label9.Text = product_name;
            label10.Text = dimensions;
            label11.Text = dollar_price;
            label12.Text = euro_price;
            label13.Text = quantity;
            pictureBox1.Image = product_image;
        }

        //close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
