// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Defaultlogin_Tbl
    {
        #region[Create Table]

        public Defaultlogin_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(DEFAULTLOGIN.DEFAULTLOGIN_TBL);
            q += AddFields.Primary(DEFAULTLOGIN.DEFAULTLOGIN_ID);
            q += AddFields.Unique_500(DEFAULTLOGIN.DEFAULTLOGIN_NAME); 
            q += AddFields.VARCHAR_500(DEFAULTLOGIN.DEFAULT_PASSWORD); 
            q += AddFields.DateTime(DEFAULTLOGIN.CREATEON); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(DEFAULTLOGIN.DEFAULTLOGIN_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Defaultlogin(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(DEFAULTLOGIN.DEFAULTLOGIN_TBL);
            q += DB.FIELD_1ST(DEFAULTLOGIN.DEFAULTLOGIN_ID);
            q += DB.FIELD(DEFAULTLOGIN.DEFAULTLOGIN_NAME);
            q += DB.FIELD(DEFAULTLOGIN.DEFAULT_PASSWORD);
            q += DB.FIELD(DEFAULTLOGIN.CREATEON);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("admin");
            q += DB.VALUE("admin");
            q += DB.VALUE("2019-05-28 16:10:38");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
