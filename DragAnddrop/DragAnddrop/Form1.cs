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

namespace DragAnddrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Mailtranslated_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
        
  
        }

        private void Mailtranslated_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                var fileStream = System.IO.File.OpenRead(fileName[0]);

                StreamReader sr = new StreamReader(fileStream, System.Text.Encoding.GetEncoding("Shift_JIS"));

                string textread = sr.ReadToEnd();

                Mailtranslated.Text = textread;

            /*var stringname = Mailtranslated.Text.IndexOf("EVALENRICO ");
            var stringnamelen = Mailtranslated.Text.Substring(stringname);
            MessageBox.Show(stringnamelen);*/

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet2.LO_Capacity' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.lO_CapacityTableAdapter1.Fill(this.aZUREDBDataSet2.LO_Capacity);


            lO_CapacityDataGridView.Columns[1].Frozen = true;
            lO_CapacityDataGridView.Sort(lO_CapacityDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void lO_CapacityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lO_CapacityBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aZUREDBDataSet2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lO_CapacityBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aZUREDBDataSet2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lO_CapacityTableAdapter1.Fill(this.aZUREDBDataSet2.LO_Capacity);
        }
    }
}
