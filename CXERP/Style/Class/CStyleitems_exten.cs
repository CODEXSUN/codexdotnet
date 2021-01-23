// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXERP
{
    public static class CArticleitems_exten
    {
         #region[Entity List] 
  
         private static List<Articleitems> EntityList(string q) 
         { 
             List<Articleitems> list = new List<Articleitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Articleitems  obj = new  Articleitems () 
                     { 
                        Articleitems_id = redr[ARTICLEITEMS.ARTICLEITEMS_ID].ToString(), 
                        Article_id = redr[ARTICLEITEMS.ARTICLE_ID].ToString(),
                        Article_no = redr[ARTICLEITEMS.ARTICLE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Colours_id = redr[COLOURS.COLOURS_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[ARTICLEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[ARTICLEITEMS.PRICE].ToString()),
                        Refered_id = redr[ARTICLEITEMS.REFERED_ID].ToString(),
                        Locked = redr[ARTICLEITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Articleitems> FKId(string id ) 
         { 
            string q = " SELECT " + ARTICLEITEMS.ARTICLEITEMS_TBL +".* \r\n"; 
            q += ", "+ ARTICLE.ARTICLE_TBL + "."+ ARTICLE.ARTICLE_NO + " \r\n"; 
            q += ", "+ PRODUCT.PRODUCT_TBL + "."+ PRODUCT.PRODUCT_NAME + " \r\n"; 
            q += ", "+ COLOURS.COLOURS_TBL + "."+ COLOURS.COLOURS_NAME + " \r\n"; 
            q += ", "+ SIZES.SIZES_TBL + "."+ SIZES.SIZES_NAME + " \r\n"; 
            q += " FROM  " + ARTICLEITEMS.ARTICLEITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + ARTICLE.ARTICLE_TBL + "\r\n";  
            q += " ON(" + ARTICLEITEMS.ARTICLEITEMS_TBL + "." + ARTICLEITEMS.ARTICLE_ID + " = " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_ID+" )\r\n";  
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";  
            q += " ON(" + ARTICLEITEMS.ARTICLEITEMS_TBL + "." + ARTICLEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + "\r\n";  
            q += " ON(" + ARTICLEITEMS.ARTICLEITEMS_TBL + "." + ARTICLEITEMS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID+" )\r\n";  
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";  
            q += " ON(" + ARTICLEITEMS.ARTICLEITEMS_TBL + "." + ARTICLEITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID+" )\r\n";  
            q += " WHERE " + ARTICLEITEMS.ARTICLEITEMS_TBL + "." + ARTICLE.ARTICLE_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + ARTICLEITEMS.ARTICLEITEMS_TBL + "." + ARTICLEITEMS.ARTICLEITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
