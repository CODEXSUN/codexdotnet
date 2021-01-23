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
    public partial class FTex_receipt : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Tex_receipt obj;
        private List<Garment_receiptitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CTex_receipt_exten.PKId(pPkValue, new DAL());
                    list = CTex_receiptitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CTex_receipt.GetNew;
                    list = CTex_receiptitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CTex_receipt_exten.PKId(pPkValue, new DAL());
                    list = CTex_receiptitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CTex_receipt_exten.PKId(pPkValue, new DAL());
                    list = CTex_receiptitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CTex_receipt_exten.PKId(pPkValue, new DAL());
                    list = CTex_receiptitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    // print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Tex_receipt obj)
        {
            vId = obj.Tex_receipt_id;
            txt_receipt_no.Text = obj.Tex_receipt_no;
            txt_receipt_date.Text = obj.Tex_receipt_date;
            txt_party_id.Text = obj.Party_id;
            txt_receipttype_id.Text = obj.Receipttype_id;
            txt_cheq_no.Text = obj.Cheq_no;
            txt_receipt_amount.Text = obj.Receipt_amount;
            txt_cheq_date.Text = obj.Cheq_date;
            txt_bank_id.Text = obj.Bank_id;
            txt_total_amount.Text = obj.Total_amount;
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Garment_receiptitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    //row.Cells[RECEIPTITEMS.RECEIPTITEMS_ID].Value = (list[r].Receiptitems_id) + "";
                    row.Cells[TEX_RECEIPTITEMS.TEX_RECEIPT_ID].Value = (list[r].Garment_receipt_id) + "";
                    row.Cells[TEX_RECEIPTITEMS.RECEIPT_BY].Value = (list[r].Receipt_by) + "";
                    row.Cells[TEX_RECEIPTITEMS.TEX_INVOICED_NO].Value = (list[r].Garment_invoiced_no) + "";
                    row.Cells[TEX_RECEIPTITEMS.TEX_INVOICED_AMOUNT].Value = (list[r].Garment_invoiced_amount) + "";
                    row.Cells[TEX_RECEIPTITEMS.TEX_RECEIPT_AMOUNT].Value = (list[r].Garment_receipt_amount) + "";
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
                            CTex_receipt.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CTex_receiptitems.Insert(itemsList, dalsession);
                            CReceipt_refered.Refered(itemsList,dalsession);
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
                            CTex_receiptitems.Delete(vId, dalsession);
                            CTex_receipt.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CTex_receiptitems.Insert(itemsList, dalsession);
                            CReceipt_refered.Refered(itemsList, dalsession);
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
                            CTex_receiptitems.Delete(vId, dalsession);
                            CTex_receipt.Delete(vId, dalsession);
                            CReceipt_refered.Refered(list, dalsession);
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

        private Tex_receipt CollectData()
        {
            Tex_receipt fobj = new Tex_receipt()
            {
                Tex_receipt_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_receipt_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Tex_receipt_no = txt_receipt_no.Text,
                Tex_receipt_date = txt_receipt_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Receipttype_id = CReceipttype_exten.GetId_Name(txt_receipttype_id.Text),
                Cheq_no = txt_cheq_no.Text,
                Receipt_amount = txt_receipt_amount.Text,
                Cheq_date = txt_cheq_date.Text,
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

        private List<Garment_receiptitems> Collectitems(string vId)
        {

            List<Garment_receiptitems> list = new List<Garment_receiptitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Garment_receiptitems obj = new Garment_receiptitems();

                if (
                (editgrid[TEX_RECEIPTITEMS.TEX_RECEIPT_AMOUNT, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Garment_receiptitems_id = "";
                    obj.Garment_receipt_id = vId;
                    obj.Receipt_by = (editgrid[TEX_RECEIPTITEMS.RECEIPT_BY, r].Value + "");
                    obj.Garment_invoiced_no = (editgrid[TEX_RECEIPTITEMS.TEX_INVOICED_NO, r].Value + "");
                    obj.Garment_invoiced_amount = ConvertTO.Decimal(editgrid[TEX_RECEIPTITEMS.TEX_INVOICED_AMOUNT, r].Value + "");
                    obj.Garment_receipt_amount = ConvertTO.Decimal(editgrid[TEX_RECEIPTITEMS.TEX_RECEIPT_AMOUNT, r].Value + "");

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
