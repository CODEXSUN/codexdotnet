// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:33 PM

using CXLIB;

namespace CXCORE
{
    public class CCity
    {

        #region[Get New]

        public static City GetNew
        {
            get
            {
                City obj = new City()
                {
                    City_id = string.Empty,
                    City_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, City v)
        {
            q = q.Replace("@" + CITY.CITY_ID + "@", "" + ConvertTO.SqlString(v.City_id) + "");
            q = q.Replace("@" + CITY.CITY_NAME + "@", "" + ConvertTO.SqlString(v.City_name) + "");
            q = q.Replace("@" + CITY.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + CITY.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + CITY.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(City v, DAL dalsession)
        {
                string q = " INSERT INTO " + CITY.CITY_TBL + " ( ";
                q += " " + CITY.CITY_NAME + " \r\n ";
                q += "," + CITY.NOTES + " \r\n ";
                q += "," + CITY.ACTIVE_ID + " \r\n ";
                q += "," + CITY.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ CITY.CITY_NAME + "@ \r\n ";
                q += ", @"+ CITY.NOTES + "@ \r\n ";
                q += ", @"+ CITY.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ CITY.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(City v, DAL dalsession)
        {
                string q = "UPDATE " + CITY.CITY_TBL + " SET";
                q += " " + CITY.CITY_NAME + " = @" + CITY.CITY_NAME + "@ \r\n ";
                q += "," + CITY.NOTES + " = @" + CITY.NOTES + "@ \r\n ";
                q += "," + CITY.ACTIVE_ID + " = @" + CITY.ACTIVE_ID + "@ \r\n ";
                q += "," + CITY.USER_ID + " = @" + CITY.USER_ID + "@ \r\n ";
                q += "  WHERE " + CITY.CITY_ID + " = @" + CITY.CITY_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + CITY.CITY_TBL+ " WHERE " + CITY.CITY_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
