// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 05-12-2018 10:49:05 AM

using CXLIB;

namespace AXCODE
{
    public class CMtables
    {

        #region[Get New]

        public static MasterTables GetNew
        {
            get
            {
                MasterTables obj = new MasterTables()
                {
                    Mastertables_id = string.Empty,
                    Databases_id = string.Empty,
                    Mastertables_name = string.Empty,
                    Alias = string.Empty,
                    Namespaces_id = string.Empty,
                    Active_id = Core.Active,
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, MasterTables v)
        {
            q = q.Replace("@" + MASTERTABLES.MASTERTABLES_ID + "@", "" + ConvertTO.SqlString(v.Mastertables_id) + "");
            q = q.Replace("@" + MASTERTABLES.DATABASES_ID + "@", "" + ConvertTO.SqlString(v.Databases_id) + "");
            q = q.Replace("@" + MASTERTABLES.MASTERTABLES_NAME + "@", "" + ConvertTO.SqlString(v.Mastertables_name) + "");
            q = q.Replace("@" + MASTERTABLES.ALIAS + "@", "" + ConvertTO.SqlString(v.Alias) + "");
            q = q.Replace("@" + MASTERTABLES.NAMESPACES_ID + "@", "" + ConvertTO.SqlString(v.Namespaces_id) + "");
            q = q.Replace("@" + MASTERTABLES.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(MasterTables v, SQLITE_DAL dalsession)
        {
            string q = " INSERT INTO " + MASTERTABLES.MASTERTABLES_TBL + " ( ";
            q += " " + MASTERTABLES.DATABASES_ID + " \r\n";
            q += "," + MASTERTABLES.MASTERTABLES_NAME + " \r\n";
            q += "," + MASTERTABLES.ALIAS + " \r\n";
            q += "," + MASTERTABLES.NAMESPACES_ID + " \r\n";
            q += "," + MASTERTABLES.ACTIVE_ID + " \r\n";
            q += " ) VALUES ( ";
            q += "  @" + MASTERTABLES.DATABASES_ID + "@ \r\n";
            q += ", @" + MASTERTABLES.MASTERTABLES_NAME + "@ \r\n";
            q += ", @" + MASTERTABLES.ALIAS + "@ \r\n";
            q += ", @" + MASTERTABLES.NAMESPACES_ID + "@ \r\n";
            q += ", @" + MASTERTABLES.ACTIVE_ID + "@ \r\n";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(MasterTables v, SQLITE_DAL dalsession)
        {
            string q = "UPDATE " + MASTERTABLES.MASTERTABLES_TBL + " SET";
            q += " " + MASTERTABLES.DATABASES_ID + " = @" + MASTERTABLES.DATABASES_ID + "@ \r\n ";
            q += "," + MASTERTABLES.MASTERTABLES_NAME + " = @" + MASTERTABLES.MASTERTABLES_NAME + "@ \r\n ";
            q += "," + MASTERTABLES.ALIAS + " = @" + MASTERTABLES.ALIAS + "@ \r\n ";
            q += "," + MASTERTABLES.NAMESPACES_ID + " = @" + MASTERTABLES.NAMESPACES_ID + "@ \r\n ";
            q += "," + MASTERTABLES.ACTIVE_ID + " = @" + MASTERTABLES.ACTIVE_ID + "@ \r\n ";
            q += "  WHERE " + MASTERTABLES.MASTERTABLES_ID + " = @" + MASTERTABLES.MASTERTABLES_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, SQLITE_DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + MASTERTABLES.MASTERTABLES_TBL + " WHERE " + MASTERTABLES.MASTERTABLES_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
