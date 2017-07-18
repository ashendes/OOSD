namespace NewEmployeeDatabase
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtHire = new System.Windows.Forms.DateTimePicker();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.tbDept = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbResident = new System.Windows.Forms.TextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbMobile);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.dtHire);
            this.panel1.Controls.Add(this.dtDob);
            this.panel1.Controls.Add(this.tbDept);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbLname);
            this.panel1.Controls.Add(this.tbFname);
            this.panel1.Controls.Add(this.tbPosition);
            this.panel1.Controls.Add(this.tbResident);
            this.panel1.Controls.Add(this.tbFullname);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(25, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 672);
            this.panel1.TabIndex = 59;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(164, 392);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(190, 22);
            this.tbEmail.TabIndex = 46;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 396);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "Email";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(475, 521);
            this.tbMobile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(208, 22);
            this.tbMobile.TabIndex = 52;
            this.tbMobile.TextChanged += new System.EventHandler(this.tbMobile_TextChanged);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(475, 267);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(208, 24);
            this.cbGender.TabIndex = 40;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // dtHire
            // 
            this.dtHire.CustomFormat = "dd/MM/yyyy";
            this.dtHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHire.Location = new System.Drawing.Point(160, 455);
            this.dtHire.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtHire.Name = "dtHire";
            this.dtHire.Size = new System.Drawing.Size(190, 22);
            this.dtHire.TabIndex = 49;
            // 
            // dtDob
            // 
            this.dtDob.CustomFormat = "dd/MM/yyyy";
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDob.Location = new System.Drawing.Point(164, 264);
            this.dtDob.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(190, 22);
            this.dtDob.TabIndex = 39;
            // 
            // tbDept
            // 
            this.tbDept.Location = new System.Drawing.Point(164, 330);
            this.tbDept.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDept.Name = "tbDept";
            this.tbDept.Size = new System.Drawing.Size(190, 22);
            this.tbDept.TabIndex = 42;
            this.tbDept.TextChanged += new System.EventHandler(this.tbDept_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(164, 194);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(520, 37);
            this.tbAddress.TabIndex = 36;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(475, 138);
            this.tbLname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(208, 22);
            this.tbLname.TabIndex = 34;
            this.tbLname.TextChanged += new System.EventHandler(this.tbLname_TextChanged);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(164, 138);
            this.tbFname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(186, 22);
            this.tbFname.TabIndex = 33;
            this.tbFname.TextChanged += new System.EventHandler(this.tbFname_TextChanged);
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(475, 330);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(208, 22);
            this.tbPosition.TabIndex = 44;
            this.tbPosition.TextChanged += new System.EventHandler(this.tbPosition_TextChanged);
            // 
            // tbResident
            // 
            this.tbResident.Location = new System.Drawing.Point(160, 521);
            this.tbResident.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbResident.Name = "tbResident";
            this.tbResident.Size = new System.Drawing.Size(186, 22);
            this.tbResident.TabIndex = 51;
            this.tbResident.TextChanged += new System.EventHandler(this.tbResident_TextChanged);
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(164, 74);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(520, 22);
            this.tbFullname.TabIndex = 31;
            this.tbFullname.TextChanged += new System.EventHandler(this.tbFullname_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 524);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Mobile";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 524);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "Resident Telephone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Hire Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(164, 12);
            this.tbId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(94, 22);
            this.tbId.TabIndex = 30;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(439, 599);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 39);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Location = new System.Drawing.Point(524, 599);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 39);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(609, 599);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 39);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 29);
            this.label14.TabIndex = 60;
            this.label14.Text = "Update Employee";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 766);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtHire;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.TextBox tbDept;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbResident;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label14;
    }
}