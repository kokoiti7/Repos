﻿using System;
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

namespace ValityAllView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Validity_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.validity_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_attachTableAdapter.Fill(this.aZUREDBDataSet.Validity_attach);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Items' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_ItemsTableAdapter.Fill(this.aZUREDBDataSet.Validity_Items);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter.Fill(this.aZUREDBDataSet.Validity_Master);

        }

        private void AllView_Click(object sender, EventArgs e)
        {
            Form AllView = new AllView();
            AllView.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.validity_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_attachTableAdapter.Fill(this.aZUREDBDataSet.Validity_attach);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Items' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_ItemsTableAdapter.Fill(this.aZUREDBDataSet.Validity_Items);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter.Fill(this.aZUREDBDataSet.Validity_Master);
        }

        private void FileNameListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (fileName.Length <= 0)
            {
                return;
            }

            string filenamefn = System.IO.Path.GetFileName(fileName[0]);

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ValityAllview.Properties.Settings.Default.accesskey);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(ValityAllview.Properties.Settings.Default.Container);

            var fileStream = System.IO.File.OpenRead(fileName[0]);

            validity_attachBindingSource.AddNew();

            fileNameTextBox.Text = filenamefn;

            CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
            blockBlob_upload.UploadFromStream(fileStream);

            // save 
            this.Validate();
            this.validity_attachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
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

        private void FileNameListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ValityAllview.Properties.Settings.Default.accesskey);

                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(ValityAllview.Properties.Settings.Default.Container);

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
    }
}
