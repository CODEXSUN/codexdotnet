// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// 16-12-2018 01:30:02 PM
// last update : 16-12-2018

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXBILL
{
    public class CPaymentitems_exten
    {
         #region[Entity List] 
  
         private static List<Paymentitems> EntityList(string q) 
         { 
             List<Paymentitems> list = new List<Paymentitems>(); 
  
             using (IDataReader redr = new DAL().Listreader(q)) 
             { 
                 while (redr.Read() == true) 
                 { 
                      Paymentitems  obj = new  Paymentitems () 
                     { 
                        Paymentitems_id = redr[PAYMENTITEMS.PAYMENTITEMS_ID].ToString(), 
                        Payment_id = redr[PAYMENTITEMS.PAYMENT_ID].ToString(),
                        Payment_by = redr[PAYMENTITEMS.PAYMENT_BY].ToString(),
                        Purchase_no = redr[PAYMENTITEMS.PURCHASE_NO].ToString(),
                        Purchase_amount = redr[PAYMENTITEMS.PURCHASE_AMOUNT].ToString(),
                        Payment_amount = redr[PAYMENTITEMS.PAYMENT_AMOUNT].ToString(),
                     }; 
  
                     list.Add(obj); 
                 } 
  
             } 
             return list; 
         } 
  
         #endregion[Entity List] 
  
         #region[FKId] 
  
         public static List<Paymentitems> FKId(string id , DAL DAL) 
         { 
            string q = " SELECT " + PAYMENTITEMS.PAYMENTITEMS_TBL +".* \r\n"; 
            q += " FROM  " + PAYMENTITEMS.PAYMENTITEMS_TBL + " \r\n"; 
            q += " WHERE " + PAYMENTITEMS.PAYMENTITEMS_TBL + "." + PAYMENT.PAYMENT_ID + "  = '" + id + "' \r\n"; 
            q += " ORDER BY  " + PAYMENTITEMS.PAYMENTITEMS_TBL + "." + PAYMENTITEMS.PAYMENTITEMS_ID + ";\r\n"; 
  
             return EntityList(q); 
         } 
  
         #endregion[FKId] 
  
    }//cls
}//ns
