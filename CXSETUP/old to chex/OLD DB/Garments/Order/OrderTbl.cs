// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 08-01-2018 10:25:50 PM
// last update : 08-01-2018

using CXLIB;

namespace CXSETUP
{
    //public class OrderTbl 
    //{
    //    #region[Create Table]

    //    public OrderTbl(string _database)
    //    {
    //        string q = "USE  " + _database + ";\r\n ";

    //        q += "CREATE TABLE IF NOT EXISTS ORDER_TBL(\r\n ";
    //        q += "  ORDER_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_ORDER_ID PRIMARY KEY(ORDER_ID)\r\n";
    //        q += ", YEAR_NO VARCHAR(150)  NOT NULL UNIQUE \r\n";
    //        q += ", COMPANY_ID INT NOT NULL , CONSTRAINT FK_ORDER_COMPANY_ID FOREIGN KEY(COMPANY_ID)REFERENCES COMPANY_TBL(COMPANY_ID)\r\n";
    //        q += ", ORDERTYPE_ID INT NOT NULL , CONSTRAINT FK_ORDER_ORDERTYPE_ID FOREIGN KEY(ORDERTYPE_ID)REFERENCES ORDERTYPE_TBL(ORDERTYPE_ID)\r\n";
    //        q += ", ORDER_NO INT(11) NOT NULL UNIQUE \r\n";
    //        q += ", ORDER_DATE DATE NOT NULL\r\n";
    //        q += ", PARTY_ID INT NOT NULL , CONSTRAINT FK_ORDER_PARTY_ID FOREIGN KEY(PARTY_ID)REFERENCES PARTY_TBL(PARTY_ID)\r\n";
    //        q += ", PARTY_REF VARCHAR(250)  NOT NULL\r\n";
    //        q += ", STYLE_REF VARCHAR(250)  NOT NULL\r\n";
    //        q += ", REFERED_NO VARCHAR(200)  NOT NULL\r\n";
    //        q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
    //        q += ", NOTES VARCHAR(500) NOT NULL\r\n";
    //        q += ", ACTIVE_ID SMALLINT(1) NOT NULL\r\n";
    //        q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_ORDER_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_TBL(USER_ID)\r\n";
    //        q += " );\r\n";
    //        new DAL().Execute(q);

    //    OrderitemsTbl(_database);

    //    }
    //    #endregion[Create Table]

    //    #region[Create Items Table]

    //    public void OrderitemsTbl(string _database)
    //    {
    //        string q = "USE  " + _database + ";\r\n ";

    //        q += "CREATE TABLE IF NOT EXISTS ORDERITEMS_TBL(\r\n ";
    //        q += "  ORDERITEMS_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_ORDERITEMS_ID PRIMARY KEY(ORDERITEMS_ID)\r\n";
    //        q += ", ORDER_ID INT NOT NULL , CONSTRAINT FK_ORDERITEMS_ORDER_ID FOREIGN KEY(ORDER_ID)REFERENCES ORDER_TBL(ORDER_ID)\r\n";
    //        q += ", ORDER_NO INT(11) NOT NULL\r\n";
    //        q += ", PRODUCT_ID INT NOT NULL , CONSTRAINT FK_ORDERITEMS_PRODUCT_ID FOREIGN KEY(PRODUCT_ID)REFERENCES PRODUCT_TBL(PRODUCT_ID)\r\n";
    //        q += ", SIZES_ID INT NOT NULL , CONSTRAINT FK_ORDERITEMS_SIZES_ID FOREIGN KEY(SIZES_ID)REFERENCES SIZES_TBL(SIZES_ID)\r\n";
    //        q += ", QTY VARCHAR(50)  NOT NULL\r\n";
    //        q += ", PRICE DECIMAL(11,2)  NOT NULL\r\n";
    //        q += ", REFERED_ID VARCHAR(200)  NOT NULL\r\n";
    //        q += ", LOCKED SMALLINT(1)  NOT NULL\r\n";
    //        q += " );\r\n";
    //        new DAL().Execute(q);
    //    }
    //    #endregion[Create Items Table]

    //    #region[Insert Default]

    //    public static void InsertDefault(string _database)
    //    {
    //        string q = "USE  " + _database + ";\r\n ";

    //        q += "INSERT INTO  ORDER_TBL ( ORDER_ID , YEAR_NO , COMPANY_ID ,ORDERTYPE_ID,  ORDER_NO , ORDER_DATE , PARTY_ID , PARTY_REF , STYLE_REF , REFERED_NO , LOCKED , NOTES , ACTIVE_ID , USER_ID) VALUES \r\n"; 
    //        q += "( 1 , 'YEAR_NO' , 1 , 1 , '0' , '2018-01-08' , 1 , 'PARTY_REF' , 'STYLE_REF' , 'REFERED_NO' , '1' ,'','1','1');\r\n";
    //        new DAL().Execute(q);

    //    InsertitemsDefault(_database);

    //    }
    //    #endregion[Insert Default]

    //    #region[Insert items Default]

    //    public static void InsertitemsDefault(string _database)
    //    {
    //        string q = "USE  " + _database + ";\r\n ";

    //        q += "INSERT INTO  ORDERITEMS_TBL ( ORDERITEMS_ID , ORDER_ID , ORDER_NO , PRODUCT_ID , SIZES_ID , QTY , PRICE , REFERED_ID , LOCKED) VALUES \r\n"; 
    //        q += "( 1 , 1 , '0' , 1 , 1 , 'QTY' , '0' , 'REFERED_ID' , '8');\r\n";

    //        new DAL().Execute(q);

    //    }
    //    #endregion[Insert Default]

    //    #region[Drop-Truncate]

    //    public static void CleanTbl(string _database)
    //    {
    //        string q = "USE  " + _database + ";\r\n ";

    //        q += "DELETE FROM ORDERITEMS_TBL WHERE ORDER_ID <> 1 ;\r\n ";

    //        q += "DELETE FROM ORDER_TBL WHERE ORDER_ID <> 1 ;\r\n ";

    //        new DAL().Execute(q);
    //    }
    //    #endregion[Drop-Truncate]

    //}//cls
}//ns
