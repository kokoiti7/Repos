﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        int rowcnt = 0;
        string dir = @"C:\Users\tech-01-adm\Desktop\Resized";
        public Form1()
        {
            InitializeComponent();
        }

        private void imagetestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.IMPA4thED_Item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_ItemTableAdapter.Fill(this.aZUREDBDataSet1.IMPA4thED_Item);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Imagetest' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
             rowcnt = iMPA4thED_ItemDataGridView.RowCount;
            iMPA4thED_ItemDataGridView.CurrentCell = iMPA4thED_ItemDataGridView[0, 0];
   
   
        }

        private void Upload_Click(object sender, EventArgs e)
        {

            //まわす回数


            rowcnt = iMPA4thED_ItemDataGridView.RowCount;

        

            for(int i=0; i< rowcnt-1; i++)
            {


                iMPA4thED_ItemDataGridView.CurrentCell = iMPA4thED_ItemDataGridView[5, i];

                if (iMPA4thED_ItemDataGridView[5, i].Value.ToString()!=null)
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
            this.iMPA4thED_ItemTableAdapter.Update(this.aZUREDBDataSet1.IMPA4thED_Item);

            /*  int fileCount = Directory.GetFiles(dir, " * ", SearchOption.TopDirectoryOnly).Length;

         MessageBox.Show(fileCount.ToString());*/

        }

        private void iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iMPA4thED_ItemBindingSource1.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.aZUREDBDataSet11);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet11.IMPA4thED_Item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.iMPA4thED_ItemTableAdapter1.Fill(this.aZUREDBDataSet11.IMPA4thED_Item);

        }
    }
    
}
