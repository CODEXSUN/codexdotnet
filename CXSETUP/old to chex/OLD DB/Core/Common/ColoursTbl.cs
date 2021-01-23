// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 12-04-2018 06:08:17 PM

using CXLIB;

namespace CXSETUP
{
    public class ColoursTbl 
    {
        #region[Create Table]

        public ColoursTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS COLOURS_TBL(\r\n ";
            q += "  COLOURS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_COLOURS_ID PRIMARY KEY(COLOURS_ID)\r\n";
            q += ", COLOURS_NAME VARCHAR(250)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_COLOURS_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  COLOURS_TBL ( COLOURS_ID , COLOURS_NAME , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'White' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM COLOURS_TBL WHERE COLOURS_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
