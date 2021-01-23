// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:20 AM

using CXLIB;
using CXOFFSET_1;

namespace CXSETUP
{
    public class Offset_1_invoice_Tbl
    {
        #region[Create Table]

        public Offset_1_invoice_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL);
            q += Fields.Primary(OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID);
            q += Fields.Unique_500(OFFSET_1_INVOICE.UNIQUENO);
            q += Fields.Foreign(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL, OFFSET_1_INVOICE.COMPANY_ID);
            q += Fields.Foreign(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL, OFFSET_1_INVOICE.ACY_ID);
            q += Fields.Foreign(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL, OFFSET_1_INVOICE.TAXTYPE_ID); 
            q += Fields.Foreign(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL, OFFSET_1_INVOICE.SALESTYPE_ID); 
            q += Fields.Int(OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO); 
            q += Fields.Date(OFFSET_1_INVOICE.OFFSET_1_INVOICE_DATE); 
            q += Fields.Foreign(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL, OFFSET_1_INVOICE.PARTY_ID); 
            q += Fields.VARCHAR_200(OFFSET_1_INVOICE.TOTAL_QTY); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.TOTAL_CGST); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.TOTAL_SGST); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.TOTAL_IGST); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.GSTTOTAL); 
            q += Fields.VARCHAR_500(OFFSET_1_INVOICE.LEDGER_ID); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.ADDITIONAL); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.ROUNDS); 
            q += Fields.Decimal_2(OFFSET_1_INVOICE.GRANDTOTAL); 
            q += Fields.VARCHAR_200(OFFSET_1_INVOICE.REFERED_AMT); 
            q += Fields.Smallint(OFFSET_1_INVOICE.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            Offset_1_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Offset_1_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL);
            q += Fields.Primary(OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID);
            q += Fields.Foreign(OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL, OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_ID); 
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_NO); 
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.OFFSET_1_PO_NO); 
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.OFFSET_1_DC_NO); 
            q += Fields.Foreign(OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL, OFFSET_1_INVOICEITEMS.PRODUCT_ID);
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.QTY);
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.PRICE);
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.SGST_PERCENT);
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.CGST_PERCENT);
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.IGST_PERCENT);
            q += Fields.VARCHAR_200(OFFSET_1_INVOICEITEMS.REFERED_ID); 
            q += Fields.Smallint(OFFSET_1_INVOICEITEMS.LOCKED); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

        #region[Default Values]

        public static void InsertDefault_invoice(string db)
        {
            //string q = USE.DB(db);
            //Pincode obj = new Pincode()
            //{
            //    Pincode_id = "",
            //    Pincode_name = "641601",
            //    Notes = "",
            //    Active_id = Core.Active,
            //    User_id = "1"
            //};

            //CPincode.Insert(obj, new DAL());

        }

        public static void InsertDefault_invoiceitems(string db)
        {
            //string q = USE.DB(db);
            //Pincode obj = new Pincode()
            //{
            //    Pincode_id = "",
            //    Pincode_name = "641601",
            //    Notes = "",
            //    Active_id = Core.Active,
            //    User_id = "1"
            //};

            //CPincode.Insert(obj, new DAL());

        }


        #endregion[Default Values]
 
    }//cls
}//ns
