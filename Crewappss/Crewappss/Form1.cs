using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crewappss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Application' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_ApplicationTableAdapter.Fill(this.aZUREDBDataSet.Crew_Application);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_ConfidencialReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_ConfidencialReportTableAdapter.Fill(this.aZUREDBDataSet.Crew_ConfidencialReport);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

        }
    }
}
