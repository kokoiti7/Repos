using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class allviewgrid : Form
    {
        public allviewgrid()
        {
            InitializeComponent();
        }

        private void allviewgrid_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.NewSelectCommand' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.newSelectCommandTableAdapter.Fill(this.aZUREDBDataSet.NewSelectCommand);

        }


    }
}
