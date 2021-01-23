// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// 13-03-2018 10:59:14 AM
// last update : 13-03-2018

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXBILL
{
    public class CQreceiptitems_exten
    {
         #region[Entity List] 
  
         private static List<QReceiptitems> EntityList(string q) 
         { 
             List<QReceiptitems> list = new List<QReceiptitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      QReceiptitems  obj = new  QReceiptitems () 
                     { 
                        Qreceiptitems_id = redr[QRECEIPTITEMS.QRECEIPTITEMS_ID].ToString(), 
                        Qreceipt_id = redr[QRECEIPTITEMS.QRECEIPT_ID].ToString(),
                        Qreceipt_by = redr[QRECEIPTITEMS.QRECEIPT_BY].ToString(),
                        Quotation_no = redr[QRECEIPTITEMS.QUOTATION_NO].ToString(),
                        Quotation_amount = ConvertTO.Decimal(redr[QRECEIPTITEMS.QUOTATION_AMOUNT].ToString()),
                        Qreceipt_amount = ConvertTO.Decimal(redr[QRECEIPTITEMS.QRECEIPT_AMOUNT].ToString()),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<QReceiptitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + QRECEIPTITEMS.QRECEIPTITEMS_TBL +".* \r\n"; 
            q += ", "+ QRECEIPT.QRECEIPT_TBL + "."+ QRECEIPT.QRECEIPT_NO + " \r\n"; 
            q += " FROM  " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + " \r\n"; 
            q += " INNER JOIN  " + QRECEIPT.QRECEIPT_TBL + "\r\n";  
            q += " ON(" + QRECEIPTITEMS.QRECEIPTITEMS_TBL + "." + QRECEIPTITEMS.QRECEIPT_ID + " = " + QRECEIPT.QRECEIPT_TBL + "." + QRECEIPT.QRECEIPT_ID+" )\r\n";  
            q += " WHERE " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + "." + QRECEIPT.QRECEIPT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + "." + QRECEIPTITEMS.QRECEIPTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
