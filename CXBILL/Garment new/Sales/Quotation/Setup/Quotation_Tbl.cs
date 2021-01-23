// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using CXLIB; 

namespace CXBILL
{
    public class Quotation_Tbl
    {
        #region[Create Table]

        public Quotation_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(QUOTATION.QUOTATION_TBL);
            q += AddFields.Primary(QUOTATION.QUOTATION_ID);
            q += AddFields.Unique_500(QUOTATION.UNIQUENO);
            q += AddFields.Foreign(QUOTATION.QUOTATION_TBL, QUOTATION.COMPANY_ID);
            q += AddFields.Foreign(QUOTATION.QUOTATION_TBL, QUOTATION.ACY_ID);
            q += AddFields.Foreign(QUOTATION.QUOTATION_TBL, QUOTATION.ORDER_ID);
            q += AddFields.Int(QUOTATION.QUOTATION_NO); 
            q += AddFields.Date(QUOTATION.QUOTATION_DATE); 
            q += AddFields.Foreign(QUOTATION.QUOTATION_TBL, QUOTATION.PARTY_ID);
            q += AddFields.Decimal_3(QUOTATION.TOTAL_QTY); 
            q += AddFields.Decimal_2(QUOTATION.TOTAL_TAXABLE_AMOUNT); 
            q += AddFields.VARCHAR_200(QUOTATION.LEDGER_ID); 
            q += AddFields.Decimal_2(QUOTATION.ADDITIONAL); 
            q += AddFields.Decimal_2(QUOTATION.ROUNDS); 
            q += AddFields.Decimal_2(QUOTATION.GRANDTOTAL); 
            q += AddFields.Decimal_2(QUOTATION.REFERED_AMT); 
            q += AddFields.Smallint(QUOTATION.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(QUOTATION.QUOTATION_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            Tex_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Tex_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(QUOTATIONITEMS.QUOTATIONITEMS_TBL);
            q += AddFields.Primary(QUOTATIONITEMS.QUOTATIONITEMS_ID);
            q += AddFields.Foreign(QUOTATIONITEMS.QUOTATIONITEMS_TBL, QUOTATIONITEMS.QUOTATION_ID); 
            q += AddFields.Foreign(QUOTATIONITEMS.QUOTATIONITEMS_TBL, QUOTATIONITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(QUOTATIONITEMS.QUOTATIONITEMS_TBL, QUOTATIONITEMS.SIZES_ID); 
            q += AddFields.Decimal_3(QUOTATIONITEMS.QTY); 
            q += AddFields.Decimal_2(QUOTATIONITEMS.PRICE);
            q += AddFields.VARCHAR_200(QUOTATIONITEMS.REFERED_ID); 
            q += AddFields.Smallint(QUOTATIONITEMS.LOCKED); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
