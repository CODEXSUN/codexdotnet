// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:28:28 AM

using CXLIB;

namespace CXCORE
{
    public class CBundle
    {

        #region[Get New]

        public static Bundle GetNew
        {
            get
            {
                Bundle obj = new Bundle()
                {
                    Bundle_id = string.Empty,
                    Bundle_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Bundle v)
        {
            q = q.Replace("@" + BUNDLE.BUNDLE_ID + "@", "" + ConvertTO.SqlString(v.Bundle_id) + "");
            q = q.Replace("@" + BUNDLE.BUNDLE_NAME + "@", "" + ConvertTO.SqlString(v.Bundle_name) + "");
            q = q.Replace("@" + BUNDLE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + BUNDLE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + BUNDLE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Bundle v, DAL dalsession)
        {
            string q = " INSERT INTO " + BUNDLE.BUNDLE_TBL + " ( ";
            q += " " + BUNDLE.BUNDLE_NAME + " \r\n ";
            q += "," + BUNDLE.NOTES + " \r\n ";
            q += "," + BUNDLE.ACTIVE_ID + " \r\n ";
            q += "," + BUNDLE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + BUNDLE.BUNDLE_NAME + "@ \r\n ";
            q += ", @" + BUNDLE.NOTES + "@ \r\n ";
            q += ", @" + BUNDLE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + BUNDLE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Bundle v, DAL dalsession)
        {
            string q = "UPDATE " + BUNDLE.BUNDLE_TBL + " SET";
            q += " " + BUNDLE.BUNDLE_NAME + " = @" + BUNDLE.BUNDLE_NAME + "@ \r\n ";
            q += "," + BUNDLE.NOTES + " = @" + BUNDLE.NOTES + "@ \r\n ";
            q += "," + BUNDLE.ACTIVE_ID + " = @" + BUNDLE.ACTIVE_ID + "@ \r\n ";
            q += "," + BUNDLE.USER_ID + " = @" + BUNDLE.USER_ID + "@ \r\n ";
            q += "  WHERE " + BUNDLE.BUNDLE_ID + " = @" + BUNDLE.BUNDLE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + BUNDLE.BUNDLE_TBL + " WHERE " + BUNDLE.BUNDLE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
