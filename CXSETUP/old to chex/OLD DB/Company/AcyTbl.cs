// Version : 1 dt : 22-10-2018
// Auto Generated
// last update : 22-10-2018 08:19:41 PM

using CXLIB;

namespace CXSETUP
{
    public class AcyTbl 
    {
        #region[Create Table]

        public AcyTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS ACY_TBL(\r\n ";
            q += "  ACY_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_ACY_ID PRIMARY KEY(ACY_ID)\r\n";
            q += ", ACY_NAME VARCHAR(150)  NOT NULL\r\n";
            q += ", ACY_DESC VARCHAR(200)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_ACY_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  ACY_TBL ( ACY_ID , ACY_NAME , ACY_DESC , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'ACY_NAME' , 'ACY_DESC' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM ACY_TBL WHERE ACY_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
