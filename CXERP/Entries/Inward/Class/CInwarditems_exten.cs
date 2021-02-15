// Version : 5.0.0.0 Date : 27-01-2021
// Auto Generated
// last update : 28-01-2021 10:30:12 PM

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXERP
{
    public static class CInwarditems_exten
    {
         #region[Entity List] 
  
         private static List<Inwarditems> EntityList(string q) 
         { 
             List<Inwarditems> list = new List<Inwarditems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Inwarditems  obj = new  Inwarditems () 
                     { 
                        Inwarditems_id = redr[INWARDITEMS.INWARDITEMS_ID].ToString(), 
                        Inward_id = redr[INWARDITEMS.INWARD_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Colours_id = redr[COLOURS.COLOURS_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Bundle = redr[INWARDITEMS.BUNDLE].ToString(),
                        Qty = redr[INWARDITEMS.QTY].ToString(),
                        Refered_id = redr[INWARDITEMS.REFERED_ID].ToString(),
                        Locked = redr[INWARDITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Inwarditems> FKId(string id ) 
         { 
            string q = " SELECT " + INWARDITEMS.INWARDITEMS_TBL +".* \r\n"; 
            q += ", "+ INWARD.INWARD_TBL + "."+ INWARD.INWARD_NO + " \r\n"; 
            q += ", "+ PRODUCT.PRODUCT_TBL + "."+ PRODUCT.PRODUCT_NAME + " \r\n"; 
            q += ", "+ COLOURS.COLOURS_TBL + "."+ COLOURS.COLOURS_NAME + " \r\n"; 
            q += ", "+ SIZES.SIZES_TBL + "."+ SIZES.SIZES_NAME + " \r\n"; 
            q += " FROM  " + INWARDITEMS.INWARDITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + INWARD.INWARD_TBL + "\r\n";  
            q += " ON(" + INWARDITEMS.INWARDITEMS_TBL + "." + INWARDITEMS.INWARD_ID + " = " + INWARD.INWARD_TBL + "." + INWARD.INWARD_ID+" )\r\n";  
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";  
            q += " ON(" + INWARDITEMS.INWARDITEMS_TBL + "." + INWARDITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + "\r\n";  
            q += " ON(" + INWARDITEMS.INWARDITEMS_TBL + "." + INWARDITEMS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID+" )\r\n";  
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";  
            q += " ON(" + INWARDITEMS.INWARDITEMS_TBL + "." + INWARDITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID+" )\r\n";  
            q += " WHERE " + INWARDITEMS.INWARDITEMS_TBL + "." + INWARD.INWARD_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + INWARDITEMS.INWARDITEMS_TBL + "." + INWARDITEMS.INWARDITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
