using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quotation_DocumentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotation_DocumentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Quotation_Documents' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentsTableAdapter1.Fill(this.aZUREDBDataSet1.Quotation_Documents);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Quotation_Document' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentTableAdapter1.Fill(this.aZUREDBDataSet1.Quotation_Document);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Quotation_Documents' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentsTableAdapter.Fill(this.aZUREDBDataSet.Quotation_Documents);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Quotation_Document' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentTableAdapter.Fill(this.aZUREDBDataSet.Quotation_Document);

        }
    }
}
