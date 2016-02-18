namespace OrderInformationTransferManager
{
    partial class OrderTransfer
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
            this.orderNumLabel = new System.Windows.Forms.Label();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.transferOrderButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.getOrderNumberButton = new System.Windows.Forms.Button();
            this.productsTreeView = new System.Windows.Forms.TreeView();
            this.companyGraphicLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.oitmHelpProvider = new System.Windows.Forms.HelpProvider();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.accountingDatabase = new OrderInformationTransferManager.AccountingDatabase();
            this.orderNumberDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderNumberDataTableTableAdapter = new OrderInformationTransferManager.AccountingDatabaseTableAdapters.orderNumberDataTableTableAdapter();
            this.tableAdapterManager1 = new OrderInformationTransferManager.AccountingDatabaseTableAdapters.TableAdapterManager();
            this.inventoryDatabase = new OrderInformationTransferManager.InventoryDatabase();
            this.tableAdapterManager = new OrderInformationTransferManager.InventoryDatabaseTableAdapters.TableAdapterManager();
            this.saleIDDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleIDDataTableTableAdapter = new OrderInformationTransferManager.InventoryDatabaseTableAdapters.saleIDDataTableTableAdapter();
            this.customerID_NameDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerID_NameDataTableTableAdapter = new OrderInformationTransferManager.InventoryDatabaseTableAdapters.customerID_NameDataTableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleIDDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerID_NameDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.companyLabel.Location = new System.Drawing.Point(72, 32);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(124, 21);
            this.companyLabel.TabIndex = 3;
            this.companyLabel.Text = "Stemmerich, Inc.";
            // 
            // orderNumLabel
            // 
            this.orderNumLabel.AutoSize = true;
            this.orderNumLabel.Location = new System.Drawing.Point(3, 40);
            this.orderNumLabel.Name = "orderNumLabel";
            this.orderNumLabel.Size = new System.Drawing.Size(83, 13);
            this.orderNumLabel.TabIndex = 0;
            this.orderNumLabel.Text = "Order number:";
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(99, 40);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.orderNumberTextBox.TabIndex = 1;
            // 
            // transferOrderButton
            // 
            this.transferOrderButton.Location = new System.Drawing.Point(6, 73);
            this.transferOrderButton.Name = "transferOrderButton";
            this.transferOrderButton.Size = new System.Drawing.Size(75, 39);
            this.transferOrderButton.TabIndex = 3;
            this.transferOrderButton.Text = "Transfer Order";
            this.transferOrderButton.UseVisualStyleBackColor = true;
            this.transferOrderButton.Click += new System.EventHandler(this.transferOrderButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.customerNameComboBox);
            this.Panel1.Controls.Add(this.transferOrderButton);
            this.Panel1.Controls.Add(this.orderNumLabel);
            this.Panel1.Controls.Add(this.getOrderNumberButton);
            this.Panel1.Controls.Add(this.orderNumberTextBox);
            this.Panel1.Location = new System.Drawing.Point(515, 77);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(300, 129);
            this.Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer name:";
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(99, 6);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(181, 21);
            this.customerNameComboBox.Sorted = true;
            this.customerNameComboBox.TabIndex = 6;
            this.customerNameComboBox.Enter += new System.EventHandler(this.customerNameComboBox_Enter);
            // 
            // getOrderNumberButton
            // 
            this.getOrderNumberButton.Location = new System.Drawing.Point(205, 40);
            this.getOrderNumberButton.Name = "getOrderNumberButton";
            this.getOrderNumberButton.Size = new System.Drawing.Size(75, 34);
            this.getOrderNumberButton.TabIndex = 2;
            this.getOrderNumberButton.Text = "Get Order Number";
            this.getOrderNumberButton.UseVisualStyleBackColor = true;
            this.getOrderNumberButton.Click += new System.EventHandler(this.getOrderNumberButton_Click);
            // 
            // productsTreeView
            // 
            this.productsTreeView.Location = new System.Drawing.Point(106, 77);
            this.productsTreeView.Name = "productsTreeView";
            this.productsTreeView.Size = new System.Drawing.Size(403, 200);
            this.productsTreeView.TabIndex = 4;
            // 
            // companyGraphicLabel
            // 
            this.companyGraphicLabel.Image = global::OrderInformationTransferManager.Properties.Resources.Beaker;
            this.companyGraphicLabel.Location = new System.Drawing.Point(22, 19);
            this.companyGraphicLabel.Name = "companyGraphicLabel";
            this.companyGraphicLabel.Size = new System.Drawing.Size(57, 55);
            this.companyGraphicLabel.TabIndex = 2;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(25, 77);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 35);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // oitmHelpProvider
            // 
            this.oitmHelpProvider.HelpNamespace = "OITM_Help.chm";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(25, 153);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(75, 34);
            this.newOrderButton.TabIndex = 5;
            this.newOrderButton.Text = "Create New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // accountingDatabase
            // 
            this.accountingDatabase.DataSetName = "AccountingDatabase";
            this.accountingDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderNumberDataTableBindingSource
            // 
            this.orderNumberDataTableBindingSource.DataMember = "orderNumberDataTable";
            this.orderNumberDataTableBindingSource.DataSource = this.accountingDatabase;
            // 
            // orderNumberDataTableTableAdapter
            // 
            this.orderNumberDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.orderNumberDataTableTableAdapter = this.orderNumberDataTableTableAdapter;
            this.tableAdapterManager1.UpdateOrder = OrderInformationTransferManager.AccountingDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryDatabase
            // 
            this.inventoryDatabase.DataSetName = "InventoryDatabase";
            this.inventoryDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customerID_NameDataTableTableAdapter = null;
            this.tableAdapterManager.saleIDDataTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OrderInformationTransferManager.InventoryDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saleIDDataTableBindingSource
            // 
            this.saleIDDataTableBindingSource.DataMember = "saleIDDataTable";
            this.saleIDDataTableBindingSource.DataSource = this.inventoryDatabase;
            // 
            // saleIDDataTableTableAdapter
            // 
            this.saleIDDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // customerID_NameDataTableBindingSource
            // 
            this.customerID_NameDataTableBindingSource.DataMember = "customerID_NameDataTable";
            this.customerID_NameDataTableBindingSource.DataSource = this.inventoryDatabase;
            // 
            // customerID_NameDataTableTableAdapter
            // 
            this.customerID_NameDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(818, 284);
            this.label2.TabIndex = 6;
            // 
            // OrderTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 305);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productsTreeView);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyGraphicLabel);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderTransfer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Information Transfer";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.orderTransfer_HelpButtonClicked);
            this.Load += new System.EventHandler(this.OrderTransfer_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleIDDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerID_NameDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label companyLabel;
        internal System.Windows.Forms.Label companyGraphicLabel;
        internal System.Windows.Forms.Label orderNumLabel;
        internal System.Windows.Forms.TextBox orderNumberTextBox;
        internal System.Windows.Forms.Button transferOrderButton;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TreeView productsTreeView;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.HelpProvider oitmHelpProvider;
        private InventoryDatabase inventoryDatabase;
        private InventoryDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button getOrderNumberButton;
        private AccountingDatabase accountingDatabase;
        private System.Windows.Forms.BindingSource orderNumberDataTableBindingSource;
        private AccountingDatabaseTableAdapters.orderNumberDataTableTableAdapter orderNumberDataTableTableAdapter;
        private AccountingDatabaseTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource saleIDDataTableBindingSource;
        private InventoryDatabaseTableAdapters.saleIDDataTableTableAdapter saleIDDataTableTableAdapter;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.BindingSource customerID_NameDataTableBindingSource;
        private InventoryDatabaseTableAdapters.customerID_NameDataTableTableAdapter customerID_NameDataTableTableAdapter;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerNameComboBox;
        private System.Windows.Forms.Label label2;

    }
}

