// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-04-2018 09:48:47 AM

using CXLIB;

namespace CXSETUP
{
    public class OrdertypeTbl 
    {
        #region[Create Table]

        public OrdertypeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS ORDERTYPE_TBL(\r\n ";
            q += "  ORDERTYPE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_ORDERTYPE_ID PRIMARY KEY(ORDERTYPE_ID)\r\n";
            q += ", ORDERTYPE_NAME VARCHAR(250)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_ORDERTYPE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  ORDERTYPE_TBL ( ORDERTYPE_ID , ORDERTYPE_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'ORDERTYPE_NAME' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM ORDERTYPE_TBL WHERE ORDERTYPE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
