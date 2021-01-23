// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public static class COrderitems_exten
    {
         #region[Entity List] 
  
         private static List<Orderitems> EntityList(string q) 
         { 
             List<Orderitems> list = new List<Orderitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Orderitems  obj = new  Orderitems () 
                     { 
                        Orderitems_id = redr[ORDERITEMS.ORDERITEMS_ID].ToString(), 
                        Order_id = redr[ORDERITEMS.ORDER_ID].ToString(),
                        Order_no = redr[ORDERITEMS.ORDER_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Colours_id = redr[COLOURS.COLOURS_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[ORDERITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[ORDERITEMS.PRICE].ToString()),
                        Refered_id = redr[ORDERITEMS.REFERED_ID].ToString(),
                        Locked = redr[ORDERITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Orderitems> FKId(string id ) 
         { 
            string q = " SELECT " + ORDERITEMS.ORDERITEMS_TBL +".* \r\n"; 
            q += ", "+ ORDER.ORDER_TBL + "."+ ORDER.ORDER_NO + " \r\n"; 
            q += ", "+ PRODUCT.PRODUCT_TBL + "."+ PRODUCT.PRODUCT_NAME + " \r\n"; 
            q += ", "+ COLOURS.COLOURS_TBL + "."+ COLOURS.COLOURS_NAME + " \r\n"; 
            q += ", "+ SIZES.SIZES_TBL + "."+ SIZES.SIZES_NAME + " \r\n"; 
            q += " FROM  " + ORDERITEMS.ORDERITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + ORDER.ORDER_TBL + "\r\n";  
            q += " ON(" + ORDERITEMS.ORDERITEMS_TBL + "." + ORDERITEMS.ORDER_ID + " = " + ORDER.ORDER_TBL + "." + ORDER.ORDER_ID+" )\r\n";  
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";  
            q += " ON(" + ORDERITEMS.ORDERITEMS_TBL + "." + ORDERITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + "\r\n";  
            q += " ON(" + ORDERITEMS.ORDERITEMS_TBL + "." + ORDERITEMS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID+" )\r\n";  
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";  
            q += " ON(" + ORDERITEMS.ORDERITEMS_TBL + "." + ORDERITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID+" )\r\n";  
            q += " WHERE " + ORDERITEMS.ORDERITEMS_TBL + "." + ORDER.ORDER_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + ORDERITEMS.ORDERITEMS_TBL + "." + ORDERITEMS.ORDERITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
