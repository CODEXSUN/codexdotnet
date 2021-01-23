// Version : 3 dt : 01-08-2017
// Auto Generated
// 24-08-2017 08:42:33 PM
// last update : 24-08-2017

using System;
using System.Windows.Forms;
using System.Drawing;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXUPVC
{
    public partial class FUpvc_quotation : UserControl
    {

        #region[Split Timer]

        private bool expand;

        private void SplitTimer_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (split_container.SplitterDistance < Convert.ToInt32(ClientSize.Width) - 29)
                {
                    split_container.SplitterDistance += 50;
                }
                else
                {
                    btn_splitter.Text = "⁞⁞";
                    expand = false;
                    splitTimer.Stop();
                }
            }
            else
            {
                if (split_container.SplitterDistance > Convert.ToInt32(ClientSize.Width) - 150)
                {
                    split_container.SplitterDistance += -50;
                }
                else
                {
                    btn_splitter.Text = ">>";
                    expand = true;
                    splitTimer.Stop();
                }
            }
        }
        private void Btn_splitter_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            Form_NeedToRefresh();
        }

        #endregion[Split Timer]

        #region[Txt Change]
        private void Txt_additional_TextChanged(object sender, EventArgs e)
        {
            RefreshRowtotal();
        }

        #endregion[Txt Change]

        #region[Enter Event]

        private void Txt_upvc_salesmode_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_upvc_salesmode_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_upvc_salesmode_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_upvc_salesmode_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_upvc_quotation_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_upvc_quotation_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_upvc_quotation_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_upvc_quotation_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_upvc_quotation_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_upvc_quotation_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_upvc_quotation_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_upvc_quotation_date.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_party_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_shipping_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_shipping_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_shipping_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_shipping_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        //private void Txt_transport_mode_id_Enter(object sender, EventArgs e)
        //{
        //    Change_infocus();
        //    lbl_transport_mode_id.BackColor = Theme.lbl_EnterBackColor;
        //    lbl_transport_mode_id.BorderColor = Theme.lbl_EnterBorderColor;
        //    lbl_transport_mode_id.ForeColor = Theme.lbl_EnterForeColor;
        //}
        //private void Txt_vehicle_no_Enter(object sender, EventArgs e)
        //{
        //    Change_infocus();
        //    lbl_vehicle_no.BackColor = Theme.lbl_EnterBackColor;
        //    lbl_vehicle_no.BorderColor = Theme.lbl_EnterBorderColor;
        //    lbl_vehicle_no.ForeColor = Theme.lbl_EnterForeColor;
        //}
        private void Txt_total_qty_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_total_qty.BackColor = Theme.lbl_EnterBackColor;
            lbl_total_qty.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_total_qty.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_gsttotal_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_gsttotal.BackColor = Theme.lbl_EnterBackColor;
            lbl_gsttotal.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_gsttotal.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_ledger_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ledger_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_ledger_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ledger_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_additional_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_additional.BackColor = Theme.lbl_EnterBackColor;
            lbl_additional.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_additional.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_grandtotal_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_grandtotal.BackColor = Theme.lbl_EnterBackColor;
            lbl_grandtotal.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_grandtotal.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_notes_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_notes.BackColor = Theme.lbl_EnterBackColor;
            lbl_notes.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_notes.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {

            lbl_upvc_salesmode_id.BackColor = Theme.lbl_BackColor;
            lbl_upvc_salesmode_id.BorderColor = Theme.lbl_BorderColor;
            lbl_upvc_salesmode_id.ForeColor = Theme.lbl_ForeColor;

            lbl_upvc_quotation_no.BackColor = Theme.lbl_BackColor;
            lbl_upvc_quotation_no.BorderColor = Theme.lbl_BorderColor;
            lbl_upvc_quotation_no.ForeColor = Theme.lbl_ForeColor;

            lbl_upvc_quotation_date.BackColor = Theme.lbl_BackColor;
            lbl_upvc_quotation_date.BorderColor = Theme.lbl_BorderColor;
            lbl_upvc_quotation_date.ForeColor = Theme.lbl_ForeColor;

            lbl_party_id.BackColor = Theme.lbl_BackColor;
            lbl_party_id.BorderColor = Theme.lbl_BorderColor;
            lbl_party_id.ForeColor = Theme.lbl_ForeColor;

            lbl_shipping_id.BackColor = Theme.lbl_BackColor;
            lbl_shipping_id.BorderColor = Theme.lbl_BorderColor;
            lbl_shipping_id.ForeColor = Theme.lbl_ForeColor;

            //lbl_transport_mode_id.BackColor = Theme.lbl_BackColor;
            //lbl_transport_mode_id.BorderColor = Theme.lbl_BorderColor;
            //lbl_transport_mode_id.ForeColor = Theme.lbl_ForeColor;

            //lbl_vehicle_no.BackColor = Theme.lbl_BackColor;
            //lbl_vehicle_no.BorderColor = Theme.lbl_BorderColor;
            //lbl_vehicle_no.ForeColor = Theme.lbl_ForeColor;

            lbl_total_qty.BackColor = Theme.lbl_BackColor;
            lbl_total_qty.BorderColor = Theme.lbl_BorderColor;
            lbl_total_qty.ForeColor = Theme.lbl_ForeColor;

            lbl_gsttotal.BackColor = Theme.lbl_BackColor;
            lbl_gsttotal.BorderColor = Theme.lbl_BorderColor;
            lbl_gsttotal.ForeColor = Theme.lbl_ForeColor;

            lbl_ledger_id.BackColor = Theme.lbl_BackColor;
            lbl_ledger_id.BorderColor = Theme.lbl_BorderColor;
            lbl_ledger_id.ForeColor = Theme.lbl_ForeColor;

            lbl_additional.BackColor = Theme.lbl_BackColor;
            lbl_additional.BorderColor = Theme.lbl_BorderColor;
            lbl_additional.ForeColor = Theme.lbl_ForeColor;

            lbl_grandtotal.BackColor = Theme.lbl_BackColor;
            lbl_grandtotal.BorderColor = Theme.lbl_BorderColor;
            lbl_grandtotal.ForeColor = Theme.lbl_ForeColor;

            lbl_notes.BackColor = Theme.lbl_BackColor;
            lbl_notes.BorderColor = Theme.lbl_BorderColor;
            lbl_notes.ForeColor = Theme.lbl_ForeColor;

        }

        #endregion[Enter Event]

        #region[Btn Event ]

        private void Btn_salestype_Click(object sender, EventArgs e)
        {
            ToggleSalestype();
        }

        private void Btn_active_Click(object sender, EventArgs e)
        {
            ToggleActive();
        }

        private void Btn_save_click(object sender, EventArgs e)
        {
            Save_Event();
        }

        private void Btn_list_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
            this.Hide();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            splitTimer.Enabled = true;
            SetAction(BtnEvent.New, null);
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Edit, vId);
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                SetAction(BtnEvent.Delete, vId);
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            if (vId != "")
            {
                splitTimer.Enabled = true;
                print_panel.BringToFront();
                SetAction(BtnEvent.Print, vId);
                print_panel.Show();
            }
        }

        #endregion[Btn Event ]

        #region[Lbl Event ]

        private void Lbl_notes_Click(object sender, EventArgs e)
        {
            txt_notes.Refresh();
            if (txt_notes.Height == 600)
            {
                txt_notes.BackColor = Color.White;
                txt_notes.Width = Theme.F_txt_notes_width - 100;
                txt_notes.Height = Theme.F_txt_notes_height;
                txt_notes.Location = new Point(Theme.txt_left, Theme.Fpanel_height - 75);
            }
            else if (txt_notes.Height == Theme.F_txt_notes_height)
            {
                txt_notes.Location = new Point(lbl_notes.Right - 1, 137);
                txt_notes.Width = 1170;
                txt_notes.Height = 600;
                txt_notes.BackColor = Color.FromArgb(255, 255, 192);
            }
        }
        #endregion[Lbl Event ]

        #region[Sales Type Toggle]
        private void ToggleSalestype()
        {
            if (btn_salestype.Text != Core.SGST)
            {
                btn_salestype.Themes = Themescheme.Yellow;
                btn_salestype.Text = Core.SGST;
                Core.TaxType = Core.SGST;
                editgrid.Columns[UPVC_QUOTATIONITEMS.SGST_PERCENT].Visible = true;
                editgrid.Columns[UPVC_QUOTATIONITEMS.CGST_PERCENT].Visible = true;
                editgrid.Columns[UPVC_QUOTATIONITEMS.IGST_PERCENT].Visible = false;
                RefreshRowtotal();
            }
            else
            {
                btn_salestype.Themes = Themescheme.Pink;
                btn_salestype.Text = Core.IGST;
                Core.TaxType = Core.IGST;
                editgrid.Columns[UPVC_QUOTATIONITEMS.SGST_PERCENT].Visible = false;
                editgrid.Columns[UPVC_QUOTATIONITEMS.CGST_PERCENT].Visible = false;
                editgrid.Columns[UPVC_QUOTATIONITEMS.IGST_PERCENT].Visible = true;
                RefreshRowtotal();
            }
        }
        private void SetSalestype()
        {
            if (Core.TaxType == Core.SGST)
            {
                btn_salestype.Themes = Themescheme.Yellow;
                btn_salestype.Text = Core.SGST;
                editgrid.Columns[UPVC_QUOTATIONITEMS.SGST_PERCENT].Visible = true;
                editgrid.Columns[UPVC_QUOTATIONITEMS.CGST_PERCENT].Visible = true;
                editgrid.Columns[UPVC_QUOTATIONITEMS.IGST_PERCENT].Visible = false;
                RefreshRowtotal();
                this.Refresh();
            }
            else if (Core.TaxType == Core.IGST)
            {
                btn_salestype.Themes = Themescheme.Pink;
                btn_salestype.Text = Core.IGST;
                editgrid.Columns[UPVC_QUOTATIONITEMS.SGST_PERCENT].Visible = false;
                editgrid.Columns[UPVC_QUOTATIONITEMS.CGST_PERCENT].Visible = false;
                editgrid.Columns[UPVC_QUOTATIONITEMS.IGST_PERCENT].Visible = true;
                RefreshRowtotal();
                this.Refresh();
            }
        }

        #endregion[Sales Type Toggle]

        #region[Active Event ]

        private void ToggleActive()
        {
            if (btn_active.Text != Core.ACTIVE_TXT)
            {
                btn_active.Themes = Themescheme.Green;
                btn_active.Text = Core.ACTIVE_TXT;
                Core.Stative = Core.Active;
            }
            else
            {
                btn_active.Themes = Themescheme.RED;
                btn_active.Text = Core.NOTACTIVE_TXT;
                Core.Stative = Core.NotActive;
            }
        }

        private void Setactives()
        {
            if (Core.Stative == Core.Active)
            {
                btn_active.Themes = Themescheme.Green;
                btn_active.Text = Core.ACTIVE_TXT;
                btn_save.Focus();
                this.Refresh();
            }
            else if (Core.Stative == Core.NotActive)
            {
                btn_active.Themes = Themescheme.RED;
                btn_active.Text = Core.NOTACTIVE_TXT;
                this.Refresh();
            }
            else if (Core.Stative == Core.Idle)
            {
                btn_active.Themes = Themescheme.WHITE;
                btn_active.Text = Core.IDLE_TXT;
            }
        }

        #endregion[Active Event ]

        #region[Raise Event ]

        public event EventHandler FUpvc_quotation_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            if (FUpvc_quotation_NeedToRefresh != null)
            {
                FUpvc_quotation_NeedToRefresh(this, new EventArgs());
            }
        }
        #endregion[Raise Event ]

        #region[Upvc_salesmode Lookup]

        public void Upvc_salesmode_lookup()
        {
            txt_upvc_salesmode_id.LookupColNames = new string[] { UPVC_SALESMODE.UPVC_SALESMODE_NAME };
            txt_upvc_salesmode_id.LookupUpdate += txt_upvc_salesmode_LookupUpdate;
            txt_upvc_salesmode_id.AllowNewEntry = true;
            txt_upvc_salesmode_id.NewEntryNeeded += txt_upvc_salesmode_NewEntryNeeded;
        }
        void txt_upvc_salesmode_LookupUpdate(object sender, EventArgs e)
        {
            txt_upvc_salesmode_id.LookupList = CUpvc_salesmode_exten.GetforLookup(new DAL());
        }
        private FUpvc_salesmode xupvc_salesmode = null;
        void txt_upvc_salesmode_NewEntryNeeded(object sender, string pValue)
        {
            if (xupvc_salesmode == null)
            {
                xupvc_salesmode = new FUpvc_salesmode();
                xupvc_salesmode.FUpvc_salesmode_NeedToRefresh += Upvc_salesmode_NeedToRefresh;
            }
            this.Parent.Controls.Add(xupvc_salesmode);
            xupvc_salesmode.Dock = DockStyle.Fill;
            xupvc_salesmode.Show();
            xupvc_salesmode.BringToFront();
            xupvc_salesmode.Focus();

            xupvc_salesmode.SetAction(BtnEvent.New, null);
            xupvc_salesmode.SetFocus();
            xupvc_salesmode.setname(pValue);
        }
        void Upvc_salesmode_NeedToRefresh(object sender, EventArgs e)
        {
            txt_upvc_salesmode_id.Text = xupvc_salesmode.GetName();
            txt_upvc_quotation_no.Focus();
        }

        #endregion[Upvc_salesmodeLookup]

        #region[Party Lookup]

        public void Party_lookup()
        {
            txt_party_id.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_party_id.LookupUpdate += Txt_party_LookupUpdate;
            txt_party_id.AllowNewEntry = true;
            txt_party_id.NewEntryNeeded += Txt_party_NewEntryNeeded;
        }
        void Txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_party_id.LookupList = CParty_exten.GetforLookup(new DAL());
        }
        private FParty xparty = null;
        void Txt_party_NewEntryNeeded(object sender, string pValue)
        {
            if (xparty == null)
            {
                xparty = new FParty();
                xparty.FParty_NeedToRefresh += Party_NeedToRefresh;
            }
            this.Parent.Controls.Add(xparty);
            xparty.Dock = DockStyle.Fill;
            xparty.Show();
            xparty.BringToFront();
            xparty.Focus();

            xparty.SetAction(BtnEvent.New, null);
            xparty.SetFocus();
            xparty.setname(pValue);
        }
        void Party_NeedToRefresh(object sender, EventArgs e)
        {
            txt_party_id.Text = xparty.GetName();
            txt_shipping_id.Focus();
        }

        #endregion[PartyLookup]

        #region[Shipping Lookup]

        public void Shipping_lookup()
        {
            txt_shipping_id.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_shipping_id.LookupUpdate += Txt_shipping_LookupUpdate;
            txt_shipping_id.AllowNewEntry = true;
            txt_shipping_id.NewEntryNeeded += Txt_Shipping_NewEntryNeeded;
        }
        void Txt_shipping_LookupUpdate(object sender, EventArgs e)
        {
            txt_shipping_id.LookupList = CParty_exten.GetforLookup(new DAL());
        }
        private FParty yparty = null;
        void Txt_Shipping_NewEntryNeeded(object sender, string pValue)
        {
            if (yparty == null)
            {
                yparty = new FParty();
                yparty.FParty_NeedToRefresh += Shipping_NeedToRefresh;
            }
            this.Parent.Controls.Add(yparty);
            yparty.Dock = DockStyle.Fill;
            yparty.Show();
            yparty.BringToFront();
            yparty.Focus();

            yparty.SetAction(BtnEvent.New, null);
            yparty.SetFocus();
            yparty.setname(pValue);
        }
        void Shipping_NeedToRefresh(object sender, EventArgs e)
        {
            txt_shipping_id.Text = xparty.GetName();
            //txt_transport_mode_id.Focus();
        }
        #endregion[ShippingLookup]

        //#region[Transport_mode Lookup]

        //public void Transport_mode_lookup()
        //{
        //    txt_transport_mode_id.LookupColNames = new string[] { TRANSPORT.TRANSPORT_NAME };
        //    txt_transport_mode_id.LookupUpdate += txt_transport_mode_LookupUpdate;
        //    txt_transport_mode_id.AllowNewEntry = true;
        //    txt_transport_mode_id.NewEntryNeeded += txt_transport_mode_NewEntryNeeded;
        //}
        //void txt_transport_mode_LookupUpdate(object sender, EventArgs e)
        //{
        //    txt_transport_mode_id.LookupList = CTransport_mode_exten.GetforLookup(new DAL());
        //}
        //private FTransport_mode xtransport_mode = null;
        //void txt_transport_mode_NewEntryNeeded(object sender, string pValue)
        //{
        //    if (xtransport_mode == null)
        //    {
        //        xtransport_mode = new FTransport_mode();
        //        xtransport_mode.FTransport_mode_NeedToRefresh += Transport_mode_NeedToRefresh;
        //    }
        //    this.Parent.Controls.Add(xtransport_mode);
        //    xtransport_mode.Dock = DockStyle.Fill;
        //    xtransport_mode.Show();
        //    xtransport_mode.BringToFront();
        //    xtransport_mode.Focus();

        //    xtransport_mode.SetAction(BtnEvent.New, null);
        //    xtransport_mode.SetFocus();
        //    xtransport_mode.setname(pValue);
        //}
        //void Transport_mode_NeedToRefresh(object sender, EventArgs e)
        //{
        //    txt_transport_mode_id.Text = xtransport_mode.GetName();
        //    txt_vehicle_no.Focus();
        //}

        //#endregion[Transport_modeLookup]

        #region[Ledger Lookup]

        public void Ledger_lookup()
        {
            txt_ledger_id.LookupColNames = new string[] { LEDGER.LEDGER_NAME };
            txt_ledger_id.LookupUpdate += txt_ledger_LookupUpdate;
            txt_ledger_id.AllowNewEntry = true;
            txt_ledger_id.NewEntryNeeded += txt_ledger_NewEntryNeeded;
        }
        void txt_ledger_LookupUpdate(object sender, EventArgs e)
        {
            txt_ledger_id.LookupList = CLedger_exten.GetforLookup(new DAL());
        }
        private FLedger xledger = null;
        void txt_ledger_NewEntryNeeded(object sender, string pValue)
        {
            if (xledger == null)
            {
                xledger = new FLedger();
                xledger.FLedger_NeedToRefresh += Ledger_NeedToRefresh;
            }
            this.Parent.Controls.Add(xledger);
            xledger.Dock = DockStyle.Fill;
            xledger.Show();
            xledger.BringToFront();
            xledger.Focus();

            xledger.SetAction(BtnEvent.New, null);
            xledger.SetFocus();
            xledger.setname(pValue);
        }
        void Ledger_NeedToRefresh(object sender, EventArgs e)
        {
            txt_ledger_id.Text = xledger.GetName();
            txt_additional.Focus();
        }

        #endregion[LedgerLookup]

        #region[Set Focus]

        public void SetFocus()
        {
            txt_party_id.Focus();
        }
        #endregion[Set Focus]

        #region[Print copies]
        private void Print_copies()
        {
            ///
            List<PrintCopies> printdata = new List<PrintCopies>();
            ///
            if (check_original.Checked)
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[0].Copies = _printdata.FirstCopy;
            }
            ///
            if ((check_duplicate.Checked) && (check_original.Checked))
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[1].Copies = _printdata.SecondCopy;
            }
            else if ((check_duplicate.Checked) && (!check_original.Checked))
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[0].Copies = _printdata.SecondCopy;
            }
            ///
            if ((check_triplicate.Checked) && (check_duplicate.Checked) && (check_original.Checked))
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[2].Copies = _printdata.ThirdCopy;

            }
            else if ((check_triplicate.Checked) && (!check_duplicate.Checked) && (check_original.Checked))
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[1].Copies = _printdata.ThirdCopy;
            }
            else if ((check_triplicate.Checked) && (!check_duplicate.Checked) && (!check_original.Checked))
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[0].Copies = _printdata.ThirdCopy;
            }
            else if ((check_triplicate.Checked) && (check_duplicate.Checked) && (!check_original.Checked))
            {
                PrintCopies _printdata = new PrintCopies();
                printdata.Add(_printdata);
                printdata[1].Copies = _printdata.ThirdCopy;
            }

            //if (Current.Company_id == "1")
            //{
            //D_QuotationItem.build();
            //D_Quotation.build();
            //FReportPreview frpt = new FReportPreview();
            //frpt.reportViewer1.ShowPrintButton = true;
            //P_Quotation.Print(frpt.reportViewer1, (vId), printdata);
            //frpt.Show();
            //print_panel.Hide();
            //this.Hide();
            //}
            //else
            //{

            //    D2_QuotationItem.build();
            //    D2_Quotation.build();
            //    FReportPreview frpt = new FReportPreview();
            //    frpt.reportViewer1.ShowPrintButton = true;
            //    P2_Quotation.Print(frpt.reportViewer1, (vQuotation_id), printdata);
            //    frpt.Show();
            //    print_panel.Hide();
            //    this.Hide();

            //CodexsunReports.ReportViewer reportViewer = new CodexsunReports.ReportViewer();
            //reportViewer.PartyStatementBindingSource.DataSource;









        }

        #endregion[Print copies]

    }//cls 
}//ns 
