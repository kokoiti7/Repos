using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CompanyMember : UserControl
    {
        public CompanyMember()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //複数のファイルを選択できるようにするXX
            ofd.Multiselect = false;



            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
   
                foreach (string fn in ofd.FileNames)
                {
                    var fileStream = System.IO.File.OpenRead(fn);
                    var filenamefn = System.IO.Path.GetFileName(fn);
                    var filedire = System.IO.Path.GetDirectoryName(ofd.FileName);
                    var filenamedire = filedire + '\\' + filenamefn;

                    imagetestDataGridView.Rows[0].Cells[1].Value = new Bitmap(filenamedire);



                    // save 
                    this.Validate();
                    this.imagetestBindingSource.EndEdit();
                    this.imagetestTableAdapter.Update(this.aZUREDBDataSet1.Imagetest);
                }
            }
        }

        private void imagetestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagetestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet1);

        }
    }
}
