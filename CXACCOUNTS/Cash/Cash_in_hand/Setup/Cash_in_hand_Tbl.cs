// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:38 PM

using CXLIB; 

namespace CXACCOUNTS
{
    public class Cash_in_hand_Tbl
    {
        #region[Create Table]

        public Cash_in_hand_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(CASH_IN_HAND.CASH_IN_HAND_TBL);
            q += AddFields.Primary(CASH_IN_HAND.CASH_IN_HAND_ID);
            q += AddFields.Date(CASH_IN_HAND.ENTRY_DATE); 
            q += AddFields.Foreign(CASH_IN_HAND.CASH_IN_HAND_TBL, CASH_IN_HAND.CASH_RECEIPT_ID); 
            q += AddFields.Foreign(CASH_IN_HAND.CASH_IN_HAND_TBL, CASH_IN_HAND.CASH_PAYMENT_ID); 
            q += AddFields.Decimal_2(CASH_IN_HAND.RECEIPT_AMOUNT); 
            q += AddFields.Decimal_2(CASH_IN_HAND.PAYMENT_AMOUNT); 
            q += AddFields.Decimal_2(CASH_IN_HAND.BALANCE_AMOUNT); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(CASH_IN_HAND.CASH_IN_HAND_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Cash_in_hand(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(CASH_IN_HAND.CASH_IN_HAND_TBL);
            q += DB.FIELD_1ST(CASH_IN_HAND.CASH_IN_HAND_ID);
            q += DB.FIELD(CASH_IN_HAND.ENTRY_DATE);
            q += DB.FIELD(CASH_IN_HAND.CASH_RECEIPT_ID);
            q += DB.FIELD(CASH_IN_HAND.CASH_PAYMENT_ID);
            q += DB.FIELD(CASH_IN_HAND.RECEIPT_AMOUNT);
            q += DB.FIELD(CASH_IN_HAND.PAYMENT_AMOUNT);
            q += DB.FIELD(CASH_IN_HAND.BALANCE_AMOUNT);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("'2020-08-09'");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("0");
            q += DB.VALUE("0");
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
