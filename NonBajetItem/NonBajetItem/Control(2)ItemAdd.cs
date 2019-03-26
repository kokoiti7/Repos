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
    public partial class Control_1_ItemAdd : Form
    {
        public Control_1_ItemAdd()
        {
            InitializeComponent();
        }



        private void ItemAdd_Click(object sender, EventArgs e)
        {

            this.dataExchange_feeBindingSource.AddNew();
            this.Validate();
            this.dataExchange_feeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Control_2_ItemAdd_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);

        }
    }
}
