using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Form1 : Form
    {
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

        }

        private void cOMPANY_MASTERDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void cOMPANY_MEMBERDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.cOMPANY_MEMBERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MEMBER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MEMBERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MEMBER);
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MASTER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MASTERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MASTER);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MEMBER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MEMBERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MEMBER);
            // TODO: このコード行はデータを 'aZUREDBDataSet.COMPANY_MASTER' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.cOMPANY_MASTERTableAdapter.Fill(this.aZUREDBDataSet.COMPANY_MASTER);
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            this.Validate();
            this.cOMPANY_MASTERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
        }
    }
}
