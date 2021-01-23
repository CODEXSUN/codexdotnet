// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:20 AM

using CXLIB;
using CXSETUP;

namespace CXTEX
{
    public class Tex_invoice_Tbl
    {
        #region[Create Table]

        public Tex_invoice_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(TEX_INVOICE.TEX_INVOICE_TBL);
            q += Fields.Primary(TEX_INVOICE.TEX_INVOICE_ID);
            q += Fields.Unique_500(TEX_INVOICE.UNIQUENO);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.COMPANY_ID);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.ACY_ID);
            q += Fields.Int(TEX_INVOICE.TEX_INVOICE_NO);
            q += Fields.Date(TEX_INVOICE.TEX_INVOICE_DATE);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.PARTY_ID);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.TAXTYPE_ID);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.SALESTYPE_ID);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.TRANSPORT_ID);
            q += Fields.Foreign(TEX_INVOICE.TEX_INVOICE_TBL, TEX_INVOICE.DELIVEREDTO_ID);
            q += Fields.VARCHAR_200(TEX_INVOICE.BUNDEL);
            q += Fields.VARCHAR_200(TEX_INVOICE.TOTAL_QTY);
            q += Fields.Decimal_2(TEX_INVOICE.TOTAL_TAXABLE_AMOUNT);
            q += Fields.Decimal_2(TEX_INVOICE.TOTAL_CGST);
            q += Fields.Decimal_2(TEX_INVOICE.TOTAL_SGST);
            q += Fields.Decimal_2(TEX_INVOICE.TOTAL_IGST);
            q += Fields.Decimal_2(TEX_INVOICE.GSTTOTAL);
            q += Fields.VARCHAR_500(TEX_INVOICE.LEDGER_ID);
            q += Fields.Decimal_2(TEX_INVOICE.ADDITIONAL);
            q += Fields.Decimal_2(TEX_INVOICE.ROUNDS);
            q += Fields.Decimal_2(TEX_INVOICE.GRANDTOTAL);
            q += Fields.VARCHAR_200(TEX_INVOICE.REFERED_AMT);
            q += Fields.Smallint(TEX_INVOICE.LOCKED);
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(TEX_INVOICE.TEX_INVOICE_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            InvoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void InvoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL);
            q += Fields.Primary(TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID);
            q += Fields.Foreign(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL, TEX_INVOICEITEMS.TEX_INVOICE_ID);
            q += Fields.Int(TEX_INVOICEITEMS.TEX_INVOICE_NO);
            q += Fields.Foreign(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL, TEX_INVOICEITEMS.PRODUCT_ID);
            q += Fields.Foreign(TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL, TEX_INVOICEITEMS.SIZES_ID);
            q += Fields.VARCHAR_200(TEX_INVOICEITEMS.QTY);
            q += Fields.VARCHAR_200(TEX_INVOICEITEMS.PRICE);
            q += Fields.VARCHAR_200(TEX_INVOICEITEMS.SGST_PERCENT);
            q += Fields.VARCHAR_200(TEX_INVOICEITEMS.CGST_PERCENT);
            q += Fields.VARCHAR_200(TEX_INVOICEITEMS.IGST_PERCENT);
            q += Fields.VARCHAR_200(TEX_INVOICEITEMS.REFERED_ID);
            q += Fields.Smallint(TEX_INVOICEITEMS.LOCKED);
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
