// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:38:55 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;
using CXCORE;

namespace CXERP
{ 
    public partial class FArticle
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

        private void Txt_po_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_po_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_po_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_po_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_article_no_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_article_no.BackColor = Theme.lbl_EnterBackColor;
            lbl_article_no.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_article_no.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_product_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_product_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_product_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_product_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_hsncode_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_hsncode_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_hsncode_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_hsncode_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_size_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_size_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_size_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_size_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_colour_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_colour_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_colour_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_colour_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_qty_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_qty.BackColor = Theme.lbl_EnterBackColor;
            lbl_qty.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_qty.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_price_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_price.BackColor = Theme.lbl_EnterBackColor;
            lbl_price.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_price.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_barcode_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_barcode.BackColor = Theme.lbl_EnterBackColor;
            lbl_barcode.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_barcode.ForeColor = Theme.lbl_EnterForeColor;
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
            
            lbl_po_id.BackColor = Theme.lbl_BackColor;
            lbl_po_id.BorderColor = Theme.lbl_BorderColor;
            lbl_po_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_article_no.BackColor = Theme.lbl_BackColor;
            lbl_article_no.BorderColor = Theme.lbl_BorderColor;
            lbl_article_no.ForeColor = Theme.lbl_ForeColor;
            
            lbl_product_id.BackColor = Theme.lbl_BackColor;
            lbl_product_id.BorderColor = Theme.lbl_BorderColor;
            lbl_product_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_hsncode_id.BackColor = Theme.lbl_BackColor;
            lbl_hsncode_id.BorderColor = Theme.lbl_BorderColor;
            lbl_hsncode_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_size_id.BackColor = Theme.lbl_BackColor;
            lbl_size_id.BorderColor = Theme.lbl_BorderColor;
            lbl_size_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_colour_id.BackColor = Theme.lbl_BackColor;
            lbl_colour_id.BorderColor = Theme.lbl_BorderColor;
            lbl_colour_id.ForeColor = Theme.lbl_ForeColor;
            
            lbl_qty.BackColor = Theme.lbl_BackColor;
            lbl_qty.BorderColor = Theme.lbl_BorderColor;
            lbl_qty.ForeColor = Theme.lbl_ForeColor;
            
            lbl_price.BackColor = Theme.lbl_BackColor;
            lbl_price.BorderColor = Theme.lbl_BorderColor;
            lbl_price.ForeColor = Theme.lbl_ForeColor;
            
            lbl_barcode.BackColor = Theme.lbl_BackColor;
            lbl_barcode.BorderColor = Theme.lbl_BorderColor;
            lbl_barcode.ForeColor = Theme.lbl_ForeColor;
            
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

        public event EventHandler FArticle_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FArticle_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[Po Lookup]

