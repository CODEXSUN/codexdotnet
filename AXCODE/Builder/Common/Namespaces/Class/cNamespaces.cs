// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2020 07.29.30 PM

using CXLIB;
using System.Collections.Generic;
using System.Data;

namespace AXCODE
{
    public class CNamespaces
    {

        #region[Get New]

        public static Namespaces GetNew
        {
            get
            {
                Namespaces obj = new Namespaces()
                {
                    Namespaces_id = string.Empty,
                    Namespaces_name = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Namespaces v)
        {
            q = q.Replace("@" + NAMESPACES.NAMESPACES_ID + "@", "" + ConvertTO.SqlString(v.Namespaces_id) + "");
            q = q.Replace("@" + NAMESPACES.NAMESPACES_NAME + "@", "" + ConvertTO.SqlString(v.Namespaces_name) + "");
            q = q.Replace("@" + NAMESPACES.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + NAMESPACES.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Namespaces v, SQLITE_DAL dalsession)
        {
                string q = " INSERT INTO " + NAMESPACES.NAMESPACES_TBL + " ( ";
                q += " " + NAMESPACES.NAMESPACES_NAME + " \r\n ";
                q += "," + NAMESPACES.NOTES + " \r\n ";
                q += "," + NAMESPACES.ACTIVE_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ NAMESPACES.NAMESPACES_NAME + "@ \r\n ";
                q += ", @"+ NAMESPACES.NOTES + "@ \r\n ";
                q += ", @"+ NAMESPACES.ACTIVE_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Namespaces v, SQLITE_DAL dalsession)
        {
                string q = "UPDATE " + NAMESPACES.NAMESPACES_TBL + " SET";
                q += " " + NAMESPACES.NAMESPACES_NAME + " = @" + NAMESPACES.NAMESPACES_NAME + "@ \r\n ";
                q += "," + NAMESPACES.NOTES + " = @" + NAMESPACES.NOTES + "@ \r\n ";
                q += "," + NAMESPACES.ACTIVE_ID + " = @" + NAMESPACES.ACTIVE_ID + "@ \r\n ";
                q += "  WHERE " + NAMESPACES.NAMESPACES_ID + " = @" + NAMESPACES.NAMESPACES_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , SQLITE_DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + NAMESPACES.NAMESPACES_TBL+ " WHERE " + NAMESPACES.NAMESPACES_ID + " =  " + pkid +";");
        }
        #endregion[Delete]               
    }//cls
}//ns
