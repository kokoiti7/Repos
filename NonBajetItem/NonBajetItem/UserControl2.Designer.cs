namespace NonBajetItem
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
            this.ItemAdd = new System.Windows.Forms.Button();
            this.itemAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFitlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangestrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveFilterbutton = new System.Windows.Forms.Button();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.BackMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.dataExchangeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchangeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.ShipcomboBox = new System.Windows.Forms.ComboBox();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangefeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareMoney1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareint1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangestrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangefeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemAdd
            // 
            this.ItemAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItemAdd.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ItemAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ItemAdd.Location = new System.Drawing.Point(397, 1);
            this.ItemAdd.Name = "ItemAdd";
            this.ItemAdd.Size = new System.Drawing.Size(153, 62);
            this.ItemAdd.TabIndex = 26;
            this.ItemAdd.Text = "ItemAdd";
            this.ItemAdd.UseVisualStyleBackColor = false;
            this.ItemAdd.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // itemAddToolStripMenuItem
            // 
            this.itemAddToolStripMenuItem.Name = "itemAddToolStripMenuItem";
            this.itemAddToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.itemAddToolStripMenuItem.Text = "ItemAdd";
            // 
            // removeFitlerToolStripMenuItem
            // 
            this.removeFitlerToolStripMenuItem.Name = "removeFitlerToolStripMenuItem";
            this.removeFitlerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeFitlerToolStripMenuItem.Text = "RemoveFitler";
            // 
            // exchangestrip
            // 
            this.exchangestrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFitlerToolStripMenuItem,
            this.itemAddToolStripMenuItem});
            this.exchangestrip.Name = "exchangestrip";
            this.exchangestrip.Size = new System.Drawing.Size(155, 48);
            // 
            // RemoveFilterbutton
            // 
            this.RemoveFilterbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveFilterbutton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveFilterbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveFilterbutton.Location = new System.Drawing.Point(238, 1);
            this.RemoveFilterbutton.Name = "RemoveFilterbutton";
            this.RemoveFilterbutton.Size = new System.Drawing.Size(153, 62);
            this.RemoveFilterbutton.TabIndex = 25;
            this.RemoveFilterbutton.Text = "RemoveFilter";
            this.RemoveFilterbutton.UseVisualStyleBackColor = false;
            this.RemoveFilterbutton.Click += new System.EventHandler(this.RemoveFilterbutton_Click);
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MonthTextBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MonthTextBox.Location = new System.Drawing.Point(3, 35);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(145, 28);
            this.MonthTextBox.TabIndex = 22;
            this.MonthTextBox.TabStop = false;
            this.MonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BackMonthButton
            // 
            this.BackMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackMonthButton.Location = new System.Drawing.Point(154, 34);
            this.BackMonthButton.Name = "BackMonthButton";
            this.BackMonthButton.Size = new System.Drawing.Size(35, 28);
            this.BackMonthButton.TabIndex = 23;
            this.BackMonthButton.TabStop = false;
            this.BackMonthButton.Text = "<";
            this.BackMonthButton.UseVisualStyleBackColor = true;
            this.BackMonthButton.Click += new System.EventHandler(this.BackMonthButton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextMonthButton.Location = new System.Drawing.Point(197, 34);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(35, 28);
            this.NextMonthButton.TabIndex = 24;
            this.NextMonthButton.TabStop = false;
            this.NextMonthButton.Text = ">";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataExchangeDataGridView
            // 
            this.dataExchangeDataGridView.AutoGenerateColumns = false;
            this.dataExchangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExchangeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Shipname,
            this.shipIDDataGridViewTextBoxColumn,
            this.monthGroupDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.spareMoney1DataGridViewTextBoxColumn,
            this.spareint1DataGridViewTextBoxColumn,
            this.spareDate1DataGridViewTextBoxColumn});
            this.dataExchangeDataGridView.DataSource = this.dataExchangeBindingSource;
            this.dataExchangeDataGridView.Location = new System.Drawing.Point(0, 68);
            this.dataExchangeDataGridView.Name = "dataExchangeDataGridView";
            this.dataExchangeDataGridView.RowTemplate.Height = 21;
            this.dataExchangeDataGridView.Size = new System.Drawing.Size(773, 511);
            this.dataExchangeDataGridView.TabIndex = 26;
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            this.dataExchangeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // ShipcomboBox
            // 
            this.ShipcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShipcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShipcomboBox.DataSource = this.aZUREDBDataSet;
            this.ShipcomboBox.DisplayMember = "Ship_Master_TB.PresentName";
            this.ShipcomboBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.ShipcomboBox.FormattingEnabled = true;
            this.ShipcomboBox.Location = new System.Drawing.Point(3, 3);
            this.ShipcomboBox.Name = "ShipcomboBox";
            this.ShipcomboBox.Size = new System.Drawing.Size(229, 28);
            this.ShipcomboBox.TabIndex = 27;
            this.ShipcomboBox.SelectedValueChanged += new System.EventHandler(this.ShipcomboBox_SelectedValueChanged);
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchangefeeBindingSource
            // 
            this.dataExchangefeeBindingSource.DataMember = "DataExchange_fee";
            this.dataExchangefeeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchange_feeTableAdapter
            // 
            this.dataExchange_feeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Shipname
            // 
            this.Shipname.DataPropertyName = "Shipname";
            this.Shipname.HeaderText = "Shipname";
            this.Shipname.Name = "Shipname";
            // 
            // shipIDDataGridViewTextBoxColumn
            // 
            this.shipIDDataGridViewTextBoxColumn.DataPropertyName = "ShipID";
            this.shipIDDataGridViewTextBoxColumn.HeaderText = "ShipID";
            this.shipIDDataGridViewTextBoxColumn.Name = "shipIDDataGridViewTextBoxColumn";
            // 
            // monthGroupDataGridViewTextBoxColumn
            // 
            this.monthGroupDataGridViewTextBoxColumn.DataPropertyName = "MonthGroup";
            this.monthGroupDataGridViewTextBoxColumn.HeaderText = "MonthGroup";
            this.monthGroupDataGridViewTextBoxColumn.Name = "monthGroupDataGridViewTextBoxColumn";
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
            // spareDate1DataGridViewTextBoxColumn
            // 
            this.spareDate1DataGridViewTextBoxColumn.DataPropertyName = "SpareDate1";
            this.spareDate1DataGridViewTextBoxColumn.HeaderText = "SpareDate1";
            this.spareDate1DataGridViewTextBoxColumn.Name = "spareDate1DataGridViewTextBoxColumn";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.ShipcomboBox);
            this.Controls.Add(this.dataExchangeDataGridView);
            this.Controls.Add(this.ItemAdd);
            this.Controls.Add(this.RemoveFilterbutton);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.BackMonthButton);
            this.Controls.Add(this.NextMonthButton);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(773, 599);
            this.exchangestrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangefeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ItemAdd;
        private System.Windows.Forms.ToolStripMenuItem itemAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFitlerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip exchangestrip;
        private System.Windows.Forms.Button RemoveFilterbutton;
        public System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.Button BackMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataExchangeDataGridView;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.ComboBox ShipcomboBox;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private System.Windows.Forms.BindingSource dataExchangefeeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipname;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareMoney1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareint1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareDate1DataGridViewTextBoxColumn;
    }
}
