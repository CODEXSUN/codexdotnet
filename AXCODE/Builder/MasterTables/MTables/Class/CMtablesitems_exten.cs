// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// 05-12-2018 01:26:34 PM
// last update : 05-12-2018

using System.Data;
using System.Collections.Generic;

namespace AXCODE
{
    public class CMtablesitems_exten
    {
         #region[Entity List] 
  
         private static List<MasterTablesItems> EntityList(string q) 
         { 
             List<MasterTablesItems> list = new List<MasterTablesItems>(); 
  
             using (IDataReader redr = new SQLITE_DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      MasterTablesItems  obj = new  MasterTablesItems () 
                     { 
                        Mtablesitems_id = redr[MASTERTABLESITEMS.MASTERTABLESITEMS_ID].ToString(), 
                        Fieldsname = redr[MASTERTABLESITEMS.FIELDSNAME].ToString(),
                        Mtables_id = redr[MASTERTABLESITEMS.MASTERTABLES_ID].ToString(),
                        Displayname = redr[MASTERTABLESITEMS.DISPLAYNAME].ToString(),
                        Datatype = redr[MASTERTABLESITEMS.DATATYPE].ToString(),
                        Inputtype = redr[MASTERTABLESITEMS.INPUTTYPE].ToString(),
                        Width = redr[MASTERTABLESITEMS.WIDTH].ToString(),
                        Height = redr[MASTERTABLESITEMS.HEIGHT].ToString(),
                        Cposition = redr[MASTERTABLESITEMS.CPOSITION].ToString(),
                        Rposition = redr[MASTERTABLESITEMS.RPOSITION].ToString(),
                        Validate = redr[MASTERTABLESITEMS.VALIDATE].ToString(),
                        Isdefault = redr[MASTERTABLESITEMS.ISDEFAULT].ToString(),
                        Placement = redr[MASTERTABLESITEMS.PLACEMENT].ToString(),
                        Alignto = redr[MASTERTABLESITEMS.ALIGNTO].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<MasterTablesItems> FKId(string id ) 
         { 
            string q = " SELECT " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL +".* \r\n"; 
            q += ", "+ MASTERTABLES.MASTERTABLES_TBL + "."+ MASTERTABLES.MASTERTABLES_NAME + " \r\n"; 
            q += " FROM  " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + MASTERTABLES.MASTERTABLES_TBL + "\r\n";  
            q += " ON(" + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL + "." + MASTERTABLESITEMS.MASTERTABLES_ID + " = " + MASTERTABLES.MASTERTABLES_TBL + "." + MASTERTABLES.MASTERTABLES_ID+" )\r\n";  
            q += " WHERE " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL + "." + MASTERTABLES.MASTERTABLES_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + MASTERTABLESITEMS.MASTERTABLESITEMS_TBL + "." + MASTERTABLESITEMS.MASTERTABLESITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
