// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 22-03-2019 12:58:24 PM

using CXLIB;

namespace CXCORE
{
    public class CDefaultlogin
    {

        #region[Attach params]

        private static string AttachParams(string q, Defaultlogin v)
        {
            q = q.Replace("@" + DEFAULTLOGIN.DEFAULTLOGIN_ID + "@", "" + ConvertTO.SqlString(v.Defaultlogin_id) + "");
            q = q.Replace("@" + DEFAULTLOGIN.DEFAULTLOGIN_NAME + "@", "" + ConvertTO.SqlString(v.Defaultlogin_name) + "");
            q = q.Replace("@" + DEFAULTLOGIN.DEFAULT_PASSWORD + "@", "" + ConvertTO.SqlString(v.Default_password) + "");
            q = q.Replace("@" + DEFAULTLOGIN.CREATEON + "@", "" + ConvertTO.SqlDateTime(v.Createon) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Defaultlogin v, DAL dalsession)
        {
            string q = " INSERT INTO " + DEFAULTLOGIN.DEFAULTLOGIN_TBL + " ( ";
            q += " " + DEFAULTLOGIN.DEFAULTLOGIN_ID + " \r\n ";
            q += "," + DEFAULTLOGIN.DEFAULTLOGIN_NAME + " \r\n ";
            q += "," + DEFAULTLOGIN.DEFAULT_PASSWORD + " \r\n ";
            q += "," + DEFAULTLOGIN.CREATEON + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + DEFAULTLOGIN.DEFAULTLOGIN_ID + "@ \r\n ";
            q += ", @" + DEFAULTLOGIN.DEFAULTLOGIN_NAME + "@ \r\n ";
            q += ", @" + DEFAULTLOGIN.DEFAULT_PASSWORD + "@ \r\n ";
            q += ", @" + DEFAULTLOGIN.CREATEON + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Defaultlogin v, DAL dalsession)
        {
            string q = "UPDATE " + DEFAULTLOGIN.DEFAULTLOGIN_TBL + " SET";
            q += " " + DEFAULTLOGIN.DEFAULTLOGIN_NAME + " = @" + DEFAULTLOGIN.DEFAULTLOGIN_NAME + "@ \r\n ";
            q += "," + DEFAULTLOGIN.DEFAULT_PASSWORD + " = @" + DEFAULTLOGIN.DEFAULT_PASSWORD + "@ \r\n ";
            q += "," + DEFAULTLOGIN.CREATEON + " = @" + DEFAULTLOGIN.CREATEON + "@ \r\n ";
            q += "  WHERE " + DEFAULTLOGIN.DEFAULTLOGIN_ID + " = @" + DEFAULTLOGIN.DEFAULTLOGIN_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + DEFAULTLOGIN.DEFAULTLOGIN_TBL + " WHERE " + DEFAULTLOGIN.DEFAULTLOGIN_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
