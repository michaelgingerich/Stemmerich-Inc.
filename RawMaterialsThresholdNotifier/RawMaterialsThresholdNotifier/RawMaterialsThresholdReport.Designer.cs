namespace RawMaterialsThresholdNotifier
{
    partial class RawMaterialsThresholdReport
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
            this.rawMaterialsThresholdReportTextBox = new System.Windows.Forms.TextBox();
            this.rmtnHelpProvider = new System.Windows.Forms.HelpProvider();
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyGraphicLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rawMaterialsThresholdReportTextBox
            // 
            this.rawMaterialsThresholdReportTextBox.Location = new System.Drawing.Point(24, 77);
            this.rawMaterialsThresholdReportTextBox.Multiline = true;
            this.rawMaterialsThresholdReportTextBox.Name = "rawMaterialsThresholdReportTextBox";
            this.rawMaterialsThresholdReportTextBox.ReadOnly = true;
            this.rawMaterialsThresholdReportTextBox.Size = new System.Drawing.Size(630, 327);
            this.rawMaterialsThresholdReportTextBox.TabIndex = 1;
            // 
            // rmtnHelpProvider
            // 
            this.rmtnHelpProvider.HelpNamespace = "RMTN_Help.chm";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.companyLabel.Location = new System.Drawing.Point(71, 32);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(124, 21);
            this.companyLabel.TabIndex = 10;
            this.companyLabel.Text = "Stemmerich, Inc.";
            // 
            // companyGraphicLabel
            // 
            this.companyGraphicLabel.Image = global::RawMaterialsThresholdNotifier.Properties.Resources.Beaker;
            this.companyGraphicLabel.Location = new System.Drawing.Point(21, 19);
            this.companyGraphicLabel.Name = "companyGraphicLabel";
            this.companyGraphicLabel.Size = new System.Drawing.Size(57, 55);
            this.companyGraphicLabel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(660, 416);
            this.label3.TabIndex = 19;
            // 
            // RawMaterialsThresholdReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 439);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyGraphicLabel);
            this.Controls.Add(this.rawMaterialsThresholdReportTextBox);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RawMaterialsThresholdReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Materials Threshold Report";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.rawMaterialsThresholdReport_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rawMaterialsThresholdReportTextBox;
        private System.Windows.Forms.HelpProvider rmtnHelpProvider;
        internal System.Windows.Forms.Label companyLabel;
        internal System.Windows.Forms.Label companyGraphicLabel;
        private System.Windows.Forms.Label label3;
    }
}