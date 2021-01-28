// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-06-2019 10:44:05 AM

using System;
using System.Windows.Forms;
using System.Drawing;
using CXLIB;
using CXCORE;


namespace CXERP
{ 
    public partial class FOrder : UserControl 
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

        private void Txt_garment_order_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_garment_order_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_garment_order_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_garment_order_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_garment_order_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_garment_order_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_garment_order_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_garment_order_date.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_ordertype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_ordertype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_ordertype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_ordertype_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_party_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_party_ref_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_ref.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_ref.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_ref.ForeColor = Theme.lbl_EnterForeColor;
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
            
            lbl_garment_order_no.BackColor = Theme.lbl_BackColor;
            lbl_garment_order_no.BorderColor = Theme.lbl_BorderColor;
            lbl_garment_order_no.ForeColor = Theme.lbl_ForeColor;
            
            lbl_garment_order_date.BackColor = Theme.lbl_BackColor;
            lbl_garment_order_date.BorderColor = Theme.lbl_BorderColor;
            lbl_garment_order_date.ForeColor = Theme.lbl_ForeColor;
            
            lbl_ordertype_id.BackColor = Theme.lbl_BackColor;
            lbl_ordertype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_ordertype_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_party_id.BackColor = Theme.lbl_BackColor;
            lbl_party_id.BorderColor = Theme.lbl_BorderColor;
            lbl_party_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_party_ref.BackColor = Theme.lbl_BackColor;
            lbl_party_ref.BorderColor = Theme.lbl_BorderColor;
            lbl_party_ref.ForeColor = Theme.lbl_ForeColor;
            
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

        public event EventHandler FOrder_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            if (FOrder_NeedToRefresh != null)
            {
                FOrder_NeedToRefresh(this, new EventArgs());
            }
        }
        #endregion[Raise Event ]

        #region[Ordertype Lookup]

        public void Ordertype_lookup() 
        { 
            txt_ordertype_id.LookupColNames = new string[] {ORDERTYPE.ORDERTYPE_NAME }; 
            txt_ordertype_id.LookupUpdate += txt_ordertype_LookupUpdate; 
            txt_ordertype_id.AllowNewEntry = true; 
            txt_ordertype_id.NewEntryNeeded += txt_ordertype_NewEntryNeeded; 
        } 
        void txt_ordertype_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_ordertype_id.LookupList = COrdertype_exten.GetforLookup(new DAL()); 
        } 
        private FOrdertype xordertype = null; 
        void txt_ordertype_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xordertype == null) 
            { 
                xordertype = new FOrdertype(); 
                xordertype.FOrdertype_NeedToRefresh += Ordertype_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xordertype); 
            xordertype.Dock = DockStyle.Fill; 
            xordertype.Show(); 
            xordertype.BringToFront(); 
            xordertype.Focus(); 
               
            xordertype.SetAction(BtnEvent.New, null); 
            xordertype.SetFocus(); 
            xordertype.setname(pValue); 
        } 
        void Ordertype_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_ordertype_id.Text = xordertype.GetName(); 
            txt_party_id.Focus(); 
        } 

        #endregion[OrdertypeLookup]

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
            txt_party_ref.Focus(); 
        } 

        #endregion[PartyLookup]

        #region[Set Focus]

        public void SetFocus()
        {
            txt_order_no.Focus();
        }
        #endregion[Set Focus]

}//cls 
}//ns 
