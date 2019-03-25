namespace NonBajetItem
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemAdd = new System.Windows.Forms.Button();
            this.removeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchange_feestrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveFilterbutton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.ShipcomboBox = new System.Windows.Forms.ComboBox();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.BackMonthButton = new System.Windows.Forms.Button();
            this.dataExchange_feeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchange_feeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataExchange_feeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budjetbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managementfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapreRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDate2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthbeginTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareMoney1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareMoney2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparevarch1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparebit1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sparebit2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spareint1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            this.exchange_feestrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            // 
            // dataExchange_feeBindingSource
            // 
            this.dataExchange_feeBindingSource.DataMember = "DataExchange_fee";
            // 
            // ItemAdd
            // 
            this.ItemAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItemAdd.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ItemAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ItemAdd.Location = new System.Drawing.Point(397, 0);
            this.ItemAdd.Name = "ItemAdd";
            this.ItemAdd.Size = new System.Drawing.Size(153, 62);
            this.ItemAdd.TabIndex = 26;
            this.ItemAdd.Text = "ItemAdd";
            this.ItemAdd.UseVisualStyleBackColor = false;
            this.ItemAdd.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // removeFilterToolStripMenuItem
            // 
            this.removeFilterToolStripMenuItem.Name = "removeFilterToolStripMenuItem";
            this.removeFilterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeFilterToolStripMenuItem.Text = "RemoveFilter";
            // 
            // exchange_feestrip
            // 
            this.exchange_feestrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFilterToolStripMenuItem});
            this.exchange_feestrip.Name = "exchange_feestrip";
            this.exchange_feestrip.Size = new System.Drawing.Size(155, 26);
            // 
            // RemoveFilterbutton
            // 
            this.RemoveFilterbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveFilterbutton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveFilterbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveFilterbutton.Location = new System.Drawing.Point(238, 0);
            this.RemoveFilterbutton.Name = "RemoveFilterbutton";
            this.RemoveFilterbutton.Size = new System.Drawing.Size(153, 62);
            this.RemoveFilterbutton.TabIndex = 24;
            this.RemoveFilterbutton.Text = "RemoveFilter";
            this.RemoveFilterbutton.UseVisualStyleBackColor = false;
            this.RemoveFilterbutton.Click += new System.EventHandler(this.RemoveFilterbutton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextMonthButton.Location = new System.Drawing.Point(197, 33);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(35, 28);
            this.NextMonthButton.TabIndex = 23;
            this.NextMonthButton.TabStop = false;
            this.NextMonthButton.Text = ">";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // ShipcomboBox
            // 
            this.ShipcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShipcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShipcomboBox.DataSource = this.aZUREDBDataSet;
            this.ShipcomboBox.DisplayMember = "Ship_Master_TB.PresentName";
            this.ShipcomboBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShipcomboBox.FormattingEnabled = true;
            this.ShipcomboBox.Location = new System.Drawing.Point(3, 3);
            this.ShipcomboBox.Name = "ShipcomboBox";
            this.ShipcomboBox.Size = new System.Drawing.Size(229, 28);
            this.ShipcomboBox.TabIndex = 20;
            this.ShipcomboBox.SelectedValueChanged += new System.EventHandler(this.ShipcomboBox_SelectedValueChanged);
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MonthTextBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MonthTextBox.Location = new System.Drawing.Point(3, 34);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(145, 28);
            this.MonthTextBox.TabIndex = 21;
            this.MonthTextBox.TabStop = false;
            this.MonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BackMonthButton
            // 
            this.BackMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackMonthButton.Location = new System.Drawing.Point(154, 33);
            this.BackMonthButton.Name = "BackMonthButton";
            this.BackMonthButton.Size = new System.Drawing.Size(35, 28);
            this.BackMonthButton.TabIndex = 22;
            this.BackMonthButton.TabStop = false;
            this.BackMonthButton.Text = "<";
            this.BackMonthButton.UseVisualStyleBackColor = true;
            this.BackMonthButton.Click += new System.EventHandler(this.BackMonthButton_Click);
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
            // dataExchange_feeDataGridView
            // 
            this.dataExchange_feeDataGridView.AutoGenerateColumns = false;
            this.dataExchange_feeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExchange_feeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shipIDDataGridViewTextBoxColumn,
            this.Shipname,
            this.monthGroupDataGridViewTextBoxColumn,
            this.budjetbalanceDataGridViewTextBoxColumn,
            this.managementfeeDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.sapreRemarkDataGridViewTextBoxColumn,
            this.spareDate1DataGridViewTextBoxColumn,
            this.spareDate2DataGridViewTextBoxColumn,
            this.monthbeginTotalDataGridViewTextBoxColumn,
            this.spareMoney1DataGridViewTextBoxColumn,
            this.spareMoney2DataGridViewTextBoxColumn,
            this.sparevarch1DataGridViewTextBoxColumn,
            this.sparebit1DataGridViewCheckBoxColumn,
            this.sparebit2DataGridViewCheckBoxColumn,
            this.spareint1DataGridViewTextBoxColumn});
            this.dataExchange_feeDataGridView.DataSource = this.dataExchange_feeBindingSource1;
            this.dataExchange_feeDataGridView.Location = new System.Drawing.Point(0, 67);
            this.dataExchange_feeDataGridView.Name = "dataExchange_feeDataGridView";
            this.dataExchange_feeDataGridView.RowTemplate.Height = 21;
            this.dataExchange_feeDataGridView.Size = new System.Drawing.Size(770, 507);
            this.dataExchange_feeDataGridView.TabIndex = 26;
            // 
            // dataExchange_feeBindingSource1
            // 
            this.dataExchange_feeBindingSource1.DataMember = "DataExchange_fee";
            this.dataExchange_feeBindingSource1.DataSource = this.aZUREDBDataSet;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipIDDataGridViewTextBoxColumn
            // 
            this.shipIDDataGridViewTextBoxColumn.DataPropertyName = "ShipID";
            this.shipIDDataGridViewTextBoxColumn.HeaderText = "ShipID";
            this.shipIDDataGridViewTextBoxColumn.Name = "shipIDDataGridViewTextBoxColumn";
            // 
            // Shipname
            // 
            this.Shipname.DataPropertyName = "Shipname";
            this.Shipname.HeaderText = "Shipname";
            this.Shipname.Name = "Shipname";
            // 
            // monthGroupDataGridViewTextBoxColumn
            // 
            this.monthGroupDataGridViewTextBoxColumn.DataPropertyName = "MonthGroup";
            this.monthGroupDataGridViewTextBoxColumn.HeaderText = "MonthGroup";
            this.monthGroupDataGridViewTextBoxColumn.Name = "monthGroupDataGridViewTextBoxColumn";
            // 
            // budjetbalanceDataGridViewTextBoxColumn
            // 
            this.budjetbalanceDataGridViewTextBoxColumn.DataPropertyName = "budjetbalance";
            this.budjetbalanceDataGridViewTextBoxColumn.HeaderText = "budjetbalance";
            this.budjetbalanceDataGridViewTextBoxColumn.Name = "budjetbalanceDataGridViewTextBoxColumn";
            // 
            // managementfeeDataGridViewTextBoxColumn
            // 
            this.managementfeeDataGridViewTextBoxColumn.DataPropertyName = "Managementfee";
            this.managementfeeDataGridViewTextBoxColumn.HeaderText = "Managementfee";
            this.managementfeeDataGridViewTextBoxColumn.Name = "managementfeeDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // sapreRemarkDataGridViewTextBoxColumn
            // 
            this.sapreRemarkDataGridViewTextBoxColumn.DataPropertyName = "SapreRemark";
            this.sapreRemarkDataGridViewTextBoxColumn.HeaderText = "SapreRemark";
            this.sapreRemarkDataGridViewTextBoxColumn.Name = "sapreRemarkDataGridViewTextBoxColumn";
            // 
            // spareDate1DataGridViewTextBoxColumn
            // 
            this.spareDate1DataGridViewTextBoxColumn.DataPropertyName = "SpareDate1";
            this.spareDate1DataGridViewTextBoxColumn.HeaderText = "SpareDate1";
            this.spareDate1DataGridViewTextBoxColumn.Name = "spareDate1DataGridViewTextBoxColumn";
            // 
            // spareDate2DataGridViewTextBoxColumn
            // 
            this.spareDate2DataGridViewTextBoxColumn.DataPropertyName = "SpareDate2";
            this.spareDate2DataGridViewTextBoxColumn.HeaderText = "SpareDate2";
            this.spareDate2DataGridViewTextBoxColumn.Name = "spareDate2DataGridViewTextBoxColumn";
            // 
            // monthbeginTotalDataGridViewTextBoxColumn
            // 
            this.monthbeginTotalDataGridViewTextBoxColumn.DataPropertyName = "MonthbeginTotal";
            this.monthbeginTotalDataGridViewTextBoxColumn.HeaderText = "MonthbeginTotal";
            this.monthbeginTotalDataGridViewTextBoxColumn.Name = "monthbeginTotalDataGridViewTextBoxColumn";
            // 
            // spareMoney1DataGridViewTextBoxColumn
            // 
            this.spareMoney1DataGridViewTextBoxColumn.DataPropertyName = "SpareMoney1";
            this.spareMoney1DataGridViewTextBoxColumn.HeaderText = "SpareMoney1";
            this.spareMoney1DataGridViewTextBoxColumn.Name = "spareMoney1DataGridViewTextBoxColumn";
            // 
            // spareMoney2DataGridViewTextBoxColumn
            // 
            this.spareMoney2DataGridViewTextBoxColumn.DataPropertyName = "SpareMoney2";
            this.spareMoney2DataGridViewTextBoxColumn.HeaderText = "SpareMoney2";
            this.spareMoney2DataGridViewTextBoxColumn.Name = "spareMoney2DataGridViewTextBoxColumn";
            // 
            // sparevarch1DataGridViewTextBoxColumn
            // 
            this.sparevarch1DataGridViewTextBoxColumn.DataPropertyName = "Sparevarch1";
            this.sparevarch1DataGridViewTextBoxColumn.HeaderText = "Sparevarch1";
            this.sparevarch1DataGridViewTextBoxColumn.Name = "sparevarch1DataGridViewTextBoxColumn";
            // 
            // sparebit1DataGridViewCheckBoxColumn
            // 
            this.sparebit1DataGridViewCheckBoxColumn.DataPropertyName = "Sparebit1";
            this.sparebit1DataGridViewCheckBoxColumn.HeaderText = "Sparebit1";
            this.sparebit1DataGridViewCheckBoxColumn.Name = "sparebit1DataGridViewCheckBoxColumn";
            // 
            // sparebit2DataGridViewCheckBoxColumn
            // 
            this.sparebit2DataGridViewCheckBoxColumn.DataPropertyName = "Sparebit2";
            this.sparebit2DataGridViewCheckBoxColumn.HeaderText = "Sparebit2";
            this.sparebit2DataGridViewCheckBoxColumn.Name = "sparebit2DataGridViewCheckBoxColumn";
            // 
            // spareint1DataGridViewTextBoxColumn
            // 
            this.spareint1DataGridViewTextBoxColumn.DataPropertyName = "Spareint1";
            this.spareint1DataGridViewTextBoxColumn.HeaderText = "Spareint1";
            this.spareint1DataGridViewTextBoxColumn.Name = "spareint1DataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataExchange_feeDataGridView);
            this.Controls.Add(this.ItemAdd);
            this.Controls.Add(this.RemoveFilterbutton);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.ShipcomboBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.BackMonthButton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(770, 574);
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            this.exchange_feestrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private System.Windows.Forms.Button ItemAdd;
        private System.Windows.Forms.ToolStripMenuItem removeFilterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip exchange_feestrip;
        private System.Windows.Forms.Button RemoveFilterbutton;
        private System.Windows.Forms.Button NextMonthButton;
        public System.Windows.Forms.ComboBox ShipcomboBox;
        public System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.Button BackMonthButton;
        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataExchange_feeDataGridView;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipname;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budjetbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managementfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapreRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareDate2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthbeginTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareMoney1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareMoney2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparevarch1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sparebit1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sparebit2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareint1DataGridViewTextBoxColumn;
    }
}
