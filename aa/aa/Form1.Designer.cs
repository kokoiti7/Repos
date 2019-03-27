namespace aa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aZUREDBDataSet = new aa.AZUREDBDataSet();
            this.quotation_DocumentTableAdapter = new aa.AZUREDBDataSetTableAdapters.Quotation_DocumentTableAdapter();
            this.tableAdapterManager = new aa.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.quoatation_FileNameTableAdapter = new aa.AZUREDBDataSetTableAdapters.Quoatation_FileNameTableAdapter();
            this.quotation_DocumentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quotation_DocumentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quotation_DocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_DocumentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.quoatation_FileNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quoatation_FileName1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quoatation_FileName1TableAdapter = new aa.AZUREDBDataSetTableAdapters.Quoatation_FileName1TableAdapter();
            this.quoatation_FileName1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKQuoatationFileNameQuotationDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentBindingNavigator)).BeginInit();
            this.quotation_DocumentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoatation_FileNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoatation_FileName1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoatation_FileName1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuoatationFileNameQuotationDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quotation_DocumentTableAdapter
            // 
            this.quotation_DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Quoatation_FileName1TableAdapter = null;
            this.tableAdapterManager.Quoatation_FileNameTableAdapter = this.quoatation_FileNameTableAdapter;
            this.tableAdapterManager.Quotation_DocumentTableAdapter = this.quotation_DocumentTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aa.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quoatation_FileNameTableAdapter
            // 
            this.quoatation_FileNameTableAdapter.ClearBeforeFill = true;
            // 
            // quotation_DocumentBindingNavigator
            // 
            this.quotation_DocumentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.quotation_DocumentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quotation_DocumentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quotation_DocumentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.quotation_DocumentBindingNavigatorSaveItem});
            this.quotation_DocumentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quotation_DocumentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quotation_DocumentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quotation_DocumentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quotation_DocumentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quotation_DocumentBindingNavigator.Name = "quotation_DocumentBindingNavigator";
            this.quotation_DocumentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quotation_DocumentBindingNavigator.Size = new System.Drawing.Size(828, 25);
            this.quotation_DocumentBindingNavigator.TabIndex = 0;
            this.quotation_DocumentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // quotation_DocumentBindingNavigatorSaveItem
            // 
            this.quotation_DocumentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quotation_DocumentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quotation_DocumentBindingNavigatorSaveItem.Image")));
            this.quotation_DocumentBindingNavigatorSaveItem.Name = "quotation_DocumentBindingNavigatorSaveItem";
            this.quotation_DocumentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.quotation_DocumentBindingNavigatorSaveItem.Text = "データの保存";
            this.quotation_DocumentBindingNavigatorSaveItem.Click += new System.EventHandler(this.quotation_DocumentBindingNavigatorSaveItem_Click);
            // 
            // quotation_DocumentBindingSource
            // 
            this.quotation_DocumentBindingSource.DataMember = "Quotation_Document";
            this.quotation_DocumentBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // quotation_DocumentDataGridView
            // 
            this.quotation_DocumentDataGridView.AutoGenerateColumns = false;
            this.quotation_DocumentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotation_DocumentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
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
            this.quotation_DocumentDataGridView.Location = new System.Drawing.Point(96, 28);
            this.quotation_DocumentDataGridView.Name = "quotation_DocumentDataGridView";
            this.quotation_DocumentDataGridView.RowTemplate.Height = 21;
            this.quotation_DocumentDataGridView.Size = new System.Drawing.Size(712, 265);
            this.quotation_DocumentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BLOBContainerPath";
            this.dataGridViewTextBoxColumn2.HeaderText = "BLOBContainerPath";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PONumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "PONumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PresentName";
            this.dataGridViewTextBoxColumn12.HeaderText = "PresentName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
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
            // quoatation_FileNameBindingSource
            // 
            this.quoatation_FileNameBindingSource.DataMember = "Quoatation_FileName";
            this.quoatation_FileNameBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // quoatation_FileName1BindingSource
            // 
            this.quoatation_FileName1BindingSource.DataMember = "Quoatation_FileName1";
            this.quoatation_FileName1BindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // quoatation_FileName1TableAdapter
            // 
            this.quoatation_FileName1TableAdapter.ClearBeforeFill = true;
            // 
            // quoatation_FileName1DataGridView
            // 
            this.quoatation_FileName1DataGridView.AutoGenerateColumns = false;
            this.quoatation_FileName1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoatation_FileName1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.quoatation_FileName1DataGridView.DataSource = this.fKQuoatationFileNameQuotationDocumentBindingSource;
            this.quoatation_FileName1DataGridView.Location = new System.Drawing.Point(96, 362);
            this.quoatation_FileName1DataGridView.Name = "quoatation_FileName1DataGridView";
            this.quoatation_FileName1DataGridView.RowTemplate.Height = 21;
            this.quoatation_FileName1DataGridView.Size = new System.Drawing.Size(712, 220);
            this.quoatation_FileName1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn22.HeaderText = "ID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "QTNTBL_ID";
            this.dataGridViewTextBoxColumn23.HeaderText = "QTNTBL_ID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn24.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "UpdateRemark";
            this.dataGridViewTextBoxColumn25.HeaderText = "UpdateRemark";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // fKQuoatationFileNameQuotationDocumentBindingSource
            // 
            this.fKQuoatationFileNameQuotationDocumentBindingSource.DataMember = "FK_Quoatation_FileName_Quotation_Document";
            this.fKQuoatationFileNameQuotationDocumentBindingSource.DataSource = this.quotation_DocumentBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 661);
            this.Controls.Add(this.quoatation_FileName1DataGridView);
            this.Controls.Add(this.quotation_DocumentDataGridView);
            this.Controls.Add(this.quotation_DocumentBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentBindingNavigator)).EndInit();
            this.quotation_DocumentBindingNavigator.ResumeLayout(false);
            this.quotation_DocumentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoatation_FileNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoatation_FileName1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoatation_FileName1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuoatationFileNameQuotationDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.Quotation_DocumentTableAdapter quotation_DocumentTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quotation_DocumentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton quotation_DocumentBindingNavigatorSaveItem;
        private AZUREDBDataSetTableAdapters.Quoatation_FileNameTableAdapter quoatation_FileNameTableAdapter;
        private System.Windows.Forms.BindingSource quotation_DocumentBindingSource;
        private System.Windows.Forms.DataGridView quotation_DocumentDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.BindingSource quoatation_FileNameBindingSource;
        private System.Windows.Forms.BindingSource quoatation_FileName1BindingSource;
        private AZUREDBDataSetTableAdapters.Quoatation_FileName1TableAdapter quoatation_FileName1TableAdapter;
        private System.Windows.Forms.DataGridView quoatation_FileName1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.BindingSource fKQuoatationFileNameQuotationDocumentBindingSource;
    }
}

