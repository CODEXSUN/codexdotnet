// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 06:41:07 AM

using CXLIB; 

namespace CXACCOUNTS
{
    public class Cash_payment_Tbl
    {
        #region[Create Table]

        public Cash_payment_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(CASH_PAYMENT.CASH_PAYMENT_TBL);
            q += AddFields.Primary(CASH_PAYMENT.CASH_PAYMENT_ID);
            q += AddFields.Foreign(CASH_PAYMENT.CASH_PAYMENT_TBL, CASH_PAYMENT.ORDER_ID); 
            q += AddFields.Date(CASH_PAYMENT.PAYMENT_DATE); 
            q += AddFields.Foreign(CASH_PAYMENT.CASH_PAYMENT_TBL, CASH_PAYMENT.LEDGER_ID); 
            q += AddFields.VARCHAR_500(CASH_PAYMENT.PURPOSE); 
            q += AddFields.Foreign(CASH_PAYMENT.CASH_PAYMENT_TBL, CASH_PAYMENT.PARTY_ID); 
            q += AddFields.Decimal_2(CASH_PAYMENT.PAYMENT_AMOUNT); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(CASH_PAYMENT.CASH_PAYMENT_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Cash_payment(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(CASH_PAYMENT.CASH_PAYMENT_TBL);
            q += DB.FIELD_1ST(CASH_PAYMENT.CASH_PAYMENT_ID);
            q += DB.FIELD(CASH_PAYMENT.ORDER_ID);
            q += DB.FIELD(CASH_PAYMENT.PAYMENT_DATE);
            q += DB.FIELD(CASH_PAYMENT.LEDGER_ID);
            q += DB.FIELD(CASH_PAYMENT.PURPOSE);
            q += DB.FIELD(CASH_PAYMENT.PARTY_ID);
            q += DB.FIELD(CASH_PAYMENT.PAYMENT_AMOUNT);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("1");
            q += DB.VALUE("'2020-08-10'");
            q += DB.VALUE("1");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
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
