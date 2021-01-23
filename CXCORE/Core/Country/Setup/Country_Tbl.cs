// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Country_Tbl
    {
        #region[Create Table]

        public Country_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(COUNTRY.COUNTRY_TBL);
            q += AddFields.Primary(COUNTRY.COUNTRY_ID);
            q += AddFields.Unique_500(COUNTRY.COUNTRY_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(COUNTRY.COUNTRY_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Country(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(COUNTRY.COUNTRY_TBL);
            q += DB.FIELD_1ST(COUNTRY.COUNTRY_ID);
            q += DB.FIELD(COUNTRY.COUNTRY_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("INDIA");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
