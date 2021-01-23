// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Ledgergroup_Tbl
    {
        #region[Create Table]

        public Ledgergroup_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(LEDGERGROUP.LEDGERGROUP_TBL);
            q += AddFields.Primary(LEDGERGROUP.LEDGERGROUP_ID);
            q += AddFields.Unique_500(LEDGERGROUP.LEDGERGROUP_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(LEDGERGROUP.LEDGERGROUP_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Ledgergroup(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(LEDGERGROUP.LEDGERGROUP_TBL);
            q += DB.FIELD_1ST(LEDGERGROUP.LEDGERGROUP_ID);
            q += DB.FIELD(LEDGERGROUP.LEDGERGROUP_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
