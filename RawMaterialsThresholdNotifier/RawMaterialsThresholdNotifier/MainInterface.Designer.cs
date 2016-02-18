namespace RawMaterialsThresholdNotifier
{
    partial class MainInterface
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
            this.viewReportButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.statusOutputLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.frequencyInputBox = new System.Windows.Forms.NumericUpDown();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.addEmailButton = new System.Windows.Forms.Button();
            this.deleteEmailButton = new System.Windows.Forms.Button();
            this.editEmailButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lastNotificationOutputLabel = new System.Windows.Forms.Label();
            this.lastNotificatonLabel = new System.Windows.Forms.Label();
            this.companyGraphicLabel = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rmtnHelpProvider = new System.Windows.Forms.HelpProvider();
            this.inventoryDatabase = new RawMaterialsThresholdNotifier.InventoryDatabase();
            this.dbo_MstItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_MstItemTableAdapter = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.dbo_MstItemTableAdapter();
            this.tableAdapterManager = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.rawMaterialsThresholdReportTextBox = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyInputBox)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_MstItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(64, 23);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(124, 21);
            this.companyLabel.TabIndex = 6;
            this.companyLabel.Text = "Stemmerich, Inc.";
            // 
            // notificationEmailLabel
            // 
            this.notificationEmailLabel.AutoSize = true;
            this.notificationEmailLabel.Location = new System.Drawing.Point(3, 32);
            this.notificationEmailLabel.Name = "notificationEmailLabel";
            this.notificationEmailLabel.Size = new System.Drawing.Size(105, 13);
            this.notificationEmailLabel.TabIndex = 3;
            this.notificationEmailLabel.Text = "Notification e-mail:";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(3, 7);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(114, 13);
            this.frequencyLabel.TabIndex = 0;
            this.frequencyLabel.Text = "Frequency of checks:";
            // 
            // viewReportButton
            // 
            this.viewReportButton.Location = new System.Drawing.Point(242, 3);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(87, 20);
            this.viewReportButton.TabIndex = 2;
            this.viewReportButton.Text = "View Report";
            this.viewReportButton.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.statusOutputLabel);
            this.Panel1.Controls.Add(this.statusLabel);
            this.Panel1.Controls.Add(this.viewReportButton);
            this.Panel1.Location = new System.Drawing.Point(17, 68);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(336, 28);
            this.Panel1.TabIndex = 7;
            // 
            // statusOutputLabel
            // 
            this.statusOutputLabel.AutoSize = true;
            this.statusOutputLabel.Location = new System.Drawing.Point(51, 7);
            this.statusOutputLabel.Name = "statusOutputLabel";
            this.statusOutputLabel.Size = new System.Drawing.Size(172, 13);
            this.statusOutputLabel.TabIndex = 1;
            this.statusOutputLabel.Text = "Thresholds reached.  See report.";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 7);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(161, 5);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(51, 13);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "minutes.";
            // 
            // frequencyInputBox
            // 
            this.frequencyInputBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frequencyInputBox.Location = new System.Drawing.Point(123, 3);
            this.frequencyInputBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.frequencyInputBox.Name = "frequencyInputBox";
            this.frequencyInputBox.Size = new System.Drawing.Size(38, 22);
            this.frequencyInputBox.TabIndex = 1;
            this.frequencyInputBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.addEmailButton);
            this.Panel2.Controls.Add(this.deleteEmailButton);
            this.Panel2.Controls.Add(this.editEmailButton);
            this.Panel2.Controls.Add(this.checkedListBox1);
            this.Panel2.Controls.Add(this.lastNotificationOutputLabel);
            this.Panel2.Controls.Add(this.notificationEmailLabel);
            this.Panel2.Controls.Add(this.minutesLabel);
            this.Panel2.Controls.Add(this.lastNotificatonLabel);
            this.Panel2.Controls.Add(this.frequencyInputBox);
            this.Panel2.Controls.Add(this.frequencyLabel);
            this.Panel2.Location = new System.Drawing.Point(17, 102);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(336, 171);
            this.Panel2.TabIndex = 8;
            // 
            // addEmailButton
            // 
            this.addEmailButton.Location = new System.Drawing.Point(132, 48);
            this.addEmailButton.Name = "addEmailButton";
            this.addEmailButton.Size = new System.Drawing.Size(75, 23);
            this.addEmailButton.TabIndex = 7;
            this.addEmailButton.Text = "Add Email";
            this.addEmailButton.UseVisualStyleBackColor = true;
            this.addEmailButton.Click += new System.EventHandler(this.saveEmail_Click);
            // 
            // deleteEmailButton
            // 
            this.deleteEmailButton.Location = new System.Drawing.Point(132, 106);
            this.deleteEmailButton.Name = "deleteEmailButton";
            this.deleteEmailButton.Size = new System.Drawing.Size(75, 34);
            this.deleteEmailButton.TabIndex = 15;
            this.deleteEmailButton.Text = "Delete Email";
            this.deleteEmailButton.UseVisualStyleBackColor = true;
            // 
            // editEmailButton
            // 
            this.editEmailButton.Location = new System.Drawing.Point(132, 77);
            this.editEmailButton.Name = "editEmailButton";
            this.editEmailButton.Size = new System.Drawing.Size(75, 23);
            this.editEmailButton.TabIndex = 14;
            this.editEmailButton.Text = "Edit Email";
            this.editEmailButton.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 48);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 13;
            // 
            // lastNotificationOutputLabel
            // 
            this.lastNotificationOutputLabel.AutoSize = true;
            this.lastNotificationOutputLabel.Location = new System.Drawing.Point(121, 150);
            this.lastNotificationOutputLabel.Name = "lastNotificationOutputLabel";
            this.lastNotificationOutputLabel.Size = new System.Drawing.Size(89, 13);
            this.lastNotificationOutputLabel.TabIndex = 6;
            this.lastNotificationOutputLabel.Text = "43 minutes ago.";
            // 
            // lastNotificatonLabel
            // 
            this.lastNotificatonLabel.AutoSize = true;
            this.lastNotificatonLabel.Location = new System.Drawing.Point(3, 150);
            this.lastNotificatonLabel.Name = "lastNotificatonLabel";
            this.lastNotificatonLabel.Size = new System.Drawing.Size(118, 13);
            this.lastNotificatonLabel.TabIndex = 5;
            this.lastNotificatonLabel.Text = "Last notification sent:";
            // 
            // companyGraphicLabel
            // 
            this.companyGraphicLabel.Image = global::RawMaterialsThresholdNotifier.Properties.Resources.Beaker;
            this.companyGraphicLabel.Location = new System.Drawing.Point(14, 10);
            this.companyGraphicLabel.Name = "companyGraphicLabel";
            this.companyGraphicLabel.Size = new System.Drawing.Size(57, 55);
            this.companyGraphicLabel.TabIndex = 5;
            // 
            // emailError
            // 
            this.emailError.ContainerControl = this;
            // 
            // rmtnHelpProvider
            // 
            this.rmtnHelpProvider.HelpNamespace = "RMTN_Help.chm";
            // 
            // inventoryDatabase
            // 
            this.inventoryDatabase.DataSetName = "InventoryDatabase";
            this.inventoryDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbo_MstItemBindingSource
            // 
            this.dbo_MstItemBindingSource.DataMember = "dbo_MstItem";
            this.dbo_MstItemBindingSource.DataSource = this.inventoryDatabase;
            // 
            // dbo_MstItemTableAdapter
            // 
            this.dbo_MstItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rawMaterialsThresholdReportTextBox
            // 
            this.rawMaterialsThresholdReportTextBox.Location = new System.Drawing.Point(452, 76);
            this.rawMaterialsThresholdReportTextBox.Multiline = true;
            this.rawMaterialsThresholdReportTextBox.Name = "rawMaterialsThresholdReportTextBox";
            this.rawMaterialsThresholdReportTextBox.ReadOnly = true;
            this.rawMaterialsThresholdReportTextBox.Size = new System.Drawing.Size(630, 422);
            this.rawMaterialsThresholdReportTextBox.TabIndex = 10;
            // 
            // MainInterface
            // 
            this.AcceptButton = this.viewReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 603);
            this.Controls.Add(this.rawMaterialsThresholdReportTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.companyGraphicLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Materials Threshold Notifier";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.rawMaterialsThresholdNotifier_HelpButtonClicked);
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyInputBox)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_MstItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label companyLabel;
        internal System.Windows.Forms.Label notificationEmailLabel;
        internal System.Windows.Forms.Label frequencyLabel;
        internal System.Windows.Forms.Button viewReportButton;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label statusOutputLabel;
        internal System.Windows.Forms.Label statusLabel;
        internal System.Windows.Forms.Label minutesLabel;
        internal System.Windows.Forms.NumericUpDown frequencyInputBox;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lastNotificationOutputLabel;
        internal System.Windows.Forms.Label lastNotificatonLabel;
        internal System.Windows.Forms.Label companyGraphicLabel;
        private System.Windows.Forms.ErrorProvider emailError;
        private System.Windows.Forms.Button addEmailButton;
        private System.Windows.Forms.Button deleteEmailButton;
        private System.Windows.Forms.Button editEmailButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.HelpProvider rmtnHelpProvider;
        private System.Windows.Forms.BindingSource dbo_MstItemBindingSource;
        private InventoryDatabase inventoryDatabase;
        private InventoryDatabaseTableAdapters.dbo_MstItemTableAdapter dbo_MstItemTableAdapter;
        private InventoryDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rawMaterialsThresholdReportTextBox;
    }
}

