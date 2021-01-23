// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:23:39 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;


namespace CXCORE
{
    public partial class FProduct : UserControl
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

        private void Txt_product_name_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_product_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_product_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_product_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_producttype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_producttype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_producttype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_producttype_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_hsncode_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_hsncode_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_hsncode_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_hsncode_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_unit_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_unit_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_unit_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_unit_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_purchase_price_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_purchase_price.BackColor = Theme.lbl_EnterBackColor;
            lbl_purchase_price.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_purchase_price.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_selling_price_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_selling_price.BackColor = Theme.lbl_EnterBackColor;
            lbl_selling_price.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_selling_price.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_sgst_percent_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_sgst_percent.BackColor = Theme.lbl_EnterBackColor;
            lbl_sgst_percent.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_sgst_percent.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_cgst_percent_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_cgst_percent.BackColor = Theme.lbl_EnterBackColor;
            lbl_cgst_percent.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_cgst_percent.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_igst_percent_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_igst_percent.BackColor = Theme.lbl_EnterBackColor;
            lbl_igst_percent.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_igst_percent.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_opening_stock_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_opening_stock.BackColor = Theme.lbl_EnterBackColor;
            lbl_opening_stock.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_opening_stock.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_opening_price_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_opening_price.BackColor = Theme.lbl_EnterBackColor;
            lbl_opening_price.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_opening_price.ForeColor = Theme.lbl_EnterForeColor;
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

            lbl_product_name.BackColor = Theme.lbl_BackColor;
            lbl_product_name.BorderColor = Theme.lbl_BorderColor;
            lbl_product_name.ForeColor = Theme.lbl_ForeColor;

            lbl_producttype_id.BackColor = Theme.lbl_BackColor;
            lbl_producttype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_producttype_id.ForeColor = Theme.lbl_ForeColor;

            lbl_hsncode_id.BackColor = Theme.lbl_BackColor;
            lbl_hsncode_id.BorderColor = Theme.lbl_BorderColor;
            lbl_hsncode_id.ForeColor = Theme.lbl_ForeColor;

            lbl_unit_id.BackColor = Theme.lbl_BackColor;
            lbl_unit_id.BorderColor = Theme.lbl_BorderColor;
            lbl_unit_id.ForeColor = Theme.lbl_ForeColor;

            lbl_purchase_price.BackColor = Theme.lbl_BackColor;
            lbl_purchase_price.BorderColor = Theme.lbl_BorderColor;
            lbl_purchase_price.ForeColor = Theme.lbl_ForeColor;

            lbl_selling_price.BackColor = Theme.lbl_BackColor;
            lbl_selling_price.BorderColor = Theme.lbl_BorderColor;
            lbl_selling_price.ForeColor = Theme.lbl_ForeColor;

            lbl_sgst_percent.BackColor = Theme.lbl_BackColor;
            lbl_sgst_percent.BorderColor = Theme.lbl_BorderColor;
            lbl_sgst_percent.ForeColor = Theme.lbl_ForeColor;

            lbl_cgst_percent.BackColor = Theme.lbl_BackColor;
            lbl_cgst_percent.BorderColor = Theme.lbl_BorderColor;
            lbl_cgst_percent.ForeColor = Theme.lbl_ForeColor;

            lbl_igst_percent.BackColor = Theme.lbl_BackColor;
            lbl_igst_percent.BorderColor = Theme.lbl_BorderColor;
            lbl_igst_percent.ForeColor = Theme.lbl_ForeColor;

            lbl_opening_stock.BackColor = Theme.lbl_BackColor;
            lbl_opening_stock.BorderColor = Theme.lbl_BorderColor;
            lbl_opening_stock.ForeColor = Theme.lbl_ForeColor;

            lbl_opening_price.BackColor = Theme.lbl_BackColor;
            lbl_opening_price.BorderColor = Theme.lbl_BorderColor;
            lbl_opening_price.ForeColor = Theme.lbl_ForeColor;

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

        public event EventHandler FProduct_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FProduct_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[Producttype Lookup]

        public void Producttype_lookup()
        {
            txt_producttype_id.LookupColNames = new string[] { PRODUCTTYPE.PRODUCTTYPE_NAME };
            txt_producttype_id.LookupUpdate += Txt_producttype_LookupUpdate;
            txt_producttype_id.AllowNewEntry = true;
            txt_producttype_id.NewEntryNeeded += Txt_producttype_NewEntryNeeded;
        }
        void Txt_producttype_LookupUpdate(object sender, EventArgs e)
        {
            txt_producttype_id.LookupList = CProducttype_exten.GetforLookup(new DAL());
        }
        private FProducttype xproducttype = null;
        void Txt_producttype_NewEntryNeeded(object sender, string pValue)
        {
            if (xproducttype == null)
            {
                xproducttype = new FProducttype();
                xproducttype.FProducttype_NeedToRefresh += Producttype_NeedToRefresh;
            }
            this.Parent.Controls.Add(xproducttype);
            xproducttype.Dock = DockStyle.Fill;
            xproducttype.Show();
            xproducttype.BringToFront();
            xproducttype.Focus();

            xproducttype.SetAction(BtnEvent.New, null);
            xproducttype.SetFocus();
            xproducttype.setname(pValue);
        }
        void Producttype_NeedToRefresh(object sender, EventArgs e)
        {
            txt_producttype_id.Text = xproducttype.GetName();
            txt_hsncode_id.Focus();
        }

        #endregion[ProducttypeLookup]

        #region[Hsncode Lookup]

        public void Hsncode_lookup()
        {
            txt_hsncode_id.LookupColNames = new string[] { HSNCODE.HSNCODE_NAME };
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
            txt_unit_id.Focus();
        }

        #endregion[HsncodeLookup]

        #region[Unit Lookup]

        public void Unit_lookup()
        {
            txt_unit_id.LookupColNames = new string[] { UNIT.UNIT_NAME };
            txt_unit_id.LookupUpdate += Txt_unit_LookupUpdate;
            txt_unit_id.AllowNewEntry = true;
            txt_unit_id.NewEntryNeeded += Txt_unit_NewEntryNeeded;
        }
        void Txt_unit_LookupUpdate(object sender, EventArgs e)
        {
            txt_unit_id.LookupList = CUnit_exten.GetforLookup(new DAL());
        }
        private FUnit xunit = null;
        void Txt_unit_NewEntryNeeded(object sender, string pValue)
        {
            if (xunit == null)
            {
                xunit = new FUnit();
                xunit.FUnit_NeedToRefresh += Unit_NeedToRefresh;
            }
            this.Parent.Controls.Add(xunit);
            xunit.Dock = DockStyle.Fill;
            xunit.Show();
            xunit.BringToFront();
            xunit.Focus();

            xunit.SetAction(BtnEvent.New, null);
            xunit.SetFocus();
            xunit.Setname(pValue);
        }
        void Unit_NeedToRefresh(object sender, EventArgs e)
        {
            txt_unit_id.Text = xunit.GetName();
            txt_purchase_price.Focus();
        }

        #endregion[UnitLookup]

        #region[GetName]

        public string GetName()
        {
            return txt_product_name.Text;
        }
        public void setname(string pName)
        {
            txt_product_name.Text = pName;
        }
        public void SetFocus()
        {
            txt_product_name.Focus();
        }
        #endregion[Set Focus]

    }//cls 
}//ns 
