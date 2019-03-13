using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Fleet_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void general_Fleet_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.general_Fleet_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.General_Fleet_information' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.general_Fleet_informationTableAdapter.Fill(this.aZUREDBDataSet.General_Fleet_information);
            general_Fleet_informationDataGridView.Sort(general_Fleet_informationDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.general_Fleet_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.general_Fleet_informationTableAdapter.Fill(this.aZUREDBDataSet.General_Fleet_information);
        }
    }
}
