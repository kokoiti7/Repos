using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.workmaster_ship_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.workmaster_ship_TBTableAdapter.Fill(this.aZUREDBDataSet1.workmaster_ship_TB);

            // TODO: このコード行はデータを 'aZUREDBDataSet3.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet2.Ship_Master_TB);
           
          //  todaytext.Text = DateTime.Today.ToString();

           /* ShipnameDropDown.DataSource = ship_Master_TBBindingSource1;
            ShipnameDropDown.DisplayMember = "PresentName";
            ShipnameDropDown.ValueMember = "ID";
            ShipnameDropDown.DropDownStyle = ComboBoxStyle.DropDownList;*/

        }

        private void BlobReport_Click(object sender, EventArgs e)
        {
            blobReport1.BringToFront();
        }

        private void CompanyMember_Click(object sender, EventArgs e)
        {
            companyMember1.BringToFront();
        }

        private void CompanyMaster_Click(object sender, EventArgs e)
        {
            companyMaster1.BringToFront();
        }

        private void Shipmaster_Click(object sender, EventArgs e)
        {

        }
    }
}
