using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Drawing_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.drawing_MasterTableAdapter.Fill(this.aZUREDBDataSet.Drawing_Master);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Drawing_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.drawing_MasterTableAdapter.Fill(this.aZUREDBDataSet.Drawing_Master);

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.drawing_MasterTableAdapter.Fill(this.aZUREDBDataSet.Drawing_Master);
        }

        private void RemoveFilterButton_Click(object sender, EventArgs e)
        {
            this.drawing_MasterBindingSource.RemoveFilter();
        }

        private void DocumentStripMenuItem_Click(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.Accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult dr = ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

               var  filename = Path.GetFileName(ofd.FileName);

                try
                {
                    if (drawing_MasterDataGridView.CurrentCell == null)
                    {
                        MessageBox.Show("新規行を選択してください");
                        return;
                    }

                    this.drawing_MasterDataGridView[2, drawing_MasterDataGridView.CurrentRow.Index].Value = drawing_MasterDataGridView[1, drawing_MasterDataGridView.CurrentRow.Index].Value + "\\" + filename;

                    this.drawing_MasterDataGridView[3, drawing_MasterDataGridView.CurrentRow.Index].Value = filename;

                    var IDname = this.drawing_MasterDataGridView[1, drawing_MasterDataGridView.CurrentRow.Index].Value;

                    CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(IDname + "\\" + filename);

                    using (var fileStream = System.IO.File.OpenRead(ofd.FileName))
                    {
                         blockBlob_upload.UploadFromStream(fileStream);
                        MessageBox.Show("Uploadsuccess!!");

                        this.Validate();
                        this.drawing_MasterBindingSource.EndEdit();
                        this.drawing_MasterTableAdapter.Update(aZUREDBDataSet.Drawing_Master);
                    }
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("例外");
                }

            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drawing_MasterBindingSource.EndEdit();
            this.drawing_MasterTableAdapter.Update(aZUREDBDataSet.Drawing_Master);
        }

        private void ShipIDCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                this.drawing_MasterBindingSource.Filter = string.Format(" ShipID = {0:d}  ", (ShipIDCombobox.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void Drawing_MasterDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.Accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            CloudBlockBlob blob = container.GetBlockBlobReference(drawing_MasterDataGridView.CurrentRow.Cells[2].Value.ToString());

            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

            Process.Start(blob.Uri + sasBlobToken);
        }


    }
}

                    
                
                
            
                
        
                
    

