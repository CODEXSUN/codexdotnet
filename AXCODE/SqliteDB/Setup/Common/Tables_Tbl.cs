namespace AXCODE
{
    public class Tables_Tbl
    {

        public Tables_Tbl()
        {
            string q = "CREATE TABLE IF NOT EXISTS TABLES_TBL( \r\n ";
            q += "TABLES_ID INTEGER  PRIMARY KEY AUTOINCREMENT,\r\n ";
            q += "DATABASES_ID INTEGER  NOT NULL, \r\n ";
            q += "TABLES_NAME TEXT  NOT NULL,  \r\n ";
            q += "TABLES_ALIAS TEXT  NOT NULL,  \r\n ";
            q += "CREATEDON TEXT NOT NULL, \r\n ";
            q += "NOTES TEXT NOT NULL, \r\n ";
            q += "ACTIVE_ID TEXT NOT NULL, \r\n ";
            q += "USER_ID  INTEGER  NOT NULL \r\n ";
            q += " ); \r\n ";
            new SQLITE_DAL().Execute(q);

            Tableitems_Tbl();
        }


        private void  Tableitems_Tbl()
        {
            string q = "CREATE TABLE IF NOT EXISTS TABLEITEM_TBL( \r\n ";
            q += "TABLEITEM_ID INTEGER  PRIMARY KEY AUTOINCREMENT, \r\n ";
            q += "FIELDS TEXT  NOT NULL, \r\n ";
            q += "TABLES_ID INTEGER  NOT NULL , \r\n ";
            q += "DISPLAY_NAME TEXT  NOT NULL, \r\n ";
            q += "DATATYPE TEXT NOT NULL , \r\n ";
            q += "LENGTHS TEXT NOT NULL, \r\n ";
            q += "PKEYS TEXT NOT NULL , \r\n ";
            q += "IFNULL TEXT NOT NULL, \r\n ";
            q += "REFERED_TBL TEXT  NOT NULL, \r\n ";
            q += "INPUTTYPE TEXT NOT NULL , \r\n ";
            q += "WIDTH TEXT NOT NULL, \r\n ";
            q += "HEIGHT TEXT NOT NULL , \r\n ";
            q += "CPOSITION TEXT NOT NULL, \r\n ";
            q += "VALIDATE TEXT NOT NULL , \r\n ";
            q += "ISDEFAULT TEXT NOT NULL, \r\n ";
            q += "PLACEMENT TEXT NOT NULL , \r\n ";
            q += "NOTES TEXT NOT NULL, \r\n ";
            q += "ACTIVE_ID TEXT NOT NULL, \r\n ";
            q += "USER_ID  INTEGER  NOT NULL \r\n ";
            q += " ); \r\n ";
            new SQLITE_DAL().Execute(q);
        }

    }//cls
}//ns