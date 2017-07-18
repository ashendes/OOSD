namespace NewEmployeeDatabase
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(17, 77);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1161, 22);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1194, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.AllowUserToOrderColumns = true;
            this.dataGridViewSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFirst,
            this.ColumnLast,
            this.ColumnDept,
            this.ColumnDes,
            this.ColumnMob,
            this.ColumnAddress,
            this.ColumnDob,
            this.ColumnGen,
            this.ColumnEmail,
            this.ColumnFull,
            this.ColumnRes,
            this.ColumnHire,
            this.ColumnSalary});
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(1297, 486);
            this.dataGridViewSearch.TabIndex = 2;
            this.dataGridViewSearch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearch_CellMouseClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 75;
            // 
            // ColumnFirst
            // 
            this.ColumnFirst.HeaderText = "First Name";
            this.ColumnFirst.Name = "ColumnFirst";
            this.ColumnFirst.Width = 150;
            // 
            // ColumnLast
            // 
            this.ColumnLast.HeaderText = "Last Name";
            this.ColumnLast.Name = "ColumnLast";
            this.ColumnLast.Width = 150;
            // 
            // ColumnDept
            // 
            this.ColumnDept.HeaderText = "Department";
            this.ColumnDept.Name = "ColumnDept";
            this.ColumnDept.Width = 150;
            // 
            // ColumnDes
            // 
            this.ColumnDes.HeaderText = "Designation";
            this.ColumnDes.Name = "ColumnDes";
            this.ColumnDes.Width = 200;
            // 
            // ColumnMob
            // 
            this.ColumnMob.HeaderText = "Mobile Number";
            this.ColumnMob.Name = "ColumnMob";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Width = 400;
            // 
            // ColumnDob
            // 
            this.ColumnDob.HeaderText = "Date of Birth";
            this.ColumnDob.Name = "ColumnDob";
            // 
            // ColumnGen
            // 
            this.ColumnGen.HeaderText = "Gender";
            this.ColumnGen.Name = "ColumnGen";
            this.ColumnGen.Width = 75;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 200;
            // 
            // ColumnFull
            // 
            this.ColumnFull.HeaderText = "Full Name";
            this.ColumnFull.Name = "ColumnFull";
            this.ColumnFull.Width = 350;
            // 
            // ColumnRes
            // 
            this.ColumnRes.HeaderText = "Resident Telephone";
            this.ColumnRes.Name = "ColumnRes";
            // 
            // ColumnHire
            // 
            this.ColumnHire.HeaderText = "Hire Date";
            this.ColumnHire.Name = "ColumnHire";
            this.ColumnHire.Width = 75;
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "Basic Salary";
            this.ColumnSalary.Name = "ColumnSalary";
            this.ColumnSalary.Width = 150;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1209, 637);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1091, 637);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(973, 637);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 35);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Employees";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.Label label1;
    }
}