using System.Data.SQLite;

namespace AXCODE
{
    public class DB_Setup
    {
        public DB_Setup(string database)
        {

            SQLiteConnection.CreateFile("" + database + ".sqlite");
        }
    }//cls
}//ns