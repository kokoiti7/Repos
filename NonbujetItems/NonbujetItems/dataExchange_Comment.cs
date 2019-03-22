using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonbujetItems
{
    public partial class dataExchange_Comment : UserControl
    {
        public dataExchange_Comment()
        {
            InitializeComponent();
        }

        private void dataExchange_CommentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchange_CommentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }
    }
}
