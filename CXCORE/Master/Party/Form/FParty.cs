// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 08:39:52 PM

using System;
using System.Windows.Forms;
using CXLIB;
using System.Drawing;


namespace CXCORE
{
    public partial class FParty : UserControl
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

        private void Txt_party_name_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_contacttype_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_contacttype_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_contacttype_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_contacttype_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_contact_person_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_contact_person.BackColor = Theme.lbl_EnterBackColor;
            lbl_contact_person.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_contact_person.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_street1_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_street1.BackColor = Theme.lbl_EnterBackColor;
            lbl_street1.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_street1.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_street2_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_street2.BackColor = Theme.lbl_EnterBackColor;
            lbl_street2.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_street2.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_city_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_city_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_city_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_city_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_state_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_state_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_state_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_state_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_country_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_country_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_country_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_country_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_pincode_id_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_pincode_id.BackColor = Theme.lbl_EnterBackColor;
            lbl_pincode_id.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_pincode_id.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_phone_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_phone.BackColor = Theme.lbl_EnterBackColor;
            lbl_phone.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_phone.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_cell_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_cell.BackColor = Theme.lbl_EnterBackColor;
            lbl_cell.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_cell.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_email_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_email.BackColor = Theme.lbl_EnterBackColor;
            lbl_email.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_email.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_website_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_website.BackColor = Theme.lbl_EnterBackColor;
            lbl_website.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_website.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_gst_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_gst.BackColor = Theme.lbl_EnterBackColor;
            lbl_gst.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_gst.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_pan_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_pan.BackColor = Theme.lbl_EnterBackColor;
            lbl_pan.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_pan.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_opening_balance_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_opening_balance.BackColor = Theme.lbl_EnterBackColor;
            lbl_opening_balance.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_opening_balance.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Txt_credit_days_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_credit_days.BackColor = Theme.lbl_EnterBackColor;
            lbl_credit_days.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_credit_days.ForeColor = Theme.lbl_EnterForeColor;
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

            lbl_party_name.BackColor = Theme.lbl_BackColor;
            lbl_party_name.BorderColor = Theme.lbl_BorderColor;
            lbl_party_name.ForeColor = Theme.lbl_ForeColor;

            lbl_contacttype_id.BackColor = Theme.lbl_BackColor;
            lbl_contacttype_id.BorderColor = Theme.lbl_BorderColor;
            lbl_contacttype_id.ForeColor = Theme.lbl_ForeColor;

            lbl_contact_person.BackColor = Theme.lbl_BackColor;
            lbl_contact_person.BorderColor = Theme.lbl_BorderColor;
            lbl_contact_person.ForeColor = Theme.lbl_ForeColor;

            lbl_street1.BackColor = Theme.lbl_BackColor;
            lbl_street1.BorderColor = Theme.lbl_BorderColor;
            lbl_street1.ForeColor = Theme.lbl_ForeColor;

            lbl_street2.BackColor = Theme.lbl_BackColor;
            lbl_street2.BorderColor = Theme.lbl_BorderColor;
            lbl_street2.ForeColor = Theme.lbl_ForeColor;

            lbl_city_id.BackColor = Theme.lbl_BackColor;
            lbl_city_id.BorderColor = Theme.lbl_BorderColor;
            lbl_city_id.ForeColor = Theme.lbl_ForeColor;

            lbl_state_id.BackColor = Theme.lbl_BackColor;
            lbl_state_id.BorderColor = Theme.lbl_BorderColor;
            lbl_state_id.ForeColor = Theme.lbl_ForeColor;

            lbl_country_id.BackColor = Theme.lbl_BackColor;
            lbl_country_id.BorderColor = Theme.lbl_BorderColor;
            lbl_country_id.ForeColor = Theme.lbl_ForeColor;

            lbl_pincode_id.BackColor = Theme.lbl_BackColor;
            lbl_pincode_id.BorderColor = Theme.lbl_BorderColor;
            lbl_pincode_id.ForeColor = Theme.lbl_ForeColor;

            lbl_phone.BackColor = Theme.lbl_BackColor;
            lbl_phone.BorderColor = Theme.lbl_BorderColor;
            lbl_phone.ForeColor = Theme.lbl_ForeColor;

            lbl_cell.BackColor = Theme.lbl_BackColor;
            lbl_cell.BorderColor = Theme.lbl_BorderColor;
            lbl_cell.ForeColor = Theme.lbl_ForeColor;

