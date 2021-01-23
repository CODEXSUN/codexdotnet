// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using CXLIB;
using INVOICE = CXBILL_EXTEN.Invoice.Const.INVOICE;
using INVOICEITEMS = CXBILL_EXTEN.Invoice.Const.INVOICEITEMS;

namespace CXBILL_EXTEN
{
    public class Invoice_Tbl
    {
        #region[Create Table]

        public Invoice_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(INVOICE.INVOICE_TBL);
            q += AddFields.Primary(INVOICE.INVOICE_ID);
            q += AddFields.Unique_500(INVOICE.UNIQUENO);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.COMPANY_ID);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.ACY_ID);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.ORDER_ID);
            q += AddFields.Int(INVOICE.INVOICE_NO); 
            q += AddFields.Date(INVOICE.INVOICE_DATE); 
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.PARTY_ID);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.TAXTYPE_ID);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.SALESTYPE_ID);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.TRANSPORT_ID);
            q += AddFields.Foreign(INVOICE.INVOICE_TBL, INVOICE.DELIVEREDTO_ID);
            q += AddFields.VARCHAR_500(INVOICE.BUNDEL);
            q += AddFields.VARCHAR_100(INVOICE.TOTAL_QTY); 
            q += AddFields.Decimal_2(INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += AddFields.Decimal_2(INVOICE.TOTAL_CGST); 
            q += AddFields.Decimal_2(INVOICE.TOTAL_SGST); 
            q += AddFields.Decimal_2(INVOICE.TOTAL_IGST); 
            q += AddFields.Decimal_2(INVOICE.GSTTOTAL); 
            q += AddFields.VARCHAR_200(INVOICE.LEDGER_ID); 
            q += AddFields.Decimal_2(INVOICE.ADDITIONAL); 
            q += AddFields.Decimal_2(INVOICE.ROUNDS); 
            q += AddFields.Decimal_2(INVOICE.GRANDTOTAL); 
            q += AddFields.Decimal_2(INVOICE.REFERED_AMT); 
            q += AddFields.Smallint(INVOICE.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(INVOICE.INVOICE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            Tex_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Tex_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(INVOICEITEMS.INVOICEITEMS_TBL);
            q += AddFields.Primary(INVOICEITEMS.INVOICEITEMS_ID);
            q += AddFields.Foreign(INVOICEITEMS.INVOICEITEMS_TBL, INVOICEITEMS.INVOICE_ID); 
            q += AddFields.VARCHAR_100(INVOICEITEMS.PO_NO); 
            q += AddFields.VARCHAR_100(INVOICEITEMS.DC_NO); 
            q += AddFields.Foreign(INVOICEITEMS.INVOICEITEMS_TBL, INVOICEITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(INVOICEITEMS.INVOICEITEMS_TBL, INVOICEITEMS.SIZES_ID); 
            q += AddFields.VARCHAR_100(INVOICEITEMS.QTY); 
            q += AddFields.Decimal_2(INVOICEITEMS.PRICE);
            q += AddFields.Decimal_2(INVOICEITEMS.CGST_PERCENT);
            q += AddFields.Decimal_2(INVOICEITEMS.SGST_PERCENT); 
            q += AddFields.Decimal_2(INVOICEITEMS.IGST_PERCENT); 
            q += AddFields.VARCHAR_200(INVOICEITEMS.REFERED_ID); 
            q += AddFields.Smallint(INVOICEITEMS.LOCKED); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

        #region[Default Values]

        public static void InsertDefault_Seq(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(INVOICE.INVOICE_TBL);
            q += DB.FIELD_1ST(INVOICE.INVOICE_ID);
            q += DB.FIELD(INVOICE.UNIQUENO);
            q += DB.FIELD(INVOICE.COMPANY_ID);
            q += DB.FIELD(INVOICE.ACY_ID);
            q += DB.FIELD(INVOICE.ORDER_ID);
            q += DB.FIELD(INVOICE.INVOICE_NO);
            q += DB.FIELD(INVOICE.INVOICE_DATE);
            q += DB.FIELD(INVOICE.PARTY_ID);
            q += DB.FIELD(INVOICE.TAXTYPE_ID);
            q += DB.FIELD(INVOICE.SALESTYPE_ID);
            q += DB.FIELD(INVOICE.TRANSPORT_ID);
            q += DB.FIELD(INVOICE.DELIVEREDTO_ID);
            q += DB.FIELD(INVOICE.BUNDEL);
            q += DB.FIELD(INVOICE.TOTAL_QTY);
            q += DB.FIELD(INVOICE.TOTAL_TAXABLE_AMOUNT);
            q += DB.FIELD(INVOICE.TOTAL_CGST);
            q += DB.FIELD(INVOICE.TOTAL_SGST);
            q += DB.FIELD(INVOICE.TOTAL_IGST);
            q += DB.FIELD(INVOICE.GSTTOTAL);
            q += DB.FIELD(INVOICE.LEDGER_ID);
            q += DB.FIELD(INVOICE.ADDITIONAL);
            q += DB.FIELD(INVOICE.ROUNDS);
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("0");
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
