// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Colours_Tbl
    {
        #region[Create Table]

        public Colours_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(COLOURS.COLOURS_TBL);
            q += AddFields.Primary(COLOURS.COLOURS_ID);
            q += AddFields.Unique_500(COLOURS.COLOURS_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(COLOURS.COLOURS_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Colours(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(COLOURS.COLOURS_TBL);
            q += DB.FIELD_1ST(COLOURS.COLOURS_ID);
            q += DB.FIELD(COLOURS.COLOURS_NAME);
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

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(COLOURS.COLOURS_TBL);
            q += DB.FIELD_1ST(COLOURS.COLOURS_ID);
            q += DB.FIELD(COLOURS.COLOURS_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("Green");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(COLOURS.COLOURS_TBL);
            q += DB.FIELD_1ST(COLOURS.COLOURS_ID);
            q += DB.FIELD(COLOURS.COLOURS_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("3");
            q += DB.VALUE("Blue");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
