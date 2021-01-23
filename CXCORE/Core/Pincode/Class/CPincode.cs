// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 09:06:45 AM

using CXLIB;

namespace CXCORE
{
    public class CPincode
    {

        #region[Get New]

        public static Pincode GetNew
        {
            get
            {
                Pincode obj = new Pincode()
                {
                    Pincode_id = string.Empty,
                    Pincode_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Pincode v)
        {
            q = q.Replace("@" + PINCODE.PINCODE_ID + "@", "" + ConvertTO.SqlString(v.Pincode_id) + "");
            q = q.Replace("@" + PINCODE.PINCODE_NAME + "@", "" + ConvertTO.SqlString(v.Pincode_name) + "");
            q = q.Replace("@" + PINCODE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PINCODE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PINCODE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Pincode v, DAL dalsession)
        {
            string q = " INSERT INTO " + PINCODE.PINCODE_TBL + " ( ";
            q += " " + PINCODE.PINCODE_NAME + " \r\n ";
            q += "," + PINCODE.NOTES + " \r\n ";
            q += "," + PINCODE.ACTIVE_ID + " \r\n ";
            q += "," + PINCODE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + PINCODE.PINCODE_NAME + "@ \r\n ";
            q += ", @" + PINCODE.NOTES + "@ \r\n ";
            q += ", @" + PINCODE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + PINCODE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Pincode v, DAL dalsession)
        {
            string q = "UPDATE " + PINCODE.PINCODE_TBL + " SET";
            q += " " + PINCODE.PINCODE_NAME + " = @" + PINCODE.PINCODE_NAME + "@ \r\n ";
            q += "," + PINCODE.NOTES + " = @" + PINCODE.NOTES + "@ \r\n ";
            q += "," + PINCODE.ACTIVE_ID + " = @" + PINCODE.ACTIVE_ID + "@ \r\n ";
            q += "," + PINCODE.USER_ID + " = @" + PINCODE.USER_ID + "@ \r\n ";
            q += "  WHERE " + PINCODE.PINCODE_ID + " = @" + PINCODE.PINCODE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + PINCODE.PINCODE_TBL + " WHERE " + PINCODE.PINCODE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