            lbl_email.BackColor = Theme.lbl_BackColor;
            lbl_email.BorderColor = Theme.lbl_BorderColor;
            lbl_email.ForeColor = Theme.lbl_ForeColor;

            lbl_website.BackColor = Theme.lbl_BackColor;
            lbl_website.BorderColor = Theme.lbl_BorderColor;
            lbl_website.ForeColor = Theme.lbl_ForeColor;

            lbl_gst.BackColor = Theme.lbl_BackColor;
            lbl_gst.BorderColor = Theme.lbl_BorderColor;
            lbl_gst.ForeColor = Theme.lbl_ForeColor;

            lbl_pan.BackColor = Theme.lbl_BackColor;
            lbl_pan.BorderColor = Theme.lbl_BorderColor;
            lbl_pan.ForeColor = Theme.lbl_ForeColor;

            lbl_opening_balance.BackColor = Theme.lbl_BackColor;
            lbl_opening_balance.BorderColor = Theme.lbl_BorderColor;
            lbl_opening_balance.ForeColor = Theme.lbl_ForeColor;

            lbl_credit_days.BackColor = Theme.lbl_BackColor;
            lbl_credit_days.BorderColor = Theme.lbl_BorderColor;
            lbl_credit_days.ForeColor = Theme.lbl_ForeColor;

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

        public event EventHandler FParty_NeedToRefresh;

        public void Form_NeedToRefresh()
        {
            FParty_NeedToRefresh?.Invoke(this, new EventArgs());
        }
        #endregion[Raise Event ]

        #region[Contacttype Lookup]

        public void Contacttype_lookup()
        {
            txt_contacttype_id.LookupColNames = new string[] { CONTACTTYPE.CONTACTTYPE_NAME };
            txt_contacttype_id.LookupUpdate += Txt_contacttype_LookupUpdate;
            txt_contacttype_id.AllowNewEntry = true;
            txt_contacttype_id.NewEntryNeeded += Txt_contacttype_NewEntryNeeded;
        }
        void Txt_contacttype_LookupUpdate(object sender, EventArgs e)
        {
            txt_contacttype_id.LookupList = CContacttype_exten.GetforLookup();
        }
        private FContacttype xcontacttype = null;
        void Txt_contacttype_NewEntryNeeded(object sender, string pValue)
        {
            if (xcontacttype == null)
            {
                xcontacttype = new FContacttype();
                xcontacttype.FContacttype_NeedToRefresh += Contacttype_NeedToRefresh;
            }
            this.Parent.Controls.Add(xcontacttype);
            xcontacttype.Dock = DockStyle.Fill;
            xcontacttype.Show();
            xcontacttype.BringToFront();
            xcontacttype.Focus();

            xcontacttype.SetAction(BtnEvent.New, null);
            xcontacttype.SetFocus();
            xcontacttype.setname(pValue);
        }
        void Contacttype_NeedToRefresh(object sender, EventArgs e)
        {
            txt_contacttype_id.Text = xcontacttype.GetName();
            txt_contact_person.Focus();
        }

        #endregion[ContacttypeLookup]

        #region[City Lookup]

        public void City_lookup()
        {
            txt_city_id.LookupColNames = new string[] { CITY.CITY_NAME };
            txt_city_id.LookupUpdate += Txt_city_LookupUpdate;
            txt_city_id.AllowNewEntry = true;
            txt_city_id.NewEntryNeeded += Txt_city_NewEntryNeeded;
        }
        void Txt_city_LookupUpdate(object sender, EventArgs e)
        {
            txt_city_id.LookupList = CCity_exten.GetforLookup(new DAL());
        }
        private FCity xcity = null;
        void Txt_city_NewEntryNeeded(object sender, string pValue)
        {
            if (xcity == null)
            {
                xcity = new FCity();
                xcity.FCity_NeedToRefresh += City_NeedToRefresh;
            }
            this.Parent.Controls.Add(xcity);
            xcity.Dock = DockStyle.Fill;
            xcity.Show();
            xcity.BringToFront();
            xcity.Focus();

            xcity.SetAction(BtnEvent.New, null);
            xcity.SetFocus();
            xcity.setname(pValue);
        }
        void City_NeedToRefresh(object sender, EventArgs e)
        {
            txt_city_id.Text = xcity.GetName();
            txt_state_id.Focus();
        }

        #endregion[CityLookup]

