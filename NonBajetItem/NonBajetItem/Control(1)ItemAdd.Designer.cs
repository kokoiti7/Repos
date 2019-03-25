namespace NonBajetItem
{
    partial class Control_2_ItemAdd
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
            System.Windows.Forms.Label shipIDLabel;
            System.Windows.Forms.Label shipnameLabel;
            System.Windows.Forms.Label monthGroupLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label amountUSDLabel;
            System.Windows.Forms.Label amountJPYLabel;
            System.Windows.Forms.Label exchangerateLabel;
            System.Windows.Forms.Label grandTotalUSDLabel;
            System.Windows.Forms.Label paymentDateLabel;
            System.Windows.Forms.Label processLabel;
            System.Windows.Forms.Label remarkLabel;
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.shipIDTextBox = new System.Windows.Forms.TextBox();
            this.shipnameTextBox = new System.Windows.Forms.TextBox();
            this.monthGroupDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountUSDTextBox = new System.Windows.Forms.TextBox();
            this.amountJPYTextBox = new System.Windows.Forms.TextBox();
            this.exchangerateTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalUSDTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateTextBox = new System.Windows.Forms.TextBox();
            this.processTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.ItemAdd = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            shipIDLabel = new System.Windows.Forms.Label();
            shipnameLabel = new System.Windows.Forms.Label();
            monthGroupLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            amountUSDLabel = new System.Windows.Forms.Label();
            amountJPYLabel = new System.Windows.Forms.Label();
            exchangerateLabel = new System.Windows.Forms.Label();
            grandTotalUSDLabel = new System.Windows.Forms.Label();
            paymentDateLabel = new System.Windows.Forms.Label();
            processLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            this.dataExchangeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchangeTableAdapter
            // 
            this.dataExchangeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_CommentTableAdapter = null;
            this.tableAdapterManager.DataExchange_feeTableAdapter = null;
            this.tableAdapterManager.DataExchangeTableAdapter = this.dataExchangeTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(30, 44);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(18, 12);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(130, 41);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 19);
            this.iDTextBox.TabIndex = 2;
            // 
            // shipIDLabel
            // 
            shipIDLabel.AutoSize = true;
            shipIDLabel.Location = new System.Drawing.Point(30, 69);
            shipIDLabel.Name = "shipIDLabel";
            shipIDLabel.Size = new System.Drawing.Size(44, 12);
            shipIDLabel.TabIndex = 3;
            shipIDLabel.Text = "Ship ID:";
            // 
            // shipIDTextBox
            // 
            this.shipIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "ShipID", true));
            this.shipIDTextBox.Location = new System.Drawing.Point(130, 66);
            this.shipIDTextBox.Name = "shipIDTextBox";
            this.shipIDTextBox.Size = new System.Drawing.Size(200, 19);
            this.shipIDTextBox.TabIndex = 4;
            // 
            // shipnameLabel
            // 
            shipnameLabel.AutoSize = true;
            shipnameLabel.Location = new System.Drawing.Point(30, 94);
            shipnameLabel.Name = "shipnameLabel";
            shipnameLabel.Size = new System.Drawing.Size(56, 12);
            shipnameLabel.TabIndex = 5;
            shipnameLabel.Text = "Shipname:";
            // 
            // shipnameTextBox
            // 
            this.shipnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "Shipname", true));
            this.shipnameTextBox.Location = new System.Drawing.Point(130, 91);
            this.shipnameTextBox.Name = "shipnameTextBox";
            this.shipnameTextBox.Size = new System.Drawing.Size(200, 19);
            this.shipnameTextBox.TabIndex = 6;
            // 
            // monthGroupLabel
            // 
            monthGroupLabel.AutoSize = true;
            monthGroupLabel.Location = new System.Drawing.Point(30, 120);
            monthGroupLabel.Name = "monthGroupLabel";
            monthGroupLabel.Size = new System.Drawing.Size(72, 12);
            monthGroupLabel.TabIndex = 7;
            monthGroupLabel.Text = "Month Group:";
            // 
            // monthGroupDateTimePicker
            // 
            this.monthGroupDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchangeBindingSource, "MonthGroup", true));
            this.monthGroupDateTimePicker.Location = new System.Drawing.Point(130, 116);
            this.monthGroupDateTimePicker.Name = "monthGroupDateTimePicker";
            this.monthGroupDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.monthGroupDateTimePicker.TabIndex = 8;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(30, 144);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(65, 12);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(130, 141);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 19);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // amountUSDLabel
            // 
            amountUSDLabel.AutoSize = true;
            amountUSDLabel.Location = new System.Drawing.Point(30, 169);
            amountUSDLabel.Name = "amountUSDLabel";
            amountUSDLabel.Size = new System.Drawing.Size(73, 12);
            amountUSDLabel.TabIndex = 11;
            amountUSDLabel.Text = "Amount USD:";
            // 
            // amountUSDTextBox
            // 
            this.amountUSDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "AmountUSD", true));
            this.amountUSDTextBox.Location = new System.Drawing.Point(130, 166);
            this.amountUSDTextBox.Name = "amountUSDTextBox";
            this.amountUSDTextBox.Size = new System.Drawing.Size(200, 19);
            this.amountUSDTextBox.TabIndex = 12;
            // 
            // amountJPYLabel
            // 
            amountJPYLabel.AutoSize = true;
            amountJPYLabel.Location = new System.Drawing.Point(30, 194);
            amountJPYLabel.Name = "amountJPYLabel";
            amountJPYLabel.Size = new System.Drawing.Size(71, 12);
            amountJPYLabel.TabIndex = 13;
            amountJPYLabel.Text = "Amount JPY:";
            // 
            // amountJPYTextBox
            // 
            this.amountJPYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "AmountJPY", true));
            this.amountJPYTextBox.Location = new System.Drawing.Point(130, 191);
            this.amountJPYTextBox.Name = "amountJPYTextBox";
            this.amountJPYTextBox.Size = new System.Drawing.Size(200, 19);
            this.amountJPYTextBox.TabIndex = 14;
            // 
            // exchangerateLabel
            // 
            exchangerateLabel.AutoSize = true;
            exchangerateLabel.Location = new System.Drawing.Point(30, 219);
            exchangerateLabel.Name = "exchangerateLabel";
            exchangerateLabel.Size = new System.Drawing.Size(75, 12);
            exchangerateLabel.TabIndex = 15;
            exchangerateLabel.Text = "exchangerate:";
            // 
            // exchangerateTextBox
            // 
            this.exchangerateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "exchangerate", true));
            this.exchangerateTextBox.Location = new System.Drawing.Point(130, 216);
            this.exchangerateTextBox.Name = "exchangerateTextBox";
            this.exchangerateTextBox.Size = new System.Drawing.Size(200, 19);
            this.exchangerateTextBox.TabIndex = 16;
            // 
            // grandTotalUSDLabel
            // 
            grandTotalUSDLabel.AutoSize = true;
            grandTotalUSDLabel.Location = new System.Drawing.Point(30, 244);
            grandTotalUSDLabel.Name = "grandTotalUSDLabel";
            grandTotalUSDLabel.Size = new System.Drawing.Size(94, 12);
            grandTotalUSDLabel.TabIndex = 17;
            grandTotalUSDLabel.Text = "Grand Total USD:";
            // 
            // grandTotalUSDTextBox
            // 
            this.grandTotalUSDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "GrandTotalUSD", true));
            this.grandTotalUSDTextBox.Location = new System.Drawing.Point(130, 241);
            this.grandTotalUSDTextBox.Name = "grandTotalUSDTextBox";
            this.grandTotalUSDTextBox.Size = new System.Drawing.Size(200, 19);
            this.grandTotalUSDTextBox.TabIndex = 18;
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.Location = new System.Drawing.Point(30, 269);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(79, 12);
            paymentDateLabel.TabIndex = 19;
            paymentDateLabel.Text = "Payment Date:";
            // 
            // paymentDateTextBox
            // 
            this.paymentDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "PaymentDate", true));
            this.paymentDateTextBox.Location = new System.Drawing.Point(130, 266);
            this.paymentDateTextBox.Name = "paymentDateTextBox";
            this.paymentDateTextBox.Size = new System.Drawing.Size(200, 19);
            this.paymentDateTextBox.TabIndex = 20;
            // 
            // processLabel
            // 
            processLabel.AutoSize = true;
            processLabel.Location = new System.Drawing.Point(30, 294);
            processLabel.Name = "processLabel";
            processLabel.Size = new System.Drawing.Size(48, 12);
            processLabel.TabIndex = 21;
            processLabel.Text = "Process:";
            // 
            // processTextBox
            // 
            this.processTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "Process", true));
            this.processTextBox.Location = new System.Drawing.Point(130, 291);
            this.processTextBox.Name = "processTextBox";
            this.processTextBox.Size = new System.Drawing.Size(200, 19);
            this.processTextBox.TabIndex = 22;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(30, 319);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(46, 12);
            remarkLabel.TabIndex = 23;
            remarkLabel.Text = "Remark:";
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(130, 316);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(200, 19);
            this.remarkTextBox.TabIndex = 24;
            // 
            // ItemAdd
            // 
            this.ItemAdd.Location = new System.Drawing.Point(211, 356);
            this.ItemAdd.Name = "ItemAdd";
            this.ItemAdd.Size = new System.Drawing.Size(119, 53);
            this.ItemAdd.TabIndex = 25;
            this.ItemAdd.Text = "ItemAdd";
            this.ItemAdd.UseVisualStyleBackColor = true;
            this.ItemAdd.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // Control_2_ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 421);
            this.Controls.Add(this.ItemAdd);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(shipIDLabel);
            this.Controls.Add(this.shipIDTextBox);
            this.Controls.Add(shipnameLabel);
            this.Controls.Add(this.shipnameTextBox);
            this.Controls.Add(monthGroupLabel);
            this.Controls.Add(this.monthGroupDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(amountUSDLabel);
            this.Controls.Add(this.amountUSDTextBox);
            this.Controls.Add(amountJPYLabel);
            this.Controls.Add(this.amountJPYTextBox);
            this.Controls.Add(exchangerateLabel);
            this.Controls.Add(this.exchangerateTextBox);
            this.Controls.Add(grandTotalUSDLabel);
            this.Controls.Add(this.grandTotalUSDTextBox);
            this.Controls.Add(paymentDateLabel);
            this.Controls.Add(this.paymentDateTextBox);
            this.Controls.Add(processLabel);
            this.Controls.Add(this.processTextBox);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Name = "Control_2_ItemAdd";
            this.Text = "Control_1_ItemAdd";
            this.Load += new System.EventHandler(this.Control_2_ItemAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox shipIDTextBox;
        private System.Windows.Forms.TextBox shipnameTextBox;
        private System.Windows.Forms.DateTimePicker monthGroupDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountUSDTextBox;
        private System.Windows.Forms.TextBox amountJPYTextBox;
        private System.Windows.Forms.TextBox exchangerateTextBox;
        private System.Windows.Forms.TextBox grandTotalUSDTextBox;
        private System.Windows.Forms.TextBox paymentDateTextBox;
        private System.Windows.Forms.TextBox processTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Button ItemAdd;
    }
}