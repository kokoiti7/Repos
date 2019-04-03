namespace ShipInvoice
{
    partial class QuotationUpdate
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label qTNIDLabel;
            System.Windows.Forms.Label fileNameLabel;
            this.aZUREDBDataSet1 = new ShipInvoice.AZUREDBDataSet1();
            this.quotation_DocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_DocumentsTableAdapter = new ShipInvoice.AZUREDBDataSet1TableAdapters.Quotation_DocumentsTableAdapter();
            this.tableAdapterManager = new ShipInvoice.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.qTNIDTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            qTNIDLabel = new System.Windows.Forms.Label();
            fileNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(34, 71);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(18, 12);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // qTNIDLabel
            // 
            qTNIDLabel.AutoSize = true;
            qTNIDLabel.Location = new System.Drawing.Point(34, 137);
            qTNIDLabel.Name = "qTNIDLabel";
            qTNIDLabel.Size = new System.Drawing.Size(41, 12);
            qTNIDLabel.TabIndex = 3;
            qTNIDLabel.Text = "QTNID:";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new System.Drawing.Point(34, 205);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new System.Drawing.Size(59, 12);
            fileNameLabel.TabIndex = 5;
            fileNameLabel.Text = "File Name:";
            // 
            // aZUREDBDataSet1
            // 
            this.aZUREDBDataSet1.DataSetName = "AZUREDBDataSet1";
            this.aZUREDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quotation_DocumentsBindingSource
            // 
            this.quotation_DocumentsBindingSource.DataMember = "Quotation_Documents";
            this.quotation_DocumentsBindingSource.DataSource = this.aZUREDBDataSet1;
            // 
            // quotation_DocumentsTableAdapter
            // 
            this.quotation_DocumentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Quotation_DocumentsTableAdapter = this.quotation_DocumentsTableAdapter;
            this.tableAdapterManager.Quotation_DocumentTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShipInvoice.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quotation_DocumentsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(99, 68);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(245, 19);
            this.iDTextBox.TabIndex = 2;
            // 
            // qTNIDTextBox
            // 
            this.qTNIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quotation_DocumentsBindingSource, "QTNID", true));
            this.qTNIDTextBox.Location = new System.Drawing.Point(99, 130);
            this.qTNIDTextBox.Name = "qTNIDTextBox";
            this.qTNIDTextBox.Size = new System.Drawing.Size(245, 19);
            this.qTNIDTextBox.TabIndex = 4;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quotation_DocumentsBindingSource, "FileName", true));
            this.fileNameTextBox.Location = new System.Drawing.Point(99, 202);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(245, 19);
            this.fileNameTextBox.TabIndex = 6;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(238, 257);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 47);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuotationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 316);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(qTNIDLabel);
            this.Controls.Add(this.qTNIDTextBox);
            this.Controls.Add(fileNameLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Name = "QuotationUpdate";
            this.Text = "QuotationUpdate";
            this.Load += new System.EventHandler(this.QuotationUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DocumentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet1 aZUREDBDataSet1;
        private System.Windows.Forms.BindingSource quotation_DocumentsBindingSource;
        private AZUREDBDataSet1TableAdapters.Quotation_DocumentsTableAdapter quotation_DocumentsTableAdapter;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox qTNIDTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button UpdateButton;
    }
}