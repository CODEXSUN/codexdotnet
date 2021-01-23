// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:24 PM
// last update : 13-07-2017

using System.Collections.Generic;
using System.Data;
using CXLIB;

namespace AXCODE
{
    public class CServers 
    {
        #region[Attach params]
        
        private static string AttachParams(string q, Servers _Servers)
        {
            q = q.Replace("@" + SERVERS.SERVERS_ID + "@", "" + ConvertTO.SqlString(_Servers.Servers_id) + "");
            q = q.Replace("@" + SERVERS.SERVERS_NAME + "@", "" + ConvertTO.SqlString(_Servers.Servers_name) + "");
            q = q.Replace("@" + SERVERS.SERVERS_VERSION + "@", "" + ConvertTO.SqlString(_Servers.Servers_version) + "");
            q = q.Replace("@" + SERVERS.SERVERS_PATH + "@", "" + ConvertTO.SqlString(_Servers.Servers_path) + "");
            q = q.Replace("@" + SERVERS.SERVERS_BACKUP_PATH + "@", "" + ConvertTO.SqlString(_Servers.Servers_backup_path) + "");
            q = q.Replace("@" + SERVERS.NOTES + "@", "" + ConvertTO.SqlString(_Servers.Notes) + "");
            q = q.Replace("@" + SERVERS.ACTIVE_ID + "@", "" + ConvertTO.SqlString(_Servers.Active_id) + "");
            q = q.Replace("@" + SERVERS.USER_ID + "@", "" + ConvertTO.SqlString(_Servers.User_id) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(Servers _Servers, SQLITE_DAL dalsession)
        {
                string q = " INSERT INTO " + SERVERS.SERVERS_TBL + " ( ";
                q += " " + SERVERS.SERVERS_NAME + " \r\n ";
                q += "," + SERVERS.SERVERS_VERSION + " \r\n ";
                q += "," + SERVERS.SERVERS_PATH + " \r\n ";
                q += "," + SERVERS.SERVERS_BACKUP_PATH + " \r\n ";
                q += "," + SERVERS.NOTES + " \r\n ";
                q += "," + SERVERS.ACTIVE_ID + " \r\n ";
                q += "," + SERVERS.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ SERVERS.SERVERS_NAME + "@ \r\n ";
                q += ", @"+ SERVERS.SERVERS_VERSION + "@ \r\n ";
                q += ", @"+ SERVERS.SERVERS_PATH + "@ \r\n ";
                q += ", @"+ SERVERS.SERVERS_BACKUP_PATH + "@ \r\n ";
                q += ", @"+ SERVERS.NOTES + "@ \r\n ";
                q += ", @"+ SERVERS.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ SERVERS.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, _Servers);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Update]
        
        public static void Update(Servers _Servers, SQLITE_DAL dalsession)
        {
                string q = "UPDATE " + SERVERS.SERVERS_TBL + " SET";
                q += " " + SERVERS.SERVERS_NAME + " = @" + SERVERS.SERVERS_NAME + "@ \r\n ";
                q += "," + SERVERS.SERVERS_VERSION + " = @" + SERVERS.SERVERS_VERSION + "@ \r\n ";
                q += "," + SERVERS.SERVERS_PATH + " = @" + SERVERS.SERVERS_PATH + "@ \r\n ";
                q += "," + SERVERS.SERVERS_BACKUP_PATH + " = @" + SERVERS.SERVERS_BACKUP_PATH + "@ \r\n ";
                q += "," + SERVERS.NOTES + " = @" + SERVERS.NOTES + "@ \r\n ";
                q += "," + SERVERS.ACTIVE_ID + " = @" + SERVERS.ACTIVE_ID + "@ \r\n ";
                q += "," + SERVERS.USER_ID + " = @" + SERVERS.USER_ID + "@ \r\n ";
                q += "  WHERE " + SERVERS.SERVERS_ID + " = @" + SERVERS.SERVERS_ID + "@ ";
                q = AttachParams(q, _Servers);
                dalsession.Execute(q);
        }
        #endregion[Update]
        
        #region[Delete]
        
        public static void Delete(string _Servers_id , SQLITE_DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + SERVERS.SERVERS_TBL+ " WHERE " + SERVERS.SERVERS_ID + " =  " + _Servers_id +";");
        }
        #endregion[Delete]
        
        #region[Tbl Data]
        
        public static DataTable TblData(string q)
        {
            return new SQLITE_DAL().Listdata(q);
        }
        
        #endregion[Tbl Data]
        
        #region[Properties Data]
        
        public static Servers PropertiesData(string q)
        {
        
            DataTable tbl = new SQLITE_DAL().Listdata(q);
        
            if (tbl.Rows.Count != 0)
            {
            Servers obj = new Servers()
            {
            Servers_id = tbl.Rows[0][SERVERS.SERVERS_ID].ToString(),
                Servers_name = tbl.Rows[0][SERVERS.SERVERS_NAME].ToString(),
                Servers_version = tbl.Rows[0][SERVERS.SERVERS_VERSION].ToString(),
                Servers_path = tbl.Rows[0][SERVERS.SERVERS_PATH].ToString(),
                Servers_backup_path = tbl.Rows[0][SERVERS.SERVERS_BACKUP_PATH].ToString(),
                Notes = tbl.Rows[0][SERVERS.NOTES].ToString(),
                Active_id = tbl.Rows[0][SERVERS.ACTIVE_ID].ToString(),
                User_id = tbl.Rows[0][SERVERS.USER_ID].ToString()
            };
            return obj;
            }
        else
        {
        return new  Servers();
        }
        }
        
        #endregion[Properties Data]
        
        #region[Properties List]
        
        public static List<Servers> PropertiesList(string q)
        {
            List<Servers> list = new List<Servers>();
        
            DataTable tbl = new SQLITE_DAL().Listdata(q);
        
            if (tbl.Rows.Count != 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
            Servers obj = new Servers()
            {
                Servers_id = tbl.Rows[i][SERVERS.SERVERS_ID].ToString(),
                Servers_name = tbl.Rows[i][SERVERS.SERVERS_NAME].ToString(),
                Servers_version = tbl.Rows[i][SERVERS.SERVERS_VERSION].ToString(),
                Servers_path = tbl.Rows[i][SERVERS.SERVERS_PATH].ToString(),
                Servers_backup_path = tbl.Rows[i][SERVERS.SERVERS_BACKUP_PATH].ToString(),
                Notes = tbl.Rows[i][SERVERS.NOTES].ToString(),
                Active_id = tbl.Rows[i][SERVERS.ACTIVE_ID].ToString(),
                User_id = tbl.Rows[i][SERVERS.USER_ID].ToString()
                };
                    list.Add(obj);
                }
            }
            return list;
        }
        
        #endregion[Properties List]
        
    }//cls
}//ns
