// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:14 PM

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CReceiptitems_exten
    {
         #region[Entity List] 
  
         private static List<Receiptitems> EntityList(string q) 
         { 
             List<Receiptitems> list = new List<Receiptitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Receiptitems  obj = new  Receiptitems () 
                     { 
                        Receiptitems_id = redr[RECEIPTITEMS.RECEIPTITEMS_ID].ToString(), 
                        Receipt_id = redr[RECEIPTITEMS.RECEIPT_ID].ToString(),
                        Receipt_by = redr[RECEIPTITEMS.RECEIPT_BY].ToString(),
                        Invoiced_no = redr[RECEIPTITEMS.INVOICED_NO].ToString(),
                        Invoiced_amount = redr[RECEIPTITEMS.INVOICED_AMOUNT].ToString(),
                        Receipt_amount = ConvertTO.Decimal(redr[RECEIPTITEMS.RECEIPT_AMOUNT].ToString()),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Receiptitems> FKId(string id ) 
         { 
            string q = " SELECT " + RECEIPTITEMS.RECEIPTITEMS_TBL +".* \r\n"; 
            q += ", "+ RECEIPT.RECEIPT_TBL + "."+ RECEIPT.RECEIPT_NO + " \r\n"; 
            q += " FROM  " + RECEIPTITEMS.RECEIPTITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + RECEIPT.RECEIPT_TBL + "\r\n";  
            q += " ON(" + RECEIPTITEMS.RECEIPTITEMS_TBL + "." + RECEIPTITEMS.RECEIPT_ID + " = " + RECEIPT.RECEIPT_TBL + "." + RECEIPT.RECEIPT_ID+" )\r\n";  
            q += " WHERE " + RECEIPTITEMS.RECEIPTITEMS_TBL + "." + RECEIPT.RECEIPT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + RECEIPTITEMS.RECEIPTITEMS_TBL + "." + RECEIPTITEMS.RECEIPTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
