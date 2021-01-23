// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:14:05 PM 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXBILL
{
    public partial class FQuotation
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Quotation obj;
        private List<Quotationitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CQuotation_exten.PKId(pPkValue, new DAL());
                    list = CQuotationitems_exten.FKNo(pPkValue, new DAL());

                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CQuotation.GetNew;
                    list = CQuotationitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CQuotation_exten.PKId(pPkValue, new DAL());
                    list = CQuotationitems_exten.FKNo(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CQuotation_exten.PKId(pPkValue, new DAL());
                    list = CQuotationitems_exten.FKNo(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CQuotation_exten.PKId(pPkValue, new DAL());
                    list = CQuotationitems_exten.FKNo(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Quotation obj)
        {
            vId = obj.Quotation_id;
            txt_quotation_no.Text = obj.Quotation_no.ToString();
            txt_quotation_date.Text = obj.Quotation_date;
            txt_party_id.Text = obj.Party_id;
            //txt_total_qty.Text = obj.Total_qty.ToString();
            //txt_total_taxable_amount.Text = obj.Total_taxable_amount;
            //txt_gsttotal.Text = obj.Gsttotal.ToString();
            txt_ledger_id.Text = obj.Ledger_id;
            txt_additional.Text = obj.Additional.ToString();
            txt_grandtotal.Text = obj.Grandtotal.ToString();
            txt_balance.Text = CQuotation_exten.GetBalance(CParty_exten.GetId_Name(txt_party_id.Text)).ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Quotationitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[QUOTATIONITEMS.QUOTATIONITEMS_ID].Value = (list[r].Quotationitems_id) + "";
                    row.Cells[QUOTATIONITEMS.QUOTATION_ID].Value = (list[r].Quotation_id) + "";
                    row.Cells[QUOTATIONITEMS.PRODUCT_ID].Value = Checks.RemoveEscape((list[r].Product_id) + "");
                    row.Cells[QUOTATIONITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[QUOTATIONITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[QUOTATIONITEMS.PRICE].Value = (list[r].Price) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_quotation_no.Enabled = !pReadOnly;
            txt_quotation_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            //txt_total_qty.Enabled = !pReadOnly;
            //txt_total_taxable_amount.Enabled = !pReadOnly;
            //txt_gsttotal.Enabled = !pReadOnly;
            txt_ledger_id.Enabled = !pReadOnly;
            txt_additional.Enabled = !pReadOnly;
            txt_grandtotal.Enabled = !pReadOnly;
            txt_notes.Enabled = !pReadOnly;

            editgrid.Enabled = !pReadOnly;
            btn_active.Enabled = !pReadOnly;

        }

        #endregion[Enable  Disable Controls]

        #region[Save Event]

        private DAL dalsession;
        private void Save_Event(string info)
        {
            if (Validation() != false)
            {
                switch (fAction)
                {
                    case BtnEvent.Open:

                        if (info != Core.saveprint)
                        {
                            this.Hide();
                            Form_NeedToRefresh();
                        }
                        else
                        {
                            Print_copies();
                            this.Hide();
                            Form_NeedToRefresh();
                        }

                        break;

                    case BtnEvent.New:
                        try
                        {
                            var vData = CollectData();

                            dalsession = new DAL();
                            dalsession.BeginTransaction();
                            CQuotation.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CQuotationitems.Insert(itemsList, dalsession);
                            CSeq_exten.UpdateNextNo(SEQ.QUOTATION_NO, dalsession);
                            dalsession.Commit();

                            if (info != Core.saveprint)
                            {
                                MessageBox.Show(this.FindForm(), "Record Saved Successfully.", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                Print_copies();
                                this.Hide();
                                Form_NeedToRefresh();
                            }
                            //this.Hide();
                            //Form_NeedToRefresh();

                            SetAction(BtnEvent.New, null);
                            txt_quotation_no.Focus();
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

                            var olditemslist = CQuotationitems_exten.FK_withoutJoin(vId, new DAL());

                            CQuotationitems.Delete(vId, dalsession);
                            CQuotation.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CQuotationitems.Insert(itemsList, dalsession);


                            //if (Customise.Invoice_poid_dcid == true)
                            //{
                            //    CDc_refered.Refered(itemsList, olditemslist, dalsession);
                            //}

                            dalsession.Commit();

                            if (info != Core.saveprint)
                            {
                                MessageBox.Show(this.FindForm(), "Record Updated Successfully.", "Update...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                Print_copies();
                            }
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
                            CQuotationitems.Delete(vId, dalsession);
                            CQuotation.Delete(vId, dalsession);
                            var olditemslist = CQuotationitems_exten.FK_withoutJoin(vId, new DAL());

                            //if (Customise.Invoice_poid_dcid == true)
                            //{
                            //    CDc_refered.Refered(olditemslist, olditemslist, dalsession);
                            //}

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
                        Print_copies();
                        this.Hide();
                        Form_NeedToRefresh();
                        break;
                }
            }
        }

        #endregion[Save Event]

        #region[Collect Data]

        private Quotation CollectData()
        {
            Quotation fobj = new Quotation()
            {
                Quotation_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_quotation_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Order_id = "1",
                Quotation_no = txt_quotation_no.Text,
                Quotation_date = txt_quotation_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Total_qty = ConvertTO.Decimal(totalQty),
                Total_taxable_amount = ConvertTO.Decimal(vTotTaxable.ToString()),
                Ledger_id = txt_ledger_id.Text,
                Additional = ConvertTO.Decimal(txt_additional.Text),
                Rounds = ConvertTO.Decimal(vRoundoff.ToString()),
                Grandtotal = ConvertTO.Decimal(txt_grandtotal.Text),
                Refered_amt = ConvertTO.Decimal(txt_grandtotal.Text),
                Locked = Core.Unlocked,
                Active_id = Core.Stative,
                Notes = txt_notes.Text,
                User_id = Current.User
            };

            return fobj;
        }

        #endregion[CollectData]

        #region[Collect items] 

        private List<Quotationitems> Collectitems(string vId)
        {

            List<Quotationitems> list = new List<Quotationitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Quotationitems obj = new Quotationitems();

                if (
               (editgrid[QUOTATIONITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[QUOTATIONITEMS.QTY, r].Value + "") == "" ||
                (editgrid[QUOTATIONITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Quotationitems_id = "";
                    obj.Quotation_id = vId;
                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[QUOTATIONITEMS.PRODUCT_ID, r].Value + ""));
                    obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[QUOTATIONITEMS.SIZES_ID, r].Value + "");
                    obj.Qty = (editgrid[QUOTATIONITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[QUOTATIONITEMS.PRICE, r].Value + "");
                    obj.Refered_id = "";
                    obj.Locked = Core.Unlocked;

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
            if (txt_quotation_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Quotation no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_quotation_no.Focus();
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
