﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testuser
{
    public partial class UserControl1 : UserControl
    {
        public string Shipnamestring;
        public string Monthstring;

        public UserControl1()
        {
            InitializeComponent();

            this.dataExchange_feeTableAdapter1.Fill(aZUREDBDataSet1.DataExchange_fee);

            DateTime dtToday = DateTime.Today;

            DateTime dateTimeFirstDay = new DateTime(dtToday.Year, dtToday.Month, 1);

            string firstday = dateTimeFirstDay.ToString();

            string firstdayrem = firstday.Remove(10, 8);

            MonthTextBox.Text = firstdayrem;

            dataExchange_feeBindingSource.RemoveFilter();
        }

        public void Sorting()
        {
            //datachenagebindingsorceをソートして日付降順

            //dataExchange_feeBindingSource.Sort = "MonthGroup"; //test
            //バインディングソースをフィルターかけて船名かつデータピッカーで選んだ日付をstringに変換

             dataExchange_feeBindingSource.Filter = string.Format("Shipname like '{0:s}'", ShipcomboBox.Text) +"AND MonthGroup = '" + MonthTextBox.Text + "'";

        }

        private void dataExchange_feeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Sorting();

        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Parse(MonthTextBox.Text);
            DateTime dtadd = dt.AddDays(35);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる０から１０番目そのあと８文字すべて
            string dtrem = dtadd2.ToString().Remove(10, 8);
            MonthTextBox.Text = dtrem;
            Sorting();

        }

        private void RemoveFilterbutton_Click(object sender, EventArgs e)
        {
            dataExchange_feeBindingSource.RemoveFilter();
        }

        private void ShipcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            dataExchange_feeBindingSource.Filter = string.Format("Shipname like '{0:s}'", ShipcomboBox.Text) + "AND MonthGroup = '" + MonthTextBox.Text + "'";
        }

        private void removeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataExchange_feeBindingSource.RemoveFilter();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
