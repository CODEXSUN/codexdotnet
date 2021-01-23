// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:32 PM
// last update : 13-07-2017

using System.Collections.Generic;
using System.Data;
using CXLIB;

namespace AXCODE
{
    public class CDatabases 
    {
        #region[Attach params]
        
        private static string AttachParams(string q, Databases _Databases)
        {
            q = q.Replace("@" + DATABASES.DATABASES_ID + "@", "" + ConvertTO.SqlString(_Databases.Databases_id) + "");
            q = q.Replace("@" + DATABASES.DATABASES_NAME + "@", "" + ConvertTO.SqlString(_Databases.Databases_name) + "");
            q = q.Replace("@" + DATABASES.NOTES + "@", "" + ConvertTO.SqlString(_Databases.Notes) + "");
            q = q.Replace("@" + DATABASES.ACTIVE_ID + "@", "" + ConvertTO.SqlString(_Databases.Active_id) + "");
            q = q.Replace("@" + DATABASES.USER_ID + "@", "" + ConvertTO.SqlString(_Databases.User_id) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(Databases _Databases, SQLITE_DAL dalsession)
        {
                string q = " INSERT INTO " + DATABASES.DATABASES_TBL + " ( ";
                q += " " + DATABASES.DATABASES_NAME + " \r\n ";
                q += "," + DATABASES.NOTES + " \r\n ";
                q += "," + DATABASES.ACTIVE_ID + " \r\n ";
                q += "," + DATABASES.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ DATABASES.DATABASES_NAME + "@ \r\n ";
                q += ", @"+ DATABASES.NOTES + "@ \r\n ";
                q += ", @"+ DATABASES.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ DATABASES.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, _Databases);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Update]
        
        public static void Update(Databases _Databases, SQLITE_DAL dalsession)
        {
                string q = "UPDATE " + DATABASES.DATABASES_TBL + " SET";
                q += " " + DATABASES.DATABASES_NAME + " = @" + DATABASES.DATABASES_NAME + "@ \r\n ";
                q += "," + DATABASES.NOTES + " = @" + DATABASES.NOTES + "@ \r\n ";
                q += "," + DATABASES.ACTIVE_ID + " = @" + DATABASES.ACTIVE_ID + "@ \r\n ";
                q += "," + DATABASES.USER_ID + " = @" + DATABASES.USER_ID + "@ \r\n ";
                q += "  WHERE " + DATABASES.DATABASES_ID + " = @" + DATABASES.DATABASES_ID + "@ ";
                q = AttachParams(q, _Databases);
                dalsession.Execute(q);
        }
        #endregion[Update]
        
        #region[Delete]
        
        public static void Delete(string _Databases_id , SQLITE_DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + DATABASES.DATABASES_TBL+ " WHERE " + DATABASES.DATABASES_ID + " =  " + _Databases_id +";");
        }
        #endregion[Delete]
        
        #region[Tbl Data]
        
        public static DataTable TblData(string q)
        {
            return new SQLITE_DAL().Listdata(q);
        }
        
        #endregion[Tbl Data]
        
        #region[Properties Data]
        
        public static Databases PropertiesData(string q)
        {
        
            DataTable tbl = new SQLITE_DAL().Listdata(q);
        
            if (tbl.Rows.Count != 0)
            {
            Databases obj = new Databases()
            {
            Databases_id = tbl.Rows[0][DATABASES.DATABASES_ID].ToString(),
                Databases_name = tbl.Rows[0][DATABASES.DATABASES_NAME].ToString(),
                Notes = tbl.Rows[0][DATABASES.NOTES].ToString(),
                Active_id = tbl.Rows[0][DATABASES.ACTIVE_ID].ToString(),
                User_id = tbl.Rows[0][DATABASES.USER_ID].ToString()
            };
            return obj;
            }
        else
        {
        return new  Databases();
        }
        }
        
        #endregion[Properties Data]
        
        #region[Properties List]
        
        public static List<Databases> PropertiesList(string q)
        {
            List<Databases> list = new List<Databases>();
        
            DataTable tbl = new SQLITE_DAL().Listdata(q);
        
            if (tbl.Rows.Count != 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
            Databases obj = new Databases()
            {
                Databases_id = tbl.Rows[i][DATABASES.DATABASES_ID].ToString(),
                Databases_name = tbl.Rows[i][DATABASES.DATABASES_NAME].ToString(),
                Notes = tbl.Rows[i][DATABASES.NOTES].ToString(),
                Active_id = tbl.Rows[i][DATABASES.ACTIVE_ID].ToString(),
                User_id = tbl.Rows[i][DATABASES.USER_ID].ToString()
                };
                    list.Add(obj);
                }
            }
            return list;
        }
        
        #endregion[Properties List]
        
    }//cls
}//ns
