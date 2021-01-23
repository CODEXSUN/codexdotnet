// Version : 7.6 dt : 30-03-2017
// CODESK
// 24-01-2017 08:01:01 AM
// create date : 24-01-2017
// last update : 30-03-2017

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
//using CXBILL;

namespace CXBILL
{
    public partial class RSalesRegister 
    {
        #region[load option]

        private action fAction = action.showall;
        public void list_partystatement(action pAction)
        {
            fAction = pAction;
            pAction = action.unreceipted;
            string voucher_type = Core.Invoice;
            //
            //switch (fAction)
            //{
            //    case action.invoice:
            //        if (radio_invoice.Checked == true)
            //        {
            //voucher_type = Core.Invoice;
            //        }
            //        break;
            //    //
            //    case action.labour_bill:
            //        if (radio_labourbill.Checked == true)
            //        {
            //            voucher_type = Core.Labour;
            //        }
            //        break;
            //    //
            //    case action.receipt:
            //        if (radio_receipt.Checked == true)
            //        {
            //            voucher_type = Core.Receipt;
            //        }
            //        break;
            //    //
            //    case action.debit_note:
            //        if (radio_debitnote.Checked == true)
            //        {
            //            voucher_type = Core.Debitnote;
            //        }
            //        break;
            //}
            //
            Load_statement(RCSalesRegister.Register(Txt_party.Text, txt_from_date.Text, txt_to_date.Text));
        }
        //
        #endregion[load option]
        //
        #region[load]
        //
        public void Load_statement(List<Salesregister> vlist)
        {

            decimal _Sales_amount = 0M; decimal _Gst_amount = 0M; 

            Listgrid.RowCount = 0;
            Listgrid.RowCount = vlist.Count;

            for (int r = 0; r < vlist.Count; r++)
            {
                DataGridViewRow row = Listgrid.Rows[r];

                row.Cells[SALESREGISTER.SDATE].Value = ConvertTO.Date2S(vlist[r].Sdate);
                row.Cells[SALESREGISTER.PARTYNAME].Value = vlist[r].Partyname;
                row.Cells[SALESREGISTER.VNO].Value = vlist[r].Vno;
                row.Cells[SALESREGISTER.STYPE].Value = vlist[r].Stype;
                row.Cells[SALESREGISTER.SALES_AMOUNT].Value = (vlist[r].Sales_amount);
                row.Cells[SALESREGISTER.GST_AMOUNT].Value = vlist[r].Gst_amount;

                _Sales_amount +=  vlist[r].Sales_amount;
                _Gst_amount +=  vlist[r].Gst_amount;

            }

            txt_invoice_total.Text = _Sales_amount.ToString();
            txt_GST_total.Text = _Gst_amount.ToString();
        }
        //
        #endregion[load]
        //
        #region[Search event]
        //
        //private void Search_no_TextChanged(object sender, EventArgs e)
        //{
        //    list_partystatement(action.No);
        //    Listgrid.Focus();
        //    Txt_invoicedate.Text = "";
        //    Txt_party.Text = "";
        //}
        ////
        //private void Search_date_TextChanged(object sender, EventArgs e)
        //{
        //    list_partystatement(action.Date);
        //    Listgrid.Focus();
        //    Txt_invoiceno.Text = "";
        //    Txt_party.Text = "";
        //}
        //
        private void Search_party_TextChanged(object sender, EventArgs e)
        {
            list_partystatement(action.Party);
            Listgrid.Focus();
            //Txt_invoiceno.Text = "";
            //Txt_invoicedate.Text = "";
        }
        //
        #endregion[Search event]
        //
        #region[Search Lookup]
        ////
        //#region[NO]

        //public void No_lookup()
        //{
        //    Txt_invoiceno.LookupColNames = new string[] { INVOICE.INVOICE_NO };
        //    Txt_invoiceno.LookupUpdate += No_LookupUpdate;
        //}
        //void No_LookupUpdate(object sender, EventArgs e)
        //{
        //    DataTable xlist = cInvoice_exten.Lookup;
        //    Txt_invoiceno.LookupList = xlist;
        //}
        //#endregion[NO]
        ////
        //#region[Date]

        //public void Date_lookup()
        //{
        //    Txt_invoicedate.LookupColNames = new string[] { INVOICE.INVOICE_DATE };
        //    Txt_invoicedate.LookupUpdate += Date_LookupUpdate;
        //}
        //void Date_LookupUpdate(object sender, EventArgs e)
        //{
        //    DataTable xlist = cInvoice_exten.LookupDate;
        //    Txt_invoicedate.LookupList = xlist;
        //}
        //#endregion[Date]
        ////
        #region[Party]

        public void Party_lookup()
        {
            Txt_party.LookupColNames = new string[] { PARTY.PARTY_NAME };
            Txt_party.LookupUpdate += Party_LookupUpdate;
        }
        void Party_LookupUpdate(object sender, EventArgs e)
        {
            Txt_party.LookupList = CParty_exten.GetforLookup(new DAL());

        }
        #endregion[Party]
        //
        #endregion[Search Lookup]
        //
        //#region[Fetch statement]
        ////
        //private List<partystatement> Fetchstatement()
        //{
        //    List<partystatement> _list = new List<partystatement>();

        //    for (int r = 0; r < Listgrid.RowCount; r++)
        //    {
        //        partystatement _items = new partystatement();
        //        //
        //        _items.no = Listgrid[PARTYSALESREGISTER.NO, r].Value + "";

        //        if (Listgrid[PARTYSALESREGISTER.DATE, r].Value == null)
        //        {
        //            _items.date = "";
        //        }
        //        else
        //        {
        //            _items.date = ConvertTO.Date2S(Listgrid[PARTYSALESREGISTER.DATE, r].Value.ToString());
        //        }


        //        _items.type = (Listgrid[PARTYSALESREGISTER.TYPE, r].Value + "");
        //        _items.party = (Listgrid[PARTYSALESREGISTER.PARTY, r].Value + "");
        //        _items.invoice_amount = (Listgrid[PARTYSALESREGISTER.INVOICE_AMOUNT, r].Value + "");
        //        _items.receipt_amount = (Listgrid[PARTYSALESREGISTER.RECEIPT_AMOUNT, r].Value + "");
        //        _items.balance_amount = (Listgrid[PARTYSALESREGISTER.BALANCE_AMOUNT, r].Value + "");
        //        _list.Add(_items);
        //    }
        //    if (_list.Count != 0)
        //    {
        //        return _list;
        //    }
        //    return null;
        //}
        ////
        //#endregion[Fetch statement]

    }//cls 
}//ns 
