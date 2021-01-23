// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:01 AM

using CXLIB;

namespace CXSETUP
{
    public class Transport_modeTbl 
    {
        #region[Create Table]

        public Transport_modeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS TRANSPORT_MODE_TBL(\r\n ";
            q += "  TRANSPORT_MODE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_TRANSPORT_MODE_ID PRIMARY KEY(TRANSPORT_MODE_ID)\r\n";
            q += ", TRANSPORT_MODE_NAME VARCHAR(300)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_TRANSPORT_MODE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  TRANSPORT_MODE_TBL ( TRANSPORT_MODE_ID , TRANSPORT_MODE_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'TRANSPORT_MODE_NAME' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM TRANSPORT_MODE_TBL WHERE TRANSPORT_MODE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
