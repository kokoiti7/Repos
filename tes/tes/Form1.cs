using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Validity_attach' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

            // TODO: このコード行はデータを 'aZUREDBDataSet.DataTable1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataTable1TableAdapter.Fill(this.aZUREDBDataSet.DataTable1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataTable1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }
    }
}
