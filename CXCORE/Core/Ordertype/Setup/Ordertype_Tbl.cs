// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Ordertype_Tbl
    {
        #region[Create Table]

        public Ordertype_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ORDERTYPE.ORDERTYPE_TBL);
            q += AddFields.Primary(ORDERTYPE.ORDERTYPE_ID);
            q += AddFields.Unique_500(ORDERTYPE.ORDERTYPE_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(ORDERTYPE.ORDERTYPE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Ordertype(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(ORDERTYPE.ORDERTYPE_TBL);
            q += DB.FIELD_1ST(ORDERTYPE.ORDERTYPE_ID);
            q += DB.FIELD(ORDERTYPE.ORDERTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("Export");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(ORDERTYPE.ORDERTYPE_TBL);
            q += DB.FIELD_1ST(ORDERTYPE.ORDERTYPE_ID);
            q += DB.FIELD(ORDERTYPE.ORDERTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("Merchant");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(ORDERTYPE.ORDERTYPE_TBL);
            q += DB.FIELD_1ST(ORDERTYPE.ORDERTYPE_ID);
            q += DB.FIELD(ORDERTYPE.ORDERTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("3");
            q += DB.VALUE("CMT");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(ORDERTYPE.ORDERTYPE_TBL);
            q += DB.FIELD_1ST(ORDERTYPE.ORDERTYPE_ID);
            q += DB.FIELD(ORDERTYPE.ORDERTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("4");
            q += DB.VALUE("Local Sales");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(ORDERTYPE.ORDERTYPE_TBL);
            q += DB.FIELD_1ST(ORDERTYPE.ORDERTYPE_ID);
            q += DB.FIELD(ORDERTYPE.ORDERTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("5");
            q += DB.VALUE("Domestic");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
