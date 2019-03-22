namespace CrewApp2
{
    partial class InputNote
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
            this.CrewwingText = new System.Windows.Forms.TextBox();
            this.SaveTxt = new System.Windows.Forms.Button();
            this.aZUREDBDataSet = new CrewApp2.AZUREDBDataSet();
            this.crew_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_MasterTableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter();
            this.tableAdapterManager = new CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.OldTextBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CrewwingText
            // 
            this.CrewwingText.Location = new System.Drawing.Point(3, 192);
            this.CrewwingText.Multiline = true;
            this.CrewwingText.Name = "CrewwingText";
            this.CrewwingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CrewwingText.Size = new System.Drawing.Size(556, 112);
            this.CrewwingText.TabIndex = 1;
            // 
            // SaveTxt
            // 
            this.SaveTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveTxt.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveTxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveTxt.Location = new System.Drawing.Point(424, 310);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(135, 62);
            this.SaveTxt.TabIndex = 16;
            this.SaveTxt.Text = "SaveText";
            this.SaveTxt.UseVisualStyleBackColor = false;
            this.SaveTxt.Click += new System.EventHandler(this.Savetxt_Click);
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
            // OldTextBox
            // 
            this.OldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crew_MasterBindingSource, "CREWINGNote", true));
            this.OldTextBox.Location = new System.Drawing.Point(3, 47);
            this.OldTextBox.Multiline = true;
            this.OldTextBox.Name = "OldTextBox";
            this.OldTextBox.ReadOnly = true;
            this.OldTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OldTextBox.Size = new System.Drawing.Size(556, 107);
            this.OldTextBox.TabIndex = 2;
            this.OldTextBox.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("メイリオ", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.username.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.username.Location = new System.Drawing.Point(12, 165);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(172, 24);
            this.username.TabIndex = 30;
            this.username.Text = "OverWriteSaveText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "CrewWingNote NowText";
            // 
            // InputNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(562, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.OldTextBox);
            this.Controls.Add(this.SaveTxt);
            this.Controls.Add(this.CrewwingText);
            this.MaximumSize = new System.Drawing.Size(578, 411);
            this.MinimumSize = new System.Drawing.Size(578, 411);
            this.Name = "InputNote";
            this.Text = "InputNote";
            this.Load += new System.EventHandler(this.InputNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CrewwingText;
        private System.Windows.Forms.Button SaveTxt;
        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource crew_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter crew_MasterTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox OldTextBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
    }
}