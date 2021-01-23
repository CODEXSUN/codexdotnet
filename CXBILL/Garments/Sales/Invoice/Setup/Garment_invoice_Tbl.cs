// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class Garment_invoice_Tbl
    {
        #region[Create Table]

        public Garment_invoice_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_INVOICE.GARMENT_INVOICE_TBL);
            q += AddFields.Primary(GARMENT_INVOICE.GARMENT_INVOICE_ID);
            q += AddFields.Unique_500(GARMENT_INVOICE.UNIQUENO);
            q += AddFields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.COMPANY_ID);
            q += AddFields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.ACY_ID);
            q += AddFields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.ORDER_ID); 
            q += AddFields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.SALESTYPE_ID); 
            q += AddFields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.TAXTYPE_ID); 
            q += AddFields.Int(GARMENT_INVOICE.GARMENT_INVOICE_NO); 
            q += AddFields.Date(GARMENT_INVOICE.GARMENT_INVOICE_DATE); 
            q += AddFields.Foreign(GARMENT_INVOICE.GARMENT_INVOICE_TBL, GARMENT_INVOICE.PARTY_ID); 
            q += AddFields.Decimal_3(GARMENT_INVOICE.TOTAL_QTY); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.TOTAL_CGST); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.TOTAL_SGST); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.TOTAL_IGST); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.GSTTOTAL); 
            q += AddFields.VARCHAR_200(GARMENT_INVOICE.LEDGER_ID); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.ADDITIONAL); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.ROUNDS); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.GRANDTOTAL); 
            q += AddFields.Decimal_2(GARMENT_INVOICE.REFERED_AMT); 
            q += AddFields.Smallint(GARMENT_INVOICE.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(GARMENT_INVOICE.GARMENT_INVOICE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            Garment_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Garment_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL);
            q += AddFields.Primary(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID);
            q += AddFields.Foreign(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL, GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID); 
            q += AddFields.Int(GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO); 
            q += AddFields.Foreign(GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL, GARMENT_INVOICEITEMS.PRODUCT_ID); 
            q += AddFields.Decimal_3(GARMENT_INVOICEITEMS.QTY); 
            q += AddFields.Decimal_2(GARMENT_INVOICEITEMS.PRICE); 
            q += AddFields.Decimal_2(GARMENT_INVOICEITEMS.SGST_PERCENT); 
            q += AddFields.Decimal_2(GARMENT_INVOICEITEMS.CGST_PERCENT); 
            q += AddFields.Decimal_2(GARMENT_INVOICEITEMS.IGST_PERCENT); 
            q += AddFields.VARCHAR_200(GARMENT_INVOICEITEMS.REFERED_ID); 
            q += AddFields.Smallint(GARMENT_INVOICEITEMS.LOCKED); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
