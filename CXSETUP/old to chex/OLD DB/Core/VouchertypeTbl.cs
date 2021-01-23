// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:48:10 PM

using CXLIB;

namespace CXSETUP
{
    public class VouchertypeTbl 
    {
        #region[Create Table]

        public VouchertypeTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS VOUCHERTYPE_TBL(\r\n ";
            q += "  VOUCHERTYPE_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_VOUCHERTYPE_ID PRIMARY KEY(VOUCHERTYPE_ID)\r\n";
            q += ", VOUCHERTYPE_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", METHOD_ID INT NOT NULL , CONSTRAINT FK_VOUCHERTYPE_METHOD_ID FOREIGN KEY(METHOD_ID)REFERENCES METHOD_TBL(METHOD_ID)\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_VOUCHERTYPE_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  VOUCHERTYPE_TBL ( VOUCHERTYPE_ID , VOUCHERTYPE_NAME , METHOD_ID , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'CASH VOUCHER' , 1 ,'','1','1'),\r\n";
            q += "( 2 , 'CASH RECEIPT' , 2 ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM VOUCHERTYPE_TBL WHERE VOUCHERTYPE_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
