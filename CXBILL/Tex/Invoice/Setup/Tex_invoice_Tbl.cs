// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using CXLIB; 

namespace CXBILL
{
    public class Tex_invoice_Tbl
    {
        #region[Create Table]

        public Tex_invoice_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(TEX_INVOICE.TEX_INVOICE_TBL);
            q += AddFields.Primary(TEX_INVOICE.TEX_INVOICE_ID);
            q += AddFields.Unique_500(TEX_INVOICE.UNIQUENO);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.COMPANY_ID);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.ACY_ID);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.ORDER_ID);
            q += AddFields.Int(TEX_INVOICE.INVOICE_NO); 
            q += AddFields.Date(TEX_INVOICE.INVOICE_DATE); 
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.PARTY_ID);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.TAXTYPE_ID);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.SALESTYPE_ID);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.TRANSPORT_ID);
            q += AddFields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.DELIVEREDTO_ID);
            q += AddFields.VARCHAR_500(TEX_INVOICE.BUNDEL);
            q += AddFields.Decimal_3(TEX_INVOICE.TOTAL_QTY); 
            q += AddFields.Decimal_2(TEX_INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += AddFields.Decimal_2(TEX_INVOICE.TOTAL_CGST); 
            q += AddFields.Decimal_2(TEX_INVOICE.TOTAL_SGST); 
            q += AddFields.Decimal_2(TEX_INVOICE.TOTAL_IGST); 
            q += AddFields.Decimal_2(TEX_INVOICE.GSTTOTAL); 
            q += AddFields.VARCHAR_200(TEX_INVOICE.LEDGER_ID); 
            q += AddFields.Decimal_2(TEX_INVOICE.ADDITIONAL); 
            q += AddFields.Decimal_2(TEX_INVOICE.ROUNDS); 
            q += AddFields.Decimal_2(TEX_INVOICE.GRANDTOTAL); 
            q += AddFields.Decimal_2(TEX_INVOICE.REFERED_AMT); 
            q += AddFields.Smallint(TEX_INVOICE.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(TEX_INVOICE.TEX_INVOICE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            Tex_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Tex_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL);
            q += AddFields.Primary(TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID);
            q += AddFields.Foreign(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL, TEX_INVOICEITEMS.TEX_INVOICE_ID); 
            //q += Fields.Int(TEX_INVOICEITEMS.INVOICE_NO); 
            q += AddFields.Foreign(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL, TEX_INVOICEITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL, TEX_INVOICEITEMS.SIZES_ID); 
            q += AddFields.Decimal_3(TEX_INVOICEITEMS.QTY); 
            q += AddFields.Decimal_2(TEX_INVOICEITEMS.PRICE);
            q += AddFields.Decimal_2(TEX_INVOICEITEMS.CGST_PERCENT);
            q += AddFields.Decimal_2(TEX_INVOICEITEMS.SGST_PERCENT); 
            q += AddFields.Decimal_2(TEX_INVOICEITEMS.IGST_PERCENT); 
            q += AddFields.VARCHAR_200(TEX_INVOICEITEMS.REFERED_ID); 
            q += AddFields.Smallint(TEX_INVOICEITEMS.LOCKED); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]



        #region[Default Values]

        public static void InsertDefault_Seq(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(TEX_INVOICE.TEX_INVOICE_TBL);
            q += DB.FIELD_1ST(TEX_INVOICE.TEX_INVOICE_ID);
            q += DB.FIELD(TEX_INVOICE.UNIQUENO);
            q += DB.FIELD(TEX_INVOICE.COMPANY_ID);
            q += DB.FIELD(TEX_INVOICE.ACY_ID);
            q += DB.FIELD(TEX_INVOICE.ORDER_ID);
            q += DB.FIELD(TEX_INVOICE.INVOICE_NO);
            q += DB.FIELD(TEX_INVOICE.INVOICE_DATE);
            q += DB.FIELD(TEX_INVOICE.PARTY_ID);
            q += DB.FIELD(TEX_INVOICE.TAXTYPE_ID);
            q += DB.FIELD(TEX_INVOICE.SALESTYPE_ID);
            q += DB.FIELD(TEX_INVOICE.TRANSPORT_ID);
            q += DB.FIELD(TEX_INVOICE.DELIVEREDTO_ID);
            q += DB.FIELD(TEX_INVOICE.BUNDEL);
            q += DB.FIELD(TEX_INVOICE.TOTAL_QTY);
            q += DB.FIELD(TEX_INVOICE.TOTAL_TAXABLE_AMOUNT);
            q += DB.FIELD(TEX_INVOICE.TOTAL_CGST);
            q += DB.FIELD(TEX_INVOICE.TOTAL_SGST);
            q += DB.FIELD(TEX_INVOICE.TOTAL_IGST);
            q += DB.FIELD(TEX_INVOICE.GSTTOTAL);
            q += DB.FIELD(TEX_INVOICE.LEDGER_ID);
            q += DB.FIELD(TEX_INVOICE.ADDITIONAL);
            q += DB.FIELD(TEX_INVOICE.ROUNDS);
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("0");
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]
    }//cls
}//ns
