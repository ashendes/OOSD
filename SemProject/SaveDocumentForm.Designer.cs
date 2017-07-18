namespace SemProject
{
    partial class SaveDocumentForm
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.entryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.docsTableAdapter = new SemProject.DataSet1TableAdapters.docsTableAdapter();
            this.buttonExit = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(712, 849);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(150, 44);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // panel
            // 
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
            this.panel.Location = new System.Drawing.Point(24, 113);
            this.panel.Margin = new System.Windows.Forms.Padding(6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1162, 367);
            this.panel.TabIndex = 19;
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
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.documentTypeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.docsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(24, 516);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1162, 321);
            this.dataGridView.TabIndex = 17;
            // 
            // entryIDDataGridViewTextBoxColumn
            // 
            this.entryIDDataGridViewTextBoxColumn.DataPropertyName = "Entry ID";
            this.entryIDDataGridViewTextBoxColumn.HeaderText = "Entry ID";
            this.entryIDDataGridViewTextBoxColumn.Name = "entryIDDataGridViewTextBoxColumn";
            this.entryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // documentTypeDataGridViewTextBoxColumn
            // 
            this.documentTypeDataGridViewTextBoxColumn.DataPropertyName = "Document Type";
            this.documentTypeDataGridViewTextBoxColumn.HeaderText = "Document Type";
            this.documentTypeDataGridViewTextBoxColumn.Name = "documentTypeDataGridViewTextBoxColumn";
            this.documentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(874, 849);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 44);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // docsTableAdapter
            // 
            this.docsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1036, 849);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 44);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(678, 79);
            this.label6.TabIndex = 25;
            this.label6.Text = "Save New Document";
            // 
            // SaveDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1222, 919);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SaveDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker docDate;
        private System.Windows.Forms.Button buttonNew;
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSave;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource docsBindingSource;
        private DataSet1TableAdapters.docsTableAdapter docsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label label6;
    }
}

