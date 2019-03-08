namespace WindowsFormsApp2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet2 = new WindowsFormsApp2.AZUREDBDataSet2();
            this.tableAdapterManager = new WindowsFormsApp2.AZUREDBDataSet2TableAdapters.TableAdapterManager();
            this.ship_Master_TBTableAdapter = new WindowsFormsApp2.AZUREDBDataSet2TableAdapters.Ship_Master_TBTableAdapter();
            this.ship_Master_TBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter1 = new WindowsFormsApp2.AZUREDBDataSet3TableAdapters.Ship_Master_TBTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp2.AZUREDBDataSet3TableAdapters.TableAdapterManager();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.aZUREDBDataSet3 = new WindowsFormsApp2.AZUREDBDataSet3();
            this.ship_Master_TBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aZUREDBDataSet1 = new WindowsFormsApp2.AZUREDBDataSet1();
            this.workmastershipTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workmaster_ship_TBTableAdapter = new WindowsFormsApp2.AZUREDBDataSet1TableAdapters.workmaster_ship_TBTableAdapter();
            this.blobReport1 = new WindowsFormsApp2.BlobReport();
            this.companyMember1 = new WindowsFormsApp2.CompanyMember();
            this.Shipmaster = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CompanyMember = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CompanyMaster = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BlobReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AzureList = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SelectionShip = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.todaytext = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyMaster1 = new WindowsFormsApp2.CompanyMaster();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workmastershipTBBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet2;
            // 
            // aZUREDBDataSet2
            // 
            this.aZUREDBDataSet2.DataSetName = "AZUREDBDataSet2";
            this.aZUREDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BLOBreportTableAdapter = null;
            this.tableAdapterManager.COMPANY_MASTERTableAdapter = null;
            this.tableAdapterManager.COMPANY_MEMBERTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.AZUREDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // ship_Master_TBBindingSource1
            // 
            this.ship_Master_TBBindingSource1.DataMember = "Ship_Master_TB";
            // 
            // ship_Master_TBTableAdapter1
            // 
            this.ship_Master_TBTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp2.AZUREDBDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aZUREDBDataSet3
            // 
            this.aZUREDBDataSet3.DataSetName = "AZUREDBDataSet3";
            this.aZUREDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ship_Master_TBBindingSource2
            // 
            this.ship_Master_TBBindingSource2.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource2.DataSource = this.aZUREDBDataSet3;
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet3;
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workmastershipTBBindingSource
            // 
            this.workmastershipTBBindingSource.DataMember = "workmaster_ship_TB";
            this.workmastershipTBBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // workmaster_ship_TBTableAdapter
            // 
            this.workmaster_ship_TBTableAdapter.ClearBeforeFill = true;
            // 
            // blobReport1
            // 
            this.blobReport1.AutoSize = true;
            this.blobReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.blobReport1.Location = new System.Drawing.Point(223, 3);
            this.blobReport1.Name = "blobReport1";
            this.blobReport1.Size = new System.Drawing.Size(1356, 882);
            this.blobReport1.TabIndex = 1;
            // 
            // companyMember1
            // 
            this.companyMember1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.companyMember1.Location = new System.Drawing.Point(223, 0);
            this.companyMember1.Name = "companyMember1";
            this.companyMember1.Size = new System.Drawing.Size(1324, 885);
            this.companyMember1.TabIndex = 2;
            // 
            // Shipmaster
            // 
            this.Shipmaster.BackColor = System.Drawing.Color.Transparent;
            this.Shipmaster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Shipmaster.BackgroundImage")));
            this.Shipmaster.ButtonText = "Shipmaster";
            this.Shipmaster.ButtonTextMarginLeft = 0;
            this.Shipmaster.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Shipmaster.DisabledFillColor = System.Drawing.Color.Gray;
            this.Shipmaster.DisabledForecolor = System.Drawing.Color.White;
            this.Shipmaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Shipmaster.ForeColor = System.Drawing.Color.White;
            this.Shipmaster.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Shipmaster.IconPadding = 10;
            this.Shipmaster.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Shipmaster.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Shipmaster.IdleBorderRadius = 1;
            this.Shipmaster.IdleBorderThickness = 0;
            this.Shipmaster.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.Shipmaster.IdleIconLeftImage = null;
            this.Shipmaster.IdleIconRightImage = null;
            this.Shipmaster.Location = new System.Drawing.Point(0, 816);
            this.Shipmaster.Name = "Shipmaster";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Shipmaster.onHoverState = stateProperties1;
            this.Shipmaster.Size = new System.Drawing.Size(220, 69);
            this.Shipmaster.TabIndex = 0;
            this.Shipmaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shipmaster.Click += new System.EventHandler(this.Shipmaster_Click);
            // 
            // CompanyMember
            // 
            this.CompanyMember.BackColor = System.Drawing.Color.Transparent;
            this.CompanyMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompanyMember.BackgroundImage")));
            this.CompanyMember.ButtonText = "CompanyMember";
            this.CompanyMember.ButtonTextMarginLeft = 0;
            this.CompanyMember.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.CompanyMember.DisabledFillColor = System.Drawing.Color.Gray;
            this.CompanyMember.DisabledForecolor = System.Drawing.Color.White;
            this.CompanyMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CompanyMember.ForeColor = System.Drawing.Color.White;
            this.CompanyMember.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CompanyMember.IconPadding = 10;
            this.CompanyMember.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CompanyMember.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.CompanyMember.IdleBorderRadius = 1;
            this.CompanyMember.IdleBorderThickness = 0;
            this.CompanyMember.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.CompanyMember.IdleIconLeftImage = null;
            this.CompanyMember.IdleIconRightImage = null;
            this.CompanyMember.Location = new System.Drawing.Point(0, 747);
            this.CompanyMember.Name = "CompanyMember";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.CompanyMember.onHoverState = stateProperties2;
            this.CompanyMember.Size = new System.Drawing.Size(220, 69);
            this.CompanyMember.TabIndex = 1;
            this.CompanyMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompanyMember.Click += new System.EventHandler(this.CompanyMember_Click);
            // 
            // CompanyMaster
            // 
            this.CompanyMaster.BackColor = System.Drawing.Color.Transparent;
            this.CompanyMaster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompanyMaster.BackgroundImage")));
            this.CompanyMaster.ButtonText = "CompanyMaster";
            this.CompanyMaster.ButtonTextMarginLeft = 0;
            this.CompanyMaster.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.CompanyMaster.DisabledFillColor = System.Drawing.Color.Gray;
            this.CompanyMaster.DisabledForecolor = System.Drawing.Color.White;
            this.CompanyMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CompanyMaster.ForeColor = System.Drawing.Color.White;
            this.CompanyMaster.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CompanyMaster.IconPadding = 10;
            this.CompanyMaster.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CompanyMaster.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.CompanyMaster.IdleBorderRadius = 1;
            this.CompanyMaster.IdleBorderThickness = 0;
            this.CompanyMaster.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.CompanyMaster.IdleIconLeftImage = null;
            this.CompanyMaster.IdleIconRightImage = null;
            this.CompanyMaster.Location = new System.Drawing.Point(0, 678);
            this.CompanyMaster.Name = "CompanyMaster";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.CompanyMaster.onHoverState = stateProperties3;
            this.CompanyMaster.Size = new System.Drawing.Size(220, 69);
            this.CompanyMaster.TabIndex = 3;
            this.CompanyMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompanyMaster.Click += new System.EventHandler(this.CompanyMaster_Click);
            // 
            // BlobReport
            // 
            this.BlobReport.BackColor = System.Drawing.Color.Transparent;
            this.BlobReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlobReport.BackgroundImage")));
            this.BlobReport.ButtonText = "BlobReport";
            this.BlobReport.ButtonTextMarginLeft = 0;
            this.BlobReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BlobReport.DisabledFillColor = System.Drawing.Color.Gray;
            this.BlobReport.DisabledForecolor = System.Drawing.Color.White;
            this.BlobReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BlobReport.ForeColor = System.Drawing.Color.White;
            this.BlobReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BlobReport.IconPadding = 10;
            this.BlobReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BlobReport.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.BlobReport.IdleBorderRadius = 1;
            this.BlobReport.IdleBorderThickness = 0;
            this.BlobReport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.BlobReport.IdleIconLeftImage = null;
            this.BlobReport.IdleIconRightImage = null;
            this.BlobReport.Location = new System.Drawing.Point(0, 609);
            this.BlobReport.Name = "BlobReport";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.BlobReport.onHoverState = stateProperties4;
            this.BlobReport.Size = new System.Drawing.Size(220, 69);
            this.BlobReport.TabIndex = 2;
            this.BlobReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BlobReport.Click += new System.EventHandler(this.BlobReport_Click);
            // 
            // AzureList
            // 
            this.AzureList.AutoSize = true;
            this.AzureList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AzureList.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.AzureList.ForeColor = System.Drawing.Color.LightGray;
            this.AzureList.Location = new System.Drawing.Point(51, 38);
            this.AzureList.Name = "AzureList";
            this.AzureList.Size = new System.Drawing.Size(133, 30);
            this.AzureList.TabIndex = 6;
            this.AzureList.Text = "TemmAzure";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 121);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(220, 42);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 3);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(217, 32);
            this.bunifuSeparator2.TabIndex = 7;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-3, 577);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(223, 32);
            this.bunifuSeparator3.TabIndex = 4;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(-2, 260);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(222, 32);
            this.bunifuSeparator4.TabIndex = 8;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // SelectionShip
            // 
            this.SelectionShip.AutoSize = true;
            this.SelectionShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectionShip.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.SelectionShip.ForeColor = System.Drawing.Color.LightGray;
            this.SelectionShip.Location = new System.Drawing.Point(35, 295);
            this.SelectionShip.Name = "SelectionShip";
            this.SelectionShip.Size = new System.Drawing.Size(149, 30);
            this.SelectionShip.TabIndex = 9;
            this.SelectionShip.Text = "SelectionShip";
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(0, 378);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(217, 32);
            this.bunifuSeparator5.TabIndex = 10;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // todaytext
            // 
            this.todaytext.AcceptsReturn = false;
            this.todaytext.AcceptsTab = false;
            this.todaytext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.todaytext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.todaytext.BackColor = System.Drawing.Color.Transparent;
            this.todaytext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todaytext.BackgroundImage")));
            this.todaytext.BorderColorActive = System.Drawing.Color.Black;
            this.todaytext.BorderColorDisabled = System.Drawing.Color.White;
            this.todaytext.BorderColorHover = System.Drawing.Color.AliceBlue;
            this.todaytext.BorderColorIdle = System.Drawing.Color.AliceBlue;
            this.todaytext.BorderRadius = 1;
            this.todaytext.BorderThickness = 2;
            this.todaytext.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.todaytext.DefaultFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todaytext.DefaultText = "";
            this.todaytext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.todaytext.ForeColor = System.Drawing.Color.White;
            this.todaytext.HideSelection = true;
            this.todaytext.IconLeft = null;
            this.todaytext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.todaytext.IconPadding = 10;
            this.todaytext.IconRight = null;
            this.todaytext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.todaytext.Location = new System.Drawing.Point(4, 89);
            this.todaytext.MaxLength = 32767;
            this.todaytext.MinimumSize = new System.Drawing.Size(100, 35);
            this.todaytext.Modified = false;
            this.todaytext.Name = "todaytext";
            this.todaytext.PasswordChar = '\0';
            this.todaytext.ReadOnly = true;
            this.todaytext.SelectedText = "";
            this.todaytext.SelectionLength = 0;
            this.todaytext.SelectionStart = 0;
            this.todaytext.ShortcutsEnabled = true;
            this.todaytext.Size = new System.Drawing.Size(216, 35);
            this.todaytext.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.todaytext.TabIndex = 1;
            this.todaytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.todaytext.TextMarginLeft = 5;
            this.todaytext.TextPlaceholder = "";
            this.todaytext.UseSystemPasswordChar = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.bunifuDropdown1.BorderRadius = 1;
            this.bunifuDropdown1.Color = System.Drawing.SystemColors.ButtonFace;
            this.bunifuDropdown1.DataSource = this.ship_Master_TBBindingSource;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DisplayMember = "PresentName";
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = false;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.GhostWhite;
            this.bunifuDropdown1.Location = new System.Drawing.Point(2, 328);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(215, 32);
            this.bunifuDropdown1.TabIndex = 15;
            this.bunifuDropdown1.Text = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.bunifuDropdown1);
            this.panel2.Controls.Add(this.todaytext);
            this.panel2.Controls.Add(this.bunifuSeparator5);
            this.panel2.Controls.Add(this.SelectionShip);
            this.panel2.Controls.Add(this.bunifuSeparator4);
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.AzureList);
            this.panel2.Controls.Add(this.BlobReport);
            this.panel2.Controls.Add(this.CompanyMaster);
            this.panel2.Controls.Add(this.CompanyMember);
            this.panel2.Controls.Add(this.Shipmaster);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 885);
            this.panel2.TabIndex = 0;
            // 
            // companyMaster1
            // 
            this.companyMaster1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.companyMaster1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.companyMaster1.Location = new System.Drawing.Point(223, 0);
            this.companyMaster1.Name = "companyMaster1";
            this.companyMaster1.Size = new System.Drawing.Size(1344, 882);
            this.companyMaster1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1565, 921);
            this.Controls.Add(this.companyMaster1);
            this.Controls.Add(this.companyMember1);
            this.Controls.Add(this.blobReport1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workmastershipTBBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AZUREDBDataSet2 aZUREDBDataSet2;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private AZUREDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSet2TableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource1;
        private AZUREDBDataSet3TableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter1;
        private AZUREDBDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private AZUREDBDataSet3 aZUREDBDataSet3;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource2;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private AZUREDBDataSet1 aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource workmastershipTBBindingSource;
        private AZUREDBDataSet1TableAdapters.workmaster_ship_TBTableAdapter workmaster_ship_TBTableAdapter;
        private BlobReport blobReport1;
        private CompanyMember companyMember1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Shipmaster;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CompanyMember;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CompanyMaster;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton BlobReport;
        private System.Windows.Forms.Label AzureList;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Label SelectionShip;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox todaytext;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Panel panel2;
        private CompanyMaster companyMaster1;
    }
}

