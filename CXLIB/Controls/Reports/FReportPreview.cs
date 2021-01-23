using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

namespace CXLIB
{
    public partial class FReportPreview : Form
    {
        public ReportViewer reportViewer1 = new ReportViewer();
        private IReportFilterPanel pnlFilterImpl;
        private bool IsReportMode; // or Print Mode

        public FReportPreview()
        {
            Init();
            ///
            IsReportMode = false;
            pnlFilter.Visible = false;
            btnFilter.Visible = false;
            btnClose.Location = btnFilter.Location;
            ///
            ListButtonsPanel.Visible = false;
        }

        public FReportPreview(IReportFilterPanel p_FilterImpl)
        {
            Init();
            ///
            IsReportMode = true;
            pnlFilter.Visible = true;
            btnFilter.Visible = true;
            ///
            pnlFilterImpl = p_FilterImpl;
            pnlFilterImpl.BackColor = Color.Transparent;
            pnlFilter.Visible = false;
            pnlFilter.Controls.Add(pnlFilterImpl);
        }

        private void Init()
        {
            InitializeComponent();
            ///
            PrinterSettings vPrinterSettings = new PrinterSettings();
            vPrinterSettings.DefaultPageSettings.Margins.Left = 0;
            vPrinterSettings.DefaultPageSettings.Margins.Right = 0;
            vPrinterSettings.DefaultPageSettings.Margins.Top = 0;
            vPrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            reportViewer1.SetPageSettings(vPrinterSettings.DefaultPageSettings);
            reportViewer1.PrinterSettings = vPrinterSettings; /*init*/
            ///
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.ShowToolBar = true;
            reportViewer1.ShowPageNavigationControls = true;
            reportViewer1.ShowExportButton = true;
            reportViewer1.ShowPrintButton = false;
            reportViewer1.ShowRefreshButton = false;
            reportViewer1.ShowStopButton = false;
            reportViewer1.ShowBackButton = false; /*Back to Parent Report*/
            reportViewer1.ShowDocumentMapButton = false;
            reportViewer1.ShowFindControls = false;
            reportViewer1.ShowContextMenu = false;
            reportViewer1.ContextMenu = null;
            reportViewer1.ContextMenuStrip = null;
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            ///

            Color ButtonBackColor = Color.FromArgb(239, 228, 176);
            Color ButtonForeColor = Color.Navy;
            Color FormBackColor = Color.Silver; //Color.FromArgb(239, 228, 176);  //Color.Azure;

            this.BackColor = FormBackColor;

            btnFilter.BackColor = ButtonBackColor;
            btnFilter.ForeColor = ButtonForeColor;

            btnClose.BackColor = ButtonBackColor;
            btnClose.ForeColor = ButtonForeColor;

            btnApplyFilter.BackColor = ButtonBackColor;
            btnApplyFilter.ForeColor = ButtonForeColor;

            btnBack.BackColor = ButtonBackColor;
            btnBack.ForeColor = ButtonForeColor;

            ///
            //==this.CancelButton = button1;
            this.MinimizeBox = false;
            this.MaximizeBox = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new FormClosingEventHandler(FReportPreview_FormClosing);

            reportViewer1.StatusChanged += new EventHandler<EventArgs>(reportViewer1_StatusChanged);
        }

        private void FReportPreview_Shown(object sender, EventArgs e)
        {
            if (IsReportMode == true)
            {
                if (pnlFilterImpl == null)
                {
                    throw new Exception("pnlFilterImpl is not passed to FReportPreview form.");
                }
                ///
                btnFilter_Click(null, null);
            }
        }

        private void FReportPreview_Resize(object sender, EventArgs e)
        {
            pnlFilter_Resize(null, null);
        }

        private void FReportPreview_Load(object sender, EventArgs e)
        {
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnlFilterImpl != null)
            {
                reportViewer1.Enabled = false;
                ListButtonsPanel.Enabled = false;
                ///
                pnlFilter.Visible = true;
                pnlFilterImpl.Focus();
            }
            ///
            ///see: btnApplyFilter_Click()
        }

