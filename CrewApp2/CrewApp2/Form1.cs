using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewApp2
{

    public partial class Form1 : Form
    { 
        public string logname;
        public string savenote;
        public string crewtxt;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            TableFill();

            FullNameComboBox.DataSource = aZUREDBDataSet.Crew_Master;
            FullNameComboBox.DisplayMember = "FullName";

            Login login = new Login();

            login.ShowDialog(this);


            cREWINGNoteTextBox.Text = Properties.Settings.Default.BackupCrewwingNote;

            username.Text = Properties.Settings.Default.UserNames;

            crew_MasterBindingSource.RemoveFilter();
            

        }


        private void TECHNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            Form InputNote = new Form();

        }

        private void CREWINGNoteTextBox_MouseEnter(object sender, EventArgs e)
        {

          //  cREWINGNoteTextBox.Text = Properties.Settings.Default.BackupCrewwingNote;

          //  this.Validate();
          //  this.crew_MasterBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(aZUREDBDataSet);
           // this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);
        }

        public void  TableFill()
        {
           

            this.crew_ConfidencialReportTableAdapter.Fill(this.aZUREDBDataSet.Crew_ConfidencialReport);
          
            this.crew_ApplicationTableAdapter.Fill(this.aZUREDBDataSet.Crew_Application);
   
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);
        }

        private void Crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void FileNameListBox1_DoubleClick(object sender, EventArgs e)
        {
            // MessageBox.Show(fileNameListBox.SelectedValue.ToString());

            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                CloudBlockBlob blob = container.GetBlockBlobReference(fileNameListBox.SelectedValue.ToString());

                SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy
                {
                    SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5),
                    SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24),
                    Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write
                };

                string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

                Process.Start(blob.Uri + sasBlobToken);


            }

            catch
            {

                MessageBox.Show("Select file");

            }
        }

        private void FileNameListBox_DoubleClick(object sender, EventArgs e)
        {
            // MessageBox.Show(fileNameListBox.SelectedValue.ToString());

            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                CloudBlockBlob blob = container.GetBlockBlobReference(fileNameListBox.SelectedValue.ToString());

                SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy
                {
                    SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5),
                    SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24),
                    Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write
                };

                string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

                Process.Start(blob.Uri + sasBlobToken);


            }

            catch
            {

                MessageBox.Show("Select file");

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_ApplicationBindingSource.EndEdit();
            this.crew_MasterBindingSource.EndEdit();
            this.crew_ConfidencialReportBindingSource.EndEdit();
            this.crew_MasterTableAdapter.Update(aZUREDBDataSet.Crew_Master);
            this.crew_ApplicationTableAdapter.Update(aZUREDBDataSet.Crew_Application);
            this.crew_ConfidencialReportTableAdapter.Update(aZUREDBDataSet.Crew_ConfidencialReport);

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            crew_MasterBindingSource.Filter = string.Format("FullName like '%{0}%'", FullNameComboBox.Text);
            crew_MasterBindingSource.Filter = string.Format("FullName like '%{0}%'", RankComboBox.Text);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

            this.crew_ConfidencialReportTableAdapter.Fill(this.aZUREDBDataSet.Crew_ConfidencialReport);

            this.crew_ApplicationTableAdapter.Fill(this.aZUREDBDataSet.Crew_Application);

            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

            crew_MasterBindingSource.RemoveFilter();

        }

        private void RemoveFilter_Click(object sender, EventArgs e)
        {
            crew_MasterBindingSource.RemoveFilter();
        }

        private void SaveNote_Click(object sender, EventArgs e)
        {
            InputNote InputNote = new InputNote();

            InputNote.inputform= cREWINGNoteTextBox.Text;

            InputNote.Show();

        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddPerson Addperson = new AddPerson();
            Addperson.Show();
        }


        private void FileNameListBox_DragDrop(object sender, DragEventArgs e)
        {
          

            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (fileName.Length <= 0)
            {
                return;
            }

                string filenamefn = System.IO.Path.GetFileName(fileName[0]);

                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                var fileStream = System.IO.File.OpenRead(fileName[0]);

                crew_ApplicationBindingSource.AddNew();

                fileNameTextBox1.Text = filenamefn;

                CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
                blockBlob_upload.UploadFromStream(fileStream);

                this.Validate();
                this.crew_ApplicationBindingSource.EndEdit();
                this.crew_ApplicationTableAdapter.Update(aZUREDBDataSet.Crew_Application);


        }

        private void FileNameListBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void FileNameListBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (fileName.Length <= 0)
            {
                return;
            }

            string filenamefn = System.IO.Path.GetFileName(fileName[0]);

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            var fileStream = System.IO.File.OpenRead(fileName[0]);

            crew_ConfidencialReportBindingSource.AddNew();


            fileNameTextBox.Text = filenamefn;

            CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
            blockBlob_upload.UploadFromStream(fileStream);

            this.Validate();
            this.crew_ConfidencialReportBindingSource.EndEdit();
            this.crew_ConfidencialReportTableAdapter.Update(aZUREDBDataSet.Crew_ConfidencialReport);

        }

        private void FileNameListBox1_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }


        private void RankComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            crew_MasterBindingSource.Filter = string.Format("PresentRANK like '{0:s}'", RankComboBox.Text);
        }

        private void RankComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            crew_MasterBindingSource.Filter = string.Format("PresentRANK like '%{0}%'", RankComboBox.Text);
        }

        private void RankComboBox_Enter(object sender, EventArgs e)
        {
           

        }


        private void FullNameComboBox_TextChanged(object sender, EventArgs e)
        {
            crew_MasterBindingSource.Filter = string.Format("FullName like '{0:s}'", FullNameComboBox.Text);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            this.crew_ConfidencialReportTableAdapter.Fill(this.aZUREDBDataSet.Crew_ConfidencialReport);

            this.crew_ApplicationTableAdapter.Fill(this.aZUREDBDataSet.Crew_Application);

            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

            crew_MasterBindingSource.RemoveFilter();
        }
    }
}
