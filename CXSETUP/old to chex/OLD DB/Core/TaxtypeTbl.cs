// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 24-01-2018 07:17:37 PM

using CXLIB;

namespace CXSETUP
{
    public class TaxtypeTbl 
    {
        #region[Create Table]

        public TaxtypeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS TAXTYPE_TBL(\r\n ";
            q += "  TAXTYPE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_TAXTYPE_ID PRIMARY KEY(TAXTYPE_ID)\r\n";
            q += ", TAXTYPE_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_TAXTYPE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  TAXTYPE_TBL ( TAXTYPE_ID , TAXTYPE_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'SGST' ,'','1','1'),\r\n";
            q += "( 2 , 'IGST' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM TAXTYPE_TBL WHERE TAXTYPE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
