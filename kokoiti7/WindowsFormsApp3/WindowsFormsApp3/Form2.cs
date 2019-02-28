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
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();

        public string shipname;
        public DateTime month;
        public DateTime pay;
        private Form1 parentF1;


        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentF1 = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (managementfeeTextBox.Text == "")
            {
                managementfeeTextBox.Text = "0";
            }
            if (remarkTextBox.Text == "")
            {
                remarkTextBox.Text = "0";
            }
            if (budjetbalanceTextBox.Text == "")
            {
                budjetbalanceTextBox.Text = "0";

            }
            if (remarkTextBox.Text =="")
            {
                remarkTextBox.Text = "0";
            }



            try
            {

                this.Validate();
                this.dataExchange_feeBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
               
                MessageBox.Show("saved");
                this.Close();
                parentF1.DgvRefresh();
            }

            catch(NoNullAllowedException)
            {

                MessageBox.Show("SelectTheMonthGroup");
               
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
          

            //順番が重要
            //fillして更新、行追加
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            this.dataExchange_feeBindingSource1.AddNew();

            this.shipnameTextBox.Text = shipname;
            monthGroupDateTimePicker.Value = month;
            paymentDateDateTimePicker.Value = pay;
        }

    }
}
