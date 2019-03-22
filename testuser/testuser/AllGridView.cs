using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testuser
{
    public partial class AllGridView : Form
    {
        public AllGridView()
        {
            InitializeComponent();
            this.dataExchange_CommentTableAdapter.Fill(aZUREDBDataSet.DataExchange_Comment);
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee1);
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
        }

        private void AllGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
