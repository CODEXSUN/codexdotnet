// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class State_Tbl
    {
        #region[Create Table]

        public State_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(STATE.STATE_TBL);
            q += AddFields.Primary(STATE.STATE_ID);
            q += AddFields.Unique_500(STATE.STATE_NAME); 
            q += AddFields.VARCHAR_200(STATE.STATE_CODE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(STATE.STATE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_State(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(STATE.STATE_TBL);
            q += DB.FIELD_1ST(STATE.STATE_ID);
            q += DB.FIELD(STATE.STATE_NAME);
            q += DB.FIELD(STATE.STATE_CODE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("00");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

            q = USE.DB(db);
            q += DB.INSERT(STATE.STATE_TBL);
            q += DB.FIELD_1ST(STATE.STATE_ID);
            q += DB.FIELD(STATE.STATE_NAME);
            q += DB.FIELD(STATE.STATE_CODE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2");
            q += DB.VALUE("Tamilnadu");
            q += DB.VALUE("33");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
