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

namespace Service_Due
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_attachTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_attach);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Validity_Items' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_ItemsTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Items);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Master);

            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_attachTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_attach);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Items' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_ItemsTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Items);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Master);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Master);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。


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

            validity_attachBindingSource1.AddNew();

            fileNameTextBox.Text = filenamefn;

            CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
            blockBlob_upload.UploadFromStream(fileStream);

            // save 
            this.Validate();
            this.validity_attachBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aZUREDBDataSet1);
            // this.validity_attachTableAdapter.Fill(this.aZUREDBDataSet.Validity_attach);

        }

        private void FileNameListBox1_DragEnter_1(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }



        private void Update_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.validity_attachBindingSource1.EndEdit();
            this.validity_ItemsBindingSource1.EndEdit();
            this.validity_MasterBindingSource1.EndEdit();
            this.validity_MasterTableAdapter1.Update(this.aZUREDBDataSet1.Validity_Master);
            this.validity_ItemsTableAdapter1.Update(this.aZUREDBDataSet1.Validity_Items);
            this.validity_attachTableAdapter1.Update(this.aZUREDBDataSet1.Validity_attach);
        }



        private void Refresh_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_attachTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_attach);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Validity_Items' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_ItemsTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Items);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Master);

            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_attachTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_attach);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Items' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_ItemsTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Items);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Master);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.validity_MasterTableAdapter1.Fill(this.aZUREDBDataSet1.Validity_Master);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        }

        private void validity_MasterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
