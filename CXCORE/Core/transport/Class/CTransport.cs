// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:56 AM

using CXLIB;

namespace CXCORE
{
    public class CTransport
    {

        #region[Get New]

        public static Transport GetNew
        {
            get
            {
                Transport obj = new Transport()
                {
                    Transport_id = string.Empty,
                    Transport_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Transport v)
        {
            q = q.Replace("@" + TRANSPORT.TRANSPORT_ID + "@", "" + ConvertTO.SqlString(v.Transport_id) + "");
            q = q.Replace("@" + TRANSPORT.TRANSPORT_NAME + "@", "" + ConvertTO.SqlString(v.Transport_name) + "");
            q = q.Replace("@" + TRANSPORT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + TRANSPORT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + TRANSPORT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Transport v, DAL dalsession)
        {
            string q = " INSERT INTO " + TRANSPORT.TRANSPORT_TBL + " ( ";
            q += " " + TRANSPORT.TRANSPORT_NAME + " \r\n ";
            q += "," + TRANSPORT.NOTES + " \r\n ";
            q += "," + TRANSPORT.ACTIVE_ID + " \r\n ";
            q += "," + TRANSPORT.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + TRANSPORT.TRANSPORT_NAME + "@ \r\n ";
            q += ", @" + TRANSPORT.NOTES + "@ \r\n ";
            q += ", @" + TRANSPORT.ACTIVE_ID + "@ \r\n ";
            q += ", @" + TRANSPORT.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Transport v, DAL dalsession)
        {
            string q = "UPDATE " + TRANSPORT.TRANSPORT_TBL + " SET";
            q += " " + TRANSPORT.TRANSPORT_NAME + " = @" + TRANSPORT.TRANSPORT_NAME + "@ \r\n ";
            q += "," + TRANSPORT.NOTES + " = @" + TRANSPORT.NOTES + "@ \r\n ";
            q += "," + TRANSPORT.ACTIVE_ID + " = @" + TRANSPORT.ACTIVE_ID + "@ \r\n ";
            q += "," + TRANSPORT.USER_ID + " = @" + TRANSPORT.USER_ID + "@ \r\n ";
            q += "  WHERE " + TRANSPORT.TRANSPORT_ID + " = @" + TRANSPORT.TRANSPORT_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + TRANSPORT.TRANSPORT_TBL + " WHERE " + TRANSPORT.TRANSPORT_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
