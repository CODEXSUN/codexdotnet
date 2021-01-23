// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:01 AM

using CXLIB;

namespace CXSETUP
{
    public class Upvc_salesmodeTbl 
    {
        #region[Create Table]

        public Upvc_salesmodeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS UPVC_SALESMODE_TBL(\r\n ";
            q += "  UPVC_SALESMODE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_UPVC_SALESMODE_ID PRIMARY KEY(UPVC_SALESMODE_ID)\r\n";
            q += ", UPVC_SALESMODE_NAME VARCHAR(250)  NOT NULL\r\n";
            q += ", DESCRIPTION VARCHAR(250)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_UPVC_SALESMODE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  UPVC_SALESMODE_TBL ( UPVC_SALESMODE_ID , UPVC_SALESMODE_NAME , DESCRIPTION , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'UPVC_SALESMODE_NAME' , 'DESCRIPTION' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM UPVC_SALESMODE_TBL WHERE UPVC_SALESMODE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