        //--private bool fPrinted = false;
        void reportViewer1_StatusChanged(object sender, EventArgs e)
        {
            /*
            if (reportViewer1.CurrentStatus.CanPrint == true)
            {
                try
                {
                    if (fPrinted == false)
                    {
                        reportViewer1.PrintDialog();
                        fPrinted = true;
                    }
                }
                catch (Exception ex)
                {
                    //--do not show error.
                }
            }
            */
        }

        void FReportPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        /*
        void crystalReportViewer1_DoubleClick(object sender, EventArgs e)
        {
            btnFilter_Click(null, null);
        }

        void crystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            btnFilter_Click(null, null);
            e.Handled = false;
        }
        */

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {

        }

        private void pnlFilter_Resize(object sender, EventArgs e)
        {
            if (IsReportMode == false)
            {
                return;
            }
            ///
            if (FilterButtonPanel.Width > pnlFilterImpl.Width)
            {
                pnlFilter.Width = FilterButtonPanel.Width + 10;
            }
            else
            {
                pnlFilter.Width = pnlFilterImpl.Width + 10;
            }

            pnlFilterImpl.Left = (pnlFilter.Width-1) / 2 - pnlFilterImpl.Width / 2;
            FilterButtonPanel.Left = pnlFilter.Width / 2 - FilterButtonPanel.Width / 2;

            pnlFilterImpl.Top = 10;
            FilterButtonPanel.Top = pnlFilterImpl.Height + 10;

            pnlFilter.Height = FilterButtonPanel.Bottom + 10;
            ///
            pnlFilter.Left = this.Width / 2 - pnlFilter.Width / 2;
            pnlFilter.Top = this.Height / 2 - pnlFilter.Height / 2;
        }

        private void FReportPreview_Deactivate(object sender, EventArgs e)
        {
            //==this.Dispose();
        }

        public void PrintImmediate()
        {
            MSRptViewerUtil.SendToPrinter(reportViewer1.LocalReport, reportViewer1.PrinterSettings);
        }

        private void btnPrintDirect_Click(object sender, EventArgs e)
        {
            this.PrintImmediate();
            this.Hide();
            this.Dispose();
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            //--reportViewer1.PageSetupDialog();
            PrintDialog dlg = new PrintDialog();
            dlg.PrinterSettings = reportViewer1.PrinterSettings;
            dlg.CurrentPage = reportViewer1.CurrentPage;
            dlg.LastPage = reportViewer1.GetTotalPages();
            DialogResult dres = dlg.ShowDialog();
            ///
            if (dres == DialogResult.Yes || dres == DialogResult.OK) /*-- Print || Apply --*/
            {
                reportViewer1.PrinterSettings = dlg.PrinterSettings;
                reportViewer1.SetPageSettings(dlg.PrinterSettings.DefaultPageSettings);
                reportViewer1.RefreshReport();
                ///
                if (dres == DialogResult.Yes ) /*-- Print --*/
                {
                    this.PrintImmediate();
                }
            }
            else /*--Cancel*/
            {
            }
            ///
            dlg.Dispose();
        }

        private void btnExportAsPdf_Click(object sender, EventArgs e)
        {
            string vFileName =
                Application.StartupPath
                + "\\TEMP\\"
                + "Export"
                + "_"
                + DateTime.Now.ToString("ddMMMyy_hhmmsstt")
                + "."
                + "pdf";
            MSRptViewerUtil.ExportAsPDF(reportViewer1.LocalReport, reportViewer1.PrinterSettings, vFileName);
            System.Diagnostics.Process.Start(vFileName);
        }

        /*
        //-- Invoke report-viewer's page-setup-dialog --//
        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            reportViewer1.PageSetupDialog();
        }

        //-- Invoke report-viewer's print-dialog --//
        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            DialogResult dres = reportViewer1.PrintDialog();
            if (dres == DialogResult.OK)
            {
                if (IsReportMode == false)
                {
                    this.Hide();
                    this.Dispose();
                }
            }
        }
        */

    }//cls//


    /////////////////////////////////////////////////////////////////////////////////////

}//ns//


