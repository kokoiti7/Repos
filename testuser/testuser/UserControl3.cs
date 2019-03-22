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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);
        }

        private void dataExchange_CommentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchange_CommentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void AddComentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveComentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataExchange_CommentBindingSource.RemoveCurrent();
                this.dataExchange_CommentBindingSource.EndEdit();
                this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet.DataExchange_Comment);
                MessageBox.Show("Deleted");
                this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("NotSelectedCell");
            }
        }
    }
}
