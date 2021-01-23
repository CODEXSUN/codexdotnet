// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 07:45:49 PM

using CXLIB;

namespace CXCORE
{
    public class CVouchertype
    {

        #region[Get New]

        public static Vouchertype GetNew
        {
            get
            {
                Vouchertype obj = new Vouchertype()
                {
                    Vouchertype_id = string.Empty,
                    Vouchertype_name = string.Empty,
                    Method_id = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Vouchertype v)
        {
            q = q.Replace("@" + VOUCHERTYPE.VOUCHERTYPE_ID + "@", "" + ConvertTO.SqlString(v.Vouchertype_id) + "");
            q = q.Replace("@" + VOUCHERTYPE.VOUCHERTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Vouchertype_name) + "");
            q = q.Replace("@" + VOUCHERTYPE.METHOD_ID + "@", "" + ConvertTO.SqlString(v.Method_id) + "");
            q = q.Replace("@" + VOUCHERTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + VOUCHERTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + VOUCHERTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Vouchertype v, DAL dalsession)
        {
                string q = " INSERT INTO " + VOUCHERTYPE.VOUCHERTYPE_TBL + " ( ";
                q += " " + VOUCHERTYPE.VOUCHERTYPE_NAME + " \r\n ";
                q += "," + VOUCHERTYPE.METHOD_ID + " \r\n ";
                q += "," + VOUCHERTYPE.NOTES + " \r\n ";
                q += "," + VOUCHERTYPE.ACTIVE_ID + " \r\n ";
                q += "," + VOUCHERTYPE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ VOUCHERTYPE.VOUCHERTYPE_NAME + "@ \r\n ";
                q += ", @"+ VOUCHERTYPE.METHOD_ID + "@ \r\n ";
                q += ", @"+ VOUCHERTYPE.NOTES + "@ \r\n ";
                q += ", @"+ VOUCHERTYPE.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ VOUCHERTYPE.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Vouchertype v, DAL dalsession)
        {
                string q = "UPDATE " + VOUCHERTYPE.VOUCHERTYPE_TBL + " SET";
                q += " " + VOUCHERTYPE.VOUCHERTYPE_NAME + " = @" + VOUCHERTYPE.VOUCHERTYPE_NAME + "@ \r\n ";
                q += "," + VOUCHERTYPE.METHOD_ID + " = @" + VOUCHERTYPE.METHOD_ID + "@ \r\n ";
                q += "," + VOUCHERTYPE.NOTES + " = @" + VOUCHERTYPE.NOTES + "@ \r\n ";
                q += "," + VOUCHERTYPE.ACTIVE_ID + " = @" + VOUCHERTYPE.ACTIVE_ID + "@ \r\n ";
                q += "," + VOUCHERTYPE.USER_ID + " = @" + VOUCHERTYPE.USER_ID + "@ \r\n ";
                q += "  WHERE " + VOUCHERTYPE.VOUCHERTYPE_ID + " = @" + VOUCHERTYPE.VOUCHERTYPE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + VOUCHERTYPE.VOUCHERTYPE_TBL+ " WHERE " + VOUCHERTYPE.VOUCHERTYPE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
