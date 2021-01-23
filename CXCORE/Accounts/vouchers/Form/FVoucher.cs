// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:23:01 PM

using System;
using System.Windows.Forms;
using CodexsunLib;
using System.Drawing;


namespace CodexsunCore
{ 
    public partial class FVoucher : UserControl 
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

        #region[Txt Change event]

        private void Txt_vouchertype_id_TextChanged(object sender, EventArgs e)
        {
            var method = CVouchertype_exten.GetId_Name(txt_vouchertype_id.Text);

            if (method == "1")
            {
                txt_credit.Visible = true;
                lbl_credit.Visible = true;

                txt_debit.Visible = false;
                lbl_debit.Visible = false;

            }
            else if (method == "2")
            {
                txt_credit.Visible = false;
                lbl_credit.Visible = false;

                txt_debit.Visible = true;
                lbl_debit.Visible = true;

            }

        }

        #endregion[Txt Change event]

        #region[Enter Event]

        private void Txt_voucher_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_voucher_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_voucher_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_voucher_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_voucher_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_voucher_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_voucher_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_voucher_date.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_vouchertype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_vouchertype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_vouchertype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_vouchertype_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_order_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_order_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_order_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_order_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_ledger_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ledger_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_ledger_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ledger_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_party_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_purpose_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_purpose.BackColor = Theme.lbl_EnterBackColor;
            lbl_purpose.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_purpose.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_credit_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_credit.BackColor = Theme.lbl_EnterBackColor;
            lbl_credit.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_credit.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_debit_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_debit.BackColor = Theme.lbl_EnterBackColor;
            lbl_debit.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_debit.ForeColor = Theme.lbl_EnterForeColor;
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
            
            
            lbl_voucher_no.BackColor = Theme.lbl_BackColor;
            lbl_voucher_no.BorderColor = Theme.lbl_BorderColor;
            lbl_voucher_no.ForeColor = Theme.lbl_ForeColor;
            
            lbl_voucher_date.BackColor = Theme.lbl_BackColor;
            lbl_voucher_date.BorderColor = Theme.lbl_BorderColor;
            lbl_voucher_date.ForeColor = Theme.lbl_ForeColor;
            
            lbl_vouchertype_id.BackColor = Theme.lbl_BackColor;
            lbl_vouchertype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_vouchertype_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_order_id.BackColor = Theme.lbl_BackColor;
            lbl_order_id.BorderColor = Theme.lbl_BorderColor;
            lbl_order_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_ledger_id.BackColor = Theme.lbl_BackColor;
            lbl_ledger_id.BorderColor = Theme.lbl_BorderColor;
            lbl_ledger_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_party_id.BackColor = Theme.lbl_BackColor;
            lbl_party_id.BorderColor = Theme.lbl_BorderColor;
            lbl_party_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_purpose.BackColor = Theme.lbl_BackColor;
            lbl_purpose.BorderColor = Theme.lbl_BorderColor;
            lbl_purpose.ForeColor = Theme.lbl_ForeColor;
            
            lbl_credit.BackColor = Theme.lbl_BackColor;
            lbl_credit.BorderColor = Theme.lbl_BorderColor;
            lbl_credit.ForeColor = Theme.lbl_ForeColor;
            
            lbl_debit.BackColor = Theme.lbl_BackColor;
            lbl_debit.BorderColor = Theme.lbl_BorderColor;
            lbl_debit.ForeColor = Theme.lbl_ForeColor;
            
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
                SetAction(BtnEvent.Print, vId);
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

        public event EventHandler FVoucher_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            if (FVoucher_NeedToRefresh != null)
            {
                FVoucher_NeedToRefresh(this, new EventArgs());
            }
        }
        #endregion[Raise Event ]

        #region[Vouchertype Lookup]

        public void Vouchertype_lookup() 
        { 
            txt_vouchertype_id.LookupColNames = new string[] {VOUCHERTYPE.VOUCHERTYPE_NAME }; 
            txt_vouchertype_id.LookupUpdate += Txt_vouchertype_LookupUpdate; 
            txt_vouchertype_id.AllowNewEntry = true; 
            txt_vouchertype_id.NewEntryNeeded += Txt_vouchertype_NewEntryNeeded; 
        } 
        void Txt_vouchertype_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_vouchertype_id.LookupList = CVouchertype_exten.GetforLookup(new DAL()); 
        } 
        private FVouchertype xvouchertype = null; 
        void Txt_vouchertype_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xvouchertype == null) 
            { 
                xvouchertype = new FVouchertype(); 
                xvouchertype.FVouchertype_NeedToRefresh += Vouchertype_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xvouchertype); 
            xvouchertype.Dock = DockStyle.Fill; 
            xvouchertype.Show(); 
            xvouchertype.BringToFront(); 
            xvouchertype.Focus(); 
               
            xvouchertype.SetAction(BtnEvent.New, null); 
            xvouchertype.SetFocus(); 
            xvouchertype.setname(pValue); 
        } 
        void Vouchertype_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_vouchertype_id.Text = xvouchertype.GetName(); 
            txt_order_id.Focus(); 
        } 

        #endregion[VouchertypeLookup]

        #region[Order Lookup]

        public void Order_lookup() 
        { 
            txt_order_id.LookupColNames = new string[] {ORDER.ORDER_NAME }; 
            txt_order_id.LookupUpdate += txt_order_LookupUpdate; 
            txt_order_id.AllowNewEntry = true; 
            txt_order_id.NewEntryNeeded += txt_order_NewEntryNeeded; 
        } 
        void txt_order_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_order_id.LookupList = COrder_exten.GetforLookup(new DAL()); 
        } 
        private FOrder xorder = null; 
        void txt_order_NewEntryNeeded(object sender, string pValue) 
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
            xorder.setname(pValue); 
        } 
        void Order_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_order_id.Text = xorder.GetName(); 
            txt_ledger_id.Focus(); 
        } 

        #endregion[OrderLookup]

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
            txt_party_id.Focus(); 
        } 

        #endregion[LedgerLookup]

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
            txt_purpose.Focus(); 
        } 

        #endregion[PartyLookup]

        #region[GetName]

        public string GetName() 
        { 
            return txt_vouchertype_id.Text; 
        } 
        public void setname(string pName) 
        {
            txt_vouchertype_id.Text = pName ; 
        } 
        public void SetFocus()
        {
            txt_voucher_date.Focus();
        }
        #endregion[Set Focus]

}//cls 
}//ns 
