// Version : 1 dt : 11-07-2017
// Auto Generated
// 13-07-2017 10:30:32 PM
// last update : 13-07-2017

using System.Data;
using CXLIB;

namespace AXCODE
{
    public class CDatabases_exten
    {
        #region[Check Box]
        
                public static string Active() 
                 { 
                     string q = " SELECT * FROM " + DATABASES.DATABASES_TBL + ""; 
                     q += " WHERE " + DATABASES.ACTIVE_ID + " = " + Core.Active + " \r\n"; 
                    // q += " AND NOT " + DATABASES.DATABASES_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY  " + DATABASES.DATABASES_NAME + " \r\n"; 
                     return q; 
                 } 
                 public static string NotActive() 
                 { 
                     string q = " SELECT * FROM  " + DATABASES.DATABASES_TBL + "  \r\n"; 
                     q += " WHERE " + DATABASES.ACTIVE_ID + " = " + Core.NotActive + " \r\n"; 
                    // q += " AND NOT " + DATABASES.DATABASES_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY " + DATABASES.DATABASES_ID + "  \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Check Box] 
                  
                 #region[Primary Key] 
                  
                 public static string PKId(string databases_id) 
                 { 
                     string q = " SELECT * FROM " + DATABASES.DATABASES_TBL + " \r\n"; 
                     q += " WHERE " + DATABASES.DATABASES_ID + " = '" + databases_id + "' \r\n"; 
                     q += " ORDER BY " + DATABASES.DATABASES_ID + " \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Primary Key] 
                  
                 #region[Search by name] 
                  
                 public static string SearchName(string databases_name) 
                 { 
                     string q = " SELECT * FROM  " + DATABASES.DATABASES_TBL + "  \r\n"; 
                     q += " WHERE " + DATABASES.DATABASES_NAME + "  = '" + databases_name + "' \r\n"; 
                     q += " ORDER BY " + DATABASES.DATABASES_NAME + " \r\n"; 
                     return q; 
                 } 
                  
                 #endregion[Search by name] 
                  
                 #region[Look up] 
                  
                 public static DataTable GetforLookup() 
                 { 
                     string q = " SELECT * FROM " + DATABASES.DATABASES_TBL + ""; 
                     q += " WHERE " + DATABASES.ACTIVE_ID + " = " + Core.Active + " \r\n"; 
                   //  q += " AND NOT " + DATABASES.DATABASES_ID + " = '" + Core.One + "' \r\n"; 
                     q += " ORDER BY " + DATABASES.DATABASES_NAME + " \r\n"; 
                      
                     DataTable xlist = new SQLITE_DAL().Listdata(q); 
                     return xlist; 
                 } 
                  
                 #endregion[Look up] 
                  
                 #region[Get id - Name] 
                  
                 public static string GetName_Id(string _pId) 
                 { 
                    Databases obj = CDatabases.PropertiesData(PKId(_pId)); 
          
                     if (obj != null) 
                     { 
                         return obj.Databases_name; 
                     } 
                     return ""; 
                 } 
                  
                 public static string GetId_Name(string _pName) 
                 { 
                     Databases obj = CDatabases.PropertiesData(SearchName(_pName)); 
          
                     if (obj != null) 
                     { 
                         return obj.Databases_id; 
                     } 
                     return ""; 
                 } 
                  
                 #endregion[Get id - Name] 
         
    }//cls
}//ns
