namespace CrewApp2
{
    partial class AddPerson
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
            System.Windows.Forms.Label masterIDLabel;
            System.Windows.Forms.Label topeverIDLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label presentRANKLabel;
            this.aZUREDBDataSet = new CrewApp2.AZUREDBDataSet();
            this.crew_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_MasterTableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter();
            this.tableAdapterManager = new CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.masterIDTextBox = new System.Windows.Forms.TextBox();
            this.topeverIDTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddPersonName = new System.Windows.Forms.Button();
            this.presentRANKComboBox = new System.Windows.Forms.ComboBox();
            this.crew_MasterDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            masterIDLabel = new System.Windows.Forms.Label();
            topeverIDLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            presentRANKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold);
            masterIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            masterIDLabel.Location = new System.Drawing.Point(206, 354);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(119, 28);
            masterIDLabel.TabIndex = 0;
            masterIDLabel.Text = "Master ID:";
            masterIDLabel.Visible = false;
            // 
            // topeverIDLabel
            // 
            topeverIDLabel.AutoSize = true;
            topeverIDLabel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            topeverIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            topeverIDLabel.Location = new System.Drawing.Point(16, 27);
            topeverIDLabel.Name = "topeverIDLabel";
            topeverIDLabel.Size = new System.Drawing.Size(317, 28);
            topeverIDLabel.TabIndex = 2;
            topeverIDLabel.Text = "Topever ID(compulsory field):";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold);
            fullNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            fullNameLabel.Location = new System.Drawing.Point(16, 109);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(122, 28);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold);
            dOBLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dOBLabel.Location = new System.Drawing.Point(16, 186);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(64, 28);
            dOBLabel.TabIndex = 6;
            dOBLabel.Text = "DOB:";
            // 
            // presentRANKLabel
            // 
            presentRANKLabel.AutoSize = true;
            presentRANKLabel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold);
            presentRANKLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            presentRANKLabel.Location = new System.Drawing.Point(16, 269);
            presentRANKLabel.Name = "presentRANKLabel";
            presentRANKLabel.Size = new System.Drawing.Size(160, 28);
            presentRANKLabel.TabIndex = 41;
            presentRANKLabel.Text = "Present RANK:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crew_MasterBindingSource
            // 
            this.crew_MasterBindingSource.DataMember = "Crew_Master";
            this.crew_MasterBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // crew_MasterTableAdapter
            // 
            this.crew_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Crew_ApplicationTableAdapter = null;
            this.tableAdapterManager.Crew_ConfidencialReportTableAdapter = null;
            this.tableAdapterManager.Crew_MasterTableAdapter = this.crew_MasterTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // masterIDTextBox
            // 
            this.masterIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "MasterID", true));
            this.masterIDTextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.masterIDTextBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.masterIDTextBox.Location = new System.Drawing.Point(190, 402);
            this.masterIDTextBox.Name = "masterIDTextBox";
            this.masterIDTextBox.Size = new System.Drawing.Size(28, 31);
            this.masterIDTextBox.TabIndex = 36;
            this.masterIDTextBox.Visible = false;
            // 
            // topeverIDTextBox
            // 
            this.topeverIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "TopeverID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.topeverIDTextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.topeverIDTextBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.topeverIDTextBox.Location = new System.Drawing.Point(21, 58);
            this.topeverIDTextBox.MaxLength = 6;
            this.topeverIDTextBox.Name = "topeverIDTextBox";
            this.topeverIDTextBox.Size = new System.Drawing.Size(304, 31);
            this.topeverIDTextBox.TabIndex = 37;
            this.topeverIDTextBox.TextChanged += new System.EventHandler(this.topeverIDTextBox_TextChanged);
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.crew_MasterBindingSource, "DOB", true));
            this.dOBDateTimePicker.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.dOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBDateTimePicker.Location = new System.Drawing.Point(21, 217);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(304, 31);
            this.dOBDateTimePicker.TabIndex = 39;
            // 
            // AddPersonName
            // 
            this.AddPersonName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddPersonName.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddPersonName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddPersonName.Location = new System.Drawing.Point(63, 385);
            this.AddPersonName.Name = "AddPersonName";
            this.AddPersonName.Size = new System.Drawing.Size(262, 62);
            this.AddPersonName.TabIndex = 41;
            this.AddPersonName.Text = "AddName";
            this.AddPersonName.UseVisualStyleBackColor = false;
            this.AddPersonName.Click += new System.EventHandler(this.AddPersonName_Click);
            // 
            // presentRANKComboBox
            // 
            this.presentRANKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "PresentRANK", true));
            this.presentRANKComboBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.presentRANKComboBox.FormattingEnabled = true;
            this.presentRANKComboBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.presentRANKComboBox.Items.AddRange(new object[] {
            "Master",
            "C/O",
            "2/O",
            "3/O",
            "C/E",
            "1AE",
            "2AE",
            "3AE",
            "BSN",
            "A/B",
            "O/S",
            "OLR",
            "WPR",
            "C/CK",
            "M/M",
            "D/C",
            "E/C",
            "ELC",
            "R/O"});
            this.presentRANKComboBox.Location = new System.Drawing.Point(21, 300);
            this.presentRANKComboBox.Name = "presentRANKComboBox";
            this.presentRANKComboBox.Size = new System.Drawing.Size(304, 32);
            this.presentRANKComboBox.TabIndex = 40;
            // 
            // crew_MasterDataGridView
            // 
            this.crew_MasterDataGridView.AutoGenerateColumns = false;
            this.crew_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crew_MasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.crew_MasterDataGridView.DataSource = this.crew_MasterBindingSource;
            this.crew_MasterDataGridView.Location = new System.Drawing.Point(166, 437);
            this.crew_MasterDataGridView.Name = "crew_MasterDataGridView";
            this.crew_MasterDataGridView.RowTemplate.Height = 21;
            this.crew_MasterDataGridView.Size = new System.Drawing.Size(10, 10);
            this.crew_MasterDataGridView.TabIndex = 42;
            this.crew_MasterDataGridView.TabStop = false;
            this.crew_MasterDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasterID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasterID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TopeverID";
            this.dataGridViewTextBoxColumn2.HeaderText = "TopeverID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PresentRANK";
            this.dataGridViewTextBoxColumn5.HeaderText = "PresentRANK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Licence";
            this.dataGridViewTextBoxColumn6.HeaderText = "Licence";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ShipName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ShipName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Emberk";
            this.dataGridViewTextBoxColumn9.HeaderText = "Emberk";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dismberk";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dismberk";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NextAvailability";
            this.dataGridViewTextBoxColumn11.HeaderText = "NextAvailability";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "onVacation";
            this.dataGridViewCheckBoxColumn1.HeaderText = "onVacation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "LeftFormCompany";
            this.dataGridViewCheckBoxColumn2.HeaderText = "LeftFormCompany";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CREWINGNote";
            this.dataGridViewTextBoxColumn12.HeaderText = "CREWINGNote";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MRNNote";
            this.dataGridViewTextBoxColumn13.HeaderText = "MRNNote";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TECHNote";
            this.dataGridViewTextBoxColumn14.HeaderText = "TECHNote";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GENNote";
            this.dataGridViewTextBoxColumn15.HeaderText = "GENNote";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "dateSpare";
            this.dataGridViewTextBoxColumn16.HeaderText = "dateSpare";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "nvSpare";
            this.dataGridViewTextBoxColumn17.HeaderText = "nvSpare";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "intSpare";
            this.dataGridViewTextBoxColumn18.HeaderText = "intSpare";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "FullName", true));
            this.fullNameTextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
            this.fullNameTextBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.fullNameTextBox.Location = new System.Drawing.Point(21, 140);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(304, 31);
            this.fullNameTextBox.TabIndex = 38;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(345, 468);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.crew_MasterDataGridView);
            this.Controls.Add(presentRANKLabel);
            this.Controls.Add(this.presentRANKComboBox);
            this.Controls.Add(this.AddPersonName);
            this.Controls.Add(masterIDLabel);
            this.Controls.Add(this.masterIDTextBox);
            this.Controls.Add(topeverIDLabel);
            this.Controls.Add(this.topeverIDTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBDateTimePicker);
            this.MaximumSize = new System.Drawing.Size(361, 506);
            this.MinimumSize = new System.Drawing.Size(361, 506);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPerson_FormClosed);
            this.Load += new System.EventHandler(this.AddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource crew_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter crew_MasterTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox masterIDTextBox;
        private System.Windows.Forms.TextBox topeverIDTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.Button AddPersonName;
        private System.Windows.Forms.ComboBox presentRANKComboBox;
        private System.Windows.Forms.DataGridView crew_MasterDataGridView;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}