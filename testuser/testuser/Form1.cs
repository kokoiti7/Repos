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
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee1);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);

            datacomentgird.Visible = true;
            datacomentgird.Dock = DockStyle.Fill;

            dataexchange.Visible = false;
            datagirdfee.Visible = false;
            DateTime dtToday = DateTime.Today;

            DateTime dateTimeFirstDay = new DateTime(dtToday.Year, dtToday.Month, 1);

            string firstday = dateTimeFirstDay.ToString();

            string firstdayrem = firstday.Remove(10, 8);

            MonthTextBox.Text = firstdayrem;
        }

        public void Sorting()
        {
            //datachenagebindingsorceをソートして日付降順
            dataExchangeBindingSource.Sort = "MonthGroup";
            dataExchange_feeBindingSource.Sort = "MonthGroup"; //test
            //バインディングソースをフィルターかけて船名かつデータピッカーで選んだ日付をstringに変換
            dataExchangeBindingSource.Filter = string.Format("Shipname like '{0:s}'", ShipcomboBox.Text) + "AND MonthGroup = '" + MonthTextBox.Text + "'";
            dataExchange_feeBindingSource.Filter = string.Format("Shipname like '{0:s}'", ShipcomboBox.Text) + "AND MonthGroup = '" + MonthTextBox.Text + "'";
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

        }

        private void CommentAdd_Click(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SelectedRemmoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataExchangeBindingSource.RemoveFilter();
            dataExchange_feeBindingSource.RemoveFilter();
            
        }

        private void BackMonthButton_Click(object sender, EventArgs e)
        {

            //textboxをDatetimeに変換してdatetime型の変数にADDして年月、月の初めを設定している
            DateTime dt = System.DateTime.Parse(MonthTextBox.Text);
            DateTime dtadd = dt.AddDays(-3);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる
            string dtrem = dtadd2.ToString().Remove(10, 8);
            MonthTextBox.Text = dtrem;

            UserControl1 UserControl1 = new UserControl1();
            UserControl2 UserControl2 = new UserControl2();

            UserControl1.Sorting();
            UserControl2.Sorting();


        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Parse(MonthTextBox.Text);
            DateTime dtadd = dt.AddDays(35);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる０から１０番目そのあと８文字すべて
            string dtrem = dtadd2.ToString().Remove(10, 8);
            MonthTextBox.Text = dtrem;

            UserControl1 UserControl1 = new UserControl1();
            UserControl2 UserControl2 = new UserControl2();

            UserControl1.Sorting();
            UserControl2.Sorting();
        }

        private void ComentcontextMenu_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
