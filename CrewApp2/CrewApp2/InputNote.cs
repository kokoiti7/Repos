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

        public InputNote()
        {
            InitializeComponent();
        }

        private void InputNote_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Crew_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);

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

            string oldtxt = Environment.NewLine + Properties.Settings.Default.BackupCrewwingNote;

            Properties.Settings.Default.BackupCrewwingNote = newtxt+oldtxt;
            Properties.Settings.Default.Save();

           this.Validate();
           this.crew_MasterBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(aZUREDBDataSet);
           this.crew_MasterTableAdapter.Fill(this.aZUREDBDataSet.Crew_Master);
           this.Close();

          
        }
    }
}
