using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewListItem
{
    public partial class AllView : Form
    {
        public AllView()
        {
            InitializeComponent();
        }

        private void AllView_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataTable1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataTable1TableAdapter.Fill(this.aZUREDBDataSet.DataTable1);

        }

        private void dataTable1DataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form Form1 = new Form1();

        }
    }
}
