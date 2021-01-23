// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:24 PM
// last update : 13-07-2017

using System.Data;
using CXLIB;

namespace AXCODE
{
    public class CServers_exten
    {
        #region[Check Box]
        
                public static string Active() 
                 { 
                     string q = " SELECT * FROM " + SERVERS.SERVERS_TBL + ""; 
                     q += " WHERE " + SERVERS.ACTIVE_ID + " = " + Core.Active + " \r\n"; 
                 //    q += " AND NOT " + SERVERS.SERVERS_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY  " + SERVERS.SERVERS_NAME + " \r\n"; 
                     return q; 
                 } 
                 public static string NotActive() 
                 { 
                     string q = " SELECT * FROM  " + SERVERS.SERVERS_TBL + "  \r\n"; 
                     q += " WHERE " + SERVERS.ACTIVE_ID + " = " + Core.NotActive + " \r\n"; 
                   //  q += " AND NOT " + SERVERS.SERVERS_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY " + SERVERS.SERVERS_ID + "  \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Check Box] 
                  
                 #region[Primary Key] 
                  
                 public static string PKId(string servers_id) 
                 { 
                     string q = " SELECT * FROM " + SERVERS.SERVERS_TBL + " \r\n"; 
                     q += " WHERE " + SERVERS.SERVERS_ID + " = '" + servers_id + "' \r\n"; 
                     q += " ORDER BY " + SERVERS.SERVERS_ID + " \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Primary Key] 
                  
                 #region[Search by name] 
                  
                 public static string SearchName(string servers_name) 
                 { 
                     string q = " SELECT * FROM  " + SERVERS.SERVERS_TBL + "  \r\n"; 
                     q += " WHERE " + SERVERS.SERVERS_NAME + "  = '" + servers_name + " ' \r\n"; 
                     q += " ORDER BY " + SERVERS.SERVERS_NAME + " \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Search by name] 
                  
                 #region[Look up] 
                  
                 public static DataTable GetforLookup() 
                 { 
                     string q = " SELECT * FROM " + SERVERS.SERVERS_TBL + ""; 
                     q += " WHERE " + SERVERS.ACTIVE_ID + " = " + Core.Active + " \r\n"; 
                 //    q += " AND NOT " + SERVERS.SERVERS_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY " + SERVERS.SERVERS_NAME + " \r\n"; 
                      
                     DataTable xlist = new SQLITE_DAL().Listdata(q); 
                     return xlist; 
                 } 
                  
                 #endregion[Look up] 
                  
                 #region[Get id - Name] 
                  
                 public static string GetName_Id(string _pId) 
                 { 
                    Servers obj = CServers.PropertiesData(PKId(_pId)); 
          
                     if (obj != null) 
                     { 
                         return obj.Servers_name; 
                     } 
                     return ""; 
                 } 
                  
                 public static string GetId_Name(string _pName) 
                 { 
                     Servers obj = CServers.PropertiesData(SearchName(_pName)); 
          
                     if (obj != null) 
                     { 
                         return obj.Servers_id; 
                     } 
                     return ""; 
                 } 
                  
                 #endregion[Get id - Name] 
         
    }//cls
}//ns
