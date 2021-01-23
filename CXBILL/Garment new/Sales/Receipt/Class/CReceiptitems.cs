// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:13 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CReceiptitems 
    {

        #region[Get New]

        public static List<Receiptitems> GetNew
        {
            get
            {
            List<Receiptitems> list = new List<Receiptitems>();

                Receiptitems obj = new Receiptitems()
                {
                    Receiptitems_id = string.Empty,
                    Receipt_id = string.Empty,
                    Receipt_by = string.Empty,
                    Invoiced_no = string.Empty,
                    Invoiced_amount = string.Empty,
                    Receipt_amount =  decimal.Zero,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Receiptitems v)
        {
            q = q.Replace("@" + RECEIPTITEMS.RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Receipt_id) + "");
            q = q.Replace("@" + RECEIPTITEMS.RECEIPT_BY + "@", "" + ConvertTO.SqlString(v.Receipt_by) + "");
            q = q.Replace("@" + RECEIPTITEMS.INVOICED_NO + "@", "" + ConvertTO.SqlString(v.Invoiced_no) + "");
            q = q.Replace("@" + RECEIPTITEMS.INVOICED_AMOUNT + "@", "" + ConvertTO.SqlString(v.Invoiced_amount) + "");
            q = q.Replace("@" + RECEIPTITEMS.RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlDecimal(v.Receipt_amount) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Receiptitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Receiptitems obj = new Receiptitems()
                {
                    Receipt_id = list[i].Receipt_id,
                    Receipt_by = list[i].Receipt_by,
                    Invoiced_no = list[i].Invoiced_no,
                    Invoiced_amount = list[i].Invoiced_amount,
                    Receipt_amount = list[i].Receipt_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Receiptitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + RECEIPTITEMS.RECEIPTITEMS_TBL + " ( ";
                q += " " + RECEIPTITEMS.RECEIPT_ID + " \r\n ";
                q += "," + RECEIPTITEMS.RECEIPT_BY + " \r\n ";
                q += "," + RECEIPTITEMS.INVOICED_NO + " \r\n ";
                q += "," + RECEIPTITEMS.INVOICED_AMOUNT + " \r\n ";
                q += "," + RECEIPTITEMS.RECEIPT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ RECEIPTITEMS.RECEIPT_ID + "@ \r\n ";
                q += ", @"+ RECEIPTITEMS.RECEIPT_BY + "@ \r\n ";
                q += ", @"+ RECEIPTITEMS.INVOICED_NO + "@ \r\n ";
                q += ", @"+ RECEIPTITEMS.INVOICED_AMOUNT + "@ \r\n ";
                q += ", @"+ RECEIPTITEMS.RECEIPT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + RECEIPTITEMS.RECEIPTITEMS_TBL+ " WHERE " + RECEIPTITEMS.RECEIPT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
