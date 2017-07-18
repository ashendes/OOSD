namespace SemProject
{
    partial class GenerateDocForm
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
            this.components = new System.ComponentModel.Container();
            this.docDate = new System.Windows.Forms.DateTimePicker();
            this.docsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SemProject.DataSet1();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonTemplate = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.docType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.docCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.docName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.docID = new System.Windows.Forms.TextBox();
            this.docsTableAdapter = new SemProject.DataSet1TableAdapters.docsTableAdapter();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // docDate
            // 
            this.docDate.CustomFormat = "yyyy-MM-dd";
            this.docDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsBindingSource, "Date", true));
            this.docDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.docDate.Location = new System.Drawing.Point(490, 171);
            this.docDate.Margin = new System.Windows.Forms.Padding(6);
            this.docDate.Name = "docDate";
            this.docDate.Size = new System.Drawing.Size(622, 31);
            this.docDate.TabIndex = 1;
            // 
            // docsBindingSource
            // 
            this.docsBindingSource.DataMember = "docs";
            this.docsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonTemplate);
            this.panel.Controls.Add(this.buttonUpload);
            this.panel.Controls.Add(this.lblStatus);
            this.panel.Controls.Add(this.progressBar);
            this.panel.Controls.Add(this.docDate);
            this.panel.Controls.Add(this.docType);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.docCustomer);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.docName);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.docID);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(24, 23);
            this.panel.Margin = new System.Windows.Forms.Padding(6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1162, 367);
            this.panel.TabIndex = 19;
            // 
            // buttonTemplate
            // 
            this.buttonTemplate.Location = new System.Drawing.Point(250, 273);
            this.buttonTemplate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTemplate.Name = "buttonTemplate";
            this.buttonTemplate.Size = new System.Drawing.Size(196, 44);
            this.buttonTemplate.TabIndex = 27;
            this.buttonTemplate.Text = "New Template";
            this.buttonTemplate.UseVisualStyleBackColor = true;
            this.buttonTemplate.Click += new System.EventHandler(this.buttonTemplate_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(44, 273);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(194, 44);
            this.buttonUpload.TabIndex = 26;
            this.buttonUpload.Text = "Upload File";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(716, 323);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(189, 25);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Upload Completed";
            this.lblStatus.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(490, 273);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(626, 44);
            this.progressBar.TabIndex = 25;
            // 
            // docType
            // 
            this.docType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsBindingSource, "Document Type", true));
            this.docType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docType.FormattingEnabled = true;
            this.docType.Items.AddRange(new object[] {
            ".doc",
            ".xls",
            ""});
            this.docType.Location = new System.Drawing.Point(490, 221);
            this.docType.Margin = new System.Windows.Forms.Padding(6);
            this.docType.Name = "docType";
            this.docType.Size = new System.Drawing.Size(622, 33);
            this.docType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Docment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer";
            // 
            // docCustomer
            // 
            this.docCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsBindingSource, "Customer", true));
            this.docCustomer.Location = new System.Drawing.Point(490, 121);
            this.docCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.docCustomer.Name = "docCustomer";
            this.docCustomer.Size = new System.Drawing.Size(622, 31);
            this.docCustomer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // docName
            // 
            this.docName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsBindingSource, "Name", true));
            this.docName.Location = new System.Drawing.Point(490, 71);
            this.docName.Margin = new System.Windows.Forms.Padding(6);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(622, 31);
            this.docName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entry ID";
            // 
            // docID
            // 
            this.docID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsBindingSource, "Entry ID", true));
            this.docID.Location = new System.Drawing.Point(490, 23);
            this.docID.Margin = new System.Windows.Forms.Padding(6);
            this.docID.Name = "docID";
            this.docID.ReadOnly = true;
            this.docID.Size = new System.Drawing.Size(622, 31);
            this.docID.TabIndex = 0;
            // 
            // docsTableAdapter
            // 
            this.docsTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // GenerateDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 981);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GenerateDocForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker docDate;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox docType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox docCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox docName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox docID;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource docsBindingSource;
        private DataSet1TableAdapters.docsTableAdapter docsTableAdapter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonTemplate;
    }
}

