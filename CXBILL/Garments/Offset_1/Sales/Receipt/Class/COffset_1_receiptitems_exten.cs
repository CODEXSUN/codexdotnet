// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:14 AM
// last update : 13-03-2018

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_1_receiptitems_exten
    {
         #region[Entity List] 
  
         private static List<Offset_1_receiptitems> EntityList(string q) 
         { 
             List<Offset_1_receiptitems> list = new List<Offset_1_receiptitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Offset_1_receiptitems  obj = new  Offset_1_receiptitems () 
                     { 
                        Offset_1_receiptitems_id = redr[OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_ID].ToString(), 
                        Offset_1_receipt_id = redr[OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID].ToString(),
                        Receipt_by = redr[OFFSET_1_RECEIPTITEMS.RECEIPT_BY].ToString(),
                        Garment_invoiced_no = redr[OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_NO].ToString(),
                        Garment_invoiced_amount = ConvertTO.Decimal(redr[OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_AMOUNT].ToString()),
                        Offset_1_receipt_amount = ConvertTO.Decimal(redr[OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_AMOUNT].ToString()),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Offset_1_receiptitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL +".* \r\n"; 
            q += ", "+ OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "."+ OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO + " \r\n"; 
            q += " FROM  " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "\r\n";  
            q += " ON(" + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL + "." + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID + " = " + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID+" )\r\n";  
            q += " WHERE " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL + "." + OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL + "." + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
