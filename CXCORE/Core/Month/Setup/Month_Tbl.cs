// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-10-2019 10:05:59 AM

using CXLIB; 

namespace CXCORE
{
    public class Month_Tbl
    {
        #region[Create Table]

        public Month_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(MONTH.MONTH_TBL);
            q += AddFields.Primary(MONTH.MONTH_ID);
            q += AddFields.Unique_500(MONTH.MONTH_NAME); 
            q += AddFields.Date(MONTH.MONTH_STARTS); 
            q += AddFields.Date(MONTH.MONTH_ENDS); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(MONTH.MONTH_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Month(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(MONTH.MONTH_TBL);
            q += DB.FIELD_1ST(MONTH.MONTH_ID);
            q += DB.FIELD(MONTH.MONTH_NAME);
            q += DB.FIELD(MONTH.MONTH_STARTS);
            q += DB.FIELD(MONTH.MONTH_ENDS);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("April - 19");
            q += DB.VALUE("2020-04-01");
            q += DB.VALUE("2020-04-30");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
