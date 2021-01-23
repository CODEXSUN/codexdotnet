// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 04:20:38 PM

using CXLIB;

namespace CXSETUP
{
    public class OrderTbl 
    {
        #region[Create Table]

        public OrderTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS ORDER_TBL(\r\n ";
            q += "  ORDER_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_ORDER_ID PRIMARY KEY(ORDER_ID)\r\n";
            q += ", ORDER_NAME VARCHAR(500)  NOT NULL UNIQUE\r\n";
            q += ", DESCRIBTION VARCHAR(500)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_ORDER_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  ORDER_TBL ( ORDER_ID , ORDER_NAME , DESCRIBTION , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , '000' , 'DESCRIBTION' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM ORDER_TBL WHERE ORDER_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
