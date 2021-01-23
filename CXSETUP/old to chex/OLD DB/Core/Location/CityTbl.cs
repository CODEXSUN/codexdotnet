// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class CityTbl 
    {
        #region[Create Table]

        public CityTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS CITY_TBL(\r\n ";
            q += "  CITY_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_CITY_ID PRIMARY KEY(CITY_ID)\r\n";
            q += ", CITY_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", STATE_ID INT NOT NULL , CONSTRAINT FK_CITY_STATE_ID FOREIGN KEY(STATE_ID)REFERENCES STATE_TBL(STATE_ID)\r\n";
            q += ", COUNTRY_ID INT NOT NULL , CONSTRAINT FK_CITY_COUNTRY_ID FOREIGN KEY(COUNTRY_ID)REFERENCES COUNTRY_TBL(COUNTRY_ID)\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_CITY_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  CITY_TBL ( CITY_ID , CITY_NAME , STATE_ID , COUNTRY_ID , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'Chennai' , 1 , 1 ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM CITY_TBL WHERE CITY_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
