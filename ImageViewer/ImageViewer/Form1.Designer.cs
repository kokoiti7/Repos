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
            this.aZUREDBDataSet11 = new ImageViewer.AZUREDBDataSet1();
            this.iMPA4thED_ItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iMPA4thED_ItemTableAdapter1 = new ImageViewer.AZUREDBDataSet1TableAdapters.IMPA4thED_ItemTableAdapter();
            this.tableAdapterManager2 = new ImageViewer.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.iMPA4thED_ItemBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iMPA4thED_ItemDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemBindingSource1BindingNavigator)).BeginInit();
            this.iMPA4thED_ItemBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet11
            // 
            this.aZUREDBDataSet11.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iMPA4thED_ItemBindingSource1
            // 
            this.iMPA4thED_ItemBindingSource1.DataMember = "IMPA4thED_Item";
            this.iMPA4thED_ItemBindingSource1.DataSource = this.aZUREDBDataSet11;
            // 
            // iMPA4thED_ItemTableAdapter1
            // 
            this.iMPA4thED_ItemTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.IMPA4thED_ItemTableAdapter = this.iMPA4thED_ItemTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = ImageViewer.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iMPA4thED_ItemBindingSource1BindingNavigator
            // 
            this.iMPA4thED_ItemBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.BindingSource = this.iMPA4thED_ItemBindingSource1;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem});
            this.iMPA4thED_ItemBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iMPA4thED_ItemBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.Name = "iMPA4thED_ItemBindingSource1BindingNavigator";
            this.iMPA4thED_ItemBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.Size = new System.Drawing.Size(950, 25);
            this.iMPA4thED_ItemBindingSource1BindingNavigator.TabIndex = 0;
            this.iMPA4thED_ItemBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "最初に移動";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "前に戻る";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "現在の場所";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 18);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "項目の総数";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "次に移動";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "最後に移動";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "新規追加";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton6.Text = "削除";
            // 
            // iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem
            // 
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.Image")));
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.Name = "iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem";
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.Text = "データの保存";
            this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // iMPA4thED_ItemDataGridView1
            // 
            this.iMPA4thED_ItemDataGridView1.AutoGenerateColumns = false;
            this.iMPA4thED_ItemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iMPA4thED_ItemDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewImageColumn3,
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
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewImageColumn4});
            this.iMPA4thED_ItemDataGridView1.DataSource = this.iMPA4thED_ItemBindingSource1;
            this.iMPA4thED_ItemDataGridView1.Location = new System.Drawing.Point(0, 170);
            this.iMPA4thED_ItemDataGridView1.Name = "iMPA4thED_ItemDataGridView1";
            this.iMPA4thED_ItemDataGridView1.RowTemplate.Height = 21;
            this.iMPA4thED_ItemDataGridView1.Size = new System.Drawing.Size(938, 220);
            this.iMPA4thED_ItemDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn18.HeaderText = "ID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "SECTION";
            this.dataGridViewTextBoxColumn19.HeaderText = "SECTION";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Apply";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Apply";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "IMPA";
            this.dataGridViewTextBoxColumn20.HeaderText = "IMPA";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "Itemimage";
            this.dataGridViewImageColumn3.HeaderText = "Itemimage";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Photopath1";
            this.dataGridViewTextBoxColumn21.HeaderText = "Photopath1";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "EDESCRIPTION";
            this.dataGridViewTextBoxColumn22.HeaderText = "EDESCRIPTION";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ESPECIFICATION";
            this.dataGridViewTextBoxColumn23.HeaderText = "ESPECIFICATION";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "EUNIT";
            this.dataGridViewTextBoxColumn24.HeaderText = "EUNIT";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ROICODE";
            this.dataGridViewTextBoxColumn25.HeaderText = "ROICODE";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "EREMARK";
            this.dataGridViewTextBoxColumn26.HeaderText = "EREMARK";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "REMARK1";
            this.dataGridViewTextBoxColumn27.HeaderText = "REMARK1";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "CUNIT";
            this.dataGridViewTextBoxColumn28.HeaderText = "CUNIT";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "CSPECIFICATION";
            this.dataGridViewTextBoxColumn29.HeaderText = "CSPECIFICATION";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "UPDATED";
            this.dataGridViewTextBoxColumn30.HeaderText = "UPDATED";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "CREMARK";
            this.dataGridViewTextBoxColumn31.HeaderText = "CREMARK";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "CDESCRIPTION";
            this.dataGridViewTextBoxColumn32.HeaderText = "CDESCRIPTION";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "REMARK2";
            this.dataGridViewTextBoxColumn33.HeaderText = "REMARK2";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "BitSpare";
            this.dataGridViewCheckBoxColumn4.HeaderText = "BitSpare";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Datespare";
            this.dataGridViewTextBoxColumn34.HeaderText = "Datespare";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.DataPropertyName = "Imagespare";
            this.dataGridViewImageColumn4.HeaderText = "Imagespare";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(950, 458);
            this.Controls.Add(this.iMPA4thED_ItemDataGridView1);
            this.Controls.Add(this.iMPA4thED_ItemBindingSource1BindingNavigator);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemBindingSource1BindingNavigator)).EndInit();
            this.iMPA4thED_ItemBindingSource1BindingNavigator.ResumeLayout(false);
            this.iMPA4thED_ItemBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMPA4thED_ItemDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


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
        private AZUREDBDataSet1 aZUREDBDataSet11;
        private System.Windows.Forms.BindingSource iMPA4thED_ItemBindingSource1;
        private AZUREDBDataSet1TableAdapters.IMPA4thED_ItemTableAdapter iMPA4thED_ItemTableAdapter1;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator iMPA4thED_ItemBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton iMPA4thED_ItemBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iMPA4thED_ItemDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
    }
}

