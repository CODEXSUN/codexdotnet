// Version : 3 dt : 01-08-2017
// Auto Generated
// 02-10-2017 07:16:41 PM
// last update : 02-10-2017

using CXLIB;

namespace CXSETUP
{
    public class QuotationTbl 
    {
        #region[Create Table]

        public QuotationTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS QUOTATION_TBL(\r\n ";
            q += "  QUOTATION_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_QUOTATION_ID PRIMARY KEY(QUOTATION_ID)\r\n";
            q += ", UNIQUENO VARCHAR(150)  NOT NULL UNIQUE \r\n";
            q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
            q += ", DIV_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_DIV_ID FOREIGN KEY(DIV_ID)REFERENCES DIV_TBL(DIV_ID)\r\n";
            q += ", ACY_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_ACY_ID FOREIGN KEY(ACY_ID)REFERENCES ACY_TBL(ACY_ID)\r\n";
            q += ", QUOTATION_NO INT(11)  NOT NULL\r\n";
            q += ", QUOTATION_DATE DATE NOT NULL\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", TAXTYPE_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_TAXTYPE_ID FOREIGN KEY(TAXTYPE_ID)REFERENCES TAXTYPE_TBL(TAXTYPE_ID)\r\n";
            q += ", SALESTYPE_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_SALESTYPE_ID FOREIGN KEY(SALESTYPE_ID)REFERENCES SALESTYPE_TBL(SALESTYPE_ID)\r\n";
            q += ", TRANSPORT_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_TRANSPORT_ID FOREIGN KEY(TRANSPORT_ID)REFERENCES TRANSPORT_TBL(TRANSPORT_ID)\r\n";
            q += ", DELIVERYTO_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_DELIVERYTO_ID FOREIGN KEY(DELIVERYTO_ID)REFERENCES DELIVERYTO_TBL(DELIVERYTO_ID)\r\n";
            q += ", BUNDEL VARCHAR(50)  NOT NULL\r\n";
            q += ", TOTAL_QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", TOTAL_TAXABLE_AMOUNT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", TOTAL_CGST DECIMAL(11,2)  NOT NULL\r\n";
            q += ", TOTAL_SGST DECIMAL(11,2)  NOT NULL\r\n";
            q += ", TOTAL_IGST DECIMAL(11,2)  NOT NULL\r\n";
            q += ", GSTTOTAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", LEDGER_ID VARCHAR(100)  NOT NULL\r\n";
            q += ", ADDITIONAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", ROUNDS DECIMAL(11,2)  NOT NULL\r\n";
            q += ", GRANDTOTAL DECIMAL(11,2)  NOT NULL\r\n";
            q += ", REFERED_AMT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_QUOTATION_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);

        InvoiceitemsTbl(_database);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void InvoiceitemsTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS QUOTATIONITEMS_TBL(\r\n ";
            q += "  QUOTATIONITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_QUOTATIONITEMS_ID PRIMARY KEY(QUOTATIONITEMS_ID)\r\n";
            q += ", QUOTATION_ID INT NOT NULL , CONSTRAINT FK_QUOTATIONITEMS_QUOTATION_ID FOREIGN KEY(QUOTATION_ID)REFERENCES QUOTATION_TBL(QUOTATION_ID)\r\n";
            q += ", QUOTATION_NO INT(11)  NOT NULL\r\n";
            q += ", PO_ID INT NOT NULL , CONSTRAINT FK_QUOTATIONITEMS_PO_ID FOREIGN KEY(PO_ID)REFERENCES PO_TBL(PO_ID)\r\n";
            q += ", POITEMS_ID INT(11)  NOT NULL\r\n";
            q += ", DC_ID INT NOT NULL , CONSTRAINT FK_QUOTATIONITEMS_DC_ID FOREIGN KEY(DC_ID)REFERENCES DC_TBL(DC_ID)\r\n";
            q += ", DCITEMS_ID INT(11)  NOT NULL\r\n";
            q += ", PRODUCT_ID INT NOT NULL , CONSTRAINT FK_QUOTATIONITEMS_PRODUCT_ID FOREIGN KEY(PRODUCT_ID)REFERENCES PRODUCT_TBL(PRODUCT_ID)\r\n";
            q += ", SIZES_ID INT NOT NULL , CONSTRAINT FK_QUOTATION_SIZES_ID FOREIGN KEY(SIZES_ID)REFERENCES SIZES_TBL(SIZES_ID)\r\n";
            q += ", QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", PRICE DECIMAL(11,2)  NOT NULL\r\n";
            q += ", CGST_PERCENT DECIMAL(11,2)  NOT NULL\r\n";
            q += ", SGST_PERCENT DECIMAL(11,2)  NOT NULL\r\n";
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

            q += "INSERT INTO  QUOTATION_TBL ( QUOTATION_ID , UNIQUENO , COMPANY_ID , DIV_ID , ACY_ID , QUOTATION_NO , QUOTATION_DATE , PARTY_ID ,TAXTYPE_ID , SALESTYPE_ID , TRANSPORT_ID , DELIVERYTO_ID , BUNDEL, TOTAL_QTY , TOTAL_TAXABLE_AMOUNT , TOTAL_CGST , TOTAL_SGST , TOTAL_IGST , GSTTOTAL , LEDGER_ID , ADDITIONAL , ROUNDS , GRANDTOTAL , REFERED_AMT , LOCKED , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'UNIQUENO' , 1 , 1 , 1 ,0  , '2017-10-02' , 1 ,1,1,1,1,0, 'TOTAL_QTY' , '0' , '0' , '0' , '0' , '0' , 'LEDGER_ID' , '0' , '0' , '0' , 0 , '1' ,'','1','1');\r\n";
            new DAL().Execute(q);

        InsertitemsDefault(_database);

        }
        #endregion[Insert Default]

        #region[Insert items Default]

        public static void InsertitemsDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  QUOTATIONITEMS_TBL ( QUOTATIONITEMS_ID , QUOTATION_ID , QUOTATION_NO , PO_ID ,POITEMS_ID, DC_ID , DCITEMS_ID , PRODUCT_ID , SIZES_ID , QTY , PRICE , CGST_PERCENT , SGST_PERCENT , IGST_PERCENT , REFERED_ID , LOCKED) VALUES \r\n"; 
            q += "( 1 , 1 , '0' , 1 , 1 , 1 , '1' , 1 , 1 , 'QTY' , '0' , '0' , '0' , '0' , 1 , '8');\r\n";

            new DAL().Execute(q);

        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM QUOTATIONITEMS_TBL WHERE QUOTATION_ID <> 1 ;\r\n ";

            q += "DELETE FROM QUOTATION_TBL WHERE QUOTATION_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
