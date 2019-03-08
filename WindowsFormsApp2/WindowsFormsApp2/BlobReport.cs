using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace WindowsFormsApp2
{
    public partial class BlobReport : UserControl
    {
        public BlobReport()
        {
            InitializeComponent();

            bLOBreportTableAdapter.Fill(aZUREDBDataSet2.BLOBreport);
        }

        private void Upload_Click(object sender, EventArgs e)
        {
           

        } 

            
        

        private void Download_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Upload_Click_1(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            OpenFileDialog ofd = new OpenFileDialog
            {
                //複数のファイルを選択できるようにするXX
                Multiselect = false
            };

            try
            {

                //ダイアログを表示する
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                    foreach (string fn in ofd.FileNames)
                    {

                        var fileStream = System.IO.File.OpenRead(fn);
                        var filenamefn = System.IO.Path.GetFileName(fn);

                        bLOBreportBindingSource.AddNew();
                        filenameTextBox.Text = filenamefn;
                        CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
                        blockBlob_upload.UploadFromStream(fileStream);

                        // save 
                        this.Validate();
                        this.bLOBreportBindingSource.EndEdit();
                        this.bLOBreportTableAdapter.Update(aZUREDBDataSet2.BLOBreport);


                    }
                }
            }

            catch (NoNullAllowedException)
            {

            }
        }
    }
}
