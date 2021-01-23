// Version : 3 dt : 01-08-2017
// Auto Generated
// 20-08-2017 10:33:49 PM
// last update : 20-08-2017

using CXLIB;

namespace CXSETUP
{
    public class PoTbl 
    {
        #region[Create Table]

        public PoTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS PO_TBL(\r\n ";
            q += "  PO_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_PO_ID PRIMARY KEY(PO_ID)\r\n";
            q += ", YEAR_NO VARCHAR(150)  NOT NULL UNIQUE \r\n";
            q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_PO_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
            q += ", PO_NO VARCHAR(250)  NOT NULL\r\n";
            q += ", PO_DATE DATE NOT NULL\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_PO_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", PARTY_PO_REF VARCHAR(250)  NOT NULL\r\n";
            q += ", DELIVERY_DATE DATE NOT NULL\r\n";
            q += ", TOTAL_QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", TOTAL_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", REFERED_NO VARCHAR(200)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_PO_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);

        PoitemsTbl(_database);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void PoitemsTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS POITEMS_TBL(\r\n ";
            q += "  POITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_POITEMS_ID PRIMARY KEY(POITEMS_ID)\r\n";
            q += ", PO_ID INT NOT NULL , CONSTRAINT FK_POITEMS_PO_ID FOREIGN KEY(PO_ID)REFERENCES PO_TBL(PO_ID)\r\n";
            q += ", PRODUCT_ID INT NOT NULL , CONSTRAINT FK_POITEMS_PRODUCT_ID FOREIGN KEY(PRODUCT_ID)REFERENCES PRODUCT_TBL(PRODUCT_ID)\r\n";
            q += ", QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", PRICE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", SUB_TOTAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", REFERED_QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Items Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  PO_TBL ( PO_ID , YEAR_NO , COMPANY_ID , PO_NO , PO_DATE , PARTY_ID , PARTY_PO_REF , DELIVERY_DATE , TOTAL_QTY , TOTAL_AMOUNT , REFERED_NO , LOCKED , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'YEAR_NO' , 1 , 'Without Po' , '2017-08-20' , 1 , 'PARTY_PO_REF' , '2017-08-20' , '0' , '0' , '0' , '1' ,'','1','1');\r\n";
            new DAL().Execute(q);

        InsertitemsDefault(_database);

        }
        #endregion[Insert Default]

        #region[Insert items Default]

        public static void InsertitemsDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  POITEMS_TBL ( POITEMS_ID , PO_ID , PRODUCT_ID , QTY , PRICE , SUB_TOTAL , REFERED_QTY , LOCKED) VALUES \r\n"; 
            q += "( 1 , 1 , 1 , '0' , '0' , '0' , '0' , '8');\r\n";

            new DAL().Execute(q);

        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM POITEMS_TBL WHERE PO_ID <> 1 ;\r\n ";

            q += "DELETE FROM PO_TBL WHERE PO_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
