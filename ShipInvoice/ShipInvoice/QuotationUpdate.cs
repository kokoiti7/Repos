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
    public partial class QuotationUpdate : Form
    {
        public QuotationUpdate()
        {
            InitializeComponent();
        }

        private void quotation_DocumentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotation_DocumentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet1);

        }

        private void QuotationUpdate_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Quotation_Documents' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentsTableAdapter.Fill(this.aZUREDBDataSet1.Quotation_Documents);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
