// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Bank_Tbl
    {
        #region[Create Table]

        public Bank_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(BANK.BANK_TBL);
            q += AddFields.Primary(BANK.BANK_ID);
            q += AddFields.Unique_500(BANK.BANK_NAME); 
            q += AddFields.VARCHAR_500(BANK.ACCOUNT_NUMBER); 
            q += AddFields.VARCHAR_200(BANK.IFSC_CODE); 
            q += AddFields.Decimal_2(BANK.OPENING_BALANCE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(BANK.BANK_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Bank(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(BANK.BANK_TBL);
            q += DB.FIELD_1ST(BANK.BANK_ID);
            q += DB.FIELD(BANK.BANK_NAME);
            q += DB.FIELD(BANK.ACCOUNT_NUMBER);
            q += DB.FIELD(BANK.IFSC_CODE);
            q += DB.FIELD(BANK.OPENING_BALANCE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("0");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
