// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Ledger_Tbl
    {
        #region[Create Table]

        public Ledger_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(LEDGER.LEDGER_TBL);
            q += AddFields.Primary(LEDGER.LEDGER_ID);
            q += AddFields.Unique_500(LEDGER.LEDGER_NAME); 
            q += AddFields.Foreign(LEDGER.LEDGER_TBL, LEDGER.LEDGERGROUP_ID); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(LEDGER.LEDGER_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Ledger(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(LEDGER.LEDGER_TBL);
            q += DB.FIELD_1ST(LEDGER.LEDGER_ID);
            q += DB.FIELD(LEDGER.LEDGER_NAME);
            q += DB.FIELD(LEDGER.LEDGERGROUP_ID);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
