// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:57 PM
// last update : 17-08-2017

using System;
using System.Windows.Forms;
using System.Drawing;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public partial class FPurchase : UserControl
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
            SetTaxtype();
        }

        private void Txt_additional_TextChanged(object sender, EventArgs e)
        {
            RefreshRowtotal();
        }

        #endregion[Txt Change]

        #region[Enter Event]

        private void Txt_order_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_order_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_order_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_order_id.ForeColor = Theme.lbl_EnterForeColor;
        }

        private void Txt_taxtype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_taxtype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_taxtype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_taxtype_id.ForeColor = Theme.lbl_EnterForeColor;
        }

        private void Txt_salestype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_salestype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_salestype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_salestype_id.ForeColor = Theme.lbl_EnterForeColor;
        }

        private void Txt_entry_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_entry_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_entry_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_entry_no.ForeColor = Theme.lbl_EnterForeColor;
        }

        private void Txt_purchase_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_purchase_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_purchase_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_purchase_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_purchase_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_purchase_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_purchase_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_purchase_date.ForeColor = Theme.lbl_EnterForeColor;
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
            lbl_order_id.BackColor = Theme.lbl_BackColor;
            lbl_order_id.BorderColor = Theme.lbl_BorderColor;
            lbl_order_id.ForeColor = Theme.lbl_ForeColor;

            lbl_taxtype_id.BackColor = Theme.lbl_BackColor;
            lbl_taxtype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_taxtype_id.ForeColor = Theme.lbl_ForeColor;

            lbl_salestype_id.BackColor = Theme.lbl_BackColor;
            lbl_salestype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_salestype_id.ForeColor = Theme.lbl_ForeColor;

            lbl_entry_no.BackColor = Theme.lbl_BackColor;
            lbl_entry_no.BorderColor = Theme.lbl_BorderColor;
            lbl_entry_no.ForeColor = Theme.lbl_ForeColor;

            lbl_purchase_no.BackColor = Theme.lbl_BackColor;
            lbl_purchase_no.BorderColor = Theme.lbl_BorderColor;
            lbl_purchase_no.ForeColor = Theme.lbl_ForeColor;

            lbl_purchase_date.BackColor = Theme.lbl_BackColor;
            lbl_purchase_date.BorderColor = Theme.lbl_BorderColor;
            lbl_purchase_date.ForeColor = Theme.lbl_ForeColor;

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
                editgrid.Columns[PURCHASEITEMS.SGST_PERCENT].Visible = true;
                editgrid.Columns[PURCHASEITEMS.CGST_PERCENT].Visible = true;
                editgrid.Columns[PURCHASEITEMS.IGST_PERCENT].Visible = false;
                RefreshRowtotal();
                this.Refresh();
            }
            else if (txt_taxtype_id.Text == Core.IGST)
            {
                Core.TaxType = "2";
                editgrid.Columns[PURCHASEITEMS.SGST_PERCENT].Visible = false;
                editgrid.Columns[PURCHASEITEMS.CGST_PERCENT].Visible = false;
                editgrid.Columns[PURCHASEITEMS.IGST_PERCENT].Visible = true;
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
                btn_active.Text = "Active";
                btn_save.Focus();
                this.Refresh();
            }
            else if (Core.Stative == Core.NotActive)
            {
                btn_active.Themes = Themescheme.RED;
                btn_active.Text = "Not Active";
                this.Refresh();
            }
            else if (Core.Stative == Core.Idle)
            {
                btn_active.Themes = Themescheme.WHITE;
                btn_active.Text = "Idle";
            }
        }

        #endregion[Active Event ]

        #region[Raise Event ]

        public event EventHandler FPurchase_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            if (FPurchase_NeedToRefresh != null)
            {
                FPurchase_NeedToRefresh(this, new EventArgs());
            }
        }
        #endregion[Raise Event ]

        #region[Order Lookup]

        public void Order_lookup()
        {
            txt_order_id.LookupColNames = new string[] { ORDER.ORDER_NO };
            txt_order_id.LookupUpdate += Txt_order_LookupUpdate;
            txt_order_id.AllowNewEntry = true;
            txt_order_id.NewEntryNeeded += Txt_order_NewEntryNeeded;
        }
        void Txt_order_LookupUpdate(object sender, EventArgs e)
        {
            txt_order_id.LookupList = COrder_exten.LookupNo();
        }
        private FOrder xorder = null;
        void Txt_order_NewEntryNeeded(object sender, string pValue)
        {
            if (xorder == null)
            {
                xorder = new FOrder();
                xorder.FOrder_NeedToRefresh += Order_NeedToRefresh;
            }
            this.Parent.Controls.Add(xorder);
            xorder.Dock = DockStyle.Fill;
            xorder.Show();
            xorder.BringToFront();
            xorder.Focus();

            xorder.SetAction(BtnEvent.New, null);
            xorder.SetFocus();
            //xorder.setname(pValue);
        }
        void Order_NeedToRefresh(object sender, EventArgs e)
        {
            //txt_order_id.Text = xorder.GetName();
            txt_total_qty.Focus();
        }

        #endregion[OrderLookup]

        #region[Tax type lookup] 

        public void Taxtype_lookup()
        {
            txt_taxtype_id.LookupColNames = new string[] { TAXTYPE.TAXTYPE_NAME };
            txt_taxtype_id.LookupUpdate += Txt_taxtype_LookupUpdate;
            txt_taxtype_id.AllowNewEntry = true;
            txt_taxtype_id.NewEntryNeeded += Txt_taxtype_NewEntryNeeded;
        }
        void Txt_taxtype_LookupUpdate(object sender, EventArgs e)
        {
            txt_taxtype_id.LookupList = CTaxtype_exten.GetforLookup(new DAL());
        }
        private FTaxtype fstaxtype = null;
        void Txt_taxtype_NewEntryNeeded(object sender, string pValue)
        {
            if (fstaxtype == null)
            {
                fstaxtype = new FTaxtype();
            }
            Parent.Controls.Add(fstaxtype);
            fstaxtype.Dock = DockStyle.Fill;
            fstaxtype.Show();
            fstaxtype.BringToFront();
            fstaxtype.Focus();

            fstaxtype.SetAction(BtnEvent.New, null);
            fstaxtype.SetFocus();
        }

        #endregion[Tax type lookup] 

        #region[Sales type lookup] 

        public void Salestype_lookup()
        {
            txt_salestype_id.LookupColNames = new string[] { SALESTYPE.SALESTYPE_NAME };
            txt_salestype_id.LookupUpdate += Txt_salestype_LookupUpdate;
            txt_salestype_id.AllowNewEntry = true;
            txt_salestype_id.NewEntryNeeded += Txt_salestype_NewEntryNeeded;
        }
        void Txt_salestype_LookupUpdate(object sender, EventArgs e)
        {
            txt_salestype_id.LookupList = CSalestype_exten.GetforLookup(new DAL());
        }
        private FSalestype fssalestype = null;
        void Txt_salestype_NewEntryNeeded(object sender, string pValue)
        {
            if (fssalestype == null)
            {
                fssalestype = new FSalestype();
            }
            Parent.Controls.Add(fssalestype);
            fssalestype.Dock = DockStyle.Fill;
            fssalestype.Show();
            fssalestype.BringToFront();
            fssalestype.Focus();

            fssalestype.SetAction(BtnEvent.New, null);
            fssalestype.SetFocus();
        }

        #endregion[Sales type lookup] 

        #region[Party Lookup]

        public void Party_lookup()
        {
            txt_party_id.LookupColNames = new string[] { PARTY.PARTY_NAME };
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
            txt_ledger_id.LookupColNames = new string[] { LEDGER.LEDGER_NAME };
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
            txt_order_id.Focus();
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

            //if (Customise.IsDivision == true)
            //{
            //    Customise.SetDivision(Current.Company_id);
            //}

            //if (Core.TaxType == "1")
            //{
            //    D_PurchaseItem.Build();
            //    D_Purchase.Build();
            //}
            //else
            //{
            //    D_IgstPurchaseItem.build();
            //    D_IgstPurchase.build();
            //}

            FReportPreview frpt = new FReportPreview();
            frpt.reportViewer1.ShowPrintButton = true;
            //  P_Purchase.Print(frpt.reportViewer1, (vId), printdata);
            frpt.Show();
            print_panel.Hide();
            this.Hide();

            //if (Current.Company_id == "1")
            //{
            //D_PurchaseItem.build();
            //D_Purchase.build();
            //FReportPreview frpt = new FReportPreview();
            //frpt.reportViewer1.ShowPrintButton = true;
            //P_Purchase.Print(frpt.reportViewer1, (vId), printdata);
            //frpt.Show();
            //print_panel.Hide();
            //this.Hide();
            //}
            //else
            //{

            //    D2_PurchaseItem.build();
            //    D2_Purchase.build();
            //    FReportPreview frpt = new FReportPreview();
            //    frpt.reportViewer1.ShowPrintButton = true;
            //    P2_Purchase.Print(frpt.reportViewer1, (vPurchase_id), printdata);
            //    frpt.Show();
            //    print_panel.Hide();
            //    this.Hide();
        }

        #endregion[Print copies]

    }//cls 
}//ns 
