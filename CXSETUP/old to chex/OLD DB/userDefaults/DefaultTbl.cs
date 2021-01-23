using CXLIB;

namespace CXSETUP
{
    public class DefaultCompanyTbl
    {
        public DefaultCompanyTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
           
            q += "CREATE TABLE IF NOT EXISTS DEFAULT_CMP ( \r\n";
            q += "  DEFAULT_CMP_ID INT(11) NOT NULL AUTO_INCREMENT, CONSTRAINT PK_DEFAULT_CMP PRIMARY KEY(DEFAULT_CMP_ID) \r\n";
            q += ", COMPANY_ID VARCHAR(15) NOT NULL \r\n";
            q += " ); \r\n ";
           
            new DAL().Execute(q);
        }

        public static void InsertDefault(string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
           
            q += "INSERT INTO  DEFAULT_CMP ( DEFAULT_CMP_ID , COMPANY_ID ) VALUES  \r\n";
            q += " (1, '1' ); \r\n";
            q += " \r\n ";
           
            new DAL().Execute(q);
        }

        public static void CleanTbl ( string _database)
        {
            string q = "USE  " + _database + " ; \r\n ";
           
            q += "DELETE FROM DEFAULT_CMP; \r\n";
            q += "TRUNCATE TABLE DEFAULT_CMP;\r\n";
            new DAL().Execute(q);
        }
    }
}
