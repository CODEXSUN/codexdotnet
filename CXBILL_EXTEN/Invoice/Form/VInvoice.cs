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
using CInvoice = CXBILL_EXTEN.Invoice.Class.CInvoice;
using CInvoice_exten = CXBILL_EXTEN.Invoice.Class.CInvoice_exten;
using CInvoiceitems = CXBILL_EXTEN.Invoice.Class.CInvoiceitems;
using CInvoiceitems_exten = CXBILL_EXTEN.Invoice.Class.CInvoiceitems_exten;
using Invoiceitems = CXBILL_EXTEN.Invoice.Const.Invoiceitems;
using INVOICEITEMS = CXBILL_EXTEN.Invoice.Const.INVOICEITEMS;

namespace CXBILL_EXTEN.Invoice.Form
{
    public partial class FInvoice
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Const.Invoice obj;
        private List<Invoiceitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CInvoice_exten.PKId(pPkValue);
                    list = CInvoiceitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = CInvoice.GetNew;
                    list = CInvoiceitems.GetNew;
                    this.EnableControls(true);
                    break;
                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = CInvoice_exten.PKId(pPkValue);
                    list = CInvoiceitems_exten.FKId(pPkValue);
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CInvoice_exten.PKId(pPkValue);
                    list = CInvoiceitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CInvoice_exten.PKId(pPkValue);
                    list = CInvoiceitems_exten.FKId(pPkValue);
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Const.Invoice obj)
        {
            vId = obj.Invoice_id;
            txt_order_id.Text = obj.Order_id;
            txt_invoice_no.Text = obj.Invoice_no.ToString();
            txt_invoice_date.Text = obj.Invoice_date;
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
            txt_balance.Text = CInvoice_exten.GetBalance(CParty_exten.GetId_Name(txt_party_id.Text)).ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Invoiceitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[INVOICEITEMS.INVOICEITEMS_ID].Value = (list[r].Invoiceitems_id) + "";
                    row.Cells[INVOICEITEMS.INVOICE_ID].Value = (list[r].Invoice_id) + "";
                    row.Cells[INVOICEITEMS.PO_NO].Value = (list[r].Po_no) + "";
                    row.Cells[INVOICEITEMS.DC_NO].Value = (list[r].Dc_no) + ""; 
                    row.Cells[INVOICEITEMS.PRODUCT_ID].Value = Checks.RemoveEscape((list[r].Product_id) + "");
                    row.Cells[INVOICEITEMS.SIZES_ID].Value = (list[r].Sizes_id) + "";
                    row.Cells[INVOICEITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[INVOICEITEMS.PRICE].Value = (list[r].Price) + "";
                    row.Cells[INVOICEITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + "";
                    row.Cells[INVOICEITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + "";
                    row.Cells[INVOICEITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + "";
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
                            CInvoice.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            CInvoiceitems.Insert(itemsList, dalsession);

                            //if (Customise.Invoice_poid_dcid == true)
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

                            var olditemslist = CInvoiceitems_exten.FK_withoutJoin(vId, new DAL());

                            CInvoiceitems.Delete(vId, dalsession);
                            CInvoice.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            CInvoiceitems.Insert(itemsList, dalsession);


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
                            CInvoiceitems.Delete(vId, dalsession);
                            CInvoice.Delete(vId, dalsession);
                            var olditemslist = CInvoiceitems_exten.FK_withoutJoin(vId, new DAL());

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

        private Const.Invoice CollectData()
        {
            Const.Invoice fobj = new Const.Invoice()
            {
                Invoice_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_invoice_no.Text,
                Company_id = Current.Company_id,
                //Div_id = Current.Div_id,
                Acy_id = Current.Acy_id,
                Order_id = COrder_exten.GetId_Name(txt_order_id.Text,"","",""),
                Invoice_no = txt_invoice_no.Text,
                Invoice_date = txt_invoice_date.Text,
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

        private List<Invoiceitems> Collectitems(string vId)
        {

            List<Invoiceitems> list = new List<Invoiceitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Invoiceitems obj = new Invoiceitems();

                if (
               (editgrid[INVOICEITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[INVOICEITEMS.QTY, r].Value + "") == "" ||
                (editgrid[INVOICEITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Invoiceitems_id = "";
                    obj.Invoice_id = vId;

                    if (Customise.InvoiceWithPo == true)
                    {
                        obj.Po_no = Checks.Escape(editgrid[INVOICEITEMS.PO_NO, r].Value + "");
                    }
                    else
                    {
                        obj.Po_no = "0";
                    }

                    if (Customise.InvoiceWithDc == true)
                    {
                        obj.Dc_no = Checks.Escape(editgrid[INVOICEITEMS.DC_NO, r].Value + "");
                    }
                    else
                    {
                        obj.Dc_no = "0";
                    }
                    
                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[INVOICEITEMS.PRODUCT_ID, r].Value + ""));

                    if (Customise.InvoiceWithSizes == true)
                    {
                        obj.Sizes_id = CSizes_exten.GetId_Name(editgrid[INVOICEITEMS.SIZES_ID, r].Value + "");
                    }
                    else
                    {
                        obj.Sizes_id =  "1";
                    }
                    
                    
                    
                    
                    
                    obj.Qty = (editgrid[INVOICEITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[INVOICEITEMS.PRICE, r].Value + "");
                    obj.Cgst_percent = ConvertTO.Decimal(editgrid[INVOICEITEMS.CGST_PERCENT, r].Value + "");
                    obj.Sgst_percent = ConvertTO.Decimal(editgrid[INVOICEITEMS.SGST_PERCENT, r].Value + "");
                    obj.Igst_percent = ConvertTO.Decimal(editgrid[INVOICEITEMS.IGST_PERCENT, r].Value + "");
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
                MessageBox.Show(this.FindForm(), "Invoice no should not Empty ! ", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
