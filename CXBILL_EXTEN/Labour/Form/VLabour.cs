// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:14:05 PM 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXBILL;
using CXCORE;
using CXERP;
using CXLIB;
using CLabour = CXBILL_EXTEN.Labour.Class.CLabour;
using CLabour_exten = CXBILL_EXTEN.Labour.Class.CLabour_exten;
using CLabouritems = CXBILL_EXTEN.Labour.Class.CLabouritems;
using CLabouritems_exten = CXBILL_EXTEN.Labour.Class.CLabouritems_exten;
using Labouritems = CXBILL_EXTEN.Labour.Const.Labouritems;
using LABOURITEMS = CXBILL_EXTEN.Labour.Const.LABOURITEMS;

namespace CXBILL_EXTEN.Labour.Form
{
    public partial class FLabour
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Const.Labour obj;
        private List<Labouritems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CLabour_exten.PKId(pPkValue);
                    list = CLabouritems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CLabour.GetNew;
                    list = CLabouritems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CLabour_exten.PKId(pPkValue);
                    list = CLabouritems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CLabour_exten.PKId(pPkValue);
                    list = CLabouritems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CLabour_exten.PKId(pPkValue);
                    list = CLabouritems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Const.Labour obj)
        {
            vId = obj.Labour_id;
            txt_order_id.Text = obj.Order_id;
            txt_invoice_no.Text = obj.Labour_no.ToString();
            txt_invoice_date.Text = obj.Labour_date;
            txt_party_id.Text = obj.Party_id;
            txt_taxtype_id.Text = obj.Taxtype_id;
            SetTaxtype();
            txt_salestype_id.Text = obj.Salestype_id;
            txt_transport_id.Text = obj.Transport_id;
            txt_deliveredto_id.Text = obj.Deliveredto_id;
            txt_bundel.Text = obj.Bundel;
            txt_total_qty.Text = obj.Total_qty.ToString();
            //txt_total_taxable_amount.Text = obj.Total_taxable_amount;
            txt_gsttotal.Text = obj.Gsttotal.ToString();
            txt_ledger_id.Text = CLedger_exten.GetName_Id(obj.Ledger_id);
            txt_additional.Text = obj.Additional.ToString();
            txt_grandtotal.Text = obj.Grandtotal.ToString();
            txt_balance.Text = CLabour_exten.GetBalance(CParty_exten.GetId_Name(txt_party_id.Text)).ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Labouritems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[LABOURITEMS.LABOURITEMS_ID].Value = (list[r].Labouritems_id) + "";
                    row.Cells[LABOURITEMS.LABOUR_ID].Value = (list[r].Labour_id) + "";
                    row.Cells[LABOURITEMS.PO_NO].Value = (list[r].Po_no) + "";
                    row.Cells[LABOURITEMS.DC_NO].Value = (list[r].Dc_no) + ""; 
                    row.Cells[LABOURITEMS.PRODUCT_ID].Value = Checks.RemoveEscape((list[r].Product_id) + "");
                    row.Cells[LABOURITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[LABOURITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[LABOURITEMS.PRICE].Value = (list[r].Price) + "";
                    row.Cells[LABOURITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + "";
                    row.Cells[LABOURITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + "";
                    row.Cells[LABOURITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + "";
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
            txt_transport_id.Enabled = !pReadOnly;
            txt_deliveredto_id.Enabled = !pReadOnly;
            txt_bundel.Enabled = !pReadOnly;
            txt_invoice_no.Enabled = !pReadOnly;
            txt_invoice_date.Enabled = !pReadOnly;
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
                            CLabour.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CLabouritems.Insert(itemsList, dalsession);

                            //if (Customise.Labour_poid_dcid == true)
                            //{
                            //    //CDc_refered.Refered(itemsList, itemsList, dalsession);
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
                            txt_invoice_no.Focus();
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

                            var olditemslist = CLabouritems_exten.FK_withoutJoin(vId, new DAL());

                            CLabouritems.Delete(vId, dalsession);
                            CLabour.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CLabouritems.Insert(itemsList, dalsession);


                            //if (Customise.Labour_poid_dcid == true)
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
                            CLabouritems.Delete(vId, dalsession);
                            CLabour.Delete(vId, dalsession);
                            var olditemslist = CLabouritems_exten.FK_withoutJoin(vId, new DAL());

                            //if (Customise.Labour_poid_dcid == true)
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

        private Const.Labour CollectData()
        {
            Const.Labour fobj = new Const.Labour()
            {
                Labour_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_invoice_no.Text,
                Company_id = Current.Company_id,
                //Div_id = Current.Div_id,
                Acy_id = Current.Acy_id,
                Order_id = COrder_exten.GetId_Name(txt_order_id.Text,"","",""),
                Labour_no = txt_invoice_no.Text,
                Labour_date = txt_invoice_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Taxtype_id = CTaxtype_exten.GetId_Name(txt_taxtype_id.Text),
                Salestype_id = CSalestype_exten.GetId_Name(txt_salestype_id.Text),
                Transport_id = CTransport_exten.GetId_Name(txt_transport_id.Text),
                Deliveredto_id = CDeliveredto_exten.GetId_Name(txt_deliveredto_id.Text),
                Bundel = txt_bundel.Text,
                Total_qty = txt_total_qty.Text,
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

        private List<Labouritems> Collectitems(string vId)
        {

            List<Labouritems> list = new List<Labouritems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Labouritems obj = new Labouritems();

                if (
               (editgrid[LABOURITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[LABOURITEMS.QTY, r].Value + "") == "" ||
                (editgrid[LABOURITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Labouritems_id = "";
                    obj.Labour_id = vId;

                    if (Customise.InvoiceWithPo == true)
                    {
                        obj.Po_no = editgrid[LABOURITEMS.PO_NO, r].Value + "";
                    }
                    else
                    {
                        obj.Po_no = "0";
                    }

                    if (Customise.InvoiceWithDc == true)
                    {
                        obj.Dc_no = editgrid[LABOURITEMS.DC_NO, r].Value + "";
                    }
                    else
                    {
                        obj.Dc_no = "0";
                    }
                    
                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[LABOURITEMS.PRODUCT_ID, r].Value + ""));

                    if (Customise.InvoiceWithSizes == true)
                    {
                        obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[LABOURITEMS.SIZES_ID, r].Value + "");
                    }
                    else
                    {
                        obj.Sizes_id =  "1";
                    }
                    
                    
                    
                    
                    
                    obj.Qty = (editgrid[LABOURITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[LABOURITEMS.PRICE, r].Value + "");
                    obj.Cgst_percent = ConvertTO.Decimal(editgrid[LABOURITEMS.CGST_PERCENT, r].Value + "");
                    obj.Sgst_percent = ConvertTO.Decimal(editgrid[LABOURITEMS.SGST_PERCENT, r].Value + "");
                    obj.Igst_percent = ConvertTO.Decimal(editgrid[LABOURITEMS.IGST_PERCENT, r].Value + "");
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
            if (txt_invoice_no.Text.Trim().Length == 0)
            {
                MessageBox.Show(this.FindForm(), "Labour no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_invoice_no.Focus();
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
