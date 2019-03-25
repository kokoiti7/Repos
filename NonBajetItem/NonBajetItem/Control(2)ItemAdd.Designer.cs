namespace NonBajetItem
{
    partial class Control_1_ItemAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label monthGroupLabel;
            System.Windows.Forms.Label shipIDLabel;
            System.Windows.Forms.Label shipnameLabel;
            System.Windows.Forms.Label budjetbalanceLabel;
            System.Windows.Forms.Label managementfeeLabel;
            System.Windows.Forms.Label paymentDateLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label monthbeginTotalLabel;
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.monthGroupDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipIDTextBox = new System.Windows.Forms.TextBox();
            this.shipnameTextBox = new System.Windows.Forms.TextBox();
            this.budjetbalanceTextBox = new System.Windows.Forms.TextBox();
            this.managementfeeTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.monthbeginTotalTextBox = new System.Windows.Forms.TextBox();
            this.ItemAdd = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            monthGroupLabel = new System.Windows.Forms.Label();
            shipIDLabel = new System.Windows.Forms.Label();
            shipnameLabel = new System.Windows.Forms.Label();
            budjetbalanceLabel = new System.Windows.Forms.Label();
            managementfeeLabel = new System.Windows.Forms.Label();
            paymentDateLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            monthbeginTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(22, 52);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(18, 12);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // monthGroupLabel
            // 
            monthGroupLabel.AutoSize = true;
            monthGroupLabel.Location = new System.Drawing.Point(22, 78);
            monthGroupLabel.Name = "monthGroupLabel";
            monthGroupLabel.Size = new System.Drawing.Size(72, 12);
            monthGroupLabel.TabIndex = 3;
            monthGroupLabel.Text = "Month Group:";
            // 
            // shipIDLabel
            // 
            shipIDLabel.AutoSize = true;
            shipIDLabel.Location = new System.Drawing.Point(22, 102);
            shipIDLabel.Name = "shipIDLabel";
            shipIDLabel.Size = new System.Drawing.Size(44, 12);
            shipIDLabel.TabIndex = 5;
            shipIDLabel.Text = "Ship ID:";
            // 
            // shipnameLabel
            // 
            shipnameLabel.AutoSize = true;
            shipnameLabel.Location = new System.Drawing.Point(22, 127);
            shipnameLabel.Name = "shipnameLabel";
            shipnameLabel.Size = new System.Drawing.Size(58, 12);
            shipnameLabel.TabIndex = 7;
            shipnameLabel.Text = "ShipName:";
            // 
            // budjetbalanceLabel
            // 
            budjetbalanceLabel.AutoSize = true;
            budjetbalanceLabel.Location = new System.Drawing.Point(22, 152);
            budjetbalanceLabel.Name = "budjetbalanceLabel";
            budjetbalanceLabel.Size = new System.Drawing.Size(77, 12);
            budjetbalanceLabel.TabIndex = 9;
            budjetbalanceLabel.Text = "budjetbalance:";
            // 
            // managementfeeLabel
            // 
            managementfeeLabel.AutoSize = true;
            managementfeeLabel.Location = new System.Drawing.Point(22, 218);
            managementfeeLabel.Name = "managementfeeLabel";
            managementfeeLabel.Size = new System.Drawing.Size(87, 12);
            managementfeeLabel.TabIndex = 11;
            managementfeeLabel.Text = "Managementfee:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.Location = new System.Drawing.Point(22, 244);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(79, 12);
            paymentDateLabel.TabIndex = 13;
            paymentDateLabel.Text = "Payment Date:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(22, 268);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(46, 12);
            remarkLabel.TabIndex = 15;
            remarkLabel.Text = "Remark:";
            // 
            // monthbeginTotalLabel
            // 
            monthbeginTotalLabel.AutoSize = true;
            monthbeginTotalLabel.Location = new System.Drawing.Point(22, 293);
            monthbeginTotalLabel.Name = "monthbeginTotalLabel";
            monthbeginTotalLabel.Size = new System.Drawing.Size(95, 12);
            monthbeginTotalLabel.TabIndex = 17;
            monthbeginTotalLabel.Text = "Monthbegin Total:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchange_feeBindingSource
            // 
            this.dataExchange_feeBindingSource.DataMember = "DataExchange_fee";
            this.dataExchange_feeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchange_feeTableAdapter
            // 
            this.dataExchange_feeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_CommentTableAdapter = null;
            this.tableAdapterManager.DataExchange_feeTableAdapter = this.dataExchange_feeTableAdapter;
            this.tableAdapterManager.DataExchangeTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(123, 49);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 19);
            this.iDTextBox.TabIndex = 2;
            // 
            // monthGroupDateTimePicker
            // 
            this.monthGroupDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchange_feeBindingSource, "MonthGroup", true));
            this.monthGroupDateTimePicker.Location = new System.Drawing.Point(123, 74);
            this.monthGroupDateTimePicker.Name = "monthGroupDateTimePicker";
            this.monthGroupDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.monthGroupDateTimePicker.TabIndex = 4;
            // 
            // shipIDTextBox
            // 
            this.shipIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "ShipID", true));
            this.shipIDTextBox.Location = new System.Drawing.Point(123, 99);
            this.shipIDTextBox.Name = "shipIDTextBox";
            this.shipIDTextBox.Size = new System.Drawing.Size(200, 19);
            this.shipIDTextBox.TabIndex = 6;
            // 
            // shipnameTextBox
            // 
            this.shipnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "shipname", true));
            this.shipnameTextBox.Location = new System.Drawing.Point(123, 124);
            this.shipnameTextBox.Name = "shipnameTextBox";
            this.shipnameTextBox.Size = new System.Drawing.Size(200, 19);
            this.shipnameTextBox.TabIndex = 8;
            // 
            // budjetbalanceTextBox
            // 
            this.budjetbalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "budjetbalance", true));
            this.budjetbalanceTextBox.Location = new System.Drawing.Point(123, 149);
            this.budjetbalanceTextBox.Name = "budjetbalanceTextBox";
            this.budjetbalanceTextBox.Size = new System.Drawing.Size(200, 19);
            this.budjetbalanceTextBox.TabIndex = 10;
            // 
            // managementfeeTextBox
            // 
            this.managementfeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "Managementfee", true));
            this.managementfeeTextBox.Location = new System.Drawing.Point(123, 215);
            this.managementfeeTextBox.Name = "managementfeeTextBox";
            this.managementfeeTextBox.Size = new System.Drawing.Size(200, 19);
            this.managementfeeTextBox.TabIndex = 12;
            // 
            // paymentDateDateTimePicker
            // 
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchange_feeBindingSource, "PaymentDate", true));
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(123, 240);
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.paymentDateDateTimePicker.TabIndex = 14;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(123, 265);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(200, 19);
            this.remarkTextBox.TabIndex = 16;
            // 
            // monthbeginTotalTextBox
            // 
            this.monthbeginTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource, "MonthbeginTotal", true));
            this.monthbeginTotalTextBox.Location = new System.Drawing.Point(123, 290);
            this.monthbeginTotalTextBox.Name = "monthbeginTotalTextBox";
            this.monthbeginTotalTextBox.Size = new System.Drawing.Size(200, 19);
            this.monthbeginTotalTextBox.TabIndex = 18;
            // 
            // ItemAdd
            // 
            this.ItemAdd.Location = new System.Drawing.Point(190, 325);
            this.ItemAdd.Name = "ItemAdd";
            this.ItemAdd.Size = new System.Drawing.Size(133, 48);
            this.ItemAdd.TabIndex = 19;
            this.ItemAdd.Text = "ItemAdd";
            this.ItemAdd.UseVisualStyleBackColor = true;
            this.ItemAdd.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // Control_1_ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 395);
            this.Controls.Add(this.ItemAdd);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(monthGroupLabel);
            this.Controls.Add(this.monthGroupDateTimePicker);
            this.Controls.Add(shipIDLabel);
            this.Controls.Add(this.shipIDTextBox);
            this.Controls.Add(shipnameLabel);
            this.Controls.Add(this.shipnameTextBox);
            this.Controls.Add(budjetbalanceLabel);
            this.Controls.Add(this.budjetbalanceTextBox);
            this.Controls.Add(managementfeeLabel);
            this.Controls.Add(this.managementfeeTextBox);
            this.Controls.Add(paymentDateLabel);
            this.Controls.Add(this.paymentDateDateTimePicker);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(monthbeginTotalLabel);
            this.Controls.Add(this.monthbeginTotalTextBox);
            this.Name = "Control_1_ItemAdd";
            this.Text = "Control_2_ItemAdd";
            this.Load += new System.EventHandler(this.Control_2_ItemAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker monthGroupDateTimePicker;
        private System.Windows.Forms.TextBox shipIDTextBox;
        private System.Windows.Forms.TextBox shipnameTextBox;
        private System.Windows.Forms.TextBox budjetbalanceTextBox;
        private System.Windows.Forms.TextBox managementfeeTextBox;
        private System.Windows.Forms.DateTimePicker paymentDateDateTimePicker;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox monthbeginTotalTextBox;
        private System.Windows.Forms.Button ItemAdd;
    }
}