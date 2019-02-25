using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{


    public partial class Form3 : Form
    {
        private Form1 parentF1;

        public string come;
        public string name;
        public string date;

        public Form3(Form1 parent)
        {
            InitializeComponent();
            parentF1 = parent;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_Comment);
            this.dataExchange_CommentBindingSource.AddNew();
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

            
            textBox1.Text = name;
            commentTextBox.Text = textBox1.Text + ":";
            editdateTimeDateTimePicker.Text = date;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            try
            {

                this.Validate();
                this.dataExchange_CommentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
                this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet.DataExchange_Comment);
                MessageBox.Show("saved");

                
                this.Close();
                parentF1.DgvRefresh();


            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Notcomment");
            }

        }

        private void editdateTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
