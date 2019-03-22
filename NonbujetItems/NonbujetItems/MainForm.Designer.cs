namespace NonbujetItems
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
            this.aZUREDBDataSet = new NonbujetItems.AZUREDBDataSet();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeTableAdapter = new NonbujetItems.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager = new NonbujetItems.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchange_feeTableAdapter = new NonbujetItems.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.dataExchange_feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_CommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_CommentTableAdapter = new NonbujetItems.AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter();
            this.dataExchangeButton = new System.Windows.Forms.Button();
            this.dataExchange_feeButton = new System.Windows.Forms.Button();
            this.dataExchange_CommentButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataExchange1 = new NonbujetItems.dataExchange();
            this.dataExchange_fee1 = new NonbujetItems.dataExchange_fee();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.DataExchange_CommentTableAdapter = null;
            this.tableAdapterManager.DataExchange_feeTableAdapter = this.dataExchange_feeTableAdapter;
            this.tableAdapterManager.DataExchangeTableAdapter = this.dataExchangeTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NonbujetItems.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataExchange_feeTableAdapter
            // 
            this.dataExchange_feeTableAdapter.ClearBeforeFill = true;
            // 
            // dataExchange_feeBindingSource
            // 
            this.dataExchange_feeBindingSource.DataMember = "DataExchange_fee";
            this.dataExchange_feeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchange_CommentBindingSource
            // 
            this.dataExchange_CommentBindingSource.DataMember = "DataExchange_Comment";
            this.dataExchange_CommentBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchange_CommentTableAdapter
            // 
            this.dataExchange_CommentTableAdapter.ClearBeforeFill = true;
            // 
            // dataExchangeButton
            // 
            this.dataExchangeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataExchangeButton.Location = new System.Drawing.Point(-4, 134);
            this.dataExchangeButton.Name = "dataExchangeButton";
            this.dataExchangeButton.Size = new System.Drawing.Size(315, 58);
            this.dataExchangeButton.TabIndex = 55;
            this.dataExchangeButton.Text = "DataexchangeShow";
            this.dataExchangeButton.UseVisualStyleBackColor = true;
            this.dataExchangeButton.Click += new System.EventHandler(this.Dataexchange_Click);
            // 
            // dataExchange_feeButton
            // 
            this.dataExchange_feeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataExchange_feeButton.Location = new System.Drawing.Point(-4, 198);
            this.dataExchange_feeButton.Name = "dataExchange_feeButton";
            this.dataExchange_feeButton.Size = new System.Drawing.Size(315, 58);
            this.dataExchange_feeButton.TabIndex = 56;
            this.dataExchange_feeButton.Text = "DataexchangeFeeShow";
            this.dataExchange_feeButton.UseVisualStyleBackColor = true;
            this.dataExchange_feeButton.Click += new System.EventHandler(this.DataexchangeFeeShow_Click);
            // 
            // dataExchange_CommentButton
            // 
            this.dataExchange_CommentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataExchange_CommentButton.Location = new System.Drawing.Point(-4, 262);
            this.dataExchange_CommentButton.Name = "dataExchange_CommentButton";
            this.dataExchange_CommentButton.Size = new System.Drawing.Size(315, 56);
            this.dataExchange_CommentButton.TabIndex = 57;
            this.dataExchange_CommentButton.Text = "DataexchangeCommentShow";
            this.dataExchange_CommentButton.UseVisualStyleBackColor = true;
            this.dataExchange_CommentButton.Click += new System.EventHandler(this.DataexchangeCommentShow_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dataExchange_fee1);
            this.panel4.Controls.Add(this.dataExchange1);
            this.panel4.Location = new System.Drawing.Point(314, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 525);
            this.panel4.TabIndex = 58;
            // 
            // dataExchange1
            // 
            this.dataExchange1.Location = new System.Drawing.Point(3, 3);
            this.dataExchange1.Name = "dataExchange1";
            this.dataExchange1.Size = new System.Drawing.Size(463, 430);
            this.dataExchange1.TabIndex = 0;
            // 
            // dataExchange_fee1
            // 
            this.dataExchange_fee1.Location = new System.Drawing.Point(0, 0);
            this.dataExchange_fee1.Name = "dataExchange_fee1";
            this.dataExchange_fee1.Size = new System.Drawing.Size(559, 332);
            this.dataExchange_fee1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataExchange_CommentButton);
            this.Controls.Add(this.dataExchangeButton);
            this.Controls.Add(this.dataExchange_feeButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource;
        private System.Windows.Forms.BindingSource dataExchange_CommentBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter dataExchange_CommentTableAdapter;
        private System.Windows.Forms.Button dataExchangeButton;
        private System.Windows.Forms.Button dataExchange_feeButton;
        private System.Windows.Forms.Button dataExchange_CommentButton;
        private System.Windows.Forms.Panel panel4;
        private dataExchange_fee dataExchange_fee1;
        private dataExchange dataExchange1;
    }
}

