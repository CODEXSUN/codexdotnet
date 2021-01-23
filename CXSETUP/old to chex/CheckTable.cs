using System.Data;
using CXLIB;

namespace CXSETUP
{
    public class Check
    {
        public static bool Table(string vtbl, string vdatabase)
        {

            string q = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" + vtbl + "' AND TABLE_SCHEMA = '" + vdatabase + "';";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    return true;
                }
            }

                return false;
        }

    }
}
