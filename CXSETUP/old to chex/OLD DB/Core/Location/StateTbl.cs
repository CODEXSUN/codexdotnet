// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class StateTbl 
    {
        #region[Create Table]

        public StateTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS STATE_TBL(\r\n ";
            q += "  STATE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_STATE_ID PRIMARY KEY(STATE_ID)\r\n";
            q += ", STATE_NAME VARCHAR(255)  NOT NULL UNIQUE\r\n";
            q += ", STATE_CODE VARCHAR(255)  NOT NULL UNIQUE\r\n";
            q += ", COUNTRY_ID INT NOT NULL , CONSTRAINT FK_STATE_COUNTRY_ID FOREIGN KEY(COUNTRY_ID)REFERENCES COUNTRY_TBL(COUNTRY_ID)\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_STATE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  STATE_TBL ( STATE_ID , STATE_NAME , STATE_CODE , COUNTRY_ID , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'Tamilnadu' , '33' , 1 ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM STATE_TBL WHERE STATE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
