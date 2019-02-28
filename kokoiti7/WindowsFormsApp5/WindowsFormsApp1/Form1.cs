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
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string URI;
        CloudBlockBlob blockBlob_upload;
        CloudBlobContainer bakupcontainer;
        public string filenamelist;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");
            bakupcontainer = container;


            var backupBlobClient = storageAccount.CreateCloudBlobClient();
            var backupContainer = backupBlobClient.GetContainerReference("temmfile");

            // useFlatBlobListing is true to ensure loading all files in
            // virtual blob sub-folders as a plain list
            var list = backupContainer.ListBlobs(useFlatBlobListing: true);
            var listOfFileNames = new List<string>();



            var blobs = backupContainer.ListBlobs().OfType<CloudBlockBlob>().ToList();


            foreach (var blob in blobs)
            {
                var blobFileName = blob.Uri.Segments.Last();

                listOfFileNames.Add(blobFileName);

            }

            listBox1.DataSource = listOfFileNames;

            URI = GetBlobSasUri(container);

            Properties.Settings.Default.URL = URI;

           


        }



        static string GetBlobSasUri(CloudBlobContainer container)
        {
            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference("");

            //Get a reference to a blob within the container.
        

           // blob.Exists();

            
            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);
           
            //Return the URI string for the container, including the SAS token.
            return blob.Uri + sasBlobToken;
           
        }






        private void button3_Click(object sender, EventArgs e)
        {

            // To create the account SAS, you need to use your shared key credentials. Modify for your account.
            const string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=temmstorage;AccountKey=zaMKR6/YhEMlmhpUu8TcW/1qas5M3GdZDfcoLQJ3LTC3EaLn9GRfHGEJ56/C+D+rWhl5rkxsgpZv5f+Ivkn/sA==";
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConnectionString);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference("test2");

            //blockBlob_upload = container;

            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference("gg.xlsx");

            //Set the expiry time and permissions for the blob.
            //In this case, the start time is specified as a few minutes in the past, to mitigate clock skew.
            //The shared access signature will be valid immediately.
            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

            //Return the URI string for the container, including the SAS token.
            MessageBox.Show(blob.Uri + sasBlobToken);
            //webBrowser1.Navigate(new Uri(blob.Uri + sasBlobToken));
           
            Process.Start(blob.Uri + sasBlobToken);

        }

        private void button4_Click(object sender, EventArgs e)
        {


            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");
            

            OpenFileDialog ofd = new OpenFileDialog();

            //複数のファイルを選択できるようにする
            ofd.Multiselect = true;


            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                foreach (string fn in ofd.FileNames)
                {
                    var fileStream = System.IO.File.OpenRead(fn);
                    var filenamefn = System.IO.Path.GetFileName(fn);
                    CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
                    blockBlob_upload.UploadFromStream(fileStream);
                }
            }

            else
            {
               
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {


            //CloudBlockBlob blockBlob_download = bakupcontainer.GetBlockBlobReference(listBox1.SelectedItem.ToString());

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "すべてのファイル(*.*) | *.* ";
            sfd.FileName = listBox1.SelectedItem.ToString();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                var filenamesn = System.IO.Path.GetFileName(listBox1.SelectedItem.ToString());
                CloudBlockBlob blockBlob_download = bakupcontainer.GetBlockBlobReference(filenamesn);
                blockBlob_download.DownloadToFile(stream.ToString(), System.IO.FileMode.Create);

            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");
            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");

            var listitem = listBox1.SelectedItem;

            // var blobs = container.GetBlockBlobReference(listitem.ToString());

            CloudBlockBlob blockBlob_delete = container.GetBlockBlobReference(listitem.ToString());

            DialogResult result = MessageBox.Show("削除しますか？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //何が選択されたか調べる

            if (result == DialogResult.Yes)
            {
                blockBlob_delete.Delete();


                var list = container.ListBlobs(useFlatBlobListing: true);
                var listOfFileNames = new List<string>();



                var blobs = container.ListBlobs().OfType<CloudBlockBlob>().ToList();


                foreach (var blob in blobs)
                {
                    var blobFileName = blob.Uri.Segments.Last();

                    listOfFileNames.Add(blobFileName);

                }

                listBox1.DataSource = listOfFileNames;
            }

            else if (result == DialogResult.No)
            {


            }
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filenamelist= listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // To create the account SAS, you need to use your shared key credentials. Modify for your account.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference("temmfile");

            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference(listBox1.SelectedItem.ToString());

            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);


            Process.Start(blob.Uri + sasBlobToken);
        }
    }
    
}
