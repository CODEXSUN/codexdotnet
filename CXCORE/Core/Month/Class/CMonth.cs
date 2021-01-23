// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-10-2019 10:05:59 AM

using CXLIB;

namespace CXCORE
{
    public class CMonth
    {

        #region[Get New]

        public static Month GetNew
        {
            get
            {
                Month obj = new Month()
                {
                    Month_id = string.Empty,
                    Month_name = string.Empty,
                    Month_starts = string.Empty,
                    Month_ends = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Month v)
        {
            q = q.Replace("@" + MONTH.MONTH_ID + "@", "" + ConvertTO.SqlString(v.Month_id) + "");
            q = q.Replace("@" + MONTH.MONTH_NAME + "@", "" + ConvertTO.SqlString(v.Month_name) + "");
            q = q.Replace("@" + MONTH.MONTH_STARTS + "@", "" + ConvertTO.SqlDate(v.Month_starts) + "");
            q = q.Replace("@" + MONTH.MONTH_ENDS + "@", "" + ConvertTO.SqlDate(v.Month_ends) + "");
            q = q.Replace("@" + MONTH.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + MONTH.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + MONTH.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Month v, DAL dalsession)
        {
                string q = " INSERT INTO " + MONTH.MONTH_TBL + " ( ";
                q += " " + MONTH.MONTH_NAME + " \r\n ";
                q += "," + MONTH.MONTH_STARTS + " \r\n ";
                q += "," + MONTH.MONTH_ENDS + " \r\n ";
                q += "," + MONTH.NOTES + " \r\n ";
                q += "," + MONTH.ACTIVE_ID + " \r\n ";
                q += "," + MONTH.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ MONTH.MONTH_NAME + "@ \r\n ";
                q += ", @"+ MONTH.MONTH_STARTS + "@ \r\n ";
                q += ", @"+ MONTH.MONTH_ENDS + "@ \r\n ";
                q += ", @"+ MONTH.NOTES + "@ \r\n ";
                q += ", @"+ MONTH.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ MONTH.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Month v, DAL dalsession)
        {
                string q = "UPDATE " + MONTH.MONTH_TBL + " SET";
                q += " " + MONTH.MONTH_NAME + " = @" + MONTH.MONTH_NAME + "@ \r\n ";
                q += "," + MONTH.MONTH_STARTS + " = @" + MONTH.MONTH_STARTS + "@ \r\n ";
                q += "," + MONTH.MONTH_ENDS + " = @" + MONTH.MONTH_ENDS + "@ \r\n ";
                q += "," + MONTH.NOTES + " = @" + MONTH.NOTES + "@ \r\n ";
                q += "," + MONTH.ACTIVE_ID + " = @" + MONTH.ACTIVE_ID + "@ \r\n ";
                q += "," + MONTH.USER_ID + " = @" + MONTH.USER_ID + "@ \r\n ";
                q += "  WHERE " + MONTH.MONTH_ID + " = @" + MONTH.MONTH_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + MONTH.MONTH_TBL+ " WHERE " + MONTH.MONTH_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
