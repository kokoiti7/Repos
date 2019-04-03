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

namespace ShipInvoice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.quotation_DocumentBindingSource.RemoveFilter();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // TODO: このコード行はデータを 'aZUREDBDataSet2.Quotation_Documents' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentsTableAdapter1.Fill(this.aZUREDBDataSet1.Quotation_Documents);
            // TODO: このコード行はデータを 'aZUREDBDataSet2.Quotation_Document' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentTableAdapter1.Fill(this.aZUREDBDataSet1.Quotation_Document);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter1.Fill(this.aZUREDBDataSet1.Ship_Master_TB);



        }

        public void BlobPropertie()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.Accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

        }

        private void DocumentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuotationUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.Accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            DialogResult dr = OpenFileDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                var filename = Path.GetFileName(OpenFileDialog.FileName);

                try
                {
                    if (quotation_DocumentsDataGridView.CurrentCell == null)
                    {
                        MessageBox.Show("新規行を選択してください");
                        return;
                    }

                    this.quotation_DocumentsDataGridView[2, quotation_DocumentsDataGridView.CurrentRow.Index].Value = quotation_DocumentDataGridView[0, quotation_DocumentDataGridView.CurrentRow.Index].Value + "\\" + filename;

                    this.quotation_DocumentDataGridView[4, quotation_DocumentDataGridView.CurrentRow.Index].Value = filename;

                    var IDname = this.quotation_DocumentDataGridView[1, quotation_DocumentDataGridView.CurrentRow.Index].Value;

                    CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(IDname + "\\" + filename);

                    using (var fileStream = System.IO.File.OpenRead((OpenFileDialog.FileName)))
                    {
                        blockBlob_upload.UploadFromStream(fileStream);
                        MessageBox.Show("Uploadsuccess!!");

                        this.Validate();
                        this.quotation_DocumentBindingSource.EndEdit();
                        this.fKQuotationDocumentsQuotationDocumentsBindingSource1.EndEdit();
                        this.quotation_DocumentTableAdapter1.Update(aZUREDBDataSet1.Quotation_Document);
                        this.quotation_DocumentsTableAdapter1.Update(aZUREDBDataSet1.Quotation_Documents);


                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("例外");

                    if (quotation_DocumentsDataGridView.CurrentRow==null)
                    {
                        quotation_DocumentsDataGridView.CurrentCell = quotation_DocumentsDataGridView[0,0];
                    }
                    this.quotation_DocumentsDataGridView[2, quotation_DocumentsDataGridView.CurrentRow.Index].Value = quotation_DocumentDataGridView[0, quotation_DocumentDataGridView.CurrentRow.Index].Value + "\\" + filename;

                    this.quotation_DocumentDataGridView[4, quotation_DocumentDataGridView.CurrentRow.Index].Value = filename;

                }

            }

        }

        private void PurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.quotation_DocumentsTableAdapter1.Fill(this.aZUREDBDataSet1.Quotation_Documents);
           this.quotation_DocumentTableAdapter1.Fill(this.aZUREDBDataSet1.Quotation_Document);
        }

        private void RemoveFilterButton_Click(object sender, EventArgs e)
        {
            this.quotation_DocumentBindingSource.RemoveFilter();
        }

        private void QuotationIDCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               this.quotation_DocumentBindingSource.Filter = string.Format(" ID = {0:d}  ", Convert.ToInt32(QuotationIDCombobox.Text));
            }
            catch (Exception ex)
            {

            }
       
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotation_DocumentBindingSource.EndEdit();
            this.fKQuotationDocumentsQuotationDocumentsBindingSource1.EndEdit();
            this.quotation_DocumentTableAdapter1.Update(aZUREDBDataSet1.Quotation_Document);
            this.quotation_DocumentsTableAdapter1.Update(aZUREDBDataSet1.Quotation_Documents);
        }

        private void Quotation_DocumentsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.Accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            CloudBlockBlob blob = container.GetBlockBlobReference(quotation_DocumentsDataGridView.CurrentRow.Cells[2].Value.ToString());

            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

            Process.Start(blob.Uri + sasBlobToken);
        }

        private void Quotation_DocumentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fKQuotationDocumentsQuotationDocumentsBindingSource1.RemoveCurrent();
                this.fKQuotationDocumentsQuotationDocumentsBindingSource1.EndEdit();
                this.quotation_DocumentsTableAdapter1.Update(this.aZUREDBDataSet1.Quotation_Documents);
                MessageBox.Show("Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("消す項目がありません");
            }

        }

        private void Quotation_DocumentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
