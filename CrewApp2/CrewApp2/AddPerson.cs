using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewApp2
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

            crew_MasterBindingSource.AddNew();

        }

        private void AddPersonName_Click(object sender, EventArgs e)
        {

            MessageBox.Show(crew_MasterDataGridView[1, 0].Value.ToString());

            for (var i = 0;i < crew_MasterDataGridView.Rows.Count;i++)
            {
                if (topeverIDTextBox.Text == crew_MasterDataGridView[1, i].Value.ToString())
                {
                    MessageBox.Show("RetryEnterNumber");
                    break;
                }

            }

            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.crew_MasterTableAdapter.Update(aZUREDBDataSet.Crew_Master);
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

            this.Close();
        }
    }
}
