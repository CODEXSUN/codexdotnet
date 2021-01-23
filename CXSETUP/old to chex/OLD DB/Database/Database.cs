using CXLIB;

namespace CXSETUP
{
    public class Database
    {
        public Database(string _database)
        {
            string q = "DROP DATABASE IF EXISTS " + _database + "; \r\n";
            q += "CREATE DATABASE /*!32312 IF NOT EXISTS*/ " + _database + "  /*!40100 DEFAULT CHARACTER SET latin1 */; \r\n";
            q += " \r\n";
            new SYS_DAL().Execute(q);
        }
    }
}
