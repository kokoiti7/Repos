namespace CrewApp2
{
    partial class Login
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
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.PleaseInputName = new System.Windows.Forms.Label();
            this.Logi = new System.Windows.Forms.Button();
            this.aZUREDBDataSet = new CrewApp2.AZUREDBDataSet();
            this.crew_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crew_MasterTableAdapter = new CrewApp2.AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter();
            this.tableAdapterManager = new CrewApp2.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUserName
            // 
            this.LoginUserName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginUserName.Location = new System.Drawing.Point(19, 93);
            this.LoginUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(451, 31);
            this.LoginUserName.TabIndex = 0;
            // 
            // PleaseInputName
            // 
            this.PleaseInputName.AutoSize = true;
            this.PleaseInputName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PleaseInputName.Location = new System.Drawing.Point(15, 30);
            this.PleaseInputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PleaseInputName.Name = "PleaseInputName";
            this.PleaseInputName.Size = new System.Drawing.Size(196, 24);
            this.PleaseInputName.TabIndex = 3;
            this.PleaseInputName.Text = "Please Your Input Name";
            // 
            // Logi
            // 
            this.Logi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Logi.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logi.Location = new System.Drawing.Point(335, 219);
            this.Logi.Name = "Logi";
            this.Logi.Size = new System.Drawing.Size(135, 62);
            this.Logi.TabIndex = 2;
            this.Logi.Text = "Login";
            this.Logi.UseVisualStyleBackColor = false;
            this.Logi.Click += new System.EventHandler(this.Login_Click);
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
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(19, 146);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(451, 30);
            this.PasswordText.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cancel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel.Location = new System.Drawing.Point(182, 219);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(135, 62);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(486, 293);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.Logi);
            this.Controls.Add(this.PleaseInputName);
            this.Controls.Add(this.LoginUserName);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUserName;
        private System.Windows.Forms.Label PleaseInputName;
        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource crew_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Crew_MasterTableAdapter crew_MasterTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Logi;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button Cancel;
    }
}