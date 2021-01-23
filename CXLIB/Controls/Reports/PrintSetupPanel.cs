using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class PrintSetupPanel : UserControl
    {
        private PrinterSettings fPrnSet = new PrinterSettings();

        private PaperSize fCustomSize = new PaperSize("User Defined Paper Size", 1000, 1200); //--Kind=Custom & RawKind=0 by default.
        
       // private int fCustomSizeIndex = -1;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PrinterSettings PrinterSettings
        {
            get { return fPrnSet; }
            set 
            {
                //--fPrnSet = value;
                string newPrinterName = value.PrinterName;
                int vSelIdx = -1;
                for (int i = 0; i <= cboPrinterNames.Items.Count - 1; i++)
                {
                    string cboPrintName = cboPrinterNames.Items[i] + "";
                    if (cboPrintName == newPrinterName)
                    {
                        vSelIdx = i;
                    }
                }
                if (vSelIdx == -1)
                {
                    throw new Exception("Printer '" + newPrinterName + "' Not Found.");
                }
                else
                {
                    cboPrinterNames.SelectedIndex = vSelIdx; //--this will load default PrinterSettings. At next line overwrite new PrinterSettings. 
                    fPrnSet = value;
                    this.LoadFromPrinterSettings();
                }
            }
        }

        /*
        private PrintSetupProfile fProfile;
        public PrintSetupProfile Profile
        {
            get
            {
                return fProfile;
            }
            set
            {
                fProfile = value;
                ///
                cboPrinterNames.Items.Clear();
                int idx = cboPrinterNames.Items.Add(fProfile.PrinterName);
                cboPrinterNames.SelectedIndex = idx;
                ///
                cboPaperSizes.Items.Clear();
                PaperSize vPaperSize = new PaperSize(fProfile.PaperSizeName, fProfile.PaperSizeUWidth, fProfile.PaperSizeUHeight);
                string disp = vPaperSize.PaperName + "     [ " + vPaperSize.Width / 100.0M + " x " + vPaperSize.Height / 100.0M + " in ]     [ " + vPaperSize.Kind + "/" + vPaperSize.RawKind + " ]";
                idx = cboPaperSizes.Items.Add(new StringObjectPair(disp, vPaperSize));
                cboPaperSizes.SelectedIndex = idx;
                ///
                cboPaperSources.Items.Clear();
                PaperSource vPaperSource = new PaperSource();
                vPaperSource.SourceName = vPaperSource.SourceName;
                disp = vPaperSource.SourceName + "     [ " + vPaperSource.Kind + "/" + vPaperSource.RawKind + " ]";
                idx = cboPaperSources.Items.Add(new StringObjectPair(disp, vPaperSource));
                cboPaperSources.SelectedIndex = idx;
                ///
                PrinterResolution vPrinterResolution = new PrinterResolution();
                vPrinterResolution.Kind = (PrinterResolutionKind)fProfile.PrinterResolutionKind;
                cboPrinterResolutions.Items.Clear();
                if (vPrinterResolution.Kind == PrinterResolutionKind.Custom)
                {
                    disp = vPrinterResolution.X + " x " + vPrinterResolution.Y + "     [ " + vPrinterResolution.Kind + " ]";
                }
                else
                {
                    disp = vPrinterResolution.Kind + "     [ " + vPrinterResolution.X + " x " + vPrinterResolution.Y + " ]";
                }
                idx = cboPrinterResolutions.Items.Add(new StringObjectPair(disp, vPrinterResolution));
                cboPrinterResolutions.SelectedIndex = idx;
                ///
                if (fProfile.Landscape == true)
                {
                    radLandscape.Checked = true;
                }
                else
                {
                    radPortrait.Checked = true;
                }
                ///
                txtMarginLeft.Text = (fProfile.MarginLeft / 100.0M) + "";
                txtMarginRight.Text = (fProfile.MarginRight / 100.0M) + "";
                txtMarginTop.Text = (fProfile.MarginTop / 100.0M) + "";
                txtMarginBottom.Text = (fProfile.MarginBottom / 100.0M) + "";
            }
        }
        */

        
        public PrintSetupPanel()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //cboPrinterNames.SelectedIndexChanged += new EventHandler(cboPrinterNames_SelectedIndexChanged);
            //cboPaperSizes.SelectedIndexChanged += new EventHandler(cboPaperSizes_SelectedIndexChanged);
            //cboPaperSources.SelectedIndexChanged += new EventHandler(cboPaperSources_SelectedIndexChanged);
            //cboPrinterResolutions.SelectedIndexChanged += new EventHandler(cboPrinterResolutions_SelectedIndexChanged);

            //chkCustomPaperSize.TabStop = false;
            //txtCustomWidth.Leave += new EventHandler(txtCustomWidth_Leave);
            //txtCustomHeight.Leave += new EventHandler(txtCustomHeight_Leave);

            //txtMarginLeft.Leave += new EventHandler(txtMarginLeft_Leave);
            //txtMarginRight.Leave += new EventHandler(txtMarginRight_Leave);
            //txtMarginTop.Leave += new EventHandler(txtMarginTop_Leave);
            //txtMarginBottom.Leave += new EventHandler(txtMarginBottom_Leave);

            //chkCustomPaperSize.CheckedChanged += new EventHandler(chkCustomPaperSize_CheckedChanged);

            //radPortrait.CheckedChanged += new EventHandler(radOrientation_CheckedChanged);
            //radLandscape.CheckedChanged += new EventHandler(radOrientation_CheckedChanged);

            /////

            //LoadPrinterNames();
            //chkCustomPaperSize_CheckedChanged(null, null);
        }


        /*
        Printers List/Info
        */
        public void LoadPrinterNames()
        {
            string vDefPrinterName = GetDefaultPrinterName();
            cboPrinterNames.Items.Clear();
            foreach (string vPrinterName in PrinterSettings.InstalledPrinters)
            {
                int idx = cboPrinterNames.Items.Add(vPrinterName);
                if (vPrinterName == vDefPrinterName)
                {
                    cboPrinterNames.SelectedIndex = idx;
                }
            }
        }


        private string GetDefaultPrinterName()
        {
            PrinterSettings ps = new PrinterSettings();
            return ps.PrinterName;
        }
        /*
        private bool IsDefaultPrinter(string pPrinterName)
        {
            bool vIsDefaultPrinter = false;
            PrinterSettings prn = new PrinterSettings();
            prn.PrinterName = pPrinterName;
            if (prn.IsValid == true)
            {
                if (prn.IsDefaultPrinter == true)
                {
                    vIsDefaultPrinter = true;
                }
            }
            return vIsDefaultPrinter;
        }
        */

        void cboPrinterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPrinterNames.SelectedIndex == -1)
            {
                return;
            }

            fPrnSet = new PrinterSettings(); //-- to reset default values.
            //...but keep Margins & Landscape settings.
            fPrnSet.DefaultPageSettings.Landscape = radLandscape.Checked;
            fPrnSet.DefaultPageSettings.Margins.Top = Global.ToInteger(txtMarginTop.Text) * 100;
            fPrnSet.DefaultPageSettings.Margins.Left = Global.ToInteger(txtMarginLeft.Text) * 100;
            fPrnSet.DefaultPageSettings.Margins.Bottom = Global.ToInteger(txtMarginBottom.Text) * 100;
            fPrnSet.DefaultPageSettings.Margins.Right = Global.ToInteger(txtMarginRight.Text) * 100;
            ///
            fPrnSet.PrinterName = cboPrinterNames.Text;
            this.LoadFromPrinterSettings();
        }

        private void LoadFromPrinterSettings()
        {
            if (fPrnSet.IsValid == true)
            {
                //this.LoadPaperSizes();
                //this.LoadPaperSources();
                //this.LoadPrinterResolutions();

                if (fPrnSet.DefaultPageSettings.Landscape == true)
                {
                    radLandscape.Checked = true;
                }
                else
                {
                    radPortrait.Checked = true;
                }

                txtMarginLeft.Text = (fPrnSet.DefaultPageSettings.Margins.Left / 100.0M) + "";
                txtMarginRight.Text = (fPrnSet.DefaultPageSettings.Margins.Right / 100.0M) + "";
                txtMarginTop.Text = (fPrnSet.DefaultPageSettings.Margins.Top / 100.0M) + "";
                txtMarginBottom.Text = (fPrnSet.DefaultPageSettings.Margins.Bottom / 100.0M) + "";

                this.ShowPageSizeInfo();
            }
        }

        public void ClearPrinterSettings()
        {
            cboPrinterNames.SelectedIndex = -1;
            cboPaperSizes.SelectedIndex = -1;
            chkCustomPaperSize.Checked = false;
            txtCustomWidth.Text = "";
            txtCustomHeight.Text = "";
            cboPaperSources.SelectedIndex = -1;
            cboPrinterResolutions.SelectedIndex = -1;
            radPortrait.Checked = true;
            txtMarginLeft.Text = "";
            txtMarginRight.Text = "";
            txtMarginTop.Text = "";
            txtMarginBottom.Text = "";
        }
        /*
        Paper Sizes List/Info
        */

        /*
        private bool fCustomSizeExists = false;
        ///
        public bool CustomSizeExists
        {
            get { return fCustomSizeExists; }
            set 
            { 
                fCustomSizeExists = value;
                fCustomSizeExists = true; //-- SET ALWAYS TRUE(FOR NOW).
                if (fCustomSizeExists == false)
                {
                    chkCustomPaperSize.Checked = false;
                    chkCustomPaperSize.Enabled = false;
                }
            }
        }
        */
        //private void LoadPaperSizes()
        //{
        //    //-- First sort PaperSizes by Name.
        //    SortedList<string, PaperSize> vSortList = new SortedList<string, PaperSize>();
        //    foreach (PaperSize vPaperSize in fPrnSet.PaperSizes)
        //    {
        //        vSortList.Add(vPaperSize.PaperName, vPaperSize);
        //    }

        //    //--Add PaperSizes; Set default PaperSize; Skip Custom Size with RawKind:0.
        //    PaperSize vDefPaperSize = fPrnSet.DefaultPageSettings.PaperSize;
        //    cboPaperSizes.Items.Clear();
        //    foreach (KeyValuePair<string, PaperSize> kvp in vSortList)
        //    {
        //        PaperSize vPaperSize = kvp.Value;
        //        if (vPaperSize.Kind == PaperKind.Custom && vPaperSize.RawKind == 0)
        //        {
        //            //--skip this; becuase we are adding it manually after this loop.
        //        }
        //        else
        //        {
        //            string disp = vPaperSize.PaperName + "     [ " + vPaperSize.Width / 100.0M + " x " + vPaperSize.Height / 100.0M + " in ]"; //== +"     [ " + vPaperSize.Kind + "/" + vPaperSize.RawKind + " ]";
        //            int idx = cboPaperSizes.Items.Add(new StringObjectPair(disp, vPaperSize));
        //            if (vPaperSize.Kind == vDefPaperSize.Kind && vPaperSize.RawKind == vDefPaperSize.RawKind) //==&& vPaperSize.Width == vDefPaperSize.Width && vPaperSize.Height == vDefPaperSize.Height
        //            {
        //                cboPaperSizes.SelectedIndex = idx;
        //            }
        //        }
        //    }

        //    if (vDefPaperSize.Kind == PaperKind.Custom && vDefPaperSize.RawKind == 0)
        //    {
        //        fCustomSize.Width = vDefPaperSize.Width;
        //        fCustomSize.Height = vDefPaperSize.Height;
        //    }
        //    /* Add Custom Size with RawKind:0.; and keep the index in fCustomSizeIndex. */
        //    string dispcustom = fCustomSize.PaperName + "     [ " + fCustomSize.Kind + "/" + fCustomSize.RawKind + " ]"; ;
        //    fCustomSizeIndex = cboPaperSizes.Items.Add(new StringObjectPair(dispcustom, fCustomSize));
        //    ///
        //    if (vDefPaperSize.Kind == PaperKind.Custom && vDefPaperSize.RawKind == 0)
        //    {
        //        cboPaperSizes.SelectedIndex = fCustomSizeIndex;
        //    }
        //}

        //private bool REENTRANT = false;
        //void cboPaperSizes_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (REENTRANT == true)
        //    {
        //        return;
        //    }
        //    ///==============================================================
        //    StringObjectPair kv = (StringObjectPair)cboPaperSizes.SelectedItem;
        //    if (kv == null) return;
        //    PaperSize vPaperSize = (PaperSize)kv.Value;
        //    fPrnSet.DefaultPageSettings.PaperSize = vPaperSize;
        //    ///
        //    txtCustomWidth.Text = (vPaperSize.Width / 100.0M) + "";
        //    txtCustomHeight.Text = (vPaperSize.Height / 100.0M) + "";
        //REENTRANT = true;
        //    if (vPaperSize == fCustomSize)
        //    {
        //        chkCustomPaperSize.Checked = true; //this raises CheckedChanged event.
        //    }
        //    else
        //    {
        //        chkCustomPaperSize.Checked = false; //this raises CheckedChanged event.
        //    }
        //REENTRANT = false;
        //    ///
        //    this.ShowPageSizeInfo();
        //}

        //private void chkCustomPaperSize_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkCustomPaperSize.Checked == true)
        //    {
        //        cboPaperSizes.SelectedIndex = fCustomSizeIndex;
        //        txtCustomWidth.ReadOnly = false;
        //        txtCustomHeight.ReadOnly = false;
        //    }
        //    else
        //    {
        //        txtCustomWidth.ReadOnly = true;
        //        txtCustomHeight.ReadOnly = true;
        //    }
        //}

        //void txtCustomWidth_Leave(object sender, EventArgs e)
        //{
        //    fCustomSize.Width = Global.ToInteger(Global.ToDecimal(txtCustomWidth.Text) * 100M);
        //}

        //void txtCustomHeight_Leave(object sender, EventArgs e)
        //{
        //    fCustomSize.Height = Global.ToInteger(Global.ToDecimal(txtCustomHeight.Text) * 100M);
        //}


        ///*
        //Paper Sources List/Info
        //*/
        //private void LoadPaperSources()
        //{
        //    PaperSource vDefPaperSource = fPrnSet.DefaultPageSettings.PaperSource;
        //    cboPaperSources.Items.Clear();
        //    foreach (PaperSource vPaperSource in fPrnSet.PaperSources)
        //    {
        //        string disp = vPaperSource.SourceName; //== +"     [ " + vPaperSource.Kind + "/" + vPaperSource.RawKind + " ]";
        //        int idx = cboPaperSources.Items.Add(new StringObjectPair(disp, vPaperSource));
        //        if (vPaperSource.RawKind == vDefPaperSource.RawKind)
        //        {
        //            cboPaperSources.SelectedIndex = idx;
        //        }
        //    }
        //}

        //void cboPaperSources_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    StringObjectPair kv = (StringObjectPair)cboPaperSources.SelectedItem;
        //    if (kv == null) return;
        //    PaperSource vPaperSource = (PaperSource)kv.Value;
        //    fPrnSet.DefaultPageSettings.PaperSource = vPaperSource;
        //    ///
        //    this.ShowPageSizeInfo();
        //}



        ///*
        //Printer Resolution List/Info
        //*/
        //private void LoadPrinterResolutions()
        //{
        //    PrinterResolution vDefPrinterResolution = fPrnSet.DefaultPageSettings.PrinterResolution;
        //    cboPrinterResolutions.Items.Clear();
        //    foreach (PrinterResolution vPrinterResolution in fPrnSet.PrinterResolutions)
        //    {
        //        string disp;
        //        if (vPrinterResolution.Kind == PrinterResolutionKind.Custom)
        //        {
        //            disp = vPrinterResolution.X + " x " + vPrinterResolution.Y; //== +"     [ " + vPrinterResolution.Kind + " ]";
        //        }
        //        else
        //        {
        //            disp = vPrinterResolution.Kind.ToString(); //== +"     [ " + vPrinterResolution.X + " x " + vPrinterResolution.Y + " ]";
        //        }
        //        int idx = cboPrinterResolutions.Items.Add(new StringObjectPair(disp, vPrinterResolution));
        //        if (vPrinterResolution.X == vDefPrinterResolution.X && vPrinterResolution.Y == vDefPrinterResolution.Y)
        //        {
        //            cboPrinterResolutions.SelectedIndex = idx;
        //        }
        //    }
        //}

        //void cboPrinterResolutions_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    StringObjectPair kv = (StringObjectPair)cboPrinterResolutions.SelectedItem;
        //    if (kv == null) return;
        //    PrinterResolution vPrinterResolution = (PrinterResolution)kv.Value;
        //    fPrnSet.DefaultPageSettings.PrinterResolution = vPrinterResolution;
        //    ///
        //    this.ShowPageSizeInfo();
        //}

        /*
        Printer Resolution
        */

        private void radOrientation_CheckedChanged(object sender, EventArgs e)
        {
            if (radPortrait.Checked == true)
            {
                fPrnSet.DefaultPageSettings.Landscape = false;
            }
            else if (radLandscape.Checked == true)
            {
                fPrnSet.DefaultPageSettings.Landscape = true;
            }
            else
            {
                return;
            }
            ///
            this.ShowPageSizeInfo();
        }


        /*
        Margins
        */
        void txtMarginLeft_Leave(object sender, EventArgs e)
        {
            fPrnSet.DefaultPageSettings.Margins.Left = Global.ToInteger(Global.ToDecimal(txtMarginLeft.Text) * 100M);
        }

        void txtMarginRight_Leave(object sender, EventArgs e)
        {
            fPrnSet.DefaultPageSettings.Margins.Right = Global.ToInteger(Global.ToDecimal(txtMarginRight.Text) * 100M);
        }

        void txtMarginTop_Leave(object sender, EventArgs e)
        {
            fPrnSet.DefaultPageSettings.Margins.Top = Global.ToInteger(Global.ToDecimal(txtMarginTop.Text) * 100M);
        }

        void txtMarginBottom_Leave(object sender, EventArgs e)
        {
            fPrnSet.DefaultPageSettings.Margins.Bottom = Global.ToInteger(Global.ToDecimal(txtMarginBottom.Text) * 100M);
        }

        private void ShowPageSizeInfo()
        {
            lblMarginDetails.Text =
                "Hard Magins => Left: " + string.Format("{0:0.0##}", fPrnSet.DefaultPageSettings.HardMarginX / 100.0d)
                + ",  Top: " + string.Format("{0:0.0##}", fPrnSet.DefaultPageSettings.HardMarginY / 100.0d) + "\r\n";

            RectangleF rp = fPrnSet.DefaultPageSettings.PrintableArea;
            lblMarginDetails.Text +=
                "Printable Area available=> Left " + string.Format("{0:0.0##}", rp.Left / 100.0d)
                + ", Top: " + string.Format("{0:0.0##}", rp.Top / 100.0d)
                + ", Width: " + string.Format("{0:0.0##}", rp.Width / 100.0d)
                + ", Height: " + string.Format("{0:0.0##}", rp.Height / 100.0d) + " (as Portrait)\r\n";

            Rectangle rb = fPrnSet.DefaultPageSettings.Bounds;
            lblMarginDetails.Text +=
                "Full Area => Left: " + string.Format("{0:0.0##}", rb.Left / 100.0M)
                + ", Top: " + string.Format("{0:0.0##}", rb.Top / 100.0M)
                + ", Width: " + string.Format("{0:0.0##}", rb.Width / 100.0M)
                + ",  Height: " + string.Format("{0:0.0##}", rb.Height / 100.0M) + "\r\n";
        }


        private bool fReadOnly = false;
        ///
        public bool ReadOnly
        {
            get { return fReadOnly; }
            set 
            { 
                fReadOnly = value; 
                bool vEnabled = !fReadOnly;
                ///
                cboPrinterNames.Enabled = vEnabled;
                cboPaperSizes.Enabled = vEnabled;
                cboPaperSources.Enabled = vEnabled;
                cboPrinterResolutions.Enabled = vEnabled;
                ////
                radPortrait.Enabled = vEnabled;
                radLandscape.Enabled = vEnabled;
                ///
                txtMarginLeft.ReadOnly = fReadOnly;
                txtMarginRight.ReadOnly = fReadOnly;
                txtMarginTop.ReadOnly = fReadOnly;
                txtMarginBottom.ReadOnly = fReadOnly;
            }
        }

    
    }

    public enum PrintSetupMode
    {
        Editable,
        Dummy /*Read-Only mode*/
    }
}
