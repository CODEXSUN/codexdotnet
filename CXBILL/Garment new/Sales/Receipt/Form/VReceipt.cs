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
    public partial class FReceipt : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Receipt obj;
        private List<Receiptitems> list;
        private string vId;

        public void SetAction(BtnEvent action, string pk)
        {
            fAction = action;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CReceipt_exten.PKId(pk);
                    list = CReceiptitems_exten.FKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CReceipt.GetNew;
                    list = CReceiptitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CReceipt_exten.PKId(pk);
                    list = CReceiptitems_exten.FKId(pk);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CReceipt_exten.PKId(pk);
                    list = CReceiptitems_exten.FKId(pk);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CReceipt_exten.PKId(pk);
                    list = CReceiptitems_exten.FKId(pk);
                    this.EnableControls(false);
                    // print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Receipt obj)
        {
            vId = obj.Receipt_id;
            txt_receipt_no.Text = obj.Receipt_no;
            txt_receipt_date.Text = obj.Receipt_date;
            txt_party_id.Text = obj.Party_id;
            txt_receipttype_id.Text = obj.Receipttype_id;
            txt_cheq_no.Text = obj.Cheq_no;
            txt_receipt_amount.Text = obj.Receipt_amount.ToString();
            txt_cheq_date.Text = obj.Cheq_date;
            txt_bank_id.Text = obj.Bank_id;
            txt_total_amount.Text = obj.Total_amount.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Receiptitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    //row.Cells[RECEIPTITEMS.RECEIPTITEMS_ID].Value = (list[r].Receiptitems_id) + "";
                    row.Cells[RECEIPTITEMS.RECEIPT_ID].Value = (list[r].Receipt_id) + "";
                    row.Cells[RECEIPTITEMS.RECEIPT_BY].Value = (list[r].Receipt_by) + "";
                    row.Cells[RECEIPTITEMS.INVOICED_NO].Value = (list[r].Invoiced_no) + "";
                    row.Cells[RECEIPTITEMS.INVOICED_AMOUNT].Value = (list[r].Invoiced_amount) + "";
                    row.Cells[RECEIPTITEMS.RECEIPT_AMOUNT].Value = (list[r].Receipt_amount) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_receipt_no.Enabled = !pReadOnly;
            txt_receipt_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_receipttype_id.Enabled = !pReadOnly;
            txt_cheq_no.Enabled = !pReadOnly;
            txt_receipt_amount.Enabled = !pReadOnly;
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
                            CReceipt.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CReceiptitems.Insert(itemsList, dalsession);
                            //CReceipt_refered.Refered(itemsList, dalsession);
                            
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
                            CReceiptitems.Delete(vId, dalsession);
                            CReceipt.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CReceiptitems.Insert(itemsList, dalsession);
                            //CReceipt_refered.Refered(itemsList, dalsession);
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
                            CReceiptitems.Delete(vId, dalsession);
                            CReceipt.Delete(vId, dalsession);
                            //CReceipt_refered.Refered(list, dalsession);
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

        private Receipt CollectData()
        {
            Receipt fobj = new Receipt()
            {
                Receipt_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_receipt_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Receipt_no = txt_receipt_no.Text,
                Receipt_date = txt_receipt_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Receipttype_id = CReceipttype_exten.GetId_Name(txt_receipttype_id.Text),
                Cheq_no = txt_cheq_no.Text,
                Receipt_amount = ConvertTO.Decimal(txt_receipt_amount.Text),
                Cheq_date = txt_cheq_date.Text,
                Bank_id = GetBankid,
                Total_amount = ConvertTO.Decimal(txt_total_amount.Text),
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

        private List<Receiptitems> Collectitems(string vId)
        {

            List<Receiptitems> list = new List<Receiptitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Receiptitems obj = new Receiptitems();

                if (
                (editgrid[RECEIPTITEMS.RECEIPT_AMOUNT, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Receiptitems_id = "";
                    obj.Receipt_id = vId;
                    obj.Receipt_by = (editgrid[RECEIPTITEMS.RECEIPT_BY, r].Value + "");
                    obj.Invoiced_no = (editgrid[RECEIPTITEMS.INVOICED_NO, r].Value + "");
                    obj.Invoiced_amount = editgrid[RECEIPTITEMS.INVOICED_AMOUNT, r].Value + "";
                    obj.Receipt_amount = ConvertTO.Decimal(editgrid[RECEIPTITEMS.RECEIPT_AMOUNT, r].Value + "");

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
            if (txt_receipt_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Receipt no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_receipt_no.Focus();
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
