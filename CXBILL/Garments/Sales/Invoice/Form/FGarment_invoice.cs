// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using System;
using System.Windows.Forms;
using System.Drawing;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{ 
    public partial class FGarment_invoice : UserControl 
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
        private void Txt_taxtype_id_TextChanged(object sender, EventArgs e)
        {
            //SetTaxtype();
        }

        private void Txt_additional_TextChanged(object sender, EventArgs e)
        {
            RefreshRowtotal();
        }

        #endregion[Txt Change]

        #region[Enter Event]

        private void Txt_garment_order_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_garment_order_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_garment_order_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_garment_order_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_salestype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_salestype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_salestype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_salestype_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_taxtype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_taxtype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_taxtype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_taxtype_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_garment_invoice_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_garment_invoice_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_garment_invoice_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_garment_invoice_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_garment_invoice_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_garment_invoice_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_garment_invoice_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_garment_invoice_date.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_party_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_id.ForeColor = Theme.lbl_EnterForeColor;
        }
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
            
            lbl_garment_order_id.BackColor = Theme.lbl_BackColor;
            lbl_garment_order_id.BorderColor = Theme.lbl_BorderColor;
            lbl_garment_order_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_salestype_id.BackColor = Theme.lbl_BackColor;
            lbl_salestype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_salestype_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_taxtype_id.BackColor = Theme.lbl_BackColor;
            lbl_taxtype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_taxtype_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_garment_invoice_no.BackColor = Theme.lbl_BackColor;
            lbl_garment_invoice_no.BorderColor = Theme.lbl_BorderColor;
            lbl_garment_invoice_no.ForeColor = Theme.lbl_ForeColor;
            
            lbl_garment_invoice_date.BackColor = Theme.lbl_BackColor;
            lbl_garment_invoice_date.BorderColor = Theme.lbl_BorderColor;
            lbl_garment_invoice_date.ForeColor = Theme.lbl_ForeColor;
            
            lbl_party_id.BackColor = Theme.lbl_BackColor;
            lbl_party_id.BorderColor = Theme.lbl_BorderColor;
            lbl_party_id.ForeColor = Theme.lbl_ForeColor;
            
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

        private void Btn_active_Click(object sender, EventArgs e)
        {
            ToggleActive();
        }

        private void Btn_save_click(object sender, EventArgs e)
        {
            Save_Event(null);
        }

        private void Btn_saveprint_click(object sender, EventArgs e)
        {
            Save_Event(Core.saveprint);
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

        #region[Set Tax type]
        private void SetTaxtype()
        {
            if (txt_taxtype_id.Text == Core.SGST)
            {
                Core.TaxType = "1";
                editgrid.Columns[GARMENT_INVOICEITEMS.SGST_PERCENT].Visible = true;
                editgrid.Columns[GARMENT_INVOICEITEMS.CGST_PERCENT].Visible = true;
                editgrid.Columns[GARMENT_INVOICEITEMS.IGST_PERCENT].Visible = false;
                RefreshRowtotal();
                this.Refresh();
            }
            else if (txt_taxtype_id.Text == Core.IGST)
            {
                Core.TaxType = "2";
                editgrid.Columns[GARMENT_INVOICEITEMS.SGST_PERCENT].Visible = false;
                editgrid.Columns[GARMENT_INVOICEITEMS.CGST_PERCENT].Visible = false;
                editgrid.Columns[GARMENT_INVOICEITEMS.IGST_PERCENT].Visible = true;
                RefreshRowtotal();
                this.Refresh();
            }
        }

        #endregion[Set Tax type]

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

        public event EventHandler FGarment_invoice_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            if (FGarment_invoice_NeedToRefresh != null)
            {
                FGarment_invoice_NeedToRefresh(this, new EventArgs());
            }
        }
        #endregion[Raise Event ]

        #region[Order Lookup]

        public void Order_lookup() 
        { 
            txt_garment_order_id.LookupColNames = new string[] {ORDER.ORDER_NO }; 
            txt_garment_order_id.LookupUpdate += txt_garment_order_LookupUpdate; 
            txt_garment_order_id.AllowNewEntry = true; 
            txt_garment_order_id.NewEntryNeeded += txt_garment_order_NewEntryNeeded; 
        } 
        void txt_garment_order_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_garment_order_id.LookupList = COrder_exten.LookupNo(); 
        } 
        private FOrder xgarment_order = null; 
        void txt_garment_order_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xgarment_order == null) 
            { 
                xgarment_order = new FOrder(); 
                xgarment_order.FOrder_NeedToRefresh += Order_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xgarment_order); 
            xgarment_order.Dock = DockStyle.Fill; 
            xgarment_order.Show(); 
            xgarment_order.BringToFront(); 
            xgarment_order.Focus(); 
               
            xgarment_order.SetAction(BtnEvent.New, null); 
            xgarment_order.SetFocus(); 
            xgarment_order.Setname(pValue); 
        } 
        void Order_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_garment_order_id.Text = xgarment_order.GetName(); 
            txt_salestype_id.Focus(); 
        } 

        #endregion[OrderLookup]

        #region[Salestype Lookup]

        public void Salestype_lookup() 
        { 
            txt_salestype_id.LookupColNames = new string[] {SALESTYPE.SALESTYPE_NAME }; 
            txt_salestype_id.LookupUpdate += txt_salestype_LookupUpdate; 
            txt_salestype_id.AllowNewEntry = true; 
            txt_salestype_id.NewEntryNeeded += txt_salestype_NewEntryNeeded; 
        } 
        void txt_salestype_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_salestype_id.LookupList = CSalestype_exten.GetforLookup(new DAL()); 
        } 
        private FSalestype xsalestype = null; 
        void txt_salestype_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xsalestype == null) 
            { 
                xsalestype = new FSalestype(); 
                xsalestype.FSalestype_NeedToRefresh += Salestype_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xsalestype); 
            xsalestype.Dock = DockStyle.Fill; 
            xsalestype.Show(); 
            xsalestype.BringToFront(); 
            xsalestype.Focus(); 
               
            xsalestype.SetAction(BtnEvent.New, null); 
            xsalestype.SetFocus(); 
            xsalestype.setname(pValue); 
        } 
        void Salestype_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_salestype_id.Text = xsalestype.GetName(); 
            txt_taxtype_id.Focus(); 
        } 

        #endregion[SalestypeLookup]

        #region[Taxtype Lookup]

        public void Taxtype_lookup() 
        { 
            txt_taxtype_id.LookupColNames = new string[] {TAXTYPE.TAXTYPE_NAME }; 
            txt_taxtype_id.LookupUpdate += txt_taxtype_LookupUpdate; 
            txt_taxtype_id.AllowNewEntry = true; 
            txt_taxtype_id.NewEntryNeeded += txt_taxtype_NewEntryNeeded; 
        } 
        void txt_taxtype_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_taxtype_id.LookupList = CTaxtype_exten.GetforLookup(new DAL()); 
        } 
        private FTaxtype xtaxtype = null; 
        void txt_taxtype_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xtaxtype == null) 
            { 
                xtaxtype = new FTaxtype(); 
                xtaxtype.FTaxtype_NeedToRefresh += Taxtype_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xtaxtype); 
            xtaxtype.Dock = DockStyle.Fill; 
            xtaxtype.Show(); 
            xtaxtype.BringToFront(); 
            xtaxtype.Focus(); 
               
            xtaxtype.SetAction(BtnEvent.New, null); 
            xtaxtype.SetFocus(); 
            xtaxtype.setname(pValue); 
        } 
        void Taxtype_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_taxtype_id.Text = xtaxtype.GetName(); 
            txt_garment_invoice_no.Focus(); 
        } 

        #endregion[TaxtypeLookup]
               
        #region[Party Lookup]

        public void Party_lookup() 
        { 
            txt_party_id.LookupColNames = new string[] {PARTY.PARTY_NAME }; 
            txt_party_id.LookupUpdate += txt_party_LookupUpdate; 
            txt_party_id.AllowNewEntry = true; 
            txt_party_id.NewEntryNeeded += txt_party_NewEntryNeeded; 
        } 
        void txt_party_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_party_id.LookupList = CParty_exten.GetforLookup(new DAL()); 
        } 
        private FParty xparty = null; 
        void txt_party_NewEntryNeeded(object sender, string pValue) 
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
            txt_total_qty.Focus(); 
        } 

        #endregion[PartyLookup]

        #region[Ledger Lookup]

        public void Ledger_lookup() 
        { 
            txt_ledger_id.LookupColNames = new string[] {LEDGER.LEDGER_NAME }; 
            txt_ledger_id.LookupUpdate += txt_ledger_LookupUpdate; 
            txt_ledger_id.AllowNewEntry = true; 
            txt_ledger_id.NewEntryNeeded += txt_ledger_NewEntryNeeded; 
        } 
        void txt_ledger_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_ledger_id.LookupList = CLedger_exten.GetforLookup(); 
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
            txt_garment_order_id.Focus();
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

            new SetPrintConfig();

            if (Core.TaxType == "1")
            {
                D_InvoiceItem.Build();
                D_Invoice.Build();
            }
            else
            {
                D_IgstInvoiceItem.Build();
                D_IgstInvoice.Build();
            }

            FReportPreview frpt = new FReportPreview();
            frpt.reportViewer1.ShowPrintButton = true;
            P_Invoice.Print(frpt.reportViewer1, (vId), printdata);
            frpt.Show();
            print_panel.Hide();
            this.Hide();

        }

        #endregion[Print copies]

        //public static  void PrintImmediate(string kid)
        //{

        //    List<PrintCopies> printdata = new List<PrintCopies>();

        //    PrintCopies _printdata = new PrintCopies();
        //    printdata.Add(_printdata);
        //    printdata[0].Copies = _printdata.ThirdCopy;


        //    if (Customise.IsDivision == true)
        //    {
        //        Customise.SetDivision(Current.Company_id);
        //    }

        //    D_InvoiceItem.Build();
        //    D_Invoice.Build();

        //    FReportPreview frpt = new FReportPreview();
        //    frpt.reportViewer1.ShowPrintButton = true;
        //    P_Garment_invoice.Print(frpt.reportViewer1, (kid), printdata);
        //    frpt.PrintImmediate();
        //}

        //public static void printgst()
        //{
        //    int[] k = {17,18,19,20,21 };

        //    for (int i = 0; i < k.Length; i++)
        //    {
        //        FGarment_invoice.PrintImmediate(CGarment_invoice_exten.GetId_Name(k[i].ToString()));
        //    }
        //}

    }//cls 
}//ns 

