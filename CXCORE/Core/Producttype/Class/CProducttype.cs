// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:33:13 PM

using CXLIB;

namespace CXCORE
{
    public class CProducttype
    {

        #region[Get New]

        public static Producttype GetNew
        {
            get
            {
                Producttype obj = new Producttype()
                {
                    Producttype_id = string.Empty,
                    Producttype_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Producttype v)
        {
            q = q.Replace("@" + PRODUCTTYPE.PRODUCTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Producttype_id) + "");
            q = q.Replace("@" + PRODUCTTYPE.PRODUCTTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Producttype_name) + "");
            q = q.Replace("@" + PRODUCTTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PRODUCTTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PRODUCTTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Producttype v, DAL dalsession)
        {
                string q = " INSERT INTO " + PRODUCTTYPE.PRODUCTTYPE_TBL + " ( ";
                q += " " + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n ";
                q += "," + PRODUCTTYPE.NOTES + " \r\n ";
                q += "," + PRODUCTTYPE.ACTIVE_ID + " \r\n ";
                q += "," + PRODUCTTYPE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ PRODUCTTYPE.PRODUCTTYPE_NAME + "@ \r\n ";
                q += ", @"+ PRODUCTTYPE.NOTES + "@ \r\n ";
                q += ", @"+ PRODUCTTYPE.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ PRODUCTTYPE.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Producttype v, DAL dalsession)
        {
                string q = "UPDATE " + PRODUCTTYPE.PRODUCTTYPE_TBL + " SET";
                q += " " + PRODUCTTYPE.PRODUCTTYPE_NAME + " = @" + PRODUCTTYPE.PRODUCTTYPE_NAME + "@ \r\n ";
                q += "," + PRODUCTTYPE.NOTES + " = @" + PRODUCTTYPE.NOTES + "@ \r\n ";
                q += "," + PRODUCTTYPE.ACTIVE_ID + " = @" + PRODUCTTYPE.ACTIVE_ID + "@ \r\n ";
                q += "," + PRODUCTTYPE.USER_ID + " = @" + PRODUCTTYPE.USER_ID + "@ \r\n ";
                q += "  WHERE " + PRODUCTTYPE.PRODUCTTYPE_ID + " = @" + PRODUCTTYPE.PRODUCTTYPE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + PRODUCTTYPE.PRODUCTTYPE_TBL+ " WHERE " + PRODUCTTYPE.PRODUCTTYPE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
