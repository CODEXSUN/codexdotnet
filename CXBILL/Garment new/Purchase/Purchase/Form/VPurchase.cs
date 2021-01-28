// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:14:05 PM 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
using CXERP;

namespace CXBILL
{
    public partial class FPurchase : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Purchase obj;
        private List<Purchaseitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CPurchase_exten.PKId(pPkValue, new DAL());

                    //if (Customise.Purchase_poid_dcid == true)
                    //{
                    //    list = CPurchaseitems_exten.FKId(pPkValue, new DAL());
                    //}

                    //if ((Customise.Purchase_pono_dcno == true) || (Customise.Purchase_Without_podc == true))
                    //{
                    list = CPurchaseitems_exten.FKNo(pPkValue, new DAL());
                    //}

                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CPurchase.GetNew;
                    list = CPurchaseitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CPurchase_exten.PKId(pPkValue, new DAL());

                    //if (Customise.Purchase_poid_dcid == true)
                    //{
                    //    list = CPurchaseitems_exten.FKId(pPkValue, new DAL());
                    //}

                    //if ((Customise.Purchase_pono_dcno == true) || (Customise.Purchase_Without_podc == true))
                    //{
                    list = CPurchaseitems_exten.FKNo(pPkValue, new DAL());
                    //}

                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CPurchase_exten.PKId(pPkValue, new DAL());

                    //if (Customise.Purchase_poid_dcid == true)
                    //{
                    //    list = CPurchaseitems_exten.FKId(pPkValue, new DAL());
                    //}

                    //if ((Customise.Purchase_pono_dcno == true) || (Customise.Purchase_Without_podc == true))
                    //{
                    list = CPurchaseitems_exten.FKNo(pPkValue, new DAL());
                    //}

                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CPurchase_exten.PKId(pPkValue, new DAL());

                    //if (Customise.Purchase_poid_dcid == true)
                    //{
                    //    list = CPurchaseitems_exten.FKId(pPkValue, new DAL());
                    //}

