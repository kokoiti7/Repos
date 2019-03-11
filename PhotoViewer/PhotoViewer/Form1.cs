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
namespace PhotoViewer
{
    public partial class Form1 : Form
    {
        int rowcnt = 0;
        string dir = @"C:\Users\tech-01-adm\Desktop\Resized";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.IMPA4thED_Item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Item);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Imagetest' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            // TODO: このコード行はデータを 'aZUREDBDataSet11.IMPA4thED_Section' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_SectionTableAdapter1.Fill(this.aZUREDBDataSet11.IMPA4thED_Section);
            // TODO: このコード行はデータを 'aZUREDBDataSet.IMPA4thED_Item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet.IMPA4thED_Item);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.IMPA4thED_Item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet1.IMPA4thED_Item);

        }


        private void Upload_Click_1(object sender, EventArgs e)
        {
            //まわす回数


            rowcnt = iMPA4thED_ItemDataGridView.RowCount;



            for (int i = 0; i < rowcnt - 1; i++)
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


                    }
                }

            }


            this.Validate();
             this.iMPA4thED_ItemBindingSource.EndEdit();
             this.iMPA4thED_ItemTableAdapter.Update(this.aZUREDBDataSet.IMPA4thED_Item);
        }
    }
}
