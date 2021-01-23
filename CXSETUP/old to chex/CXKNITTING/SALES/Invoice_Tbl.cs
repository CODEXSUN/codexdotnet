// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:20 AM

using CXLIB;
using CXSETUP;

namespace CXKNITTING
{
    public class Knitting_Invoice_Tbl
    {
        #region[Create Table]

        public Knitting_Invoice_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(KNITTING_INVOICE.KNITTING_INVOICE_TBL);
            q += Fields.Primary(KNITTING_INVOICE.KNITTING_INVOICE_ID);
            q += Fields.Unique_500(KNITTING_INVOICE.UNIQUENO);
            q += Fields.Foreign(KNITTING_INVOICE.KNITTING_INVOICE_TBL, KNITTING_INVOICE.COMPANY_ID);
            q += Fields.Foreign(KNITTING_INVOICE.KNITTING_INVOICE_TBL, KNITTING_INVOICE.ACY_ID);
            q += Fields.Int(KNITTING_INVOICE.KNITTING_INVOICE_NO);
            q += Fields.Date(KNITTING_INVOICE.KNITTING_INVOICE_DATE);
            q += Fields.Foreign(KNITTING_INVOICE.KNITTING_INVOICE_TBL, KNITTING_INVOICE.PARTY_ID);
            q += Fields.Foreign(KNITTING_INVOICE.KNITTING_INVOICE_TBL, KNITTING_INVOICE.TAXTYPE_ID);
            q += Fields.Foreign(KNITTING_INVOICE.KNITTING_INVOICE_TBL, KNITTING_INVOICE.SALESTYPE_ID);
            q += Fields.VARCHAR_200(KNITTING_INVOICE.JOBNO);
            q += Fields.VARCHAR_200(KNITTING_INVOICE.TOTAL_ROLLS);
            q += Fields.VARCHAR_200(KNITTING_INVOICE.TOTAL_QTY);
            q += Fields.Decimal_2(KNITTING_INVOICE.TOTAL_TAXABLE_AMOUNT);
            q += Fields.Decimal_2(KNITTING_INVOICE.TOTAL_CGST);
            q += Fields.Decimal_2(KNITTING_INVOICE.TOTAL_SGST);
            q += Fields.Decimal_2(KNITTING_INVOICE.TOTAL_IGST);
            q += Fields.Decimal_2(KNITTING_INVOICE.GSTTOTAL);
            q += Fields.VARCHAR_500(KNITTING_INVOICE.LEDGER_ID);
            q += Fields.Decimal_2(KNITTING_INVOICE.ADDITIONAL);
            q += Fields.Decimal_2(KNITTING_INVOICE.ROUNDS);
            q += Fields.Decimal_2(KNITTING_INVOICE.GRANDTOTAL);
            q += Fields.VARCHAR_200(KNITTING_INVOICE.REFERED_AMT);
            q += Fields.Smallint(KNITTING_INVOICE.LOCKED);
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(KNITTING_INVOICE.KNITTING_INVOICE_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            Knitting_InvoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Knitting_InvoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL);
            q += Fields.Primary(KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID);
            q += Fields.Foreign(KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL, KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID);
            q += Fields.Int(KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO);
            q += Fields.Foreign(KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL, KNITTING_INVOICEITEMS.PRODUCT_ID);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.NOOFROLLS);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.QTY);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.PRICE);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.SGST_PERCENT);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.CGST_PERCENT);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.IGST_PERCENT);
            q += Fields.VARCHAR_200(KNITTING_INVOICEITEMS.REFERED_ID);
            q += Fields.Smallint(KNITTING_INVOICEITEMS.LOCKED);
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
