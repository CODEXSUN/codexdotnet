// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:41:08 PM

using CXLIB;

namespace CXCORE
{
    public class CHsncode
    {

        #region[Get New]

        public static Hsncode GetNew
        {
            get
            {
                Hsncode obj = new Hsncode()
                {
                    Hsncode_id = string.Empty,
                    Hsncode_name = string.Empty,
                    Description = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Hsncode v)
        {
            q = q.Replace("@" + HSNCODE.HSNCODE_ID + "@", "" + ConvertTO.SqlString(v.Hsncode_id) + "");
            q = q.Replace("@" + HSNCODE.HSNCODE_NAME + "@", "" + ConvertTO.SqlString(v.Hsncode_name) + "");
            q = q.Replace("@" + HSNCODE.DESCRIPTION + "@", "" + ConvertTO.SqlString(v.Description) + "");
            q = q.Replace("@" + HSNCODE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + HSNCODE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + HSNCODE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Hsncode v, DAL dalsession)
        {
                string q = " INSERT INTO " + HSNCODE.HSNCODE_TBL + " ( ";
                q += " " + HSNCODE.HSNCODE_NAME + " \r\n ";
                q += "," + HSNCODE.DESCRIPTION + " \r\n ";
                q += "," + HSNCODE.NOTES + " \r\n ";
                q += "," + HSNCODE.ACTIVE_ID + " \r\n ";
                q += "," + HSNCODE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ HSNCODE.HSNCODE_NAME + "@ \r\n ";
                q += ", @"+ HSNCODE.DESCRIPTION + "@ \r\n ";
                q += ", @"+ HSNCODE.NOTES + "@ \r\n ";
                q += ", @"+ HSNCODE.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ HSNCODE.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Hsncode v, DAL dalsession)
        {
                string q = "UPDATE " + HSNCODE.HSNCODE_TBL + " SET";
                q += " " + HSNCODE.HSNCODE_NAME + " = @" + HSNCODE.HSNCODE_NAME + "@ \r\n ";
                q += "," + HSNCODE.DESCRIPTION + " = @" + HSNCODE.DESCRIPTION + "@ \r\n ";
                q += "," + HSNCODE.NOTES + " = @" + HSNCODE.NOTES + "@ \r\n ";
                q += "," + HSNCODE.ACTIVE_ID + " = @" + HSNCODE.ACTIVE_ID + "@ \r\n ";
                q += "," + HSNCODE.USER_ID + " = @" + HSNCODE.USER_ID + "@ \r\n ";
                q += "  WHERE " + HSNCODE.HSNCODE_ID + " = @" + HSNCODE.HSNCODE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + HSNCODE.HSNCODE_TBL+ " WHERE " + HSNCODE.HSNCODE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
