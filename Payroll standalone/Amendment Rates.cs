using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Payroll_standalone
{
    public partial class Amendment_Rates : Form
    {
        MySqlConnection db;
        public Amendment_Rates(MySqlConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Amendment_Rates_Load(object sender, EventArgs e)
        {
            
            tbxEPFRate.Text = getRate("EPF");
            tbxETFRate.Text = getRate("ETF");
            tbxOTRate.Text = getRate("OT");
        }

        private string getRate(string ratename)
        {
            var value="";
            try
            {
                using (db)
                {

                    var query = "SELECT * FROM rates where `rate name`=@ratename";
                    using (var command = new MySqlCommand(query, db))
                    {
                        command.Parameters.AddWithValue("@ratename", ratename);                        
                        db.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();
                            value= reader.GetString("Value");

                        }
                        db.Close();
                        return value;
                    }
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
