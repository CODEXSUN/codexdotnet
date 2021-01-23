// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 08.01.05 PM

using CXLIB;

namespace CXCORE
{
    public class CContacttype
    {

        #region[Get New]

        public static Contacttype GetNew
        {
            get
            {
                Contacttype obj = new Contacttype()
                {
                    Contacttype_id = string.Empty,
                    Contacttype_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Contacttype v)
        {
            q = q.Replace("@" + CONTACTTYPE.CONTACTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Contacttype_id) + "");
            q = q.Replace("@" + CONTACTTYPE.CONTACTTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Contacttype_name) + "");
            q = q.Replace("@" + CONTACTTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + CONTACTTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + CONTACTTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Contacttype v, DAL dalsession)
        {
                string q = " INSERT INTO " + CONTACTTYPE.CONTACTTYPE_TBL + " ( ";
                q += " " + CONTACTTYPE.CONTACTTYPE_NAME + " \r\n ";
                q += "," + CONTACTTYPE.NOTES + " \r\n ";
                q += "," + CONTACTTYPE.ACTIVE_ID + " \r\n ";
                q += "," + CONTACTTYPE.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ CONTACTTYPE.CONTACTTYPE_NAME + "@ \r\n ";
                q += ", @"+ CONTACTTYPE.NOTES + "@ \r\n ";
                q += ", @"+ CONTACTTYPE.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ CONTACTTYPE.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Contacttype v, DAL dalsession)
        {
                string q = "UPDATE " + CONTACTTYPE.CONTACTTYPE_TBL + " SET";
                q += " " + CONTACTTYPE.CONTACTTYPE_NAME + " = @" + CONTACTTYPE.CONTACTTYPE_NAME + "@ \r\n ";
                q += "," + CONTACTTYPE.NOTES + " = @" + CONTACTTYPE.NOTES + "@ \r\n ";
                q += "," + CONTACTTYPE.ACTIVE_ID + " = @" + CONTACTTYPE.ACTIVE_ID + "@ \r\n ";
                q += "," + CONTACTTYPE.USER_ID + " = @" + CONTACTTYPE.USER_ID + "@ \r\n ";
                q += "  WHERE " + CONTACTTYPE.CONTACTTYPE_ID + " = @" + CONTACTTYPE.CONTACTTYPE_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + CONTACTTYPE.CONTACTTYPE_TBL+ " WHERE " + CONTACTTYPE.CONTACTTYPE_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
