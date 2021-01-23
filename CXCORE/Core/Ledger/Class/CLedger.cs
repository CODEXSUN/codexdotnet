// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:55:36 PM

using CXLIB;

namespace CXCORE
{
    public class CLedger
    {

        #region[Get New]

        public static Ledger GetNew
        {
            get
            {
                Ledger obj = new Ledger()
                {
                    Ledger_id = string.Empty,
                    Ledger_name = string.Empty,
                    Ledgergroup_id = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Ledger v)
        {
            q = q.Replace("@" + LEDGER.LEDGER_ID + "@", "" + ConvertTO.SqlString(v.Ledger_id) + "");
            q = q.Replace("@" + LEDGER.LEDGER_NAME + "@", "" + ConvertTO.SqlString(v.Ledger_name) + "");
            q = q.Replace("@" + LEDGER.LEDGERGROUP_ID + "@", "" + ConvertTO.SqlString(v.Ledgergroup_id) + "");
            q = q.Replace("@" + LEDGER.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + LEDGER.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + LEDGER.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Ledger v, DAL dalsession)
        {
                string q = " INSERT INTO " + LEDGER.LEDGER_TBL + " ( ";
                q += " " + LEDGER.LEDGER_NAME + " \r\n ";
                q += "," + LEDGER.LEDGERGROUP_ID + " \r\n ";
                q += "," + LEDGER.NOTES + " \r\n ";
                q += "," + LEDGER.ACTIVE_ID + " \r\n ";
                q += "," + LEDGER.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ LEDGER.LEDGER_NAME + "@ \r\n ";
                q += ", @"+ LEDGER.LEDGERGROUP_ID + "@ \r\n ";
                q += ", @"+ LEDGER.NOTES + "@ \r\n ";
                q += ", @"+ LEDGER.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ LEDGER.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Ledger v, DAL dalsession)
        {
                string q = "UPDATE " + LEDGER.LEDGER_TBL + " SET";
                q += " " + LEDGER.LEDGER_NAME + " = @" + LEDGER.LEDGER_NAME + "@ \r\n ";
                q += "," + LEDGER.LEDGERGROUP_ID + " = @" + LEDGER.LEDGERGROUP_ID + "@ \r\n ";
                q += "," + LEDGER.NOTES + " = @" + LEDGER.NOTES + "@ \r\n ";
                q += "," + LEDGER.ACTIVE_ID + " = @" + LEDGER.ACTIVE_ID + "@ \r\n ";
                q += "," + LEDGER.USER_ID + " = @" + LEDGER.USER_ID + "@ \r\n ";
                q += "  WHERE " + LEDGER.LEDGER_ID + " = @" + LEDGER.LEDGER_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + LEDGER.LEDGER_TBL+ " WHERE " + LEDGER.LEDGER_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
