namespace OrderInformationTransferManager
{
    partial class RawMaterialsAvailability
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
            this.rawMaterialsAvailabilityDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterialsAvailabilityDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabase = new OrderInformationTransferManager.InventoryDatabase();
            this.addRawMaterialsButton = new System.Windows.Forms.Button();
            this.codeFilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.companyGraphicLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.codeFilterButton = new System.Windows.Forms.Button();
            this.descFilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descFilterTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new OrderInformationTransferManager.InventoryDatabaseTableAdapters.TableAdapterManager();
            this.rawMaterialsAvailabilityDataTableTableAdapter = new OrderInformationTransferManager.InventoryDatabaseTableAdapters.rawMaterialsAvailabilityDataTableTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsAvailabilityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsAvailabilityDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // rawMaterialsAvailabilityDataGridView
            // 
            this.rawMaterialsAvailabilityDataGridView.AutoGenerateColumns = false;
            this.rawMaterialsAvailabilityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rawMaterialsAvailabilityDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rawMaterialsAvailabilityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawMaterialsAvailabilityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rawMaterialsAvailabilityDataGridView.DataSource = this.rawMaterialsAvailabilityDataTableBindingSource;
            this.rawMaterialsAvailabilityDataGridView.Location = new System.Drawing.Point(18, 103);
            this.rawMaterialsAvailabilityDataGridView.Name = "rawMaterialsAvailabilityDataGridView";
            this.rawMaterialsAvailabilityDataGridView.RowHeadersVisible = false;
            this.rawMaterialsAvailabilityDataGridView.Size = new System.Drawing.Size(922, 418);
            this.rawMaterialsAvailabilityDataGridView.TabIndex = 0;
            this.rawMaterialsAvailabilityDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.rawMaterialsAvailabilityDataGridView_CellEndEdit);
            this.rawMaterialsAvailabilityDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.rawMaterialsAvailabilityDataGridView_EditingControlShowing);
            this.rawMaterialsAvailabilityDataGridView.Sorted += new System.EventHandler(this.rawMaterialsAvailabilityDataGridView_Sorted);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 57;
            // 
            // rawMaterialsAvailabilityDataTableBindingSource
            // 
            this.rawMaterialsAvailabilityDataTableBindingSource.DataMember = "rawMaterialsAvailabilityDataTable";
            this.rawMaterialsAvailabilityDataTableBindingSource.DataSource = this.inventoryDatabase;
            // 
            // inventoryDatabase
            // 
            this.inventoryDatabase.DataSetName = "InventoryDatabase";
            this.inventoryDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addRawMaterialsButton
            // 
            this.addRawMaterialsButton.Location = new System.Drawing.Point(18, 527);
            this.addRawMaterialsButton.Name = "addRawMaterialsButton";
            this.addRawMaterialsButton.Size = new System.Drawing.Size(75, 35);
            this.addRawMaterialsButton.TabIndex = 1;
            this.addRawMaterialsButton.Text = "Add Raw Materials";
            this.addRawMaterialsButton.UseVisualStyleBackColor = true;
            this.addRawMaterialsButton.Click += new System.EventHandler(this.addRawMaterialsButton_Click);
            // 
            // codeFilterTextBox
            // 
            this.codeFilterTextBox.Location = new System.Drawing.Point(106, 77);
            this.codeFilterTextBox.Name = "codeFilterTextBox";
            this.codeFilterTextBox.Size = new System.Drawing.Size(100, 22);
            this.codeFilterTextBox.TabIndex = 2;
            this.codeFilterTextBox.TextChanged += new System.EventHandler(this.codeFilterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by code:";
            // 
            // companyGraphicLabel
            // 
            this.companyGraphicLabel.Image = global::OrderInformationTransferManager.Properties.Resources.Beaker;
            this.companyGraphicLabel.Location = new System.Drawing.Point(21, 19);
            this.companyGraphicLabel.Name = "companyGraphicLabel";
            this.companyGraphicLabel.Size = new System.Drawing.Size(57, 55);
            this.companyGraphicLabel.TabIndex = 6;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.companyLabel.Location = new System.Drawing.Point(71, 32);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(124, 21);
            this.companyLabel.TabIndex = 7;
            this.companyLabel.Text = "Stemmerich, Inc.";
            // 
            // codeFilterButton
            // 
            this.codeFilterButton.Location = new System.Drawing.Point(212, 77);
            this.codeFilterButton.Name = "codeFilterButton";
            this.codeFilterButton.Size = new System.Drawing.Size(75, 23);
            this.codeFilterButton.TabIndex = 8;
            this.codeFilterButton.Text = "Filter";
            this.codeFilterButton.UseVisualStyleBackColor = true;
            this.codeFilterButton.Click += new System.EventHandler(this.codeFilterButton_Click_KeyPress);
            this.codeFilterButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeFilterButton_Click_KeyPress);
            // 
            // descFilterButton
            // 
            this.descFilterButton.Location = new System.Drawing.Point(535, 77);
            this.descFilterButton.Name = "descFilterButton";
            this.descFilterButton.Size = new System.Drawing.Size(75, 23);
            this.descFilterButton.TabIndex = 11;
            this.descFilterButton.Text = "Filter";
            this.descFilterButton.UseVisualStyleBackColor = true;
            this.descFilterButton.Click += new System.EventHandler(this.descfilterButton_Click_KeyPress);
            this.descFilterButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descfilterButton_Click_KeyPress);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(307, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter by description:";
            // 
            // descFilterTextBox
            // 
            this.descFilterTextBox.Location = new System.Drawing.Point(429, 77);
            this.descFilterTextBox.Name = "descFilterTextBox";
            this.descFilterTextBox.Size = new System.Drawing.Size(100, 22);
            this.descFilterTextBox.TabIndex = 9;
            this.descFilterTextBox.TextChanged += new System.EventHandler(this.descFilterTextBox_TextChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customerID_NameDataTableTableAdapter = null;
            this.tableAdapterManager.saleIDDataTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OrderInformationTransferManager.InventoryDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rawMaterialsAvailabilityDataTableTableAdapter
            // 
            this.rawMaterialsAvailabilityDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(941, 569);
            this.label3.TabIndex = 12;
            // 
            // RawMaterialsAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(962, 587);
            this.Controls.Add(this.descFilterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descFilterTextBox);
            this.Controls.Add(this.codeFilterButton);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyGraphicLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeFilterTextBox);
            this.Controls.Add(this.addRawMaterialsButton);
            this.Controls.Add(this.rawMaterialsAvailabilityDataGridView);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RawMaterialsAvailability";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Materials Availability";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.rawMaterialsAvailability_HelpButtonClicked);
            this.Load += new System.EventHandler(this.RawMaterialsAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsAvailabilityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsAvailabilityDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryDatabase inventoryDatabase;
        private InventoryDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource rawMaterialsAvailabilityDataTableBindingSource;
        private InventoryDatabaseTableAdapters.rawMaterialsAvailabilityDataTableTableAdapter rawMaterialsAvailabilityDataTableTableAdapter;
        private System.Windows.Forms.DataGridView rawMaterialsAvailabilityDataGridView;
        private System.Windows.Forms.Button addRawMaterialsButton;
        private System.Windows.Forms.TextBox codeFilterTextBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label companyGraphicLabel;
        internal System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button codeFilterButton;
        private System.Windows.Forms.Button descFilterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descFilterTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
    }
}