using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonBajetItem
{
    public partial class CommentAdd : Form
    {
        public CommentAdd()
        {
            InitializeComponent();
        }

        private void dataExchange_CommentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchange_CommentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void CommentAdd_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);

        }

        private void AddComentButton_Click(object sender, EventArgs e)
        {
            this.dataExchange_CommentBindingSource.AddNew();

            this.Validate();
            this.dataExchange_CommentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }
    }
}
