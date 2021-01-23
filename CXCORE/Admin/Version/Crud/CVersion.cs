// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 10-08-2020 10:29:14 AM

using CXLIB;

namespace CXCORE
{
    public static class CVersion
    {

        #region[Get New]

        public static Version GetNew
        {
            get
            {
                Version obj = new Version()
                {
                    Version_id = string.Empty,
                    Version_name = string.Empty,
                    Created_on = string.Empty,
                    Changes = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Version v)
        {
            q = q.Replace("@" + VERSION.VERSION_ID + "@", "" + ConvertTO.SqlString(v.Version_id) + "");
            q = q.Replace("@" + VERSION.VERSION_NAME + "@", "" + ConvertTO.SqlString(v.Version_name) + "");
            q = q.Replace("@" + VERSION.CREATED_ON + "@", "" + ConvertTO.SqlDate(v.Created_on) + "");
            q = q.Replace("@" + VERSION.CHANGES + "@", "" + ConvertTO.SqlString(v.Changes) + "");
            q = q.Replace("@" + VERSION.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + VERSION.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + VERSION.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Version v, DAL dalsession)
        {
            string q = " INSERT INTO " + VERSION.VERSION_TBL + " ( ";
            q += " " + VERSION.VERSION_NAME + " \r\n ";
            q += "," + VERSION.CREATED_ON + " \r\n ";
            q += "," + VERSION.CHANGES + " \r\n ";
            q += "," + VERSION.NOTES + " \r\n ";
            q += "," + VERSION.ACTIVE_ID + " \r\n ";
            q += "," + VERSION.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + VERSION.VERSION_NAME + "@ \r\n ";
                q += ", @" + VERSION.CREATED_ON + "@ \r\n ";
                q += ", @" + VERSION.CHANGES + "@ \r\n ";
            q += ", @" + VERSION.NOTES + "@ \r\n ";
            q += ", @" + VERSION.ACTIVE_ID + "@ \r\n ";
            q += ", @" + VERSION.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Version v, DAL dalsession)
        {
            string q = "UPDATE " + VERSION.VERSION_TBL + " SET";
            q += " " + VERSION.VERSION_NAME + " = @" + VERSION.VERSION_NAME + "@ \r\n ";
            q += "," + VERSION.CREATED_ON + " = @" + VERSION.CREATED_ON + "@ \r\n ";
            q += "," + VERSION.CHANGES + " = @" + VERSION.CHANGES + "@ \r\n ";
            q += "," + VERSION.NOTES + " = @" + VERSION.NOTES + "@ \r\n ";
            q += "," + VERSION.ACTIVE_ID + " = @" + VERSION.ACTIVE_ID + "@ \r\n ";
            q += "," + VERSION.USER_ID + " = @" + VERSION.USER_ID + "@ \r\n ";
            q += "  WHERE " + VERSION.VERSION_ID + " = @" + VERSION.VERSION_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + VERSION.VERSION_TBL + " WHERE " + VERSION.VERSION_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
