// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 22-03-2019 12:58:19 PM

using CXLIB;

namespace CXCORE
{
    public class CDefaultcompany
    {

        #region[Attach params]

        private static string AttachParams(string q, Defaultcompany v)
        {
            q = q.Replace("@" + DEFAULTCOMPANY.DEFAULTCOMPANY_ID + "@", "" + ConvertTO.SqlString(v.Defaultcompany_id) + "");
            q = q.Replace("@" + DEFAULTCOMPANY.COMPANY_ID + "@", "" + ConvertTO.SqlString(v.Company_id) + "");
            q = q.Replace("@" + DEFAULTCOMPANY.ACY_ID + "@", "" + ConvertTO.SqlString(v.Acy_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Defaultcompany v, DAL dalsession)
        {
            string q = " INSERT INTO " + DEFAULTCOMPANY.DEFAULTCOMPANY_TBL + " ( ";
            q += " " + DEFAULTCOMPANY.COMPANY_ID + " \r\n ";
            q += "," + DEFAULTCOMPANY.ACY_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + DEFAULTCOMPANY.COMPANY_ID + "@ \r\n ";
            q += ", @" + DEFAULTCOMPANY.ACY_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Defaultcompany v, DAL dalsession)
        {
            string q = "UPDATE " + DEFAULTCOMPANY.DEFAULTCOMPANY_TBL + " SET";
            q += " " + DEFAULTCOMPANY.COMPANY_ID + " = @" + DEFAULTCOMPANY.COMPANY_ID + "@ \r\n ";
            q += "," + DEFAULTCOMPANY.ACY_ID + " = @" + DEFAULTCOMPANY.ACY_ID + "@ \r\n ";
            q += "  WHERE " + DEFAULTCOMPANY.DEFAULTCOMPANY_ID + " = @" + DEFAULTCOMPANY.DEFAULTCOMPANY_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + DEFAULTCOMPANY.DEFAULTCOMPANY_TBL + " WHERE " + DEFAULTCOMPANY.DEFAULTCOMPANY_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
