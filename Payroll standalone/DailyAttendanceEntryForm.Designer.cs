namespace Payroll_standalone
{
    partial class DailyAttendanceEntryForm
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
            this.dataSet1 = new System.Data.DataSet();
            this.FormTitle = new System.Windows.Forms.Label();
            this.panelTableEntry = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClrRow = new System.Windows.Forms.Button();
            this.btnAddSingle = new System.Windows.Forms.Button();
            this.btnClrAll = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSingleEntry = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBxEmpID = new System.Windows.Forms.ComboBox();
            this.tbxEmpName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelTableEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSingleEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Arial Narrow", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(31, 71);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(546, 88);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Attendance Entry";
            // 
            // panelTableEntry
            // 
            this.panelTableEntry.Controls.Add(this.label10);
            this.panelTableEntry.Controls.Add(this.label9);
            this.panelTableEntry.Controls.Add(this.btnClrRow);
            this.panelTableEntry.Controls.Add(this.btnAddSingle);
            this.panelTableEntry.Controls.Add(this.btnClrAll);
            this.panelTableEntry.Controls.Add(this.btnSubmit);
            this.panelTableEntry.Controls.Add(this.dateTimePicker1);
            this.panelTableEntry.Controls.Add(this.dataGridView1);
            this.panelTableEntry.Controls.Add(this.label1);
            this.panelTableEntry.Location = new System.Drawing.Point(46, 232);
            this.panelTableEntry.Margin = new System.Windows.Forms.Padding(4);
            this.panelTableEntry.Name = "panelTableEntry";
            this.panelTableEntry.Size = new System.Drawing.Size(1329, 1014);
            this.panelTableEntry.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "(yyyy-mm-dd)";
            // 
            // btnClrRow
            // 
            this.btnClrRow.Location = new System.Drawing.Point(864, 901);
            this.btnClrRow.Name = "btnClrRow";
            this.btnClrRow.Size = new System.Drawing.Size(196, 58);
            this.btnClrRow.TabIndex = 6;
            this.btnClrRow.Text = "Clear Row";
            this.btnClrRow.UseVisualStyleBackColor = true;
            this.btnClrRow.Click += new System.EventHandler(this.btnClrRow_Click);
            // 
            // btnAddSingle
            // 
            this.btnAddSingle.Location = new System.Drawing.Point(994, 45);
            this.btnAddSingle.Name = "btnAddSingle";
            this.btnAddSingle.Size = new System.Drawing.Size(286, 61);
            this.btnAddSingle.TabIndex = 7;
            this.btnAddSingle.Text = "Single Record Entry";
            this.btnAddSingle.UseVisualStyleBackColor = true;
            this.btnAddSingle.Click += new System.EventHandler(this.btnAddSingle_Click);
            // 
            // btnClrAll
            // 
            this.btnClrAll.Location = new System.Drawing.Point(1084, 901);
            this.btnClrAll.Name = "btnClrAll";
            this.btnClrAll.Size = new System.Drawing.Size(196, 58);
            this.btnClrAll.TabIndex = 5;
            this.btnClrAll.Text = "Clear All";
            this.btnClrAll.UseVisualStyleBackColor = true;
            this.btnClrAll.Click += new System.EventHandler(this.btnClrAll_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(642, 901);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(196, 58);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(557, 40);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.InTime,
            this.OutTime,
            this.Absent});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(55, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 696);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // EmpID
            // 
            this.EmpID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EmpID.Frozen = true;
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Width = 208;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.FillWeight = 400F;
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // InTime
            // 
            this.InTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InTime.HeaderText = "In Time";
            this.InTime.Name = "InTime";
            this.InTime.Width = 146;
            // 
            // OutTime
            // 
            this.OutTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutTime.HeaderText = "Out Time";
            this.OutTime.Name = "OutTime";
            this.OutTime.Width = 167;
            // 
            // Absent
            // 
            this.Absent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Absent.FillWeight = 10F;
            this.Absent.HeaderText = "Absent";
            this.Absent.Name = "Absent";
            this.Absent.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // panelSingleEntry
            // 
            this.panelSingleEntry.Controls.Add(this.label8);
            this.panelSingleEntry.Controls.Add(this.label7);
            this.panelSingleEntry.Controls.Add(this.dateTimePicker4);
            this.panelSingleEntry.Controls.Add(this.dateTimePicker3);
            this.panelSingleEntry.Controls.Add(this.btnAddAll);
            this.panelSingleEntry.Controls.Add(this.btnClear);
            this.panelSingleEntry.Controls.Add(this.btnNext);
            this.panelSingleEntry.Controls.Add(this.label6);
            this.panelSingleEntry.Controls.Add(this.label5);
            this.panelSingleEntry.Controls.Add(this.label4);
            this.panelSingleEntry.Controls.Add(this.dateTimePicker2);
            this.panelSingleEntry.Controls.Add(this.label3);
            this.panelSingleEntry.Controls.Add(this.label2);
            this.panelSingleEntry.Controls.Add(this.cBxEmpID);
            this.panelSingleEntry.Controls.Add(this.tbxEmpName);
            this.panelSingleEntry.Location = new System.Drawing.Point(46, 232);
            this.panelSingleEntry.Name = "panelSingleEntry";
            this.panelSingleEntry.Size = new System.Drawing.Size(1329, 1011);
            this.panelSingleEntry.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "(yyyy-mm-dd)";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "h:mm tt";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(404, 557);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(530, 40);
            this.dateTimePicker4.TabIndex = 11;
            this.dateTimePicker4.Value = new System.DateTime(2017, 7, 13, 17, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "h:mm tt";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(404, 451);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(530, 40);
            this.dateTimePicker3.TabIndex = 10;
            this.dateTimePicker3.Value = new System.DateTime(2017, 7, 13, 8, 0, 0, 0);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(994, 45);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(286, 63);
            this.btnAddAll.TabIndex = 8;
            this.btnAddAll.Text = "Table Entry";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(723, 697);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 62);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(497, 697);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(211, 62);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next Entry";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Out Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "In Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee Name";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(404, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(530, 40);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // cBxEmpID
            // 
            this.cBxEmpID.FormattingEnabled = true;
            this.cBxEmpID.Location = new System.Drawing.Point(404, 234);
            this.cBxEmpID.Name = "cBxEmpID";
            this.cBxEmpID.Size = new System.Drawing.Size(530, 41);
            this.cBxEmpID.TabIndex = 1;
            this.cBxEmpID.SelectedIndexChanged += new System.EventHandler(this.cBxEmpID_SelectedIndexChanged);
            // 
            // tbxEmpName
            // 
            this.tbxEmpName.Location = new System.Drawing.Point(404, 343);
            this.tbxEmpName.Name = "tbxEmpName";
            this.tbxEmpName.ReadOnly = true;
            this.tbxEmpName.Size = new System.Drawing.Size(530, 40);
            this.tbxEmpName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Single Entry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 33);
            this.label10.TabIndex = 14;
            this.label10.Text = "Table Entry";
            // 
            // DailyAttendanceEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1413, 1281);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.panelSingleEntry);
            this.Controls.Add(this.panelTableEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailyAttendanceEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Entry";
            this.Load += new System.EventHandler(this.DailyAttendanceEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelTableEntry.ResumeLayout(false);
            this.panelTableEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSingleEntry.ResumeLayout(false);
            this.panelSingleEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Panel panelTableEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelSingleEntry;
        private System.Windows.Forms.TextBox tbxEmpName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClrAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBxEmpID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClrRow;
        private System.Windows.Forms.Button btnAddSingle;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Absent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}

