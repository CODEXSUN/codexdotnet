// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:15:22 AM

using CXLIB;

namespace CXCORE
{
    public class CSizes
    {

        #region[Get New]

        public static Sizes GetNew
        {
            get
            {
                Sizes obj = new Sizes()
                {
                    Sizes_id = string.Empty,
                    Sizes_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Sizes v)
        {
            q = q.Replace("@" + SIZES.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + SIZES.SIZES_NAME + "@", "" + ConvertTO.SqlString(v.Sizes_name) + "");
            q = q.Replace("@" + SIZES.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + SIZES.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + SIZES.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Sizes v, DAL dalsession)
        {
            string q = " INSERT INTO " + SIZES.SIZES_TBL + " ( ";
            q += " " + SIZES.SIZES_NAME + " \r\n ";
            q += "," + SIZES.NOTES + " \r\n ";
            q += "," + SIZES.ACTIVE_ID + " \r\n ";
            q += "," + SIZES.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + SIZES.SIZES_NAME + "@ \r\n ";
            q += ", @" + SIZES.NOTES + "@ \r\n ";
            q += ", @" + SIZES.ACTIVE_ID + "@ \r\n ";
            q += ", @" + SIZES.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Sizes v, DAL dalsession)
        {
            string q = "UPDATE " + SIZES.SIZES_TBL + " SET";
            q += " " + SIZES.SIZES_NAME + " = @" + SIZES.SIZES_NAME + "@ \r\n ";
            q += "," + SIZES.NOTES + " = @" + SIZES.NOTES + "@ \r\n ";
            q += "," + SIZES.ACTIVE_ID + " = @" + SIZES.ACTIVE_ID + "@ \r\n ";
            q += "," + SIZES.USER_ID + " = @" + SIZES.USER_ID + "@ \r\n ";
            q += "  WHERE " + SIZES.SIZES_ID + " = @" + SIZES.SIZES_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + SIZES.SIZES_TBL + " WHERE " + SIZES.SIZES_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
