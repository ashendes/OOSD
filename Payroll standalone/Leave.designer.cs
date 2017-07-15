namespace Payroll_standalone
{
    partial class Leave
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
            this.ColumnLID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlLeave = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLeave = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUtype = new System.Windows.Forms.ComboBox();
            this.dtUend = new System.Windows.Forms.DateTimePicker();
            this.dtUstart = new System.Windows.Forms.DateTimePicker();
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbUleave = new System.Windows.Forms.TextBox();
            this.tbUid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
            this.tabControlLeave.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(988, 844);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 47);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewLeave);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1139, 755);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Current Leaves";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeave
            // 
            this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLID,
            this.ColumnEID,
            this.ColumnName,
            this.ColumnType,
            this.ColumnStart,
            this.ColumnEnd});
            this.dataGridViewLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeave.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewLeave.Name = "dataGridViewLeave";
            this.dataGridViewLeave.RowTemplate.Height = 24;
            this.dataGridViewLeave.Size = new System.Drawing.Size(1131, 745);
            this.dataGridViewLeave.TabIndex = 0;
            // 
            // ColumnLID
            // 
            this.ColumnLID.HeaderText = "Leave ID";
            this.ColumnLID.Name = "ColumnLID";
            // 
            // ColumnEID
            // 
            this.ColumnEID.HeaderText = "Employee ID";
            this.ColumnEID.Name = "ColumnEID";
            this.ColumnEID.Width = 75;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Employee Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 250;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Leave Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 150;
            // 
            // ColumnStart
            // 
            this.ColumnStart.HeaderText = "Start Date";
            this.ColumnStart.Name = "ColumnStart";
            this.ColumnStart.Width = 150;
            // 
            // ColumnEnd
            // 
            this.ColumnEnd.HeaderText = "End Date";
            this.ColumnEnd.Name = "ColumnEnd";
            this.ColumnEnd.Width = 150;
            // 
            // tabControlLeave
            // 
            this.tabControlLeave.Controls.Add(this.tabPage1);
            this.tabControlLeave.Controls.Add(this.tabPage2);
            this.tabControlLeave.Controls.Add(this.tabPage3);
            this.tabControlLeave.Location = new System.Drawing.Point(18, 19);
            this.tabControlLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlLeave.Name = "tabControlLeave";
            this.tabControlLeave.SelectedIndex = 0;
            this.tabControlLeave.Size = new System.Drawing.Size(1155, 802);
            this.tabControlLeave.TabIndex = 0;
            this.tabControlLeave.SelectedIndexChanged += new System.EventHandler(this.tabControlLeave_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cbType);
            this.tabPage1.Controls.Add(this.dtEnd);
            this.tabPage1.Controls.Add(this.dtStart);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.tbLeave);
            this.tabPage1.Controls.Add(this.tbId);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1139, 755);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Leave";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(42, 298);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(156, 25);
            this.label30.TabIndex = 22;
            this.label30.Text = "Leave Details";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(42, 44);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(195, 25);
            this.label29.TabIndex = 21;
            this.label29.Text = "Employee Details";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(42, 448);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 25);
            this.label22.TabIndex = 20;
            this.label22.Text = "Leave Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 195);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 25);
            this.label21.TabIndex = 19;
            this.label21.Text = "Employee Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(42, 116);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 25);
            this.label20.TabIndex = 18;
            this.label20.Text = "Leave ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 359);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 25);
            this.label19.TabIndex = 17;
            this.label19.Text = "Start Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(628, 359);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 25);
            this.label18.TabIndex = 16;
            this.label18.Text = "End Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(598, 116);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 25);
            this.label17.TabIndex = 15;
            this.label17.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 13;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Medical",
            "Casual"});
            this.cbType.Location = new System.Drawing.Point(218, 438);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(298, 33);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(774, 352);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(312, 31);
            this.dtEnd.TabIndex = 3;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(218, 352);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(298, 31);
            this.dtStart.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(218, 188);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(868, 31);
            this.tbName.TabIndex = 1;
            // 
            // tbLeave
            // 
            this.tbLeave.Location = new System.Drawing.Point(218, 108);
            this.tbLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLeave.Name = "tbLeave";
            this.tbLeave.ReadOnly = true;
            this.tbLeave.Size = new System.Drawing.Size(298, 31);
            this.tbLeave.TabIndex = 8;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(774, 111);
            this.tbId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(312, 31);
            this.tbId.TabIndex = 0;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 442);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(813, 655);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 47);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(969, 655);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbUtype);
            this.tabPage2.Controls.Add(this.dtUend);
            this.tabPage2.Controls.Add(this.dtUstart);
            this.tabPage2.Controls.Add(this.tbUname);
            this.tabPage2.Controls.Add(this.tbUleave);
            this.tabPage2.Controls.Add(this.tbUid);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1139, 755);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Leave";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(34, 298);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(156, 25);
            this.label31.TabIndex = 37;
            this.label31.Text = "Leave Details";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(34, 44);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(195, 25);
            this.label32.TabIndex = 36;
            this.label32.Text = "Employee Details";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 458);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 25);
            this.label23.TabIndex = 35;
            this.label23.Text = "Leave Type";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 192);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(169, 25);
            this.label24.TabIndex = 34;
            this.label24.Text = "Employee Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 122);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 25);
            this.label25.TabIndex = 33;
            this.label25.Text = "Leave ID";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(34, 369);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 25);
            this.label26.TabIndex = 32;
            this.label26.Text = "Start Date";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(621, 369);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 25);
            this.label27.TabIndex = 31;
            this.label27.Text = "End Date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(591, 122);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(133, 25);
            this.label28.TabIndex = 30;
            this.label28.Text = "Employee ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(964, 655);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 47);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 28;
            // 
            // cbUtype
            // 
            this.cbUtype.FormattingEnabled = true;
            this.cbUtype.Items.AddRange(new object[] {
            "Medical",
            "Casual"});
            this.cbUtype.Location = new System.Drawing.Point(213, 442);
            this.cbUtype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUtype.Name = "cbUtype";
            this.cbUtype.Size = new System.Drawing.Size(298, 33);
            this.cbUtype.TabIndex = 4;
            this.cbUtype.SelectedIndexChanged += new System.EventHandler(this.cbUtype_SelectedIndexChanged);
            // 
            // dtUend
            // 
            this.dtUend.Location = new System.Drawing.Point(770, 356);
            this.dtUend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtUend.Name = "dtUend";
            this.dtUend.Size = new System.Drawing.Size(312, 31);
            this.dtUend.TabIndex = 3;
            // 
            // dtUstart
            // 
            this.dtUstart.Location = new System.Drawing.Point(213, 356);
            this.dtUstart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtUstart.Name = "dtUstart";
            this.dtUstart.Size = new System.Drawing.Size(298, 31);
            this.dtUstart.TabIndex = 2;
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(213, 188);
            this.tbUname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUname.Name = "tbUname";
            this.tbUname.ReadOnly = true;
            this.tbUname.Size = new System.Drawing.Size(868, 31);
            this.tbUname.TabIndex = 1;
            // 
            // tbUleave
            // 
            this.tbUleave.Location = new System.Drawing.Point(213, 117);
            this.tbUleave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUleave.Name = "tbUleave";
            this.tbUleave.Size = new System.Drawing.Size(298, 31);
            this.tbUleave.TabIndex = 23;
            this.tbUleave.TextChanged += new System.EventHandler(this.tbUleave_TextChanged);
            // 
            // tbUid
            // 
            this.tbUid.Location = new System.Drawing.Point(770, 117);
            this.tbUid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUid.Name = "tbUid";
            this.tbUid.ReadOnly = true;
            this.tbUid.Size = new System.Drawing.Size(312, 31);
            this.tbUid.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 447);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 364);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 364);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 298);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 192);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 25);
            this.label14.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(566, 117);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 25);
            this.label15.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 112);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 25);
            this.label16.TabIndex = 15;
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 909);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControlLeave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Leave";
            this.Text = "Leave";
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
            this.tabControlLeave.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnd;
        private System.Windows.Forms.TabControl tabControlLeave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLeave;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUtype;
        private System.Windows.Forms.DateTimePicker dtUend;
        private System.Windows.Forms.DateTimePicker dtUstart;
        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbUleave;
        private System.Windows.Forms.TextBox tbUid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnNew;
    }
}

