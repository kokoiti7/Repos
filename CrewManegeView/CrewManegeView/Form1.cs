using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewManegeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crew_Master1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_Master1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_Master1TableAdapter.Fill(this.aZUREDBDataSet.Crew_Master1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
          
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_Master1TableAdapter.Fill(this.aZUREDBDataSet.Crew_Master1);

        }

        private void crew_Master1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_Master1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }
    }
}
