namespace CrewApp2
{
    partial class zommgrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aZUREDBDataSet = new CrewApp2.AZUREDBDataSet();
            this.crew_Master1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_Master1TableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_Master1TableAdapter();
            this.tableAdapterManager = new CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.crew_Master1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_Master1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_Master1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crew_Master1BindingSource
            // 
            this.crew_Master1BindingSource.DataMember = "Crew_Master1";
            this.crew_Master1BindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // crew_Master1TableAdapter
            // 
            this.crew_Master1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Crew_ApplicationTableAdapter = null;
            this.tableAdapterManager.Crew_ConfidencialReportTableAdapter = null;
            this.tableAdapterManager.Crew_MasterTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crew_Master1DataGridView
            // 
            this.crew_Master1DataGridView.AutoGenerateColumns = false;
            this.crew_Master1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crew_Master1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.crew_Master1DataGridView.DataSource = this.crew_Master1BindingSource;
            this.crew_Master1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crew_Master1DataGridView.Location = new System.Drawing.Point(0, 0);
            this.crew_Master1DataGridView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.crew_Master1DataGridView.Name = "crew_Master1DataGridView";
            this.crew_Master1DataGridView.RowTemplate.Height = 200;
            this.crew_Master1DataGridView.Size = new System.Drawing.Size(1016, 686);
            this.crew_Master1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasterID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasterID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 104;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CREWINGNote";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "CREWINGNote";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 500;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 500;
            // 
            // zommgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 686);
            this.Controls.Add(this.crew_Master1DataGridView);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "zommgrid";
            this.Text = "zommgrid";
            this.Load += new System.EventHandler(this.zommgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_Master1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_Master1DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource crew_Master1BindingSource;
        private AZUREDBDataSetTableAdapters.Crew_Master1TableAdapter crew_Master1TableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView crew_Master1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}