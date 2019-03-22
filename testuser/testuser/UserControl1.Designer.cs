namespace testuser
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
            this.dataExchange_feeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKDataExchangefeeShipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDataExchangefeeShipMasterTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet = new testuser.AZUREDBDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeTableAdapter = new testuser.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.tableAdapterManager = new testuser.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.ship_Master_TBTableAdapter = new testuser.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangefeeShipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangefeeShipMasterTBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExchange_feeDataGridView
            // 
            this.dataExchange_feeDataGridView.AllowUserToAddRows = false;
            this.dataExchange_feeDataGridView.AutoGenerateColumns = false;
            this.dataExchange_feeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExchange_feeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataExchange_feeDataGridView.DataSource = this.dataExchange_feeBindingSource;
            this.dataExchange_feeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataExchange_feeDataGridView.Name = "dataExchange_feeDataGridView";
            this.dataExchange_feeDataGridView.RowTemplate.Height = 21;
            this.dataExchange_feeDataGridView.Size = new System.Drawing.Size(725, 124);
            this.dataExchange_feeDataGridView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dataGridView1.DataSource = this.dataExchange_feeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(725, 446);
            this.dataGridView1.TabIndex = 3;
            // 
            // fKDataExchangefeeShipMasterTBBindingSource
            // 
            this.fKDataExchangefeeShipMasterTBBindingSource.DataMember = "FK_DataExchange_fee_Ship_Master_TB";
            this.fKDataExchangefeeShipMasterTBBindingSource.DataSource = this.ship_Master_TBBindingSource;
            // 
            // fKDataExchangefeeShipMasterTBBindingSource1
            // 
            this.fKDataExchangefeeShipMasterTBBindingSource1.DataMember = "FK_DataExchange_fee_Ship_Master_TB";
            this.fKDataExchangefeeShipMasterTBBindingSource1.DataSource = this.ship_Master_TBBindingSource;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn17.HeaderText = "ID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "budjetbalance";
            this.dataGridViewTextBoxColumn21.HeaderText = "budjetbalance";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Managementfee";
            this.dataGridViewTextBoxColumn22.HeaderText = "Managementfee";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 110;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumn23.HeaderText = "PaymentDate";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 98;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn24.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 69;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MonthGroup";
            this.dataGridViewTextBoxColumn2.HeaderText = "MonthGroup";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "shipname";
            this.dataGridViewTextBoxColumn4.HeaderText = "shipname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "budjetbalance";
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance from last month";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 114;
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
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = testuser.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataExchange_feeDataGridView);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(725, 579);
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangefeeShipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangefeeShipMasterTBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataExchange_feeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource fKDataExchangefeeShipMasterTBBindingSource;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.BindingSource fKDataExchangefeeShipMasterTBBindingSource1;
    }
}
