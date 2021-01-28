// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:07 AM

using System;
using System.Windows.Forms;
using CXCORE;
using CXLIB;
using CXBILL;
using CXERP;

namespace CXACCOUNTS
{
    public partial class FCash_payment : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Cash_payment obj;
        private string vId;

        public void SetAction(BtnEvent action, string pk)
        {
            fAction = action;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CCash_payment_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CCash_payment.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CCash_payment_exten.PKId(pk);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CCash_payment_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CCash_payment_exten.PKId(pk);
                    this.EnableControls(false);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Cash_payment_id;
            txt_order_id.Text = obj.Order_id;
            txt_payment_date.Text = obj.Payment_date;
            txt_ledger_id.Text = obj.Ledger_id;
            txt_purpose.Text = obj.Purpose;
            txt_party_id.Text = obj.Party_id;
            txt_payment_amount.Text = obj.Payment_amount.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_order_id.Enabled = !pReadOnly;
            txt_payment_date.Enabled = !pReadOnly;
            txt_ledger_id.Enabled = !pReadOnly;
            txt_purpose.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_payment_amount.Enabled = !pReadOnly;
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
                            CCash_payment.Insert(vData, dalsession);
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
                            CCash_payment.Update(vData, dalsession);
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
                            CCash_payment.Delete(vId, dalsession);
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

        private Cash_payment CollectData()
        {
            Cash_payment fobj = new Cash_payment()
            {
                Cash_payment_id = vId,
                Order_id = COrder_exten.GetId_Name(txt_order_id.Text, "", "", ""),
                Payment_date = txt_payment_date.Text,
                Ledger_id = CLedger_exten.GetId_Name(txt_ledger_id.Text),
                Purpose = txt_purpose.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Payment_amount = ConvertTO.Decimal(txt_payment_amount.Text),
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
            if (txt_order_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Order id should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_order_id.Focus();
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
