﻿namespace WindowsFormsApp2
{
    partial class CompanyMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMaster));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.workmaster_ship_TBTableAdapter1 = new WindowsFormsApp2.AZUREDBDataSet1TableAdapters.workmaster_ship_TBTableAdapter();
            this.Delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Download = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Upload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "CompanyMaster";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 23);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(129, 21);
            this.bunifuSeparator1.TabIndex = 25;
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
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.Delete.onHoverState = stateProperties4;
            this.Delete.Size = new System.Drawing.Size(210, 94);
            this.Delete.TabIndex = 28;
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
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.Download.onHoverState = stateProperties5;
            this.Download.Size = new System.Drawing.Size(210, 94);
            this.Download.TabIndex = 29;
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
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.Upload.onHoverState = stateProperties6;
            this.Upload.Size = new System.Drawing.Size(210, 94);
            this.Upload.TabIndex = 27;
            this.Upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Upload);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CompanyMaster";
            this.Size = new System.Drawing.Size(1059, 773);
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
    }
}
