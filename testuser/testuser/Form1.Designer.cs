namespace testuser
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
            this.dataExchangeButton = new System.Windows.Forms.Button();
            this.dataExchange_feeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagirdfee = new testuser.UserControl1();
            this.datacomentgird = new testuser.UserControl3();
            this.ComentcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addComentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeComentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataexchange = new testuser.UserControl2();
            this.GridViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectedRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataExchange_Comment = new System.Windows.Forms.Button();
            this.CommentAdd = new System.Windows.Forms.Button();
            this.CommentRemoveButton = new System.Windows.Forms.Button();
            this.Nonbajet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aZUREDBDataSet = new testuser.AZUREDBDataSet();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeTableAdapter = new testuser.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager = new testuser.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchange_CommentTableAdapter = new testuser.AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter();
            this.dataExchange_feeTableAdapter = new testuser.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.dataExchange_CommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllDataGridViewShow_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShipcomboBox = new System.Windows.Forms.ComboBox();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.BackMonthButton = new System.Windows.Forms.Button();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.ship_Master_TBTableAdapter = new testuser.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.panel1.SuspendLayout();
            this.ComentcontextMenu.SuspendLayout();
            this.GridViewContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExchangeButton
            // 
            this.dataExchangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataExchangeButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataExchangeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataExchangeButton.Location = new System.Drawing.Point(-1, 193);
            this.dataExchangeButton.Name = "dataExchangeButton";
            this.dataExchangeButton.Size = new System.Drawing.Size(239, 45);
            this.dataExchangeButton.TabIndex = 0;
            this.dataExchangeButton.Text = "DataExchangeShow";
            this.dataExchangeButton.UseVisualStyleBackColor = false;
            this.dataExchangeButton.Click += new System.EventHandler(this.DataExchangeButton_Click);
            // 
            // dataExchange_feeButton
            // 
            this.dataExchange_feeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataExchange_feeButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataExchange_feeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataExchange_feeButton.Location = new System.Drawing.Point(-1, 262);
            this.dataExchange_feeButton.Name = "dataExchange_feeButton";
            this.dataExchange_feeButton.Size = new System.Drawing.Size(239, 45);
            this.dataExchange_feeButton.TabIndex = 1;
            this.dataExchange_feeButton.Text = "DataExchangeFeeShow";
            this.dataExchange_feeButton.UseVisualStyleBackColor = false;
            this.dataExchange_feeButton.Click += new System.EventHandler(this.DataExchange_feeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagirdfee);
            this.panel1.Controls.Add(this.datacomentgird);
            this.panel1.Controls.Add(this.dataexchange);
            this.panel1.Location = new System.Drawing.Point(238, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 574);
            this.panel1.TabIndex = 4;
            // 
            // datagirdfee
            // 
            this.datagirdfee.Location = new System.Drawing.Point(0, 0);
            this.datagirdfee.Name = "datagirdfee";
            this.datagirdfee.Size = new System.Drawing.Size(723, 577);
            this.datagirdfee.TabIndex = 3;
            // 
            // datacomentgird
            // 
            this.datacomentgird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datacomentgird.ContextMenuStrip = this.ComentcontextMenu;
            this.datacomentgird.Location = new System.Drawing.Point(0, 0);
            this.datacomentgird.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.datacomentgird.Name = "datacomentgird";
            this.datacomentgird.Size = new System.Drawing.Size(721, 574);
            this.datacomentgird.TabIndex = 2;
            // 
            // ComentcontextMenu
            // 
            this.ComentcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComentToolStripMenuItem,
            this.removeComentToolStripMenuItem});
            this.ComentcontextMenu.Name = "contextMenuStrip1";
            this.ComentcontextMenu.Size = new System.Drawing.Size(171, 48);
            this.ComentcontextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ComentcontextMenu_Opening);
            // 
            // addComentToolStripMenuItem
            // 
            this.addComentToolStripMenuItem.Name = "addComentToolStripMenuItem";
            this.addComentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addComentToolStripMenuItem.Text = "AddComent";
            // 
            // removeComentToolStripMenuItem
            // 
            this.removeComentToolStripMenuItem.Name = "removeComentToolStripMenuItem";
            this.removeComentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeComentToolStripMenuItem.Text = "RemoveComent";
            // 
            // dataexchange
            // 
            this.dataexchange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataexchange.ContextMenuStrip = this.GridViewContextMenu;
            this.dataexchange.Location = new System.Drawing.Point(0, 0);
            this.dataexchange.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataexchange.Name = "dataexchange";
            this.dataexchange.Size = new System.Drawing.Size(721, 574);
            this.dataexchange.TabIndex = 1;
            // 
            // GridViewContextMenu
            // 
            this.GridViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectedRemoveToolStripMenuItem,
            this.RemoveFilterToolStripMenuItem});
            this.GridViewContextMenu.Name = "contextMenuStrip1";
            this.GridViewContextMenu.Size = new System.Drawing.Size(175, 48);
            this.GridViewContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // SelectedRemoveToolStripMenuItem
            // 
            this.SelectedRemoveToolStripMenuItem.Name = "SelectedRemoveToolStripMenuItem";
            this.SelectedRemoveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.SelectedRemoveToolStripMenuItem.Text = "SelectedRemove";
            this.SelectedRemoveToolStripMenuItem.Click += new System.EventHandler(this.SelectedRemmoveToolStripMenuItem_Click);
            // 
            // RemoveFilterToolStripMenuItem
            // 
            this.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem";
            this.RemoveFilterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.RemoveFilterToolStripMenuItem.Text = "RemoveFilter";
            this.RemoveFilterToolStripMenuItem.Click += new System.EventHandler(this.RemoveFilterToolStripMenuItem_Click);
            // 
            // dataExchange_Comment
            // 
            this.dataExchange_Comment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataExchange_Comment.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataExchange_Comment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataExchange_Comment.Location = new System.Drawing.Point(0, 331);
            this.dataExchange_Comment.Name = "dataExchange_Comment";
            this.dataExchange_Comment.Size = new System.Drawing.Size(239, 45);
            this.dataExchange_Comment.TabIndex = 58;
            this.dataExchange_Comment.Text = "DataexchangeCommentShow";
            this.dataExchange_Comment.UseVisualStyleBackColor = false;
            this.dataExchange_Comment.Click += new System.EventHandler(this.DataExchange_Comment_Click);
            // 
            // CommentAdd
            // 
            this.CommentAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CommentAdd.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic);
            this.CommentAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CommentAdd.Location = new System.Drawing.Point(-1, 482);
            this.CommentAdd.Name = "CommentAdd";
            this.CommentAdd.Size = new System.Drawing.Size(239, 45);
            this.CommentAdd.TabIndex = 59;
            this.CommentAdd.Text = "CommentAdd";
            this.CommentAdd.UseVisualStyleBackColor = false;
            this.CommentAdd.Click += new System.EventHandler(this.CommentAdd_Click);
            // 
            // CommentRemoveButton
            // 
            this.CommentRemoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CommentRemoveButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic);
            this.CommentRemoveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CommentRemoveButton.Location = new System.Drawing.Point(-1, 533);
            this.CommentRemoveButton.Name = "CommentRemoveButton";
            this.CommentRemoveButton.Size = new System.Drawing.Size(239, 45);
            this.CommentRemoveButton.TabIndex = 60;
            this.CommentRemoveButton.Text = "CommentRemove";
            this.CommentRemoveButton.UseVisualStyleBackColor = false;
            this.CommentRemoveButton.Click += new System.EventHandler(this.CommentRemoveButton_Click);
            // 
            // Nonbajet
            // 
            this.Nonbajet.AutoSize = true;
            this.Nonbajet.Font = new System.Drawing.Font("メイリオ", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nonbajet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nonbajet.Location = new System.Drawing.Point(-4, 1);
            this.Nonbajet.Name = "Nonbajet";
            this.Nonbajet.Size = new System.Drawing.Size(141, 28);
            this.Nonbajet.TabIndex = 61;
            this.Nonbajet.Text = "NonBajetItem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testuser.Properties.Resources.テムマリタイム1;
            this.pictureBox1.Location = new System.Drawing.Point(135, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            this.dataExchangeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchangeTableAdapter
            // 
            this.dataExchangeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_CommentTableAdapter = this.dataExchange_CommentTableAdapter;
            this.tableAdapterManager.DataExchange_feeTableAdapter = this.dataExchange_feeTableAdapter;
            this.tableAdapterManager.DataExchangeTableAdapter = this.dataExchangeTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = testuser.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataExchange_CommentTableAdapter
            // 
            this.dataExchange_CommentTableAdapter.ClearBeforeFill = true;
            // 
            // dataExchange_feeTableAdapter
            // 
            this.dataExchange_feeTableAdapter.ClearBeforeFill = true;
            // 
            // dataExchange_CommentBindingSource
            // 
            this.dataExchange_CommentBindingSource.DataMember = "DataExchange_Comment";
            this.dataExchange_CommentBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchange_feeBindingSource
            // 
            this.dataExchange_feeBindingSource.DataMember = "DataExchange_fee";
            this.dataExchange_feeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // AllDataGridViewShow_button
            // 
            this.AllDataGridViewShow_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllDataGridViewShow_button.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllDataGridViewShow_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AllDataGridViewShow_button.Location = new System.Drawing.Point(0, 400);
            this.AllDataGridViewShow_button.Name = "AllDataGridViewShow_button";
            this.AllDataGridViewShow_button.Size = new System.Drawing.Size(239, 45);
            this.AllDataGridViewShow_button.TabIndex = 63;
            this.AllDataGridViewShow_button.Text = "AllDataGridViewShow";
            this.AllDataGridViewShow_button.UseVisualStyleBackColor = false;
            this.AllDataGridViewShow_button.Click += new System.EventHandler(this.AllDataGridViewShowbutton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(0, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(0, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = " ";
            // 
            // ShipcomboBox
            // 
            this.ShipcomboBox.DataSource = this.shipMasterTBBindingSource;
            this.ShipcomboBox.DisplayMember = "PresentName";
            this.ShipcomboBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShipcomboBox.FormattingEnabled = true;
            this.ShipcomboBox.Location = new System.Drawing.Point(1, 89);
            this.ShipcomboBox.Name = "ShipcomboBox";
            this.ShipcomboBox.Size = new System.Drawing.Size(229, 28);
            this.ShipcomboBox.TabIndex = 1;
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextMonthButton.Location = new System.Drawing.Point(192, 123);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(35, 28);
            this.NextMonthButton.TabIndex = 12;
            this.NextMonthButton.TabStop = false;
            this.NextMonthButton.Text = ">";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // BackMonthButton
            // 
            this.BackMonthButton.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMonthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackMonthButton.Location = new System.Drawing.Point(153, 123);
            this.BackMonthButton.Name = "BackMonthButton";
            this.BackMonthButton.Size = new System.Drawing.Size(35, 28);
            this.BackMonthButton.TabIndex = 3;
            this.BackMonthButton.TabStop = false;
            this.BackMonthButton.Text = "<";
            this.BackMonthButton.UseVisualStyleBackColor = true;
            this.BackMonthButton.Click += new System.EventHandler(this.BackMonthButton_Click);
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MonthTextBox.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MonthTextBox.Location = new System.Drawing.Point(2, 123);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(145, 28);
            this.MonthTextBox.TabIndex = 2;
            this.MonthTextBox.TabStop = false;
            this.MonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 579);
            this.Controls.Add(this.BackMonthButton);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.ShipcomboBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllDataGridViewShow_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Nonbajet);
            this.Controls.Add(this.CommentRemoveButton);
            this.Controls.Add(this.CommentAdd);
            this.Controls.Add(this.dataExchange_Comment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataExchange_feeButton);
            this.Controls.Add(this.dataExchangeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ComentcontextMenu.ResumeLayout(false);
            this.GridViewContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dataExchangeButton;
        private System.Windows.Forms.Button dataExchange_feeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dataExchange_Comment;
        private System.Windows.Forms.Button CommentAdd;
        private System.Windows.Forms.Button CommentRemoveButton;
        private System.Windows.Forms.Label Nonbajet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter dataExchange_CommentTableAdapter;
        private System.Windows.Forms.BindingSource dataExchange_CommentBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private System.Windows.Forms.Button AllDataGridViewShow_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip GridViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectedRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveFilterToolStripMenuItem;
        public System.Windows.Forms.ComboBox ShipcomboBox;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button BackMonthButton;
        public System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.ContextMenuStrip ComentcontextMenu;
        private System.Windows.Forms.ToolStripMenuItem addComentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeComentToolStripMenuItem;
        private UserControl3 datacomentgird;
        private UserControl2 dataexchange;
        private UserControl1 datagirdfee;
    }
}

