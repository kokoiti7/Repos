namespace WindowsFormsApp5
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RemoveFilterButton = new System.Windows.Forms.Button();
            this.ShipIDCombobox = new System.Windows.Forms.ComboBox();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet = new WindowsFormsApp5.AZUREDBDataSet();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.documentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterManager = new WindowsFormsApp5.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.ship_Master_TBTableAdapter = new WindowsFormsApp5.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.drawing_MasterTableAdapter = new WindowsFormsApp5.AZUREDBDataSetTableAdapters.Drawing_MasterTableAdapter();
            this.drawing_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawing_MasterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_MasterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_Button.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Save_Button.Location = new System.Drawing.Point(0, 481);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(392, 68);
            this.Save_Button.TabIndex = 11;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RefreshButton.Location = new System.Drawing.Point(0, 389);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(392, 68);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveFilterButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveFilterButton.Location = new System.Drawing.Point(0, 297);
            this.RemoveFilterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(392, 68);
            this.RemoveFilterButton.TabIndex = 9;
            this.RemoveFilterButton.Text = "RemoveFilter";
            this.RemoveFilterButton.UseVisualStyleBackColor = false;
            this.RemoveFilterButton.Click += new System.EventHandler(this.RemoveFilterButton_Click);
            // 
            // ShipIDCombobox
            // 
            this.ShipIDCombobox.DataSource = this.ship_Master_TBBindingSource;
            this.ShipIDCombobox.DisplayMember = "ID";
            this.ShipIDCombobox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShipIDCombobox.FormattingEnabled = true;
            this.ShipIDCombobox.Location = new System.Drawing.Point(0, 33);
            this.ShipIDCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipIDCombobox.Name = "ShipIDCombobox";
            this.ShipIDCombobox.Size = new System.Drawing.Size(391, 32);
            this.ShipIDCombobox.TabIndex = 13;
            this.ShipIDCombobox.SelectedIndexChanged += new System.EventHandler(this.ShipIDCombobox_SelectedIndexChanged);
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentUpdateToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(1640, 28);
            this.MenuStrip.TabIndex = 14;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // documentUpdateToolStripMenuItem
            // 
            this.documentUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocumentStripMenuItem});
            this.documentUpdateToolStripMenuItem.Name = "documentUpdateToolStripMenuItem";
            this.documentUpdateToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.documentUpdateToolStripMenuItem.Text = "DocumentUpdate";
            // 
            // DocumentStripMenuItem
            // 
            this.DocumentStripMenuItem.Name = "DocumentStripMenuItem";
            this.DocumentStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.DocumentStripMenuItem.Text = "Update";
            this.DocumentStripMenuItem.Click += new System.EventHandler(this.DocumentStripMenuItem_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Drawing_MasterTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp5.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // drawing_MasterTableAdapter
            // 
            this.drawing_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // drawing_MasterBindingSource
            // 
            this.drawing_MasterBindingSource.DataMember = "Drawing_Master";
            this.drawing_MasterBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // drawing_MasterDataGridView
            // 
            this.drawing_MasterDataGridView.AutoGenerateColumns = false;
            this.drawing_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drawing_MasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10});
            this.drawing_MasterDataGridView.DataSource = this.drawing_MasterBindingSource;
            this.drawing_MasterDataGridView.Location = new System.Drawing.Point(391, 31);
            this.drawing_MasterDataGridView.Name = "drawing_MasterDataGridView";
            this.drawing_MasterDataGridView.RowTemplate.Height = 21;
            this.drawing_MasterDataGridView.Size = new System.Drawing.Size(1237, 517);
            this.drawing_MasterDataGridView.TabIndex = 15;
            this.drawing_MasterDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Drawing_MasterDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 63;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BLOBPath";
            this.dataGridViewTextBoxColumn8.HeaderText = "BLOBPath";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 83;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BLOBFileName";
            this.dataGridViewTextBoxColumn9.HeaderText = "BLOBFileName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 108;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Part";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ListNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "ListNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DrawingNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "DrawingNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DrawingName";
            this.dataGridViewTextBoxColumn6.HeaderText = "DrawingName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 69;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UploadDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "UploadDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 550);
            this.Controls.Add(this.drawing_MasterDataGridView);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ShipIDCombobox);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RemoveFilterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawing_MasterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button RemoveFilterButton;
        private System.Windows.Forms.ComboBox ShipIDCombobox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem documentUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocumentStripMenuItem;
        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private AZUREDBDataSetTableAdapters.Drawing_MasterTableAdapter drawing_MasterTableAdapter;
        private System.Windows.Forms.BindingSource drawing_MasterBindingSource;
        private System.Windows.Forms.DataGridView drawing_MasterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

