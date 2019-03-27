using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aa
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
            // TODO: このコード行はデータを 'aZUREDBDataSet.Quoatation_FileName1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quoatation_FileName1TableAdapter.Fill(this.aZUREDBDataSet.Quoatation_FileName1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Quoatation_FileName1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quoatation_FileName1TableAdapter.Fill(this.aZUREDBDataSet.Quoatation_FileName1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Quoatation_FileName' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quoatation_FileNameTableAdapter.Fill(this.aZUREDBDataSet.Quoatation_FileName);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Quotation_Document' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.quotation_DocumentTableAdapter.Fill(this.aZUREDBDataSet.Quotation_Document);

        }
    }
}
