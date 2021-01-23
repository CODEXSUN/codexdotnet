// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:37 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;


namespace CXACCOUNTS
{ 
    public partial class FCash_in_hand : UserControl 
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

        #region[Enter Event]

        private void Txt_entry_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_entry_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_entry_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_entry_date.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_cash_receipt_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_cash_receipt_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_cash_receipt_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_cash_receipt_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_cash_payment_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_cash_payment_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_cash_payment_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_cash_payment_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_receipt_amount_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_receipt_amount.BackColor = Theme.lbl_EnterBackColor;
            lbl_receipt_amount.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_receipt_amount.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_payment_amount_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_payment_amount.BackColor = Theme.lbl_EnterBackColor;
            lbl_payment_amount.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_payment_amount.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_balance_amount_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_balance_amount.BackColor = Theme.lbl_EnterBackColor;
            lbl_balance_amount.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_balance_amount.ForeColor = Theme.lbl_EnterForeColor;
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
            
            lbl_entry_date.BackColor = Theme.lbl_BackColor;
            lbl_entry_date.BorderColor = Theme.lbl_BorderColor;
            lbl_entry_date.ForeColor = Theme.lbl_ForeColor;
            
            lbl_cash_receipt_id.BackColor = Theme.lbl_BackColor;
            lbl_cash_receipt_id.BorderColor = Theme.lbl_BorderColor;
            lbl_cash_receipt_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_cash_payment_id.BackColor = Theme.lbl_BackColor;
            lbl_cash_payment_id.BorderColor = Theme.lbl_BorderColor;
            lbl_cash_payment_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_receipt_amount.BackColor = Theme.lbl_BackColor;
            lbl_receipt_amount.BorderColor = Theme.lbl_BorderColor;
            lbl_receipt_amount.ForeColor = Theme.lbl_ForeColor;
            
            lbl_payment_amount.BackColor = Theme.lbl_BackColor;
            lbl_payment_amount.BorderColor = Theme.lbl_BorderColor;
            lbl_payment_amount.ForeColor = Theme.lbl_ForeColor;
            
            lbl_balance_amount.BackColor = Theme.lbl_BackColor;
            lbl_balance_amount.BorderColor = Theme.lbl_BorderColor;
            lbl_balance_amount.ForeColor = Theme.lbl_ForeColor;
            
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

        public event EventHandler FCash_in_hand_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FCash_in_hand_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[Cash_receipt Lookup]

        public void Cash_receipt_lookup() 
        { 
            txt_cash_receipt_id.LookupColNames = new string[] {CASH_RECEIPT.CASH_RECEIPT_ID }; 
            txt_cash_receipt_id.LookupUpdate += Txt_cash_receipt_LookupUpdate; 
            txt_cash_receipt_id.AllowNewEntry = true; 
            txt_cash_receipt_id.NewEntryNeeded += Txt_cash_receipt_NewEntryNeeded; 
        } 
        void Txt_cash_receipt_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_cash_receipt_id.LookupList = CCash_receipt_exten.GetforLookup(); 
        } 
        private FCash_receipt xcash_receipt = null; 
        void Txt_cash_receipt_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xcash_receipt == null) 
            { 
                xcash_receipt = new FCash_receipt(); 
                xcash_receipt.FCash_receipt_NeedToRefresh += Cash_receipt_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xcash_receipt); 
            xcash_receipt.Dock = DockStyle.Fill; 
            xcash_receipt.Show(); 
            xcash_receipt.BringToFront(); 
            xcash_receipt.Focus(); 
               
            xcash_receipt.SetAction(BtnEvent.New, null); 
            xcash_receipt.SetFocus(); 
            xcash_receipt.setname(pValue); 
        } 
        void Cash_receipt_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_cash_receipt_id.Text = xcash_receipt.GetName(); 
            txt_cash_payment_id.Focus(); 
        } 

        #endregion[Cash_receiptLookup]

        #region[Cash_payment Lookup]

        public void Cash_payment_lookup() 
        { 
            txt_cash_payment_id.LookupColNames = new string[] {CASH_PAYMENT.CASH_PAYMENT_ID }; 
            txt_cash_payment_id.LookupUpdate += Txt_cash_payment_LookupUpdate; 
            txt_cash_payment_id.AllowNewEntry = true; 
            txt_cash_payment_id.NewEntryNeeded += Txt_cash_payment_NewEntryNeeded; 
        } 
        void Txt_cash_payment_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_cash_payment_id.LookupList = CCash_payment_exten.GetforLookup(); 
        } 
        private FCash_payment xcash_payment = null; 
        void Txt_cash_payment_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xcash_payment == null) 
            { 
                xcash_payment = new FCash_payment(); 
                xcash_payment.FCash_payment_NeedToRefresh += Cash_payment_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xcash_payment); 
            xcash_payment.Dock = DockStyle.Fill; 
            xcash_payment.Show(); 
            xcash_payment.BringToFront(); 
            xcash_payment.Focus(); 
               
            xcash_payment.SetAction(BtnEvent.New, null); 
            xcash_payment.SetFocus(); 
            xcash_payment.setname(pValue); 
        } 
        void Cash_payment_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_cash_payment_id.Text = xcash_payment.GetName(); 
            txt_receipt_amount.Focus(); 
        } 

        #endregion[Cash_paymentLookup]

        #region[GetName]

        public string GetName() 
        { 
            return txt_entry_date.Text; 
        } 
        public void setname(string pName) 
        { 
            txt_entry_date.Text = pName ; 
        } 
        public void SetFocus()
        {
            txt_entry_date.Focus();
        }
        #endregion[Set Focus]

}//cls 
}//ns 
