// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:42:25 PM
// last update : 13-07-2017

using System.Data;
using CXLIB;

namespace AXCODE
{
    public class CUser_exten
    {
        #region[Check Box]
        
                public static string Active() 
                 { 
                     string q = " SELECT * FROM " + USER.USER_TBL + ""; 
                     q += " WHERE " + USER.ACTIVE_ID + " = " + Core.Active + " \r\n"; 
                 //    q += " AND NOT " + USER.USER_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY  " + USER.USER_NAME + " \r\n"; 
                     return q; 
                 } 
                 public static string NotActive() 
                 { 
                     string q = " SELECT * FROM  " + USER.USER_TBL + "  \r\n"; 
                     q += " WHERE " + USER.ACTIVE_ID + " = " + Core.NotActive + " \r\n"; 
                  //   q += " AND NOT " + USER.USER_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY " + USER.USER_ID + "  \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Check Box] 
                  
                 #region[Primary Key] 
                  
                 public static string PKId(string user_id) 
                 { 
                     string q = " SELECT * FROM " + USER.USER_TBL + " \r\n"; 
                     q += " WHERE " + USER.USER_ID + " = '" + user_id + "' \r\n"; 
                     q += " ORDER BY " + USER.USER_ID + " \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Primary Key] 
                  
                 #region[Search by name] 
                  
                 public static string SearchName(string user_name) 
                 { 
                     string q = " SELECT * FROM  " + USER.USER_TBL + "  \r\n"; 
                     q += " WHERE " + USER.USER_NAME + "  = '" + user_name + " ' \r\n"; 
                     q += " ORDER BY " + USER.USER_NAME + " \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Search by name] 
                  
                 #region[Look up] 
                  
                 public static DataTable GetforLookup() 
                 { 
                     string q = " SELECT * FROM " + USER.USER_TBL + ""; 
                     q += " WHERE " + USER.ACTIVE_ID + " = " + Core.Active + " \r\n"; 
                  //   q += " AND NOT " + USER.USER_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY " + USER.USER_NAME + " \r\n"; 
                      
                     DataTable xlist = new DAL().Listdata(q); 
                     return xlist; 
                 } 
                  
                 #endregion[Look up] 
                  
                 #region[Get id - Name] 
                  
                 public static string GetName_Id(string _pId) 
                 { 
                    User obj = CUser.PropertiesData(PKId(_pId)); 
          
                     if (obj != null) 
                     { 
                         return obj.User_name; 
                     } 
                     return ""; 
                 } 
                  
                 public static string GetId_Name(string _pName) 
                 { 
                     User obj = CUser.PropertiesData(SearchName(_pName)); 
          
                     if (obj != null) 
                     { 
                         return obj.User_id; 
                     } 
                     return ""; 
                 } 
                  
                 #endregion[Get id - Name] 
         
    }//cls
}//ns
