// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:15 AM

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

//  
namespace CXBILL
{
    public partial class FPayment : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Payment obj;
        private List<Paymentitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CPayment_exten.PKId(pPkValue, new DAL());
                    list = CPaymentitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CPayment.GetNew;
                    list = CPaymentitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CPayment_exten.PKId(pPkValue, new DAL());
                    list = CPaymentitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CPayment_exten.PKId(pPkValue, new DAL());
                    list = CPaymentitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CPayment_exten.PKId(pPkValue, new DAL());
                    list = CPaymentitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    // print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Payment obj)
        {
            vId = obj.Payment_id;
            txt_payment_no.Text = obj.Payment_no;
            txt_payment_date.Text = obj.Payment_date;
            txt_party_id.Text = obj.Party_id;
            txt_receipttype_id.Text = obj.Receipttype_id;
            txt_cheq_no.Text = obj.Cheque_no;
            txt_payment_amount.Text = obj.Payment_amount;
            txt_cheq_date.Text = obj.Cheque_date;
            txt_bank_id.Text = obj.Bank_id;
            //txt_total_amount.Text = obj.Total_amount;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Paymentitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    //row.Cells[PAYMENTITEMS.PAYMENTITEMS_ID].Value = (list[r].Paymentitems_id) + "";
                    row.Cells[PAYMENTITEMS.PAYMENT_ID].Value = (list[r].Payment_id) + "";
                    row.Cells[PAYMENTITEMS.PAYMENT_BY].Value = (list[r].Payment_by) + "";
                    row.Cells[PAYMENTITEMS.PURCHASE_NO].Value = (list[r].Purchase_no) + "";
                    row.Cells[PAYMENTITEMS.PURCHASE_AMOUNT].Value = (list[r].Purchase_amount) + "";
                    row.Cells[PAYMENTITEMS.PAYMENT_AMOUNT].Value = (list[r].Payment_amount) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_payment_no.Enabled = !pReadOnly;
            txt_payment_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_receipttype_id.Enabled = !pReadOnly;
            txt_cheq_no.Enabled = !pReadOnly;
            txt_payment_amount.Enabled = !pReadOnly;
            txt_cheq_date.Enabled = !pReadOnly;
            txt_bank_id.Enabled = !pReadOnly;
            txt_total_amount.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;
            editgrid.Enabled = !pReadOnly;
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
                            CPayment.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CPaymentitems.Insert(itemsList, dalsession);
                            //CPayment_refered.Refered(itemsList,dalsession);
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
                            CPaymentitems.Delete(vId, dalsession);
                            CPayment.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CPaymentitems.Insert(itemsList, dalsession);
                            //CPayment_refered.Refered(itemsList, dalsession);
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
                            CPaymentitems.Delete(vId, dalsession);
                            CPayment.Delete(vId, dalsession);
                            //CPayment_refered.Refered(list, dalsession);
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

        private Payment CollectData()
        {
            Payment fobj = new Payment()
            {
                Payment_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_payment_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Payment_no = txt_payment_no.Text,
                Payment_date = txt_payment_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Receipttype_id = CReceipttype_exten.GetId_Name(txt_receipttype_id.Text),
                Cheque_no = txt_cheq_no.Text,
                Payment_amount = txt_payment_amount.Text,
                Cheque_date = txt_cheq_date.Text,
                Bank_id = GetBankid,
                Total_amount = txt_total_amount.Text,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };
            return fobj;
        }

        private string GetBankid
        {
            get
            {
                if (txt_receipttype_id.Text.ToUpper() == "CHEQUE")
                {
                    return CBank_exten.GetId_Name(txt_bank_id.Text);
                }
                else
                {
                    return "1";
                }
            }
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Paymentitems> Collectitems(string vId)
        {

            List<Paymentitems> list = new List<Paymentitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Paymentitems obj = new Paymentitems();

                if (
                (editgrid[PAYMENTITEMS.PAYMENT_AMOUNT, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Paymentitems_id = "";
                    obj.Payment_id = vId;
                    obj.Payment_by = (editgrid[PAYMENTITEMS.PAYMENT_BY, r].Value + "");
                    obj.Purchase_no = (editgrid[PAYMENTITEMS.PURCHASE_NO, r].Value + "");
                    obj.Purchase_amount = (editgrid[PAYMENTITEMS.PURCHASE_AMOUNT, r].Value + "");
                    obj.Payment_amount = (editgrid[PAYMENTITEMS.PAYMENT_AMOUNT, r].Value + "");

                    list.Add(obj);
                }

            }

            if (list.Count != 0)
            {
                return list;
            }

            return null;
        }

        #endregion[Collect items] 

        #region[Validation]

        private bool Validation()
        {
            if (txt_payment_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Payment no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_payment_no.Focus();
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
