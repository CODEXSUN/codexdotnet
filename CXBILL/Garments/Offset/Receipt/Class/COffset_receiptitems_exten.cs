// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:14 AM
// last update : 13-03-2018

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_receiptitems_exten
    {
         #region[Entity List] 
  
         private static List<Offset_receiptitems> EntityList(string q) 
         { 
             List<Offset_receiptitems> list = new List<Offset_receiptitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Offset_receiptitems  obj = new  Offset_receiptitems () 
                     { 
                        Offset_receiptitems_id = redr[OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_ID].ToString(), 
                        Offset_receipt_id = redr[OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID].ToString(),
                        Receipt_by = redr[OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY].ToString(),
                        Offset_invoiced_no = redr[OFFSET_RECEIPTITEMS.OFFSET_INVOICED_NO].ToString(),
                        Offset_invoiced_amount = ConvertTO.Decimal(redr[OFFSET_RECEIPTITEMS.OFFSET_INVOICED_AMOUNT].ToString()),
                        Offset_receipt_amount = ConvertTO.Decimal(redr[OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_AMOUNT].ToString()),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Offset_receiptitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL +".* \r\n"; 
            q += ", "+ OFFSET_RECEIPT.OFFSET_RECEIPT_TBL + "."+ OFFSET_RECEIPT.OFFSET_RECEIPT_NO + " \r\n"; 
            q += " FROM  " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + OFFSET_RECEIPT.OFFSET_RECEIPT_TBL + "\r\n";  
            q += " ON(" + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL + "." + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID + " = " + OFFSET_RECEIPT.OFFSET_RECEIPT_TBL + "." + OFFSET_RECEIPT.OFFSET_RECEIPT_ID+" )\r\n";  
            q += " WHERE " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL + "." + OFFSET_RECEIPT.OFFSET_RECEIPT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL + "." + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
