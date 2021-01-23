// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 08:07:53 PM

using System;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class FParty : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Party obj;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CParty_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CParty.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CParty_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CParty_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CParty_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Party_id;
            txt_party_name.Text = obj.Party_name;
            txt_contacttype_id.Text = obj.Contacttype_id;
            txt_contact_person.Text = obj.Contact_person;
            txt_street1.Text = obj.Street_1;
            txt_street2.Text = obj.Street_2;
            txt_city_id.Text = obj.City_id;
            txt_state_id.Text = obj.State_id;
            txt_country_id.Text = obj.Country_id;
            txt_pincode_id.Text = obj.Pincode_id;
            txt_phone.Text = obj.Phone;
            txt_cell.Text = obj.Cell;
            txt_email.Text = obj.Email;
            txt_website.Text = obj.Website;
            txt_gst.Text = obj.Gstin;
            txt_pan.Text = obj.Pan;
            txt_opening_balance.Text = obj.Opening_balance.ToString();
            txt_credit_days.Text = obj.Credit_days.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_party_name.Enabled = !pReadOnly;
            txt_contacttype_id.Enabled = !pReadOnly;
            txt_contact_person.Enabled = !pReadOnly;
            txt_street1.Enabled = !pReadOnly;
            txt_street2.Enabled = !pReadOnly;
            txt_city_id.Enabled = !pReadOnly;
            txt_state_id.Enabled = !pReadOnly;
            txt_country_id.Enabled = !pReadOnly;
            txt_pincode_id.Enabled = !pReadOnly;
            txt_phone.Enabled = !pReadOnly;
            txt_cell.Enabled = !pReadOnly;
            txt_email.Enabled = !pReadOnly;
            txt_website.Enabled = !pReadOnly;
            txt_gst.Enabled = !pReadOnly;
            txt_pan.Enabled = !pReadOnly;
            txt_opening_balance.Enabled = !pReadOnly;
            txt_credit_days.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            btn_active.Enabled = !pReadOnly;

        }

        #endregion[Enable  Disable Controls]

        #region[Save Event]

        private DAL dalsession;
        private void Save_Event()
        {
            if (Validation() != false)
            {
                switch (fAction)
                {
                    case BtnEvent.Open:
                        this.Hide();
                        Form_NeedToRefresh();
                        break;

                    case BtnEvent.New:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CParty.Insert(vData, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Saved Successfully.", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Save...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Edit:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CParty.Update(vData, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Updated Successfully.", "Update...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Update...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Delete:
                        try
                        {
                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CParty.Delete(vId, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Deleted Successfully.", "Delete...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        catch (Exception ex)
                        {
                            if (dalsession != null)
                            {
                                dalsession.Rollback();
                            }
                            MessageBox.Show(this.FindForm(), "Something Goes Wrong \r\n" + ex.Message, "Could Not Update...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetFocus();
                            return;
                        }
                        break;

                    case BtnEvent.Print:
                        this.Hide();
                        Form_NeedToRefresh();
                        break;
                }
            }
        }

        #endregion[Save Event]

        #region[Collect Data]

        private Party CollectData()
        {
            Party fobj = new Party()
            {
                Party_id = vId,
                Party_name = ChangeCase.ToUpper(txt_party_name.Text),
                Contacttype_id = CContacttype_exten.GetId_Name(txt_contacttype_id.Text),
                Contact_person = ChangeCase.UpperFirst(txt_contact_person.Text),
                Street_1 = txt_street1.Text,
                Street_2 = txt_street2.Text,
                City_id = CCity_exten.GetId_Name(txt_city_id.Text),
                State_id = CState_exten.GetId_Name(txt_state_id.Text),
                Country_id = CCountry_exten.GetId_Name(txt_country_id.Text),
                Pincode_id = CPincode_exten.GetId_Name(txt_pincode_id.Text),
                Phone = txt_phone.Text,
                Cell = txt_cell.Text,
                Email = txt_email.Text,
                Website = txt_website.Text,
                Gstin = ChangeCase.ToUpper(txt_gst.Text),
                Pan = txt_pan.Text,
                Opening_balance = ConvertTO.Decimal(txt_opening_balance.Text),
                Credit_days = ConvertTO.Decimal(txt_credit_days.Text),
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };

            if ((fobj.Contacttype_id == null) || (fobj.Contacttype_id == "")) { fobj.Contacttype_id = "1"; }
            if ((fobj.City_id == null) || (fobj.City_id == "")) { fobj.City_id = "1"; }
            if ((fobj.State_id == null) || (fobj.State_id == "")) { fobj.State_id = "1"; }
            if ((fobj.Country_id == null) || (fobj.Country_id == "")) { fobj.Country_id = "1"; }
            if ((fobj.Pincode_id == null) || (fobj.Pincode_id == "")) { fobj.Pincode_id = "1"; }

            return fobj;
        }

        #endregion[CollectData]

        #region[Validation]

        private bool Validation()
        {
            if (txt_party_name.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Party name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_party_name.Focus();
                return false;
            }

            if (Core.Stative == Core.Idle)
            {
                MessageBox.Show(this.FindForm(), "Select Active or not !", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_active.Focus();
                return false;
            }

            return true;
        }

        #endregion[Validation]

    }//cls 
}//ns 
