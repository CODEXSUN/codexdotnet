// Version : 3 dt : 01-08-2017
// Auto Generated
// 01-10-2017 09:52:50 PM
// last update : 01-10-2017

using CXLIB;

namespace CXSETUP
{
    public class DcTbl 
    {
        #region[Create Table]

        public DcTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS DC_TBL(\r\n ";
            q += "  DC_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_DC_ID PRIMARY KEY(DC_ID)\r\n";
            q += ", YEAR_NO VARCHAR(150)  NOT NULL UNIQUE \r\n";
            q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_DC_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
            q += ", DC_NO INT(11)  NOT NULL\r\n";
            q += ", DC_DATE DATE NOT NULL\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_DC_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", TOTAL_QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", REFERED_NO VARCHAR(200)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_DC_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);

        DcitemsTbl(_database);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void DcitemsTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS DCITEMS_TBL(\r\n ";
            q += "  DCITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_DCITEMS_ID PRIMARY KEY(DCITEMS_ID)\r\n";
            q += ", DC_ID INT NOT NULL , CONSTRAINT FK_DCITEMS_DC_ID FOREIGN KEY(DC_ID)REFERENCES DC_TBL(DC_ID)\r\n";
            q += ", DC_NO INT(11)  NOT NULL\r\n";
            q += ", PO_ID INT NOT NULL , CONSTRAINT FK_DCITEMS_PO_ID FOREIGN KEY(PO_ID)REFERENCES PO_TBL(PO_ID)\r\n";
            q += ", POITEMS_ID INT(11)  NOT NULL\r\n";
            q += ", PRODUCT_ID INT NOT NULL , CONSTRAINT FK_DCITEMS_PRODUCT_ID FOREIGN KEY(PRODUCT_ID)REFERENCES PRODUCT_TBL(PRODUCT_ID)\r\n";
            q += ", QTY VARCHAR(50)  NOT NULL\r\n";
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

            q += "INSERT INTO  DC_TBL ( DC_ID , YEAR_NO , COMPANY_ID , DC_NO , DC_DATE , PARTY_ID , TOTAL_QTY , REFERED_NO , LOCKED , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'YEAR_NO' , 1 , '0' , '2017-10-01' , 1 , 'TOTAL_QTY' , 'REFERED_NO' , '1' ,'','1','1');\r\n";
            new DAL().Execute(q);

        InsertitemsDefault(_database);

        }
        #endregion[Insert Default]

        #region[Insert items Default]

        public static void InsertitemsDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  DCITEMS_TBL ( DCITEMS_ID , DC_ID , DC_NO , PO_ID , POITEMS_ID , PRODUCT_ID , QTY , REFERED_QTY , LOCKED) VALUES \r\n"; 
            q += "( 1 , 1 , '0' , 1 , '1' , 1 , 'QTY' , 'REFERED_QTY' , '8');\r\n";

            new DAL().Execute(q);

        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM DCITEMS_TBL WHERE DC_ID <> 1 ;\r\n ";

            q += "DELETE FROM DC_TBL WHERE DC_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
