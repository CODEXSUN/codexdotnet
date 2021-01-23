// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using CXSETUP; 
using CXLIB; 

namespace CXGARMENT
{
    public class Garment_invoice_Tbl
    {
        #region[Create Table]

        public Garment_invoice_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_INVOICE.GARMENT_INVOICE_TBL);
            q += Fields.Primary(GARMENT_INVOICE.GARMENT_INVOICE_ID);
            q += Fields.Unique_500(GARMENT_INVOICE.UNIQUENO);
            q += Fields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.COMPANY_ID);
            q += Fields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.ACY_ID);
            q += Fields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.GARMENT_ORDER_ID); 
            q += Fields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.SALESTYPE_ID); 
            q += Fields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.TAXTYPE_ID); 
            q += Fields.Int(GARMENT_INVOICE.GARMENT_INVOICE_NO); 
            q += Fields.Date(GARMENT_INVOICE.GARMENT_INVOICE_DATE); 
            q += Fields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.PARTY_ID); 
            q += Fields.Decimal_3(GARMENT_INVOICE.TOTAL_QTY); 
            q += Fields.Decimal_2(GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal_2(GARMENT_INVOICE.TOTAL_CGST); 
            q += Fields.Decimal_2(GARMENT_INVOICE.TOTAL_SGST); 
            q += Fields.Decimal_2(GARMENT_INVOICE.TOTAL_IGST); 
            q += Fields.Decimal_2(GARMENT_INVOICE.GSTTOTAL); 
            q += Fields.VARCHAR_200(GARMENT_INVOICE.LEDGER_ID); 
            q += Fields.Decimal_2(GARMENT_INVOICE.ADDITIONAL); 
            q += Fields.Decimal_2(GARMENT_INVOICE.ROUNDS); 
            q += Fields.Decimal_2(GARMENT_INVOICE.GRANDTOTAL); 
            q += Fields.Decimal_2(GARMENT_INVOICE.REFERED_AMT); 
            q += Fields.Smallint(GARMENT_INVOICE.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(GARMENT_INVOICE.GARMENT_INVOICE_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            Garment_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Garment_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL);
            q += Fields.Primary(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID);
            q += Fields.Foreign(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL, GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID); 
            q += Fields.Int(GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO); 
            q += Fields.Foreign(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL, GARMENT_INVOICEITEMS.PRODUCT_ID); 
            q += Fields.Decimal_3(GARMENT_INVOICEITEMS.QTY); 
            q += Fields.Decimal_2(GARMENT_INVOICEITEMS.PRICE); 
            q += Fields.Decimal_2(GARMENT_INVOICEITEMS.SGST_PERCENT); 
            q += Fields.Decimal_2(GARMENT_INVOICEITEMS.CGST_PERCENT); 
            q += Fields.Decimal_2(GARMENT_INVOICEITEMS.IGST_PERCENT); 
            q += Fields.VARCHAR_200(GARMENT_INVOICEITEMS.REFERED_ID); 
            q += Fields.Smallint(GARMENT_INVOICEITEMS.LOCKED); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
