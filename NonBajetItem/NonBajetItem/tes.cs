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
    public partial class tes : Form
    {
        public tes()
        {
            InitializeComponent();
        }

        private void ship_Master_TBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ship_Master_TBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void tes_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);

        }
    }
}
