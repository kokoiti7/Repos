using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoCapacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lO_CapacityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lO_CapacityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.LO_Capacity' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.lO_CapacityTableAdapter.Fill(this.aZUREDBDataSet.LO_Capacity);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lO_CapacityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lO_CapacityTableAdapter.Fill(this.aZUREDBDataSet.LO_Capacity);
        }
    }
}
