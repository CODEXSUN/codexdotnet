// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:39:04 PM

using CXLIB; 

namespace CXERP
{
    public class Po_Tbl
    {
        #region[Create Table]

        public Po_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PO.PO_TBL);
            q += AddFields.Primary(PO.PO_ID);
            q += AddFields.VARCHAR_500(PO.PO_NO); 
            q += AddFields.Date(PO.PO_DATE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(PO.PO_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Po(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(PO.PO_TBL);
            q += DB.FIELD_1ST(PO.PO_ID);
            q += DB.FIELD(PO.PO_NO);
            q += DB.FIELD(PO.PO_DATE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("'2021-01-23'");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
