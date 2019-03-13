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



        private void iMPA4thED_SectionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //convertが重要stringにする必要があり、かつLike '%{0}%'も決まり文句
            iMPA4thED_ItemBindingSource.Filter = string.Format("convert(SECTION,'System.String') Like '%{0}%'", iMPA4thED_SectionDataGridView.CurrentCell.Value);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            rowcnt = iMPA4thED_ItemDataGridView.RowCount;

            //ボタンを押したらprntscreen？をしたやつを入れるnew bitmap 3/12

            OpenFileDialog ofd = new OpenFileDialog();

            //複数のファイルを選択できるようにするXX
            ofd.Multiselect = false;


            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                foreach (string fn in ofd.FileNames)
                {

                    var fileStream = System.IO.File.OpenRead(fn);
                    var filenamefn = System.IO.Path.GetFileName(fn);
                    
                    iMPA4thED_ItemBindingSource.AddNew();
    
                    this.Validate();
                    this.iMPA4thED_ItemBindingSource.EndEdit();
                    this.iMPA4thED_ItemTableAdapter.Update(this.aZUREDBDataSet.IMPA4thED_Item);
                }
            }
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Item);
            this.iMPA4thED_SectionTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Section);
        }


    }
}
