namespace Payroll_standalone
{
    partial class SalaryInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEmpID = new System.Windows.Forms.ComboBox();
            this.tbxDesignation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDept = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxEmpName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.month = new System.Windows.Forms.DateTimePicker();
            this.year = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxArrears = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnViewPS = new System.Windows.Forms.Button();
            this.tbxOTPay = new System.Windows.Forms.TextBox();
            this.lblOT = new System.Windows.Forms.Label();
            this.tbxNetSal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxETF = new System.Windows.Forms.TextBox();
            this.lblETF = new System.Windows.Forms.Label();
            this.tbxEPF = new System.Windows.Forms.TextBox();
            this.tbxGSal = new System.Windows.Forms.TextBox();
            this.lblEPF = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxBonuses = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxAdvances = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxAllowances = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxBasicSal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPSID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxOTHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxWHours = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.cbxEmpID);
            this.groupBox1.Controls.Add(this.tbxDesignation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxDept);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxEmpName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(76, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 411);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // cbxEmpID
            // 
            this.cbxEmpID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxEmpID.FormattingEnabled = true;
            this.cbxEmpID.Location = new System.Drawing.Point(36, 87);
            this.cbxEmpID.Name = "cbxEmpID";
            this.cbxEmpID.Size = new System.Drawing.Size(498, 41);
            this.cbxEmpID.TabIndex = 9;
            this.cbxEmpID.SelectedIndexChanged += new System.EventHandler(this.cbxEmpID_SelectedIndexChanged);
            this.cbxEmpID.TextChanged += new System.EventHandler(this.cbxEmpID_TextChanged);
            this.cbxEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEmpID_KeyPress_1);
            this.cbxEmpID.Leave += new System.EventHandler(this.cbxEmpID_Leave);
            // 
            // tbxDesignation
            // 
            this.tbxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesignation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxDesignation.Location = new System.Drawing.Point(36, 345);
            this.tbxDesignation.Name = "tbxDesignation";
            this.tbxDesignation.ReadOnly = true;
            this.tbxDesignation.Size = new System.Drawing.Size(499, 40);
            this.tbxDesignation.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 33);
            this.label9.TabIndex = 7;
            this.label9.Text = "Designation";
            // 
            // tbxDept
            // 
            this.tbxDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxDept.Location = new System.Drawing.Point(36, 258);
            this.tbxDept.Name = "tbxDept";
            this.tbxDept.ReadOnly = true;
            this.tbxDept.Size = new System.Drawing.Size(499, 40);
            this.tbxDept.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "Department";
            // 
            // tbxEmpName
            // 
            this.tbxEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxEmpName.Location = new System.Drawing.Point(36, 171);
            this.tbxEmpName.Name = "tbxEmpName";
            this.tbxEmpName.ReadOnly = true;
            this.tbxEmpName.Size = new System.Drawing.Size(499, 40);
            this.tbxEmpName.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.month);
            this.groupBox2.Controls.Add(this.year);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(76, 686);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 239);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issue Period";
            // 
            // month
            // 
            this.month.CustomFormat = "MMMM";
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month.Location = new System.Drawing.Point(36, 176);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(499, 40);
            this.month.TabIndex = 10;
            // 
            // year
            // 
            this.year.CustomFormat = "yyyy";
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.year.Location = new System.Drawing.Point(36, 88);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(499, 40);
            this.year.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Year";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.tbxArrears);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.btnConfirm);
            this.groupBox3.Controls.Add(this.btnViewPS);
            this.groupBox3.Controls.Add(this.tbxOTPay);
            this.groupBox3.Controls.Add(this.lblOT);
            this.groupBox3.Controls.Add(this.tbxNetSal);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tbxETF);
            this.groupBox3.Controls.Add(this.lblETF);
            this.groupBox3.Controls.Add(this.tbxEPF);
            this.groupBox3.Controls.Add(this.tbxGSal);
            this.groupBox3.Controls.Add(this.lblEPF);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbxBonuses);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbxAdvances);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbxAllowances);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbxBasicSal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbxPSID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbxOTHours);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbxWHours);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(721, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 804);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salary Details";
            // 
            // tbxArrears
            // 
            this.tbxArrears.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxArrears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxArrears.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxArrears.Location = new System.Drawing.Point(495, 171);
            this.tbxArrears.Name = "tbxArrears";
            this.tbxArrears.Size = new System.Drawing.Size(421, 40);
            this.tbxArrears.TabIndex = 41;
            this.tbxArrears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxArrears_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(494, 135);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 33);
            this.label20.TabIndex = 40;
            this.label20.Text = "Arrears";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(346, 700);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(259, 67);
            this.btnConfirm.TabIndex = 39;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnViewPS
            // 
            this.btnViewPS.Location = new System.Drawing.Point(657, 700);
            this.btnViewPS.Name = "btnViewPS";
            this.btnViewPS.Size = new System.Drawing.Size(259, 67);
            this.btnViewPS.TabIndex = 38;
            this.btnViewPS.Text = "View Payslip";
            this.btnViewPS.UseVisualStyleBackColor = true;
            this.btnViewPS.Click += new System.EventHandler(this.btnViewPS_Click);
            // 
            // tbxOTPay
            // 
            this.tbxOTPay.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxOTPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOTPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxOTPay.Location = new System.Drawing.Point(495, 345);
            this.tbxOTPay.Name = "tbxOTPay";
            this.tbxOTPay.ReadOnly = true;
            this.tbxOTPay.Size = new System.Drawing.Size(421, 40);
            this.tbxOTPay.TabIndex = 37;
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Location = new System.Drawing.Point(494, 309);
            this.lblOT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(114, 33);
            this.lblOT.TabIndex = 36;
            this.lblOT.Text = "OT Pay";
            // 
            // tbxNetSal
            // 
            this.tbxNetSal.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNetSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNetSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxNetSal.Location = new System.Drawing.Point(495, 597);
            this.tbxNetSal.Name = "tbxNetSal";
            this.tbxNetSal.ReadOnly = true;
            this.tbxNetSal.Size = new System.Drawing.Size(421, 40);
            this.tbxNetSal.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(494, 561);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 33);
            this.label18.TabIndex = 34;
            this.label18.Text = "Net Salary";
            // 
            // tbxETF
            // 
            this.tbxETF.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxETF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxETF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxETF.Location = new System.Drawing.Point(495, 511);
            this.tbxETF.Name = "tbxETF";
            this.tbxETF.ReadOnly = true;
            this.tbxETF.Size = new System.Drawing.Size(421, 40);
            this.tbxETF.TabIndex = 33;
            // 
            // lblETF
            // 
            this.lblETF.AutoSize = true;
            this.lblETF.Location = new System.Drawing.Point(494, 475);
            this.lblETF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblETF.Name = "lblETF";
            this.lblETF.Size = new System.Drawing.Size(70, 33);
            this.lblETF.TabIndex = 32;
            this.lblETF.Text = "ETF";
            // 
            // tbxEPF
            // 
            this.tbxEPF.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxEPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxEPF.Location = new System.Drawing.Point(495, 427);
            this.tbxEPF.Name = "tbxEPF";
            this.tbxEPF.ReadOnly = true;
            this.tbxEPF.Size = new System.Drawing.Size(421, 40);
            this.tbxEPF.TabIndex = 31;
            // 
            // tbxGSal
            // 
            this.tbxGSal.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxGSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxGSal.Location = new System.Drawing.Point(495, 258);
            this.tbxGSal.Name = "tbxGSal";
            this.tbxGSal.ReadOnly = true;
            this.tbxGSal.Size = new System.Drawing.Size(421, 40);
            this.tbxGSal.TabIndex = 30;
            // 
            // lblEPF
            // 
            this.lblEPF.AutoSize = true;
            this.lblEPF.Location = new System.Drawing.Point(494, 391);
            this.lblEPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEPF.Name = "lblEPF";
            this.lblEPF.Size = new System.Drawing.Size(79, 33);
            this.lblEPF.TabIndex = 28;
            this.lblEPF.Text = "EPF ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 700);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(258, 67);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(494, 222);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 33);
            this.label15.TabIndex = 24;
            this.label15.Text = "Gross Salary";
            // 
            // tbxBonuses
            // 
            this.tbxBonuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBonuses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxBonuses.Location = new System.Drawing.Point(28, 600);
            this.tbxBonuses.Name = "tbxBonuses";
            this.tbxBonuses.Size = new System.Drawing.Size(432, 40);
            this.tbxBonuses.TabIndex = 23;
            this.tbxBonuses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBonuses_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 564);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 33);
            this.label14.TabIndex = 22;
            this.label14.Text = "Bonuses";
            // 
            // tbxAdvances
            // 
            this.tbxAdvances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAdvances.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAdvances.Location = new System.Drawing.Point(28, 515);
            this.tbxAdvances.Name = "tbxAdvances";
            this.tbxAdvances.Size = new System.Drawing.Size(432, 40);
            this.tbxAdvances.TabIndex = 21;
            this.tbxAdvances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAdvances_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 479);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 33);
            this.label13.TabIndex = 20;
            this.label13.Text = "Advances";
            // 
            // tbxAllowances
            // 
            this.tbxAllowances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAllowances.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAllowances.Location = new System.Drawing.Point(28, 427);
            this.tbxAllowances.Name = "tbxAllowances";
            this.tbxAllowances.Size = new System.Drawing.Size(432, 40);
            this.tbxAllowances.TabIndex = 19;
            this.tbxAllowances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAllowances_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Allowances";
            // 
            // tbxBasicSal
            // 
            this.tbxBasicSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBasicSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxBasicSal.Location = new System.Drawing.Point(28, 171);
            this.tbxBasicSal.Name = "tbxBasicSal";
            this.tbxBasicSal.Size = new System.Drawing.Size(432, 40);
            this.tbxBasicSal.TabIndex = 17;
            this.tbxBasicSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBasicSal_KeyPress);
            this.tbxBasicSal.Leave += new System.EventHandler(this.tbxBasicSal_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "Basic Salary";
            // 
            // tbxPSID
            // 
            this.tbxPSID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxPSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPSID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxPSID.Location = new System.Drawing.Point(28, 85);
            this.tbxPSID.Name = "tbxPSID";
            this.tbxPSID.ReadOnly = true;
            this.tbxPSID.Size = new System.Drawing.Size(432, 40);
            this.tbxPSID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Payslip ID";
            // 
            // tbxOTHours
            // 
            this.tbxOTHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOTHours.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxOTHours.Location = new System.Drawing.Point(28, 345);
            this.tbxOTHours.Name = "tbxOTHours";
            this.tbxOTHours.Size = new System.Drawing.Size(432, 40);
            this.tbxOTHours.TabIndex = 13;
            this.tbxOTHours.TextChanged += new System.EventHandler(this.tbxOTHours_TextChanged);
            this.tbxOTHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOTHours_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "No. of OT Hours";
            // 
            // tbxWHours
            // 
            this.tbxWHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWHours.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxWHours.Location = new System.Drawing.Point(28, 258);
            this.tbxWHours.Name = "tbxWHours";
            this.tbxWHours.Size = new System.Drawing.Size(432, 40);
            this.tbxWHours.TabIndex = 11;
            this.tbxWHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWHours_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 33);
            this.label12.TabIndex = 10;
            this.label12.Text = "No. of Hours Worked";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(384, 955);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(268, 67);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(65, 955);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(272, 67);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1730, 1097);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryInfo";
            this.Load += new System.EventHandler(this.SalaryInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxDesignation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxEmpName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxAllowances;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxBasicSal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPSID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxOTHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxWHours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxBonuses;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxAdvances;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxNetSal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxETF;
        private System.Windows.Forms.Label lblETF;
        private System.Windows.Forms.TextBox tbxEPF;
        private System.Windows.Forms.TextBox tbxGSal;
        private System.Windows.Forms.Label lblEPF;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxOTPay;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnViewPS;
        private System.Windows.Forms.DateTimePicker year;
        private System.Windows.Forms.TextBox tbxArrears;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker month;
        private System.Windows.Forms.ComboBox cbxEmpID;
    }
}