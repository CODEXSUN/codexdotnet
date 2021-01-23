// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXKNITTING
{
    public class CReceiptitems_exten
    {
         #region[Entity List] 
  
         private static List<Knitting_Receiptitems> EntityList(string q) 
         { 
             List<Knitting_Receiptitems> list = new List<Knitting_Receiptitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Knitting_Receiptitems  obj = new  Knitting_Receiptitems () 
                     { 
                        Knitting_Receiptitems_id = redr[KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_ID].ToString(), 
                        Knitting_Receipt_id = redr[KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID].ToString(),
                        Receipt_by = redr[KNITTING_RECEIPTITEMS.RECEIPT_BY].ToString(),
                        Knitting_Invoiced_no = redr[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO].ToString(),
                        Knitting_Invoiced_amount = ConvertTO.Decimal(redr[KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT].ToString()),
                        Receipt_amount = ConvertTO.Decimal(redr[KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT].ToString()),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Knitting_Receiptitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL +".* \r\n"; 
            q += ", "+ KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "."+ KNITTING_RECEIPT.KNITTING_RECEIPT_NO + " \r\n"; 
            q += " FROM  " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "\r\n";  
            q += " ON(" + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL + "." + KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID + " = " + KNITTING_RECEIPT.KNITTING_RECEIPT_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_ID+" )\r\n";  
            q += " WHERE " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL + "." + KNITTING_RECEIPT.KNITTING_RECEIPT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL + "." + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
