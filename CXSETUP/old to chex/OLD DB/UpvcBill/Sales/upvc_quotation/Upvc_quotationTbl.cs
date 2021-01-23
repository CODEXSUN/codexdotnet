// Version : 4 dt : 04-10-2017
// Auto Generated
// 05-10-2017 12:27:03 PM
// last update : 05-10-2017

using CXLIB;

namespace CXSETUP
{
    public class Upvc_quotationTbl 
    {
        #region[Create Table]

        public Upvc_quotationTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS UPVC_QUOTATION_TBL(\r\n ";
            q += "  UPVC_QUOTATION_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_UPVC_QUOTATION_ID PRIMARY KEY(UPVC_QUOTATION_ID)\r\n";
            q += ", YEAR_NO VARCHAR(150)  NOT NULL\r\n";
            q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATION_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
            q += ", SALESTYPE VARCHAR(50)  NOT NULL\r\n";
            q += ", UPVC_SALESMODE_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATION_UPVC_SALESMODE_ID FOREIGN KEY(UPVC_SALESMODE_ID)REFERENCES UPVC_SALESMODE_TBL(UPVC_SALESMODE_ID)\r\n";
            q += ", UPVC_QUOTATION_NO INT(11)  NOT NULL\r\n";
            q += ", UPVC_QUOTATION_DATE DATE NOT NULL\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATION_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", SHIPPING_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATION_SHIPPING_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", TRANSPORT_MODE_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATION_TRANSPORT_MODE_ID FOREIGN KEY(TRANSPORT_MODE_ID)REFERENCES TRANSPORT_MODE_TBL(TRANSPORT_MODE_ID)\r\n";
            q += ", VEHICLE_NO VARCHAR(250)  NOT NULL\r\n";
            q += ", TOTAL_QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", TOTAL_AREASQ VARCHAR(50)  NOT NULL\r\n";
            q += ", TOTAL_TAXABLE_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", TOTAL_CGST DECIMAL(11,2)  NOT NULL\r\n";
            q += ", TOTAL_SGST DECIMAL(11,2)  NOT NULL\r\n";
            q += ", TOTAL_IGST DECIMAL(11,2)  NOT NULL\r\n";
            q += ", GSTTOTAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", LEDGER_ID VARCHAR(100)  NOT NULL\r\n";
            q += ", ADDITIONAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", ROUNDS DECIMAL(11,2)  NOT NULL\r\n";
            q += ", GRANDTOTAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", REFERED_NO VARCHAR(200)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_UPVC_QUOTATION_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);

        Upvc_quotationitemsTbl(_database);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void Upvc_quotationitemsTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS UPVC_QUOTATIONITEMS_TBL(\r\n ";
            q += "  UPVC_QUOTATIONITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_UPVC_QUOTATIONITEMS_ID PRIMARY KEY(UPVC_QUOTATIONITEMS_ID)\r\n";
            q += ", UPVC_QUOTATION_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATIONITEMS_UPVC_QUOTATION_ID FOREIGN KEY(UPVC_QUOTATION_ID)REFERENCES UPVC_QUOTATION_TBL(UPVC_QUOTATION_ID)\r\n";
            q += ", PRODUCT_ID INT NOT NULL , CONSTRAINT FK_UPVC_QUOTATIONITEMS_PRODUCT_ID FOREIGN KEY(PRODUCT_ID)REFERENCES PRODUCT_TBL(PRODUCT_ID)\r\n";
            q += ", WIDTHS VARCHAR(50)  NOT NULL\r\n";
            q += ", HEIGHTS VARCHAR(50)  NOT NULL\r\n";
            q += ", AREASQ VARCHAR(50)  NOT NULL\r\n";
            q += ", QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", PRICE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", SGST_PERCENT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", CGST_PERCENT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", IGST_PERCENT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", REFERED_ID VARCHAR(200)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += " );\r\n";
            new DAL().Execute(q);
        }
        #endregion[Create Items Table]

        #region[Insert Default]

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  UPVC_QUOTATION_TBL ( UPVC_QUOTATION_ID , YEAR_NO , COMPANY_ID , SALESTYPE , UPVC_SALESMODE_ID , UPVC_QUOTATION_NO , UPVC_QUOTATION_DATE , PARTY_ID , SHIPPING_ID , TRANSPORT_MODE_ID , VEHICLE_NO , TOTAL_QTY , TOTAL_AREASQ , TOTAL_TAXABLE_AMOUNT , TOTAL_CGST , TOTAL_SGST , TOTAL_IGST , GSTTOTAL , LEDGER_ID , ADDITIONAL , ROUNDS , GRANDTOTAL , REFERED_NO , LOCKED , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'YEAR_NO' , 1 , 'SALESTYPE' , 1 , '9' , '2017-10-05' , 1 , 1 , 1 , 'VEHICLE_NO' , 'TOTAL_QTY' , 'TOTAL_AREASQ' , '0' , '0' , '0' , '0' , '0' , 'LEDGER_ID' , '0' , '0' , '0' , 'REFERED_NO' , '1' ,'','1','1');\r\n";
            new DAL().Execute(q);

        InsertitemsDefault(_database);

        }
        #endregion[Insert Default]

        #region[Insert items Default]

        public static void InsertitemsDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  UPVC_QUOTATIONITEMS_TBL ( UPVC_QUOTATIONITEMS_ID , UPVC_QUOTATION_ID , PRODUCT_ID , WIDTHS , HEIGHTS , AREASQ , QTY , PRICE , SGST_PERCENT , CGST_PERCENT , IGST_PERCENT , REFERED_ID , LOCKED) VALUES \r\n"; 
            q += "( 1 , 1 , 1 , 'WIDTHS' , 'HEIGHTS' , 'AREASQ' , 'QTY' , '0' , '0' , '0' , '0' , 'REFERED_ID' , '8');\r\n";

            new DAL().Execute(q);

        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM UPVC_QUOTATIONITEMS_TBL WHERE UPVC_QUOTATION_ID <> 1 ;\r\n ";

            q += "DELETE FROM UPVC_QUOTATION_TBL WHERE UPVC_QUOTATION_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
