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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangeShipMasterTBBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.dataExchangeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(759, 579);
            this.dataGridView1.TabIndex = 3;
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
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(759, 579);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangeShipMasterTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}
