// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:58 PM
// last update : 17-08-2017

using CXLIB;

namespace CXSETUP
{
    public class ReceiptTbl 
    {
        #region[Create Table]

        public ReceiptTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS RECEIPT_TBL(\r\n ";
            q += "  RECEIPT_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_RECEIPT_ID PRIMARY KEY(RECEIPT_ID)\r\n";
            q += ", YEAR_NO VARCHAR(150)  NOT NULL UNIQUE\r\n";
            q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_RECEIPT_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
            q += ", RECEIPT_NO INT(11)  NOT NULL\r\n";
            q += ", RECEIPT_DATE DATE NULL\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_RECEIPT_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", RECEIPTTYPE_ID INT NOT NULL , CONSTRAINT FK_RECEIPT_RECEIPTTYPE_ID FOREIGN KEY(RECEIPTTYPE_ID)REFERENCES RECEIPTTYPE_TBL(RECEIPTTYPE_ID)\r\n";
            q += ", CHEQ_NO VARCHAR(200)  NOT NULL\r\n";
            q += ", RECEIPT_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", CHEQ_DATE VARCHAR(50)  NOT NULL\r\n";
            q += ", BANK_ID INT(11)  NOT NULL\r\n";
            q += ", TOTAL_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_RECEIPT_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);

        ReceiptitemsTbl(_database);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void ReceiptitemsTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS RECEIPTITEMS_TBL(\r\n ";
            q += "  RECEIPTITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_RECEIPTITEMS_ID PRIMARY KEY(RECEIPTITEMS_ID)\r\n";
            q += ", RECEIPT_ID INT NOT NULL , CONSTRAINT FK_RECEIPTITEMS_RECEIPT_ID FOREIGN KEY(RECEIPT_ID)REFERENCES RECEIPT_TBL(RECEIPT_ID)\r\n";
            q += ", RECEIPT_BY VARCHAR(100)  NOT NULL\r\n";
            q += ", INVOICED_NO INT(11)  NOT NULL\r\n";
            q += ", INVOICED_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", RECEIPT_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Items Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  RECEIPT_TBL ( RECEIPT_ID , YEAR_NO , COMPANY_ID , RECEIPT_NO , RECEIPT_DATE , PARTY_ID , RECEIPTTYPE_ID , CHEQ_NO , RECEIPT_AMOUNT , CHEQ_DATE , BANK_ID , TOTAL_AMOUNT , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'YEAR_NO' , 1 , '9' , '2017-08-17' , 1 , 1 , 'CHEQ_NO' , '0' , 'CHEQ_DATE' , '9' , '0' ,'','1','1');\r\n";
            new DAL().Execute(q);

        InsertitemsDefault(_database);

        }
        #endregion[Insert Default]

        #region[Insert items Default]

        public static void InsertitemsDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  RECEIPTITEMS_TBL ( RECEIPTITEMS_ID , RECEIPT_ID , RECEIPT_BY , INVOICED_NO , INVOICED_AMOUNT , RECEIPT_AMOUNT) VALUES \r\n"; 
            q += "( 1 , 1 , 'RECEIPT_BY' , '9' , '0' , '0');\r\n";

            new DAL().Execute(q);

        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM RECEIPTITEMS_TBL WHERE RECEIPT_ID <> 1 ;\r\n ";

            q += "DELETE FROM RECEIPT_TBL WHERE RECEIPT_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
