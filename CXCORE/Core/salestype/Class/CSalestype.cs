// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:11:05 AM

using CXLIB;

namespace CXCORE
{
    public class CSalestype
    {

        #region[Get New]

        public static Salestype GetNew
        {
            get
            {
                Salestype obj = new Salestype()
                {
                    Salestype_id = string.Empty,
                    Salestype_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Salestype v)
        {
            q = q.Replace("@" + SALESTYPE.SALESTYPE_ID + "@", "" + ConvertTO.SqlString(v.Salestype_id) + "");
            q = q.Replace("@" + SALESTYPE.SALESTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Salestype_name) + "");
            q = q.Replace("@" + SALESTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + SALESTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + SALESTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Salestype v, DAL dalsession)
        {
            string q = " INSERT INTO " + SALESTYPE.SALESTYPE_TBL + " ( ";
            q += " " + SALESTYPE.SALESTYPE_NAME + " \r\n ";
            q += "," + SALESTYPE.NOTES + " \r\n ";
            q += "," + SALESTYPE.ACTIVE_ID + " \r\n ";
            q += "," + SALESTYPE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + SALESTYPE.SALESTYPE_NAME + "@ \r\n ";
            q += ", @" + SALESTYPE.NOTES + "@ \r\n ";
            q += ", @" + SALESTYPE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + SALESTYPE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Salestype v, DAL dalsession)
        {
            string q = "UPDATE " + SALESTYPE.SALESTYPE_TBL + " SET";
            q += " " + SALESTYPE.SALESTYPE_NAME + " = @" + SALESTYPE.SALESTYPE_NAME + "@ \r\n ";
            q += "," + SALESTYPE.NOTES + " = @" + SALESTYPE.NOTES + "@ \r\n ";
            q += "," + SALESTYPE.ACTIVE_ID + " = @" + SALESTYPE.ACTIVE_ID + "@ \r\n ";
            q += "," + SALESTYPE.USER_ID + " = @" + SALESTYPE.USER_ID + "@ \r\n ";
            q += "  WHERE " + SALESTYPE.SALESTYPE_ID + " = @" + SALESTYPE.SALESTYPE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + SALESTYPE.SALESTYPE_TBL + " WHERE " + SALESTYPE.SALESTYPE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
