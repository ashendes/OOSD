namespace Payroll_standalone
{
    partial class ViewPayrollInfo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PayslipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_calculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOTHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OTPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewPayslip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM, yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 31);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select month:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayslipID,
            this.ID,
            this.EmployeeName,
            this.Designation,
            this.Department,
            this.Date_of_calculation,
            this.BasicSalary,
            this.TotalWHours,
            this.TotalOTHours,
            this.Allowances,
            this.Advances,
            this.Bonuses,
            this.Arrears,
            this.GrossSalary,
            this.OTPay,
            this.EPF,
            this.ETF,
            this.NetSalary});
            this.dataGridView1.Location = new System.Drawing.Point(26, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1844, 792);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PayslipID
            // 
            this.PayslipID.HeaderText = "Payslip ID";
            this.PayslipID.Name = "PayslipID";
            this.PayslipID.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "Employee ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Date_of_calculation
            // 
            this.Date_of_calculation.HeaderText = "Date of calculation";
            this.Date_of_calculation.Name = "Date_of_calculation";
            this.Date_of_calculation.ReadOnly = true;
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "Basic Salary";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            // 
            // TotalWHours
            // 
            this.TotalWHours.HeaderText = "Hours Worked";
            this.TotalWHours.Name = "TotalWHours";
            this.TotalWHours.ReadOnly = true;
            // 
            // TotalOTHours
            // 
            this.TotalOTHours.HeaderText = "OT Hours";
            this.TotalOTHours.Name = "TotalOTHours";
            this.TotalOTHours.ReadOnly = true;
            // 
            // Allowances
            // 
            this.Allowances.HeaderText = "Allowances";
            this.Allowances.Name = "Allowances";
            this.Allowances.ReadOnly = true;
            // 
            // Advances
            // 
            this.Advances.HeaderText = "Advances";
            this.Advances.Name = "Advances";
            this.Advances.ReadOnly = true;
            // 
            // Bonuses
            // 
            this.Bonuses.HeaderText = "Bonuses";
            this.Bonuses.Name = "Bonuses";
            this.Bonuses.ReadOnly = true;
            // 
            // Arrears
            // 
            this.Arrears.HeaderText = "Arrears";
            this.Arrears.Name = "Arrears";
            this.Arrears.ReadOnly = true;
            // 
            // GrossSalary
            // 
            this.GrossSalary.HeaderText = "Gross Salary";
            this.GrossSalary.Name = "GrossSalary";
            this.GrossSalary.ReadOnly = true;
            // 
            // OTPay
            // 
            this.OTPay.HeaderText = "OT Pay";
            this.OTPay.Name = "OTPay";
            this.OTPay.ReadOnly = true;
            // 
            // EPF
            // 
            this.EPF.HeaderText = "EPF";
            this.EPF.Name = "EPF";
            this.EPF.ReadOnly = true;
            // 
            // ETF
            // 
            this.ETF.HeaderText = "ETF";
            this.ETF.Name = "ETF";
            this.ETF.ReadOnly = true;
            // 
            // NetSalary
            // 
            this.NetSalary.HeaderText = "Net Salary";
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(552, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewPayslip
            // 
            this.btnViewPayslip.Location = new System.Drawing.Point(1569, 925);
            this.btnViewPayslip.Name = "btnViewPayslip";
            this.btnViewPayslip.Size = new System.Drawing.Size(301, 61);
            this.btnViewPayslip.TabIndex = 4;
            this.btnViewPayslip.Text = "View Payslip";
            this.btnViewPayslip.UseVisualStyleBackColor = true;
            this.btnViewPayslip.Click += new System.EventHandler(this.btnViewPayslip_Click);
            // 
            // ViewPayrollInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1013);
            this.Controls.Add(this.btnViewPayslip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ViewPayrollInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPayrollInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayslipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_calculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOTHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advances;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrears;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn OTPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetSalary;
        private System.Windows.Forms.Button btnViewPayslip;
    }
}