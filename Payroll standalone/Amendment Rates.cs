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
            btnConfirmEPF.Enabled = false;
            btnConfirmETF.Enabled = false;
            btnConfirmOT.Enabled = false;
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
                            value = reader.GetString("Value");
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
            if (MessageBox.Show("Are you sure you want to update rates?", "Rate Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                changeRate("EPF", tbxEPFRate.Text);
            }
            else
            {
                tbxEPFRate.Text = getRate("EPF");
            }
            btnConfirmEPF.Enabled = false;
        }

        private void changeRate(string ratename, string value)
        {
            try
            {
                using (db)
                {

                    var query = "UPDATE rates SET `Value` = @value  where `rate name`=@ratename";
                    using (var command = new MySqlCommand(query, db))
                    {
                        command.Parameters.AddWithValue("@ratename", ratename);
                        command.Parameters.AddWithValue("@value", value);
                        db.Open();
                        command.ExecuteNonQuery();
                        db.Close();                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmETF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update rates?", "Rate Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                changeRate("ETF", tbxEPFRate.Text);
            }
            else
            {
                tbxEPFRate.Text = getRate("ETF");
            }
            btnConfirmETF.Enabled = false;
        }

        private void btnConfirmOT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update rates?", "Rate Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                changeRate("OT", tbxEPFRate.Text);
            }
            else
            {
                tbxEPFRate.Text = getRate("OT");
            }
            btnConfirmOT.Enabled = false;
        }

        private void tbxEPFRate_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEPF.Enabled = true;
        }

        private void tbxETFRate_TextChanged(object sender, EventArgs e)
        {
            btnConfirmETF.Enabled = true;
        }

        private void tbxOTRate_TextChanged(object sender, EventArgs e)
        {
            btnConfirmOT.Enabled = true;
        }
    }
}
