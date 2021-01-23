// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXERP
{
    public static class CStyleitems_exten
    {
         #region[Entity List] 
  
         private static List<Styleitems> EntityList(string q) 
         { 
             List<Styleitems> list = new List<Styleitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Styleitems  obj = new  Styleitems () 
                     { 
                        Styleitems_id = redr[STYLEITEMS.STYLEITEMS_ID].ToString(), 
                        Style_id = redr[STYLEITEMS.STYLE_ID].ToString(),
                        Style_no = redr[STYLEITEMS.STYLE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Colours_id = redr[COLOURS.COLOURS_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[STYLEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[STYLEITEMS.PRICE].ToString()),
                        Refered_id = redr[STYLEITEMS.REFERED_ID].ToString(),
                        Locked = redr[STYLEITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Styleitems> FKId(string id ) 
         { 
            string q = " SELECT " + STYLEITEMS.STYLEITEMS_TBL +".* \r\n"; 
            q += ", "+ STYLE.STYLE_TBL + "."+ STYLE.STYLE_NO + " \r\n"; 
            q += ", "+ PRODUCT.PRODUCT_TBL + "."+ PRODUCT.PRODUCT_NAME + " \r\n"; 
            q += ", "+ COLOURS.COLOURS_TBL + "."+ COLOURS.COLOURS_NAME + " \r\n"; 
            q += ", "+ SIZES.SIZES_TBL + "."+ SIZES.SIZES_NAME + " \r\n"; 
            q += " FROM  " + STYLEITEMS.STYLEITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + STYLE.STYLE_TBL + "\r\n";  
            q += " ON(" + STYLEITEMS.STYLEITEMS_TBL + "." + STYLEITEMS.STYLE_ID + " = " + STYLE.STYLE_TBL + "." + STYLE.STYLE_ID+" )\r\n";  
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";  
            q += " ON(" + STYLEITEMS.STYLEITEMS_TBL + "." + STYLEITEMS.STYLE_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + "\r\n";  
            q += " ON(" + STYLEITEMS.STYLEITEMS_TBL + "." + STYLEITEMS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID+" )\r\n";  
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";  
            q += " ON(" + STYLEITEMS.STYLEITEMS_TBL + "." + STYLEITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID+" )\r\n";  
            q += " WHERE " + STYLEITEMS.STYLEITEMS_TBL + "." + STYLE.STYLE_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + STYLEITEMS.STYLEITEMS_TBL + "." + STYLEITEMS.STYLEITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
