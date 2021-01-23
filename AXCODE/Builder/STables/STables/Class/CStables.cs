// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 18-11-2018 07:25:37 PM

using CXLIB;

namespace AXCODE
{
    public class CStables
    {

        #region[Get New]

        public static Stables GetNew
        {
            get
            {
                Stables obj = new Stables()
                {
                    Stables_id = string.Empty,
                    Stables_name = string.Empty,
                    Alias = string.Empty,
                    Namespaces_id = string.Empty,
                    Databases_id = string.Empty,
                    Active_id = Core.Active,
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Stables v)
        {
            q = q.Replace("@" + STABLES.STABLES_ID + "@", "" + ConvertTO.SqlString(v.Stables_id) + "");
            q = q.Replace("@" + STABLES.STABLES_NAME + "@", "" + ConvertTO.SqlString(v.Stables_name) + "");
            q = q.Replace("@" + STABLES.ALIAS + "@", "" + ConvertTO.SqlString(v.Alias) + "");
            q = q.Replace("@" + STABLES.NAMESPACES_ID + "@", "" + ConvertTO.SqlString(v.Namespaces_id) + "");
            q = q.Replace("@" + STABLES.DATABASES_ID + "@", "" + ConvertTO.SqlString(v.Databases_id) + "");
            q = q.Replace("@" + STABLES.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Stables v, SQLITE_DAL dalsession)
        {
            string q = " INSERT INTO " + STABLES.STABLES_TBL + " ( ";
            q += " " + STABLES.STABLES_NAME + " \r\n ";
            q += "," + STABLES.ALIAS + " \r\n ";
            q += "," + STABLES.NAMESPACES_ID + " \r\n ";
            q += "," + STABLES.DATABASES_ID + " \r\n ";
            q += "," + STABLES.ACTIVE_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + STABLES.STABLES_NAME + "@ \r\n ";
            q += ", @" + STABLES.ALIAS + "@ \r\n ";
            q += ", @" + STABLES.NAMESPACES_ID + "@ \r\n ";
            q += ", @" + STABLES.DATABASES_ID + "@ \r\n ";
            q += ", @" + STABLES.ACTIVE_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Stables v, SQLITE_DAL dalsession)
        {
            string q = "UPDATE " + STABLES.STABLES_TBL + " SET";
            q += " " + STABLES.STABLES_NAME + " = @" + STABLES.STABLES_NAME + "@ \r\n ";
            q += "," + STABLES.ALIAS + " = @" + STABLES.ALIAS + "@ \r\n ";
            q += "," + STABLES.NAMESPACES_ID + " = @" + STABLES.NAMESPACES_ID + "@ \r\n ";
            q += "," + STABLES.DATABASES_ID + " = @" + STABLES.DATABASES_ID + "@ \r\n ";
            q += "," + STABLES.ACTIVE_ID + " = @" + STABLES.ACTIVE_ID + "@ \r\n ";
            q += "  WHERE " + STABLES.STABLES_ID + " = @" + STABLES.STABLES_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, SQLITE_DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + STABLES.STABLES_TBL + " WHERE " + STABLES.STABLES_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
