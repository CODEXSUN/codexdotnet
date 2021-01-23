// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:46:35 AM

using CXLIB;

namespace CXCORE
{
    public class CDeliveredto
    {

        #region[Get New]

        public static Deliveredto GetNew
        {
            get
            {
                Deliveredto obj = new Deliveredto()
                {
                    Deliveredto_id = string.Empty,
                    Deliveredto_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Deliveredto v)
        {
            q = q.Replace("@" + DELIVEREDTO.DELIVEREDTO_ID + "@", "" + ConvertTO.SqlString(v.Deliveredto_id) + "");
            q = q.Replace("@" + DELIVEREDTO.DELIVEREDTO_NAME + "@", "" + ConvertTO.SqlString(v.Deliveredto_name) + "");
            q = q.Replace("@" + DELIVEREDTO.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + DELIVEREDTO.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + DELIVEREDTO.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Deliveredto v, DAL dalsession)
        {
            string q = " INSERT INTO " + DELIVEREDTO.DELIVEREDTO_TBL + " ( ";
            q += " " + DELIVEREDTO.DELIVEREDTO_NAME + " \r\n ";
            q += "," + DELIVEREDTO.NOTES + " \r\n ";
            q += "," + DELIVEREDTO.ACTIVE_ID + " \r\n ";
            q += "," + DELIVEREDTO.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + DELIVEREDTO.DELIVEREDTO_NAME + "@ \r\n ";
            q += ", @" + DELIVEREDTO.NOTES + "@ \r\n ";
            q += ", @" + DELIVEREDTO.ACTIVE_ID + "@ \r\n ";
            q += ", @" + DELIVEREDTO.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Deliveredto v, DAL dalsession)
        {
            string q = "UPDATE " + DELIVEREDTO.DELIVEREDTO_TBL + " SET";
            q += " " + DELIVEREDTO.DELIVEREDTO_NAME + " = @" + DELIVEREDTO.DELIVEREDTO_NAME + "@ \r\n ";
            q += "," + DELIVEREDTO.NOTES + " = @" + DELIVEREDTO.NOTES + "@ \r\n ";
            q += "," + DELIVEREDTO.ACTIVE_ID + " = @" + DELIVEREDTO.ACTIVE_ID + "@ \r\n ";
            q += "," + DELIVEREDTO.USER_ID + " = @" + DELIVEREDTO.USER_ID + "@ \r\n ";
            q += "  WHERE " + DELIVEREDTO.DELIVEREDTO_ID + " = @" + DELIVEREDTO.DELIVEREDTO_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + DELIVEREDTO.DELIVEREDTO_TBL + " WHERE " + DELIVEREDTO.DELIVEREDTO_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
