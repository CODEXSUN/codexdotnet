// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:51:36 PM

using CXLIB;

namespace CXCORE
{
    public class CLedgergroup
    {

        #region[Get New]

        public static Ledgergroup GetNew
        {
            get
            {
                Ledgergroup obj = new Ledgergroup()
                {
                    Ledgergroup_id = string.Empty,
                    Ledgergroup_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Ledgergroup v)
        {
            q = q.Replace("@" + LEDGERGROUP.LEDGERGROUP_ID + "@", "" + ConvertTO.SqlString(v.Ledgergroup_id) + "");
            q = q.Replace("@" + LEDGERGROUP.LEDGERGROUP_NAME + "@", "" + ConvertTO.SqlString(v.Ledgergroup_name) + "");
            q = q.Replace("@" + LEDGERGROUP.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + LEDGERGROUP.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + LEDGERGROUP.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Ledgergroup v, DAL dalsession)
        {
            string q = " INSERT INTO " + LEDGERGROUP.LEDGERGROUP_TBL + " ( ";
            q += " " + LEDGERGROUP.LEDGERGROUP_NAME + " \r\n ";
            q += "," + LEDGERGROUP.NOTES + " \r\n ";
            q += "," + LEDGERGROUP.ACTIVE_ID + " \r\n ";
            q += "," + LEDGERGROUP.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + LEDGERGROUP.LEDGERGROUP_NAME + "@ \r\n ";
            q += ", @" + LEDGERGROUP.NOTES + "@ \r\n ";
            q += ", @" + LEDGERGROUP.ACTIVE_ID + "@ \r\n ";
            q += ", @" + LEDGERGROUP.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Ledgergroup v, DAL dalsession)
        {
            string q = "UPDATE " + LEDGERGROUP.LEDGERGROUP_TBL + " SET";
            q += " " + LEDGERGROUP.LEDGERGROUP_NAME + " = @" + LEDGERGROUP.LEDGERGROUP_NAME + "@ \r\n ";
            q += "," + LEDGERGROUP.NOTES + " = @" + LEDGERGROUP.NOTES + "@ \r\n ";
            q += "," + LEDGERGROUP.ACTIVE_ID + " = @" + LEDGERGROUP.ACTIVE_ID + "@ \r\n ";
            q += "," + LEDGERGROUP.USER_ID + " = @" + LEDGERGROUP.USER_ID + "@ \r\n ";
            q += "  WHERE " + LEDGERGROUP.LEDGERGROUP_ID + " = @" + LEDGERGROUP.LEDGERGROUP_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + LEDGERGROUP.LEDGERGROUP_TBL + " WHERE " + LEDGERGROUP.LEDGERGROUP_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
