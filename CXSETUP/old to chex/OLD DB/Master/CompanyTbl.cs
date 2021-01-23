// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:01 AM

using CXLIB;
using System;

namespace CXSETUP
{
    public class CompanyTbl
    {
        #region[Create Table]

        public CompanyTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS COMPANY_TBL(\r\n ";
            q += "  COMPANY_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_COMPANY_ID PRIMARY KEY(COMPANY_ID)\r\n";
            q += ", COMPANY_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", DISPLAY_NAME VARCHAR(150)  NOT NULL\r\n";
            q += ", STREET1 VARCHAR(250)  NOT NULL\r\n";
            q += ", STREET2 VARCHAR(250)  NOT NULL\r\n";
            q += ", CITY_ID INT NOT NULL , CONSTRAINT FK_COMPANY_CITY_ID FOREIGN KEY(CITY_ID)REFERENCES CITY_TBL(CITY_ID)\r\n";
            q += ", STATE_ID INT NOT NULL , CONSTRAINT FK_COMPANY_STATE_ID FOREIGN KEY(STATE_ID)REFERENCES STATE_TBL(STATE_ID)\r\n";
            q += ", COUNTRY_ID INT NOT NULL , CONSTRAINT FK_COMPANY_COUNTRY_ID FOREIGN KEY(COUNTRY_ID)REFERENCES COUNTRY_TBL(COUNTRY_ID)\r\n";
            q += ", PINCODE_ID INT NOT NULL , CONSTRAINT FK_COMPANY_PINCODE_ID FOREIGN KEY(PINCODE_ID)REFERENCES PINCODE_TBL(PINCODE_ID)\r\n";
            q += ", CELL1 VARCHAR(16)  NOT NULL\r\n";
            q += ", CELL2 VARCHAR(16)  NOT NULL\r\n";
            q += ", PHONE VARCHAR(16)  NOT NULL\r\n";
            q += ", EMAIL VARCHAR(200)  NOT NULL\r\n";
            q += ", WEBSITE VARCHAR(200)  NOT NULL\r\n";
            q += ", TIN VARCHAR(50)  NOT NULL\r\n";
            q += ", GST VARCHAR(50)  NOT NULL\r\n";
            q += ", CST VARCHAR(50)  NOT NULL\r\n";
            q += ", PAN VARCHAR(50)  NOT NULL\r\n";
            q += ", BOOK_STARTS_FROM DATE NOT NULL\r\n";
            q += ", ACCOUNTING_YEAR_FROM DATE NOT NULL\r\n";
            q += ", ACCOUNTING_YEAR_TO DATE NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_COMPANY_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  COMPANY_TBL ( COMPANY_NAME , DISPLAY_NAME , STREET1 , STREET2 , CITY_ID , STATE_ID , COUNTRY_ID , PINCODE_ID , CELL1 , CELL2 , PHONE , EMAIL , WEBSITE , TIN , GST , CST , PAN , BOOK_STARTS_FROM , ACCOUNTING_YEAR_FROM , ACCOUNTING_YEAR_TO , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n";
            q += "( 'a' , 'atext' , 'STREET1' , 'STREET2' , 1 , 1 , 1 , 1 , 'CELL1' , 'CELL2' , 'PHONE' , 'EMAIL' , 'WEBSITE' , 'TIN' , 'GST' , 'CST' , 'PAN' , '" + DateTime.Now.ToString("yyyy-MM-dd") + "' , '" + DateTime.Now.ToString("yyyy-MM-dd") + "' , '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM COMPANY_TBL WHERE COMPANY_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
