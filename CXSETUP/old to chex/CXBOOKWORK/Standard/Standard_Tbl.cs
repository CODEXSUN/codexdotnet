// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 08.03.09 PM

using CXCORE; 
using CXLIB; 

namespace CXSETUP
{
    public class Standard_Tbl
    {
        #region[Create Table]

        public Standard_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(STANDARD.STANDARD_TBL);
            q += Fields.Primary(STANDARD.STANDARD_ID);
            q += Fields.Unique_500(STANDARD.STANDARD_NAME); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(STANDARD.STANDARD_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Standard(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(STANDARD.STANDARD_TBL);
            q += DB.FIELD_1ST(STANDARD.STANDARD_ID);
            q += DB.FIELD(STANDARD.STANDARD_NAME);
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
