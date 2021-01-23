// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:23:18 PM

using System;
using System.Windows.Forms;
using CodexsunLib;

namespace CodexsunCore
{
    public partial class FVoucher : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Voucher obj;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "CLOSE";
                    obj = CVoucher_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "SAVE";
                    obj = CVoucher.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "UPDATE";
                    obj = CVoucher_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\nDELETE";
                    obj = CVoucher_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "PRINT";
                    obj = CVoucher_exten.PKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
            }

            this.LoadData();
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData()
        {
            vId = obj.Voucher_id;
            txt_voucher_no.Text = obj.Voucher_no;
            txt_voucher_date.Text = obj.Voucher_date;
            txt_vouchertype_id.Text = obj.Vouchertype_id;
            txt_order_id.Text = obj.Order_id;
            txt_ledger_id.Text = obj.Ledger_id;
            txt_party_id.Text = obj.Party_id;
            txt_purpose.Text = obj.Purpose;
            txt_credit.Text = obj.Credit;
            txt_debit.Text = obj.Debit;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_voucher_no.Enabled = !pReadOnly;
            txt_voucher_date.Enabled = !pReadOnly;
            txt_vouchertype_id.Enabled = !pReadOnly;
            txt_order_id.Enabled = !pReadOnly;
            txt_ledger_id.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_purpose.Enabled = !pReadOnly;
            txt_credit.Enabled = !pReadOnly;
            txt_debit.Enabled = !pReadOnly;
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
                            CVoucher.Insert(vData, dalsession);
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
                            CVoucher.Update(vData, dalsession);
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
                            CVoucher.Delete(vId, dalsession);
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

        private Voucher CollectData()
        {
            Voucher fobj = new Voucher()
            {
                Voucher_id = vId,
                Company_id = Current.Company_id,
                Voucher_no = txt_voucher_no.Text,
                Voucher_date = txt_voucher_date.Text,
                Vouchertype_id = CVouchertype_exten.GetId_Name(txt_vouchertype_id.Text),
                Order_id = COrder_exten.GetId_Name(txt_order_id.Text),
                Ledger_id = CLedger_exten.GetId_Name(txt_ledger_id.Text),
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Purpose = txt_purpose.Text,
                Credit = "",
                Debit = "",
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };


            var method = CVouchertype_exten.GetMethodid_Name(txt_vouchertype_id.Text);

            if (method == "1")// 1 payment
            {
                fobj.Credit = txt_credit.Text;
            }
            else if (method == "2") // receipt
            {
                fobj.Debit = txt_debit.Text;
            }


            return fobj;
        }

        #endregion[CollectData]

        #region[Validation]

        private bool Validation()
        {
            if (txt_vouchertype_id.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Vouchertype id should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_vouchertype_id.Focus();
                return false;
            }

            if (txt_voucher_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Voucher no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_voucher_no.Focus();
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
