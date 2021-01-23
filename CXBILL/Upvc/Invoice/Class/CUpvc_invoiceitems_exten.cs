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
    public class CUpvc_invoiceitems_exten
    {
         #region[Entity List] 
  
         private static List<Upvc_invoiceitems> EntityList(string q) 
         { 
             List<Upvc_invoiceitems> list = new List<Upvc_invoiceitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Upvc_invoiceitems  obj = new  Upvc_invoiceitems () 
                     { 
                        Upvc_invoiceitems_id = redr[UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_ID].ToString(), 
                        Upvc_invoice_id = redr[UPVC_INVOICEITEMS.UPVC_INVOICE_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Widths = redr[UPVC_INVOICEITEMS.WIDTHS].ToString(),
                        Heights = redr[UPVC_INVOICEITEMS.HEIGHTS].ToString(),
                        Areasq = redr[UPVC_INVOICEITEMS.AREASQ].ToString(),
                        Qty = redr[UPVC_INVOICEITEMS.QTY].ToString(),
                        Price = redr[UPVC_INVOICEITEMS.PRICE].ToString(),
                        Sgst_percent = redr[UPVC_INVOICEITEMS.SGST_PERCENT].ToString(),
                        Cgst_percent = redr[UPVC_INVOICEITEMS.CGST_PERCENT].ToString(),
                        Igst_percent = redr[UPVC_INVOICEITEMS.IGST_PERCENT].ToString(),
                        Refered_id = redr[UPVC_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[UPVC_INVOICEITEMS.LOCKED].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Upvc_invoiceitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL +".* \r\n"; 
            q += ", "+ UPVC_INVOICE.UPVC_INVOICE_TBL + "."+ UPVC_INVOICE.INVOICE_NO + " \r\n"; 
            q += ", "+ PRODUCT.PRODUCT_TBL + "."+ PRODUCT.PRODUCT_NAME + " \r\n"; 
            q += " FROM  " + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + UPVC_INVOICE.UPVC_INVOICE_TBL + "\r\n";  
            q += " ON(" + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL + "." + UPVC_INVOICEITEMS.UPVC_INVOICE_ID + " = " + UPVC_INVOICE.UPVC_INVOICE_TBL + "." + UPVC_INVOICE.UPVC_INVOICE_ID+" )\r\n";  
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";  
            q += " ON(" + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL + "." + UPVC_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID+" )\r\n";  
            q += " WHERE " + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL + "." + UPVC_INVOICE.UPVC_INVOICE_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL + "." + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
