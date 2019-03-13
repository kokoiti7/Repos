namespace Service_Due_Maneger
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
            System.Windows.Forms.Label presentNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aZUREDBDataSet = new Service_Due_Maneger.AZUREDBDataSet();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter = new Service_Due_Maneger.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.tableAdapterManager = new Service_Due_Maneger.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.validity_attachTableAdapter = new Service_Due_Maneger.AZUREDBDataSetTableAdapters.Validity_attachTableAdapter();
            this.validity_ItemsTableAdapter = new Service_Due_Maneger.AZUREDBDataSetTableAdapters.Validity_ItemsTableAdapter();
            this.validity_MasterTableAdapter = new Service_Due_Maneger.AZUREDBDataSetTableAdapters.Validity_MasterTableAdapter();
            this.presentNameComboBox = new System.Windows.Forms.ComboBox();
            this.validity_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validity_MasterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validity_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validity_ItemsDataGridView = new System.Windows.Forms.DataGridView();
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
            this.validity_attachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validity_attachDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameListBox = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ship_Master_TBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ship_Master_TBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            presentNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingNavigator)).BeginInit();
            this.ship_Master_TBBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // presentNameLabel
            // 
            presentNameLabel.AutoSize = true;
            presentNameLabel.Location = new System.Drawing.Point(32, 45);
            presentNameLabel.Name = "presentNameLabel";
            presentNameLabel.Size = new System.Drawing.Size(79, 12);
            presentNameLabel.TabIndex = 1;
            presentNameLabel.Text = "Present Name:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = Service_Due_Maneger.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Validity_attachTableAdapter = this.validity_attachTableAdapter;
            this.tableAdapterManager.Validity_ItemsTableAdapter = this.validity_ItemsTableAdapter;
            this.tableAdapterManager.Validity_MasterTableAdapter = this.validity_MasterTableAdapter;
            // 
            // validity_attachTableAdapter
            // 
            this.validity_attachTableAdapter.ClearBeforeFill = true;
            // 
            // validity_ItemsTableAdapter
            // 
            this.validity_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // validity_MasterTableAdapter
            // 
            this.validity_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // presentNameComboBox
            // 
            this.presentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ship_Master_TBBindingSource, "PresentName", true));
            this.presentNameComboBox.DataSource = this.ship_Master_TBBindingSource;
            this.presentNameComboBox.DisplayMember = "PresentName";
            this.presentNameComboBox.FormattingEnabled = true;
            this.presentNameComboBox.Location = new System.Drawing.Point(117, 45);
            this.presentNameComboBox.Name = "presentNameComboBox";
            this.presentNameComboBox.Size = new System.Drawing.Size(121, 20);
            this.presentNameComboBox.TabIndex = 2;
            this.presentNameComboBox.ValueMember = "ID";
            // 
            // validity_MasterBindingSource
            // 
            this.validity_MasterBindingSource.DataMember = "Validity_Master";
            this.validity_MasterBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // validity_MasterDataGridView
            // 
            this.validity_MasterDataGridView.AutoGenerateColumns = false;
            this.validity_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.validity_MasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.validity_MasterDataGridView.DataSource = this.validity_MasterBindingSource;
            this.validity_MasterDataGridView.Location = new System.Drawing.Point(0, 98);
            this.validity_MasterDataGridView.Name = "validity_MasterDataGridView";
            this.validity_MasterDataGridView.RowTemplate.Height = 21;
            this.validity_MasterDataGridView.Size = new System.Drawing.Size(671, 244);
            this.validity_MasterDataGridView.TabIndex = 3;
            this.validity_MasterDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.validity_attachDataGridView_CellLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ValidityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ValidityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategolyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategolyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Item/Equipment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item/Equipment";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Period";
            this.dataGridViewTextBoxColumn4.HeaderText = "Period";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // validity_ItemsBindingSource
            // 
            this.validity_ItemsBindingSource.DataMember = "FK_Validity_Items_Validity_Master";
            this.validity_ItemsBindingSource.DataSource = this.validity_MasterBindingSource;
            // 
            // validity_ItemsDataGridView
            // 
            this.validity_ItemsDataGridView.AutoGenerateColumns = false;
            this.validity_ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.validity_ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn20});
            this.validity_ItemsDataGridView.DataSource = this.validity_ItemsBindingSource;
            this.validity_ItemsDataGridView.Location = new System.Drawing.Point(0, 348);
            this.validity_ItemsDataGridView.Name = "validity_ItemsDataGridView";
            this.validity_ItemsDataGridView.RowTemplate.Height = 21;
            this.validity_ItemsDataGridView.Size = new System.Drawing.Size(1223, 232);
            this.validity_ItemsDataGridView.TabIndex = 4;
            this.validity_ItemsDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.validity_attachDataGridView_CellLeave);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "itemID";
            this.dataGridViewTextBoxColumn7.HeaderText = "itemID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValidityID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ValidityID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn9.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn10.HeaderText = "Type";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn11.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Accessory";
            this.dataGridViewTextBoxColumn12.HeaderText = "Accessory";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Accessory Remark";
            this.dataGridViewTextBoxColumn13.HeaderText = "Accessory Remark";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Supply Date";
            this.dataGridViewTextBoxColumn14.HeaderText = "Supply Date";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Next due date";
            this.dataGridViewTextBoxColumn15.HeaderText = "Next due date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Update";
            this.dataGridViewTextBoxColumn16.HeaderText = "Update";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Remark for next service";
            this.dataGridViewTextBoxColumn17.HeaderText = "Remark for next service";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Remark2";
            this.dataGridViewTextBoxColumn18.HeaderText = "Remark2";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "shipID";
            this.dataGridViewTextBoxColumn19.HeaderText = "shipID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "varSpare";
            this.dataGridViewTextBoxColumn20.HeaderText = "varSpare";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // validity_attachBindingSource
            // 
            this.validity_attachBindingSource.DataMember = "FK_Validity_attach_Validity_Items";
            this.validity_attachBindingSource.DataSource = this.validity_ItemsBindingSource;
            // 
            // validity_attachDataGridView
            // 
            this.validity_attachDataGridView.AutoGenerateColumns = false;
            this.validity_attachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.validity_attachDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.validity_attachDataGridView.DataSource = this.validity_attachBindingSource;
            this.validity_attachDataGridView.Location = new System.Drawing.Point(0, 586);
            this.validity_attachDataGridView.Name = "validity_attachDataGridView";
            this.validity_attachDataGridView.RowTemplate.Height = 21;
            this.validity_attachDataGridView.Size = new System.Drawing.Size(1223, 220);
            this.validity_attachDataGridView.TabIndex = 5;
            this.validity_attachDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.validity_attachDataGridView_CellLeave);
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "AttachID";
            this.dataGridViewTextBoxColumn21.HeaderText = "AttachID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "itemID";
            this.dataGridViewTextBoxColumn22.HeaderText = "itemID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Type of file";
            this.dataGridViewTextBoxColumn23.HeaderText = "Type of file";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "fileName";
            this.dataGridViewTextBoxColumn24.HeaderText = "fileName";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "filepath";
            this.dataGridViewTextBoxColumn25.HeaderText = "filepath";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn26.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "BitSpare";
            this.dataGridViewCheckBoxColumn1.HeaderText = "BitSpare";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Update";
            this.dataGridViewTextBoxColumn27.HeaderText = "Update";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "nverSpare";
            this.dataGridViewTextBoxColumn28.HeaderText = "nverSpare";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // fileNameListBox
            // 
            this.fileNameListBox.AllowDrop = true;
            this.fileNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.validity_attachBindingSource, "fileName", true));
            this.fileNameListBox.DataSource = this.validity_attachBindingSource;
            this.fileNameListBox.DisplayMember = "fileName";
            this.fileNameListBox.FormattingEnabled = true;
            this.fileNameListBox.ItemHeight = 12;
            this.fileNameListBox.Location = new System.Drawing.Point(694, 98);
            this.fileNameListBox.Name = "fileNameListBox";
            this.fileNameListBox.Size = new System.Drawing.Size(227, 244);
            this.fileNameListBox.TabIndex = 7;
            this.fileNameListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileNameListBox_DragDrop);
            this.fileNameListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileNameListBox_DragEnter);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(927, 99);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(281, 243);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
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
            // ship_Master_TBBindingNavigatorSaveItem
            // 
            this.ship_Master_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ship_Master_TBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ship_Master_TBBindingNavigatorSaveItem.Image")));
            this.ship_Master_TBBindingNavigatorSaveItem.Name = "ship_Master_TBBindingNavigatorSaveItem";
            this.ship_Master_TBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ship_Master_TBBindingNavigatorSaveItem.Text = "データの保存";
            this.ship_Master_TBBindingNavigatorSaveItem.Click += new System.EventHandler(this.ship_Master_TBBindingNavigatorSaveItem_Click);
            // 
            // ship_Master_TBBindingNavigator
            // 
            this.ship_Master_TBBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ship_Master_TBBindingNavigator.BindingSource = this.ship_Master_TBBindingSource;
            this.ship_Master_TBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ship_Master_TBBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ship_Master_TBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ship_Master_TBBindingNavigatorSaveItem});
            this.ship_Master_TBBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ship_Master_TBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ship_Master_TBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ship_Master_TBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ship_Master_TBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ship_Master_TBBindingNavigator.Name = "ship_Master_TBBindingNavigator";
            this.ship_Master_TBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ship_Master_TBBindingNavigator.Size = new System.Drawing.Size(1243, 25);
            this.ship_Master_TBBindingNavigator.TabIndex = 0;
            this.ship_Master_TBBindingNavigator.Text = "bindingNavigator1";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validity_attachBindingSource, "fileName", true));
            this.fileNameTextBox.Location = new System.Drawing.Point(694, 68);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(227, 19);
            this.fileNameTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 826);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.fileNameListBox);
            this.Controls.Add(this.validity_attachDataGridView);
            this.Controls.Add(this.validity_ItemsDataGridView);
            this.Controls.Add(this.validity_MasterDataGridView);
            this.Controls.Add(presentNameLabel);
            this.Controls.Add(this.presentNameComboBox);
            this.Controls.Add(this.ship_Master_TBBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingNavigator)).EndInit();
            this.ship_Master_TBBindingNavigator.ResumeLayout(false);
            this.ship_Master_TBBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox presentNameComboBox;
        private AZUREDBDataSetTableAdapters.Validity_MasterTableAdapter validity_MasterTableAdapter;
        private System.Windows.Forms.BindingSource validity_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Validity_ItemsTableAdapter validity_ItemsTableAdapter;
        private System.Windows.Forms.DataGridView validity_MasterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource validity_ItemsBindingSource;
        private AZUREDBDataSetTableAdapters.Validity_attachTableAdapter validity_attachTableAdapter;
        private System.Windows.Forms.DataGridView validity_ItemsDataGridView;
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
        private System.Windows.Forms.BindingSource validity_attachBindingSource;
        private System.Windows.Forms.DataGridView validity_attachDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.ListBox fileNameListBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton ship_Master_TBBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator ship_Master_TBBindingNavigator;
        private System.Windows.Forms.TextBox fileNameTextBox;
    }
}

