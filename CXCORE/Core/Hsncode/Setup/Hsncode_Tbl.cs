// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Hsncode_Tbl
    {
        #region[Create Table]

        public Hsncode_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(HSNCODE.HSNCODE_TBL);
            q += AddFields.Primary(HSNCODE.HSNCODE_ID);
            q += AddFields.Unique_500(HSNCODE.HSNCODE_NAME); 
            q += AddFields.VARCHAR_500(HSNCODE.DESCRIPTION); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(HSNCODE.HSNCODE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Hsncode(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(HSNCODE.HSNCODE_TBL);
            q += DB.FIELD_1ST(HSNCODE.HSNCODE_ID);
            q += DB.FIELD(HSNCODE.HSNCODE_NAME);
            q += DB.FIELD(HSNCODE.DESCRIPTION);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
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
