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
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUserName
            // 
            this.LoginUserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginUserName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginUserName.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.LoginUserName.Location = new System.Drawing.Point(159, 135);
            this.LoginUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(392, 31);
            this.LoginUserName.TabIndex = 0;
            // 
            // PleaseInputName
            // 
            this.PleaseInputName.AutoSize = true;
            this.PleaseInputName.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold);
            this.PleaseInputName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PleaseInputName.Location = new System.Drawing.Point(154, 101);
            this.PleaseInputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PleaseInputName.Name = "PleaseInputName";
            this.PleaseInputName.Size = new System.Drawing.Size(86, 28);
            this.PleaseInputName.TabIndex = 3;
            this.PleaseInputName.Text = "Sign In";
            // 
            // Logi
            // 
            this.Logi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logi.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Logi.Location = new System.Drawing.Point(416, 301);
            this.Logi.Name = "Logi";
            this.Logi.Size = new System.Drawing.Size(135, 73);
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
            this.PasswordText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PasswordText.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.PasswordText.Location = new System.Drawing.Point(159, 229);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(392, 30);
            this.PasswordText.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cancel.Location = new System.Drawing.Point(263, 301);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(135, 73);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Checked = true;
            this.RememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberMe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RememberMe.Location = new System.Drawing.Point(17, 347);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(130, 27);
            this.RememberMe.TabIndex = 5;
            this.RememberMe.Text = "RememberMe";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "PassWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::CrewApp2.Properties.Resources.テムマリタイム2;
            this.pictureBox1.Location = new System.Drawing.Point(23, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Temm Maritime Co.,Ltd.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Logi);
            this.Controls.Add(this.PleaseInputName);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(595, 433);
            this.MinimumSize = new System.Drawing.Size(595, 433);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}