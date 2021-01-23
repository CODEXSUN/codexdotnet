// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Bundle_Tbl
    {
        #region[Create Table]

        public Bundle_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(BUNDLE.BUNDLE_TBL);
            q += AddFields.Primary(BUNDLE.BUNDLE_ID);
            q += AddFields.Unique_500(BUNDLE.BUNDLE_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(BUNDLE.BUNDLE_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Bundle(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(BUNDLE.BUNDLE_TBL);
            q += DB.FIELD_1ST(BUNDLE.BUNDLE_ID);
            q += DB.FIELD(BUNDLE.BUNDLE_NAME);
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

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
