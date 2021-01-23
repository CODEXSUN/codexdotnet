// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB;

namespace CXCORE
{
    public class Sizes_Tbl
    {
        #region[Create Table]

        public Sizes_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(SIZES.SIZES_TBL);
            q += AddFields.Primary(SIZES.SIZES_ID);
            q += AddFields.Unique_500(SIZES.SIZES_NAME);
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(SIZES.SIZES_TBL);
            q += AddFields.EOF;

            new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Sizes(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(SIZES.SIZES_TBL);
            q += DB.FIELD_1ST(SIZES.SIZES_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("..");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("S");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("M");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("L");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("XL");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;

            q += DB.ROW_NEXT_VALUE;
            q += DB.VALUE_1ST("XXL");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
