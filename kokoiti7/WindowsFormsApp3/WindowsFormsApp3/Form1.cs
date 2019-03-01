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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void dataExchangeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);

            
            editdateTimeDate.Text = DateTime.Today.ToString();

            //Textboxにロード時あらかじめ月の初めを表示させかつその月の１日目である
            DateTime dtToday = DateTime.Today;

            DateTime dateTimeFirstDay = new DateTime(dtToday.Year, dtToday.Month, 1);

            string firstday = dateTimeFirstDay.ToString();

            string firstdayrem = firstday.Remove(10,8);

            textBox1.Text = firstdayrem;

        }



        public void button1_Click_1(object sender, EventArgs e)
        {
          
            decimal v1 = 0;
            decimal v2 = 0;

            
            for (int i = 0; i < dataExchange_feeDataGridView.Rows.Count;i++)
            {

                try
                {
                    //forでまわしてデシマルのv1,v2に対してグリッドロウのi番目つまり行をみていっている
                    v1 = (decimal)dataExchange_feeDataGridView.Rows[i].Cells[4].Value;
                    v2 = (decimal)dataExchange_feeDataGridView.Rows[i].Cells[5].Value;

                    //feeのほうのグリッドビュアーの列(v1 + v2).ToString()1番目にv1v2を足してtost

                    dataExchange_feeDataGridView[6, i].Value = v1 + v2;
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("NotTotalValue");
                }
                catch(InvalidCastException)
                {
                    MessageBox.Show("NotTotalValue");
                }
                

            }
                
            
        }

       






        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataExchange_feeBindingSource1.RemoveCurrent();
                this.dataExchange_feeBindingSource1.EndEdit();
                this.dataExchange_feeTableAdapter.Update(this.aZUREDBDataSet.DataExchange_fee);
                MessageBox.Show("deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Notdeletedselect");
            }
           

        }



        private void button5_Click(object sender, EventArgs e)
        {
            //textboxをDatetimeに変換してdatetime型の変数にADDして年月、月の初めを設定している
            DateTime dt = System.DateTime.Parse(textBox1.Text);
            DateTime dtadd = dt.AddDays(-3);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる
            string dtrem = dtadd2.ToString().Remove(10, 8);
            textBox1.Text = dtrem;

        }


        private void button4_Click(object sender, EventArgs e)
        {

            //バインディングソースをフィルターかけて船名かつデータピッカーで選んだ日付をstringに変換
            dataExchangeBindingSource2.Filter = string.Format("Shipname like '{0:s}'", comboBox1.Text) + "AND MonthGroup = '" + textBox1.Text + "'";

            dataExchange_feeBindingSource1.Filter = string.Format("Shipname like '{0:s}'", comboBox1.Text) + "AND MonthGroup = '" + textBox1.Text + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataExchangeBindingSource2.RemoveFilter();
            dataExchange_feeBindingSource1.RemoveFilter();
        }







        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                this.dataExchange_CommentBindingSource1.RemoveCurrent();
                this.dataExchange_CommentBindingSource1.EndEdit();
                this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet1.DataExchange_Comment);
                MessageBox.Show("Deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("NotSelectedCell");
            }

        }


        private void button9_Click(object sender, EventArgs e)
        {
           
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
          

        }



        private void button10_Click(object sender, EventArgs e)
        {
            dataExchange_CommentBindingSource1.MoveNext();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataExchange_CommentBindingSource1.MovePrevious();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                dataExchangeBindingSource2.RemoveCurrent();
                this.dataExchangeBindingSource2.EndEdit();
                this.dataExchangeTableAdapter.Update(this.aZUREDBDataSet.DataExchange);
                MessageBox.Show("deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Notdeletedselect");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        public void button13_Click(object sender, EventArgs e)
        {
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
        }




        //かなり重要こいつをform3で呼び出してリフレッシュさせる。つまりform3を閉じた後に自動的にgridviewを更新させる
        public void DgvRefresh()
        {
            this.dataExchange_CommentDataGridView.Refresh();
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // ↓これはこのメソッドが機能したことを確認するため
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.dataExchange_feeBindingSourc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            //割と重要Form2を呼んでかつメソッドに対してform1のcombobox,textboxを代入してform2が起動時にロードできるようにしている


            Form2 frm2 = new Form2(this);

            //変数１回介さないと空白が入るので面倒
            frm2.month = DateTime.Parse(textBox1.Text);
            frm2.pay = DateTime.Parse(textBox1.Text);
            frm2.shipname = comboBox1.Text;
            frm2.Show();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);

            this.Validate();
            this.dataExchange_CommentBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet1.DataExchange_Comment);

            dataExchange_CommentDataGridView.Refresh();
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            frm3.name = textBox2.Text;
            frm3.date = editdateTimeDate.Text;
            frm3.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
