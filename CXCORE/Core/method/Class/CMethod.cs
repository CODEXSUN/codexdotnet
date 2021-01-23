// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 25-12-2017 08:21:03 PM

using CXLIB;

namespace CXCORE
{
    public class CMethod
    {

        #region[Get New]

        public static Method GetNew
        {
            get
            {
                Method obj = new Method()
                {
                    Method_id = string.Empty,
                    Method_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Method v)
        {
            q = q.Replace("@" + METHOD.METHOD_ID + "@", "" + ConvertTO.SqlString(v.Method_id) + "");
            q = q.Replace("@" + METHOD.METHOD_NAME + "@", "" + ConvertTO.SqlString(v.Method_name) + "");
            q = q.Replace("@" + METHOD.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + METHOD.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + METHOD.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Method v, DAL dalsession)
        {
                string q = " INSERT INTO " + METHOD.METHOD_TBL + " ( ";
                q += " " + METHOD.METHOD_NAME + " \r\n ";
                q += "," + METHOD.NOTES + " \r\n ";
                q += "," + METHOD.ACTIVE_ID + " \r\n ";
                q += "," + METHOD.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ METHOD.METHOD_NAME + "@ \r\n ";
                q += ", @"+ METHOD.NOTES + "@ \r\n ";
                q += ", @"+ METHOD.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ METHOD.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Method v, DAL dalsession)
        {
                string q = "UPDATE " + METHOD.METHOD_TBL + " SET";
                q += " " + METHOD.METHOD_NAME + " = @" + METHOD.METHOD_NAME + "@ \r\n ";
                q += "," + METHOD.NOTES + " = @" + METHOD.NOTES + "@ \r\n ";
                q += "," + METHOD.ACTIVE_ID + " = @" + METHOD.ACTIVE_ID + "@ \r\n ";
                q += "," + METHOD.USER_ID + " = @" + METHOD.USER_ID + "@ \r\n ";
                q += "  WHERE " + METHOD.METHOD_ID + " = @" + METHOD.METHOD_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + METHOD.METHOD_TBL+ " WHERE " + METHOD.METHOD_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
