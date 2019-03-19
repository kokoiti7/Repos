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

        private void Crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
           // MessageBox.Show(crew_MasterBindingSource.Count.ToString());
           // MessageBox.Show(crew_MasterDataGridView.Rows.Count.ToString());


            int k = 0;

            for (var i = 0 ; i < crew_MasterBindingSource.Count - 1 ; i++)
            {

                string serchno = topeverIDTextBox.Text;

               // MessageBox.Show(crew_MasterDataGridView[1, i].Value.ToString());

                if (serchno == crew_MasterDataGridView[1, i].Value.ToString())
                {
                    k++;

                }


            }

         
            if (k == 0)
            {
                
                this.Validate();
                this.crew_MasterBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
                this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);
                this.Close();
            }
            else
            {
                MessageBox.Show("Retry input ID");
                return;
            }

        }
    }
}
