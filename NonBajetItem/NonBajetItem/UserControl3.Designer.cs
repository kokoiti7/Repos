﻿namespace NonBajetItem
{
    partial class UserControl3
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
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.dataExchange_CommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_CommentTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchange_CommentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_CommentTableAdapter = this.dataExchange_CommentTableAdapter;
            this.tableAdapterManager.DataExchange_feeTableAdapter = null;
            this.tableAdapterManager.DataExchangeTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataExchange_CommentDataGridView
            // 
            this.dataExchange_CommentDataGridView.AutoGenerateColumns = false;
            this.dataExchange_CommentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExchange_CommentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataExchange_CommentDataGridView.DataSource = this.dataExchange_CommentBindingSource;
            this.dataExchange_CommentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataExchange_CommentDataGridView.Name = "dataExchange_CommentDataGridView";
            this.dataExchange_CommentDataGridView.RowTemplate.Height = 21;
            this.dataExchange_CommentDataGridView.Size = new System.Drawing.Size(770, 574);
            this.dataExchange_CommentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EditdateTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "EditdateTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CommnetSpare";
            this.dataGridViewTextBoxColumn4.HeaderText = "CommnetSpare";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataExchange_CommentDataGridView);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(770, 574);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchange_CommentBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter dataExchange_CommentTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataExchange_CommentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
