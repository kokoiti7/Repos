using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Diagnostics;
using System.IO;

namespace CrewAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_ConfidencialReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_ConfidencialReportTableAdapter.Fill(this.aZUREDBDataSet.Crew_ConfidencialReport);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Application' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_ApplicationTableAdapter.Fill(this.aZUREDBDataSet.Crew_Application);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

        }

        private void Crewlistbox_DragDrop(object sender, DragEventArgs e)
        {
            string filenamefn;

            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            OpenFileDialog ofd = new OpenFileDialog();

            if (fileName.Length <= 0)
            {
                return;
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                System.IO.Stream stream;
                stream = ofd.OpenFile();

                filenamefn = System.IO.Path.GetFileName(fileName[0]);

                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                var fileStream = System.IO.File.OpenRead(fileName[0]);

                crew_ApplicationBindingSource.AddNew();
                crew_ConfidencialReportBindingSource.AddNew();

                fileNameTextBox.Text = filenamefn;
                fileNameTextBox1.Text = filenamefn;

                CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
                blockBlob_upload.UploadFromStream(fileStream);
            }

            // save 
            this.Validate();

            this.crew_ConfidencialReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Crewlistbox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }
    }
}
