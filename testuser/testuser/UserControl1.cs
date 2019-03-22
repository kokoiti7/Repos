using System;
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
       

        public UserControl1()
        {
            InitializeComponent();
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
          
        }


        private void dataExchange_feeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchange_feeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        public void Sorting()
        {
            Form1 Form1 = new Form1();
            //datachenagebindingsorceをソートして日付降順
    
            dataExchange_feeBindingSource.Sort = "MonthGroup"; //test
            //バインディングソースをフィルターかけて船名かつデータピッカーで選んだ日付をstringに変換

            dataExchange_feeBindingSource.Filter = string.Format("Shipname like '{0:s}'", Form1.ShipcomboBox.Text) + "AND MonthGroup = '" + Form1.MonthTextBox.Text + "'";
        }
    }
}
