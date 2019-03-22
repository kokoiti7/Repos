using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewApp2
{
    public partial class InputNote : Form
    {
        public string form1st;
        public string inputform;
        public int grid;
        public InputNote()
        {
            InitializeComponent();
        }

        private void InputNote_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

            this.crew_MasterBindingSource.Position = crew_MasterBindingSource.Find("MasterID", Properties.Settings.Default.tradeint);
        }

        private void Crew_MasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Savetxt_Click(object sender, EventArgs e)
        {

            Form1 Form1 = new Form1();
           
            string newtxt = "["+DateTime.Now.ToString("G") +"]"+"["+ Properties.Settings.Default.UserNames +"]"+"["+ CrewwingText.Text + "]" ;

            string oldtxt = OldTextBox.Text;

            

            OldTextBox.Text = newtxt + Environment.NewLine + oldtxt;


            this.Validate();
            this.crew_MasterBindingSource.EndEdit();
            this.crew_MasterTableAdapter.Update(aZUREDBDataSet.Crew_Master);
           
            this.Close();

       
        }


    }
}
