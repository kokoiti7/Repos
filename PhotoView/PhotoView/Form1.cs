using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoView
{
    public partial class Form1 : Form
    {
        int rowcnt = 0;

        string dir = @"C:\Users\tech-01-adm\Desktop\Resized";

        public Form1()
        {
            InitializeComponent();
        }

        private void iMPA4thED_ItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iMPA4thED_ItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.IMPA4thED_Section' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_SectionTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Section);
            // TODO: このコード行はデータを 'aZUREDBDataSet.IMPA4thED_Item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Item);

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            rowcnt = iMPA4thED_ItemDataGridView.RowCount;



          /*  for (int i = 0; i < rowcnt - 1; i++)
            {


                iMPA4thED_ItemDataGridView.CurrentCell = iMPA4thED_ItemDataGridView[5, i];

                if (iMPA4thED_ItemDataGridView[5, i].Value.ToString() != null)
                {

                    var filenameget = Path.GetFileName(iMPA4thED_ItemDataGridView[5, i].Value.ToString());


                    var filenamecut = dir + "\\" + filenameget;


                    if (System.IO.File.Exists(filenamecut))
                    {


                        iMPA4thED_ItemDataGridView.CurrentCell = iMPA4thED_ItemDataGridView[4, 3];
                        iMPA4thED_ItemDataGridView[4, i].Value = new Bitmap(filenamecut);

                    }
                    else
                    {


                    }*/
                
            
        }

        private void iMPA4thED_SectionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //convertが重要stringにする必要があり、かつLike '%{0}%'も決まり文句
            iMPA4thED_ItemBindingSource.Filter = string.Format("convert(SECTION,'System.String') Like '%{0}%'", iMPA4thED_SectionDataGridView.CurrentCell.Value);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iMPA4thED_ItemBindingSource.EndEdit();
            this.iMPA4thED_ItemTableAdapter.Update(this.aZUREDBDataSet.IMPA4thED_Item);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Item);
            this.iMPA4thED_SectionTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Section);
        }
    }
}
