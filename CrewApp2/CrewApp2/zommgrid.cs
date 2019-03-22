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
    public partial class zommgrid : Form
    {
        public zommgrid()
        {
            InitializeComponent();
        }

        private void zommgrid_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_Master1TableAdapter.Fill(this.aZUREDBDataSet.Crew_Master1);

        }
    }
}
