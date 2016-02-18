namespace RawMaterialsThresholdNotifier
{
    partial class rawMaterialsThresholdNotifier
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
            this.companyLabel = new System.Windows.Forms.Label();
            this.notificationEmailLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.frequencyInputBox = new System.Windows.Forms.NumericUpDown();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.itemToggleButton = new System.Windows.Forms.Button();
            this.addEmailButton = new System.Windows.Forms.Button();
            this.emailAddressesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.deleteEmailButton = new System.Windows.Forms.Button();
            this.editEmailButton = new System.Windows.Forms.Button();
            this.rmtnHelpProvider = new System.Windows.Forms.HelpProvider();
            this.companyGraphicLabel = new System.Windows.Forms.Label();
            this.inventoryDatabase = new RawMaterialsThresholdNotifier.InventoryDatabase();
            this.rawMaterialsThresholdNotifierDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawMaterialsThresholdNotifierDataTableTableAdapter = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.rawMaterialsThresholdNotifierDataTableTableAdapter();
            this.tableAdapterManager = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.TableAdapterManager();
            this.invTrans2DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invTrans2TableAdapter = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.invTrans2TableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusOutputLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyInputBox)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsThresholdNotifierDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTrans2DataTableBindingSource)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.companyLabel.Location = new System.Drawing.Point(71, 32);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(124, 21);
            this.companyLabel.TabIndex = 6;
            this.companyLabel.Text = "Stemmerich, Inc.";
            // 
            // notificationEmailLabel
            // 
            this.notificationEmailLabel.AutoSize = true;
            this.notificationEmailLabel.Location = new System.Drawing.Point(85, 49);
            this.notificationEmailLabel.Name = "notificationEmailLabel";
            this.notificationEmailLabel.Size = new System.Drawing.Size(110, 13);
            this.notificationEmailLabel.TabIndex = 3;
            this.notificationEmailLabel.Text = "Notification e-mails:";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(95, 13);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(114, 13);
            this.frequencyLabel.TabIndex = 0;
            this.frequencyLabel.Text = "Frequency of checks:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(259, 13);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(51, 13);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "minutes.";
            // 
            // frequencyInputBox
            // 
            this.frequencyInputBox.Location = new System.Drawing.Point(215, 11);
            this.frequencyInputBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.frequencyInputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencyInputBox.Name = "frequencyInputBox";
            this.frequencyInputBox.ReadOnly = true;
            this.frequencyInputBox.Size = new System.Drawing.Size(38, 22);
            this.frequencyInputBox.TabIndex = 1;
            this.frequencyInputBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.frequencyInputBox.ValueChanged += new System.EventHandler(this.frequencyInputBox_ValueChanged);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.itemToggleButton);
            this.Panel2.Controls.Add(this.addEmailButton);
            this.Panel2.Controls.Add(this.emailAddressesCheckedListBox);
            this.Panel2.Controls.Add(this.deleteEmailButton);
            this.Panel2.Controls.Add(this.notificationEmailLabel);
            this.Panel2.Controls.Add(this.editEmailButton);
            this.Panel2.Controls.Add(this.minutesLabel);
            this.Panel2.Controls.Add(this.frequencyInputBox);
            this.Panel2.Controls.Add(this.frequencyLabel);
            this.Panel2.Location = new System.Drawing.Point(24, 115);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(336, 170);
            this.Panel2.TabIndex = 8;
            // 
            // itemToggleButton
            // 
            this.itemToggleButton.Location = new System.Drawing.Point(4, 8);
            this.itemToggleButton.Name = "itemToggleButton";
            this.itemToggleButton.Size = new System.Drawing.Size(75, 23);
            this.itemToggleButton.TabIndex = 9;
            this.itemToggleButton.Text = "Item Toggle";
            this.itemToggleButton.UseVisualStyleBackColor = true;
            this.itemToggleButton.Click += new System.EventHandler(this.itemToggleButton_Click);
            // 
            // addEmailButton
            // 
            this.addEmailButton.Location = new System.Drawing.Point(4, 49);
            this.addEmailButton.Name = "addEmailButton";
            this.addEmailButton.Size = new System.Drawing.Size(75, 23);
            this.addEmailButton.TabIndex = 7;
            this.addEmailButton.Text = "Add E-mail";
            this.addEmailButton.UseVisualStyleBackColor = true;
            this.addEmailButton.Click += new System.EventHandler(this.addEmail_Click);
            // 
            // emailAddressesCheckedListBox
            // 
            this.emailAddressesCheckedListBox.FormattingEnabled = true;
            this.emailAddressesCheckedListBox.HorizontalScrollbar = true;
            this.emailAddressesCheckedListBox.Location = new System.Drawing.Point(88, 65);
            this.emailAddressesCheckedListBox.Name = "emailAddressesCheckedListBox";
            this.emailAddressesCheckedListBox.Size = new System.Drawing.Size(239, 89);
            this.emailAddressesCheckedListBox.TabIndex = 13;
            this.emailAddressesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.emailAddressesCheckedListBox_ItemCheck);
            // 
            // deleteEmailButton
            // 
            this.deleteEmailButton.Location = new System.Drawing.Point(4, 107);
            this.deleteEmailButton.Name = "deleteEmailButton";
            this.deleteEmailButton.Size = new System.Drawing.Size(75, 34);
            this.deleteEmailButton.TabIndex = 15;
            this.deleteEmailButton.Text = "Delete E-mail";
            this.deleteEmailButton.UseVisualStyleBackColor = true;
            this.deleteEmailButton.Click += new System.EventHandler(this.deleteEmailButton_Click);
            // 
            // editEmailButton
            // 
            this.editEmailButton.Location = new System.Drawing.Point(4, 78);
            this.editEmailButton.Name = "editEmailButton";
            this.editEmailButton.Size = new System.Drawing.Size(75, 23);
            this.editEmailButton.TabIndex = 14;
            this.editEmailButton.Text = "Edit E-mail";
            this.editEmailButton.UseVisualStyleBackColor = true;
            this.editEmailButton.Click += new System.EventHandler(this.editEmailButton_Click);
            // 
            // rmtnHelpProvider
            // 
            this.rmtnHelpProvider.HelpNamespace = "RMTN_Help.chm";
            // 
            // companyGraphicLabel
            // 
            this.companyGraphicLabel.Image = global::RawMaterialsThresholdNotifier.Properties.Resources.Beaker;
            this.companyGraphicLabel.Location = new System.Drawing.Point(21, 19);
            this.companyGraphicLabel.Name = "companyGraphicLabel";
            this.companyGraphicLabel.Size = new System.Drawing.Size(57, 55);
            this.companyGraphicLabel.TabIndex = 5;
            // 
            // inventoryDatabase
            // 
            this.inventoryDatabase.DataSetName = "InventoryDatabase";
            this.inventoryDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawMaterialsThresholdNotifierDataTableBindingSource
            // 
            this.rawMaterialsThresholdNotifierDataTableBindingSource.DataMember = "rawMaterialsThresholdNotifierDataTable";
            this.rawMaterialsThresholdNotifierDataTableBindingSource.DataSource = this.inventoryDatabase;
            // 
            // rawMaterialsThresholdNotifierDataTableTableAdapter
            // 
            this.rawMaterialsThresholdNotifierDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.invTrans2TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invTrans2DataTableBindingSource
            // 
            this.invTrans2DataTableBindingSource.DataMember = "invTrans2DataTable";
            this.invTrans2DataTableBindingSource.DataSource = this.inventoryDatabase;
            // 
            // invTrans2TableAdapter
            // 
            this.invTrans2TableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 289);
            this.label3.TabIndex = 19;
            // 
            // viewReportButton
            // 
            this.viewReportButton.Location = new System.Drawing.Point(223, 5);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(87, 20);
            this.viewReportButton.TabIndex = 2;
            this.viewReportButton.Text = "View Report";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 6);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // statusOutputLabel
            // 
            this.statusOutputLabel.Location = new System.Drawing.Point(47, 5);
            this.statusOutputLabel.Name = "statusOutputLabel";
            this.statusOutputLabel.Size = new System.Drawing.Size(147, 20);
            this.statusOutputLabel.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.statusOutputLabel);
            this.Panel1.Controls.Add(this.statusLabel);
            this.Panel1.Controls.Add(this.viewReportButton);
            this.Panel1.Location = new System.Drawing.Point(24, 77);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(336, 32);
            this.Panel1.TabIndex = 7;
            // 
            // rawMaterialsThresholdNotifier
            // 
            this.AcceptButton = this.viewReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 312);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.companyGraphicLabel);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rawMaterialsThresholdNotifier";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Materials Threshold Notifier";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.rawMaterialsThresholdNotifier_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rawMaterialsThresholdNotifier_FormClosing);
            this.Load += new System.EventHandler(this.rawMaterialsThresholdNotifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frequencyInputBox)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsThresholdNotifierDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invTrans2DataTableBindingSource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label companyLabel;
        internal System.Windows.Forms.Label notificationEmailLabel;
        internal System.Windows.Forms.Label frequencyLabel;
        internal System.Windows.Forms.Label minutesLabel;
        internal System.Windows.Forms.NumericUpDown frequencyInputBox;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label companyGraphicLabel;
        private System.Windows.Forms.Button addEmailButton;
        private System.Windows.Forms.Button deleteEmailButton;
        private System.Windows.Forms.Button editEmailButton;
        private System.Windows.Forms.CheckedListBox emailAddressesCheckedListBox;
        private System.Windows.Forms.HelpProvider rmtnHelpProvider;
        private System.Windows.Forms.BindingSource rawMaterialsThresholdNotifierDataTableBindingSource;
        private InventoryDatabase inventoryDatabase;
        private InventoryDatabaseTableAdapters.rawMaterialsThresholdNotifierDataTableTableAdapter rawMaterialsThresholdNotifierDataTableTableAdapter;
        private InventoryDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button itemToggleButton;
        private System.Windows.Forms.BindingSource invTrans2DataTableBindingSource;
        private InventoryDatabaseTableAdapters.invTrans2TableAdapter invTrans2TableAdapter;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button viewReportButton;
        internal System.Windows.Forms.Label statusLabel;
        internal System.Windows.Forms.Label statusOutputLabel;
        internal System.Windows.Forms.Panel Panel1;
    }
}

