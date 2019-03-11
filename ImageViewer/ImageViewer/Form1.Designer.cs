namespace ImageViewer
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
            this.aZUREDBDataSet = new ImageViewer.AZUREDBDataSet();
            this.imagetestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagetestTableAdapter = new ImageViewer.AZUREDBDataSetTableAdapters.ImagetestTableAdapter();
            this.tableAdapterManager = new ImageViewer.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.imagetestBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.imagetestBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imagetestDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.aZUREDBDataSet1 = new ImageViewer.AZUREDBDataSet1();
            this.iMPA4thED_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMPA4thED_ItemTableAdapter = new ImageViewer.AZUREDBDataSet1TableAdapters.IMPA4thED_ItemTableAdapter();
            this.tableAdapterManager1 = new ImageViewer.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.iMPA4thED_ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.Upload = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestBindingNavigator)).BeginInit();
            this.imagetestBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagetestBindingSource
            // 
            this.imagetestBindingSource.DataMember = "Imagetest";
            this.imagetestBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // imagetestTableAdapter
            // 
            this.imagetestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImagetestTableAdapter = this.imagetestTableAdapter;
            this.tableAdapterManager.UpdateOrder = ImageViewer.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagetestBindingNavigator
            // 
            this.imagetestBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imagetestBindingNavigator.BindingSource = this.imagetestBindingSource;
            this.imagetestBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imagetestBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imagetestBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.imagetestBindingNavigatorSaveItem});
            this.imagetestBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imagetestBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imagetestBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imagetestBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imagetestBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imagetestBindingNavigator.Name = "imagetestBindingNavigator";
            this.imagetestBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imagetestBindingNavigator.Size = new System.Drawing.Size(1139, 25);
            this.imagetestBindingNavigator.TabIndex = 0;
            this.imagetestBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // imagetestBindingNavigatorSaveItem
            // 
            this.imagetestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imagetestBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imagetestBindingNavigatorSaveItem.Image")));
            this.imagetestBindingNavigatorSaveItem.Name = "imagetestBindingNavigatorSaveItem";
            this.imagetestBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imagetestBindingNavigatorSaveItem.Text = "データの保存";
            this.imagetestBindingNavigatorSaveItem.Click += new System.EventHandler(this.imagetestBindingNavigatorSaveItem_Click);
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 41;
            // 
            // imagetestDataGridView
            // 
            this.imagetestDataGridView.AutoGenerateColumns = false;
            this.imagetestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagetestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageDataGridViewImageColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn});
            this.imagetestDataGridView.DataSource = this.imagetestBindingSource;
            this.imagetestDataGridView.Location = new System.Drawing.Point(12, 614);
            this.imagetestDataGridView.Name = "imagetestDataGridView";
            this.imagetestDataGridView.RowTemplate.Height = 100;
            this.imagetestDataGridView.Size = new System.Drawing.Size(1107, 102);
            this.imagetestDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iMPA4thED_ItemBindingSource
            // 
            this.iMPA4thED_ItemBindingSource.DataMember = "IMPA4thED_Item";
            this.iMPA4thED_ItemBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // iMPA4thED_ItemTableAdapter
            // 
            this.iMPA4thED_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.IMPA4thED_ItemTableAdapter = this.iMPA4thED_ItemTableAdapter;
            this.tableAdapterManager1.UpdateOrder = ImageViewer.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iMPA4thED_ItemDataGridView
            // 
            this.iMPA4thED_ItemDataGridView.AutoGenerateColumns = false;
            this.iMPA4thED_ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iMPA4thED_ItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
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
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewImageColumn2});
            this.iMPA4thED_ItemDataGridView.DataSource = this.iMPA4thED_ItemBindingSource;
            this.iMPA4thED_ItemDataGridView.Location = new System.Drawing.Point(12, 57);
            this.iMPA4thED_ItemDataGridView.Name = "iMPA4thED_ItemDataGridView";
            this.iMPA4thED_ItemDataGridView.RowTemplate.Height = 60;
            this.iMPA4thED_ItemDataGridView.Size = new System.Drawing.Size(1107, 543);
            this.iMPA4thED_ItemDataGridView.TabIndex = 3;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(571, 28);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 4;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Imagespare";
            this.dataGridViewImageColumn2.HeaderText = "Imagespare";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Datespare";
            this.dataGridViewTextBoxColumn17.HeaderText = "Datespare";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "BitSpare";
            this.dataGridViewCheckBoxColumn2.HeaderText = "BitSpare";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "REMARK2";
            this.dataGridViewTextBoxColumn16.HeaderText = "REMARK2";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CDESCRIPTION";
            this.dataGridViewTextBoxColumn15.HeaderText = "CDESCRIPTION";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CREMARK";
            this.dataGridViewTextBoxColumn14.HeaderText = "CREMARK";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "UPDATED";
            this.dataGridViewTextBoxColumn13.HeaderText = "UPDATED";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CSPECIFICATION";
            this.dataGridViewTextBoxColumn12.HeaderText = "CSPECIFICATION";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CUNIT";
            this.dataGridViewTextBoxColumn11.HeaderText = "CUNIT";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "REMARK1";
            this.dataGridViewTextBoxColumn10.HeaderText = "REMARK1";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EREMARK";
            this.dataGridViewTextBoxColumn9.HeaderText = "EREMARK";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ROICODE";
            this.dataGridViewTextBoxColumn8.HeaderText = "ROICODE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EUNIT";
            this.dataGridViewTextBoxColumn7.HeaderText = "EUNIT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ESPECIFICATION";
            this.dataGridViewTextBoxColumn6.HeaderText = "ESPECIFICATION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EDESCRIPTION";
            this.dataGridViewTextBoxColumn5.HeaderText = "EDESCRIPTION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Photopath1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Photopath1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Itemimage";
            this.dataGridViewImageColumn1.HeaderText = "Itemimage";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IMPA";
            this.dataGridViewTextBoxColumn3.HeaderText = "IMPA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Apply";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Apply";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SECTION";
            this.dataGridViewTextBoxColumn2.HeaderText = "SECTION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 728);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.iMPA4thED_ItemDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagetestDataGridView);
            this.Controls.Add(this.imagetestBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestBindingNavigator)).EndInit();
            this.imagetestBindingNavigator.ResumeLayout(false);
            this.imagetestBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource imagetestBindingSource;
        private AZUREDBDataSetTableAdapters.ImagetestTableAdapter imagetestTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imagetestBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton imagetestBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridView imagetestDataGridView;
        private System.Windows.Forms.Button button1;
        private AZUREDBDataSet1 aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource iMPA4thED_ItemBindingSource;
        private AZUREDBDataSet1TableAdapters.IMPA4thED_ItemTableAdapter iMPA4thED_ItemTableAdapter;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView iMPA4thED_ItemDataGridView;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}

