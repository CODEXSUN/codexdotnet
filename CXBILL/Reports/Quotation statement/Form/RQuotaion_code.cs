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
    public partial class ReportQuotationStatement
    {
        #region[load option]

        public void List_partystatement()
        {
            string voucher_type = Core.Quotation;

            Load_statement(CReportQuotationStatement.Statement(Txt_party.Text, txt_from_date.Text, txt_to_date.Text, voucher_type));
        }
        //
        #endregion[load option]
        //
        #region[load]
        //
        public void Load_statement(List<ReportQuotaionStatement> vlist)
        {

            decimal _Sales_amount = 0M; decimal _receipt = 0M;  decimal _balance = 0M; //decimal _opening = 0M;

            Listgrid.RowCount = 0;
            Listgrid.RowCount = vlist.Count + 1;

            if (vlist.Count != 0)
            {
                Listgrid.Rows[0].Cells[REPORTQUOTATIONSTATEMENT.BALANCE_AMOUNT].Value = 0 + vlist[0].Opening; /// ading opening balance separate
            }

            for (int r = 1; r < vlist.Count + 1; r++)
            {
                DataGridViewRow row = Listgrid.Rows[r];

                row.Cells[REPORTQUOTATIONSTATEMENT.SNO].Value = vlist[r - 1].Sno;
                row.Cells[REPORTQUOTATIONSTATEMENT.VNO].Value = vlist[r - 1].Vno;
                row.Cells[REPORTQUOTATIONSTATEMENT.SDATE].Value = ConvertTO.Date2S(vlist[r - 1].Sdate);
                row.Cells[REPORTQUOTATIONSTATEMENT.STYPE].Value = vlist[r - 1].Stype;
                row.Cells[REPORTQUOTATIONSTATEMENT.PARTY].Value = vlist[r - 1].Party;
                row.Cells[REPORTQUOTATIONSTATEMENT.QUOTATION_AMOUNT].Value = (vlist[r - 1].Quotaion_amount);
                row.Cells[REPORTQUOTATIONSTATEMENT.QRECEIPT_AMOUNT].Value = vlist[r - 1].Qreceipt_amount;
                row.Cells[REPORTQUOTATIONSTATEMENT.BALANCE_AMOUNT].Value = vlist[r - 1].Balance_amount;

                _Sales_amount +=  vlist[r - 1].Quotaion_amount;
                _receipt +=  vlist[r - 1].Qreceipt_amount;
                _balance = (vlist[r - 1].Balance_amount);

            }

            txt_invoice_total.Text = _Sales_amount.ToString();
            txt_receipt_total.Text = _receipt.ToString();
            txt_balance_total.Text = _balance.ToString();
        }
        
        #endregion[load]
        
        #region[Search event]

        private void Search_party_TextChanged(object sender, EventArgs e)
        {
            List_partystatement();
            Listgrid.Focus();
        }
        //
        #endregion[Search event]
        
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
               
    }//cls 
}//ns 
