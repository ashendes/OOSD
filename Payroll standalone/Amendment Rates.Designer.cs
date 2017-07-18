namespace Payroll_standalone
{
    partial class Amendment_Rates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEPFRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxETFRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOTRate = new System.Windows.Forms.TextBox();
            this.btnConfirmEPF = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirmETF = new System.Windows.Forms.Button();
            this.btnConfirmOT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "EPF Rate";
            // 
            // tbxEPFRate
            // 
            this.tbxEPFRate.Location = new System.Drawing.Point(161, 31);
            this.tbxEPFRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxEPFRate.MaxLength = 10;
            this.tbxEPFRate.Name = "tbxEPFRate";
            this.tbxEPFRate.Size = new System.Drawing.Size(309, 28);
            this.tbxEPFRate.TabIndex = 14;
            this.tbxEPFRate.TextChanged += new System.EventHandler(this.tbxEPFRate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "ETF Rate";
            // 
            // tbxETFRate
            // 
            this.tbxETFRate.Location = new System.Drawing.Point(161, 84);
            this.tbxETFRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxETFRate.MaxLength = 10;
            this.tbxETFRate.Name = "tbxETFRate";
            this.tbxETFRate.Size = new System.Drawing.Size(309, 28);
            this.tbxETFRate.TabIndex = 16;
            this.tbxETFRate.TextChanged += new System.EventHandler(this.tbxETFRate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "OT Rate";
            // 
            // tbxOTRate
            // 
            this.tbxOTRate.Location = new System.Drawing.Point(161, 138);
            this.tbxOTRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOTRate.MaxLength = 10;
            this.tbxOTRate.Name = "tbxOTRate";
            this.tbxOTRate.Size = new System.Drawing.Size(309, 28);
            this.tbxOTRate.TabIndex = 18;
            this.tbxOTRate.TextChanged += new System.EventHandler(this.tbxOTRate_TextChanged);
            // 
            // btnConfirmEPF
            // 
            this.btnConfirmEPF.BackColor = System.Drawing.Color.White;
            this.btnConfirmEPF.Enabled = false;
            this.btnConfirmEPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEPF.Location = new System.Drawing.Point(474, 31);
            this.btnConfirmEPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmEPF.Name = "btnConfirmEPF";
            this.btnConfirmEPF.Size = new System.Drawing.Size(95, 32);
            this.btnConfirmEPF.TabIndex = 20;
            this.btnConfirmEPF.Text = "Confirm";
            this.btnConfirmEPF.UseVisualStyleBackColor = false;
            this.btnConfirmEPF.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(394, 205);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 31);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmETF
            // 
            this.btnConfirmETF.BackColor = System.Drawing.Color.White;
            this.btnConfirmETF.Enabled = false;
            this.btnConfirmETF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmETF.Location = new System.Drawing.Point(474, 84);
            this.btnConfirmETF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmETF.Name = "btnConfirmETF";
            this.btnConfirmETF.Size = new System.Drawing.Size(95, 32);
            this.btnConfirmETF.TabIndex = 22;
            this.btnConfirmETF.Text = "Confirm";
            this.btnConfirmETF.UseVisualStyleBackColor = false;
            this.btnConfirmETF.Click += new System.EventHandler(this.btnConfirmETF_Click);
            // 
            // btnConfirmOT
            // 
            this.btnConfirmOT.BackColor = System.Drawing.Color.White;
            this.btnConfirmOT.Enabled = false;
            this.btnConfirmOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOT.Location = new System.Drawing.Point(474, 138);
            this.btnConfirmOT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmOT.Name = "btnConfirmOT";
            this.btnConfirmOT.Size = new System.Drawing.Size(95, 32);
            this.btnConfirmOT.TabIndex = 23;
            this.btnConfirmOT.Text = "Confirm";
            this.btnConfirmOT.UseVisualStyleBackColor = false;
            this.btnConfirmOT.Click += new System.EventHandler(this.btnConfirmOT_Click);
            // 
            // Amendment_Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 262);
            this.Controls.Add(this.btnConfirmOT);
            this.Controls.Add(this.btnConfirmETF);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirmEPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxOTRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxETFRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEPFRate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Amendment_Rates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amendment_Rates";
            this.Load += new System.EventHandler(this.Amendment_Rates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEPFRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxETFRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOTRate;
        private System.Windows.Forms.Button btnConfirmEPF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirmETF;
        private System.Windows.Forms.Button btnConfirmOT;
    }
}