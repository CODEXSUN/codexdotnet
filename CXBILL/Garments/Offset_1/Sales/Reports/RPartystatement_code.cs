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
    public partial class ROffset_1_party 
    {
        #region[load option]
        //
        public void Partystatement_ListRefresh()
        {
            list_partystatement(fAction);
        }
        //
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
            Load_statement(RcPartystatement.Statement(Txt_party.Text, txt_from_date.Text, txt_to_date.Text, voucher_type));
        }
        //
        #endregion[load option]
        //
        #region[load]
        //
        public void Load_statement(List<Statement> vlist)
        {

            decimal _Sales_amount = 0M; decimal _receipt = 0M;  decimal _balance = 0M; //decimal _opening = 0M;

            Listgrid.RowCount = 0;
            Listgrid.RowCount = vlist.Count + 1;

            if (vlist.Count != 0)
            {
                Listgrid.Rows[0].Cells[STATEMENT.BALANCE_AMOUNT].Value = 0 + vlist[0].Opening; /// ading opening balance separate
            }

            for (int r = 1; r < vlist.Count + 1; r++)
            {
                DataGridViewRow row = Listgrid.Rows[r];

                row.Cells[STATEMENT.SNO].Value = vlist[r - 1].Sno;
                row.Cells[STATEMENT.VNO].Value = vlist[r - 1].Vno;
                row.Cells[STATEMENT.SDATE].Value = ConvertTO.Date2S(vlist[r - 1].Sdate);
                row.Cells[STATEMENT.STYPE].Value = vlist[r - 1].Stype;
                row.Cells[STATEMENT.PARTY].Value = vlist[r - 1].Party;
                row.Cells[STATEMENT.SALES_AMOUNT].Value = (vlist[r - 1].Sales_amount);
                row.Cells[STATEMENT.RECEIPT_AMOUNT].Value = vlist[r - 1].Receipt_amount;
                row.Cells[STATEMENT.BALANCE_AMOUNT].Value = vlist[r - 1].Balance_amount;

                _Sales_amount +=  vlist[r - 1].Sales_amount;
                _receipt +=  vlist[r - 1].Receipt_amount;
                _balance = (vlist[r - 1].Balance_amount);

            }

            txt_invoice_total.Text = _Sales_amount.ToString();
            txt_receipt_total.Text = _receipt.ToString();
            txt_balance_total.Text = _balance.ToString();
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
        //        _items.no = Listgrid[PARTYSTATEMENT.NO, r].Value + "";

        //        if (Listgrid[PARTYSTATEMENT.DATE, r].Value == null)
        //        {
        //            _items.date = "";
        //        }
        //        else
        //        {
        //            _items.date = ConvertTO.Date2S(Listgrid[PARTYSTATEMENT.DATE, r].Value.ToString());
        //        }


        //        _items.type = (Listgrid[PARTYSTATEMENT.TYPE, r].Value + "");
        //        _items.party = (Listgrid[PARTYSTATEMENT.PARTY, r].Value + "");
        //        _items.invoice_amount = (Listgrid[PARTYSTATEMENT.INVOICE_AMOUNT, r].Value + "");
        //        _items.receipt_amount = (Listgrid[PARTYSTATEMENT.RECEIPT_AMOUNT, r].Value + "");
        //        _items.balance_amount = (Listgrid[PARTYSTATEMENT.BALANCE_AMOUNT, r].Value + "");
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
