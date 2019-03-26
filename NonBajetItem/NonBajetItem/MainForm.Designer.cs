namespace NonBajetItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.AllDataGridViewShow_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NonBajetItem = new System.Windows.Forms.Label();
            this.CommentRemoveButton = new System.Windows.Forms.Button();
            this.CommentAdd = new System.Windows.Forms.Button();
            this.dataExchange_Comment = new System.Windows.Forms.Button();
            this.addComentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComentcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeComentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataExchange_feeButton = new System.Windows.Forms.Button();
            this.dataExchangeButton = new System.Windows.Forms.Button();
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.dataExchangeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.dataExchange_CommentTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter();
            this.dataExchange_feeTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.ship_Master_TBTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_CommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datacomentgird = new NonBajetItem.UserControl3();
            this.dataexchange = new NonBajetItem.UserControl2();
            this.datagirdfee = new NonBajetItem.UserControl1();
            this.ComentcontextMenu.SuspendLayout();
            this.GridViewContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(2, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = " ";
            // 
            // AllDataGridViewShow_button
            // 
            this.AllDataGridViewShow_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllDataGridViewShow_button.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllDataGridViewShow_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AllDataGridViewShow_button.Location = new System.Drawing.Point(0, 305);
            this.AllDataGridViewShow_button.Name = "AllDataGridViewShow_button";
            this.AllDataGridViewShow_button.Size = new System.Drawing.Size(240, 45);
            this.AllDataGridViewShow_button.TabIndex = 74;
            this.AllDataGridViewShow_button.Text = "AllDataGridViewShow";
            this.AllDataGridViewShow_button.UseVisualStyleBackColor = false;
            this.AllDataGridViewShow_button.Click += new System.EventHandler(this.AllDataGridViewShow_button_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(2, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = " ";
            // 
            // NonBajetItem
            // 
            this.NonBajetItem.AutoSize = true;
            this.NonBajetItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NonBajetItem.Font = new System.Drawing.Font("メイリオ", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NonBajetItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NonBajetItem.Location = new System.Drawing.Point(3, 12);
            this.NonBajetItem.Name = "NonBajetItem";
            this.NonBajetItem.Size = new System.Drawing.Size(141, 28);
            this.NonBajetItem.TabIndex = 72;
            this.NonBajetItem.Text = "NonBajetItem";
            // 
            // CommentRemoveButton
            // 
            this.CommentRemoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CommentRemoveButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic);
            this.CommentRemoveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CommentRemoveButton.Location = new System.Drawing.Point(1, 541);
            this.CommentRemoveButton.Name = "CommentRemoveButton";
            this.CommentRemoveButton.Size = new System.Drawing.Size(239, 45);
            this.CommentRemoveButton.TabIndex = 71;
            this.CommentRemoveButton.Text = "CommentRemove";
            this.CommentRemoveButton.UseVisualStyleBackColor = false;
            this.CommentRemoveButton.Click += new System.EventHandler(this.CommentRemoveButton_Click);
            // 
            // CommentAdd
            // 
            this.CommentAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CommentAdd.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic);
            this.CommentAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CommentAdd.Location = new System.Drawing.Point(1, 452);
            this.CommentAdd.Name = "CommentAdd";
            this.CommentAdd.Size = new System.Drawing.Size(239, 45);
            this.CommentAdd.TabIndex = 70;
            this.CommentAdd.Text = "CommentAdd";
            this.CommentAdd.UseVisualStyleBackColor = false;
            this.CommentAdd.Click += new System.EventHandler(this.CommentAdd_Click);
            // 
            // dataExchange_Comment
            // 
            this.dataExchange_Comment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataExchange_Comment.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataExchange_Comment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataExchange_Comment.Location = new System.Drawing.Point(0, 236);
            this.dataExchange_Comment.Name = "dataExchange_Comment";
            this.dataExchange_Comment.Size = new System.Drawing.Size(240, 45);
            this.dataExchange_Comment.TabIndex = 69;
            this.dataExchange_Comment.Text = "DataexchangeCommentShow";
            this.dataExchange_Comment.UseVisualStyleBackColor = false;
            this.dataExchange_Comment.Click += new System.EventHandler(this.dataExchange_Comment_Click);
            // 
            // addComentToolStripMenuItem
            // 
            this.addComentToolStripMenuItem.Name = "addComentToolStripMenuItem";
            this.addComentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addComentToolStripMenuItem.Text = "AddComent";
            // 
            // ComentcontextMenu
            // 
            this.ComentcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComentToolStripMenuItem,
            this.removeComentToolStripMenuItem});
            this.ComentcontextMenu.Name = "contextMenuStrip1";
            this.ComentcontextMenu.Size = new System.Drawing.Size(171, 48);
            // 
            // removeComentToolStripMenuItem
            // 
            this.removeComentToolStripMenuItem.Name = "removeComentToolStripMenuItem";
            this.removeComentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeComentToolStripMenuItem.Text = "RemoveComent";
            // 
            // RemoveFilterToolStripMenuItem
            // 
            this.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem";
            this.RemoveFilterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.RemoveFilterToolStripMenuItem.Text = "RemoveFilter";
            // 
            // SelectedRemoveToolStripMenuItem
            // 
            this.SelectedRemoveToolStripMenuItem.Name = "SelectedRemoveToolStripMenuItem";
            this.SelectedRemoveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SelectedRemoveToolStripMenuItem.Text = "SelectedRemove";
            // 
            // GridViewContextMenu
            // 
            this.GridViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectedRemoveToolStripMenuItem,
            this.RemoveFilterToolStripMenuItem});
            this.GridViewContextMenu.Name = "contextMenuStrip1";
            this.GridViewContextMenu.Size = new System.Drawing.Size(175, 48);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datacomentgird);
            this.panel1.Controls.Add(this.dataexchange);
            this.panel1.Controls.Add(this.datagirdfee);
            this.panel1.Location = new System.Drawing.Point(243, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 574);
            this.panel1.TabIndex = 68;
            // 
            // dataExchange_feeButton
            // 
            this.dataExchange_feeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataExchange_feeButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataExchange_feeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataExchange_feeButton.Location = new System.Drawing.Point(1, 168);
            this.dataExchange_feeButton.Name = "dataExchange_feeButton";
            this.dataExchange_feeButton.Size = new System.Drawing.Size(239, 45);
            this.dataExchange_feeButton.TabIndex = 67;
            this.dataExchange_feeButton.Text = "DataExchangeFeeShow";
            this.dataExchange_feeButton.UseVisualStyleBackColor = false;
            this.dataExchange_feeButton.Click += new System.EventHandler(this.dataExchange_feeButton_Click);
            // 
            // dataExchangeButton
            // 
            this.dataExchangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataExchangeButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataExchangeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataExchangeButton.Location = new System.Drawing.Point(0, 100);
            this.dataExchangeButton.Name = "dataExchangeButton";
            this.dataExchangeButton.Size = new System.Drawing.Size(240, 45);
            this.dataExchangeButton.TabIndex = 66;
            this.dataExchangeButton.Text = "DataExchangeShow";
            this.dataExchangeButton.UseVisualStyleBackColor = false;
            this.dataExchangeButton.Click += new System.EventHandler(this.dataExchangeButton_Click);
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchangeTableAdapter
            // 
            this.dataExchangeTableAdapter.ClearBeforeFill = true;
            // 
            // dataExchange_CommentTableAdapter
            // 
            this.dataExchange_CommentTableAdapter.ClearBeforeFill = true;
            // 
            // dataExchange_feeTableAdapter
            // 
            this.dataExchange_feeTableAdapter.ClearBeforeFill = true;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NonBajetItem.Properties.Resources.テムマリタイム;
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            // 
            // dataExchange_feeBindingSource
            // 
            this.dataExchange_feeBindingSource.DataMember = "DataExchange_fee";
            // 
            // dataExchange_CommentBindingSource
            // 
            this.dataExchange_CommentBindingSource.DataMember = "DataExchange_Comment";
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            // 
            // datacomentgird
            // 
            this.datacomentgird.Location = new System.Drawing.Point(0, 0);
            this.datacomentgird.Name = "datacomentgird";
            this.datacomentgird.Size = new System.Drawing.Size(770, 574);
            this.datacomentgird.TabIndex = 2;
            // 
            // dataexchange
            // 
            this.dataexchange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataexchange.Location = new System.Drawing.Point(0, 0);
            this.dataexchange.Name = "dataexchange";
            this.dataexchange.Size = new System.Drawing.Size(767, 582);
            this.dataexchange.TabIndex = 1;
            // 
            // datagirdfee
            // 
            this.datagirdfee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagirdfee.Location = new System.Drawing.Point(0, 0);
            this.datagirdfee.Name = "datagirdfee";
            this.datagirdfee.Size = new System.Drawing.Size(770, 574);
            this.datagirdfee.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllDataGridViewShow_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NonBajetItem);
            this.Controls.Add(this.CommentRemoveButton);
            this.Controls.Add(this.CommentAdd);
            this.Controls.Add(this.dataExchange_Comment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataExchange_feeButton);
            this.Controls.Add(this.dataExchangeButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ComentcontextMenu.ResumeLayout(false);
            this.GridViewContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AllDataGridViewShow_button;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private System.Windows.Forms.BindingSource dataExchange_CommentBindingSource;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NonBajetItem;
        private System.Windows.Forms.Button CommentRemoveButton;
        private System.Windows.Forms.Button CommentAdd;
        private System.Windows.Forms.Button dataExchange_Comment;
        private System.Windows.Forms.ToolStripMenuItem addComentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ComentcontextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeComentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectedRemoveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip GridViewContextMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dataExchange_feeButton;
        private System.Windows.Forms.Button dataExchangeButton;
        private AZUREDBDataSet aZUREDBDataSet;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter dataExchange_CommentTableAdapter;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private UserControl3 datacomentgird;
        private UserControl2 dataexchange;
        private UserControl1 datagirdfee;
    }
}

