// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:01 AM

using CXLIB;

namespace CXSETUP
{
    public class BankTbl 
    {
        #region[Create Table]

        public BankTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS BANK_TBL(\r\n ";
            q += "  BANK_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_BANK_ID PRIMARY KEY(BANK_ID)\r\n";
            q += ", BANK_NAME VARCHAR(500)  NOT NULL UNIQUE\r\n";
            q += ", ACCOUNT_NUMBER VARCHAR(500)  NOT NULL\r\n";
            q += ", IFSC_CODE VARCHAR(100)  NOT NULL\r\n";
            q += ", OPENING_BALANCE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_BANK_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  BANK_TBL ( BANK_ID , BANK_NAME , ACCOUNT_NUMBER , IFSC_CODE , OPENING_BALANCE , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n";
            q += "( 1 , 'STATE BANK OF INDIA' , 'ACCOUNT_NUMBER' , 'IFSC_CODE' , '0' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM BANK_TBL WHERE BANK_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
