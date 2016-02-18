namespace RawMaterialsThresholdNotifier
{
    partial class RawMaterialsSelection
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
            this.companyGraphicLabel = new System.Windows.Forms.Label();
            this.inventoryDatabase = new RawMaterialsThresholdNotifier.InventoryDatabase();
            this.rawMaterialsThresholdNotifierDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawMaterialsThresholdNotifierDataTableTableAdapter = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.rawMaterialsThresholdNotifierDataTableTableAdapter();
            this.tableAdapterManager = new RawMaterialsThresholdNotifier.InventoryDatabaseTableAdapters.TableAdapterManager();
            this.rawMaterialsSelectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descFilterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descFilterTextBox = new System.Windows.Forms.TextBox();
            this.codeFilterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codeFilterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rmtnHelpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsThresholdNotifierDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsSelectionDataGridView)).BeginInit();
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
            this.companyLabel.TabIndex = 8;
            this.companyLabel.Text = "Stemmerich, Inc.";
            // 
            // companyGraphicLabel
            // 
            this.companyGraphicLabel.Image = global::RawMaterialsThresholdNotifier.Properties.Resources.Beaker;
            this.companyGraphicLabel.Location = new System.Drawing.Point(21, 19);
            this.companyGraphicLabel.Name = "companyGraphicLabel";
            this.companyGraphicLabel.Size = new System.Drawing.Size(57, 55);
            this.companyGraphicLabel.TabIndex = 7;
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
            // rawMaterialsSelectionDataGridView
            // 
            this.rawMaterialsSelectionDataGridView.AutoGenerateColumns = false;
            this.rawMaterialsSelectionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rawMaterialsSelectionDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rawMaterialsSelectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawMaterialsSelectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rawMaterialsSelectionDataGridView.DataSource = this.rawMaterialsThresholdNotifierDataTableBindingSource;
            this.rawMaterialsSelectionDataGridView.Location = new System.Drawing.Point(18, 103);
            this.rawMaterialsSelectionDataGridView.Name = "rawMaterialsSelectionDataGridView";
            this.rawMaterialsSelectionDataGridView.RowHeadersVisible = false;
            this.rawMaterialsSelectionDataGridView.Size = new System.Drawing.Size(922, 418);
            this.rawMaterialsSelectionDataGridView.TabIndex = 9;
            this.rawMaterialsSelectionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rawMaterialsSelectionDataGridView_CellContentClick);
            this.rawMaterialsSelectionDataGridView.Sorted += new System.EventHandler(this.rawMaterialsSelectionDataGridView_Sorted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
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
            // descFilterButton
            // 
            this.descFilterButton.Location = new System.Drawing.Point(535, 77);
            this.descFilterButton.Name = "descFilterButton";
            this.descFilterButton.Size = new System.Drawing.Size(75, 23);
            this.descFilterButton.TabIndex = 17;
            this.descFilterButton.Text = "Filter";
            this.descFilterButton.UseVisualStyleBackColor = true;
            this.descFilterButton.Click += new System.EventHandler(this.descFilterButton_Click_KeyPress);
            this.descFilterButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descFilterButton_Click_KeyPress);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(307, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter by description:";
            // 
            // descFilterTextBox
            // 
            this.descFilterTextBox.Location = new System.Drawing.Point(429, 77);
            this.descFilterTextBox.Name = "descFilterTextBox";
            this.descFilterTextBox.Size = new System.Drawing.Size(100, 22);
            this.descFilterTextBox.TabIndex = 15;
            this.descFilterTextBox.TextChanged += new System.EventHandler(this.descFilterTextBox_TextChanged);
            // 
            // codeFilterButton
            // 
            this.codeFilterButton.Location = new System.Drawing.Point(212, 77);
            this.codeFilterButton.Name = "codeFilterButton";
            this.codeFilterButton.Size = new System.Drawing.Size(75, 23);
            this.codeFilterButton.TabIndex = 14;
            this.codeFilterButton.Text = "Filter";
            this.codeFilterButton.UseVisualStyleBackColor = true;
            this.codeFilterButton.Click += new System.EventHandler(this.codeFilterButton_Click_KeyPress);
            this.codeFilterButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeFilterButton_Click_KeyPress);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter by code:";
            // 
            // codeFilterTextBox
            // 
            this.codeFilterTextBox.Location = new System.Drawing.Point(106, 77);
            this.codeFilterTextBox.Name = "codeFilterTextBox";
            this.codeFilterTextBox.Size = new System.Drawing.Size(100, 22);
            this.codeFilterTextBox.TabIndex = 12;
            this.codeFilterTextBox.TextChanged += new System.EventHandler(this.codeFilterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(941, 569);
            this.label3.TabIndex = 18;
            // 
            // rmtnHelpProvider
            // 
            this.rmtnHelpProvider.HelpNamespace = "RMTN_Help.chm";
            // 
            // RawMaterialsSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 587);
            this.Controls.Add(this.descFilterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descFilterTextBox);
            this.Controls.Add(this.codeFilterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeFilterTextBox);
            this.Controls.Add(this.rawMaterialsSelectionDataGridView);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyGraphicLabel);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RawMaterialsSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RawMaterialsSelection";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.RawMaterialsSelection_HelpButtonClicked_1);
            this.Load += new System.EventHandler(this.RawMaterialsSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsThresholdNotifierDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsSelectionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label companyLabel;
        internal System.Windows.Forms.Label companyGraphicLabel;
        private InventoryDatabase inventoryDatabase;
        private System.Windows.Forms.BindingSource rawMaterialsThresholdNotifierDataTableBindingSource;
        private InventoryDatabaseTableAdapters.rawMaterialsThresholdNotifierDataTableTableAdapter rawMaterialsThresholdNotifierDataTableTableAdapter;
        private InventoryDatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rawMaterialsSelectionDataGridView;
        private System.Windows.Forms.Button descFilterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descFilterTextBox;
        private System.Windows.Forms.Button codeFilterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeFilterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.HelpProvider rmtnHelpProvider;
    }
}