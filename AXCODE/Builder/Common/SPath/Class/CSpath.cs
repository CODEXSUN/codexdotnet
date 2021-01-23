// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using CXLIB;

namespace AXCODE
{
    public class CSpath
    {

        #region[Get New]

        public static Spath GetNew
        {
            get
            {
                Spath obj = new Spath()
                {
                    Spath_id = string.Empty,
                    Stables_id = string.Empty,
                    Root_folder = string.Empty,
                    Contfolder = string.Empty,
                    Classfolder = string.Empty,
                    Formfolder = string.Empty,
                    Listfolder = string.Empty,
                    Setupfolder = string.Empty,
                    Testfolder = string.Empty,
                    Active_id = Core.Active,
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Spath v)
        {
            q = q.Replace("@" + SPATH.SPATH_ID + "@", "" + ConvertTO.SqlString(v.Spath_id) + "");
            q = q.Replace("@" + SPATH.STABLES_ID + "@", "" + ConvertTO.SqlString(v.Stables_id) + "");
            q = q.Replace("@" + SPATH.ROOT_FOLDER + "@", "" + ConvertTO.SqlString(v.Root_folder) + "");
            q = q.Replace("@" + SPATH.CONTFOLDER + "@", "" + ConvertTO.SqlString(v.Contfolder) + "");
            q = q.Replace("@" + SPATH.CLASSFOLDER + "@", "" + ConvertTO.SqlString(v.Classfolder) + "");
            q = q.Replace("@" + SPATH.FORMFOLDER + "@", "" + ConvertTO.SqlString(v.Formfolder) + "");
            q = q.Replace("@" + SPATH.LISTFOLDER + "@", "" + ConvertTO.SqlString(v.Listfolder) + "");
            q = q.Replace("@" + SPATH.SETUPFOLDER + "@", "" + ConvertTO.SqlString(v.Setupfolder) + "");
            q = q.Replace("@" + SPATH.TESTFOLDER + "@", "" + ConvertTO.SqlString(v.Testfolder) + "");
            q = q.Replace("@" + SPATH.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Spath v, SQLITE_DAL dalsession)
        {
            string q = " INSERT INTO " + SPATH.SPATH_TBL + " ( ";
            q += " " + SPATH.STABLES_ID + " \r\n ";
            q += "," + SPATH.ROOT_FOLDER + " \r\n ";
            q += "," + SPATH.CONTFOLDER + " \r\n ";
            q += "," + SPATH.CLASSFOLDER + " \r\n ";
            q += "," + SPATH.FORMFOLDER + " \r\n ";
            q += "," + SPATH.LISTFOLDER + " \r\n ";
            q += "," + SPATH.SETUPFOLDER + " \r\n ";
            q += "," + SPATH.TESTFOLDER + " \r\n ";
            q += "," + SPATH.ACTIVE_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + SPATH.STABLES_ID + "@ \r\n ";
            q += ", @" + SPATH.ROOT_FOLDER + "@ \r\n ";
            q += ", @" + SPATH.CONTFOLDER + "@ \r\n ";
            q += ", @" + SPATH.CLASSFOLDER + "@ \r\n ";
            q += ", @" + SPATH.FORMFOLDER + "@ \r\n ";
            q += ", @" + SPATH.LISTFOLDER + "@ \r\n ";
            q += ", @" + SPATH.SETUPFOLDER + "@ \r\n ";
            q += ", @" + SPATH.TESTFOLDER + "@ \r\n ";
            q += ", @" + SPATH.ACTIVE_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Spath v, SQLITE_DAL dalsession)
        {
            string q = "UPDATE " + SPATH.SPATH_TBL + " SET";
            q += " " + SPATH.STABLES_ID + " = @" + SPATH.STABLES_ID + "@ \r\n ";
            q += "," + SPATH.ROOT_FOLDER + " = @" + SPATH.ROOT_FOLDER + "@ \r\n ";
            q += "," + SPATH.CONTFOLDER + " = @" + SPATH.CONTFOLDER + "@ \r\n ";
            q += "," + SPATH.CLASSFOLDER + " = @" + SPATH.CLASSFOLDER + "@ \r\n ";
            q += "," + SPATH.FORMFOLDER + " = @" + SPATH.FORMFOLDER + "@ \r\n ";
            q += "," + SPATH.LISTFOLDER + " = @" + SPATH.LISTFOLDER + "@ \r\n ";
            q += "," + SPATH.SETUPFOLDER + " = @" + SPATH.SETUPFOLDER + "@ \r\n ";
            q += "," + SPATH.TESTFOLDER + " = @" + SPATH.TESTFOLDER + "@ \r\n ";
            q += "," + SPATH.ACTIVE_ID + " = @" + SPATH.ACTIVE_ID + "@ \r\n ";
            q += "  WHERE " + SPATH.SPATH_ID + " = @" + SPATH.SPATH_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, SQLITE_DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + SPATH.SPATH_TBL + " WHERE " + SPATH.SPATH_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
