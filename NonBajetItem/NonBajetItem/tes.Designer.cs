namespace NonBajetItem
{
    partial class tes
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
            System.Windows.Forms.Label presentNameLabel;
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.presentNameComboBox = new System.Windows.Forms.ComboBox();
            presentNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_CommentTableAdapter = null;
            this.tableAdapterManager.DataExchange_feeTableAdapter = null;
            this.tableAdapterManager.DataExchangeTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // presentNameLabel
            // 
            presentNameLabel.AutoSize = true;
            presentNameLabel.Location = new System.Drawing.Point(56, 57);
            presentNameLabel.Name = "presentNameLabel";
            presentNameLabel.Size = new System.Drawing.Size(79, 12);
            presentNameLabel.TabIndex = 66;
            presentNameLabel.Text = "Present Name:";
            // 
            // presentNameComboBox
            // 
            this.presentNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ship_Master_TBBindingSource, "PresentName", true));
            this.presentNameComboBox.DataSource = this.aZUREDBDataSet;
            this.presentNameComboBox.DisplayMember = "Ship_Master_TB.PresentName";
            this.presentNameComboBox.FormattingEnabled = true;
            this.presentNameComboBox.Location = new System.Drawing.Point(141, 54);
            this.presentNameComboBox.Name = "presentNameComboBox";
            this.presentNameComboBox.Size = new System.Drawing.Size(121, 20);
            this.presentNameComboBox.TabIndex = 67;
            // 
            // tes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Controls.Add(presentNameLabel);
            this.Controls.Add(this.presentNameComboBox);
            this.Name = "tes";
            this.Text = "tes";
            this.Load += new System.EventHandler(this.tes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox presentNameComboBox;
    }
}