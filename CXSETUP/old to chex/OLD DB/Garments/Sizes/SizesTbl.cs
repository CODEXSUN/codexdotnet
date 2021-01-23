// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 08-01-2018 08:03:26 PM

using CXLIB;

namespace CXSETUP
{
    public class SizesTbl 
    {
        #region[Create Table]

        public SizesTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS SIZES_TBL(\r\n ";
            q += "  SIZES_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_SIZES_ID PRIMARY KEY(SIZES_ID)\r\n";
            q += ", SIZES_NAME VARCHAR(250)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_SIZES_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  SIZES_TBL ( SIZES_ID , SIZES_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , '..' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM SIZES_TBL WHERE SIZES_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
