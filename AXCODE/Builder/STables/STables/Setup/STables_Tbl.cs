namespace AXCODE
{
    public class STables_Tbl
    {

        public STables_Tbl()
        {
            string q = QSQLite.CREATE(STABLES.STABLES_TBL);
            q += QSQLite.PRIMARY(STABLES.STABLES_ID);
            q += QSQLite.TEXT(STABLES.STABLES_NAME);
            q += QSQLite.TEXT(STABLES.ALIAS);
            q += QSQLite.INTEGER(STABLES.NAMESPACES_ID);
            q += QSQLite.INTEGER(STABLES.DATABASES_ID);
            q += QSQLite.INTEGER(STABLES.ACTIVE_ID);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
            SFields_Tbl();
        }


        private void SFields_Tbl()
        {
            string q = QSQLite.CREATE(SFIELDS.SFIELDS_TBL);
            q += QSQLite.PRIMARY(SFIELDS.SFIELDS_ID);
            q += QSQLite.INTEGER(SFIELDS.STABLES_ID);
            q += QSQLite.TEXT(SFIELDS.FIELDSNAME);
            q += QSQLite.TEXT(SFIELDS.DISPLAY_NAME);
            q += QSQLite.TEXT(SFIELDS.DATATYPE);
            //q += QSQLite.TEXT(SFIELDS.LENGTHS);
            //q += QSQLite.TEXT(SFIELDS.PKEYS);
            //q += QSQLite.TEXT(SFIELDS.IFNULL);
            //q += QSQLite.TEXT(SFIELDS.REFEREDTBL);
            q += QSQLite.TEXT(SFIELDS.INPUTTYPE);
            q += QSQLite.TEXT(SFIELDS.WIDTH);
            q += QSQLite.TEXT(SFIELDS.HEIGHT);
            q += QSQLite.TEXT(SFIELDS.CPOSITION);
            q += QSQLite.TEXT(SFIELDS.RPOSITION);
            q += QSQLite.TEXT(SFIELDS.VALIDATE);
            q += QSQLite.TEXT(SFIELDS.ISDEFAULT);
            q += QSQLite.TEXT(SFIELDS.PLACEMENT);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
            SFieldsItems_Tbl();
        }

        private void SFieldsItems_Tbl()
        {
            string q = QSQLite.CREATE(SFIELDSITEMS.SFIELDSITEMS_TBL);
            q += QSQLite.PRIMARY(SFIELDSITEMS.SFIELDSITEMS_ID);
            q += QSQLite.INTEGER(SFIELDSITEMS.STABLES_ID);
            q += QSQLite.TEXT(SFIELDSITEMS.FIELDSNAME);
            q += QSQLite.TEXT(SFIELDSITEMS.DISPLAY_NAME);
            q += QSQLite.TEXT(SFIELDSITEMS.DATATYPE);
            //q += QSQLite.TEXT(SFIELDSITEMS.LENGTHS);
            //q += QSQLite.TEXT(SFIELDSITEMS.PKEYS);
            //q += QSQLite.TEXT(SFIELDSITEMS.IFNULL);
            //q += QSQLite.TEXT(SFIELDSITEMS.REFEREDTBL);
            q += QSQLite.TEXT(SFIELDSITEMS.INPUTTYPE);
            q += QSQLite.TEXT(SFIELDSITEMS.WIDTH);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
            SPath_tbl();
        }

        private void SPath_tbl()
        {
            string q = QSQLite.CREATE(SPATH.SPATH_TBL);
            q += QSQLite.PRIMARY(SPATH.SPATH_ID);
            q += QSQLite.INTEGER(SPATH.STABLES_ID);
            q += QSQLite.TEXT(SPATH.CONTFOLDER);
            q += QSQLite.TEXT(SPATH.CLASSFOLDER);
            q += QSQLite.TEXT(SPATH.FORMFOLDER);
            q += QSQLite.TEXT(SPATH.LISTFOLDER);
            q += QSQLite.TEXT(SPATH.SETUPFOLDER);
            q += QSQLite.TEXT(SPATH.TESTFOLDER);
            q += QSQLite.EOF;
            new SQLITE_DAL().Execute(q);
        }




    }//cls
}//ns