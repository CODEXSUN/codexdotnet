// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:42:25 PM
// last update : 13-07-2017

using System.Collections.Generic;
using System.Data;
using CXLIB;

namespace AXCODE
{
    public class CUser 
    {
        #region[Attach params]
        
        private static string AttachParams(string q, User _User)
        {
            q = q.Replace("@" + USER.USER_ID + "@", "" + ConvertTO.SqlString(_User.User_id) + "");
            q = q.Replace("@" + USER.USER_NAME + "@", "" + ConvertTO.SqlString(_User.User_name) + "");
            q = q.Replace("@" + USER.USER_PASSWORD + "@", "" + ConvertTO.SqlString(_User.User_password) + "");
            q = q.Replace("@" + USER.CREATEON + "@", "" + ConvertTO.SqlDateTime(_User.Createon) + "");
            q = q.Replace("@" + USER.ENTRYBY + "@", "" + ConvertTO.SqlString(_User.Entryby) + "");
            q = q.Replace("@" + USER.NOTES + "@", "" + ConvertTO.SqlString(_User.Notes) + "");
            q = q.Replace("@" + USER.ACTIVE_ID + "@", "" + ConvertTO.SqlString(_User.Active_id) + "");
            q = q.Replace("@" + USER.USER_ID + "@", "" + ConvertTO.SqlString(_User.User_id) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(User _User, DAL dalsession)
        {
                string q = " INSERT INTO " + USER.USER_TBL + " ( ";
                q += " " + USER.USER_NAME + " \r\n ";
                q += "," + USER.USER_PASSWORD + " \r\n ";
                q += "," + USER.CREATEON + " \r\n ";
                q += "," + USER.ENTRYBY + " \r\n ";
                q += "," + USER.NOTES + " \r\n ";
                q += "," + USER.ACTIVE_ID + " \r\n ";
                q += "," + USER.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ USER.USER_NAME + "@ \r\n ";
                q += ", @"+ USER.USER_PASSWORD + "@ \r\n ";
                q += ", @"+ USER.CREATEON + "@ \r\n ";
                q += ", @"+ USER.ENTRYBY + "@ \r\n ";
                q += ", @"+ USER.NOTES + "@ \r\n ";
                q += ", @"+ USER.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ USER.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, _User);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Update]
        
        public static void Update(User _User, DAL dalsession)
        {
                string q = "UPDATE " + USER.USER_TBL + " SET";
                q += " " + USER.USER_NAME + " = @" + USER.USER_NAME + "@ \r\n ";
                q += "," + USER.USER_PASSWORD + " = @" + USER.USER_PASSWORD + "@ \r\n ";
                q += "," + USER.CREATEON + " = @" + USER.CREATEON + "@ \r\n ";
                q += "," + USER.ENTRYBY + " = @" + USER.ENTRYBY + "@ \r\n ";
                q += "," + USER.NOTES + " = @" + USER.NOTES + "@ \r\n ";
                q += "," + USER.ACTIVE_ID + " = @" + USER.ACTIVE_ID + "@ \r\n ";
                q += "," + USER.USER_ID + " = @" + USER.USER_ID + "@ \r\n ";
                q += "  WHERE " + USER.USER_ID + " = @" + USER.USER_ID + "@ ";
                q = AttachParams(q, _User);
                dalsession.Execute(q);
        }
        #endregion[Update]
        
        #region[Delete]
        
        public static void Delete(string _User_id , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + USER.USER_TBL+ " WHERE " + USER.USER_ID + " =  " + _User_id +";");
        }
        #endregion[Delete]
        
        #region[Tbl Data]
        
        public static DataTable TblData(string q)
        {
            return new DAL().Listdata(q);
        }
        
        #endregion[Tbl Data]
        
        #region[Properties Data]
        
        public static User PropertiesData(string q)
        {
        
            DataTable tbl = new DAL().Listdata(q);
        
            if (tbl.Rows.Count != 0)
            {
            User obj = new User()
            {
            User_id = tbl.Rows[0][USER.USER_ID].ToString(),
                User_name = tbl.Rows[0][USER.USER_NAME].ToString(),
                User_password = tbl.Rows[0][USER.USER_PASSWORD].ToString(),
                Createon = tbl.Rows[0][USER.CREATEON].ToString(),
                Entryby = tbl.Rows[0][USER.ENTRYBY].ToString(),
                Notes = tbl.Rows[0][USER.NOTES].ToString(),
                Active_id = tbl.Rows[0][USER.ACTIVE_ID].ToString()
            };
            return obj;
            }
        else
        {
        return new  User();
        }
        }
        
        #endregion[Properties Data]
        
        #region[Properties List]
        
        public static List<User> PropertiesList(string q)
        {
            List<User> list = new List<User>();
        
            DataTable tbl = new DAL().Listdata(q);
        
            if (tbl.Rows.Count != 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
            User obj = new User()
            {
                User_id = tbl.Rows[i][USER.USER_ID].ToString(),
                User_name = tbl.Rows[i][USER.USER_NAME].ToString(),
                User_password = tbl.Rows[i][USER.USER_PASSWORD].ToString(),
                Createon = tbl.Rows[i][USER.CREATEON].ToString(),
                Entryby = tbl.Rows[i][USER.ENTRYBY].ToString(),
                Notes = tbl.Rows[i][USER.NOTES].ToString(),
                Active_id = tbl.Rows[i][USER.ACTIVE_ID].ToString(),
                };
                    list.Add(obj);
                }
            }
            return list;
        }
        
        #endregion[Properties List]
        
    }//cls
}//ns
