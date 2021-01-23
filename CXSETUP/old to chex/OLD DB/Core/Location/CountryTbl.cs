// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:21:59 AM

using CXLIB;

namespace CXSETUP
{
    public class CountryTbl 
    {
        #region[Create Table]

        public CountryTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS COUNTRY_TBL(\r\n ";
            q += "  COUNTRY_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_COUNTRY_ID PRIMARY KEY(COUNTRY_ID)\r\n";
            q += ", COUNTRY_NAME VARCHAR(255)  NOT NULL UNIQUE \r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_COUNTRY_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  COUNTRY_TBL ( COUNTRY_ID , COUNTRY_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n";
            q += "( 1 , 'INDIA' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM COUNTRY_TBL WHERE COUNTRY_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
