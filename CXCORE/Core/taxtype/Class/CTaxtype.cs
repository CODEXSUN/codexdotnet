// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 10:22:51 AM

using CXLIB;

namespace CXCORE
{
    public class CTaxtype
    {

        #region[Get New]

        public static Taxtype GetNew
        {
            get
            {
                Taxtype obj = new Taxtype()
                {
                    Taxtype_id = string.Empty,
                    Taxtype_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Taxtype v)
        {
            q = q.Replace("@" + TAXTYPE.TAXTYPE_ID + "@", "" + ConvertTO.SqlString(v.Taxtype_id) + "");
            q = q.Replace("@" + TAXTYPE.TAXTYPE_NAME + "@", "" + ConvertTO.SqlString(v.Taxtype_name) + "");
            q = q.Replace("@" + TAXTYPE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + TAXTYPE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + TAXTYPE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Taxtype v, DAL dalsession)
        {
            string q = " INSERT INTO " + TAXTYPE.TAXTYPE_TBL + " ( ";
            q += " " + TAXTYPE.TAXTYPE_NAME + " \r\n ";
            q += "," + TAXTYPE.NOTES + " \r\n ";
            q += "," + TAXTYPE.ACTIVE_ID + " \r\n ";
            q += "," + TAXTYPE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + TAXTYPE.TAXTYPE_NAME + "@ \r\n ";
            q += ", @" + TAXTYPE.NOTES + "@ \r\n ";
            q += ", @" + TAXTYPE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + TAXTYPE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Taxtype v, DAL dalsession)
        {
            string q = "UPDATE " + TAXTYPE.TAXTYPE_TBL + " SET";
            q += " " + TAXTYPE.TAXTYPE_NAME + " = @" + TAXTYPE.TAXTYPE_NAME + "@ \r\n ";
            q += "," + TAXTYPE.NOTES + " = @" + TAXTYPE.NOTES + "@ \r\n ";
            q += "," + TAXTYPE.ACTIVE_ID + " = @" + TAXTYPE.ACTIVE_ID + "@ \r\n ";
            q += "," + TAXTYPE.USER_ID + " = @" + TAXTYPE.USER_ID + "@ \r\n ";
            q += "  WHERE " + TAXTYPE.TAXTYPE_ID + " = @" + TAXTYPE.TAXTYPE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + TAXTYPE.TAXTYPE_TBL + " WHERE " + TAXTYPE.TAXTYPE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
