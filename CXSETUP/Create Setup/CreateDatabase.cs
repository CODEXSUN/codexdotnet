using CXLIB;

namespace CXSETUP
{
    public class DB_Setup
    {
        public static void CreateDatabase(string db)
        {
            string q = "CREATE DATABASE /*!32312 IF NOT EXISTS*/ " + db + " /*!40100 DEFAULT CHARACTER SET latin1 */; \r\n";
            q += " \r\n";
            new SYS_DAL().Execute(q);
        }

        public static void DropDatabase(string db)
        {
            string q = "DROP DATABASE IF EXISTS " + db + "; \r\n";
            new SYS_DAL().Execute(q);
        }

    }
}
