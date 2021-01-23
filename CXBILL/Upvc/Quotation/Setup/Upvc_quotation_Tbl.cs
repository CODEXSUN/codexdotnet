// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 11:04:22 AM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class Upvc_Quotation_Tbl
    {
        #region[Create Table]

        public Upvc_Quotation_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(UPVC_QUOTATION.UPVC_QUOTATION_TBL);
            q += Fields.Primary(UPVC_QUOTATION.UPVC_QUOTATION_ID);
            q += Fields.Unique_500(UPVC_QUOTATION.UNIQUENO);
            q += Fields.Foreign(UPVC_QUOTATION.UPVC_QUOTATION_TBL, UPVC_QUOTATION.COMPANY_ID);
            q += Fields.Foreign(UPVC_QUOTATION.UPVC_QUOTATION_TBL, UPVC_QUOTATION.ACY_ID);
            q += Fields.Foreign(UPVC_QUOTATION.UPVC_QUOTATION_TBL, UPVC_QUOTATION.SALESTYPE_ID);
            q += Fields.Foreign(UPVC_QUOTATION.UPVC_QUOTATION_TBL, UPVC_QUOTATION.TAXTYPE_ID); 
            q += Fields.VARCHAR_200(UPVC_QUOTATION.QUOTATION_NO); 
            q += Fields.Date(UPVC_QUOTATION.QUOTATION_DATE); 
            q += Fields.Foreign(UPVC_QUOTATION.UPVC_QUOTATION_TBL, UPVC_QUOTATION.PARTY_ID); 
            q += Fields.Int(UPVC_QUOTATION.DELIVEREDTO_ID); 
            q += Fields.Foreign(UPVC_QUOTATION.UPVC_QUOTATION_TBL, UPVC_QUOTATION.TRANSPORT_ID); 
            q += Fields.VARCHAR_500(UPVC_QUOTATION.VEHICLE_NO); 
            q += Fields.Decimal_3(UPVC_QUOTATION.TOTAL_QTY); 
            q += Fields.VARCHAR_200(UPVC_QUOTATION.TOTAL_AREASQ); 
            q += Fields.Decimal_2(UPVC_QUOTATION.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal_2(UPVC_QUOTATION.TOTAL_CGST); 
            q += Fields.Decimal_2(UPVC_QUOTATION.TOTAL_SGST); 
            q += Fields.Decimal_2(UPVC_QUOTATION.TOTAL_IGST); 
            q += Fields.Decimal_2(UPVC_QUOTATION.GSTTOTAL); 
            q += Fields.VARCHAR_500(UPVC_QUOTATION.LEDGER_ID); 
            q += Fields.Decimal_2(UPVC_QUOTATION.ADDITIONAL); 
            q += Fields.Decimal_2(UPVC_QUOTATION.ROUNDS); 
            q += Fields.Decimal_2(UPVC_QUOTATION.GRANDTOTAL); 
            q += Fields.Decimal_2(UPVC_QUOTATION.REFERED_NO); 
            q += Fields.Smallint(UPVC_QUOTATION.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(UPVC_QUOTATION.UPVC_QUOTATION_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            Upvc_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Upvc_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL);
            q += Fields.Primary(UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_ID);
            q += Fields.Foreign(UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL, UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID); 
            q += Fields.Foreign(UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL, UPVC_QUOTATIONITEMS.PRODUCT_ID); 
            q += Fields.Decimal_3(UPVC_QUOTATIONITEMS.WIDTHS); 
            q += Fields.Decimal_3(UPVC_QUOTATIONITEMS.HEIGHTS); 
            q += Fields.Decimal_3(UPVC_QUOTATIONITEMS.AREASQ); 
            q += Fields.Decimal_3(UPVC_QUOTATIONITEMS.QTY); 
            q += Fields.Decimal_2(UPVC_QUOTATIONITEMS.PRICE); 
            q += Fields.Decimal_2(UPVC_QUOTATIONITEMS.SGST_PERCENT); 
            q += Fields.Decimal_2(UPVC_QUOTATIONITEMS.CGST_PERCENT); 
            q += Fields.Decimal_2(UPVC_QUOTATIONITEMS.IGST_PERCENT); 
            q += Fields.VARCHAR_500(UPVC_QUOTATIONITEMS.REFERED_ID); 
            q += Fields.Smallint(UPVC_QUOTATIONITEMS.LOCKED); 
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
