// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 25-01-2021 10:14:36 AM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;


namespace CXERP
{ 
    public partial class FPo
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

        private void Txt_po_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_po_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_po_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_po_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_po_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_po_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_po_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_po_date.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_delivery_date_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_delivery_date.BackColor = Theme.lbl_EnterBackColor;
            lbl_delivery_date.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_delivery_date.ForeColor = Theme.lbl_EnterForeColor;
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
            
            lbl_po_no.BackColor = Theme.lbl_BackColor;
            lbl_po_no.BorderColor = Theme.lbl_BorderColor;
            lbl_po_no.ForeColor = Theme.lbl_ForeColor;
            
            lbl_po_date.BackColor = Theme.lbl_BackColor;
            lbl_po_date.BorderColor = Theme.lbl_BorderColor;
            lbl_po_date.ForeColor = Theme.lbl_ForeColor;
            
            lbl_delivery_date.BackColor = Theme.lbl_BackColor;
            lbl_delivery_date.BorderColor = Theme.lbl_BorderColor;
            lbl_delivery_date.ForeColor = Theme.lbl_ForeColor;
            
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

        public event EventHandler FPo_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FPo_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[GetName]

        public string GetName() 
        { 
            return txt_po_no.Text; 
        } 
        public void setname(string pName) 
        { 
            txt_po_no.Text = pName ; 
        } 
        public void SetFocus()
        {
            txt_po_no.Focus();
        }
        #endregion[Set Focus]

}//cls 
}//ns 
