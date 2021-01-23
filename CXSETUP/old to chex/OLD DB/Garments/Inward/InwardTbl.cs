// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 08-01-2018 10:25:50 PM
// last update : 08-01-2018

using CXLIB;

namespace CXSETUP
{
    public class InwardTbl 
    {
        #region[Create Table]

        public InwardTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS INWARD_TBL(\r\n ";
            q += "  INWARD_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_INWARD_ID PRIMARY KEY(INWARD_ID)\r\n";
            q += ", YEAR_NO VARCHAR(150)  NOT NULL UNIQUE \r\n";
            q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_INWARD_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
            q += ", INWARD_NO INT(11)  NOT NULL\r\n";
            q += ", INWARD_DATE DATE NOT NULL\r\n";
            q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_INWARD_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
            q += ", ORDER_ID INT NOT NULL , CONSTRAINT FK_INWARD_ORDER_ID FOREIGN KEY(ORDER_ID)REFERENCES ORDER_TBL(ORDER_ID)\r\n";
            q += ", TOTAL_QTY VARCHAR(50)  NOT NULL\r\n";
            q += ", REFERED_NO VARCHAR(200)  NOT NULL\r\n";
            q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
            q += ", NOTES VARCHAR(500) NOT NULL\r\n";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_INWARD_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
            q += " );\r\n";
            new DAL().Execute(q);

        InwarditemsTbl(_database);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void InwarditemsTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "CREATE TABLE IF NOT EXISTS INWARDITEMS_TBL(\r\n ";
            q += "  INWARDITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_INWARDITEMS_ID PRIMARY KEY(INWARDITEMS_ID)\r\n";
            q += ", INWARD_ID INT NOT NULL , CONSTRAINT FK_INWARDITEMS_INWARD_ID FOREIGN KEY(INWARD_ID)REFERENCES INWARD_TBL(INWARD_ID)\r\n";
            q += ", INWARD_NO INT(11)  NOT NULL\r\n";
            q += ", PRODUCT_ID INT NOT NULL , CONSTRAINT FK_INWARDITEMS_PRODUCT_ID FOREIGN KEY(PRODUCT_ID)REFERENCES PRODUCT_TBL(PRODUCT_ID)\r\n";
            q += ", SIZES_ID INT NOT NULL , CONSTRAINT FK_INWARDITEMS_SIZES_ID FOREIGN KEY(SIZES_ID)REFERENCES SIZES_TBL(SIZES_ID)\r\n";
            q += ", QTY VARCHAR(50)  NOT NULL\r\n";
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

            q += "INSERT INTO  INWARD_TBL ( INWARD_ID , YEAR_NO , COMPANY_ID , INWARD_NO , INWARD_DATE , PARTY_ID , ORDER_ID , TOTAL_QTY , REFERED_NO , LOCKED , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
            q += "( 1 , 'YEAR_NO' , 1 , '0' , '2018-01-08' , 1 , 1 , 'TOTAL_QTY' , 'REFERED_NO' , '1' ,'','1','1');\r\n";
            new DAL().Execute(q);

        InsertitemsDefault(_database);

        }
        #endregion[Insert Default]

        #region[Insert items Default]

        public static void InsertitemsDefault(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "INSERT INTO  INWARDITEMS_TBL ( INWARDITEMS_ID , INWARD_ID , INWARD_NO , PRODUCT_ID , SIZES_ID , QTY , REFERED_ID , LOCKED) VALUES \r\n"; 
            q += "( 1 , 1 , '0' , 1 , 1 , 'QTY' , 'REFERED_ID' , '8');\r\n";

            new DAL().Execute(q);

        }
        #endregion[Insert Default]

        #region[Drop-Truncate]

        public static void CleanTbl(string _database)
        {
            string q = "USE  " + _database + ";\r\n ";

            q += "DELETE FROM INWARDITEMS_TBL WHERE INWARD_ID <> 1 ;\r\n ";

            q += "DELETE FROM INWARD_TBL WHERE INWARD_ID <> 1 ;\r\n ";

            new DAL().Execute(q);
        }
        #endregion[Drop-Truncate]

    }//cls
}//ns
