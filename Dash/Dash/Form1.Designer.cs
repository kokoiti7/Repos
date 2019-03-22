namespace Dash
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
            this.aZUREDBDataSet = new Dash.AZUREDBDataSet();
            this.general_Fleet_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_Fleet_informationTableAdapter = new Dash.AZUREDBDataSetTableAdapters.General_Fleet_informationTableAdapter();
            this.general_fleet_attachGroup1TableAdapter = new Dash.AZUREDBDataSetTableAdapters.General_fleet_attachGroup1TableAdapter();
            this.general_Fleet_informationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.general_Fleet_informationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.general_Fleet_informationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.general_fleet_attachGroup1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filenameListBox = new System.Windows.Forms.ListBox();
            this.fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_Fleet_informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_Fleet_informationBindingNavigator)).BeginInit();
            this.general_Fleet_informationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_Fleet_informationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_fleet_attachGroup1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // general_Fleet_informationBindingSource
            // 
            this.general_Fleet_informationBindingSource.DataMember = "General_Fleet_information";
            this.general_Fleet_informationBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // general_Fleet_informationTableAdapter
            // 
            this.general_Fleet_informationTableAdapter.ClearBeforeFill = true;
            // 
            // general_fleet_attachGroup1TableAdapter
            // 
            this.general_fleet_attachGroup1TableAdapter.ClearBeforeFill = true;
            // 
            // general_Fleet_informationBindingNavigator
            // 
            this.general_Fleet_informationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.general_Fleet_informationBindingNavigator.BindingSource = this.general_Fleet_informationBindingSource;
            this.general_Fleet_informationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.general_Fleet_informationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.general_Fleet_informationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.general_Fleet_informationBindingNavigatorSaveItem});
            this.general_Fleet_informationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.general_Fleet_informationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.general_Fleet_informationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.general_Fleet_informationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.general_Fleet_informationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.general_Fleet_informationBindingNavigator.Name = "general_Fleet_informationBindingNavigator";
            this.general_Fleet_informationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.general_Fleet_informationBindingNavigator.Size = new System.Drawing.Size(1075, 25);
            this.general_Fleet_informationBindingNavigator.TabIndex = 0;
            this.general_Fleet_informationBindingNavigator.Text = "bindingNavigator1";
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
            // general_Fleet_informationBindingNavigatorSaveItem
            // 
            this.general_Fleet_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.general_Fleet_informationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("general_Fleet_informationBindingNavigatorSaveItem.Image")));
            this.general_Fleet_informationBindingNavigatorSaveItem.Name = "general_Fleet_informationBindingNavigatorSaveItem";
            this.general_Fleet_informationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.general_Fleet_informationBindingNavigatorSaveItem.Text = "データの保存";
            this.general_Fleet_informationBindingNavigatorSaveItem.Click += new System.EventHandler(this.general_Fleet_informationBindingNavigatorSaveItem_Click);
            // 
            // general_Fleet_informationDataGridView
            // 
            this.general_Fleet_informationDataGridView.AutoGenerateColumns = false;
            this.general_Fleet_informationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.general_Fleet_informationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12});
            this.general_Fleet_informationDataGridView.DataSource = this.general_Fleet_informationBindingSource;
            this.general_Fleet_informationDataGridView.Location = new System.Drawing.Point(12, 46);
            this.general_Fleet_informationDataGridView.Name = "general_Fleet_informationDataGridView";
            this.general_Fleet_informationDataGridView.RowTemplate.Height = 21;
            this.general_Fleet_informationDataGridView.Size = new System.Drawing.Size(1043, 352);
            this.general_Fleet_informationDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VESSEL NAME";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "VESSEL NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Charterer";
            this.dataGridViewTextBoxColumn57.HeaderText = "Charterer";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "CharterPeriod";
            this.dataGridViewTextBoxColumn54.HeaderText = "CharterPeriod";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nxt Nxt Dock";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nxt Docking Survey";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prop shaft draw";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prop shaft draw";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "BoilerSurvay";
            this.dataGridViewTextBoxColumn55.HeaderText = "BoilerSurvay";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "CraneLoadTest";
            this.dataGridViewTextBoxColumn56.HeaderText = "CraneLoadTest";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IOPPC renewal due";
            this.dataGridViewTextBoxColumn6.HeaderText = "IOPPC renewal due";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "USCG postponed until";
            this.dataGridViewTextBoxColumn7.HeaderText = "USCG postponed until";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "USCG due date";
            this.dataGridViewTextBoxColumn8.HeaderText = "USCG due date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn12.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // general_fleet_attachGroup1BindingSource
            // 
            this.general_fleet_attachGroup1BindingSource.DataMember = "FK_General_fleet_attachGroup1_General_Fleet_information";
            this.general_fleet_attachGroup1BindingSource.DataSource = this.general_Fleet_informationBindingSource;
            // 
            // filenameListBox
            // 
            this.filenameListBox.AllowDrop = true;
            this.filenameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.general_fleet_attachGroup1BindingSource, "Filename", true));
            this.filenameListBox.DataSource = this.general_fleet_attachGroup1BindingSource;
            this.filenameListBox.DisplayMember = "Filename";
            this.filenameListBox.FormattingEnabled = true;
            this.filenameListBox.ItemHeight = 17;
            this.filenameListBox.Location = new System.Drawing.Point(12, 417);
            this.filenameListBox.Name = "filenameListBox";
            this.filenameListBox.Size = new System.Drawing.Size(484, 208);
            this.filenameListBox.TabIndex = 3;
            this.filenameListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.filenameListBox_DragDrop);
            this.filenameListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.filenameListBox_DragEnter);
            this.filenameListBox.DoubleClick += new System.EventHandler(this.filenameListBox_DoubleClick);
            // 
            // fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource
            // 
            this.fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource.DataMember = "FK_General_fleet_attachGroup1_General_Fleet_information";
            this.fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource.DataSource = this.general_Fleet_informationBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 637);
            this.Controls.Add(this.filenameListBox);
            this.Controls.Add(this.general_Fleet_informationDataGridView);
            this.Controls.Add(this.general_Fleet_informationBindingNavigator);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_Fleet_informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_Fleet_informationBindingNavigator)).EndInit();
            this.general_Fleet_informationBindingNavigator.ResumeLayout(false);
            this.general_Fleet_informationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_Fleet_informationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_fleet_attachGroup1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource general_Fleet_informationBindingSource;
        private AZUREDBDataSetTableAdapters.General_Fleet_informationTableAdapter general_Fleet_informationTableAdapter;
        private System.Windows.Forms.BindingNavigator general_Fleet_informationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton general_Fleet_informationBindingNavigatorSaveItem;
        private AZUREDBDataSetTableAdapters.General_fleet_attachGroup1TableAdapter general_fleet_attachGroup1TableAdapter;
        private System.Windows.Forms.DataGridView general_Fleet_informationDataGridView;
        private System.Windows.Forms.BindingSource general_fleet_attachGroup1BindingSource;
        private System.Windows.Forms.ListBox filenameListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource fKGeneralfleetattachGroup1GeneralFleetinformationBindingSource;
    }
}

