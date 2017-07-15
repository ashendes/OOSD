namespace Payroll_standalone
{
    partial class Switchboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switchboard));
            this.btnDAE = new System.Windows.Forms.Button();
            this.btnSA = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelusername = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditRates = new System.Windows.Forms.Button();
            this.btnSalCalc = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDAE
            // 
            this.btnDAE.Location = new System.Drawing.Point(29, 58);
            this.btnDAE.Name = "btnDAE";
            this.btnDAE.Size = new System.Drawing.Size(417, 86);
            this.btnDAE.TabIndex = 0;
            this.btnDAE.Text = "Attendance Entry";
            this.btnDAE.UseVisualStyleBackColor = true;
            this.btnDAE.Click += new System.EventHandler(this.btnDAE_Click);
            // 
            // btnSA
            // 
            this.btnSA.Location = new System.Drawing.Point(29, 170);
            this.btnSA.Name = "btnSA";
            this.btnSA.Size = new System.Drawing.Size(417, 86);
            this.btnSA.TabIndex = 1;
            this.btnSA.Text = "Salary Amendment";
            this.btnSA.UseVisualStyleBackColor = true;
            this.btnSA.Click += new System.EventHandler(this.btnSA_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelusername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(2018, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(170, 32);
            this.toolStripStatusLabel1.Text = "Logged in as : ";
            // 
            // toolStripStatusLabelusername
            // 
            this.toolStripStatusLabelusername.Name = "toolStripStatusLabelusername";
            this.toolStripStatusLabelusername.Size = new System.Drawing.Size(74, 32);
            this.toolStripStatusLabelusername.Text = "[user]";
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(1623, 1107);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(307, 78);
            this.mainButton.TabIndex = 4;
            this.mainButton.Text = "Check E-mail";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1561, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2018, 40);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 36);
            this.fileToolStripMenuItem.Text = "New";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditRates);
            this.groupBox1.Controls.Add(this.btnSalCalc);
            this.groupBox1.Controls.Add(this.btnDAE);
            this.groupBox1.Controls.Add(this.btnSA);
            this.groupBox1.Location = new System.Drawing.Point(1484, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 541);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payroll Activities";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEditRates
            // 
            this.btnEditRates.Location = new System.Drawing.Point(29, 287);
            this.btnEditRates.Name = "btnEditRates";
            this.btnEditRates.Size = new System.Drawing.Size(417, 86);
            this.btnEditRates.TabIndex = 16;
            this.btnEditRates.Text = "Edit Rates";
            this.btnEditRates.UseVisualStyleBackColor = true;
            this.btnEditRates.Click += new System.EventHandler(this.btnEditRates_Click);
            // 
            // btnSalCalc
            // 
            this.btnSalCalc.Location = new System.Drawing.Point(29, 401);
            this.btnSalCalc.Name = "btnSalCalc";
            this.btnSalCalc.Size = new System.Drawing.Size(417, 86);
            this.btnSalCalc.TabIndex = 15;
            this.btnSalCalc.Text = "Calculate Salary";
            this.btnSalCalc.UseVisualStyleBackColor = true;
            this.btnSalCalc.Click += new System.EventHandler(this.btnSalCalc_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(144, 539);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(417, 86);
            this.btnHR.TabIndex = 17;
            this.btnHR.Text = "OPen HR";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(288, 807);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(417, 86);
            this.btnInventory.TabIndex = 18;
            this.btnInventory.Text = "OPen Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // Switchboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2018, 1296);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Switchboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switchboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDAE;
        private System.Windows.Forms.Button btnSA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelusername;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalCalc;
        private System.Windows.Forms.Button btnEditRates;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnInventory;
    }
}