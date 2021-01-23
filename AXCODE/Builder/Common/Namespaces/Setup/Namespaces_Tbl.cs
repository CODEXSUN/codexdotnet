namespace AXCODE
{
    public class Namespaces_Tbl
    {

        public Namespaces_Tbl()
        {
            string q = QSQLite.CREATE(NAMESPACES.NAMESPACES_TBL);
            q += QSQLite.PRIMARY(NAMESPACES.NAMESPACES_ID);
            q += QSQLite.TEXT(NAMESPACES.NAMESPACES_NAME);
            q += QSQLite.TEXT(NAMESPACES.ACTIVE_ID);
            q += QSQLite.TEXT(NAMESPACES.NOTES);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
        }

    }//cls
}//ns