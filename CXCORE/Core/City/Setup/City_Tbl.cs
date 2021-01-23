// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class City_Tbl
    {
        #region[Create Table]

        public City_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(CITY.CITY_TBL);
            q += AddFields.Primary(CITY.CITY_ID);
            q += AddFields.Unique_500(CITY.CITY_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(CITY.CITY_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_City(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(CITY.CITY_TBL);
            q += DB.FIELD_1ST(CITY.CITY_ID);
            q += DB.FIELD(CITY.CITY_NAME);
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
           q += DB.INSERT(CITY.CITY_TBL);
           q += DB.FIELD_1ST(CITY.CITY_ID);
           q += DB.FIELD(CITY.CITY_NAME);
           q += DB.NOTES;
           q += DB.ACTIVE_ID;
           q += DB.USER_ID;
           q += DB.MID;
           q += DB.VALUE_1ST("2");
           q += DB.VALUE("Tirupur");
           q += DB.NotesValue;
           q += DB.ActiveValue;
           q += DB.UserValue;
           q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
