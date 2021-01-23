// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 13-03-2018 10:59:14 AM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CQreceiptitems 
    {

        #region[Get New]

        public static List<QReceiptitems> GetNew
        {
            get
            {
            List<QReceiptitems> list = new List<QReceiptitems>();

                QReceiptitems obj = new QReceiptitems()
                {
                    Qreceiptitems_id = string.Empty,
                    Qreceipt_id = string.Empty,
                    Qreceipt_by = string.Empty,
                    Quotation_no = string.Empty,
                    Quotation_amount = decimal.Zero,
                    Qreceipt_amount = decimal.Zero,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, QReceiptitems v)
        {
            q = q.Replace("@" + QRECEIPTITEMS.QRECEIPT_ID + "@", "" + ConvertTO.SqlString(v.Qreceipt_id) + "");
            q = q.Replace("@" + QRECEIPTITEMS.QRECEIPT_BY + "@", "" + ConvertTO.SqlString(v.Qreceipt_by) + "");
            q = q.Replace("@" + QRECEIPTITEMS.QUOTATION_NO + "@", "" + ConvertTO.SqlString(v.Quotation_no) + "");
            q = q.Replace("@" + QRECEIPTITEMS.QUOTATION_AMOUNT + "@", "" + ConvertTO.SqlString(v.Quotation_amount + ""));
            q = q.Replace("@" + QRECEIPTITEMS.QRECEIPT_AMOUNT + "@", "" + ConvertTO.SqlString(v.Qreceipt_amount + ""));
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<QReceiptitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                QReceiptitems obj = new QReceiptitems()
                {
                    Qreceipt_id = list[i].Qreceipt_id,
                    Qreceipt_by = list[i].Qreceipt_by,
                    Quotation_no = list[i].Quotation_no,
                    Quotation_amount = list[i].Quotation_amount,
                    Qreceipt_amount = list[i].Qreceipt_amount
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(QReceiptitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + QRECEIPTITEMS.QRECEIPTITEMS_TBL + " ( ";
                q += " " + QRECEIPTITEMS.QRECEIPT_ID + " \r\n ";
                q += "," + QRECEIPTITEMS.QRECEIPT_BY + " \r\n ";
                q += "," + QRECEIPTITEMS.QUOTATION_NO + " \r\n ";
                q += "," + QRECEIPTITEMS.QUOTATION_AMOUNT + " \r\n ";
                q += "," + QRECEIPTITEMS.QRECEIPT_AMOUNT + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ QRECEIPTITEMS.QRECEIPT_ID + "@ \r\n ";
                q += ", @"+ QRECEIPTITEMS.QRECEIPT_BY + "@ \r\n ";
                q += ", @"+ QRECEIPTITEMS.QUOTATION_NO + "@ \r\n ";
                q += ", @"+ QRECEIPTITEMS.QUOTATION_AMOUNT + "@ \r\n ";
                q += ", @"+ QRECEIPTITEMS.QRECEIPT_AMOUNT + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + QRECEIPTITEMS.QRECEIPTITEMS_TBL+ " WHERE " + QRECEIPTITEMS.QRECEIPT_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
