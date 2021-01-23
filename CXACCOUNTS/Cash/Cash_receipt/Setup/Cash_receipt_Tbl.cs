// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

using CXLIB; 

namespace CXACCOUNTS
{
    public class Cash_receipt_Tbl
    {
        #region[Create Table]

        public Cash_receipt_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(CASH_RECEIPT.CASH_RECEIPT_TBL);
            q += AddFields.Primary(CASH_RECEIPT.CASH_RECEIPT_ID);
            q += AddFields.Date(CASH_RECEIPT.RECEIPT_DATE); 
            q += AddFields.Foreign(CASH_RECEIPT.CASH_RECEIPT_TBL, CASH_RECEIPT.PARTY_ID); 
            q += AddFields.VARCHAR_500(CASH_RECEIPT.PURPOSE); 
            q += AddFields.Decimal_2(CASH_RECEIPT.RECEIPT_AMOUNT); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(CASH_RECEIPT.CASH_RECEIPT_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Cash_receipt(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(CASH_RECEIPT.CASH_RECEIPT_TBL);
            q += DB.FIELD_1ST(CASH_RECEIPT.CASH_RECEIPT_ID);
            q += DB.FIELD(CASH_RECEIPT.RECEIPT_DATE);
            q += DB.FIELD(CASH_RECEIPT.PARTY_ID);
            q += DB.FIELD(CASH_RECEIPT.PURPOSE);
            q += DB.FIELD(CASH_RECEIPT.RECEIPT_AMOUNT);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("'2020-08-09'");
            q += DB.VALUE("1");
            q += DB.VALUE("-");
            q += DB.VALUE("0");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
