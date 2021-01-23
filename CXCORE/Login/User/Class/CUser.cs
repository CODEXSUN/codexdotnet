// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:37:39 AM

using CXLIB;

namespace CXCORE
{
    public class CUser
    {

        #region[Get New]

        public static User GetNew
        {
            get
            {
                User obj = new User()
                {
                    User_id = string.Empty,
                    User_name = string.Empty,
                    User_password = string.Empty,
                    Createon = string.Empty,
                    Role_id = string.Empty,
                    Entryby = Current.User,
                    Notes = string.Empty,
                    Active_id = Core.Active
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, User v)
        {
            q = q.Replace("@" + USER.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            q = q.Replace("@" + USER.USER_NAME + "@", "" + ConvertTO.SqlString(v.User_name) + "");
            q = q.Replace("@" + USER.USER_PASSWORD + "@", "" + ConvertTO.SqlString(v.User_password) + "");
            q = q.Replace("@" + USER.CREATEON + "@", "" + ConvertTO.SqlDateTime(v.Createon) + "");
            q = q.Replace("@" + USER.ROLE_ID + "@", "" + ConvertTO.SqlString(v.Role_id) + "");
            q = q.Replace("@" + USER.ENTRYBY + "@", "" + ConvertTO.SqlString(v.Entryby) + "");
            q = q.Replace("@" + USER.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + USER.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(User v, DAL dalsession)
        {
            string q = " INSERT INTO " + USER.USER_TBL + " ( ";
            q += " " + USER.USER_NAME + " \r\n ";
            q += "," + USER.USER_PASSWORD + " \r\n ";
            q += "," + USER.CREATEON + " \r\n ";
            q += "," + USER.ROLE_ID + " \r\n ";
            q += "," + USER.ENTRYBY + " \r\n ";
            q += "," + USER.NOTES + " \r\n ";
            q += "," + USER.ACTIVE_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + USER.USER_NAME + "@ \r\n ";
            q += ", @" + USER.USER_PASSWORD + "@ \r\n ";
            q += ", @" + USER.CREATEON + "@ \r\n ";
            q += ", @" + USER.ROLE_ID + "@ \r\n ";
            q += ", @" + USER.ENTRYBY + "@ \r\n ";
            q += ", @" + USER.NOTES + "@ \r\n ";
            q += ", @" + USER.ACTIVE_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(User v, DAL dalsession)
        {
            string q = "UPDATE " + USER.USER_TBL + " SET";
            q += " " + USER.USER_NAME + " = @" + USER.USER_NAME + "@ \r\n ";
            q += "," + USER.USER_PASSWORD + " = @" + USER.USER_PASSWORD + "@ \r\n ";
            q += "," + USER.CREATEON + " = @" + USER.CREATEON + "@ \r\n ";
            q += "," + USER.ROLE_ID + " = @" + USER.ROLE_ID + "@ \r\n ";
            q += "," + USER.ENTRYBY + " = @" + USER.ENTRYBY + "@ \r\n ";
            q += "," + USER.NOTES + " = @" + USER.NOTES + "@ \r\n ";
            q += "," + USER.ACTIVE_ID + " = @" + USER.ACTIVE_ID + "@ \r\n ";
            q += "  WHERE " + USER.USER_ID + " = @" + USER.USER_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + USER.USER_TBL + " WHERE " + USER.USER_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
