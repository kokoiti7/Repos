namespace CrewApp2
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
            System.Windows.Forms.Label cREWINGNoteLabel;
            System.Windows.Forms.Label mRNNoteLabel;
            System.Windows.Forms.Label tECHNoteLabel;
            System.Windows.Forms.Label gENNoteLabel;
            System.Windows.Forms.Label shipNameLabel;
            this.aZUREDBDataSet = new CrewApp2.AZUREDBDataSet();
            this.crew_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_MasterTableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter();
            this.tableAdapterManager = new CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.crew_ApplicationTableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_ApplicationTableAdapter();
            this.crew_ConfidencialReportTableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_ConfidencialReportTableAdapter();
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
            this.新規作成NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開くOToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.上書き保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.印刷PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りUToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.コピーCToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼り付けPToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ヘルプLToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.crew_MasterDataGridView = new System.Windows.Forms.DataGridView();
            this.crew_ApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_ConfidencialReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileNameListBox = new System.Windows.Forms.ListBox();
            this.fKCrewApplicationCrewApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileNameListBox1 = new System.Windows.Forms.ListBox();
            this.fKCrewConfidencialReportCrewMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox1 = new System.Windows.Forms.TextBox();
            this.fKCrewApplicationCrewApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.cREWINGNoteTextBox = new System.Windows.Forms.TextBox();
            this.mRNNoteTextBox = new System.Windows.Forms.TextBox();
            this.tECHNoteTextBox = new System.Windows.Forms.TextBox();
            this.gENNoteTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shipNameComboBox = new System.Windows.Forms.ComboBox();
            cREWINGNoteLabel = new System.Windows.Forms.Label();
            mRNNoteLabel = new System.Windows.Forms.Label();
            tECHNoteLabel = new System.Windows.Forms.Label();
            gENNoteLabel = new System.Windows.Forms.Label();
            shipNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingNavigator)).BeginInit();
            this.crew_MasterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_ConfidencialReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCrewApplicationCrewApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCrewConfidencialReportCrewMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCrewApplicationCrewApplicationBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.UpdateOrder = CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.crew_MasterBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.crew_MasterBindingNavigatorSaveItem,
            this.新規作成NToolStripButton,
            this.開くOToolStripButton,
            this.上書き保存SToolStripButton,
            this.印刷PToolStripButton,
            this.toolStripSeparator,
            this.切り取りUToolStripButton,
            this.コピーCToolStripButton,
            this.貼り付けPToolStripButton,
            this.toolStripSeparator7,
            this.ヘルプLToolStripButton});
            this.crew_MasterBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.crew_MasterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crew_MasterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crew_MasterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crew_MasterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crew_MasterBindingNavigator.Name = "crew_MasterBindingNavigator";
            this.crew_MasterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crew_MasterBindingNavigator.Size = new System.Drawing.Size(477, 25);
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
            this.crew_MasterBindingNavigatorSaveItem.Click += new System.EventHandler(this.crew_MasterBindingNavigatorSaveItem_Click);
            // 
            // 新規作成NToolStripButton
            // 
            this.新規作成NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新規作成NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新規作成NToolStripButton.Image")));
            this.新規作成NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新規作成NToolStripButton.Name = "新規作成NToolStripButton";
            this.新規作成NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新規作成NToolStripButton.Text = "新規作成(&N)";
            // 
            // 開くOToolStripButton
            // 
            this.開くOToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開くOToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開くOToolStripButton.Image")));
            this.開くOToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くOToolStripButton.Name = "開くOToolStripButton";
            this.開くOToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.開くOToolStripButton.Text = "開く(&O)";
            // 
            // 上書き保存SToolStripButton
            // 
            this.上書き保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.上書き保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存SToolStripButton.Image")));
            this.上書き保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripButton.Name = "上書き保存SToolStripButton";
            this.上書き保存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.上書き保存SToolStripButton.Text = "上書き保存(&S)";
            // 
            // 印刷PToolStripButton
            // 
            this.印刷PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.印刷PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("印刷PToolStripButton.Image")));
            this.印刷PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.印刷PToolStripButton.Name = "印刷PToolStripButton";
            this.印刷PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.印刷PToolStripButton.Text = "印刷(&P)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 切り取りUToolStripButton
            // 
            this.切り取りUToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.切り取りUToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("切り取りUToolStripButton.Image")));
            this.切り取りUToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.切り取りUToolStripButton.Name = "切り取りUToolStripButton";
            this.切り取りUToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.切り取りUToolStripButton.Text = "切り取り(&U)";
            // 
            // コピーCToolStripButton
            // 
            this.コピーCToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.コピーCToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("コピーCToolStripButton.Image")));
            this.コピーCToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.コピーCToolStripButton.Name = "コピーCToolStripButton";
            this.コピーCToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.コピーCToolStripButton.Text = "コピー(&C)";
            // 
            // 貼り付けPToolStripButton
            // 
            this.貼り付けPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼り付けPToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("貼り付けPToolStripButton.Image")));
            this.貼り付けPToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼り付けPToolStripButton.Name = "貼り付けPToolStripButton";
            this.貼り付けPToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.貼り付けPToolStripButton.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // ヘルプLToolStripButton
            // 
            this.ヘルプLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ヘルプLToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ヘルプLToolStripButton.Image")));
            this.ヘルプLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ヘルプLToolStripButton.Name = "ヘルプLToolStripButton";
            this.ヘルプLToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ヘルプLToolStripButton.Text = "ヘルプ(&L)";
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
            this.crew_MasterDataGridView.Location = new System.Drawing.Point(9, 61);
            this.crew_MasterDataGridView.Name = "crew_MasterDataGridView";
            this.crew_MasterDataGridView.RowTemplate.Height = 21;
            this.crew_MasterDataGridView.Size = new System.Drawing.Size(1283, 220);
            this.crew_MasterDataGridView.TabIndex = 1;
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
            // fileNameListBox
            // 
            this.fileNameListBox.AllowDrop = true;
            this.fileNameListBox.DataSource = this.crew_ApplicationBindingSource;
            this.fileNameListBox.DisplayMember = "FileName";
            this.fileNameListBox.FormattingEnabled = true;
            this.fileNameListBox.ItemHeight = 12;
            this.fileNameListBox.Location = new System.Drawing.Point(14, 640);
            this.fileNameListBox.Name = "fileNameListBox";
            this.fileNameListBox.Size = new System.Drawing.Size(605, 136);
            this.fileNameListBox.TabIndex = 5;
            this.fileNameListBox.ValueMember = "FileName";
            this.fileNameListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileNameListBox_DragDrop);
            this.fileNameListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileNameListBox_DragEnter);
            // 
            // fKCrewApplicationCrewApplicationBindingSource
            // 
            this.fKCrewApplicationCrewApplicationBindingSource.DataMember = "FK_Crew_Application_Crew_Application";
            this.fKCrewApplicationCrewApplicationBindingSource.DataSource = this.crew_MasterBindingSource;
            // 
            // fileNameListBox1
            // 
            this.fileNameListBox1.AllowDrop = true;
            this.fileNameListBox1.DataSource = this.crew_ConfidencialReportBindingSource;
            this.fileNameListBox1.DisplayMember = "FileName";
            this.fileNameListBox1.FormattingEnabled = true;
            this.fileNameListBox1.ItemHeight = 12;
            this.fileNameListBox1.Location = new System.Drawing.Point(660, 640);
            this.fileNameListBox1.Name = "fileNameListBox1";
            this.fileNameListBox1.Size = new System.Drawing.Size(648, 136);
            this.fileNameListBox1.TabIndex = 7;
            this.fileNameListBox1.ValueMember = "FileName";
            this.fileNameListBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileNameListBox1_DragDrop);
            this.fileNameListBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileNameListBox1_DragEnter);
            // 
            // fKCrewConfidencialReportCrewMasterBindingSource
            // 
            this.fKCrewConfidencialReportCrewMasterBindingSource.DataMember = "FK_Crew_ConfidencialReport_Crew_Master";
            this.fKCrewConfidencialReportCrewMasterBindingSource.DataSource = this.crew_MasterBindingSource;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_ConfidencialReportBindingSource, "FileName", true));
            this.fileNameTextBox.Location = new System.Drawing.Point(14, 615);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(605, 19);
            this.fileNameTextBox.TabIndex = 9;
            // 
            // fileNameTextBox1
            // 
            this.fileNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_ApplicationBindingSource, "FileName", true));
            this.fileNameTextBox1.Location = new System.Drawing.Point(657, 615);
            this.fileNameTextBox1.Name = "fileNameTextBox1";
            this.fileNameTextBox1.ReadOnly = true;
            this.fileNameTextBox1.Size = new System.Drawing.Size(652, 19);
            this.fileNameTextBox1.TabIndex = 11;
            // 
            // fKCrewApplicationCrewApplicationBindingSource1
            // 
            this.fKCrewApplicationCrewApplicationBindingSource1.DataMember = "FK_Crew_Application_Crew_Application";
            this.fKCrewApplicationCrewApplicationBindingSource1.DataSource = this.crew_MasterBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(979, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(1154, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasterID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasterID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TopeverID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TopeverID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PresentRANK";
            this.dataGridViewTextBoxColumn5.HeaderText = "RANK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Licence";
            this.dataGridViewTextBoxColumn6.HeaderText = "Licence";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 69;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 63;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ShipName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ShipName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Emberk";
            this.dataGridViewTextBoxColumn9.HeaderText = "Emberk";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 68;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dismberk";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dismberk";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 78;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NextAvailability";
            this.dataGridViewTextBoxColumn11.HeaderText = "NextAvailability";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 111;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "onVacation";
            this.dataGridViewCheckBoxColumn1.HeaderText = "onVacation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 68;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "LeftFormCompany";
            this.dataGridViewCheckBoxColumn2.HeaderText = "LeftFormCompany";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 104;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CREWINGNote";
            this.dataGridViewTextBoxColumn12.HeaderText = "CREWINGNote";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MRNNote";
            this.dataGridViewTextBoxColumn13.HeaderText = "MRNNote";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TECHNote";
            this.dataGridViewTextBoxColumn14.HeaderText = "TECHNote";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GENNote";
            this.dataGridViewTextBoxColumn15.HeaderText = "GENNote";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "dateSpare";
            this.dataGridViewTextBoxColumn16.HeaderText = "dateSpare";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "nvSpare";
            this.dataGridViewTextBoxColumn17.HeaderText = "nvSpare";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "intSpare";
            this.dataGridViewTextBoxColumn18.HeaderText = "intSpare";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // cREWINGNoteLabel
            // 
            cREWINGNoteLabel.AutoSize = true;
            cREWINGNoteLabel.Location = new System.Drawing.Point(7, 311);
            cREWINGNoteLabel.Name = "cREWINGNoteLabel";
            cREWINGNoteLabel.Size = new System.Drawing.Size(82, 12);
            cREWINGNoteLabel.TabIndex = 15;
            cREWINGNoteLabel.Text = "CREWINGNote:";
            // 
            // cREWINGNoteTextBox
            // 
            this.cREWINGNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "CREWINGNote", true));
            this.cREWINGNoteTextBox.Location = new System.Drawing.Point(657, 326);
            this.cREWINGNoteTextBox.Multiline = true;
            this.cREWINGNoteTextBox.Name = "cREWINGNoteTextBox";
            this.cREWINGNoteTextBox.Size = new System.Drawing.Size(652, 122);
            this.cREWINGNoteTextBox.TabIndex = 16;
            // 
            // mRNNoteLabel
            // 
            mRNNoteLabel.AutoSize = true;
            mRNNoteLabel.Location = new System.Drawing.Point(12, 470);
            mRNNoteLabel.Name = "mRNNoteLabel";
            mRNNoteLabel.Size = new System.Drawing.Size(56, 12);
            mRNNoteLabel.TabIndex = 16;
            mRNNoteLabel.Text = "MRNNote:";
            // 
            // mRNNoteTextBox
            // 
            this.mRNNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "MRNNote", true));
            this.mRNNoteTextBox.Location = new System.Drawing.Point(657, 487);
            this.mRNNoteTextBox.Multiline = true;
            this.mRNNoteTextBox.Name = "mRNNoteTextBox";
            this.mRNNoteTextBox.Size = new System.Drawing.Size(652, 122);
            this.mRNNoteTextBox.TabIndex = 17;
            // 
            // tECHNoteLabel
            // 
            tECHNoteLabel.AutoSize = true;
            tECHNoteLabel.Location = new System.Drawing.Point(655, 472);
            tECHNoteLabel.Name = "tECHNoteLabel";
            tECHNoteLabel.Size = new System.Drawing.Size(61, 12);
            tECHNoteLabel.TabIndex = 17;
            tECHNoteLabel.Text = "TECHNote:";
            // 
            // tECHNoteTextBox
            // 
            this.tECHNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "TECHNote", true));
            this.tECHNoteTextBox.Location = new System.Drawing.Point(9, 326);
            this.tECHNoteTextBox.Multiline = true;
            this.tECHNoteTextBox.Name = "tECHNoteTextBox";
            this.tECHNoteTextBox.Size = new System.Drawing.Size(610, 122);
            this.tECHNoteTextBox.TabIndex = 18;
            // 
            // gENNoteLabel
            // 
            gENNoteLabel.AutoSize = true;
            gENNoteLabel.Location = new System.Drawing.Point(655, 300);
            gENNoteLabel.Name = "gENNoteLabel";
            gENNoteLabel.Size = new System.Drawing.Size(54, 12);
            gENNoteLabel.TabIndex = 18;
            gENNoteLabel.Text = "GENNote:";
            // 
            // gENNoteTextBox
            // 
            this.gENNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "GENNote", true));
            this.gENNoteTextBox.Location = new System.Drawing.Point(9, 485);
            this.gENNoteTextBox.Multiline = true;
            this.gENNoteTextBox.Name = "gENNoteTextBox";
            this.gENNoteTextBox.Size = new System.Drawing.Size(610, 122);
            this.gENNoteTextBox.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "FullName", true));
            this.textBox1.Location = new System.Drawing.Point(750, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 19);
            this.textBox1.TabIndex = 20;
            // 
            // shipNameLabel
            // 
            shipNameLabel.AutoSize = true;
            shipNameLabel.Location = new System.Drawing.Point(507, 20);
            shipNameLabel.Name = "shipNameLabel";
            shipNameLabel.Size = new System.Drawing.Size(62, 12);
            shipNameLabel.TabIndex = 20;
            shipNameLabel.Text = "Ship Name:";
            // 
            // shipNameComboBox
            // 
            this.shipNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "ShipName", true));
            this.shipNameComboBox.FormattingEnabled = true;
            this.shipNameComboBox.Location = new System.Drawing.Point(509, 35);
            this.shipNameComboBox.Name = "shipNameComboBox";
            this.shipNameComboBox.Size = new System.Drawing.Size(169, 20);
            this.shipNameComboBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 796);
            this.Controls.Add(shipNameLabel);
            this.Controls.Add(this.shipNameComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(gENNoteLabel);
            this.Controls.Add(this.gENNoteTextBox);
            this.Controls.Add(tECHNoteLabel);
            this.Controls.Add(this.tECHNoteTextBox);
            this.Controls.Add(mRNNoteLabel);
            this.Controls.Add(this.mRNNoteTextBox);
            this.Controls.Add(cREWINGNoteLabel);
            this.Controls.Add(this.cREWINGNoteTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileNameTextBox1);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameListBox1);
            this.Controls.Add(this.fileNameListBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.fKCrewApplicationCrewApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCrewConfidencialReportCrewMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCrewApplicationCrewApplicationBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource crew_ApplicationBindingSource;
        private AZUREDBDataSetTableAdapters.Crew_ConfidencialReportTableAdapter crew_ConfidencialReportTableAdapter;
        private System.Windows.Forms.BindingSource crew_ConfidencialReportBindingSource;
        private System.Windows.Forms.ListBox fileNameListBox;
        private System.Windows.Forms.ListBox fileNameListBox1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox1;
        private System.Windows.Forms.BindingSource fKCrewApplicationCrewApplicationBindingSource;
        private System.Windows.Forms.BindingSource fKCrewConfidencialReportCrewMasterBindingSource;
        private System.Windows.Forms.BindingSource fKCrewApplicationCrewApplicationBindingSource1;
        private System.Windows.Forms.ToolStripButton 新規作成NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開くOToolStripButton;
        private System.Windows.Forms.ToolStripButton 上書き保存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 印刷PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 切り取りUToolStripButton;
        private System.Windows.Forms.ToolStripButton コピーCToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼り付けPToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton ヘルプLToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox cREWINGNoteTextBox;
        private System.Windows.Forms.TextBox mRNNoteTextBox;
        private System.Windows.Forms.TextBox tECHNoteTextBox;
        private System.Windows.Forms.TextBox gENNoteTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox shipNameComboBox;
    }
}

