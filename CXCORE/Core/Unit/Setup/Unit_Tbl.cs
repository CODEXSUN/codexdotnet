// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Unit_Tbl
    {
        #region[Create Table]

        public Unit_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(UNIT.UNIT_TBL);
            q += AddFields.Primary(UNIT.UNIT_ID);
            q += AddFields.Unique_500(UNIT.UNIT_NAME); 
            q += AddFields.VARCHAR_200(UNIT.UNIT_DESC); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(UNIT.UNIT_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Unit(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(UNIT.UNIT_TBL);
            q += DB.FIELD_1ST(UNIT.UNIT_ID);
            q += DB.FIELD(UNIT.UNIT_NAME);
            q += DB.FIELD(UNIT.UNIT_DESC);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("KGS");
            q += DB.VALUE("Kilo Gram");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(UNIT.UNIT_TBL);
            q += DB.FIELD_1ST(UNIT.UNIT_ID);
            q += DB.FIELD(UNIT.UNIT_NAME);
            q += DB.FIELD(UNIT.UNIT_DESC);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("PCS");
            q += DB.VALUE("Pices");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);


            q = USE.DB(db);
            q += DB.INSERT(UNIT.UNIT_TBL);
            q += DB.FIELD_1ST(UNIT.UNIT_ID);
            q += DB.FIELD(UNIT.UNIT_NAME);
            q += DB.FIELD(UNIT.UNIT_DESC);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("3");
            q += DB.VALUE("NOS");
            q += DB.VALUE("Numbers");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
