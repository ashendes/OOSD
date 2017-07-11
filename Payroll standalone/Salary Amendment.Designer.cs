namespace Payroll_standalone
{
    partial class SalaryAmendmentForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEmpID = new System.Windows.Forms.ComboBox();
            this.tbxEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.cbxAmendType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Name";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(495, 78);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(512, 40);
            this.dateTimePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            // 
            // cbxEmpID
            // 
            this.cbxEmpID.FormattingEnabled = true;
            this.cbxEmpID.Location = new System.Drawing.Point(495, 160);
            this.cbxEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmpID.Name = "cbxEmpID";
            this.cbxEmpID.Size = new System.Drawing.Size(512, 41);
            this.cbxEmpID.TabIndex = 7;
            // 
            // tbxEmpName
            // 
            this.tbxEmpName.Location = new System.Drawing.Point(495, 245);
            this.tbxEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmpName.Name = "tbxEmpName";
            this.tbxEmpName.ReadOnly = true;
            this.tbxEmpName.Size = new System.Drawing.Size(512, 40);
            this.tbxEmpName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(494, 402);
            this.tbxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(512, 40);
            this.tbxAmount.TabIndex = 12;
            // 
            // cbxAmendType
            // 
            this.cbxAmendType.FormattingEnabled = true;
            this.cbxAmendType.Location = new System.Drawing.Point(495, 319);
            this.cbxAmendType.Name = "cbxAmendType";
            this.cbxAmendType.Size = new System.Drawing.Size(511, 41);
            this.cbxAmendType.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amendment Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(114, 508);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(327, 83);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(679, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(327, 83);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SalaryAmendmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1087, 661);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxAmendType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEmpID);
            this.Controls.Add(this.tbxEmpName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryAmendmentForm";
            this.Text = "Salary Amendment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEmpID;
        private System.Windows.Forms.TextBox tbxEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.ComboBox cbxAmendType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}