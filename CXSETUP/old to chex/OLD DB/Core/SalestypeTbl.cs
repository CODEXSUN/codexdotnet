// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 24-01-2018 07:17:37 PM

using CXLIB;

namespace CXSETUP
{
    public class SalestypeTbl 
    {
        #region[Create Table]

        public SalestypeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS SALESTYPE_TBL(\r\n ";
            q += "  SALESTYPE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_SALESTYPE_ID PRIMARY KEY(SALESTYPE_ID)\r\n";
            q += ", SALESTYPE_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_SALESTYPE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  SALESTYPE_TBL ( SALESTYPE_ID , SALESTYPE_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'TAX INVOICE' ,'','1','1'),\r\n";
            q += "( 2 , 'LABOUR BILL' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM SALESTYPE_TBL WHERE SALESTYPE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
