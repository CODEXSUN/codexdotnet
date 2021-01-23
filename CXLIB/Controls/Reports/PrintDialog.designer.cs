namespace CXLIB
{
    partial class PrintDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDialog));
            this.lblProfileName = new System.Windows.Forms.Label();
            this.pnlProfiles = new System.Windows.Forms.Panel();
            this.pnlCopies = new System.Windows.Forms.GroupBox();
            this.chkCollate = new System.Windows.Forms.CheckBox();
            this.txtCopies = new System.Windows.Forms.NumericUpDown();
            this.lblCopies = new System.Windows.Forms.Label();
            this.pnlPageRange = new System.Windows.Forms.GroupBox();
            this.radCurrentPage = new System.Windows.Forms.RadioButton();
            this.lblPageRangeAdvice = new System.Windows.Forms.Label();
            this.txtPageRange = new System.Windows.Forms.TextBox();
            this.radSomPages = new System.Windows.Forms.RadioButton();
            this.radAllPages = new System.Windows.Forms.RadioButton();
            this.cboProfileName = new System.Windows.Forms.ComboBox();
            this.pnlButtonsList = new System.Windows.Forms.Panel();
            this.pnlPrinterSetup = new CXLIB.PrintSetupPanel();
            this.picCollate = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlProfiles.SuspendLayout();
            this.pnlCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopies)).BeginInit();
            this.pnlPageRange.SuspendLayout();
            this.pnlButtonsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCollate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(24, 11);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(36, 13);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "Profile";
            // 
            // pnlProfiles
            // 
            this.pnlProfiles.BackColor = System.Drawing.Color.White;
            this.pnlProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfiles.Controls.Add(this.pnlCopies);
            this.pnlProfiles.Controls.Add(this.pnlPageRange);
            this.pnlProfiles.Controls.Add(this.cboProfileName);
            this.pnlProfiles.Controls.Add(this.pnlButtonsList);
            this.pnlProfiles.Controls.Add(this.lblProfileName);
            this.pnlProfiles.Controls.Add(this.pnlPrinterSetup);
            this.pnlProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfiles.Location = new System.Drawing.Point(0, 0);
            this.pnlProfiles.Name = "pnlProfiles";
            this.pnlProfiles.Size = new System.Drawing.Size(470, 543);
            this.pnlProfiles.TabIndex = 0;
            // 
            // pnlCopies
            // 
            this.pnlCopies.Controls.Add(this.picCollate);
            this.pnlCopies.Controls.Add(this.chkCollate);
            this.pnlCopies.Controls.Add(this.txtCopies);
            this.pnlCopies.Controls.Add(this.lblCopies);
            this.pnlCopies.Location = new System.Drawing.Point(286, 351);
            this.pnlCopies.Name = "pnlCopies";
            this.pnlCopies.Size = new System.Drawing.Size(174, 121);
            this.pnlCopies.TabIndex = 4;
            this.pnlCopies.TabStop = false;
            // 
            // chkCollate
            // 
            this.chkCollate.AutoSize = true;
            this.chkCollate.Location = new System.Drawing.Point(10, 66);
            this.chkCollate.Name = "chkCollate";
            this.chkCollate.Size = new System.Drawing.Size(58, 17);
            this.chkCollate.TabIndex = 2;
            this.chkCollate.Text = "Collate";
            this.chkCollate.UseVisualStyleBackColor = true;
            this.chkCollate.CheckedChanged += new System.EventHandler(this.chkCollate_CheckedChanged);
            // 
            // txtCopies
            // 
            this.txtCopies.Enabled = false;
            this.txtCopies.Location = new System.Drawing.Point(105, 20);
            this.txtCopies.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(46, 20);
            this.txtCopies.TabIndex = 1;
            this.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCopies.ValueChanged += new System.EventHandler(this.txtCopies_ValueChanged);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Enabled = false;
            this.lblCopies.Location = new System.Drawing.Point(6, 22);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(93, 13);
            this.lblCopies.TabIndex = 0;
            this.lblCopies.Text = "Number of copies:";
            // 
            // pnlPageRange
            // 
            this.pnlPageRange.Controls.Add(this.radCurrentPage);
            this.pnlPageRange.Controls.Add(this.lblPageRangeAdvice);
            this.pnlPageRange.Controls.Add(this.txtPageRange);
            this.pnlPageRange.Controls.Add(this.radSomPages);
            this.pnlPageRange.Controls.Add(this.radAllPages);
            this.pnlPageRange.Location = new System.Drawing.Point(10, 351);
            this.pnlPageRange.Name = "pnlPageRange";
            this.pnlPageRange.Size = new System.Drawing.Size(269, 121);
            this.pnlPageRange.TabIndex = 3;
            this.pnlPageRange.TabStop = false;
            this.pnlPageRange.Text = "Page Range";
            // 
            // radCurrentPage
            // 
            this.radCurrentPage.AutoSize = true;
            this.radCurrentPage.Location = new System.Drawing.Point(13, 44);
            this.radCurrentPage.Name = "radCurrentPage";
            this.radCurrentPage.Size = new System.Drawing.Size(87, 17);
            this.radCurrentPage.TabIndex = 1;
            this.radCurrentPage.Text = "Current Page";
            this.radCurrentPage.UseVisualStyleBackColor = true;
            // 
            // lblPageRangeAdvice
            // 
            this.lblPageRangeAdvice.Location = new System.Drawing.Point(14, 89);
            this.lblPageRangeAdvice.Name = "lblPageRangeAdvice";
            this.lblPageRangeAdvice.Size = new System.Drawing.Size(248, 28);
            this.lblPageRangeAdvice.TabIndex = 4;
            this.lblPageRangeAdvice.Text = "Enter either a single page number (for example 3)\r\nor a single page range. (for e" +
    "xample 5-12)";
            // 
            // txtPageRange
            // 
            this.txtPageRange.Location = new System.Drawing.Point(84, 66);
            this.txtPageRange.Name = "txtPageRange";
            this.txtPageRange.Size = new System.Drawing.Size(67, 20);
            this.txtPageRange.TabIndex = 3;
            this.txtPageRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageRange_KeyPress);
            // 
            // radSomPages
            // 
            this.radSomPages.AutoSize = true;
            this.radSomPages.Location = new System.Drawing.Point(13, 68);
            this.radSomPages.Name = "radSomPages";
            this.radSomPages.Size = new System.Drawing.Size(61, 17);
            this.radSomPages.TabIndex = 2;
            this.radSomPages.Text = "Pages :";
            this.radSomPages.UseVisualStyleBackColor = true;
            this.radSomPages.CheckedChanged += new System.EventHandler(this.radSomPages_CheckedChanged);
            // 
            // radAllPages
            // 
            this.radAllPages.AutoSize = true;
            this.radAllPages.Checked = true;
            this.radAllPages.Location = new System.Drawing.Point(13, 20);
            this.radAllPages.Name = "radAllPages";
            this.radAllPages.Size = new System.Drawing.Size(36, 17);
            this.radAllPages.TabIndex = 0;
            this.radAllPages.TabStop = true;
            this.radAllPages.Text = "All";
            this.radAllPages.UseVisualStyleBackColor = true;
            // 
            // cboProfileName
            // 
            this.cboProfileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfileName.FormattingEnabled = true;
            this.cboProfileName.Location = new System.Drawing.Point(100, 7);
            this.cboProfileName.Name = "cboProfileName";
            this.cboProfileName.Size = new System.Drawing.Size(337, 21);
            this.cboProfileName.TabIndex = 1;
            // 
            // pnlButtonsList
            // 
            this.pnlButtonsList.Controls.Add(this.btnPrint);
            this.pnlButtonsList.Controls.Add(this.btnCancel);
            this.pnlButtonsList.Controls.Add(this.btnApply);
            this.pnlButtonsList.Location = new System.Drawing.Point(9, 478);
            this.pnlButtonsList.Name = "pnlButtonsList";
            this.pnlButtonsList.Size = new System.Drawing.Size(451, 54);
            this.pnlButtonsList.TabIndex = 5;
            // 
            // pnlPrinterSetup
            // 
            this.pnlPrinterSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrinterSetup.Location = new System.Drawing.Point(9, 28);
            this.pnlPrinterSetup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPrinterSetup.Name = "pnlPrinterSetup";
            this.pnlPrinterSetup.ReadOnly = false;
            this.pnlPrinterSetup.Size = new System.Drawing.Size(458, 318);
            this.pnlPrinterSetup.TabIndex = 2;
            // 
            // picCollate
            // 
            this.picCollate.Location = new System.Drawing.Point(66, 73);
            this.picCollate.Name = "picCollate";
            this.picCollate.Size = new System.Drawing.Size(102, 34);
            this.picCollate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCollate.TabIndex = 1;
            this.picCollate.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::CXLIB.Properties.Resources.printer_small;
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 48);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(353, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 48);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Image = global::CXLIB.Properties.Resources.tick_32;
            this.btnApply.Location = new System.Drawing.Point(251, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(96, 48);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // PrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 543);
            this.Controls.Add(this.pnlProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priner Setup";
            this.pnlProfiles.ResumeLayout(false);
            this.pnlProfiles.PerformLayout();
            this.pnlCopies.ResumeLayout(false);
            this.pnlCopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopies)).EndInit();
            this.pnlPageRange.ResumeLayout(false);
            this.pnlPageRange.PerformLayout();
            this.pnlButtonsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCollate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PrintSetupPanel pnlPrinterSetup;
        private System.Windows.Forms.Panel pnlButtonsList;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Panel pnlProfiles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboProfileName;
        private System.Windows.Forms.GroupBox pnlPageRange;
        private System.Windows.Forms.Label lblPageRangeAdvice;
        private System.Windows.Forms.TextBox txtPageRange;
        private System.Windows.Forms.RadioButton radSomPages;
        private System.Windows.Forms.RadioButton radAllPages;
        private System.Windows.Forms.GroupBox pnlCopies;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.NumericUpDown txtCopies;
        private System.Windows.Forms.PictureBox picCollate;
        private System.Windows.Forms.CheckBox chkCollate;
        private System.Windows.Forms.RadioButton radCurrentPage;
    }
}