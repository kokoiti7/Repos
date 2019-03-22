using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Windows.Forms;

namespace GeneralInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void General_Fleet_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.general_Fleet_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.General_fleet_attachGroup1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.general_fleet_attachGroup1TableAdapter.Fill(this.aZUREDBDataSet.General_fleet_attachGroup1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.General_Fleet_information' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.general_Fleet_informationTableAdapter.Fill(this.aZUREDBDataSet.General_Fleet_information);

        }

        private void FilenameListBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void FilenameListBox_DragDrop(object sender, DragEventArgs e)
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

            general_fleet_attachGroup1BindingSource.AddNew();

            filenameTextBox.Text = filenamefn;

            CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
            blockBlob_upload.UploadFromStream(fileStream);

            // save 
            
                this.Validate();
                this.general_Fleet_informationBindingSource.EndEdit();
                this.general_fleet_attachGroup1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void FilenameListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                //Get a reference to a blob within the container.


                // MessageBox.Show(watchlist_FileListBox.SelectedValue.ToString());

                CloudBlockBlob blob = container.GetBlockBlobReference(filenameListBox.SelectedValue.ToString());

                SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
                sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
                sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
                sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

                //Generate the shared access signature on the blob, setting the constraints directly on the signature.
                string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

                //  MessageBox.Show(blob.Uri.ToString());


                Process.Start(blob.Uri + sasBlobToken);
            }

            catch
            {

                MessageBox.Show("Select file");

            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);


            CloudBlockBlob blockBlob_delete = container.GetBlockBlobReference(filenameListBox.SelectedValue.ToString());

            int sel = filenameListBox.SelectedIndex;

            MessageBox.Show(filenameListBox.SelectedValue.ToString());

            DialogResult result = MessageBox.Show("Are you sure ? " + '\n' + "Delete " + filenameListBox.SelectedValue.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //何が選択されたか調べる

            try
            {

                if (result == DialogResult.Yes)
                {
                    blockBlob_delete.Delete();

                    general_fleet_attachGroup1BindingSource.RemoveCurrent();

                    this.Validate();
                    this.general_fleet_attachGroup1BindingSource.EndEdit();
           
                    this.general_fleet_attachGroup1TableAdapter.Update(aZUREDBDataSet.General_fleet_attachGroup1);



                }

                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Error");

                }

            }
            catch (StorageException)
            {
                MessageBox.Show("Please select item.");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.General_fleet_attachGroup1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.general_fleet_attachGroup1TableAdapter.Fill(this.aZUREDBDataSet.General_fleet_attachGroup1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.General_Fleet_information' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.general_Fleet_informationTableAdapter.Fill(this.aZUREDBDataSet.General_Fleet_information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.general_Fleet_informationBindingSource.EndEdit();
            this.general_fleet_attachGroup1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

    }
}