        public void Po_lookup() 
        { 
            txt_po_id.LookupColNames = new string[] {PO.PO_NO}; 
            txt_po_id.LookupUpdate += Txt_po_LookupUpdate; 
            txt_po_id.AllowNewEntry = true; 
            txt_po_id.NewEntryNeeded += Txt_po_NewEntryNeeded; 
        } 
        void Txt_po_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_po_id.LookupList = CPo_exten.GetforLookup(); 
        } 
        private FPo xpo = null; 
        void Txt_po_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xpo == null) 
            { 
                xpo = new FPo(); 
                xpo.FPo_NeedToRefresh += Po_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xpo); 
            xpo.Dock = DockStyle.Fill; 
            xpo.Show(); 
            xpo.BringToFront(); 
            xpo.Focus(); 
               
            xpo.SetAction(BtnEvent.New, null); 
            xpo.SetFocus(); 
            xpo.setname(pValue); 
        } 
        void Po_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_po_id.Text = xpo.GetName(); 
            txt_article_no.Focus(); 
        } 

        #endregion[PoLookup]

        #region[Hsncode Lookup]

        public void Hsncode_lookup() 
        { 
            txt_hsncode_id.LookupColNames = new string[] {HSNCODE.HSNCODE_NAME }; 
            txt_hsncode_id.LookupUpdate += Txt_hsncode_LookupUpdate; 
            txt_hsncode_id.AllowNewEntry = true; 
            txt_hsncode_id.NewEntryNeeded += Txt_hsncode_NewEntryNeeded; 
        } 
        void Txt_hsncode_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_hsncode_id.LookupList = CHsncode_exten.GetforLookup(new DAL()); 
        } 
        private FHsncode xhsncode = null; 
        void Txt_hsncode_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xhsncode == null) 
            { 
                xhsncode = new FHsncode(); 
                xhsncode.FHsncode_NeedToRefresh += Hsncode_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xhsncode); 
            xhsncode.Dock = DockStyle.Fill; 
            xhsncode.Show(); 
            xhsncode.BringToFront(); 
            xhsncode.Focus(); 
               
            xhsncode.SetAction(BtnEvent.New, null); 
            xhsncode.SetFocus(); 
            xhsncode.setname(pValue); 
        } 
        void Hsncode_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_hsncode_id.Text = xhsncode.GetName(); 
            txt_size_id.Focus(); 
        } 

        #endregion[HsncodeLookup]

        #region[Size Lookup]

        public void Size_lookup() 
        { 
            txt_size_id.LookupColNames = new string[] {SIZES.SIZES_NAME }; 
            txt_size_id.LookupUpdate += Txt_size_LookupUpdate; 
            txt_size_id.AllowNewEntry = true; 
            txt_size_id.NewEntryNeeded += Txt_size_NewEntryNeeded; 
        } 
        void Txt_size_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_size_id.LookupList = CSizes_exten.GetforLookup(new DAL()); 
        } 
        private FSizes xsize = null; 
        void Txt_size_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xsize == null) 
            { 
                xsize = new FSizes(); 
                xsize.FSizes_NeedToRefresh += Size_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xsize); 
            xsize.Dock = DockStyle.Fill; 
            xsize.Show(); 
            xsize.BringToFront(); 
            xsize.Focus(); 
               
            xsize.SetAction(BtnEvent.New, null); 
            xsize.SetFocus(); 
            xsize.setname(pValue); 
        } 
        void Size_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_size_id.Text = xsize.GetName(); 
            txt_colour_id.Focus(); 
        } 

        #endregion[SizeLookup]

        #region[Colour Lookup]

        public void Colour_lookup() 
        { 
            txt_colour_id.LookupColNames = new string[] {COLOURS.COLOURS_NAME }; 
            txt_colour_id.LookupUpdate += Txt_colour_LookupUpdate; 
            txt_colour_id.AllowNewEntry = true; 
            txt_colour_id.NewEntryNeeded += Txt_colour_NewEntryNeeded; 
        } 
        void Txt_colour_LookupUpdate(object sender, EventArgs e) 
        { 
            txt_colour_id.LookupList = CColours_exten.GetforLookup(new DAL()); 
        } 
        private FColours xcolour = null; 
        void Txt_colour_NewEntryNeeded(object sender, string pValue) 
        { 
            if (xcolour == null) 
            { 
                xcolour = new FColours(); 
                xcolour.FColours_NeedToRefresh += Colour_NeedToRefresh; 
            } 
            this.Parent.Controls.Add(xcolour); 
            xcolour.Dock = DockStyle.Fill; 
            xcolour.Show(); 
            xcolour.BringToFront(); 
            xcolour.Focus(); 
               
            xcolour.SetAction(BtnEvent.New, null); 
            xcolour.SetFocus(); 
            xcolour.setname(pValue); 
        } 
        void Colour_NeedToRefresh(object sender, EventArgs e) 
        { 
            txt_colour_id.Text = xcolour.GetName(); 
            txt_qty.Focus(); 
        } 

        #endregion[ColourLookup]

        #region[GetName]

        public string GetName() 
        { 
            return txt_po_id.Text; 
        } 
        public void setname(string pName) 
        { 
            txt_po_id.Text = pName ; 
        } 
        public void SetFocus()
        {
        }
        #endregion[Set Focus]

}//cls 
}//ns 