                    //if ((Customise.Purchase_pono_dcno == true) || (Customise.Purchase_Without_podc == true))
                    //{
                    list = CPurchaseitems_exten.FKNo(pPkValue, new DAL());
                    //}

                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Purchase obj)
        {
            vId = obj.Purchase_id;
            txt_taxtype_id.Text = obj.Taxtype_id;
            SetTaxtype();
            txt_salestype_id.Text = obj.Salestype_id;
            txt_order_id.Text = obj.Order_id;
            txt_entry_no.Text = obj.Entry_no;
            txt_purchase_no.Text = obj.Purchase_no;
            txt_purchase_date.Text = obj.Purchase_date;
            txt_party_id.Text = obj.Party_id;
            txt_total_qty.Text = obj.Total_qty.ToString();
            //txt_total_taxable_amount.Text = obj.Total_taxable_amount;
            txt_gsttotal.Text = obj.Gsttotal.ToString();
            txt_ledger_id.Text = CLedger_exten.GetName_Id(obj.Ledger_id);
            txt_additional.Text = obj.Additional.ToString();
            txt_grandtotal.Text = obj.Grandtotal.ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Purchaseitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[PURCHASEITEMS.PURCHASEITEMS_ID].Value = (list[r].Purchaseitems_id) + "";
                    row.Cells[PURCHASEITEMS.PURCHASE_ID].Value = (list[r].Purchase_id) + "";
                    //row.Cells[PURCHASEITEMS.PURCHASE_NO].Value = (list[r].Purchase_no) + ""; 
                    //row.Cells[PURCHASEITEMS.PO_ID].Value = (list[r].Po_id) + "";
                    //row.Cells[PURCHASEITEMS.POITEMS_ID].Value = (list[r].Poitems_id) + ""; 

                    //if (list[r].Dc_id == "0")
                    //{
                    //    row.Cells[PURCHASEITEMS.DC_ID].Value = Core.Without_Dc;
                    //    row.Cells[PURCHASEITEMS.DCITEMS_ID].Value = "";
                    //}
                    //else
                    //{
                    //    row.Cells[PURCHASEITEMS.DC_ID].Value = (list[r].Dc_id) + "";
                    //    row.Cells[PURCHASEITEMS.DCITEMS_ID].Value = (list[r].Dcitems_id) + "";
                    //}

                    row.Cells[PURCHASEITEMS.PRODUCT_ID].Value = (list[r].Product_id) + "";
                    row.Cells[PURCHASEITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[PURCHASEITEMS.PRICE].Value = (list[r].Price) + "";
                    row.Cells[PURCHASEITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + "";
                    row.Cells[PURCHASEITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + "";
                    row.Cells[PURCHASEITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;
            txt_order_id.Enabled = !pReadOnly;
            txt_taxtype_id.Enabled = !pReadOnly;
            txt_salestype_id.Enabled = !pReadOnly;
            txt_entry_no.Enabled = !pReadOnly;
            txt_purchase_no.Enabled = !pReadOnly;
            txt_purchase_date.Enabled = !pReadOnly;
            txt_party_id.Enabled = !pReadOnly;
            txt_total_qty.Enabled = !pReadOnly;
            //txt_total_taxable_amount.Enabled = !pReadOnly;
            txt_gsttotal.Enabled = !pReadOnly;
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
                            CPurchase.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CPurchaseitems.Insert(itemsList, dalsession);

                            //if (Customise.Purchase_poid_dcid == true)
                            //{
                            //    CDc_refered.Refered(itemsList, itemsList, dalsession);
                            //}

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
                            txt_order_id.Focus();
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

                            var olditemslist = CPurchaseitems_exten.FK_withoutJoin(vId, new DAL());

                            CPurchaseitems.Delete(vId, dalsession);
                            CPurchase.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CPurchaseitems.Insert(itemsList, dalsession);


                            //if (Customise.Purchase_poid_dcid == true)
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
                            CPurchaseitems.Delete(vId, dalsession);
                            CPurchase.Delete(vId, dalsession);
                            var olditemslist = CPurchaseitems_exten.FK_withoutJoin(vId, new DAL());

                            //if (Customise.Purchase_poid_dcid == true)
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

        private Purchase CollectData()
        {
            Purchase fobj = new Purchase()
            {
                Purchase_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_entry_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Order_id = COrder_exten.GetId_Name(txt_order_id.Text, "", "", ""),
                Taxtype_id = CTaxtype_exten.GetId_Name(txt_taxtype_id.Text),
                Salestype_id = CSalestype_exten.GetId_Name(txt_salestype_id.Text),
                Entry_no = txt_entry_no.Text,
                Purchase_no = Checks.Escape(txt_purchase_no.Text),
                Purchase_date = txt_purchase_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Total_qty = ConvertTO.Decimal(txt_total_qty.Text),
                Total_taxable_amount = ConvertTO.Decimal(vTotTaxable.ToString()),
                Total_cgst = ConvertTO.Decimal(vTotCgst.ToString()),
                Total_sgst = ConvertTO.Decimal(vTotSgst.ToString()),
                Total_igst = ConvertTO.Decimal(vTotIgst.ToString()),
                Gsttotal = ConvertTO.Decimal(txt_gsttotal.Text),
                Ledger_id = CLedger_exten.GetId_Name(txt_ledger_id.Text),
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

        private List<Purchaseitems> Collectitems(string vId)
        {

            List<Purchaseitems> list = new List<Purchaseitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Purchaseitems obj = new Purchaseitems();

                if (
               (editgrid[PURCHASEITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[PURCHASEITEMS.QTY, r].Value + "") == "" ||
                (editgrid[PURCHASEITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Purchaseitems_id = "";
                    obj.Purchase_id = vId;
                    obj.Purchase_no = txt_purchase_no.Text;


                    //if (Customise.Purchase_poid_dcid == true)
                    //{
                    //    if (((editgrid[PURCHASEITEMS.PO_ID, r].Value + "") == "") || ((editgrid[PURCHASEITEMS.PO_ID, r].Value + "") == Core.Without_Po) || ((editgrid[PURCHASEITEMS.PO_ID, r].Value + "") == Core._Without_po_))
                    //    {
                    //        obj.Po_id = "1";
                    //        obj.Poitems_id = "1";
                    //    }
                    //    else
                    //    {

                    //        obj.Po_id = CPo_exten.GetId_Name(editgrid[PURCHASEITEMS.PO_ID, r].Value + "");
                    //        obj.Poitems_id = editgrid[PURCHASEITEMS.POITEMS_ID, r].Value + "";
                    //    }
                    //}

                    //if (Customise.Purchase_pono_dcno == true)
                    //{
                    //    obj.Po_id = (editgrid[PURCHASEITEMS.PO_ID, r].Value + "");
                    //    obj.Poitems_id = editgrid[PURCHASEITEMS.POITEMS_ID, r].Value + "";
                    //}

                    //if (Customise.Purchase_poid_dcid == true)
                    //{
                    //    if (((editgrid[PURCHASEITEMS.DC_ID, r].Value + "") == "") || ((editgrid[PURCHASEITEMS.DC_ID, r].Value + "") == Core.Without_Dc) || ((editgrid[PURCHASEITEMS.DC_ID, r].Value + "") == "0"))
                    //    {
                    //        obj.Dc_id = "1";
                    //        obj.Dcitems_id = "1";
                    //    }
                    //    else
                    //    {
                    //        obj.Dc_id = CDc_exten.GetId_Name(editgrid[PURCHASEITEMS.DC_ID, r].Value + "");
                    //        obj.Dcitems_id = (editgrid[PURCHASEITEMS.DCITEMS_ID, r].Value + "");
                    //        if (obj.Dcitems_id == "") { obj.Dcitems_id = "1"; }
                    //    }
                    //}

                    //if (Customise.Purchase_pono_dcno == true)
                    //{
                    //    obj.Dc_id = (editgrid[PURCHASEITEMS.DC_ID, r].Value + "");
                    //    obj.Dcitems_id = (editgrid[PURCHASEITEMS.DCITEMS_ID, r].Value + "");
                    //}

                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[PURCHASEITEMS.PRODUCT_ID, r].Value + ""));
                    obj.Qty = ConvertTO.Decimal(editgrid[PURCHASEITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[PURCHASEITEMS.PRICE, r].Value + "");
                    obj.Cgst_percent = ConvertTO.Decimal(editgrid[PURCHASEITEMS.CGST_PERCENT, r].Value + "");
                    obj.Sgst_percent = ConvertTO.Decimal(editgrid[PURCHASEITEMS.SGST_PERCENT, r].Value + "");
                    obj.Igst_percent = ConvertTO.Decimal(editgrid[PURCHASEITEMS.IGST_PERCENT, r].Value + "");
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
            if (txt_purchase_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Purchase no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_purchase_no.Focus();
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
