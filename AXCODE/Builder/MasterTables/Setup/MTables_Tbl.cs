namespace AXCODE
{
    public class MTables_Tbl
    {

        public MTables_Tbl()
        {
            string q = QSQLite.CREATE(MASTERTABLES.MASTERTABLES_TBL);
            q += QSQLite.PRIMARY(MASTERTABLES.MASTERTABLES_ID);
            q += QSQLite.TEXT(MASTERTABLES.MASTERTABLES_NAME);
            q += QSQLite.TEXT(MASTERTABLES.ALIAS);
            q += QSQLite.INTEGER(MASTERTABLES.NAMESPACES_ID);
            q += QSQLite.INTEGER(MASTERTABLES.DATABASES_ID);
            q += QSQLite.INTEGER(MASTERTABLES.ACTIVE_ID);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
            MFields_Tbl();
        }


        private void MFields_Tbl()
        {
            string q = QSQLite.CREATE(MASTERTABLESITEMS.MASTERTABLESITEMS_TBL);
            q += QSQLite.PRIMARY(MASTERTABLESITEMS.MASTERTABLESITEMS_ID);
            q += QSQLite.INTEGER(MASTERTABLESITEMS.MASTERTABLES_ID);
            q += QSQLite.TEXT(MASTERTABLESITEMS.FIELDSNAME);
            q += QSQLite.TEXT(MASTERTABLESITEMS.DISPLAYNAME);
            q += QSQLite.TEXT(MASTERTABLESITEMS.DATATYPE);
            q += QSQLite.TEXT(MASTERTABLESITEMS.INPUTTYPE);
            q += QSQLite.TEXT(MASTERTABLESITEMS.WIDTH);
            q += QSQLite.TEXT(MASTERTABLESITEMS.HEIGHT);
            q += QSQLite.TEXT(MASTERTABLESITEMS.CPOSITION);
            q += QSQLite.TEXT(MASTERTABLESITEMS.RPOSITION);
            q += QSQLite.TEXT(MASTERTABLESITEMS.VALIDATE);
            q += QSQLite.TEXT(MASTERTABLESITEMS.ISDEFAULT);
            q += QSQLite.TEXT(MASTERTABLESITEMS.PLACEMENT);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
            MPath_tbl();
        }


        private void MPath_tbl()
        {
            string q = QSQLite.CREATE(MASTERPATH.MASTERPATH_TBL);
            q += QSQLite.PRIMARY(MASTERPATH.MASTERPATH_ID);
            q += QSQLite.INTEGER(MASTERPATH.MASTERTABLES_ID);
            q += QSQLite.TEXT(MASTERPATH.CONTFOLDER);
            q += QSQLite.TEXT(MASTERPATH.CLASSFOLDER);
            q += QSQLite.TEXT(MASTERPATH.FORMFOLDER);
            q += QSQLite.TEXT(MASTERPATH.LISTFOLDER);
            q += QSQLite.TEXT(MASTERPATH.SETUPFOLDER);
            q += QSQLite.TEXT(MASTERPATH.TESTFOLDER);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
        }




    }//cls
}//ns