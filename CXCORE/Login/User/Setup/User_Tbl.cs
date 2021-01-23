// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXCORE; 
using CXLIB; 

namespace CXSETUP
{
    public class User_Tbl
    {
        #region[Create Table]

        public User_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(USER.USER_TBL);
            q += AddFields.Primary(USER.USER_ID);
            q += AddFields.Unique_500(USER.USER_NAME); 
            q += AddFields.VARCHAR_500(USER.USER_PASSWORD); 
            q += AddFields.DateTime(USER.CREATEON); 
            q += AddFields.Foreign(USER.USER_TBL, USER.ROLE_ID); 
            q += AddFields.VARCHAR_200(USER.ENTRYBY); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_User(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(USER.USER_TBL);
            q += DB.FIELD_1ST(USER.USER_ID);
            q += DB.FIELD(USER.USER_NAME);
            q += DB.FIELD(USER.USER_PASSWORD);
            q += DB.FIELD(USER.CREATEON);
            q += DB.FIELD(USER.ROLE_ID);
            q += DB.FIELD(USER.ENTRYBY);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("admin");
            q += DB.VALUE("admin");
            q += DB.VALUE("2019-05-28 16:10:38");
            q += DB.VALUE("1");
            q += DB.VALUE("admin");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]


        #region[Update Table]

        public static void UpdateTable(string db)
        {
        
        }

        #endregion[Update Table]


        #region[Update Data]

        public static void UpdateTable()
        {

        }

        #endregion[Update Data]


    }//cls
}//ns
