namespace WindowsFormsApp2
{
    partial class CompanyMember
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMember));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.workmaster_ship_TBTableAdapter1 = new WindowsFormsApp2.AZUREDBDataSet1TableAdapters.workmaster_ship_TBTableAdapter();
            this.Delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Download = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Upload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Imaegbutoon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.aZUREDBDataSet1 = new WindowsFormsApp2.AZUREDBDataSet1();
            this.imagetestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagetestTableAdapter = new WindowsFormsApp2.AZUREDBDataSet1TableAdapters.ImagetestTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.imagetestDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CompanyMember";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 23);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(129, 21);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // workmaster_ship_TBTableAdapter1
            // 
            this.workmaster_ship_TBTableAdapter1.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.ButtonText = "Delete";
            this.Delete.ButtonTextMarginLeft = 0;
            this.Delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Delete.DisabledFillColor = System.Drawing.Color.Gray;
            this.Delete.DisabledForecolor = System.Drawing.Color.White;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Delete.IconPadding = 10;
            this.Delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Delete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Delete.IdleBorderRadius = 1;
            this.Delete.IdleBorderThickness = 0;
            this.Delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Delete.IdleIconLeftImage = null;
            this.Delete.IdleIconRightImage = null;
            this.Delete.Location = new System.Drawing.Point(617, 0);
            this.Delete.Name = "Delete";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.Delete.onHoverState = stateProperties5;
            this.Delete.Size = new System.Drawing.Size(210, 94);
            this.Delete.TabIndex = 22;
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Download
            // 
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Download.BackgroundImage")));
            this.Download.ButtonText = "Download";
            this.Download.ButtonTextMarginLeft = 0;
            this.Download.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Download.DisabledFillColor = System.Drawing.Color.Gray;
            this.Download.DisabledForecolor = System.Drawing.Color.White;
            this.Download.ForeColor = System.Drawing.Color.White;
            this.Download.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Download.IconPadding = 10;
            this.Download.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Download.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Download.IdleBorderRadius = 1;
            this.Download.IdleBorderThickness = 0;
            this.Download.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Download.IdleIconLeftImage = null;
            this.Download.IdleIconRightImage = null;
            this.Download.Location = new System.Drawing.Point(401, 0);
            this.Download.Name = "Download";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.Download.onHoverState = stateProperties6;
            this.Download.Size = new System.Drawing.Size(210, 94);
            this.Download.TabIndex = 23;
            this.Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Transparent;
            this.Upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload.BackgroundImage")));
            this.Upload.ButtonText = "Upload";
            this.Upload.ButtonTextMarginLeft = 0;
            this.Upload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Upload.DisabledFillColor = System.Drawing.Color.Gray;
            this.Upload.DisabledForecolor = System.Drawing.Color.White;
            this.Upload.ForeColor = System.Drawing.Color.White;
            this.Upload.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Upload.IconPadding = 10;
            this.Upload.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Upload.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Upload.IdleBorderRadius = 1;
            this.Upload.IdleBorderThickness = 0;
            this.Upload.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Upload.IdleIconLeftImage = null;
            this.Upload.IdleIconRightImage = null;
            this.Upload.Location = new System.Drawing.Point(185, 0);
            this.Upload.Name = "Upload";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.Upload.onHoverState = stateProperties7;
            this.Upload.Size = new System.Drawing.Size(210, 94);
            this.Upload.TabIndex = 21;
            this.Upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Imaegbutoon
            // 
            this.Imaegbutoon.BackColor = System.Drawing.Color.Transparent;
            this.Imaegbutoon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imaegbutoon.BackgroundImage")));
            this.Imaegbutoon.ButtonText = "Imaegbutoon";
            this.Imaegbutoon.ButtonTextMarginLeft = 0;
            this.Imaegbutoon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Imaegbutoon.DisabledFillColor = System.Drawing.Color.Gray;
            this.Imaegbutoon.DisabledForecolor = System.Drawing.Color.White;
            this.Imaegbutoon.ForeColor = System.Drawing.Color.White;
            this.Imaegbutoon.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Imaegbutoon.IconPadding = 10;
            this.Imaegbutoon.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Imaegbutoon.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Imaegbutoon.IdleBorderRadius = 1;
            this.Imaegbutoon.IdleBorderThickness = 0;
            this.Imaegbutoon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Imaegbutoon.IdleIconLeftImage = null;
            this.Imaegbutoon.IdleIconRightImage = null;
            this.Imaegbutoon.Location = new System.Drawing.Point(833, 0);
            this.Imaegbutoon.Name = "Imaegbutoon";
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 1;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.Imaegbutoon.onHoverState = stateProperties8;
            this.Imaegbutoon.Size = new System.Drawing.Size(210, 94);
            this.Imaegbutoon.TabIndex = 26;
            this.Imaegbutoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Imaegbutoon.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagetestBindingSource
            // 
            this.imagetestBindingSource.DataMember = "Imagetest";
            this.imagetestBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // imagetestTableAdapter
            // 
            this.imagetestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImagetestTableAdapter = this.imagetestTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workmaster_ship_TBTableAdapter = null;
            this.tableAdapterManager.workmaster_TBTableAdapter = null;
            // 
            // imagetestDataGridView
            // 
            this.imagetestDataGridView.AutoGenerateColumns = false;
            this.imagetestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagetestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.imagetestDataGridView.DataSource = this.imagetestBindingSource;
            this.imagetestDataGridView.Location = new System.Drawing.Point(0, 366);
            this.imagetestDataGridView.Name = "imagetestDataGridView";
            this.imagetestDataGridView.RowTemplate.Height = 21;
            this.imagetestDataGridView.Size = new System.Drawing.Size(1169, 220);
            this.imagetestDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn2.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "filename";
            this.dataGridViewTextBoxColumn3.HeaderText = "filename";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // CompanyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.imagetestDataGridView);
            this.Controls.Add(this.Imaegbutoon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Upload);
            this.Name = "CompanyMember";
            this.Size = new System.Drawing.Size(1424, 825);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagetestDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Delete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Download;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Upload;
        private AZUREDBDataSet1TableAdapters.workmaster_ship_TBTableAdapter workmaster_ship_TBTableAdapter1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Imaegbutoon;
        private AZUREDBDataSet1 aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource imagetestBindingSource;
        private AZUREDBDataSet1TableAdapters.ImagetestTableAdapter imagetestTableAdapter;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView imagetestDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
