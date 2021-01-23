// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System.Collections.Generic;
using CXLIB;

namespace CXKNITTING
{
    public class CReceiptitems 
    {

        #region[Get New]

        public static List<Knitting_Receiptitems> GetNew
        {
            get
            {
            List<Knitting_Receiptitems> list = new List<Knitting_Receiptitems>();

                Knitting_Receiptitems obj = new Knitting_Receiptitems()
                {
                    Knitting_Receiptitems_id = string.Empty,
                    Knitting_Receipt_id = string.Empty,
                    Receipt_by = string.Empty,
                    Knitting_Invoiced_no = string.Empty,
                    Knitting_Invoiced_amount = decimal.Zero,
                    Receipt_amount = decimal.Zero,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Knitting_Receiptitems v)
        {
            q = q.Replace("@" + KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Knitting_Receipt_id) + "");
            q = q.Replace("@" + KNITTING_RECEIPTITEMS.RECEIPT_BY + "@", "" + ConvertTO.SqlString(v.Receipt_by) + "");
            q = q.Replace("@" + KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO + "@", "" + ConvertTO.SqlString(v.Knitting_Invoiced_no) + "");
            q = q.Replace("@" + KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT + "@", "" + ConvertTO.SqlString(v.Knitting_Invoiced_amount + ""));
            q = q.Replace("@" + KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Receipt_amount + ""));
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Knitting_Receiptitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Knitting_Receiptitems obj = new Knitting_Receiptitems()
                {
                    Knitting_Receipt_id = list[i].Knitting_Receipt_id,
                    Receipt_by = list[i].Receipt_by,
                    Knitting_Invoiced_no = list[i].Knitting_Invoiced_no,
                    Knitting_Invoiced_amount = list[i].Knitting_Invoiced_amount,
                    Receipt_amount = list[i].Receipt_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Knitting_Receiptitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL + " ( ";
                q += " " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID + " \r\n ";
                q += "," + KNITTING_RECEIPTITEMS.RECEIPT_BY + " \r\n ";
                q += "," + KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO + " \r\n ";
                q += "," + KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT + " \r\n ";
                q += "," + KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID + "@ \r\n ";
                q += ", @"+ KNITTING_RECEIPTITEMS.RECEIPT_BY + "@ \r\n ";
                q += ", @"+ KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO + "@ \r\n ";
                q += ", @"+ KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT + "@ \r\n ";
                q += ", @"+ KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL+ " WHERE " + KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
