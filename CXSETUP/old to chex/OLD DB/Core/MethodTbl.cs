// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 08:21:03 PM

using CXLIB;

namespace CXSETUP
{
    public class MethodTbl 
    {
        #region[Create Table]

        public MethodTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS METHOD_TBL(\r\n ";
            q += "  METHOD_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_METHOD_ID PRIMARY KEY(METHOD_ID)\r\n";
            q += ", METHOD_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_METHOD_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  METHOD_TBL ( METHOD_ID , METHOD_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'PAYMENT' ,'','1','1'),\r\n";
            q += "( 2 , 'RECEIPT' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM METHOD_TBL WHERE METHOD_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
