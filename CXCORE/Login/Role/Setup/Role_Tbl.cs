// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Role_Tbl
    {
        #region[Create Table]

        public Role_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ROLE.ROLE_TBL);
            q += AddFields.Primary(ROLE.ROLE_ID);
            q += AddFields.Unique_500(ROLE.ROLE_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Role(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(ROLE.ROLE_TBL);
            q += DB.FIELD_1ST(ROLE.ROLE_ID);
            q += DB.FIELD(ROLE.ROLE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("Admin");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);

            q += DB.INSERT(ROLE.ROLE_TBL);
            q += DB.FIELD_1ST(ROLE.ROLE_ID);
            q += DB.FIELD(ROLE.ROLE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("Accounts");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
