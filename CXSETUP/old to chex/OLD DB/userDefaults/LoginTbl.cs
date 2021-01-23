using CXLIB;
using System;

namespace CXSETUP
{
    public class LoginTbl
    {
        public LoginTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
            
            q += "CREATE TABLE IF NOT EXISTS LOGIN_Tbl (   \r\n ";
            q += "  LOGIN_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_LOGIN_ID PRIMARY KEY(LOGIN_ID) \r\n ";
            q += ", LOGIN_NAME VARCHAR(350)  NOT NULL  UNIQUE \r\n ";
            q += ", LOGIN_PASSWORD VARCHAR(350)  NOT NULL \r\n ";
            q += ", CREATEON DATETIME NULL \r\n ";
            q += " ); \r\n ";
            
            new DAL().Execute(q);
        }

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
            
            q += "INSERT INTO  LOGIN_Tbl ( LOGIN_ID , LOGIN_NAME , LOGIN_PASSWORD , CREATEON ) VALUES  \r\n";
            q += " (1, 'admin', 'admin', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'); \r\n";
            q += " \r\n ";
            
            new DAL().Execute(q);
        }

        public static void CleanTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
            
            q += "DELETE FROM LOGIN_Tbl; \r\n";
            q += "TRUNCATE TABLE LOGIN_Tbl;\r\n";
            new DAL().Execute(q);
        }
    }
}
