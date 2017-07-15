namespace NewEmployeeDatabase
{
    partial class ViewDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDatabase));
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddresss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.AllowUserToDeleteRows = false;
            this.dataGridViewDatabase.AllowUserToOrderColumns = true;
            this.dataGridViewDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDatabase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFirst,
            this.ColumnLast,
            this.ColumnDept,
            this.ColumnDes,
            this.ColumnMob,
            this.ColumnAddresss,
            this.ColumnDob,
            this.ColumnGen,
            this.ColumnEmail,
            this.ColumnFull,
            this.ColumnRes,
            this.ColumnHire,
            this.ColumnSalary});
            this.dataGridViewDatabase.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.RowTemplate.Height = 24;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(1080, 624);
            this.dataGridViewDatabase.TabIndex = 0;
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
            // ColumnAddresss
            // 
            this.ColumnAddresss.HeaderText = "Address";
            this.ColumnAddresss.Name = "ColumnAddresss";
            this.ColumnAddresss.Width = 400;
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
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(975, 698);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Database";
            // 
            // ViewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDatabase";
            this.Text = "ViewDatabase";
            this.Load += new System.EventHandler(this.ViewDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatabase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddresss;
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