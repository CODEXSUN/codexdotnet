// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Method_Tbl
    {
        #region[Create Table]

        public Method_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(METHOD.METHOD_TBL);
            q += AddFields.Primary(METHOD.METHOD_ID);
            q += AddFields.Unique_500(METHOD.METHOD_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(METHOD.METHOD_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Method(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(METHOD.METHOD_TBL);
            q += DB.FIELD_1ST(METHOD.METHOD_ID);
            q += DB.FIELD(METHOD.METHOD_NAME);
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
