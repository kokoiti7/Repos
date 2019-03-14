namespace CrewAPP
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
            System.Windows.Forms.Label fileNameLabel;
            System.Windows.Forms.Label fileNameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aZUREDBDataSet = new CrewAPP.AZUREDBDataSet();
            this.crew_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_MasterTableAdapter = new CrewAPP.AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter();
            this.tableAdapterManager = new CrewAPP.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.crew_ApplicationTableAdapter = new CrewAPP.AZUREDBDataSetTableAdapters.Crew_ApplicationTableAdapter();
            this.crew_ConfidencialReportTableAdapter = new CrewAPP.AZUREDBDataSetTableAdapters.Crew_ConfidencialReportTableAdapter();
            this.crew_MasterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.crew_MasterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.crew_MasterDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crew_ApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_ConfidencialReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Crewlistbox = new System.Windows.Forms.ListBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox1 = new System.Windows.Forms.TextBox();
            this.crew_ApplicationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crew_ConfidencialReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fileNameLabel = new System.Windows.Forms.Label();
            fileNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingNavigator)).BeginInit();
            this.crew_MasterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ConfidencialReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ApplicationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ConfidencialReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new System.Drawing.Point(1028, 169);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new System.Drawing.Size(59, 12);
            fileNameLabel.TabIndex = 5;
            fileNameLabel.Text = "File Name:";
            // 
            // fileNameLabel1
            // 
            fileNameLabel1.AutoSize = true;
            fileNameLabel1.Location = new System.Drawing.Point(1028, 234);
            fileNameLabel1.Name = "fileNameLabel1";
            fileNameLabel1.Size = new System.Drawing.Size(59, 12);
            fileNameLabel1.TabIndex = 7;
            fileNameLabel1.Text = "File Name:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crew_MasterBindingSource
            // 
            this.crew_MasterBindingSource.DataMember = "Crew_Master";
            this.crew_MasterBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // crew_MasterTableAdapter
            // 
            this.crew_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Crew_ApplicationTableAdapter = this.crew_ApplicationTableAdapter;
            this.tableAdapterManager.Crew_ConfidencialReportTableAdapter = this.crew_ConfidencialReportTableAdapter;
            this.tableAdapterManager.Crew_MasterTableAdapter = this.crew_MasterTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrewAPP.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crew_ApplicationTableAdapter
            // 
            this.crew_ApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // crew_ConfidencialReportTableAdapter
            // 
            this.crew_ConfidencialReportTableAdapter.ClearBeforeFill = true;
            // 
            // crew_MasterBindingNavigator
            // 
            this.crew_MasterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.crew_MasterBindingNavigator.BindingSource = this.crew_MasterBindingSource;
            this.crew_MasterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.crew_MasterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.crew_MasterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.crew_MasterBindingNavigatorSaveItem});
            this.crew_MasterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.crew_MasterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crew_MasterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crew_MasterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crew_MasterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crew_MasterBindingNavigator.Name = "crew_MasterBindingNavigator";
            this.crew_MasterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crew_MasterBindingNavigator.Size = new System.Drawing.Size(1267, 25);
            this.crew_MasterBindingNavigator.TabIndex = 0;
            this.crew_MasterBindingNavigator.Text = "bindingNavigator1";
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
            // crew_MasterBindingNavigatorSaveItem
            // 
            this.crew_MasterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crew_MasterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("crew_MasterBindingNavigatorSaveItem.Image")));
            this.crew_MasterBindingNavigatorSaveItem.Name = "crew_MasterBindingNavigatorSaveItem";
            this.crew_MasterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.crew_MasterBindingNavigatorSaveItem.Text = "データの保存";
            this.crew_MasterBindingNavigatorSaveItem.Click += new System.EventHandler(this.Crew_MasterBindingNavigatorSaveItem_Click);
            // 
            // crew_MasterDataGridView
            // 
            this.crew_MasterDataGridView.AutoGenerateColumns = false;
            this.crew_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crew_MasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.crew_MasterDataGridView.DataSource = this.crew_MasterBindingSource;
            this.crew_MasterDataGridView.Location = new System.Drawing.Point(12, 41);
            this.crew_MasterDataGridView.Name = "crew_MasterDataGridView";
            this.crew_MasterDataGridView.RowTemplate.Height = 21;
            this.crew_MasterDataGridView.Size = new System.Drawing.Size(873, 220);
            this.crew_MasterDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasterID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasterID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TopeverID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TopeverID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PresentRANK";
            this.dataGridViewTextBoxColumn5.HeaderText = "PresentRANK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Licence";
            this.dataGridViewTextBoxColumn6.HeaderText = "Licence";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ShipName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ShipName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Emberk";
            this.dataGridViewTextBoxColumn9.HeaderText = "Emberk";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dismberk";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dismberk";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NextAvailability";
            this.dataGridViewTextBoxColumn11.HeaderText = "NextAvailability";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "onVacation";
            this.dataGridViewCheckBoxColumn1.HeaderText = "onVacation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "LeftFormCompany";
            this.dataGridViewCheckBoxColumn2.HeaderText = "LeftFormCompany";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CREWINGNote";
            this.dataGridViewTextBoxColumn12.HeaderText = "CREWINGNote";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MRNNote";
            this.dataGridViewTextBoxColumn13.HeaderText = "MRNNote";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TECHNote";
            this.dataGridViewTextBoxColumn14.HeaderText = "TECHNote";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GENNote";
            this.dataGridViewTextBoxColumn15.HeaderText = "GENNote";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "dateSpare";
            this.dataGridViewTextBoxColumn16.HeaderText = "dateSpare";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "nvSpare";
            this.dataGridViewTextBoxColumn17.HeaderText = "nvSpare";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "intSpare";
            this.dataGridViewTextBoxColumn18.HeaderText = "intSpare";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // crew_ApplicationBindingSource
            // 
            this.crew_ApplicationBindingSource.DataMember = "FK_Crew_Application_Crew_Application";
            this.crew_ApplicationBindingSource.DataSource = this.crew_MasterBindingSource;
            // 
            // crew_ConfidencialReportBindingSource
            // 
            this.crew_ConfidencialReportBindingSource.DataMember = "FK_Crew_ConfidencialReport_Crew_Master";
            this.crew_ConfidencialReportBindingSource.DataSource = this.crew_MasterBindingSource;
            // 
            // Crewlistbox
            // 
            this.Crewlistbox.AllowDrop = true;
            this.Crewlistbox.FormattingEnabled = true;
            this.Crewlistbox.ItemHeight = 12;
            this.Crewlistbox.Location = new System.Drawing.Point(919, 267);
            this.Crewlistbox.Name = "Crewlistbox";
            this.Crewlistbox.Size = new System.Drawing.Size(325, 436);
            this.Crewlistbox.TabIndex = 4;
            this.Crewlistbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Crewlistbox_DragDrop);
            this.Crewlistbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Crewlistbox_DragEnter);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_ApplicationBindingSource, "FileName", true));
            this.fileNameTextBox.Location = new System.Drawing.Point(1093, 166);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 19);
            this.fileNameTextBox.TabIndex = 6;
            // 
            // fileNameTextBox1
            // 
            this.fileNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_ConfidencialReportBindingSource, "FileName", true));
            this.fileNameTextBox1.Location = new System.Drawing.Point(1093, 231);
            this.fileNameTextBox1.Name = "fileNameTextBox1";
            this.fileNameTextBox1.Size = new System.Drawing.Size(100, 19);
            this.fileNameTextBox1.TabIndex = 8;
            // 
            // crew_ApplicationDataGridView
            // 
            this.crew_ApplicationDataGridView.AutoGenerateColumns = false;
            this.crew_ApplicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crew_ApplicationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.crew_ApplicationDataGridView.DataSource = this.crew_ApplicationBindingSource;
            this.crew_ApplicationDataGridView.Location = new System.Drawing.Point(12, 267);
            this.crew_ApplicationDataGridView.Name = "crew_ApplicationDataGridView";
            this.crew_ApplicationDataGridView.RowTemplate.Height = 21;
            this.crew_ApplicationDataGridView.Size = new System.Drawing.Size(873, 220);
            this.crew_ApplicationDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ApplicationID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ApplicationID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "MasterID";
            this.dataGridViewTextBoxColumn20.HeaderText = "MasterID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn21.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Filepath";
            this.dataGridViewTextBoxColumn22.HeaderText = "Filepath";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "nvSpare";
            this.dataGridViewTextBoxColumn23.HeaderText = "nvSpare";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Updated";
            this.dataGridViewTextBoxColumn24.HeaderText = "Updated";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // crew_ConfidencialReportDataGridView
            // 
            this.crew_ConfidencialReportDataGridView.AutoGenerateColumns = false;
            this.crew_ConfidencialReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crew_ConfidencialReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.crew_ConfidencialReportDataGridView.DataSource = this.crew_ConfidencialReportBindingSource;
            this.crew_ConfidencialReportDataGridView.Location = new System.Drawing.Point(12, 493);
            this.crew_ConfidencialReportDataGridView.Name = "crew_ConfidencialReportDataGridView";
            this.crew_ConfidencialReportDataGridView.RowTemplate.Height = 21;
            this.crew_ConfidencialReportDataGridView.Size = new System.Drawing.Size(873, 220);
            this.crew_ConfidencialReportDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ConfidencialD";
            this.dataGridViewTextBoxColumn25.HeaderText = "ConfidencialD";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "MasterID";
            this.dataGridViewTextBoxColumn26.HeaderText = "MasterID";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn27.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Filepath";
            this.dataGridViewTextBoxColumn28.HeaderText = "Filepath";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Updated";
            this.dataGridViewTextBoxColumn29.HeaderText = "Updated";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "nvSpare";
            this.dataGridViewTextBoxColumn30.HeaderText = "nvSpare";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 743);
            this.Controls.Add(this.crew_ConfidencialReportDataGridView);
            this.Controls.Add(this.crew_ApplicationDataGridView);
            this.Controls.Add(fileNameLabel1);
            this.Controls.Add(this.fileNameTextBox1);
            this.Controls.Add(fileNameLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.Crewlistbox);
            this.Controls.Add(this.crew_MasterDataGridView);
            this.Controls.Add(this.crew_MasterBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingNavigator)).EndInit();
            this.crew_MasterBindingNavigator.ResumeLayout(false);
            this.crew_MasterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ConfidencialReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ApplicationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ConfidencialReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource crew_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter crew_MasterTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator crew_MasterBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton crew_MasterBindingNavigatorSaveItem;
        private AZUREDBDataSetTableAdapters.Crew_ApplicationTableAdapter crew_ApplicationTableAdapter;
        private System.Windows.Forms.DataGridView crew_MasterDataGridView;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.BindingSource crew_ApplicationBindingSource;
        private AZUREDBDataSetTableAdapters.Crew_ConfidencialReportTableAdapter crew_ConfidencialReportTableAdapter;
        private System.Windows.Forms.BindingSource crew_ConfidencialReportBindingSource;
        private System.Windows.Forms.ListBox Crewlistbox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox1;
        private System.Windows.Forms.DataGridView crew_ApplicationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridView crew_ConfidencialReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
    }
}

