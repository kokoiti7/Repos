namespace WindowsFormsApp3
{
    partial class Form3
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
            System.Windows.Forms.Label editdateTimeLabel;
            System.Windows.Forms.Label commentLabel;
            this.aZUREDBDataSet = new WindowsFormsApp3.AZUREDBDataSet1();
            this.dataExchange_CommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_CommentTableAdapter = new WindowsFormsApp3.AZUREDBDataSet1TableAdapters.DataExchange_CommentTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.AZUREDBDataSet1TableAdapters.TableAdapterManager();
            this.editdateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            editdateTimeLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editdateTimeLabel
            // 
            editdateTimeLabel.AutoSize = true;
            editdateTimeLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            editdateTimeLabel.Location = new System.Drawing.Point(22, 86);
            editdateTimeLabel.Name = "editdateTimeLabel";
            editdateTimeLabel.Size = new System.Drawing.Size(95, 18);
            editdateTimeLabel.TabIndex = 3;
            editdateTimeLabel.Text = "Editdate Time:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            commentLabel.Location = new System.Drawing.Point(46, 156);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(71, 18);
            commentLabel.TabIndex = 5;
            commentLabel.Text = "Comment:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet1";
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
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.AZUREDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editdateTimeDateTimePicker
            // 
            this.editdateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchange_CommentBindingSource, "EditdateTime", true));
            this.editdateTimeDateTimePicker.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.editdateTimeDateTimePicker.Location = new System.Drawing.Point(133, 81);
            this.editdateTimeDateTimePicker.Name = "editdateTimeDateTimePicker";
            this.editdateTimeDateTimePicker.Size = new System.Drawing.Size(266, 25);
            this.editdateTimeDateTimePicker.TabIndex = 4;
            this.editdateTimeDateTimePicker.ValueChanged += new System.EventHandler(this.editdateTimeDateTimePicker_ValueChanged);
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_CommentBindingSource, "Comment", true));
            this.commentTextBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.commentTextBox.Location = new System.Drawing.Point(133, 156);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(266, 266);
            this.commentTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(133, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 19);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(editdateTimeLabel);
            this.Controls.Add(this.editdateTimeDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_CommentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet1 aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchange_CommentBindingSource;
        private AZUREDBDataSet1TableAdapters.DataExchange_CommentTableAdapter dataExchange_CommentTableAdapter;
        private AZUREDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker editdateTimeDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox commentTextBox;
    }
}