namespace Service_Due
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
            this.fKValidityattachValidityItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet1 = new Service_Due.AZUREDBDataSet1();
            this.validity_MasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.validity_MasterTableAdapter1 = new Service_Due.AZUREDBDataSet1TableAdapters.Validity_MasterTableAdapter();
            this.tableAdapterManager1 = new Service_Due.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.validity_attachTableAdapter1 = new Service_Due.AZUREDBDataSet1TableAdapters.Validity_attachTableAdapter();
            this.validity_ItemsTableAdapter1 = new Service_Due.AZUREDBDataSet1TableAdapters.Validity_ItemsTableAdapter();
            this.validity_MasterDataGridView = new System.Windows.Forms.DataGridView();
            this.validity_ItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.validity_attachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.validity_attachDataGridView = new System.Windows.Forms.DataGridView();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileNameListBox1 = new System.Windows.Forms.ListBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.fKValidityattachValidityItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // validity_MasterBindingSource1
            // 
            this.validity_MasterBindingSource1.DataMember = "Validity_Master";
            this.validity_MasterBindingSource1.DataSource = this.aZUREDBDataSet1;
            // 
            // validity_MasterTableAdapter1
            // 
            this.validity_MasterTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Service_Due.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Validity_attachTableAdapter = this.validity_attachTableAdapter1;
            this.tableAdapterManager1.Validity_ItemsTableAdapter = this.validity_ItemsTableAdapter1;
            this.tableAdapterManager1.Validity_MasterTableAdapter = this.validity_MasterTableAdapter1;
            // 
            // validity_attachTableAdapter1
            // 
            this.validity_attachTableAdapter1.ClearBeforeFill = true;
            // 
            // validity_ItemsTableAdapter1
            // 
            this.validity_ItemsTableAdapter1.ClearBeforeFill = true;
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
            this.validity_MasterDataGridView.DataSource = this.validity_MasterBindingSource1;
            this.validity_MasterDataGridView.Location = new System.Drawing.Point(0, 58);
            this.validity_MasterDataGridView.Name = "validity_MasterDataGridView";
            this.validity_MasterDataGridView.RowTemplate.Height = 21;
            this.validity_MasterDataGridView.Size = new System.Drawing.Size(921, 220);
            this.validity_MasterDataGridView.TabIndex = 6;
            this.validity_MasterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.validity_MasterDataGridView_CellContentClick);
            // 
            // validity_ItemsBindingSource1
            // 
            this.validity_ItemsBindingSource1.DataMember = "FK_Validity_Items_Validity_Master";
            this.validity_ItemsBindingSource1.DataSource = this.validity_MasterBindingSource1;
            // 
            // validity_attachBindingSource1
            // 
            this.validity_attachBindingSource1.DataMember = "FK_Validity_attach_Validity_Items";
            this.validity_attachBindingSource1.DataSource = this.validity_ItemsBindingSource1;
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
            this.validity_attachDataGridView.DataSource = this.validity_attachBindingSource1;
            this.validity_attachDataGridView.Location = new System.Drawing.Point(0, 510);
            this.validity_attachDataGridView.Name = "validity_attachDataGridView";
            this.validity_attachDataGridView.RowTemplate.Height = 21;
            this.validity_attachDataGridView.Size = new System.Drawing.Size(1275, 220);
            this.validity_attachDataGridView.TabIndex = 6;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validity_attachBindingSource1, "fileName", true));
            this.fileNameTextBox.Location = new System.Drawing.Point(955, 306);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(288, 19);
            this.fileNameTextBox.TabIndex = 7;
            // 
            // fileNameListBox1
            // 
            this.fileNameListBox1.AllowDrop = true;
            this.fileNameListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.validity_attachBindingSource1, "fileName", true));
            this.fileNameListBox1.DataSource = this.validity_attachBindingSource1;
            this.fileNameListBox1.DisplayMember = "fileName";
            this.fileNameListBox1.FormattingEnabled = true;
            this.fileNameListBox1.ItemHeight = 12;
            this.fileNameListBox1.Location = new System.Drawing.Point(955, 57);
            this.fileNameListBox1.Name = "fileNameListBox1";
            this.fileNameListBox1.Size = new System.Drawing.Size(288, 232);
            this.fileNameListBox1.TabIndex = 8;
            this.fileNameListBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileNameListBox1_DragDrop);
            this.fileNameListBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileNameListBox1_DragEnter_1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(1137, 416);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(106, 65);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
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
            this.validity_ItemsDataGridView.DataSource = this.validity_ItemsBindingSource1;
            this.validity_ItemsDataGridView.Location = new System.Drawing.Point(0, 284);
            this.validity_ItemsDataGridView.Name = "validity_ItemsDataGridView";
            this.validity_ItemsDataGridView.RowTemplate.Height = 21;
            this.validity_ItemsDataGridView.Size = new System.Drawing.Size(921, 220);
            this.validity_ItemsDataGridView.TabIndex = 10;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 778);
            this.Controls.Add(this.validity_ItemsDataGridView);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileNameListBox1);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.validity_attachDataGridView);
            this.Controls.Add(this.validity_MasterDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKValidityattachValidityItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_MasterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_attachDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validity_ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource fKValidityattachValidityItemsBindingSource1;
        private AZUREDBDataSet1 aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource validity_MasterBindingSource1;
        private AZUREDBDataSet1TableAdapters.Validity_MasterTableAdapter validity_MasterTableAdapter1;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private AZUREDBDataSet1TableAdapters.Validity_ItemsTableAdapter validity_ItemsTableAdapter1;
        private System.Windows.Forms.DataGridView validity_MasterDataGridView;
        private System.Windows.Forms.BindingSource validity_ItemsBindingSource1;
        private AZUREDBDataSet1TableAdapters.Validity_attachTableAdapter validity_attachTableAdapter1;
        private System.Windows.Forms.BindingSource validity_attachBindingSource1;
        private System.Windows.Forms.DataGridView validity_attachDataGridView;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.ListBox fileNameListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Refresh;
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
    }
}

