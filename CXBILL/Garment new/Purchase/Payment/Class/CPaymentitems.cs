// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 16-12-2018 01:30:02 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CPaymentitems 
    {

        #region[Get New]

        public static List<Paymentitems> GetNew
        {
            get
            {
            List<Paymentitems> list = new List<Paymentitems>();

                Paymentitems obj = new Paymentitems()
                {
                    Paymentitems_id = string.Empty,
                    Payment_id = string.Empty,
                    Payment_by = string.Empty,
                    Purchase_no = string.Empty,
                    Purchase_amount = string.Empty,
                    Payment_amount = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Paymentitems v)
        {
            q = q.Replace("@" + PAYMENTITEMS.PAYMENT_ID + "@", "" + ConvertTO.SqlString(v.Payment_id) + "");
            q = q.Replace("@" + PAYMENTITEMS.PAYMENT_BY + "@", "" + ConvertTO.SqlString(v.Payment_by) + "");
            q = q.Replace("@" + PAYMENTITEMS.PURCHASE_NO + "@", "" + ConvertTO.SqlString(v.Purchase_no) + "");
            q = q.Replace("@" + PAYMENTITEMS.PURCHASE_AMOUNT + "@", "" + ConvertTO.SqlString(v.Purchase_amount) + "");
            q = q.Replace("@" + PAYMENTITEMS.PAYMENT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Payment_amount) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Paymentitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Paymentitems obj = new Paymentitems()
                {
                    Payment_id = list[i].Payment_id,
                    Payment_by = list[i].Payment_by,
                    Purchase_no = list[i].Purchase_no,
                    Purchase_amount = list[i].Purchase_amount,
                    Payment_amount = list[i].Payment_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Paymentitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + PAYMENTITEMS.PAYMENTITEMS_TBL + " ( ";
                q += " " + PAYMENTITEMS.PAYMENT_ID + " \r\n ";
                q += "," + PAYMENTITEMS.PAYMENT_BY + " \r\n ";
                q += "," + PAYMENTITEMS.PURCHASE_NO + " \r\n ";
                q += "," + PAYMENTITEMS.PURCHASE_AMOUNT + " \r\n ";
                q += "," + PAYMENTITEMS.PAYMENT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ PAYMENTITEMS.PAYMENT_ID + "@ \r\n ";
                q += ", @"+ PAYMENTITEMS.PAYMENT_BY + "@ \r\n ";
                q += ", @"+ PAYMENTITEMS.PURCHASE_NO + "@ \r\n ";
                q += ", @"+ PAYMENTITEMS.PURCHASE_AMOUNT + "@ \r\n ";
                q += ", @"+ PAYMENTITEMS.PAYMENT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + PAYMENTITEMS.PAYMENTITEMS_TBL+ " WHERE " + PAYMENTITEMS.PAYMENT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
