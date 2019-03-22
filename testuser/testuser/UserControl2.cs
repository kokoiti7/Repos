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
    public partial class UserControl2 : UserControl
    {
        

        public UserControl2()
        {
            InitializeComponent();
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);

      
        }

        private void dataExchangeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        public void Sorting()
        {
            Form1 Form1 =new Form1();
            //datachenagebindingsorceをソートして日付降順
            dataExchangeBindingSource.Sort = "MonthGroup";
       
            //バインディングソースをフィルターかけて船名かつデータピッカーで選んだ日付をstringに変換
            dataExchangeBindingSource.Filter = string.Format("Shipname like '{0:s}'", Form1.ShipcomboBox.Text) + "AND MonthGroup = '" + Form1.MonthTextBox.Text + "'";
           
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
