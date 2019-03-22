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
    public partial class Form1 : Form
    {

        public string Shipnamestring;
        public string Monthstring;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllFill();

            UserControl2 UserControl2 = new UserControl2();
            UserControl2.Sorting();

            datagirdfee.Visible = true;
            datacomentgird.Dock = DockStyle.Fill;

            dataexchange.Visible = false;
            datacomentgird.Visible = false;


        }

        public void AllFill()
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
        }

        private void DataExchange_Comment_Click(object sender, EventArgs e)
        {
            datacomentgird.Visible = true;
            datacomentgird.Dock = DockStyle.Fill;

            dataexchange.Visible = false;
            datagirdfee.Visible = false;
        }

        private void DataExchange_feeButton_Click(object sender, EventArgs e)
        {
            datagirdfee.Visible = true;
            datagirdfee.Dock = DockStyle.Fill;

            datacomentgird.Visible = false;
            dataexchange.Visible = false;
        }

        private void DataExchangeButton_Click(object sender, EventArgs e)
        {
            dataexchange.Visible = true;
            dataexchange.Dock = DockStyle.Fill;

            datagirdfee.Visible = false;
            datacomentgird.Visible = false;
        }

        private void AllDataGridViewShowbutton_Click(object sender, EventArgs e)
        {
            AllGridView AllGridView = new AllGridView();
            AllGridView.Show();

        }

        private void CommentRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataExchange_CommentBindingSource.RemoveCurrent();
                this.dataExchange_CommentBindingSource.EndEdit();
                this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet.DataExchange_Comment);
                MessageBox.Show("Deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("NotSelectedCell");
            }
        }

        private void CommentAdd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchange_CommentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet.DataExchange_Comment);
        }

        private void SelectedRemmoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataExchangeBindingSource.RemoveFilter();
            dataExchange_feeBindingSource.RemoveFilter();
            
        }


   

    }
}
