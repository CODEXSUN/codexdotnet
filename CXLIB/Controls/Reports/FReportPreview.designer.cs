namespace CXLIB
{
    partial class FReportPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FReportPreview));
            this.ListButtonsPanel = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.FilterButtonPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnExportAsPdf = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.btnPrintDirect = new System.Windows.Forms.Button();
            this.ListButtonsPanel.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.FilterButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListButtonsPanel
            // 
            this.ListButtonsPanel.Controls.Add(this.btnFilter);
            this.ListButtonsPanel.Controls.Add(this.btnClose);
            this.ListButtonsPanel.Location = new System.Drawing.Point(160, 413);
            this.ListButtonsPanel.Name = "ListButtonsPanel";
            this.ListButtonsPanel.Size = new System.Drawing.Size(330, 44);
            this.ListButtonsPanel.TabIndex = 8;
            this.ListButtonsPanel.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(111, -1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(102, 43);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "&FILTER";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(219, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "E&XIT";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.Gray;
            this.pnlFilter.Controls.Add(this.FilterButtonPanel);
            this.pnlFilter.Location = new System.Drawing.Point(215, 100);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(331, 227);
            this.pnlFilter.TabIndex = 9;
            this.pnlFilter.Resize += new System.EventHandler(this.pnlFilter_Resize);
            // 
            // FilterButtonPanel
            // 
            this.FilterButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.FilterButtonPanel.Controls.Add(this.btnBack);
            this.FilterButtonPanel.Controls.Add(this.btnApplyFilter);
            this.FilterButtonPanel.Location = new System.Drawing.Point(16, 165);
            this.FilterButtonPanel.Name = "FilterButtonPanel";
            this.FilterButtonPanel.Size = new System.Drawing.Size(300, 50);
            this.FilterButtonPanel.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(148, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&BACK";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.Location = new System.Drawing.Point(0, 0);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(138, 43);
            this.btnApplyFilter.TabIndex = 0;
            this.btnApplyFilter.Text = "&PREVIEW";
            this.btnApplyFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnExportAsPdf
            // 
            this.btnExportAsPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAsPdf.BackColor = System.Drawing.Color.White;
            this.btnExportAsPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAsPdf.Location = new System.Drawing.Point(422, 0);
            this.btnExportAsPdf.Name = "btnExportAsPdf";
            this.btnExportAsPdf.Size = new System.Drawing.Size(29, 26);
            this.btnExportAsPdf.TabIndex = 10;
            this.btnExportAsPdf.TabStop = false;
            this.btnExportAsPdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportAsPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportAsPdf.UseVisualStyleBackColor = false;
            this.btnExportAsPdf.Visible = false;
            this.btnExportAsPdf.Click += new System.EventHandler(this.btnExportAsPdf_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDialog.BackColor = System.Drawing.Color.White;
            this.btnPrintDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDialog.Image = global::CXLIB.Properties.Resources.printer_small;
            this.btnPrintDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintDialog.Location = new System.Drawing.Point(271, 1);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(59, 24);
            this.btnPrintDialog.TabIndex = 1;
            this.btnPrintDialog.Text = "Print &Dialog...";
            this.btnPrintDialog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintDialog.UseVisualStyleBackColor = false;
            this.btnPrintDialog.Visible = false;
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageSetup.BackColor = System.Drawing.Color.White;
            this.btnPageSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPageSetup.Location = new System.Drawing.Point(537, 1);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(103, 24);
            this.btnPageSetup.TabIndex = 2;
            this.btnPageSetup.Text = "Page &Setup...";
            this.btnPageSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPageSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPageSetup.UseVisualStyleBackColor = false;
            this.btnPageSetup.Visible = false;
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // btnPrintDirect
            // 
            this.btnPrintDirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDirect.BackColor = System.Drawing.Color.White;
            this.btnPrintDirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDirect.Image = global::CXLIB.Properties.Resources.printer_small;
            this.btnPrintDirect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintDirect.Location = new System.Drawing.Point(466, 1);
            this.btnPrintDirect.Name = "btnPrintDirect";
            this.btnPrintDirect.Size = new System.Drawing.Size(69, 24);
            this.btnPrintDirect.TabIndex = 0;
            this.btnPrintDirect.Text = "&Print";
            this.btnPrintDirect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintDirect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintDirect.UseVisualStyleBackColor = false;
            this.btnPrintDirect.Visible = false;
            this.btnPrintDirect.Click += new System.EventHandler(this.btnPrintDirect_Click);
            // 
            // FReportPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(642, 457);
            this.Controls.Add(this.btnExportAsPdf);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnPageSetup);
            this.Controls.Add(this.btnPrintDirect);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.ListButtonsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FReportPreview";
            this.Text = "Report Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.FReportPreview_Deactivate);
            this.Load += new System.EventHandler(this.FReportPreview_Load);
            this.Shown += new System.EventHandler(this.FReportPreview_Shown);
            this.Resize += new System.EventHandler(this.FReportPreview_Resize);
            this.ListButtonsPanel.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.FilterButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListButtonsPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel FilterButtonPanel;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintDirect;
        private System.Windows.Forms.Button btnPageSetup;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button btnExportAsPdf;

    }
}