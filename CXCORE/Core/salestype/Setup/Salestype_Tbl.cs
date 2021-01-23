// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Salestype_Tbl
    {
        #region[Create Table]

        public Salestype_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(SALESTYPE.SALESTYPE_TBL);
            q += AddFields.Primary(SALESTYPE.SALESTYPE_ID);
            q += AddFields.Unique_500(SALESTYPE.SALESTYPE_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(SALESTYPE.SALESTYPE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Salestype(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(SALESTYPE.SALESTYPE_TBL);
            q += DB.FIELD_1ST(SALESTYPE.SALESTYPE_ID);
            q += DB.FIELD(SALESTYPE.SALESTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("TAX INVOICE");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(SALESTYPE.SALESTYPE_TBL);
            q += DB.FIELD_1ST(SALESTYPE.SALESTYPE_ID);
            q += DB.FIELD(SALESTYPE.SALESTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("LABOUR BILL");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(SALESTYPE.SALESTYPE_TBL);
            q += DB.FIELD_1ST(SALESTYPE.SALESTYPE_ID);
            q += DB.FIELD(SALESTYPE.SALESTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("3");
            q += DB.VALUE("DEBIT NOTE");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);


            q = USE.DB(db);
            q += DB.INSERT(SALESTYPE.SALESTYPE_TBL);
            q += DB.FIELD_1ST(SALESTYPE.SALESTYPE_ID);
            q += DB.FIELD(SALESTYPE.SALESTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("4");
            q += DB.VALUE("B2B");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(SALESTYPE.SALESTYPE_TBL);
            q += DB.FIELD_1ST(SALESTYPE.SALESTYPE_ID);
            q += DB.FIELD(SALESTYPE.SALESTYPE_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("5");
            q += DB.VALUE("B2C");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
