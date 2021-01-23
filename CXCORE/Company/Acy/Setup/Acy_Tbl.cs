// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 07:48:01 AM

using CXLIB; 

namespace CXCORE
{
    public class Acy_Tbl
    {
        #region[Create Table]

        public Acy_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ACY.ACY_TBL);
            q += AddFields.Primary(ACY.ACY_ID);
            q += AddFields.Unique_500(ACY.ACY_NAME); 
            q += AddFields.Date(ACY.FROM_DATE); 
            q += AddFields.Date(ACY.TO_DATE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(ACY.ACY_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Acy(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(ACY.ACY_TBL);
            q += DB.FIELD_1ST(ACY.ACY_NAME);
            q += DB.FIELD(ACY.FROM_DATE);
            q += DB.FIELD(ACY.TO_DATE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("2017-18");
            q += DB.VALUE("2017-04-01");
            q += DB.VALUE("2018-03-31");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("2018-19");
            q += DB.VALUE("2018-04-01");
            q += DB.VALUE("2019-03-31");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("2019-20");
            q += DB.VALUE("2019-04-01");
            q += DB.VALUE("2020-03-31");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.ROW_NEXT_VALUE;

            q += DB.VALUE_1ST("2020-21");
            q += DB.VALUE("2020-04-01");
            q += DB.VALUE("2021-03-31");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
