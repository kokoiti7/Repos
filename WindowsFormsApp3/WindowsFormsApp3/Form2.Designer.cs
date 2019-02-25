namespace WindowsFormsApp3
{
    partial class Form2
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
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label monthGroupLabel1;
            System.Windows.Forms.Label shipnameLabel1;
            System.Windows.Forms.Label budjetbalanceLabel1;
            System.Windows.Forms.Label managementfeeLabel1;
            System.Windows.Forms.Label paymentDateLabel1;
            System.Windows.Forms.Label remarkLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.aZUREDBDataSet = new WindowsFormsApp3.AZUREDBDataSet();
            this.dataExchange_feeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchange_feeTableAdapter = new WindowsFormsApp3.AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.monthGroupDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipnameTextBox = new System.Windows.Forms.TextBox();
            this.budjetbalanceTextBox = new System.Windows.Forms.TextBox();
            this.managementfeeTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            iDLabel1 = new System.Windows.Forms.Label();
            monthGroupLabel1 = new System.Windows.Forms.Label();
            shipnameLabel1 = new System.Windows.Forms.Label();
            budjetbalanceLabel1 = new System.Windows.Forms.Label();
            managementfeeLabel1 = new System.Windows.Forms.Label();
            paymentDateLabel1 = new System.Windows.Forms.Label();
            remarkLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            iDLabel1.Location = new System.Drawing.Point(83, 40);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(27, 18);
            iDLabel1.TabIndex = 60;
            iDLabel1.Text = "ID:";
            // 
            // monthGroupLabel1
            // 
            monthGroupLabel1.AutoSize = true;
            monthGroupLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            monthGroupLabel1.Location = new System.Drawing.Point(29, 83);
            monthGroupLabel1.Name = "monthGroupLabel1";
            monthGroupLabel1.Size = new System.Drawing.Size(88, 18);
            monthGroupLabel1.TabIndex = 62;
            monthGroupLabel1.Text = "Month Group:";
            // 
            // shipnameLabel1
            // 
            shipnameLabel1.AutoSize = true;
            shipnameLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            shipnameLabel1.Location = new System.Drawing.Point(46, 125);
            shipnameLabel1.Name = "shipnameLabel1";
            shipnameLabel1.Size = new System.Drawing.Size(69, 18);
            shipnameLabel1.TabIndex = 66;
            shipnameLabel1.Text = "shipname:";
            // 
            // budjetbalanceLabel1
            // 
            budjetbalanceLabel1.AutoSize = true;
            budjetbalanceLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            budjetbalanceLabel1.Location = new System.Drawing.Point(24, 159);
            budjetbalanceLabel1.Name = "budjetbalanceLabel1";
            budjetbalanceLabel1.Size = new System.Drawing.Size(94, 18);
            budjetbalanceLabel1.TabIndex = 68;
            budjetbalanceLabel1.Text = "budjetbalance:";
            // 
            // managementfeeLabel1
            // 
            managementfeeLabel1.AutoSize = true;
            managementfeeLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            managementfeeLabel1.Location = new System.Drawing.Point(14, 194);
            managementfeeLabel1.Name = "managementfeeLabel1";
            managementfeeLabel1.Size = new System.Drawing.Size(107, 18);
            managementfeeLabel1.TabIndex = 70;
            managementfeeLabel1.Text = "Managementfee:";
            // 
            // paymentDateLabel1
            // 
            paymentDateLabel1.AutoSize = true;
            paymentDateLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            paymentDateLabel1.Location = new System.Drawing.Point(22, 235);
            paymentDateLabel1.Name = "paymentDateLabel1";
            paymentDateLabel1.Size = new System.Drawing.Size(97, 18);
            paymentDateLabel1.TabIndex = 72;
            paymentDateLabel1.Text = "Payment Date:";
            // 
            // remarkLabel1
            // 
            remarkLabel1.AutoSize = true;
            remarkLabel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            remarkLabel1.Location = new System.Drawing.Point(55, 271);
            remarkLabel1.Name = "remarkLabel1";
            remarkLabel1.Size = new System.Drawing.Size(59, 18);
            remarkLabel1.TabIndex = 74;
            remarkLabel1.Text = "Remark:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(123, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchange_feeBindingSource1
            // 
            this.dataExchange_feeBindingSource1.DataMember = "DataExchange_fee";
            this.dataExchange_feeBindingSource1.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchange_feeTableAdapter
            // 
            this.dataExchange_feeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_feeTableAdapter = this.dataExchange_feeTableAdapter;
            this.tableAdapterManager.DataExchangeTableAdapter = null;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource1, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(123, 42);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 19);
            this.iDTextBox.TabIndex = 61;
            // 
            // monthGroupDateTimePicker
            // 
            this.monthGroupDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchange_feeBindingSource1, "MonthGroup", true));
            this.monthGroupDateTimePicker.Location = new System.Drawing.Point(123, 83);
            this.monthGroupDateTimePicker.Name = "monthGroupDateTimePicker";
            this.monthGroupDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.monthGroupDateTimePicker.TabIndex = 63;
            // 
            // shipnameTextBox
            // 
            this.shipnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource1, "shipname", true));
            this.shipnameTextBox.Location = new System.Drawing.Point(123, 120);
            this.shipnameTextBox.Name = "shipnameTextBox";
            this.shipnameTextBox.Size = new System.Drawing.Size(200, 19);
            this.shipnameTextBox.TabIndex = 67;
            // 
            // budjetbalanceTextBox
            // 
            this.budjetbalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource1, "budjetbalance", true));
            this.budjetbalanceTextBox.Location = new System.Drawing.Point(123, 157);
            this.budjetbalanceTextBox.Name = "budjetbalanceTextBox";
            this.budjetbalanceTextBox.Size = new System.Drawing.Size(200, 19);
            this.budjetbalanceTextBox.TabIndex = 69;
            // 
            // managementfeeTextBox
            // 
            this.managementfeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource1, "Managementfee", true));
            this.managementfeeTextBox.Location = new System.Drawing.Point(123, 196);
            this.managementfeeTextBox.Name = "managementfeeTextBox";
            this.managementfeeTextBox.Size = new System.Drawing.Size(200, 19);
            this.managementfeeTextBox.TabIndex = 71;
            // 
            // paymentDateDateTimePicker
            // 
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataExchange_feeBindingSource1, "PaymentDate", true));
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(123, 233);
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.paymentDateDateTimePicker.TabIndex = 73;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchange_feeBindingSource1, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(123, 269);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(200, 19);
            this.remarkTextBox.TabIndex = 75;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 437);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(monthGroupLabel1);
            this.Controls.Add(this.monthGroupDateTimePicker);
            this.Controls.Add(shipnameLabel1);
            this.Controls.Add(this.shipnameTextBox);
            this.Controls.Add(budjetbalanceLabel1);
            this.Controls.Add(this.budjetbalanceTextBox);
            this.Controls.Add(managementfeeLabel1);
            this.Controls.Add(this.managementfeeTextBox);
            this.Controls.Add(paymentDateLabel1);
            this.Controls.Add(this.paymentDateDateTimePicker);
            this.Controls.Add(remarkLabel1);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchange_feeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchange_feeBindingSource1;
        private AZUREDBDataSetTableAdapters.DataExchange_feeTableAdapter dataExchange_feeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker monthGroupDateTimePicker;
        private System.Windows.Forms.TextBox shipnameTextBox;
        private System.Windows.Forms.TextBox budjetbalanceTextBox;
        private System.Windows.Forms.TextBox managementfeeTextBox;
        private System.Windows.Forms.DateTimePicker paymentDateDateTimePicker;
        private System.Windows.Forms.TextBox remarkTextBox;
    }
}