// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 08:01:31 AM

using CXLIB;

namespace CXCORE
{
    public static class CShipping
    {

        #region[Get New]

        public static Shipping GetNew
        {
            get
            {
                Shipping obj = new Shipping()
                {
                    Shipping_id = string.Empty,
                    Shipping_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Shipping v)
        {
            q = q.Replace("@" + SHIPPING.SHIPPING_ID + "@", "" + ConvertTO.SqlString(v.Shipping_id) + "");
            q = q.Replace("@" + SHIPPING.SHIPPING_NAME + "@", "" + ConvertTO.SqlString(v.Shipping_name) + "");
            q = q.Replace("@" + SHIPPING.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + SHIPPING.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + SHIPPING.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Shipping v, DAL dalsession)
        {
            string q = " INSERT INTO " + SHIPPING.SHIPPING_TBL + " ( ";
            q += " " + SHIPPING.SHIPPING_NAME + " \r\n ";
            q += "," + SHIPPING.NOTES + " \r\n ";
            q += "," + SHIPPING.ACTIVE_ID + " \r\n ";
            q += "," + SHIPPING.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + SHIPPING.SHIPPING_NAME + "@ \r\n ";
            q += ", @" + SHIPPING.NOTES + "@ \r\n ";
            q += ", @" + SHIPPING.ACTIVE_ID + "@ \r\n ";
            q += ", @" + SHIPPING.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Shipping v, DAL dalsession)
        {
            string q = "UPDATE " + SHIPPING.SHIPPING_TBL + " SET";
            q += " " + SHIPPING.SHIPPING_NAME + " = @" + SHIPPING.SHIPPING_NAME + "@ \r\n ";
            q += "," + SHIPPING.NOTES + " = @" + SHIPPING.NOTES + "@ \r\n ";
            q += "," + SHIPPING.ACTIVE_ID + " = @" + SHIPPING.ACTIVE_ID + "@ \r\n ";
            q += "," + SHIPPING.USER_ID + " = @" + SHIPPING.USER_ID + "@ \r\n ";
            q += "  WHERE " + SHIPPING.SHIPPING_ID + " = @" + SHIPPING.SHIPPING_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + SHIPPING.SHIPPING_TBL + " WHERE " + SHIPPING.SHIPPING_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
