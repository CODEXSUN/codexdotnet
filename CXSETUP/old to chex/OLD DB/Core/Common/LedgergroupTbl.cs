// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class LedgergroupTbl 
    {
        #region[Create Table]

        public LedgergroupTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS LEDGERGROUP_TBL(\r\n ";
            q += "  LEDGERGROUP_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_LEDGERGROUP_ID PRIMARY KEY(LEDGERGROUP_ID)\r\n";
            q += ", LEDGERGROUP_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_LEDGERGROUP_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  LEDGERGROUP_TBL ( LEDGERGROUP_ID , LEDGERGROUP_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n";
            q += "( 1 , 'Direct Expenses' ,'','1','1'),\r\n";
            q += "( 2 , 'Indirect Expenses' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM LEDGERGROUP_TBL WHERE LEDGERGROUP_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
