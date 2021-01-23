namespace AXCODE
{
    class QSQLite
    {

        public static string CREATE(string v)
        {
            return "CREATE TABLE IF NOT EXISTS " + v + "(\r\n";
        }

        public static string PRIMARY(string v)
        {
            return v + " INTEGER  PRIMARY KEY AUTOINCREMENT\r\n";
        }

        public static string INTEGER(string v)
        {
            return ", " + v + " INTEGER NOT NULL\r\n";
        }

        public static string TEXT(string v)
        {
            return ", " + v + " TEXT NOT NULL\r\n";
        }

        public static string EOF
        {
            get { return ");\r\n"; }
            
        }

    }
}
