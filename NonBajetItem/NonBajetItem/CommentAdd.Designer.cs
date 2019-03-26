namespace NonBajetItem
{
    partial class CommentAdd
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
            System.Windows.Forms.Label editdateTimeLabel;
            System.Windows.Forms.Label commentLabel;
            this.aZUREDBDataSet = new NonBajetItem.AZUREDBDataSet();
            this.dataExchange_CommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_CommentTableAdapter = new NonBajetItem.AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter();
            this.tableAdapterManager = new NonBajetItem.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.editdateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.AddComentButton = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            editdateTimeLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).BeginInit();
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
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            iDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iDLabel.Location = new System.Drawing.Point(13, 46);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(33, 23);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_CommentBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(148, 50);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 19);
            this.iDTextBox.TabIndex = 2;
            // 
            // editdateTimeLabel
            // 
            editdateTimeLabel.AutoSize = true;
            editdateTimeLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            editdateTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            editdateTimeLabel.Location = new System.Drawing.Point(13, 72);
            editdateTimeLabel.Name = "editdateTimeLabel";
            editdateTimeLabel.Size = new System.Drawing.Size(119, 23);
            editdateTimeLabel.TabIndex = 3;
            editdateTimeLabel.Text = "Editdate Time:";
            // 
            // editdateTimeDateTimePicker
            // 
            this.editdateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchange_CommentBindingSource, "EditdateTime", true));
            this.editdateTimeDateTimePicker.Location = new System.Drawing.Point(148, 75);
            this.editdateTimeDateTimePicker.Name = "editdateTimeDateTimePicker";
            this.editdateTimeDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.editdateTimeDateTimePicker.TabIndex = 4;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            commentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            commentLabel.Location = new System.Drawing.Point(13, 253);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(87, 23);
            commentLabel.TabIndex = 5;
            commentLabel.Text = "Comment:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_CommentBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(148, 141);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 135);
            this.commentTextBox.TabIndex = 6;
            // 
            // AddComentButton
            // 
            this.AddComentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddComentButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddComentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddComentButton.Location = new System.Drawing.Point(210, 310);
            this.AddComentButton.Name = "AddComentButton";
            this.AddComentButton.Size = new System.Drawing.Size(138, 36);
            this.AddComentButton.TabIndex = 7;
            this.AddComentButton.Text = "AddComment";
            this.AddComentButton.UseVisualStyleBackColor = false;
            this.AddComentButton.Click += new System.EventHandler(this.AddComentButton_Click);
            // 
            // CommentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 378);
            this.Controls.Add(this.AddComentButton);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(editdateTimeLabel);
            this.Controls.Add(this.editdateTimeDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Name = "CommentAdd";
            this.Text = "CommentAdd";
            this.Load += new System.EventHandler(this.CommentAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchange_CommentBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchange_CommentTableAdapter dataExchange_CommentTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker editdateTimeDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button AddComentButton;
    }
}