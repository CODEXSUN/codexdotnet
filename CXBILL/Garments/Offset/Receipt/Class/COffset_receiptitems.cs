// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class COffset_receiptitems 
    {

        #region[Get New]

        public static List<Offset_receiptitems> GetNew
        {
            get
            {
            List<Offset_receiptitems> list = new List<Offset_receiptitems>();

                Offset_receiptitems obj = new Offset_receiptitems()
                {
                    Offset_receiptitems_id = string.Empty,
                    Offset_receipt_id = string.Empty,
                    Receipt_by = string.Empty,
                    Offset_invoiced_no = string.Empty,
                    Offset_invoiced_amount = decimal.Zero,
                    Offset_receipt_amount = decimal.Zero,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Offset_receiptitems v)
        {
            q = q.Replace("@" + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Offset_receipt_id) + "");
            q = q.Replace("@" + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY + "@", "" + ConvertTO.SqlString(v.Receipt_by) + "");
            q = q.Replace("@" + OFFSET_RECEIPTITEMS.OFFSET_INVOICED_NO + "@", "" + ConvertTO.SqlString(v.Offset_invoiced_no) + "");
            q = q.Replace("@" + OFFSET_RECEIPTITEMS.OFFSET_INVOICED_AMOUNT + "@", "" + ConvertTO.SqlString(v.Offset_invoiced_amount + ""));
            q = q.Replace("@" + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Offset_receipt_amount + ""));
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Offset_receiptitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Offset_receiptitems obj = new Offset_receiptitems()
                {
                    Offset_receipt_id = list[i].Offset_receipt_id,
                    Receipt_by = list[i].Receipt_by,
                    Offset_invoiced_no = list[i].Offset_invoiced_no,
                    Offset_invoiced_amount = list[i].Offset_invoiced_amount,
                    Offset_receipt_amount = list[i].Offset_receipt_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Offset_receiptitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL + " ( ";
                q += " " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID + " \r\n ";
                q += "," + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY + " \r\n ";
                q += "," + OFFSET_RECEIPTITEMS.OFFSET_INVOICED_NO + " \r\n ";
                q += "," + OFFSET_RECEIPTITEMS.OFFSET_INVOICED_AMOUNT + " \r\n ";
                q += "," + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID + "@ \r\n ";
                q += ", @"+ OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY + "@ \r\n ";
                q += ", @"+ OFFSET_RECEIPTITEMS.OFFSET_INVOICED_NO + "@ \r\n ";
                q += ", @"+ OFFSET_RECEIPTITEMS.OFFSET_INVOICED_AMOUNT + "@ \r\n ";
                q += ", @"+ OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL+ " WHERE " + OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
