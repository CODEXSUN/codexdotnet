// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:34:52 AM

using CXLIB;

namespace CXCORE
{
    public class CRole
    {

        #region[Get New]

        public static Role GetNew
        {
            get
            {
                Role obj = new Role()
                {
                    Role_id = string.Empty,
                    Role_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Role v)
        {
            q = q.Replace("@" + ROLE.ROLE_ID + "@", "" + ConvertTO.SqlString(v.Role_id) + "");
            q = q.Replace("@" + ROLE.ROLE_NAME + "@", "" + ConvertTO.SqlString(v.Role_name) + "");
            q = q.Replace("@" + ROLE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + ROLE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Role v, DAL dalsession)
        {
            string q = " INSERT INTO " + ROLE.ROLE_TBL + " ( ";
            q += " " + ROLE.ROLE_NAME + " \r\n ";
            q += "," + ROLE.NOTES + " \r\n ";
            q += "," + ROLE.ACTIVE_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + ROLE.ROLE_NAME + "@ \r\n ";
            q += ", @" + ROLE.NOTES + "@ \r\n ";
            q += ", @" + ROLE.ACTIVE_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Role v, DAL dalsession)
        {
            string q = "UPDATE " + ROLE.ROLE_TBL + " SET";
            q += " " + ROLE.ROLE_NAME + " = @" + ROLE.ROLE_NAME + "@ \r\n ";
            q += "," + ROLE.NOTES + " = @" + ROLE.NOTES + "@ \r\n ";
            q += "," + ROLE.ACTIVE_ID + " = @" + ROLE.ACTIVE_ID + "@ \r\n ";
            q += "  WHERE " + ROLE.ROLE_ID + " = @" + ROLE.ROLE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + ROLE.ROLE_TBL + " WHERE " + ROLE.ROLE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
