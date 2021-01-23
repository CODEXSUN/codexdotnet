// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 08.01.05 PM

using CXLIB;

namespace CXCORE
{
    public class Contacttype_Tbl
    {
        #region[Create Table]

        public Contacttype_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(CONTACTTYPE.CONTACTTYPE_TBL);
            q += AddFields.Primary(CONTACTTYPE.CONTACTTYPE_ID);
            q += AddFields.Unique_500(CONTACTTYPE.CONTACTTYPE_NAME);
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(CONTACTTYPE.CONTACTTYPE_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Contacttype(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(CONTACTTYPE.CONTACTTYPE_TBL);
            q += DB.FIELD_1ST(CONTACTTYPE.CONTACTTYPE_ID);
            q += DB.FIELD(CONTACTTYPE.CONTACTTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("Debitors");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(CONTACTTYPE.CONTACTTYPE_TBL);// re set text
            q += DB.FIELD_1ST(CONTACTTYPE.CONTACTTYPE_ID);
            q += DB.FIELD(CONTACTTYPE.CONTACTTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("Creditors");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
