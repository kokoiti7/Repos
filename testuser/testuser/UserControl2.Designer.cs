namespace testuser
{
    partial class UserControl2
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
            this.aZUREDBDataSet = new testuser.AZUREDBDataSet();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeTableAdapter = new testuser.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager = new testuser.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.ship_Master_TBTableAdapter = new testuser.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountUSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountJPYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangerateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandTotalUSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateremark255DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDatedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareMoney1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareint1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparenver1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareBit1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spareBit2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fKDataExchangeShipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.ShipcomboBox = new System.Windows.Forms.ComboBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.aZUREDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveFilterbutton = new System.Windows.Forms.Button();
            this.exchangestrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.removeFitlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangeShipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSetBindingSource)).BeginInit();
            this.exchangestrip.SuspendLayout();
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
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = testuser.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchangeGridView
            // 
            this.dataExchangeGridView.AllowUserToAddRows = false;
            this.dataExchangeGridView.AutoGenerateColumns = false;
            this.dataExchangeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExchangeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shipIDDataGridViewTextBoxColumn,
            this.shipnameDataGridViewTextBoxColumn,
            this.monthGroupDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountUSDDataGridViewTextBoxColumn,
            this.amountJPYDataGridViewTextBoxColumn,
            this.exchangerateDataGridViewTextBoxColumn,
            this.grandTotalUSDDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.updateremark255DataGridViewTextBoxColumn,
            this.updateDatedateDataGridViewTextBoxColumn,
            this.supportDocksDataGridViewTextBoxColumn,
            this.spareMoney1DataGridViewTextBoxColumn,
            this.spareint1DataGridViewTextBoxColumn,
            this.sparenver1DataGridViewTextBoxColumn,
            this.spareDate1DataGridViewTextBoxColumn,
            this.spareBit1DataGridViewCheckBoxColumn,
            this.spareBit2DataGridViewCheckBoxColumn});
            this.dataExchangeGridView.DataSource = this.dataExchangeBindingSource;
            this.dataExchangeGridView.Location = new System.Drawing.Point(0, 71);
            this.dataExchangeGridView.Name = "dataExchangeGridView";
            this.dataExchangeGridView.RowTemplate.Height = 21;
            this.dataExchangeGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataExchangeGridView.Size = new System.Drawing.Size(759, 508);
            this.dataExchangeGridView.TabIndex = 3;
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
            // shipnameDataGridViewTextBoxColumn
            // 
            this.shipnameDataGridViewTextBoxColumn.DataPropertyName = "Shipname";
            this.shipnameDataGridViewTextBoxColumn.HeaderText = "Shipname";
            this.shipnameDataGridViewTextBoxColumn.Name = "shipnameDataGridViewTextBoxColumn";
            // 
            // monthGroupDataGridViewTextBoxColumn
            // 
            this.monthGroupDataGridViewTextBoxColumn.DataPropertyName = "MonthGroup";
            this.monthGroupDataGridViewTextBoxColumn.HeaderText = "MonthGroup";
            this.monthGroupDataGridViewTextBoxColumn.Name = "monthGroupDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // amountUSDDataGridViewTextBoxColumn
            // 
            this.amountUSDDataGridViewTextBoxColumn.DataPropertyName = "AmountUSD";
            this.amountUSDDataGridViewTextBoxColumn.HeaderText = "AmountUSD";
            this.amountUSDDataGridViewTextBoxColumn.Name = "amountUSDDataGridViewTextBoxColumn";
            // 
            // amountJPYDataGridViewTextBoxColumn
            // 
            this.amountJPYDataGridViewTextBoxColumn.DataPropertyName = "AmountJPY";
            this.amountJPYDataGridViewTextBoxColumn.HeaderText = "AmountJPY";
            this.amountJPYDataGridViewTextBoxColumn.Name = "amountJPYDataGridViewTextBoxColumn";
            // 
            // exchangerateDataGridViewTextBoxColumn
            // 
            this.exchangerateDataGridViewTextBoxColumn.DataPropertyName = "exchangerate";
            this.exchangerateDataGridViewTextBoxColumn.HeaderText = "exchangerate";
            this.exchangerateDataGridViewTextBoxColumn.Name = "exchangerateDataGridViewTextBoxColumn";
            // 
            // grandTotalUSDDataGridViewTextBoxColumn
            // 
            this.grandTotalUSDDataGridViewTextBoxColumn.DataPropertyName = "GrandTotalUSD";
            this.grandTotalUSDDataGridViewTextBoxColumn.HeaderText = "GrandTotalUSD";
            this.grandTotalUSDDataGridViewTextBoxColumn.Name = "grandTotalUSDDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "Process";
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // updateremark255DataGridViewTextBoxColumn
            // 
            this.updateremark255DataGridViewTextBoxColumn.DataPropertyName = "Updateremark255";
            this.updateremark255DataGridViewTextBoxColumn.HeaderText = "Updateremark255";
            this.updateremark255DataGridViewTextBoxColumn.Name = "updateremark255DataGridViewTextBoxColumn";
            // 
            // updateDatedateDataGridViewTextBoxColumn
            // 
            this.updateDatedateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDatedate";
            this.updateDatedateDataGridViewTextBoxColumn.HeaderText = "UpdateDatedate";
            this.updateDatedateDataGridViewTextBoxColumn.Name = "updateDatedateDataGridViewTextBoxColumn";
            // 
            // supportDocksDataGridViewTextBoxColumn
            // 
            this.supportDocksDataGridViewTextBoxColumn.DataPropertyName = "SupportDocks";
            this.supportDocksDataGridViewTextBoxColumn.HeaderText = "SupportDocks";
            this.supportDocksDataGridViewTextBoxColumn.Name = "supportDocksDataGridViewTextBoxColumn";
            // 
            // spareMoney1DataGridViewTextBoxColumn
            // 
            this.spareMoney1DataGridViewTextBoxColumn.DataPropertyName = "SpareMoney1";
            this.spareMoney1DataGridViewTextBoxColumn.HeaderText = "SpareMoney1";
            this.spareMoney1DataGridViewTextBoxColumn.Name = "spareMoney1DataGridViewTextBoxColumn";
            // 
            // spareint1DataGridViewTextBoxColumn
            // 
            this.spareint1DataGridViewTextBoxColumn.DataPropertyName = "Spareint1";
            this.spareint1DataGridViewTextBoxColumn.HeaderText = "Spareint1";
            this.spareint1DataGridViewTextBoxColumn.Name = "spareint1DataGridViewTextBoxColumn";
            // 
            // sparenver1DataGridViewTextBoxColumn
            // 
            this.sparenver1DataGridViewTextBoxColumn.DataPropertyName = "Sparenver1";
            this.sparenver1DataGridViewTextBoxColumn.HeaderText = "Sparenver1";
            this.sparenver1DataGridViewTextBoxColumn.Name = "sparenver1DataGridViewTextBoxColumn";
            // 
            // spareDate1DataGridViewTextBoxColumn
            // 
            this.spareDate1DataGridViewTextBoxColumn.DataPropertyName = "SpareDate1";
            this.spareDate1DataGridViewTextBoxColumn.HeaderText = "SpareDate1";
            this.spareDate1DataGridViewTextBoxColumn.Name = "spareDate1DataGridViewTextBoxColumn";
            // 
            // spareBit1DataGridViewCheckBoxColumn
            // 
            this.spareBit1DataGridViewCheckBoxColumn.DataPropertyName = "SpareBit1";
            this.spareBit1DataGridViewCheckBoxColumn.HeaderText = "SpareBit1";
            this.spareBit1DataGridViewCheckBoxColumn.Name = "spareBit1DataGridViewCheckBoxColumn";
            // 
            // spareBit2DataGridViewCheckBoxColumn
            // 
            this.spareBit2DataGridViewCheckBoxColumn.DataPropertyName = "SpareBit2";
            this.spareBit2DataGridViewCheckBoxColumn.HeaderText = "SpareBit2";
            this.spareBit2DataGridViewCheckBoxColumn.Name = "spareBit2DataGridViewCheckBoxColumn";
            // 
            // fKDataExchangeShipMasterTBBindingSource
            // 
            this.fKDataExchangeShipMasterTBBindingSource.DataMember = "FK_DataExchange_Ship_Master_TB";
            this.fKDataExchangeShipMasterTBBindingSource.DataSource = this.ship_Master_TBBindingSource;
            // 
            // BackMonthButton
            // 
            this.BackMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackMonthButton.Location = new System.Drawing.Point(154, 37);
            this.BackMonthButton.Name = "BackMonthButton";
            this.BackMonthButton.Size = new System.Drawing.Size(35, 28);
            this.BackMonthButton.TabIndex = 15;
            this.BackMonthButton.TabStop = false;
            this.BackMonthButton.Text = "<";
            this.BackMonthButton.UseVisualStyleBackColor = true;
            this.BackMonthButton.Click += new System.EventHandler(this.BackMonthButton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextMonthButton.Location = new System.Drawing.Point(193, 37);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(35, 28);
            this.NextMonthButton.TabIndex = 16;
            this.NextMonthButton.TabStop = false;
            this.NextMonthButton.Text = ">";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // ShipcomboBox
            // 
            this.ShipcomboBox.DataSource = this.ship_Master_TBBindingSource;
            this.ShipcomboBox.DisplayMember = "PresentName";
            this.ShipcomboBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShipcomboBox.FormattingEnabled = true;
            this.ShipcomboBox.Location = new System.Drawing.Point(3, 3);
            this.ShipcomboBox.Name = "ShipcomboBox";
            this.ShipcomboBox.Size = new System.Drawing.Size(229, 28);
            this.ShipcomboBox.TabIndex = 13;
            this.ShipcomboBox.SelectedValueChanged += new System.EventHandler(this.ShipcomboBox_SelectedValueChanged);
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MonthTextBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MonthTextBox.Location = new System.Drawing.Point(3, 37);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(145, 28);
            this.MonthTextBox.TabIndex = 14;
            this.MonthTextBox.TabStop = false;
            this.MonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aZUREDBDataSetBindingSource
            // 
            this.aZUREDBDataSetBindingSource.DataSource = this.aZUREDBDataSet;
            this.aZUREDBDataSetBindingSource.Position = 0;
            // 
            // RemoveFilterbutton
            // 
            this.RemoveFilterbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveFilterbutton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveFilterbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveFilterbutton.Location = new System.Drawing.Point(238, 3);
            this.RemoveFilterbutton.Name = "RemoveFilterbutton";
            this.RemoveFilterbutton.Size = new System.Drawing.Size(153, 62);
            this.RemoveFilterbutton.TabIndex = 18;
            this.RemoveFilterbutton.Text = "RemoveFilter";
            this.RemoveFilterbutton.UseVisualStyleBackColor = false;
            this.RemoveFilterbutton.Click += new System.EventHandler(this.RemoveFilterbutton_Click);
            // 
            // exchangestrip
            // 
            this.exchangestrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFitlerToolStripMenuItem,
            this.itemAddToolStripMenuItem});
            this.exchangestrip.Name = "exchangestrip";
            this.exchangestrip.Size = new System.Drawing.Size(155, 48);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(397, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 20;
            this.button1.Text = "ItemAdd";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // removeFitlerToolStripMenuItem
            // 
            this.removeFitlerToolStripMenuItem.Name = "removeFitlerToolStripMenuItem";
            this.removeFitlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeFitlerToolStripMenuItem.Text = "RemoveFitler";
            this.removeFitlerToolStripMenuItem.Click += new System.EventHandler(this.removeFitlerToolStripMenuItem_Click);
            // 
            // itemAddToolStripMenuItem
            // 
            this.itemAddToolStripMenuItem.Name = "itemAddToolStripMenuItem";
            this.itemAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemAddToolStripMenuItem.Text = "ItemAdd";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.exchangestrip;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveFilterbutton);
            this.Controls.Add(this.BackMonthButton);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.ShipcomboBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.dataExchangeGridView);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(759, 579);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangeShipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSetBindingSource)).EndInit();
            this.exchangestrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private System.Windows.Forms.DataGridView dataExchangeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKDataExchangeShipMasterTBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountUSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountJPYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangerateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandTotalUSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateremark255DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDatedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareMoney1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareint1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparenver1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn spareBit1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn spareBit2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BackMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        public System.Windows.Forms.ComboBox ShipcomboBox;
        public System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.BindingSource aZUREDBDataSetBindingSource;
        private System.Windows.Forms.Button RemoveFilterbutton;
        private System.Windows.Forms.ContextMenuStrip exchangestrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem removeFitlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAddToolStripMenuItem;
    }
}
