using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CXLIB
{
    public partial class PrintDialog : Form
    {
        private PrintSetupData fPrintSetupData;

        public int CurrentPage = 0; //0 means unknown. so unsupported option.
        public int LastPage = 0; //0 means unknown. so unsupported option.

        public PrintDialog()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //pnlButtonsList.GradientStartColor = Color.FromArgb(110, 140, 200);
            //pnlButtonsList.GradientEndColor = Color.FromArgb(110, 140, 200);
            //pnlButtonsList.RoundCornerRadius = 25;
            ///
            this.FetchProfiles();
            ///
            txtPageRange.TabStop = false;
            ///
            txtCopies.Value = 1;
            chkCollate.Checked = false;
            chkCollate.Enabled = false;
            ///
            this.Shown += new EventHandler(PrintDialog_Shown);
            cboProfileName.SelectedIndexChanged += new EventHandler(cboProfileName_SelectedIndexChanged);
        }

        void PrintDialog_Shown(object sender, EventArgs e)
        {
            txtPageRange.Text = "1-" + this.LastPage;
        }

        private void FetchProfiles()
        {
            /*
             * GET DATA FROM FILE
             */
            fPrintSetupData = PrintSetupData.ReadFromFile();
            SortedList<string, PrintSetupProfile> vProfiles = fPrintSetupData.Profiles;

            /*
             * LOAD DATA INTO LISTBOX
             */
            foreach (KeyValuePair<string, PrintSetupProfile> kvp in vProfiles)
            {
                PrintSetupProfile vProfile = kvp.Value;
                cboProfileName.Items.Add(vProfile.ProfileName);
            }
        }

        void cboProfileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vProfileName = cboProfileName.Text;
            if (fPrintSetupData.Profiles.ContainsKey(vProfileName))
            {
                try
                {
                    PrintSetupProfile vProfile = fPrintSetupData.Profiles[vProfileName];
                    pnlPrinterSetup.PrinterSettings = vProfile.GetPrinterSettings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" "+ ex +" ");
                    //--ignore.
                }
            }
        }

        public PrinterSettings PrinterSettings
        {
            set
            {
                pnlPrinterSetup.PrinterSettings = value;
            }
            get
            {
                PrinterSettings vPrinterSettings = pnlPrinterSetup.PrinterSettings;
                ///
                if (radAllPages.Checked == true)
                {
                    vPrinterSettings.PrintRange = PrintRange.AllPages;
                }
                else if (radCurrentPage.Checked == true)
                {
                    vPrinterSettings.PrintRange = PrintRange.SomePages;
                    vPrinterSettings.FromPage = this.CurrentPage;
                    vPrinterSettings.ToPage = vPrinterSettings.FromPage;
                }
                else if (radSomPages.Checked == true)
                {
                    vPrinterSettings.PrintRange = PrintRange.SomePages;
                    if (txtPageRange.Text.IndexOf("-") == -1)
                    {
                        vPrinterSettings.FromPage = Global.ToInteger(txtPageRange.Text);
                        vPrinterSettings.ToPage = vPrinterSettings.FromPage;
                    }
                    else
                    {
                        string[] splits = txtPageRange.Text.Split('-');
                        vPrinterSettings.FromPage = Global.ToInteger(splits[0]);
                        vPrinterSettings.ToPage = Global.ToInteger(splits[1]);
                    }
                }
                ///
                vPrinterSettings.Copies = (short)txtCopies.Value;
                vPrinterSettings.Collate = chkCollate.Checked;
                ///
                return vPrinterSettings;
            }
        }

        private new bool Validate()
        {
            bool isValid = true;
            ///
            ///
            if (radSomPages.Checked == true)
            {
                bool isValidRange = true;
                bool isValidPage = true;
                if (txtPageRange.Text.IndexOf("-") == -1)
                {
                    if (Global.IsIntegerNumber(txtPageRange.Text) == false)
                    {
                        isValidRange = false;
                    }
                    else
                    {
                        int vPageToPrint = Global.ToInteger(txtPageRange.Text);
                        if (vPageToPrint < 1 || vPageToPrint > LastPage)
                        {
                            isValidPage = false;
                        }
                    }
                }
                else
                {
                    string[] splits = txtPageRange.Text.Split('-');
                    if (Global.IsIntegerNumber(splits[0]) == false)
                    {
                        isValidRange = false;
                    }
                    else if (Global.IsIntegerNumber(splits[1]) == false)
                    {
                        isValidRange = false;
                    }
                    else
                    {
                        int vFromPage = Global.ToInteger(splits[0]);
                        int vToPage = Global.ToInteger(splits[1]);
                        if (vFromPage < 1
                            || vToPage > this.LastPage
                            || vFromPage > vToPage
                            )
                        {
                            isValidPage = false;
                        }
                    }
                }
                ///
                if (isValidRange == false)
                {
                    isValid = false;
                    string msg = "Enter either a single page number (for example 5)\r\nor a single page range. (for example 5-12)";
                    MessageBox.Show(this, msg, "Page Range...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (isValidPage == false)
                {
                    isValid = false;
                    string msg = "Entered page number is not in the range. Please check it.";
                    MessageBox.Show(this, msg, "Page Range...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ///
            ///
            return isValid;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (this.Validate() == false)
            {
                return;
            }
            ///
            base.DialogResult = DialogResult.OK; /*--OK for Apply--*/
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel; /*--Cancel for do-nothing--*/
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.Validate() == false)
            {
                return;
            }
            ///
            base.DialogResult = DialogResult.Yes; /*--Yes for Print--*/
            this.Hide();
        }

        private void txtCopies_ValueChanged(object sender, EventArgs e)
        {
            if (txtCopies.Value == 1)
            {
                chkCollate.Checked = false;
                chkCollate.Enabled = false;
            }
            else if (txtCopies.Value >= 2)
            {
                chkCollate.Enabled = true;
            }
        }

        private void chkCollate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCollate.Checked == true)
            {
               // picCollate.Image = CXLIB.Properties.Resources.collate_yes;
            }
            else if (chkCollate.Checked == false)
            {
               // picCollate.Image = CXLIB.Properties.Resources.collate_no;
            }
        }

        private void txtPageRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radSomPages.Checked != true)
            {
                radSomPages.Checked = true;
            }
        }

        private void radSomPages_CheckedChanged(object sender, EventArgs e)
        {
            if (radSomPages.Checked == true)
            {
                txtPageRange.TabStop = true;
                txtPageRange.Focus();
            }
            else
            {
                txtPageRange.TabStop = false;
            }
        }



    }//class
}//ns

