// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:24:12 PM

using CXLIB;

namespace CXSETUP
{
    public class VoucherTbl 
    {
        #region[Create Table]

        public VoucherTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS VOUCHER_TBL(\r\n ";
            q += "  VOUCHER_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_VOUCHER_ID PRIMARY KEY(VOUCHER_ID)\r\n";
            q += ", COMPANY_ID INT(11)  NOT NULL\r\n";
            q += ", VOUCHER_NO INT(11)  NOT NULL UNIQUE\r\n";
            q += ", VOUCHER_DATE DATE NOT NULL\r\n";
            q += ", VOUCHERTYPE_ID INT NOT NULL , CONSTRAINT FK_VOUCHER_VOUCHERTYPE_ID FOREIGN KEY(VOUCHERTYPE_ID)REFERENCES VOUCHERTYPE_TBL(VOUCHERTYPE_ID)\r\n";
            q += ", ORDER_ID INT NOT NULL , CONSTRAINT FK_VOUCHER_ORDER_ID FOREIGN KEY(ORDER_ID)REFERENCES ORDER_TBL(ORDER_ID)\r\n";
            q += ", LEDGER_ID INT NOT NULL , CONSTRAINT FK_VOUCHER_LEDGER_ID FOREIGN KEY(LEDGER_ID)REFERENCES LEDGER_TBL(LEDGER_ID)\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_VOUCHER_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", PURPOSE VARCHAR(500)  NOT NULL\r\n";
            q += ", CREDIT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", DEBIT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_VOUCHER_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  VOUCHER_TBL ( VOUCHER_ID , COMPANY_ID , VOUCHER_NO , VOUCHER_DATE , VOUCHERTYPE_ID , ORDER_ID , LEDGER_ID , PARTY_ID , PURPOSE , CREDIT , DEBIT , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , '9' , '0' , '2017-12-25' , 1 , 1 , 1 , 1 , 'PURPOSE' , '0' , '0' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM VOUCHER_TBL WHERE VOUCHER_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
