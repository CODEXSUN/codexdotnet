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
    public partial class FOffset_Invoice : UserControl
    {
        #region[Action]

        private BtnEvent fAction = BtnEvent.Open;
        private Offset_invoice obj;
        private List<Offset_invoiceitems> list;
        private string vId;

        public void SetAction(BtnEvent pAction, string pPkValue)
        {
            fAction = pAction;

            switch (fAction)
            {
                case BtnEvent.Open:
                    btn_save.Text = "&CLOSE";
                    obj = COffset_invoice_exten.PKId(pPkValue, new DAL());
                    list = COffset_invoiceitems_exten.FKId(pPkValue, new DAL());
                    EnableControls(false);
                    break;

                case BtnEvent.New:
                    btn_save.Text = "&SAVE";
                    obj = COffset_invoice.GetNew;
                    list = COffset_invoiceitems.GetNew;
                    EnableControls(true);
                    break;

                case BtnEvent.Edit:
                    btn_save.Text = "&UPDATE";
                    obj = COffset_invoice_exten.PKId(pPkValue, new DAL());
                    list = COffset_invoiceitems_exten.FKId(pPkValue, new DAL());
                    EnableControls(true);
                    break;

                case BtnEvent.Delete:
                    btn_save.Text = "CONFIRM\r\n&DELETE";
                    obj = COffset_invoice_exten.PKId(pPkValue, new DAL());
                    list = COffset_invoiceitems_exten.FKId(pPkValue, new DAL());
                    EnableControls(false);
                    break;

                case BtnEvent.Print:
                    btn_save.Text = "&PRINT";
                    obj = COffset_invoice_exten.PKId(pPkValue, new DAL());
                    list = COffset_invoiceitems_exten.FKId(pPkValue, new DAL());
                    EnableControls(false);
                    print_panel.Show();
                    break;
            }

            LoadData(obj);
            Loaditems(list);
        }

        #endregion[Action]

        #region[Load Data]

        private void LoadData(Offset_invoice obj)
        {
            vId = obj.Offset_invoice_id;
            txt_invoice_no.Text = obj.Offset_invoice_no.ToString();
            txt_invoice_date.Text = obj.Offset_invoice_date;
            txt_party_id.Text = obj.Party_id;
            txt_taxtype_id.Text = obj.Taxtype_id;
            SetTaxtype();
            txt_salestype_id.Text = obj.Salestype_id;
            txt_total_qty.Text = obj.Total_qty.ToString();
            //txt_total_taxable_amount.Text = obj.Total_taxable_amount;
            txt_gsttotal.Text = obj.Gsttotal.ToString();
            txt_ledger_id.Text = CLedger_exten.GetName_Id(obj.Ledger_id);
            txt_additional.Text = obj.Additional.ToString();
            txt_grandtotal.Text = obj.Grandtotal.ToString();
            txt_balance.Text = COffset_invoice_exten.GetBalance(CParty_exten.GetId_Name(txt_party_id.Text)).ToString();
            txt_notes.Text = obj.Notes;
            Core.Stative = obj.Active_id;
            Setactives();
        }

        #endregion[Load Data]

        #region[load items] 

        public void Loaditems(List<Offset_invoiceitems> list)
        {
            editgrid.RowCount = 0;
            if (list != null)
            {
                editgrid.RowCount = list.Count;
                for (int r = 0; r < list.Count; r++)
                {
                    DataGridViewRow row = editgrid.Rows[r];

                    row.Cells[OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID].Value = (list[r].Offset_invoiceitems_id) + "";
                    row.Cells[OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID].Value = (list[r].Offset_invoice_id) + "";
                    row.Cells[OFFSET_INVOICEITEMS.OFFSET_PO_ID].Value = (list[r].Offset_po_id) + "";
                    row.Cells[OFFSET_INVOICEITEMS.OFFSET_POITEMS_ID].Value = (list[r].Offset_poitems_id) + "";

                    if (list[r].Offset_dc_id == "0")
                    {
                        row.Cells[OFFSET_INVOICEITEMS.OFFSET_DC_ID].Value = Core.Without_Dc;
                        row.Cells[OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID].Value = "";
                    }
                    else
                    {
                        row.Cells[OFFSET_INVOICEITEMS.OFFSET_DC_ID].Value = (list[r].Offset_dc_id) + "";
                        row.Cells[OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID].Value = (list[r].Offset_dcitems_id) + "";
                    }

                    row.Cells[OFFSET_INVOICEITEMS.PRODUCT_ID].Value = Checks.RemoveEscape((list[r].Product_id) + "");
                    row.Cells[OFFSET_INVOICEITEMS.QTY].Value = (list[r].Qty) + "";
                    row.Cells[OFFSET_INVOICEITEMS.PRICE].Value = (list[r].Price) + "";
                    row.Cells[OFFSET_INVOICEITEMS.CGST_PERCENT].Value = (list[r].Cgst_percent) + "";
                    row.Cells[OFFSET_INVOICEITEMS.SGST_PERCENT].Value = (list[r].Sgst_percent) + "";
                    row.Cells[OFFSET_INVOICEITEMS.IGST_PERCENT].Value = (list[r].Igst_percent) + "";
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
                            COffset_invoice.Insert(vData, dalsession);
                            vId = DAL.GetIdentity(dalsession);
                            var itemsList = Collectitems(vId);
                            COffset_invoiceitems.Insert(itemsList, dalsession);

                            COffset_dc_refered.Refered(itemsList, itemsList, dalsession);

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

                            var olditemslist = COffset_invoiceitems_exten.FK_withoutJoin(vId, new DAL());

                            COffset_invoiceitems.Delete(vId, dalsession);
                            COffset_invoice.Update(vData, dalsession);
                            var itemsList = Collectitems(vId);
                            COffset_invoiceitems.Insert(itemsList, dalsession);

                            COffset_dc_refered.Refered(itemsList, olditemslist, dalsession);

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
                            COffset_invoiceitems.Delete(vId, dalsession);
                            COffset_invoice.Delete(vId, dalsession);
                            var olditemslist = COffset_invoiceitems_exten.FK_withoutJoin(vId, new DAL());

                            COffset_dc_refered.Refered(olditemslist, olditemslist, dalsession);

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

        private Offset_invoice CollectData()
        {
            Offset_invoice fobj = new Offset_invoice()
            {
                Offset_invoice_id = vId,
                Uniqueno = Current.Acy_id + "~" + Current.Company_id + "~" + txt_invoice_no.Text,
                Company_id = Current.Company_id,
                Acy_id = Current.Acy_id,
                Offset_invoice_no = Convert.ToInt32(txt_invoice_no.Text),
                Offset_invoice_date = txt_invoice_date.Text,
                Party_id = CParty_exten.GetId_Name(txt_party_id.Text),
                Taxtype_id = CTaxtype_exten.GetId_Name(txt_taxtype_id.Text),
                Salestype_id = CSalestype_exten.GetId_Name(txt_salestype_id.Text),
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

        private List<Offset_invoiceitems> Collectitems(string vId)
        {

            List<Offset_invoiceitems> list = new List<Offset_invoiceitems>();

            for (int r = 0; r < editgrid.RowCount; r++)
            {

                Offset_invoiceitems obj = new Offset_invoiceitems();

                if (
               (editgrid[OFFSET_INVOICEITEMS.PRODUCT_ID, r].Value + "") == "" ||
                (editgrid[OFFSET_INVOICEITEMS.QTY, r].Value + "") == "" ||
                (editgrid[OFFSET_INVOICEITEMS.PRICE, r].Value + "") == ""
                )
                {
                    //==LEAVE IT(the empty row).  
                }
                else
                {
                    obj.Offset_invoiceitems_id = "";
                    obj.Offset_invoice_id = vId;
                    obj.Offset_invoice_no = txt_invoice_no.Text;


                    if (((editgrid[OFFSET_INVOICEITEMS.OFFSET_PO_ID, r].Value + "") == "") || ((editgrid[OFFSET_INVOICEITEMS.OFFSET_PO_ID, r].Value + "") == Core.Without_Po) || ((editgrid[OFFSET_INVOICEITEMS.OFFSET_PO_ID, r].Value + "") == Core._Without_po_))
                    {
                        obj.Offset_po_id = "1";
                        obj.Offset_poitems_id = "1";
                    }
                    else
                    {
                        obj.Offset_po_id = COffset_po_exten.GetId_Name(editgrid[OFFSET_INVOICEITEMS.OFFSET_PO_ID, r].Value + "");
                        obj.Offset_poitems_id = editgrid[OFFSET_INVOICEITEMS.OFFSET_POITEMS_ID, r].Value + "";
                    }


                    if (((editgrid[OFFSET_INVOICEITEMS.OFFSET_DC_ID, r].Value + "") == "") || ((editgrid[OFFSET_INVOICEITEMS.OFFSET_DC_ID, r].Value + "") == Core.Without_Dc) || ((editgrid[OFFSET_INVOICEITEMS.OFFSET_DC_ID, r].Value + "") == "0"))
                    {
                        obj.Offset_dc_id = "1";
                        obj.Offset_dcitems_id = "1";
                    }
                    else
                    {
                        obj.Offset_dc_id = COffset_dc_exten.GetId_Name(editgrid[OFFSET_INVOICEITEMS.OFFSET_DC_ID, r].Value + "");
                        obj.Offset_dcitems_id = (editgrid[OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID, r].Value + "");
                        if (obj.Offset_dcitems_id == "") { obj.Offset_dcitems_id = "1"; }
                    }

                    obj.Product_id = CProduct_exten.GetId_Name(Checks.Escape(editgrid[OFFSET_INVOICEITEMS.PRODUCT_ID, r].Value + ""));
                    obj.Qty = (editgrid[OFFSET_INVOICEITEMS.QTY, r].Value + "");
                    obj.Price = ConvertTO.Decimal(editgrid[OFFSET_INVOICEITEMS.PRICE, r].Value + "");
                    obj.Cgst_percent = ConvertTO.Decimal(editgrid[OFFSET_INVOICEITEMS.CGST_PERCENT, r].Value + "");
                    obj.Sgst_percent = ConvertTO.Decimal(editgrid[OFFSET_INVOICEITEMS.SGST_PERCENT, r].Value + "");
                    obj.Igst_percent = ConvertTO.Decimal(editgrid[OFFSET_INVOICEITEMS.IGST_PERCENT, r].Value + "");
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
