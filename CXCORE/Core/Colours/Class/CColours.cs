// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 08:38:20 AM

using CXLIB;

namespace CXCORE
{
    public class CColours
    {

        #region[Get New]

        public static Colours GetNew
        {
            get
            {
                Colours obj = new Colours()
                {
                    Colours_id = string.Empty,
                    Colours_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Colours v)
        {
            q = q.Replace("@" + COLOURS.COLOURS_ID + "@", "" + ConvertTO.SqlString(v.Colours_id) + "");
            q = q.Replace("@" + COLOURS.COLOURS_NAME + "@", "" + ConvertTO.SqlString(v.Colours_name) + "");
            q = q.Replace("@" + COLOURS.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + COLOURS.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + COLOURS.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Colours v, DAL dalsession)
        {
            string q = " INSERT INTO " + COLOURS.COLOURS_TBL + " ( ";
            q += " " + COLOURS.COLOURS_NAME + " \r\n ";
            q += "," + COLOURS.NOTES + " \r\n ";
            q += "," + COLOURS.ACTIVE_ID + " \r\n ";
            q += "," + COLOURS.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + COLOURS.COLOURS_NAME + "@ \r\n ";
            q += ", @" + COLOURS.NOTES + "@ \r\n ";
            q += ", @" + COLOURS.ACTIVE_ID + "@ \r\n ";
            q += ", @" + COLOURS.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Colours v, DAL dalsession)
        {
            string q = "UPDATE " + COLOURS.COLOURS_TBL + " SET";
            q += " " + COLOURS.COLOURS_NAME + " = @" + COLOURS.COLOURS_NAME + "@ \r\n ";
            q += "," + COLOURS.NOTES + " = @" + COLOURS.NOTES + "@ \r\n ";
            q += "," + COLOURS.ACTIVE_ID + " = @" + COLOURS.ACTIVE_ID + "@ \r\n ";
            q += "," + COLOURS.USER_ID + " = @" + COLOURS.USER_ID + "@ \r\n ";
            q += "  WHERE " + COLOURS.COLOURS_ID + " = @" + COLOURS.COLOURS_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + COLOURS.COLOURS_TBL + " WHERE " + COLOURS.COLOURS_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
