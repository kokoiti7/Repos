using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBajetItem
{
    public partial class AllGridView : Form
    {
        public AllGridView()
        {
            InitializeComponent();
        }

        private void dataExchangeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void AllGridView_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);

        }
    }
}
