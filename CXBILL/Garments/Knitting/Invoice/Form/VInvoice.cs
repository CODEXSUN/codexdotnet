// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:14:05 PM 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;

namespace CXKNITTING
{
    public partial class FInvoice : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Knitting_Invoice obj;
        private List<Knitting_Invoiceitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = CInvoice_exten.PKId(pPkValue, new DAL());
                    list = CInvoiceitems_exten.FKId(pPkValue, new DAL());
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
                    obj = CInvoice_exten.PKId(pPkValue, new DAL());
                    list = CInvoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(true);
                    break;
                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = CInvoice_exten.PKId(pPkValue, new DAL());
                    list = CInvoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    break;
                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = CInvoice_exten.PKId(pPkValue, new DAL());
                    list = CInvoiceitems_exten.FKId(pPkValue, new DAL());
                    this.EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Knitting_Invoice obj)
        {
            vId = obj.Knitting_Invoice_id;
            txt_invoice_no.Text = obj.Knitting_Invoice_no.ToString();
            txt_invoice_date.Text = obj.Knitting_Invoice_date;
            txt_party_id.Text = obj.Party_id;
            txt_taxtype_id.Text = obj.Taxtype_id;
            SetTaxtype();
            txt_salestype_id.Text = obj.Salestype_id;
            txt_Jobno.Text = obj.Jobno;
            txt_total_qty.Text = obj.Total_qty.ToString();
            txt_gsttotal.Text = obj.Gsttotal.ToString();
            txt_ledger_id.Text = CLedger_exten.GetName_Id(obj.Ledger_id);
            txt_additional.Text = obj.Additional.ToString();
            txt_grandtotal.Text = obj.Grandtotal.ToString();
            //txt_balance.Text = CInvoice_exten.GetBalance(CParty_exten.GetId_Name(txt_party_id.Text)).ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Knitting_Invoiceitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID].Value = (list[r].Knitting_Invoiceitems_id) + "";
                    row.Cells[KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID].Value = (list[r].Knitting_Invoice_id) + "";
                    //row.Cells[INVOICEITEMS.PO_ID].Value = (list[r].Po_id) + "";
                    //row.Cells[INVOICEITEMS.POITEMS_ID].Value = (list[r].Poitems_id) + ""; 

                    //if (list[r].Dc_id == "0")
                    //{
                    //    row.Cells[INVOICEITEMS.DC_ID].Value = Core.Without_Dc;
                    //    row.Cells[INVOICEITEMS.DCITEMS_ID].Value = "";
                    //}
                    //else
                    //{
                    //    row.Cells[INVOICEITEMS.DC_ID].Value = (list[r].Dc_id) + "";
                    //    row.Cells[INVOICEITEMS.DCITEMS_ID].Value = (list[r].Dcitems_id) + "";
                    //}

                    row.Cells[KNITTING_INVOICEITEMS.PRODUCT_ID].Value = Checks.RemoveEscape((list[r].Product_id) + "");
                    row.Cells[KNITTING_INVOICEITEMS.NOOFROLLS].Value = (list[r].Noofrolls) + "";
                    row.Cells[KNITTING_INVOICEITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[KNITTING_INVOICEITEMS.PRICE].Value = (list[r].Price) + "";
                    row.Cells[KNITTING_INVOICEITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + "";
                    row.Cells[KNITTING_INVOICEITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + "";
                    row.Cells[KNITTING_INVOICEITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + "";
                }
            }
        }

        #endregion[load items] 

        #region[Enable  Disable Controls]

        private void EnableControls(bool pEnabled)
        {
            bool pReadOnly = !pEnabled;

            txt_taxtype_id.Enabled = !pReadOnly;
            txt_salestype_id.Enabled = !pReadOnly;
            txt_Jobno.Enabled = !pReadOnly;
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

        private Knitting_Invoice CollectData()
        {
            Knitting_Invoice fobj = new Knitting_Invoice()
            {
                Knitting_Invoice_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_invoice_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Knitting_Invoice_no = Convert.ToInt32(txt_invoice_no.Text),
                Knitting_Invoice_date = txt_invoice_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Taxtype_id = CTaxtype_exten.GetId_Name(txt_taxtype_id.Text),
                Salestype_id = CSalestype_exten.GetId_Name(txt_salestype_id.Text),
                Jobno = txt_Jobno.Text,
                Total_rolls = vrolls,
                Total_qty = ConvertTO.Decimal(txt_total_qty.Text),
                Total_taxable_amount = vTotTaxable,
                Total_cgst = vTotCgst,
                Total_sgst = vTotSgst,
                Total_igst = vTotIgst,
                Gsttotal = ConvertTO.Decimal(txt_gsttotal.Text),
                Ledger_id = CLedger_exten.GetId_Name(txt_ledger_id.Text),
                Additional = ConvertTO.Decimal(txt_additional.Text),
                Rounds = vRoundoff,
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

        private List<Knitting_Invoiceitems> Collectitems(string vId)
        {

            List<Knitting_Invoiceitems> list = new List<Knitting_Invoiceitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Knitting_Invoiceitems obj = new Knitting_Invoiceitems();

                if (
               (editgrid[KNITTING_INVOICEITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[KNITTING_INVOICEITEMS.QTY, r].Value + "") == "" ||
                (editgrid[KNITTING_INVOICEITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Knitting_Invoiceitems_id = "";
                    obj.Knitting_Invoice_id = vId;
                    obj.Knitting_Invoice_no = txt_invoice_no.Text;
                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[KNITTING_INVOICEITEMS.PRODUCT_ID, r].Value + ""));
                    obj.Noofrolls = (editgrid[KNITTING_INVOICEITEMS.NOOFROLLS, r].Value + "");
                    obj.Qty = (editgrid[KNITTING_INVOICEITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[KNITTING_INVOICEITEMS.PRICE, r].Value + "");
                    obj.Cgst_percent = ConvertTO.Decimal(editgrid[KNITTING_INVOICEITEMS.CGST_PERCENT, r].Value + "");
                    obj.Sgst_percent = ConvertTO.Decimal(editgrid[KNITTING_INVOICEITEMS.SGST_PERCENT, r].Value + "");
                    obj.Igst_percent = ConvertTO.Decimal(editgrid[KNITTING_INVOICEITEMS.IGST_PERCENT, r].Value + "");
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
