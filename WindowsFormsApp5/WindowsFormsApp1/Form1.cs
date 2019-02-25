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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string URI;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Parse the connection string and return a reference to the storage account.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            //Create the blob client object.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //Get a reference to a container to use for the sample code, and create it if it does not exist.
            CloudBlobContainer container = blobClient.GetContainerReference("test");
            container.CreateIfNotExists();

            URI = GetBlobSasUri(container);

            Properties.Settings.Default.URL = URI;

            textBox1.Text = Properties.Settings.Default.URL;



        }



        static string GetBlobSasUri(CloudBlobContainer container)
        {
            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference("777.pdf");

            //Upload text to the blob. If the blob does not yet exist, it will be created.
            //If the blob does exist, its existing content will be overwritten.
            string blobContent = "This blob will be accessible to clients via a shared access signature (SAS).";
            blob.UploadText(blobContent);

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
            return blob.Uri + sasBlobToken;
        }




        private void textBox1_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(new Uri(URI));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webBrowser2.Navigate("https://temmstorage.blob.core.windows.net/test/777.pdf?sv=2018-03-28&sr=b&sig=tYrn9xi5atbOaBpeI4%2FzUrS1nGLCy5GI1attQrylExM%3D&st=2019-02-25T08%3A04%3A41Z&se=2019-02-26T08%3A09%3A41Z&sp=rw");
        }
    }
}
