using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyMasterInput
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

   
        public Form1()
        {
            InitializeComponent();
        }

        private void cOMPANY_MASTERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MEMBER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MEMBERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MEMBER);
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MASTER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MASTERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MASTER);
            cOMPANY_MASTERDataGridView.Sort(cOMPANY_MASTERDataGridView.Columns[1], ListSortDirection.Ascending);

            //オートコンプリートモードの設定
            Engname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //コンボボックスのアイテムをオートコンプリートの選択候補とする
            Engname.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MEMBER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MEMBERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MEMBER);
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MASTER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MASTERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MASTER);

            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void Delete_Click(object sender, EventArgs e)
        {        
            cOMPANY_MASTERBindingSource.RemoveCurrent();
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }
    }
}
