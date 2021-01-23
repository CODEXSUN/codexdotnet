// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class PartyTbl 
    {
        #region[Create Table]

        public PartyTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS PARTY_TBL(\r\n ";
            q += "  PARTY_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_PARTY_ID PRIMARY KEY(PARTY_ID)\r\n";
            q += ", PARTY_NAME VARCHAR(150)  NOT NULL UNIQUE\r\n";
            q += ", CONTACTTYPE_ID INT NOT NULL , CONSTRAINT FK_PARTY_CONTACTTYPE_ID FOREIGN KEY(CONTACTTYPE_ID)REFERENCES CONTACTTYPE_TBL(CONTACTTYPE_ID)\r\n";
            q += ", CONTACT_PERSON VARCHAR(150)  NOT NULL\r\n";
            q += ", STREET1 VARCHAR(250)  NOT NULL\r\n";
            q += ", STREET2 VARCHAR(250)  NOT NULL\r\n";
            q += ", CITY_ID INT NOT NULL , CONSTRAINT FK_PARTY_CITY_ID FOREIGN KEY(CITY_ID)REFERENCES CITY_TBL(CITY_ID)\r\n";
            q += ", STATE_ID INT NOT NULL , CONSTRAINT FK_PARTY_STATE_ID FOREIGN KEY(STATE_ID)REFERENCES STATE_TBL(STATE_ID)\r\n";
            q += ", COUNTRY_ID INT NOT NULL , CONSTRAINT FK_PARTY_COUNTRY_ID FOREIGN KEY(COUNTRY_ID)REFERENCES COUNTRY_TBL(COUNTRY_ID)\r\n";
            q += ", PINCODE_ID INT NOT NULL , CONSTRAINT FK_PARTY_PINCODE_ID FOREIGN KEY(PINCODE_ID)REFERENCES PINCODE_TBL(PINCODE_ID)\r\n";
            q += ", PHONE VARCHAR(16)  NOT NULL\r\n";
            q += ", CELL VARCHAR(16)  NOT NULL\r\n";
            q += ", EMAIL VARCHAR(150)  NOT NULL\r\n";
            q += ", WEBSITE VARCHAR(150)  NOT NULL\r\n";
            q += ", TIN VARCHAR(50)  NOT NULL\r\n";
            q += ", CST VARCHAR(50)  NOT NULL\r\n";
            q += ", GST VARCHAR(50)  NOT NULL\r\n";
            q += ", PAN VARCHAR(50)  NOT NULL\r\n";
            q += ", OPENING_BALANCE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", CREDIT_DAYS INT(11)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_PARTY_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  PARTY_TBL ( PARTY_ID , PARTY_NAME , CONTACTTYPE_ID , CONTACT_PERSON , STREET1 , STREET2 , CITY_ID , STATE_ID , COUNTRY_ID , PINCODE_ID , PHONE , CELL , EMAIL , WEBSITE , TIN , CST , GST , PAN , OPENING_BALANCE , CREDIT_DAYS , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'PARTY_NAME' , 1 , 'CONTACT_PERSON' , 'STREET1' , 'STREET2' , 1 , 1 , 1 , 1 , 'PHONE' , 'CELL' , 'EMAIL' , 'WEBSITE' , 'TIN' , 'CST' , 'GST' , 'PAN' , '0' , '9' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM PARTY_TBL WHERE PARTY_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
