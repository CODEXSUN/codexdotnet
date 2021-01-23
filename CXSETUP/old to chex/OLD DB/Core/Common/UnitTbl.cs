// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class UnitTbl 
    {
        #region[Create Table]

        public UnitTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS UNIT_TBL(\r\n ";
            q += "  UNIT_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_UNIT_ID PRIMARY KEY(UNIT_ID)\r\n";
            q += ", UNIT_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", UNIT_DESC VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_UNIT_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  UNIT_TBL ( UNIT_ID , UNIT_NAME , UNIT_DESC , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n";
            q += "( 1 , 'Mts' , 'Meters' ,'','1','1'),\r\n";
            q += "( 2 , 'Pcs' , 'Pices' ,'','1','1'),\r\n";
            q += "( 3 , 'Nos' , 'Numbers' ,'','1','1'),\r\n";
            q += "( 4 , 'Kgs' , 'Kilo Gram' ,'','1','1'),\r\n";
            q += "( 5 , 'Ltr' , 'Liters' ,'','1','1'),\r\n";
            q += "( 6 , 'Ft' , 'Feet' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM UNIT_TBL WHERE UNIT_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
