// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 06-12-2018 10:53:54 PM

using CXLIB;

namespace AXCODE
{
    public class CMpath
    {

        #region[Get New]

        public static MasterTablePath GetNew
        {
            get
            {
                MasterTablePath obj = new MasterTablePath()
                {
                    Masterpath_id = string.Empty,
                    Mastertables_id = string.Empty,
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

        private static string AttachParams(string q, MasterTablePath v)
        {
            q = q.Replace("@" + MASTERPATH.MASTERPATH_ID + "@", "" + ConvertTO.SqlString(v.Masterpath_id) + "");
            q = q.Replace("@" + MASTERPATH.MASTERTABLES_ID + "@", "" + ConvertTO.SqlString(v.Mastertables_id) + "");
            q = q.Replace("@" + MASTERPATH.ROOT_FOLDER + "@", "" + ConvertTO.SqlString(v.Root_folder) + "");
            q = q.Replace("@" + MASTERPATH.CONTFOLDER + "@", "" + ConvertTO.SqlString(v.Contfolder) + "");
            q = q.Replace("@" + MASTERPATH.CLASSFOLDER + "@", "" + ConvertTO.SqlString(v.Classfolder) + "");
            q = q.Replace("@" + MASTERPATH.FORMFOLDER + "@", "" + ConvertTO.SqlString(v.Formfolder) + "");
            q = q.Replace("@" + MASTERPATH.LISTFOLDER + "@", "" + ConvertTO.SqlString(v.Listfolder) + "");
            q = q.Replace("@" + MASTERPATH.SETUPFOLDER + "@", "" + ConvertTO.SqlString(v.Setupfolder) + "");
            q = q.Replace("@" + MASTERPATH.TESTFOLDER + "@", "" + ConvertTO.SqlString(v.Testfolder) + "");
            q = q.Replace("@" + MASTERPATH.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(MasterTablePath v, SQLITE_DAL dalsession)
        {
            string q = " INSERT INTO " + MASTERPATH.MASTERPATH_TBL + " ( ";
            q += " " + MASTERPATH.MASTERTABLES_ID + " \r\n ";
            q += "," + MASTERPATH.ROOT_FOLDER + " \r\n ";
            q += "," + MASTERPATH.CONTFOLDER + " \r\n ";
            q += "," + MASTERPATH.CLASSFOLDER + " \r\n ";
            q += "," + MASTERPATH.FORMFOLDER + " \r\n ";
            q += "," + MASTERPATH.LISTFOLDER + " \r\n ";
            q += "," + MASTERPATH.SETUPFOLDER + " \r\n ";
            q += "," + MASTERPATH.TESTFOLDER + " \r\n ";
            q += "," + MASTERPATH.ACTIVE_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + MASTERPATH.MASTERTABLES_ID + "@ \r\n ";
            q += ", @" + MASTERPATH.ROOT_FOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.CONTFOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.CLASSFOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.FORMFOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.LISTFOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.SETUPFOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.TESTFOLDER + "@ \r\n ";
            q += ", @" + MASTERPATH.ACTIVE_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(MasterTablePath v, SQLITE_DAL dalsession)
        {
            string q = "UPDATE " + MASTERPATH.MASTERPATH_TBL + " SET";
            q += " " + MASTERPATH.MASTERTABLES_ID + " = @" + MASTERPATH.MASTERTABLES_ID + "@ \r\n ";
            q += "," + MASTERPATH.ROOT_FOLDER + " = @" + MASTERPATH.ROOT_FOLDER + "@ \r\n ";
            q += "," + MASTERPATH.CONTFOLDER + " = @" + MASTERPATH.CONTFOLDER + "@ \r\n ";
            q += "," + MASTERPATH.CLASSFOLDER + " = @" + MASTERPATH.CLASSFOLDER + "@ \r\n ";
            q += "," + MASTERPATH.FORMFOLDER + " = @" + MASTERPATH.FORMFOLDER + "@ \r\n ";
            q += "," + MASTERPATH.LISTFOLDER + " = @" + MASTERPATH.LISTFOLDER + "@ \r\n ";
            q += "," + MASTERPATH.SETUPFOLDER + " = @" + MASTERPATH.SETUPFOLDER + "@ \r\n ";
            q += "," + MASTERPATH.TESTFOLDER + " = @" + MASTERPATH.TESTFOLDER + "@ \r\n ";
            q += "," + MASTERPATH.ACTIVE_ID + " = @" + MASTERPATH.ACTIVE_ID + "@ \r\n ";
            q += "  WHERE " + MASTERPATH.MASTERPATH_ID + " = @" + MASTERPATH.MASTERPATH_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, SQLITE_DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + MASTERPATH.MASTERPATH_TBL + " WHERE " + MASTERPATH.MASTERPATH_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
