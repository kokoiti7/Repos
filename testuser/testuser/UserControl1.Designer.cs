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
            this.BackMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.ShipcomboBox = new System.Windows.Forms.ComboBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.RemoveFilterbutton = new System.Windows.Forms.Button();
            this.exchange_feestrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet1 = new testuser.AZUREDBDataSet();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeTableAdapter = new testuser.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager1 = new testuser.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchange_feeTableAdapter1 = new testuser.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter = new testuser.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDataExchangeShipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.exchange_feestrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangeShipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMonthButton
            // 
            this.BackMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackMonthButton.Location = new System.Drawing.Point(154, 36);
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
            this.NextMonthButton.Location = new System.Drawing.Point(197, 36);
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
            this.ShipcomboBox.DataSource = this.shipMasterTBBindingSource;
            this.ShipcomboBox.DisplayMember = "PresentName";
            this.ShipcomboBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShipcomboBox.FormattingEnabled = true;
            this.ShipcomboBox.Location = new System.Drawing.Point(0, 2);
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
            // RemoveFilterbutton
            // 
            this.RemoveFilterbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveFilterbutton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveFilterbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveFilterbutton.Location = new System.Drawing.Point(238, 3);
            this.RemoveFilterbutton.Name = "RemoveFilterbutton";
            this.RemoveFilterbutton.Size = new System.Drawing.Size(153, 62);
            this.RemoveFilterbutton.TabIndex = 17;
            this.RemoveFilterbutton.Text = "RemoveFilter";
            this.RemoveFilterbutton.UseVisualStyleBackColor = false;
            this.RemoveFilterbutton.Click += new System.EventHandler(this.RemoveFilterbutton_Click);
            // 
            // exchange_feestrip
            // 
            this.exchange_feestrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFilterToolStripMenuItem});
            this.exchange_feestrip.Name = "exchange_feestrip";
            this.exchange_feestrip.Size = new System.Drawing.Size(155, 26);
            // 
            // removeFilterToolStripMenuItem
            // 
            this.removeFilterToolStripMenuItem.Name = "removeFilterToolStripMenuItem";
            this.removeFilterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeFilterToolStripMenuItem.Text = "RemoveFilter";
            this.removeFilterToolStripMenuItem.Click += new System.EventHandler(this.removeFilterToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(397, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 19;
            this.button1.Text = "ItemAdd";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataExchange_feeBindingSource
            // 
            this.dataExchange_feeBindingSource.DataMember = "DataExchange_fee";
            this.dataExchange_feeBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            this.dataExchangeBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // dataExchangeTableAdapter
            // 
            this.dataExchangeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DataExchange_CommentTableAdapter = null;
            this.tableAdapterManager1.DataExchange_feeTableAdapter = this.dataExchange_feeTableAdapter1;
            this.tableAdapterManager1.DataExchangeTableAdapter = this.dataExchangeTableAdapter;
            this.tableAdapterManager1.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = testuser.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataExchange_feeTableAdapter1
            // 
            this.dataExchange_feeTableAdapter1.ClearBeforeFill = true;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // fKDataExchangeShipMasterTBBindingSource
            // 
            this.fKDataExchangeShipMasterTBBindingSource.DataMember = "FK_DataExchange_Ship_Master_TB";
            this.fKDataExchangeShipMasterTBBindingSource.DataSource = this.ship_Master_TBBindingSource;
            // 
            // dataExchange_feeDataGridView
            // 
            this.dataExchange_feeDataGridView.AutoGenerateColumns = false;
            this.dataExchange_feeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExchange_feeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn32});
            this.dataExchange_feeDataGridView.DataSource = this.dataExchange_feeBindingSource;
            this.dataExchange_feeDataGridView.Location = new System.Drawing.Point(0, 70);
            this.dataExchange_feeDataGridView.Name = "dataExchange_feeDataGridView";
            this.dataExchange_feeDataGridView.RowTemplate.Height = 21;
            this.dataExchange_feeDataGridView.Size = new System.Drawing.Size(756, 506);
            this.dataExchange_feeDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn17.HeaderText = "ID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "MonthGroup";
            this.dataGridViewTextBoxColumn18.HeaderText = "MonthGroup";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "shipname";
            this.dataGridViewTextBoxColumn20.HeaderText = "shipname";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "budjetbalance";
            this.dataGridViewTextBoxColumn21.HeaderText = "budjetbalance";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Managementfee";
            this.dataGridViewTextBoxColumn22.HeaderText = "Managementfee";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumn23.HeaderText = "PaymentDate";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn24.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "SapreRemark";
            this.dataGridViewTextBoxColumn25.HeaderText = "SapreRemark";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "SpareDate1";
            this.dataGridViewTextBoxColumn26.HeaderText = "SpareDate1";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "SpareDate2";
            this.dataGridViewTextBoxColumn27.HeaderText = "SpareDate2";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "MonthbeginTotal";
            this.dataGridViewTextBoxColumn28.HeaderText = "MonthbeginTotal";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "SpareMoney1";
            this.dataGridViewTextBoxColumn29.HeaderText = "SpareMoney1";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "SpareMoney2";
            this.dataGridViewTextBoxColumn30.HeaderText = "SpareMoney2";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Sparevarch1";
            this.dataGridViewTextBoxColumn31.HeaderText = "Sparevarch1";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Sparebit1";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Sparebit1";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Sparebit2";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Sparebit2";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Spareint1";
            this.dataGridViewTextBoxColumn32.HeaderText = "Spareint1";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.aZUREDBDataSet1;
            this.comboBox1.DisplayMember = "Ship_Master_TB.PresentName";
            this.comboBox1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(556, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.exchange_feestrip;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataExchange_feeDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveFilterbutton);
            this.Controls.Add(this.BackMonthButton);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.ShipcomboBox);
            this.Controls.Add(this.MonthTextBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(756, 579);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.exchange_feestrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDataExchangeShipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackMonthButton;
        private System.Windows.Forms.Button NextMonthButton;
        public System.Windows.Forms.ComboBox ShipcomboBox;
        public System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.Button RemoveFilterbutton;
        private System.Windows.Forms.ContextMenuStrip exchange_feestrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem removeFilterToolStripMenuItem;
        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private AZUREDBDataSet aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter1;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private System.Windows.Forms.BindingSource fKDataExchangeShipMasterTBBindingSource;
        private System.Windows.Forms.DataGridView dataExchange_feeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
