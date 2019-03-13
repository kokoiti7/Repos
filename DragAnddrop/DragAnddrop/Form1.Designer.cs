namespace DragAnddrop
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
            this.Mailtranslated = new System.Windows.Forms.TextBox();
            this.aZUREDBDataSet1 = new DragAnddrop.AZUREDBDataSet1();
            this.lO_CapacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lO_CapacityTableAdapter = new DragAnddrop.AZUREDBDataSet1TableAdapters.LO_CapacityTableAdapter();
            this.tableAdapterManager = new DragAnddrop.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.aZUREDBDataSet2 = new DragAnddrop.AZUREDBDataSet2();
            this.lO_CapacityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lO_CapacityTableAdapter1 = new DragAnddrop.AZUREDBDataSet2TableAdapters.LO_CapacityTableAdapter();
            this.tableAdapterManager1 = new DragAnddrop.AZUREDBDataSet2TableAdapters.TableAdapterManager();
            this.lO_CapacityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lO_CapacityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lO_CapacityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lO_CapacityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Mailtranslated
            // 
            this.Mailtranslated.AllowDrop = true;
            this.Mailtranslated.Location = new System.Drawing.Point(12, 637);
            this.Mailtranslated.Multiline = true;
            this.Mailtranslated.Name = "Mailtranslated";
            this.Mailtranslated.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Mailtranslated.Size = new System.Drawing.Size(1423, 97);
            this.Mailtranslated.TabIndex = 0;
            this.Mailtranslated.DragDrop += new System.Windows.Forms.DragEventHandler(this.Mailtranslated_DragDrop);
            this.Mailtranslated.DragEnter += new System.Windows.Forms.DragEventHandler(this.Mailtranslated_DragEnter);
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lO_CapacityBindingSource
            // 
            this.lO_CapacityBindingSource.DataMember = "LO_Capacity";
            this.lO_CapacityBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // lO_CapacityTableAdapter
            // 
            this.lO_CapacityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LO_CapacityTableAdapter = this.lO_CapacityTableAdapter;
            this.tableAdapterManager.UpdateOrder = DragAnddrop.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1099, 554);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 78);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1276, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aZUREDBDataSet2
            // 
            this.aZUREDBDataSet2.DataSetName = "AZUREDBDataSet2";
            this.aZUREDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lO_CapacityBindingSource1
            // 
            this.lO_CapacityBindingSource1.DataMember = "LO_Capacity";
            this.lO_CapacityBindingSource1.DataSource = this.aZUREDBDataSet2;
            // 
            // lO_CapacityTableAdapter1
            // 
            this.lO_CapacityTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LO_CapacityTableAdapter = this.lO_CapacityTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = DragAnddrop.AZUREDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lO_CapacityDataGridView
            // 
            this.lO_CapacityDataGridView.AutoGenerateColumns = false;
            this.lO_CapacityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lO_CapacityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.lO_CapacityDataGridView.DataSource = this.lO_CapacityBindingSource1;
            this.lO_CapacityDataGridView.Location = new System.Drawing.Point(0, 39);
            this.lO_CapacityDataGridView.Name = "lO_CapacityDataGridView";
            this.lO_CapacityDataGridView.RowTemplate.Height = 21;
            this.lO_CapacityDataGridView.Size = new System.Drawing.Size(1457, 508);
            this.lO_CapacityDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRESENT NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "PRESENT NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "M/E Cylinder oil Tank";
            this.dataGridViewTextBoxColumn3.HeaderText = "M/E Cylinder oil Tank";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LS Cylinder oil Tank";
            this.dataGridViewTextBoxColumn4.HeaderText = "LS Cylinder oil Tank";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "M/E System oil Tank";
            this.dataGridViewTextBoxColumn5.HeaderText = "M/E System oil Tank";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "D/E system oil Tank";
            this.dataGridViewTextBoxColumn6.HeaderText = "D/E system oil Tank";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "M/E LO sett tank No_1";
            this.dataGridViewTextBoxColumn7.HeaderText = "M/E LO sett tank No_1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "M/E LO sett No_2";
            this.dataGridViewTextBoxColumn8.HeaderText = "M/E LO sett No_2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "D/E LO sett tank No_1";
            this.dataGridViewTextBoxColumn9.HeaderText = "D/E LO sett tank No_1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "D/E LO sett tank No_2";
            this.dataGridViewTextBoxColumn10.HeaderText = "D/E LO sett tank No_2";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "M/E Sump tank";
            this.dataGridViewTextBoxColumn11.HeaderText = "M/E Sump tank";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Waste oil tank";
            this.dataGridViewTextBoxColumn12.HeaderText = "Waste oil tank";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Bilge primary tank";
            this.dataGridViewTextBoxColumn13.HeaderText = "Bilge primary tank";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Bilge tank";
            this.dataGridViewTextBoxColumn14.HeaderText = "Bilge tank";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 754);
            this.Controls.Add(this.lO_CapacityDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Mailtranslated);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lO_CapacityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lO_CapacityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lO_CapacityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mailtranslated;
        private AZUREDBDataSet1 aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource lO_CapacityBindingSource;
        private AZUREDBDataSet1TableAdapters.LO_CapacityTableAdapter lO_CapacityTableAdapter;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
        private AZUREDBDataSet2 aZUREDBDataSet2;
        private System.Windows.Forms.BindingSource lO_CapacityBindingSource1;
        private AZUREDBDataSet2TableAdapters.LO_CapacityTableAdapter lO_CapacityTableAdapter1;
        private AZUREDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView lO_CapacityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
    }
}

