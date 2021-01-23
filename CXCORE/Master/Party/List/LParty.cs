// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 08:52:27 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class LParty
    {

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Party_Id = new DataGridViewTextBoxColumn();
            col_Party_Id.Name = PARTY.PARTY_ID;
            col_Party_Id.HeaderText = "PARTY_ID ";
            col_Party_Id.Visible = false;
            col_Party_Id.Width = 100;
            col_Party_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Party_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_Id);

            DataGridViewTextBoxColumn col_sn = new DataGridViewTextBoxColumn();
            col_sn.Name = "SN";
            col_sn.HeaderText = "";
            //col_sn.Visible = false; 
            col_sn.Width = 40;
            col_sn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_sn);

            DataGridViewTextBoxColumn col_Party_name = new DataGridViewTextBoxColumn();
            col_Party_name.Name = PARTY.PARTY_NAME;
            col_Party_name.HeaderText = "PARTY NAME";
            //col_Party_name.Visible = false; 
            col_Party_name.Width = 400;
            col_Party_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Party_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Party_name);

            DataGridViewTextBoxColumn col_Phone = new DataGridViewTextBoxColumn();
            col_Phone.Name = PARTY.PHONE;
            col_Phone.HeaderText = "PHONE";
            //col_Phone.Visible = false; 
            col_Phone.Width = 130;
            col_Phone.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Phone);

            DataGridViewTextBoxColumn col_Cell = new DataGridViewTextBoxColumn();
            col_Cell.Name = PARTY.CELL;
            col_Cell.HeaderText = "CELL";
            //col_Cell.Visible = false; 
            col_Cell.Width = 130;
            col_Cell.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Cell.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Cell);

            DataGridViewTextBoxColumn col_Gst = new DataGridViewTextBoxColumn();
            col_Gst.Name = PARTY.GSTIN;
            col_Gst.HeaderText = "GST NO";
            //col_Gst.Visible = false; 
            col_Gst.Width = 180;
            col_Gst.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Gst.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Gst);

            DataGridViewTextBoxColumn col_Email = new DataGridViewTextBoxColumn();
            col_Email.Name = PARTY.EMAIL;
            col_Email.HeaderText = "EMAIL";
            col_Email.Visible = false; 
            col_Email.Width = 150;
            col_Email.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Email);


            DataGridViewTextBoxColumn col_Opening_balance = new DataGridViewTextBoxColumn();
            col_Opening_balance.Name = PARTY.OPENING_BALANCE;
            col_Opening_balance.HeaderText = "OPENING BALANCE";
            //col_Opening_balance.Visible = false; 
            col_Opening_balance.Width = 225;
            col_Opening_balance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Opening_balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Opening_balance);

            DataGridViewTextBoxColumn col_Contacttype_id = new DataGridViewTextBoxColumn();
            col_Contacttype_id.Name = PARTY.CONTACTTYPE_ID;
            col_Contacttype_id.HeaderText = "CONTACT TYPE";
            col_Contacttype_id.Visible = false;
            col_Contacttype_id.Width = 175;
            col_Contacttype_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Contacttype_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Contacttype_id);

            DataGridViewTextBoxColumn col_Contact_person = new DataGridViewTextBoxColumn();
            col_Contact_person.Name = PARTY.CONTACT_PERSON;
            col_Contact_person.HeaderText = "CONTACT PERSON";
            col_Contact_person.Visible = false;
            col_Contact_person.Width = 212;
            col_Contact_person.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Contact_person.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Contact_person);

            DataGridViewTextBoxColumn col_Street1 = new DataGridViewTextBoxColumn();
            col_Street1.Name = PARTY.STREET_1;
            col_Street1.HeaderText = "STREET";
            col_Street1.Visible = false;
            col_Street1.Width = 100;
            col_Street1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Street1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Street1);

            DataGridViewTextBoxColumn col_Street2 = new DataGridViewTextBoxColumn();
            col_Street2.Name = PARTY.STREET_2;
            col_Street2.HeaderText = "STREET";
            col_Street2.Visible = false;
            col_Street2.Width = 100;
            col_Street2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Street2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Street2);

            DataGridViewTextBoxColumn col_City_id = new DataGridViewTextBoxColumn();
            col_City_id.Name = PARTY.CITY_ID;
            col_City_id.HeaderText = "CITY";
            col_City_id.Visible = false; 
            col_City_id.Width = 100;
            col_City_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_City_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_City_id);

            DataGridViewTextBoxColumn col_State_id = new DataGridViewTextBoxColumn();
            col_State_id.Name = PARTY.STATE_ID;
            col_State_id.HeaderText = "STATE";
            col_State_id.Visible = false;
            col_State_id.Width = 100;
            col_State_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_State_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_State_id);

            DataGridViewTextBoxColumn col_Country_id = new DataGridViewTextBoxColumn();
            col_Country_id.Name = PARTY.COUNTRY_ID;
            col_Country_id.HeaderText = "COUNTRY";
            col_Country_id.Visible = false;
            col_Country_id.Width = 100;
            col_Country_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Country_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Country_id);

            DataGridViewTextBoxColumn col_Pincode_id = new DataGridViewTextBoxColumn();
            col_Pincode_id.Name = PARTY.PINCODE_ID;
            col_Pincode_id.HeaderText = "PINCODE";
            col_Pincode_id.Visible = false;
            col_Pincode_id.Width = 100;
            col_Pincode_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Pincode_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Pincode_id);

            DataGridViewTextBoxColumn col_Website = new DataGridViewTextBoxColumn();
            col_Website.Name = PARTY.WEBSITE;
            col_Website.HeaderText = "WEBSITE";
            col_Website.Visible = false;
            col_Website.Width = 100;
            col_Website.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Website.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Website);


            DataGridViewTextBoxColumn col_Pan = new DataGridViewTextBoxColumn();
            col_Pan.Name = PARTY.PAN;
            col_Pan.HeaderText = "PAN";
            col_Pan.Visible = false;
            col_Pan.Width = 100;
            col_Pan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Pan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Pan);

            DataGridViewTextBoxColumn col_Credit_days = new DataGridViewTextBoxColumn();
            col_Credit_days.Name = PARTY.CREDIT_DAYS;
            col_Credit_days.HeaderText = "QOP";
            //col_Credit_days.Visible = false;
            col_Credit_days.Width = 212;
            col_Credit_days.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Credit_days.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Credit_days);

            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();
            col_Notes.Name = PARTY.NOTES;
            col_Notes.HeaderText = "NOTES";
            col_Notes.Visible = false;
            col_Notes.Width = 200;
            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Notes);

            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();
            col_Active_Id.Name = PARTY.ACTIVE_ID;
            col_Active_Id.HeaderText = "ACTIVE ID";
            col_Active_Id.Visible = false;
            col_Active_Id.Width = 200;
            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Active_Id);

            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();
            col_User_Id.Name = PARTY.USER_ID;
            col_User_Id.HeaderText = "ENTRY BY";
            //col_User_Id.Visible = false; 
            col_User_Id.Width = 120;
            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_User_Id);

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listgrid.Columns.Add(colFiller);
        }

        #endregion[Init Grid]

        #region[Grid Action]

        void Listgrid_RowAction(object sender, EventArgs e)
        {
            if (listgrid.SelectedRow == null)
            {
                return;
            }
            if (fparty == null)
            {
                fparty = new FParty();
            }
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fparty.SetAction(BtnEvent.Open, pkValue);
            }
        }

        #endregion[Grid Action]

        #region[Enter Event]

        private void Txt_partytype_Enter(object sender, EventArgs e)
        {
            Change_infocus();
            lbl_party_name.BackColor = Theme.lbl_EnterBackColor;
            lbl_party_name.BorderColor = Theme.lbl_EnterBorderColor;
            lbl_party_name.ForeColor = Theme.lbl_EnterForeColor;
        }
        private void Change_infocus()
        {
            lbl_party_name.BackColor = Theme.lbl_BackColor;
            lbl_party_name.BorderColor = Theme.lbl_BorderColor;
            lbl_party_name.ForeColor = Theme.lbl_ForeColor;
        }

        #endregion[Enter Event]

        #region[Build Form]

        private void BuildForm()
        {
            if (fparty == null)
            {
                fparty = new FParty();
            }
            fparty.FParty_NeedToRefresh += VParty_NeedToRefresh;
            Parent.Controls.Add(fparty);
            fparty.Dock = DockStyle.Fill;
            fparty.Show();
            fparty.BringToFront();

        }

        #endregion[Build Form]

        #region[Checkbox Event] 

        private void Chk_notactive_CheckedChanged(object sender, EventArgs e)
        {
            List_Option(ListOption.notactive);
        }

        #endregion[Checkbox Event] 

        #region[Btn Event] 

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            BuildForm();
            fparty.SetAction(BtnEvent.New, null);
            fparty.SetFocus();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fparty.SetAction(BtnEvent.Edit, pkValue);
                fparty.SetFocus();
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fparty.SetAction(BtnEvent.Delete, pkValue);
                fparty.SetFocus();
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            BuildForm();
            string pkValue = GetSelectedPkValue();
            if (pkValue != null)
            {
                fparty.SetAction(BtnEvent.Print, pkValue);
                fparty.SetFocus();
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            RaiseEvent_NeedToRefresh();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            List_Option(ListOption.Search);
        }

        #endregion[Btn Event] 

        #region[lookup] 

        public void Party_lookup()
        {
            txt_party_name.LookupColNames = new string[] { PARTY.PARTY_NAME };
            txt_party_name.LookupUpdate += txt_party_LookupUpdate;
            txt_party_name.AllowNewEntry = true;
            txt_party_name.NewEntryNeeded += txt_party_NewEntryNeeded;
        }
        void txt_party_LookupUpdate(object sender, EventArgs e)
        {
            txt_party_name.LookupList = CParty_exten.GetforLookup(new DAL());
        }
        private FParty fsparty = null;
        void txt_party_NewEntryNeeded(object sender, string pValue)
        {
            if (fsparty == null)
            {
                fsparty = new FParty();
            }
            Parent.Controls.Add(fsparty);
            fsparty.Dock = DockStyle.Fill;
            fsparty.Show();
            fsparty.BringToFront();
            fsparty.Focus();

            fsparty.SetAction(BtnEvent.New, null);
            fsparty.SetFocus();
        }

        #endregion[lookup] 

        #region[Get selected pk value]

        private string GetSelectedPkValue()
        {
            DataGridViewRow vSelRow = null;
            if (listgrid.SelectedRows != null && listgrid.SelectedRows.Count != 0)
            {
                vSelRow = listgrid.SelectedRows[0];
            }

            string selPkValue = null;
            if (vSelRow != null)
            {
                selPkValue = vSelRow.Cells[PARTY.PARTY_ID].Value.ToString();
            }
            return selPkValue;
        }

        #endregion[Get selected pk value]

        #region[RaiseEvent]

        void VParty_NeedToRefresh(object sender, EventArgs e)
        {
            List_Option(ListOption.active);
        }
        #endregion[RaiseEvent]

    }//cls
}//ns
