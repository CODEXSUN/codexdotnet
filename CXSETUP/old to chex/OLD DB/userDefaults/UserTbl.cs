using CXLIB;
using System;

namespace CXSETUP
{
    public class UserTbl
    {

        public UserTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";

            q += "CREATE TABLE IF NOT EXISTS USER_Tbl (  \r\n";
            q += " USER_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_USER_ID PRIMARY KEY(USER_ID) \r\n ";
            q += ",USER_NAME VARCHAR(350)  NOT NULL  UNIQUE \r\n ";
            q += ",USER_PASSWORD VARCHAR(350)  NOT NULL \r\n ";
            q += ",CREATEON DATETIME NULL \r\n ";
            q += ",NOTES VARCHAR(200) NOT NULL \r\n ";
            q += ",ACTIVE_ID SMALLINT(1) NOT NULL \r\n ";
            q += ",ENTRYBY VARCHAR(100) NOT NULL \r\n ";
            q += " ); \r\n ";

            new DAL().Execute(q);
        }

        public static void InsertDefault(string _database)
        {
           
            string q = "USE " + _database + " ; \r\n ";
           
            q += "INSERT INTO  USER_Tbl ( USER_ID , USER_NAME , USER_PASSWORD , CREATEON , NOTES , ACTIVE_ID , ENTRYBY ) VALUES  \r\n";
            q += " (1, 'SUNDAR', 'codeXsun*', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'SUNDAR', 1, 1), \r\n";
            q += " (2, 'admin', 'admin', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'DEFAULT', 1, 1); \r\n";
           
            q += " \r\n ";
           
            new DAL().Execute(q);
        }

        public static void Clean_Tbl ( string _database)
        {
           
            string q = "USE " + _database + " ; \r\n ";
           
            q += "DELETE FROM USER_Tbl; \r\n";
            q += "TRUNCATE TABLE USER_Tbl;\r\n";
            new DAL().Execute(q);
        }

    }
}