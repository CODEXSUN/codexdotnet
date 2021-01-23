// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CGarment_receiptitems 
    {

        #region[Get New]

        public static List<Garment_receiptitems> GetNew
        {
            get
            {
            List<Garment_receiptitems> list = new List<Garment_receiptitems>();

                Garment_receiptitems obj = new Garment_receiptitems()
                {
                    Garment_receiptitems_id = string.Empty,
                    Garment_receipt_id = string.Empty,
                    Receipt_by = string.Empty,
                    Garment_invoiced_no = string.Empty,
                    Garment_invoiced_amount = decimal.Zero,
                    Garment_receipt_amount = decimal.Zero,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Garment_receiptitems v)
        {
            q = q.Replace("@" + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Garment_receipt_id) + "");
            q = q.Replace("@" + GARMENT_RECEIPTITEMS.RECEIPT_BY + "@", "" + ConvertTO.SqlString(v.Receipt_by) + "");
            q = q.Replace("@" + GARMENT_RECEIPTITEMS.GARMENT_INVOICED_NO + "@", "" + ConvertTO.SqlString(v.Garment_invoiced_no) + "");
            q = q.Replace("@" + GARMENT_RECEIPTITEMS.GARMENT_INVOICED_AMOUNT + "@", "" + ConvertTO.SqlString(v.Garment_invoiced_amount + ""));
            q = q.Replace("@" + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Garment_receipt_amount + ""));
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Garment_receiptitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Garment_receiptitems obj = new Garment_receiptitems()
                {
                    Garment_receipt_id = list[i].Garment_receipt_id,
                    Receipt_by = list[i].Receipt_by,
                    Garment_invoiced_no = list[i].Garment_invoiced_no,
                    Garment_invoiced_amount = list[i].Garment_invoiced_amount,
                    Garment_receipt_amount = list[i].Garment_receipt_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Garment_receiptitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL + " ( ";
                q += " " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID + " \r\n ";
                q += "," + GARMENT_RECEIPTITEMS.RECEIPT_BY + " \r\n ";
                q += "," + GARMENT_RECEIPTITEMS.GARMENT_INVOICED_NO + " \r\n ";
                q += "," + GARMENT_RECEIPTITEMS.GARMENT_INVOICED_AMOUNT + " \r\n ";
                q += "," + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID + "@ \r\n ";
                q += ", @"+ GARMENT_RECEIPTITEMS.RECEIPT_BY + "@ \r\n ";
                q += ", @"+ GARMENT_RECEIPTITEMS.GARMENT_INVOICED_NO + "@ \r\n ";
                q += ", @"+ GARMENT_RECEIPTITEMS.GARMENT_INVOICED_AMOUNT + "@ \r\n ";
                q += ", @"+ GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL+ " WHERE " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
