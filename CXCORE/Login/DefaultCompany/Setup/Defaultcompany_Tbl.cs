// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Defaultcompany_Tbl
    {
        #region[Create Table]

        public Defaultcompany_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(DEFAULTCOMPANY.DEFAULTCOMPANY_TBL);
            q += AddFields.Primary(DEFAULTCOMPANY.DEFAULTCOMPANY_ID);
            q += AddFields.Int(DEFAULTCOMPANY.COMPANY_ID);
            q += AddFields.Int(DEFAULTCOMPANY.ACY_ID);
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(DEFAULTCOMPANY.DEFAULTCOMPANY_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Defaultcompany(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(DEFAULTCOMPANY.DEFAULTCOMPANY_TBL);
            q += DB.FIELD_1ST(DEFAULTCOMPANY.DEFAULTCOMPANY_ID);
            q += DB.FIELD(DEFAULTCOMPANY.COMPANY_ID);
            q += DB.FIELD(DEFAULTCOMPANY.ACY_ID);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("1");
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
