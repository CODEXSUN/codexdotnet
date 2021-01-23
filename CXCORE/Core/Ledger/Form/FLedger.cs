// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:55:36 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;


namespace CXCORE
{ 
    public partial class FLedger : UserControl 
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

        private void Txt_ledger_name_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ledger_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_ledger_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ledger_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_ledgergroup_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ledgergroup_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_ledgergroup_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ledgergroup_id.ForeColor = Theme.lbl_EnterForeColor;
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
            
            lbl_ledger_name.BackColor = Theme.lbl_BackColor;
            lbl_ledger_name.BorderColor = Theme.lbl_BorderColor;
            lbl_ledger_name.ForeColor = Theme.lbl_ForeColor;
            
            lbl_ledgergroup_id.BackColor = Theme.lbl_BackColor;
            lbl_ledgergroup_id.BorderColor = Theme.lbl_BorderColor;
            lbl_ledgergroup_id.ForeColor = Theme.lbl_ForeColor;
            
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

        public event EventHandler FLedger_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FLedger_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[Ledgergroup Lookup]

        public void Ledgergroup_lookup() 
        { 
            txt_ledgergroup_id.LookupColNames = new string[] {LEDGERGROUP.LEDGERGROUP_NAME }; 
            txt_ledgergroup_id.LookupUpdate += Txt_ledgergroup_LookupUpdate; 
            txt_ledgergroup_id.AllowNewEntry = true; 
            txt_ledgergroup_id.NewEntryNeeded += Txt_ledgergroup_NewEntryNeeded; 
        } 
        void Txt_ledgergroup_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_ledgergroup_id.LookupList = CLedgergroup_exten.GetforLookup(new DAL()); 
        } 
        private FLedgergroup xledgergroup = null; 
        void Txt_ledgergroup_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xledgergroup == null) 
            { 
                xledgergroup = new FLedgergroup(); 
                xledgergroup.FLedgergroup_NeedToRefresh += Ledgergroup_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xledgergroup); 
            xledgergroup.Dock = DockStyle.Fill; 
            xledgergroup.Show(); 
            xledgergroup.BringToFront(); 
            xledgergroup.Focus(); 
               
            xledgergroup.SetAction(BtnEvent.New, null); 
            xledgergroup.SetFocus(); 
            xledgergroup.setname(pValue); 
        } 
        void Ledgergroup_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_ledgergroup_id.Text = xledgergroup.GetName(); 
            txt_ledgergroup_id.Focus(); 
        } 

        #endregion[LedgergroupLookup]

        #region[GetName]

        public string GetName() 
        { 
            return txt_ledger_name.Text; 
        } 
        public void setname(string pName) 
        { 
            txt_ledger_name.Text = pName ; 
        } 
        public void SetFocus()
        {
            txt_ledger_name.Focus();
        }
        #endregion[Set Focus]

}//cls 
}//ns 
