// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 14-11-2017 09:22:00 AM

using CXLIB;

namespace CXSETUP
{
    public class ProductTbl 
    {
        #region[Create Table]

        public ProductTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS PRODUCT_TBL(\r\n ";
            q += "  PRODUCT_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_PRODUCT_ID PRIMARY KEY(PRODUCT_ID)\r\n";
            q += ", PRODUCT_NAME VARCHAR(250)  NOT NULL UNIQUE\r\n";
            q += ", PRODUCTTYPE_ID INT NOT NULL , CONSTRAINT FK_PRODUCT_PRODUCTTYPE_ID FOREIGN KEY(PRODUCTTYPE_ID)REFERENCES PRODUCTTYPE_TBL(PRODUCTTYPE_ID)\r\n";
            q += ", HSNCODE_ID INT NOT NULL , CONSTRAINT FK_PRODUCT_HSNCODE_ID FOREIGN KEY(HSNCODE_ID)REFERENCES HSNCODE_TBL(HSNCODE_ID)\r\n";
            q += ", UNIT_ID INT NOT NULL , CONSTRAINT FK_PRODUCT_UNIT_ID FOREIGN KEY(UNIT_ID)REFERENCES UNIT_TBL(UNIT_ID)\r\n";
            q += ", PURCHASE_PRICE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", SELLING_PRICE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", SGST_PERCENT VARCHAR(100)  NOT NULL\r\n";
            q += ", CGST_PERCENT VARCHAR(100)  NOT NULL\r\n";
            q += ", IGST_PERCENT VARCHAR(100)  NOT NULL\r\n";
            q += ", OPENING_STOCK INT(11)  NOT NULL\r\n";
            q += ", OPENING_PRICE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_PRODUCT_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  PRODUCT_TBL ( PRODUCT_ID , PRODUCT_NAME , PRODUCTTYPE_ID , HSNCODE_ID , UNIT_ID , PURCHASE_PRICE , SELLING_PRICE , SGST_PERCENT , CGST_PERCENT , IGST_PERCENT , OPENING_STOCK , OPENING_PRICE , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'PRODUCT_NAME' , 1 , 1 , 1 , '0' , '0' , 'SGST_PERCENT' , 'CGST_PERCENT' , 'IGST_PERCENT' , '9' , '0' ,'','1','1');\r\n";
            new DAL().Execute(q);
        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM PRODUCT_TBL WHERE PRODUCT_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
