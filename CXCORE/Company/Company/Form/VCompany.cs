// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// 28/03/2019 01:43:16 PM
// last update : 28-03-2019

using System;
using System.Windows.Forms;
using CXLIB;

namespace CXCORE
{
    public partial class FCompany
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Company obj;
        private string vId;

        public void SetAction(BtnEvent action, string pk)
        {
            fAction = action;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CCompany_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CCompany_exten.PKId(pk);
                    this.EnableControls(true);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Company_id;
            txt_company_name.Text = obj.Company_name;
            txt_display_name.Text = obj.Display_name;
            txt_street1.Text = obj.Street1;
            txt_street2.Text = obj.Street2;
            txt_city_id.Text = obj.City_id;
            txt_state_id.Text = obj.State_id;
            txt_country_id.Text = obj.Country_id;
            txt_pincode_id.Text = obj.Pincode_id;
            txt_cell1.Text = obj.Cell1;
            txt_cell2.Text = obj.Cell2;
            txt_phone.Text = obj.Phone;
            txt_email.Text = obj.Email;
            txt_website.Text = obj.Website;
            txt_gst.Text = obj.Gstin;
            txt_pan.Text = obj.Pan;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_company_name.Enabled = !pReadOnly;
            txt_display_name.Enabled = !pReadOnly;
            txt_street1.Enabled = !pReadOnly;
            txt_street2.Enabled = !pReadOnly;
            txt_city_id.Enabled = !pReadOnly;
            txt_state_id.Enabled = !pReadOnly;
            txt_country_id.Enabled = !pReadOnly;
            txt_pincode_id.Enabled = !pReadOnly;
            txt_cell1.Enabled = !pReadOnly;
            txt_cell2.Enabled = !pReadOnly;
            txt_phone.Enabled = !pReadOnly;
            txt_email.Enabled = !pReadOnly;
            txt_website.Enabled = !pReadOnly;
            txt_gst.Enabled = !pReadOnly;
            txt_pan.Enabled = !pReadOnly;
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
                        RaiseEvent_NeedToRefresh();
                        break;

                    case BtnEvent.Edit:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CCompany.Update(vData, dalsession);
                            dalsession.Commit();

                            MessageBox.Show(this.FindForm(), "Record Updated Successfully.", "Update...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            RaiseEvent_NeedToRefresh();
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
                }
            }
        }

        #endregion[Save Event]

        #region[Collect Data]

        private Company CollectData()
        {
            Company fobj = new Company()
            {
                Company_id = vId,
                Company_name = txt_company_name.Text,
                Display_name = txt_display_name.Text.ToUpper(),
                Street1 = txt_street1.Text,
                Street2 = txt_street2.Text,
                City_id = CCity_exten.GetId_Name(txt_city_id.Text),
                State_id = CState_exten.GetId_Name(txt_state_id.Text),
                Country_id = CCountry_exten.GetId_Name(txt_country_id.Text),
                Pincode_id = CPincode_exten.GetId_Name(txt_pincode_id.Text),
                Cell1 = txt_cell1.Text,
                Cell2 = txt_cell2.Text,
                Phone = txt_phone.Text,
                Email = txt_email.Text,
                Website = txt_website.Text,
                Gstin = txt_gst.Text.ToUpper(),
                Pan = txt_pan.Text,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        #endregion[CollectData]

        #region[Validation]

        private bool Validation()
        {
            if (txt_company_name.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Company name should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_company_name.Focus();
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
