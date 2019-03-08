using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imagetestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagetestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Imagetest' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.imagetestTableAdapter.Fill(this.aZUREDBDataSet.Imagetest);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    var filedire= System.IO.Path.GetDirectoryName(ofd.FileName);
                    var filenamedire = filedire +'\\'+ filenamefn;

                    imagetestDataGridView.Rows[0].Cells[0].Value = new Bitmap(filenamedire);


                    
                    // save 
                    this.Validate();
                    this.imagetestBindingSource.EndEdit();
                    this.imagetestTableAdapter.Update(this.aZUREDBDataSet.Imagetest);
                }
            }
        }
    }
}
