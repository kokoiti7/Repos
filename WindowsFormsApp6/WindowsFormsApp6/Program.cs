using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;


namespace WindowsFormsApp6
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


       
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("images");

            //もし無かったら作る
            //container.CreateIfNotExists();

            //upload

            //アップロード後のファイル名を指定（無くてよい）
            CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference("aaa.txt");

            //アップロード処理
            //アップロードしたいローカルのファイルを指定
            using (var fileStream = System.IO.File.OpenRead(@"C:\Users\tech-01-adm\Desktop\aaa.txt"))
            {
                blockBlob_upload.UploadFromStream(fileStream);
            }

            //download

            //ダウンロードするファイル名を指定
            CloudBlockBlob blockBlob_download = container.GetBlockBlobReference("ccc.jpg");

            //ダウンロード処理
            //ダウンロード後のパスとファイル名を指定。
            blockBlob_download.DownloadToFile(@"C:\Users\tech-01-adm\Desktop\ddd.txt", System.IO.FileMode.CreateNew);

            //削除
            //blockBlob_download.Delete();
        }
    }
}
