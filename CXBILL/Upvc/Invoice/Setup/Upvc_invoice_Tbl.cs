// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 11:04:22 AM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class Upvc_invoice_Tbl
    {
        #region[Create Table]

        public Upvc_invoice_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(UPVC_INVOICE.UPVC_INVOICE_TBL);
            q += Fields.Primary(UPVC_INVOICE.UPVC_INVOICE_ID);
            q += Fields.Unique_500(UPVC_INVOICE.UNIQUENO);
            q += Fields.Foreign(UPVC_INVOICE.UPVC_INVOICE_TBL, UPVC_INVOICE.COMPANY_ID);
            q += Fields.Foreign(UPVC_INVOICE.UPVC_INVOICE_TBL, UPVC_INVOICE.ACY_ID);
            q += Fields.Foreign(UPVC_INVOICE.UPVC_INVOICE_TBL, UPVC_INVOICE.SALESTYPE_ID);
            q += Fields.Foreign(UPVC_INVOICE.UPVC_INVOICE_TBL, UPVC_INVOICE.TAXTYPE_ID); 
            q += Fields.VARCHAR_200(UPVC_INVOICE.INVOICE_NO); 
            q += Fields.Date(UPVC_INVOICE.INVOICE_DATE); 
            q += Fields.Foreign(UPVC_INVOICE.UPVC_INVOICE_TBL, UPVC_INVOICE.PARTY_ID); 
            q += Fields.Int(UPVC_INVOICE.DELIVEREDTO_ID); 
            q += Fields.Foreign(UPVC_INVOICE.UPVC_INVOICE_TBL, UPVC_INVOICE.TRANSPORT_ID); 
            q += Fields.VARCHAR_500(UPVC_INVOICE.VEHICLE_NO); 
            q += Fields.Decimal_3(UPVC_INVOICE.TOTAL_QTY); 
            q += Fields.VARCHAR_200(UPVC_INVOICE.TOTAL_AREASQ); 
            q += Fields.Decimal_2(UPVC_INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal_2(UPVC_INVOICE.TOTAL_CGST); 
            q += Fields.Decimal_2(UPVC_INVOICE.TOTAL_SGST); 
            q += Fields.Decimal_2(UPVC_INVOICE.TOTAL_IGST); 
            q += Fields.Decimal_2(UPVC_INVOICE.GSTTOTAL); 
            q += Fields.VARCHAR_500(UPVC_INVOICE.LEDGER_ID); 
            q += Fields.Decimal_2(UPVC_INVOICE.ADDITIONAL); 
            q += Fields.Decimal_2(UPVC_INVOICE.ROUNDS); 
            q += Fields.Decimal_2(UPVC_INVOICE.GRANDTOTAL); 
            q += Fields.Decimal_2(UPVC_INVOICE.REFERED_NO); 
            q += Fields.Smallint(UPVC_INVOICE.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(UPVC_INVOICE.UPVC_INVOICE_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            Upvc_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Upvc_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL);
            q += Fields.Primary(UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_ID);
            q += Fields.Foreign(UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL, UPVC_INVOICEITEMS.UPVC_INVOICE_ID); 
            q += Fields.Foreign(UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL, UPVC_INVOICEITEMS.PRODUCT_ID); 
            q += Fields.Decimal_3(UPVC_INVOICEITEMS.WIDTHS); 
            q += Fields.Decimal_3(UPVC_INVOICEITEMS.HEIGHTS); 
            q += Fields.Decimal_3(UPVC_INVOICEITEMS.AREASQ); 
            q += Fields.Decimal_3(UPVC_INVOICEITEMS.QTY); 
            q += Fields.Decimal_2(UPVC_INVOICEITEMS.PRICE); 
            q += Fields.Decimal_2(UPVC_INVOICEITEMS.SGST_PERCENT); 
            q += Fields.Decimal_2(UPVC_INVOICEITEMS.CGST_PERCENT); 
            q += Fields.Decimal_2(UPVC_INVOICEITEMS.IGST_PERCENT); 
            q += Fields.VARCHAR_500(UPVC_INVOICEITEMS.REFERED_ID); 
            q += Fields.Smallint(UPVC_INVOICEITEMS.LOCKED); 
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
