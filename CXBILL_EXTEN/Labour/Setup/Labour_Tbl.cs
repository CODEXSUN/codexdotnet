// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using CXLIB;
using LABOUR = CXBILL_EXTEN.Labour.Const.LABOUR;
using LABOURITEMS = CXBILL_EXTEN.Labour.Const.LABOURITEMS;

namespace CXBILL_EXTEN
{
    public class Labour_Tbl
    {
        #region[Create Table]

        public Labour_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(LABOUR.LABOUR_TBL);
            q += AddFields.Primary(LABOUR.LABOUR_ID);
            q += AddFields.Unique_500(LABOUR.UNIQUENO);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.COMPANY_ID);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.ACY_ID);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.ORDER_ID);
            q += AddFields.Int(LABOUR.LABOUR_NO); 
            q += AddFields.Date(LABOUR.LABOUR_DATE); 
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.PARTY_ID);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.TAXTYPE_ID);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.SALESTYPE_ID);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.TRANSPORT_ID);
            q += AddFields.Foreign(LABOUR.LABOUR_TBL, LABOUR.DELIVEREDTO_ID);
            q += AddFields.VARCHAR_500(LABOUR.BUNDEL);
            q += AddFields.VARCHAR_100(LABOUR.TOTAL_QTY); 
            q += AddFields.Decimal_2(LABOUR.TOTAL_TAXABLE_AMOUNT); 
            q += AddFields.Decimal_2(LABOUR.TOTAL_CGST); 
            q += AddFields.Decimal_2(LABOUR.TOTAL_SGST); 
            q += AddFields.Decimal_2(LABOUR.TOTAL_IGST); 
            q += AddFields.Decimal_2(LABOUR.GSTTOTAL); 
            q += AddFields.VARCHAR_200(LABOUR.LEDGER_ID); 
            q += AddFields.Decimal_2(LABOUR.ADDITIONAL); 
            q += AddFields.Decimal_2(LABOUR.ROUNDS); 
            q += AddFields.Decimal_2(LABOUR.GRANDTOTAL); 
            q += AddFields.Decimal_2(LABOUR.REFERED_AMT); 
            q += AddFields.Smallint(LABOUR.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(LABOUR.LABOUR_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            Tex_invoiceItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Tex_invoiceItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(LABOURITEMS.LABOURITEMS_TBL);
            q += AddFields.Primary(LABOURITEMS.LABOURITEMS_ID);
            q += AddFields.Foreign(LABOURITEMS.LABOURITEMS_TBL, LABOURITEMS.LABOUR_ID); 
            q += AddFields.VARCHAR_100(LABOURITEMS.PO_NO); 
            q += AddFields.VARCHAR_100(LABOURITEMS.DC_NO); 
            q += AddFields.Foreign(LABOURITEMS.LABOURITEMS_TBL, LABOURITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(LABOURITEMS.LABOURITEMS_TBL, LABOURITEMS.SIZES_ID); 
            q += AddFields.VARCHAR_100(LABOURITEMS.QTY); 
            q += AddFields.Decimal_2(LABOURITEMS.PRICE);
            q += AddFields.Decimal_2(LABOURITEMS.CGST_PERCENT);
            q += AddFields.Decimal_2(LABOURITEMS.SGST_PERCENT); 
            q += AddFields.Decimal_2(LABOURITEMS.IGST_PERCENT); 
            q += AddFields.VARCHAR_200(LABOURITEMS.REFERED_ID); 
            q += AddFields.Smallint(LABOURITEMS.LOCKED); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

        #region[Default Values]

        public static void InsertDefault_Seq(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(LABOUR.LABOUR_TBL);
            q += DB.FIELD_1ST(LABOUR.LABOUR_ID);
            q += DB.FIELD(LABOUR.UNIQUENO);
            q += DB.FIELD(LABOUR.COMPANY_ID);
            q += DB.FIELD(LABOUR.ACY_ID);
            q += DB.FIELD(LABOUR.ORDER_ID);
            q += DB.FIELD(LABOUR.LABOUR_NO);
            q += DB.FIELD(LABOUR.LABOUR_DATE);
            q += DB.FIELD(LABOUR.PARTY_ID);
            q += DB.FIELD(LABOUR.TAXTYPE_ID);
            q += DB.FIELD(LABOUR.SALESTYPE_ID);
            q += DB.FIELD(LABOUR.TRANSPORT_ID);
            q += DB.FIELD(LABOUR.DELIVEREDTO_ID);
            q += DB.FIELD(LABOUR.BUNDEL);
            q += DB.FIELD(LABOUR.TOTAL_QTY);
            q += DB.FIELD(LABOUR.TOTAL_TAXABLE_AMOUNT);
            q += DB.FIELD(LABOUR.TOTAL_CGST);
            q += DB.FIELD(LABOUR.TOTAL_SGST);
            q += DB.FIELD(LABOUR.TOTAL_IGST);
            q += DB.FIELD(LABOUR.GSTTOTAL);
            q += DB.FIELD(LABOUR.LEDGER_ID);
            q += DB.FIELD(LABOUR.ADDITIONAL);
            q += DB.FIELD(LABOUR.ROUNDS);
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("0");
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
