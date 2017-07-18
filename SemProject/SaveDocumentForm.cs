using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Microsoft.Office.Interop.Word;

namespace SemProject
{
    public partial class SaveDocumentForm : Form
    {
        public SaveDocumentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.docs' table. You can move, or remove it, as needed.
            this.docsTableAdapter.Fill(this.dataSet1.docs);
            docsBindingSource.DataSource = this.dataSet1.docs;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                lblStatus.Visible = false;
                progressBar.Value = 0;
                docName.Focus();
                this.dataSet1.docs.AdddocsRow(this.dataSet1.docs.NewdocsRow());
                docsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            lblStatus.Visible = false;
            progressBar.Value = 0;
            docName.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                docsBindingSource.EndEdit();
                docsTableAdapter.Update(this.dataSet1.docs);
                panel.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteFile()
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Areyou sure you want to delete the selected record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try
                {
                    docsBindingSource.RemoveCurrent();
                    docsBindingSource.EndEdit();
                    docsTableAdapter.Update(this.dataSet1.docs);
                    panel.Enabled = false;

                    deleteFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        struct FtpSetting
        {
            public String server { get; set;}
            public String username { get; set; }
            public String password { get; set; }
            public String filename { get; set; }
            public String fullname { get; set; }
        }

        FtpSetting _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileName1 = ((FtpSetting)e.Argument).filename;
                string fileName = string.Format("{0}.{1}", docID.Text, fileName1.Split('.')[fileName1.Split('.').Length - 1]);
                string fullName = ((FtpSetting)e.Argument).fullname;
                string userName = ((FtpSetting)e.Argument).username;
                string passWord = ((FtpSetting)e.Argument).password;
                string serVer = ((FtpSetting)e.Argument).server;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", serVer, fileName)));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(userName, passWord);

                Stream ftpStream = request.GetRequestStream();
                FileStream fs = File.OpenRead(fullName);
                byte[] buffer = new byte[1024];
                double total = (double)fs.Length;
                int byteRead = 0;
                double read = 0;
                do
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        byteRead = fs.Read(buffer, 0, 1024);
                        ftpStream.Write(buffer, 0, byteRead);
                        read += (double)byteRead;
                        double percentage = read / total * 100;
                        backgroundWorker.ReportProgress((int)percentage);
                    }
                }
                while (byteRead != 0);
                fs.Close();
                ftpStream.Close();
            }catch (Exception ex)
            {
                if (ex is WebException)
                {
                    MessageBox.Show("FTP Server not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Visible = true;
        }
        
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = string.Format("Selected Document Types|*{0}*", docType.SelectedItem.ToString())})
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        _inputParameter.username = "user";
                        _inputParameter.password = "1234";
                        _inputParameter.server = "ftp://localhost";
                        _inputParameter.filename = fi.Name;
                        _inputParameter.fullname = fi.FullName;
                        backgroundWorker.RunWorkerAsync(_inputParameter);
                    }
                }
            }
            catch(System.NullReferenceException ex)
            {
                MessageBox.Show("Please select a valid document type", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void downloadFile(string fileName)
        {
            string inputfilepath = string.Format("C:/Users/ASUS/Desktop/Artiwood Downloads/{0}", fileName);
            string ftphost = "localhost";
            string ftpfilepath = string.Format("/{0}", fileName);

            string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

            using (WebClient request = new WebClient())
            {
                request.Credentials = new NetworkCredential("user", "1234");
                byte[] fileData = request.DownloadData(ftpfullpath);

                using (FileStream file = File.Create(inputfilepath))
                {
                    file.Write(fileData, 0, fileData.Length);
                    file.Close();
                }
                MessageBox.Show("Download Complete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setTemplate()
        {
            downloadFile("template.doc");
            
            docType.Text = ".doc";
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                downloadFile(string.Format("{0}{1}", docID.Text, docType.SelectedItem.ToString()));              
            }
            catch (Exception ex)
            {
                MessageBox.Show("The selected document doesn't exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTemplate_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            Document document = ap.Documents.Open(@"C:\Users\ASUS\Desktop\Templates\template.doc");
            ap.Visible = true;
        }
    }
}