        #region[State Lookup]

        public void State_lookup()
        {
            txt_state_id.LookupColNames = new string[] { STATE.STATE_NAME };
            txt_state_id.LookupUpdate += Txt_state_LookupUpdate;
            txt_state_id.AllowNewEntry = true;
            txt_state_id.NewEntryNeeded += Txt_state_NewEntryNeeded;
        }
        void Txt_state_LookupUpdate(object sender, EventArgs e)
        {
            txt_state_id.LookupList = CState_exten.GetforLookup(new DAL());
        }
        private FState xstate = null;
        void Txt_state_NewEntryNeeded(object sender, string pValue)
        {
            if (xstate == null)
            {
                xstate = new FState();
                xstate.FState_NeedToRefresh += State_NeedToRefresh;
            }
            this.Parent.Controls.Add(xstate);
            xstate.Dock = DockStyle.Fill;
            xstate.Show();
            xstate.BringToFront();
            xstate.Focus();

            xstate.SetAction(BtnEvent.New, null);
            xstate.SetFocus();
            xstate.setname(pValue);
        }
        void State_NeedToRefresh(object sender, EventArgs e)
        {
            txt_state_id.Text = xstate.GetName();
            txt_country_id.Focus();
        }

        #endregion[StateLookup]

        #region[Country Lookup]

        public void Country_lookup()
        {
            txt_country_id.LookupColNames = new string[] { COUNTRY.COUNTRY_NAME };
            txt_country_id.LookupUpdate += Txt_country_LookupUpdate;
            txt_country_id.AllowNewEntry = true;
            txt_country_id.NewEntryNeeded += Txt_country_NewEntryNeeded;
        }
        void Txt_country_LookupUpdate(object sender, EventArgs e)
        {
            txt_country_id.LookupList = CCountry_exten.GetforLookup(new DAL());
        }
        private FCountry xcountry = null;
        void Txt_country_NewEntryNeeded(object sender, string pValue)
        {
            if (xcountry == null)
            {
                xcountry = new FCountry();
                xcountry.FCountry_NeedToRefresh += Country_NeedToRefresh;
            }
            this.Parent.Controls.Add(xcountry);
            xcountry.Dock = DockStyle.Fill;
            xcountry.Show();
            xcountry.BringToFront();
            xcountry.Focus();

            xcountry.SetAction(BtnEvent.New, null);
            xcountry.SetFocus();
            xcountry.setname(pValue);
        }
        void Country_NeedToRefresh(object sender, EventArgs e)
        {
            txt_country_id.Text = xcountry.GetName();
            txt_pincode_id.Focus();
        }

        #endregion[CountryLookup]

        #region[Pincode Lookup]

        public void Pincode_lookup()
        {
            txt_pincode_id.LookupColNames = new string[] { PINCODE.PINCODE_NAME };
            txt_pincode_id.LookupUpdate += Txt_pincode_LookupUpdate;
            txt_pincode_id.AllowNewEntry = true;
            txt_pincode_id.NewEntryNeeded += Txt_pincode_NewEntryNeeded;
        }
        void Txt_pincode_LookupUpdate(object sender, EventArgs e)
        {
            txt_pincode_id.LookupList = CPincode_exten.GetforLookup(new DAL());
        }
        private FPincode xpincode = null;
        void Txt_pincode_NewEntryNeeded(object sender, string pValue)
        {
            if (xpincode == null)
            {
                xpincode = new FPincode();
                xpincode.FPincode_NeedToRefresh += Pincode_NeedToRefresh;
            }
            this.Parent.Controls.Add(xpincode);
            xpincode.Dock = DockStyle.Fill;
            xpincode.Show();
            xpincode.BringToFront();
            xpincode.Focus();

            xpincode.SetAction(BtnEvent.New, null);
            xpincode.SetFocus();
            xpincode.setname(pValue);
        }
        void Pincode_NeedToRefresh(object sender, EventArgs e)
        {
            txt_pincode_id.Text = xpincode.GetName();
            txt_phone.Focus();
        }

        #endregion[PincodeLookup]

        #region[GetName]

        public string GetName()
        {
            return txt_party_name.Text.ToUpper();
        }
        public void setname(string pName)
        {
            txt_party_name.Text = pName;
        }
        public void SetFocus()
        {
            txt_party_name.Focus();
        }
        #endregion[Set Focus]

    }//cls 
}//ns 
