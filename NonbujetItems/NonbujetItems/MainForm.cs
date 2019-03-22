using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonbujetItems
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();

          
        }

        private void Dataexchange_Click(object sender, EventArgs e)
        {

            dataExchange1.Visible = true;
            dataExchange_fee1.Visible = false;

        }

        private void DataexchangeCommentShow_Click(object sender, EventArgs e)
        {
        

        

        }

        private void DataexchangeFeeShow_Click(object sender, EventArgs e)
        {
            dataExchange_fee1.Visible = true;
            dataExchange1.Visible = false;
        }
    }
}
