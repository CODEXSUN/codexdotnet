// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class COffset_1_receiptitems 
    {

        #region[Get New]

        public static List<Offset_1_receiptitems> GetNew
        {
            get
            {
            List<Offset_1_receiptitems> list = new List<Offset_1_receiptitems>();

                Offset_1_receiptitems obj = new Offset_1_receiptitems()
                {
                    Offset_1_receiptitems_id = string.Empty,
                    Offset_1_receipt_id = string.Empty,
                    Receipt_by = string.Empty,
                    Garment_invoiced_no = string.Empty,
                    Garment_invoiced_amount = decimal.Zero,
                    Offset_1_receipt_amount = decimal.Zero,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Offset_1_receiptitems v)
        {
            q = q.Replace("@" + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Offset_1_receipt_id) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPTITEMS.RECEIPT_BY + "@", "" + ConvertTO.SqlString(v.Receipt_by) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_NO + "@", "" + ConvertTO.SqlString(v.Garment_invoiced_no) + "");
            q = q.Replace("@" + OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_AMOUNT + "@", "" + ConvertTO.SqlString(v.Garment_invoiced_amount + ""));
            q = q.Replace("@" + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Offset_1_receipt_amount + ""));
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Offset_1_receiptitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Offset_1_receiptitems obj = new Offset_1_receiptitems()
                {
                    Offset_1_receipt_id = list[i].Offset_1_receipt_id,
                    Receipt_by = list[i].Receipt_by,
                    Garment_invoiced_no = list[i].Garment_invoiced_no,
                    Garment_invoiced_amount = list[i].Garment_invoiced_amount,
                    Offset_1_receipt_amount = list[i].Offset_1_receipt_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Offset_1_receiptitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL + " ( ";
                q += " " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID + " \r\n ";
                q += "," + OFFSET_1_RECEIPTITEMS.RECEIPT_BY + " \r\n ";
                q += "," + OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_NO + " \r\n ";
                q += "," + OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_AMOUNT + " \r\n ";
                q += "," + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID + "@ \r\n ";
                q += ", @"+ OFFSET_1_RECEIPTITEMS.RECEIPT_BY + "@ \r\n ";
                q += ", @"+ OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_NO + "@ \r\n ";
                q += ", @"+ OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_AMOUNT + "@ \r\n ";
                q += ", @"+ OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL+ " WHERE " + OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
