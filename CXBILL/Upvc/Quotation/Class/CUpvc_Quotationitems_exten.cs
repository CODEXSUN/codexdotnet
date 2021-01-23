// Version : 3 dt : 01-08-2017
// Auto Generated
// 23-08-2017 10:05:48 AM
// last update : 23-08-2017

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CUpvc_Quotationitems_exten
    {
         #region[Entity List] 
  
         private static List<Upvc_Quotationitems> EntityList(string q) 
         { 
             List<Upvc_Quotationitems> list = new List<Upvc_Quotationitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Upvc_Quotationitems  obj = new  Upvc_Quotationitems () 
                     { 
                        Upvc_Quotationitems_id = redr[UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_ID].ToString(), 
                        Upvc_Quotation_id = redr[UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Widths = redr[UPVC_QUOTATIONITEMS.WIDTHS].ToString(),
                        Heights = redr[UPVC_QUOTATIONITEMS.HEIGHTS].ToString(),
                        Areasq = redr[UPVC_QUOTATIONITEMS.AREASQ].ToString(),
                        Qty = redr[UPVC_QUOTATIONITEMS.QTY].ToString(),
                        Price = redr[UPVC_QUOTATIONITEMS.PRICE].ToString(),
                        Sgst_percent = redr[UPVC_QUOTATIONITEMS.SGST_PERCENT].ToString(),
                        Cgst_percent = redr[UPVC_QUOTATIONITEMS.CGST_PERCENT].ToString(),
                        Igst_percent = redr[UPVC_QUOTATIONITEMS.IGST_PERCENT].ToString(),
                        Refered_id = redr[UPVC_QUOTATIONITEMS.REFERED_ID].ToString(),
                        Locked = redr[UPVC_QUOTATIONITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Upvc_Quotationitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL +".* \r\n"; 
            q += ", "+ UPVC_QUOTATION.UPVC_QUOTATION_TBL + "."+ UPVC_QUOTATION.QUOTATION_NO + " \r\n"; 
            q += ", "+ PRODUCT.PRODUCT_TBL + "."+ PRODUCT.PRODUCT_NAME + " \r\n"; 
            q += " FROM  " + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "\r\n";  
            q += " ON(" + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL + "." + UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID + " = " + UPVC_QUOTATION.UPVC_QUOTATION_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_ID+" )\r\n";  
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";  
            q += " ON(" + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL + "." + UPVC_QUOTATIONITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " WHERE " + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL + "." + UPVC_QUOTATION.UPVC_QUOTATION_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL + "." + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
