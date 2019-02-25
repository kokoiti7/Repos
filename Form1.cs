using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        DataSet ds = new DataSet();
        Form2 fm2;

        public Form1()
        {
            InitializeComponent();
            fm2 = new Form2
            {
                Owner = this
            };

        }



        public static void ClearTextBox(Control hParent)
        {
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control cControl in hParent.Controls)
            {
                // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                if (cControl.HasChildren == true)
                {
                    ClearTextBox(cControl);
                }

                // コントロールの型が TextBoxBase からの派生型の場合は Text をクリアする
                if (cControl is TextBoxBase)
                {
                    cControl.Text = string.Empty;
                }
            }
        }

        private void dataExchangeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet1.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);


          //  shipMasterTBBindingSource.Filter = string.Format("OwnerGroup= 1004");
            shipMasterTBBindingSource.Filter = "OwnerGroup= 1004";
            presentNameComboBox.DataSource = shipMasterTBBindingSource;
            //presentNameComboBox.Items.Add = "SSS";
            presentNameComboBox.DisplayMember = "PresentName";
            presentNameComboBox.ValueMember = "PresentName";



            
        }
        private void Selectchanged(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ////////
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

            MessageBox.Show("Saved");


            this.Close();



        }

        private void fillByFunadaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ship_Master_TBTableAdapter.FillByFunada(this.aZUREDBDataSet.Ship_Master_TB);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          


        }

        private void presentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void presentNameComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            //dataExchangeBindingSource.Filter = "ID = 100002";
        }

        private void presentNameComboBox_DisplayMemberChanged(object sender, EventArgs e)
        {
            //  dataExchangeBindingSource.Filter = "ShipID = 100002";
            
        }

        private void presentNameComboBox_TextChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(textBox1.Text);
           // textBox2.Text = presentNameComboBox.Text;

            // dataExchangeBindingSource.Filter = string.Format("Shipname like '{0:s}'", textBox2.Text) + "AND MonthGroup = '" + textBox1.Text + "'";

            //datachange();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          //  textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
           
        }

        private void presentNameComboBox_DropDownClosed(object sender, EventArgs e)
        {
            // MessageBox.Show(textBox1.Text);

          

            //dataExchangeBindingSource.Filter = string.Format("Shipname like '{0:s}'", textBox2.Text) + "AND MonthGroup = '" + textBox1.Text + "'";

        }

        private void datachange()
        { 
         DateTime dtToday = dateTimePicker1.Value;
         DateTime dtFDM = new DateTime(dtToday.Year, dtToday.Month, 1);

         string sdtFDM = dtFDM.ToString();

       

            dataExchangeBindingSource.Filter = string.Format("Shipname like '{0:s}'", presentNameComboBox.Text) + "AND MonthGroup = '" + dateTimePicker1.Text + "'";
            string sendshipname=string.Format("Shipname like '{0:s}'", presentNameComboBox.Text) + "AND MonthGroup = '" + dateTimePicker1.Text + "'";
        }

        private void presentNameComboBox_SelectedIndexChanged_1(object sender, EventArgs e)

        {
          


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void yobidasi(object sender, EventArgs e)
        {


        }


        public void button2_Click_1(object sender, EventArgs e)
        {

           

            dataExchangeBindingSource.Filter = string.Format("Shipname like '{0:s}'", presentNameComboBox.Text);
            

            sum2();


            
           

        }



        private void dataExchangeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }


        private void sum()
        {
            ClearTextBox(this);

            decimal goukeiUSD = 0;
            int cnt = dataExchangeDataGridView.Rows.Count;

           // MessageBox.Show(dataExchangeDataGridView.Rows.Count.ToString());
           //  MessageBox.Show(dataExchangeDataGridView.Rows[0].Cells[5].Value.ToString()); 
     

               for (int i = 0; i < cnt; i++)
               {
                　goukeiUSD += (decimal)(dataExchangeDataGridView.Rows[i].Cells[5].Value); // int.Parseが必要かも？
               }

            textBox3.Text = goukeiUSD.ToString("#,##0.00");


            decimal goukeiJPY = 0;

  

            for (int i = 0; i < cnt; i++)
            {
                goukeiJPY += (decimal)(dataExchangeDataGridView.Rows[i].Cells[6].Value); // int.Parseが必要かも？
            }

            textBox1.Text = goukeiJPY.ToString("#,##0");



            decimal goukeiGTUSD = 0;



            for (int i = 0; i < cnt; i++)
            {
                goukeiGTUSD += (decimal)(dataExchangeDataGridView.Rows[i].Cells[8].Value); // int.Parseが必要かも？
            }

            textBox2.Text = goukeiGTUSD.ToString("#,##0.00");
        }

        private void sum2()
        {

            ClearTextBox(this);

            decimal goukeiUSD = 0;
            int cnt = dataExchangeDataGridView.Rows.Count;

            // MessageBox.Show(dataExchangeDataGridView.Rows.Count.ToString());
            //  MessageBox.Show(dataExchangeDataGridView.Rows[0].Cells[5].Value.ToString()); 


            for (int i = 0; i < cnt; i++)
            {
                goukeiUSD += (decimal)(dataExchangeDataGridView.Rows[i].Cells[5].Value); // int.Parseが必要かも？
            }

            textBox6.Text = goukeiUSD.ToString("#,##0.00");


            decimal goukeiJPY = 0;



            for (int i = 0; i < cnt; i++)
            {
                goukeiJPY += (decimal)(dataExchangeDataGridView.Rows[i].Cells[6].Value); // int.Parseが必要かも？
            }

            textBox5.Text = goukeiJPY.ToString("#,##0");



            decimal goukeiGTUSD = 0;



            for (int i = 0; i < cnt; i++)
            {
                goukeiGTUSD += (decimal)(dataExchangeDataGridView.Rows[i].Cells[8].Value); // int.Parseが必要かも？
            }

            textBox4.Text = goukeiGTUSD.ToString("#,##0.00");
        }

        private void sum3()
        {

            ClearTextBox(this);

            decimal goukeiUSD = 0;
            int cnt = dataExchangeDataGridView.Rows.Count;

            // MessageBox.Show(dataExchangeDataGridView.Rows.Count.ToString());
            //  MessageBox.Show(dataExchangeDataGridView.Rows[0].Cells[5].Value.ToString()); 


            for (int i = 0; i < cnt; i++)
            {
                goukeiUSD += (decimal)(dataExchangeDataGridView.Rows[i].Cells[5].Value); // int.Parseが必要かも？
            }

            textBox7.Text = goukeiUSD.ToString("#,##0.00");


            decimal goukeiJPY = 0;



            for (int i = 0; i < cnt; i++)
            {
                goukeiJPY += (decimal)(dataExchangeDataGridView.Rows[i].Cells[6].Value); // int.Parseが必要かも？
            }

            textBox8.Text = goukeiJPY.ToString("#,##0");



            decimal goukeiGTUSD = 0;



            for (int i = 0; i < cnt; i++)
            {
                goukeiGTUSD += (decimal)(dataExchangeDataGridView.Rows[i].Cells[8].Value); // int.Parseが必要かも？
            }

            textBox9.Text = goukeiGTUSD.ToString("#,##0.00");
        }












        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataExchangeBindingSource.Filter = "MonthGroup = '" + dateTimePicker1.Text + "'";

            sum();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            datachange();
            sum3();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            MessageBox.Show("保存しました");

            Form2 frm2 = new Form2();

            frm2.shipnamefromform1 = presentNameComboBox.Text;

            frm2.Owner = this; ///現在の親フォームを指定する

            frm2.Show();

            
        }

        


        private void button6_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet1.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }




}
