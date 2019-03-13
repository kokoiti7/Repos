namespace tes
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
            this.aZUREDBDataSet = new tes.AZUREDBDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new tes.AZUREDBDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new tes.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataTable1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataTable1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.nverSpareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSpareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varSpareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkForNextServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categolyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).BeginInit();
            this.dataTable1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = tes.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Validity_attachTableAdapter = null;
            this.tableAdapterManager.Validity_ItemsTableAdapter = null;
            this.tableAdapterManager.Validity_MasterTableAdapter = null;
            // 
            // dataTable1BindingNavigator
            // 
            this.dataTable1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTable1BindingNavigator.BindingSource = this.dataTable1BindingSource;
            this.dataTable1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTable1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTable1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataTable1BindingNavigatorSaveItem});
            this.dataTable1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTable1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTable1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTable1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTable1BindingNavigator.Name = "dataTable1BindingNavigator";
            this.dataTable1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTable1BindingNavigator.Size = new System.Drawing.Size(1452, 25);
            this.dataTable1BindingNavigator.TabIndex = 0;
            this.dataTable1BindingNavigator.Text = "bindingNavigator1";
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
            // dataTable1BindingNavigatorSaveItem
            // 
            this.dataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTable1BindingNavigatorSaveItem.Enabled = false;
            this.dataTable1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTable1BindingNavigatorSaveItem.Image")));
            this.dataTable1BindingNavigatorSaveItem.Name = "dataTable1BindingNavigatorSaveItem";
            this.dataTable1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataTable1BindingNavigatorSaveItem.Text = "データの保存";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "SAve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categolyNameDataGridViewTextBoxColumn,
            this.itemEquipmentDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.shipIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.accessoryDataGridViewTextBoxColumn,
            this.accessoryRemarkDataGridViewTextBoxColumn,
            this.supplyDateDataGridViewTextBoxColumn,
            this.nextDueDateDataGridViewTextBoxColumn,
            this.updateDataGridViewTextBoxColumn,
            this.remarkForNextServiceDataGridViewTextBoxColumn,
            this.remark2DataGridViewTextBoxColumn,
            this.varSpareDataGridViewTextBoxColumn,
            this.attachIDDataGridViewTextBoxColumn,
            this.typeOfFileDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.filepathDataGridViewTextBoxColumn,
            this.bitSpareDataGridViewCheckBoxColumn,
            this.nverSpareDataGridViewTextBoxColumn});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(12, 79);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowTemplate.Height = 21;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(1192, 537);
            this.dataTable1DataGridView.TabIndex = 1;
            // 
            // nverSpareDataGridViewTextBoxColumn
            // 
            this.nverSpareDataGridViewTextBoxColumn.DataPropertyName = "nverSpare";
            this.nverSpareDataGridViewTextBoxColumn.HeaderText = "nverSpare";
            this.nverSpareDataGridViewTextBoxColumn.Name = "nverSpareDataGridViewTextBoxColumn";
            // 
            // bitSpareDataGridViewCheckBoxColumn
            // 
            this.bitSpareDataGridViewCheckBoxColumn.DataPropertyName = "BitSpare";
            this.bitSpareDataGridViewCheckBoxColumn.HeaderText = "BitSpare";
            this.bitSpareDataGridViewCheckBoxColumn.Name = "bitSpareDataGridViewCheckBoxColumn";
            // 
            // filepathDataGridViewTextBoxColumn
            // 
            this.filepathDataGridViewTextBoxColumn.DataPropertyName = "filepath";
            this.filepathDataGridViewTextBoxColumn.HeaderText = "filepath";
            this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "fileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // typeOfFileDataGridViewTextBoxColumn
            // 
            this.typeOfFileDataGridViewTextBoxColumn.DataPropertyName = "Type of file";
            this.typeOfFileDataGridViewTextBoxColumn.HeaderText = "Type of file";
            this.typeOfFileDataGridViewTextBoxColumn.Name = "typeOfFileDataGridViewTextBoxColumn";
            // 
            // attachIDDataGridViewTextBoxColumn
            // 
            this.attachIDDataGridViewTextBoxColumn.DataPropertyName = "AttachID";
            this.attachIDDataGridViewTextBoxColumn.HeaderText = "AttachID";
            this.attachIDDataGridViewTextBoxColumn.Name = "attachIDDataGridViewTextBoxColumn";
            this.attachIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varSpareDataGridViewTextBoxColumn
            // 
            this.varSpareDataGridViewTextBoxColumn.DataPropertyName = "varSpare";
            this.varSpareDataGridViewTextBoxColumn.HeaderText = "varSpare";
            this.varSpareDataGridViewTextBoxColumn.Name = "varSpareDataGridViewTextBoxColumn";
            // 
            // remark2DataGridViewTextBoxColumn
            // 
            this.remark2DataGridViewTextBoxColumn.DataPropertyName = "Remark2";
            this.remark2DataGridViewTextBoxColumn.HeaderText = "Remark2";
            this.remark2DataGridViewTextBoxColumn.Name = "remark2DataGridViewTextBoxColumn";
            // 
            // remarkForNextServiceDataGridViewTextBoxColumn
            // 
            this.remarkForNextServiceDataGridViewTextBoxColumn.DataPropertyName = "Remark for next service";
            this.remarkForNextServiceDataGridViewTextBoxColumn.HeaderText = "Remark for next service";
            this.remarkForNextServiceDataGridViewTextBoxColumn.Name = "remarkForNextServiceDataGridViewTextBoxColumn";
            // 
            // updateDataGridViewTextBoxColumn
            // 
            this.updateDataGridViewTextBoxColumn.DataPropertyName = "Update";
            this.updateDataGridViewTextBoxColumn.HeaderText = "Update";
            this.updateDataGridViewTextBoxColumn.Name = "updateDataGridViewTextBoxColumn";
            // 
            // nextDueDateDataGridViewTextBoxColumn
            // 
            this.nextDueDateDataGridViewTextBoxColumn.DataPropertyName = "Next due date";
            this.nextDueDateDataGridViewTextBoxColumn.HeaderText = "Next due date";
            this.nextDueDateDataGridViewTextBoxColumn.Name = "nextDueDateDataGridViewTextBoxColumn";
            // 
            // supplyDateDataGridViewTextBoxColumn
            // 
            this.supplyDateDataGridViewTextBoxColumn.DataPropertyName = "Supply Date";
            this.supplyDateDataGridViewTextBoxColumn.HeaderText = "Supply Date";
            this.supplyDateDataGridViewTextBoxColumn.Name = "supplyDateDataGridViewTextBoxColumn";
            // 
            // accessoryRemarkDataGridViewTextBoxColumn
            // 
            this.accessoryRemarkDataGridViewTextBoxColumn.DataPropertyName = "Accessory Remark";
            this.accessoryRemarkDataGridViewTextBoxColumn.HeaderText = "Accessory Remark";
            this.accessoryRemarkDataGridViewTextBoxColumn.Name = "accessoryRemarkDataGridViewTextBoxColumn";
            // 
            // accessoryDataGridViewTextBoxColumn
            // 
            this.accessoryDataGridViewTextBoxColumn.DataPropertyName = "Accessory";
            this.accessoryDataGridViewTextBoxColumn.HeaderText = "Accessory";
            this.accessoryDataGridViewTextBoxColumn.Name = "accessoryDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipIDDataGridViewTextBoxColumn
            // 
            this.shipIDDataGridViewTextBoxColumn.DataPropertyName = "ShipID";
            this.shipIDDataGridViewTextBoxColumn.HeaderText = "ShipID";
            this.shipIDDataGridViewTextBoxColumn.Name = "shipIDDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // itemEquipmentDataGridViewTextBoxColumn
            // 
            this.itemEquipmentDataGridViewTextBoxColumn.DataPropertyName = "Item/Equipment";
            this.itemEquipmentDataGridViewTextBoxColumn.HeaderText = "Item/Equipment";
            this.itemEquipmentDataGridViewTextBoxColumn.Name = "itemEquipmentDataGridViewTextBoxColumn";
            // 
            // categolyNameDataGridViewTextBoxColumn
            // 
            this.categolyNameDataGridViewTextBoxColumn.DataPropertyName = "CategolyName";
            this.categolyNameDataGridViewTextBoxColumn.HeaderText = "CategolyName";
            this.categolyNameDataGridViewTextBoxColumn.Name = "categolyNameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.dataTable1BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).EndInit();
            this.dataTable1BindingNavigator.ResumeLayout(false);
            this.dataTable1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private AZUREDBDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataTable1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn validityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validityID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn update1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn categolyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkForNextServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varSpareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSpareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nverSpareDataGridViewTextBoxColumn;
    }
}

