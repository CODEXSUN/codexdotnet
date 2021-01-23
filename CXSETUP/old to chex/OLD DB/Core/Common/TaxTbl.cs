using CXLIB;
namespace CXSETUP
{
   public class TaxTbl
    {
       public TaxTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
            q += "CREATE TABLE IF NOT EXISTS TAX_Tbl ( \r\n ";
            q += "  TAX_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_TAX_ID PRIMARY KEY(TAX_ID) \r\n ";
            q += ", TAX_TYPE VARCHAR(250)  NOT NULL UNIQUE\r\n ";
            q += ", TAX_PERCENT DECIMAL(10,2)  NOT NULL \r\n ";
            q += ", TAX_VALUE DECIMAL(10,2)  NOT NULL \r\n ";
            q += ", NOTES VARCHAR(200) NOT NULL \r\n ";
            q += ", ACTIVE_ID SMALLINT(1) NOT NULL \r\n ";
            q += ", USER_ID  INT NOT NULL, CONSTRAINT FK_TAX_USER_ID FOREIGN KEY(USER_ID)REFERENCES USER_Tbl ( USER_ID) \r\n ";
            q += " ); \r\n ";
          
            new DAL().Execute(q);
        }

        public static void InsertDefault ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
            q += "INSERT INTO TAX_Tbl ( TAX_ID , TAX_TYPE , TAX_PERCENT , TAX_VALUE , NOTES , ACTIVE_ID , USER_ID ) values \r\n ";
            q += " (1,'Vat @ 5%','5.00','100.00','',1,1) \r\n ";
            q += ",(2,'CST @ 1%','0.00','100.00','',1,1) \r\n ";
            q += ",(3,'Excemption TAX','0.00','100.00','These Goods are exempted from Tax by section 15, Fourth schedule, Part-A item no .8(VI) and item no 10.',1,1) \r\n ";
            q += "; \r\n ";
            new DAL().Execute(q);
        }

        public static void CleanTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
            q += "DELETE FROM TAX_Tbl; \r\n";
            q += "TRUNCATE TABLE TAX_Tbl;\r\n";
            new DAL().Execute(q);
        }
      
    }//cls
}//ns
