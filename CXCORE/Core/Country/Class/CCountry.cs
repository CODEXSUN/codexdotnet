// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:45:30 AM

using CXLIB;

namespace CXCORE
{
    public class CCountry
    {

        #region[Get New]

        public static Country GetNew
        {
            get
            {
                Country obj = new Country()
                {
                    Country_id = string.Empty,
                    Country_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Country v)
        {
            q = q.Replace("@" + COUNTRY.COUNTRY_ID + "@", "" + ConvertTO.SqlString(v.Country_id) + "");
            q = q.Replace("@" + COUNTRY.COUNTRY_NAME + "@", "" + ConvertTO.SqlString(v.Country_name) + "");
            q = q.Replace("@" + COUNTRY.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + COUNTRY.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + COUNTRY.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Country v, DAL dalsession)
        {
            string q = " INSERT INTO " + COUNTRY.COUNTRY_TBL + " ( ";
            q += " " + COUNTRY.COUNTRY_NAME + " \r\n ";
            q += "," + COUNTRY.NOTES + " \r\n ";
            q += "," + COUNTRY.ACTIVE_ID + " \r\n ";
            q += "," + COUNTRY.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + COUNTRY.COUNTRY_NAME + "@ \r\n ";
            q += ", @" + COUNTRY.NOTES + "@ \r\n ";
            q += ", @" + COUNTRY.ACTIVE_ID + "@ \r\n ";
            q += ", @" + COUNTRY.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Country v, DAL dalsession)
        {
            string q = "UPDATE " + COUNTRY.COUNTRY_TBL + " SET";
            q += " " + COUNTRY.COUNTRY_NAME + " = @" + COUNTRY.COUNTRY_NAME + "@ \r\n ";
            q += "," + COUNTRY.NOTES + " = @" + COUNTRY.NOTES + "@ \r\n ";
            q += "," + COUNTRY.ACTIVE_ID + " = @" + COUNTRY.ACTIVE_ID + "@ \r\n ";
            q += "," + COUNTRY.USER_ID + " = @" + COUNTRY.USER_ID + "@ \r\n ";
            q += "  WHERE " + COUNTRY.COUNTRY_ID + " = @" + COUNTRY.COUNTRY_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + COUNTRY.COUNTRY_TBL + " WHERE " + COUNTRY.COUNTRY_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
