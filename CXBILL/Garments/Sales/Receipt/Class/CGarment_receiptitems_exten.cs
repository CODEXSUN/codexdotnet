// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:14 AM
// last update : 13-03-2018

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXBILL
{
    public class CGarment_receiptitems_exten
    {
         #region[Entity List] 
  
         private static List<Garment_receiptitems> EntityList(string q) 
         { 
             List<Garment_receiptitems> list = new List<Garment_receiptitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Garment_receiptitems  obj = new  Garment_receiptitems () 
                     { 
                        Garment_receiptitems_id = redr[GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_ID].ToString(), 
                        Garment_receipt_id = redr[GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID].ToString(),
                        Receipt_by = redr[GARMENT_RECEIPTITEMS.RECEIPT_BY].ToString(),
                        Garment_invoiced_no = redr[GARMENT_RECEIPTITEMS.GARMENT_INVOICED_NO].ToString(),
                        Garment_invoiced_amount = ConvertTO.Decimal(redr[GARMENT_RECEIPTITEMS.GARMENT_INVOICED_AMOUNT].ToString()),
                        Garment_receipt_amount = ConvertTO.Decimal(redr[GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_AMOUNT].ToString()),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Garment_receiptitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL +".* \r\n"; 
            q += ", "+ GARMENT_RECEIPT.GARMENT_RECEIPT_TBL + "."+ GARMENT_RECEIPT.GARMENT_RECEIPT_NO + " \r\n"; 
            q += " FROM  " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + GARMENT_RECEIPT.GARMENT_RECEIPT_TBL + "\r\n";  
            q += " ON(" + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL + "." + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID + " = " + GARMENT_RECEIPT.GARMENT_RECEIPT_TBL + "." + GARMENT_RECEIPT.GARMENT_RECEIPT_ID+" )\r\n";  
            q += " WHERE " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL + "." + GARMENT_RECEIPT.GARMENT_RECEIPT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL + "." + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
