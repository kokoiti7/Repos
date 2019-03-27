namespace ShipInvoice
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.documentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuotationUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseOrdersUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RemoveFilterButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.QuotationIDCombobox = new System.Windows.Forms.ComboBox();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet1 = new ShipInvoice.AZUREDBDataSet();
            this.AllView = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.quotation_DocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_DocumentTableAdapter1 = new ShipInvoice.AZUREDBDataSetTableAdapters.Quotation_DocumentTableAdapter();
            this.tableAdapterManager1 = new ShipInvoice.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.quotation_DocumentsTableAdapter1 = new ShipInvoice.AZUREDBDataSetTableAdapters.Quotation_DocumentsTableAdapter();
            this.ship_Master_TBTableAdapter1 = new ShipInvoice.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.quotation_DocumentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotation_DocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_DocumentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKQuotationDocumentsQuotationDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuotationDocumentsQuotationDocumentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentUpdateToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(1279, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // documentUpdateToolStripMenuItem
            // 
            this.documentUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuotationUpdateToolStripMenuItem,
            this.PurchaseOrdersUpdateToolStripMenuItem,
            this.InvoiceUpdateToolStripMenuItem});
            this.documentUpdateToolStripMenuItem.Name = "documentUpdateToolStripMenuItem";
            this.documentUpdateToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.documentUpdateToolStripMenuItem.Text = "DocumentUpdate";
            this.documentUpdateToolStripMenuItem.Click += new System.EventHandler(this.DocumentUpdateToolStripMenuItem_Click);
            // 
            // QuotationUpdateToolStripMenuItem
            // 
            this.QuotationUpdateToolStripMenuItem.Name = "QuotationUpdateToolStripMenuItem";
            this.QuotationUpdateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.QuotationUpdateToolStripMenuItem.Text = "QuotationUpdate";
            this.QuotationUpdateToolStripMenuItem.Click += new System.EventHandler(this.QuotationUpdateToolStripMenuItem_Click);
            // 
            // PurchaseOrdersUpdateToolStripMenuItem
            // 
            this.PurchaseOrdersUpdateToolStripMenuItem.Name = "PurchaseOrdersUpdateToolStripMenuItem";
            this.PurchaseOrdersUpdateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PurchaseOrdersUpdateToolStripMenuItem.Text = "PurchaseOrderUpdate";
            this.PurchaseOrdersUpdateToolStripMenuItem.Click += new System.EventHandler(this.PurchaseOrdersToolStripMenuItem_Click);
            // 
            // InvoiceUpdateToolStripMenuItem
            // 
            this.InvoiceUpdateToolStripMenuItem.Name = "InvoiceUpdateToolStripMenuItem";
            this.InvoiceUpdateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.InvoiceUpdateToolStripMenuItem.Text = "InvoiceUpdate";
            this.InvoiceUpdateToolStripMenuItem.Click += new System.EventHandler(this.InvoiceUpdateToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveFilterButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveFilterButton.Location = new System.Drawing.Point(2, 157);
            this.RemoveFilterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(348, 82);
            this.RemoveFilterButton.TabIndex = 3;
            this.RemoveFilterButton.Text = "RemoveFilter";
            this.RemoveFilterButton.UseVisualStyleBackColor = false;
            this.RemoveFilterButton.Click += new System.EventHandler(this.RemoveFilterButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RefreshButton.Location = new System.Drawing.Point(2, 239);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(348, 82);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // QuotationIDCombobox
            // 
            this.QuotationIDCombobox.DataSource = this.shipMasterTBBindingSource;
            this.QuotationIDCombobox.DisplayMember = "ID";
            this.QuotationIDCombobox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuotationIDCombobox.FormattingEnabled = true;
            this.QuotationIDCombobox.Location = new System.Drawing.Point(2, 33);
            this.QuotationIDCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuotationIDCombobox.Name = "QuotationIDCombobox";
            this.QuotationIDCombobox.Size = new System.Drawing.Size(348, 32);
            this.QuotationIDCombobox.TabIndex = 5;
            this.QuotationIDCombobox.SelectedIndexChanged += new System.EventHandler(this.QuotationIDCombobox_SelectedIndexChanged);
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AllView
            // 
            this.AllView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllView.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllView.Location = new System.Drawing.Point(2, 75);
            this.AllView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllView.Name = "AllView";
            this.AllView.Size = new System.Drawing.Size(348, 82);
            this.AllView.TabIndex = 6;
            this.AllView.Text = "AllView";
            this.AllView.UseVisualStyleBackColor = false;
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_Button.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Save_Button.Location = new System.Drawing.Point(2, 327);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(348, 82);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // quotation_DocumentBindingSource
            // 
            this.quotation_DocumentBindingSource.DataMember = "Quotation_Document";
            this.quotation_DocumentBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // quotation_DocumentTableAdapter1
            // 
            this.quotation_DocumentTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Quotation_DocumentsTableAdapter = this.quotation_DocumentsTableAdapter1;
            this.tableAdapterManager1.Quotation_DocumentTableAdapter = this.quotation_DocumentTableAdapter1;
            this.tableAdapterManager1.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ShipInvoice.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quotation_DocumentsTableAdapter1
            // 
            this.quotation_DocumentsTableAdapter1.ClearBeforeFill = true;
            // 
            // ship_Master_TBTableAdapter1
            // 
            this.ship_Master_TBTableAdapter1.ClearBeforeFill = true;
            // 
            // quotation_DocumentDataGridView
            // 
            this.quotation_DocumentDataGridView.AutoGenerateColumns = false;
            this.quotation_DocumentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotation_DocumentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn21});
            this.quotation_DocumentDataGridView.DataSource = this.quotation_DocumentBindingSource;
            this.quotation_DocumentDataGridView.Location = new System.Drawing.Point(357, 31);
            this.quotation_DocumentDataGridView.Name = "quotation_DocumentDataGridView";
            this.quotation_DocumentDataGridView.RowTemplate.Height = 21;
            this.quotation_DocumentDataGridView.Size = new System.Drawing.Size(922, 220);
            this.quotation_DocumentDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PONumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "PONumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 76;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PresentName";
            this.dataGridViewTextBoxColumn12.HeaderText = "PresentName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 117;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BLOBContainerPath";
            this.dataGridViewTextBoxColumn2.HeaderText = "BLOBContainerPath";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 159;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Contractor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contractor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContractorDetail";
            this.dataGridViewTextBoxColumn4.HeaderText = "ContractorDetail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ContractorPIC";
            this.dataGridViewTextBoxColumn5.HeaderText = "ContractorPIC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ContractorTarm";
            this.dataGridViewTextBoxColumn6.HeaderText = "ContractorTarm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "POReference";
            this.dataGridViewTextBoxColumn8.HeaderText = "POReference";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlanedDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlanedDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IsuueDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "IsuueDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PlanedPort";
            this.dataGridViewTextBoxColumn13.HeaderText = "PlanedPort";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PlanedPortAgent";
            this.dataGridViewTextBoxColumn14.HeaderText = "PlanedPortAgent";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PlanedPortETA";
            this.dataGridViewTextBoxColumn15.HeaderText = "PlanedPortETA";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PlanedPortRemark";
            this.dataGridViewTextBoxColumn16.HeaderText = "PlanedPortRemark";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Orderer";
            this.dataGridViewTextBoxColumn17.HeaderText = "Orderer";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "OrdererPIC";
            this.dataGridViewTextBoxColumn18.HeaderText = "OrdererPIC";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "OrdererDetail";
            this.dataGridViewTextBoxColumn19.HeaderText = "OrdererDetail";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn20.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "DateSpeare";
            this.dataGridViewImageColumn1.HeaderText = "DateSpeare";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "IssuedDateSpeare";
            this.dataGridViewImageColumn2.HeaderText = "IssuedDateSpeare";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "IntDateSpeare";
            this.dataGridViewTextBoxColumn21.HeaderText = "IntDateSpeare";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // quotation_DocumentsBindingSource
            // 
            this.quotation_DocumentsBindingSource.DataMember = "FK_Quotation_Documents_Quotation_Documents";
            this.quotation_DocumentsBindingSource.DataSource = this.quotation_DocumentBindingSource;
            // 
            // quotation_DocumentsDataGridView
            // 
            this.quotation_DocumentsDataGridView.AutoGenerateColumns = false;
            this.quotation_DocumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotation_DocumentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.quotation_DocumentsDataGridView.DataSource = this.fKQuotationDocumentsQuotationDocumentsBindingSource;
            this.quotation_DocumentsDataGridView.Location = new System.Drawing.Point(357, 257);
            this.quotation_DocumentsDataGridView.Name = "quotation_DocumentsDataGridView";
            this.quotation_DocumentsDataGridView.RowTemplate.Height = 21;
            this.quotation_DocumentsDataGridView.Size = new System.Drawing.Size(922, 428);
            this.quotation_DocumentsDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn22.HeaderText = "ID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 49;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "QTNID";
            this.dataGridViewTextBoxColumn23.HeaderText = "QTNID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 77;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn24.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 91;
            // 
            // fKQuotationDocumentsQuotationDocumentsBindingSource
            // 
            this.fKQuotationDocumentsQuotationDocumentsBindingSource.DataMember = "FK_Quotation_Documents_Quotation_Documents";
            this.fKQuotationDocumentsQuotationDocumentsBindingSource.DataSource = this.quotation_DocumentBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 697);
            this.Controls.Add(this.quotation_DocumentsDataGridView);
            this.Controls.Add(this.quotation_DocumentDataGridView);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.AllView);
            this.Controls.Add(this.QuotationIDCombobox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RemoveFilterButton);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuotationDocumentsQuotationDocumentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem documentUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuotationUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseOrdersUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceUpdateToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button RemoveFilterButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox QuotationIDCombobox;
        private System.Windows.Forms.Button AllView;
        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.Quotation_DocumentTableAdapter quotation_DocumentTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private AZUREDBDataSetTableAdapters.Quotation_DocumentsTableAdapter quotation_DocumentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOBContainerPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorPICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorTarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isuueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planedPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planedPortAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planedPortETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planedPortRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordererDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordererPICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordererDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dateSpeareDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn issuedDateSpeareDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDateSpeareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save_Button;
        private AZUREDBDataSet aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource quotation_DocumentBindingSource;
        private AZUREDBDataSetTableAdapters.Quotation_DocumentTableAdapter quotation_DocumentTableAdapter1;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private AZUREDBDataSetTableAdapters.Quotation_DocumentsTableAdapter quotation_DocumentsTableAdapter1;
        private System.Windows.Forms.DataGridView quotation_DocumentDataGridView;
        private System.Windows.Forms.BindingSource quotation_DocumentsBindingSource;
        private System.Windows.Forms.DataGridView quotation_DocumentsDataGridView;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter1;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.BindingSource fKQuotationDocumentsQuotationDocumentsBindingSource;
    }
}

