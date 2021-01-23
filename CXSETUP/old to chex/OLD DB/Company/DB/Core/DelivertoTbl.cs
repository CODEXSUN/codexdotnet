// Version : 1 dt : 22-10-2018
// Auto Generated
// last update : 22-10-2018 01:38:35 PM

using CXLIB;

namespace CXSETUP
{
    public class DelivertoTbl 
    {
        #region[Create Table]

        public DelivertoTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS DELIVERYTO_TBL(\r\n ";
            q += "  DELIVERYTO_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_DELIVERYTO_ID PRIMARY KEY(DELIVERYTO_ID)\r\n";
            q += ", DELIVERYTO_NAME VARCHAR(500)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_DELIVERYTO_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  DELIVERYTO_TBL ( DELIVERYTO_ID , DELIVERYTO_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'DELIVERYTO_NAME' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM DELIVERYTO_TBL WHERE DELIVERYTO_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
