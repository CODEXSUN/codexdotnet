// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class HsncodeTbl 
    {
        #region[Create Table]

        public HsncodeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS HSNCODE_TBL(\r\n ";
            q += "  HSNCODE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_HSNCODE_ID PRIMARY KEY(HSNCODE_ID)\r\n";
            q += ", HSNCODE_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", DESCRIPTION VARCHAR(250)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_HSNCODE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  HSNCODE_TBL ( HSNCODE_ID , HSNCODE_NAME , DESCRIPTION , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n";
            q += "( 1 , '-' , 'DEFAULT' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM HSNCODE_TBL WHERE HSNCODE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
