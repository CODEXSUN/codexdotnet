// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 15-05-2019 06:44:13 PM

using CXLIB;

namespace CXCORE
{
    public class COrdertype
    {

        #region[Get New]

        public static Ordertype GetNew
        {
            get
            {
                Ordertype obj = new Ordertype()
                {
                    Ordertype_id = string.Empty,
                    Ordertype_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Ordertype v)
        {
            q = q.Replace("@" + ORDERTYPE.ORDERTYPE_ID + "@", "" + ConvertTO.SqlString(v.Ordertype_id) + "");
            q = q.Replace("@" + ORDERTYPE.ORDERTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Ordertype_name) + "");
            q = q.Replace("@" + ORDERTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + ORDERTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + ORDERTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Ordertype v, DAL dalsession)
        {
                string q = " INSERT INTO " + ORDERTYPE.ORDERTYPE_TBL + " ( ";
                q += " " + ORDERTYPE.ORDERTYPE_NAME + " \r\n ";
                q += "," + ORDERTYPE.NOTES + " \r\n ";
                q += "," + ORDERTYPE.ACTIVE_ID + " \r\n ";
                q += "," + ORDERTYPE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ ORDERTYPE.ORDERTYPE_NAME + "@ \r\n ";
                q += ", @"+ ORDERTYPE.NOTES + "@ \r\n ";
                q += ", @"+ ORDERTYPE.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ ORDERTYPE.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Ordertype v, DAL dalsession)
        {
                string q = "UPDATE " + ORDERTYPE.ORDERTYPE_TBL + " SET";
                q += " " + ORDERTYPE.ORDERTYPE_NAME + " = @" + ORDERTYPE.ORDERTYPE_NAME + "@ \r\n ";
                q += "," + ORDERTYPE.NOTES + " = @" + ORDERTYPE.NOTES + "@ \r\n ";
                q += "," + ORDERTYPE.ACTIVE_ID + " = @" + ORDERTYPE.ACTIVE_ID + "@ \r\n ";
                q += "," + ORDERTYPE.USER_ID + " = @" + ORDERTYPE.USER_ID + "@ \r\n ";
                q += "  WHERE " + ORDERTYPE.ORDERTYPE_ID + " = @" + ORDERTYPE.ORDERTYPE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + ORDERTYPE.ORDERTYPE_TBL+ " WHERE " + ORDERTYPE.ORDERTYPE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
