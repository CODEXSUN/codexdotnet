// Version : 3 dt : 01-08-2017
// Auto Generated
// 23-08-2017 10:05:48 AM
// last update : 23-08-2017

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CUpvc_invoiceitems 
    {
        #region[Attach params]
        
        private static string AttachParams(string q, Upvc_invoiceitems v)
        {
            q = q.Replace("@" + UPVC_INVOICEITEMS.UPVC_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Upvc_invoice_id) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.WIDTHS + "@", "" + ConvertTO.SqlString(v.Widths) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.HEIGHTS + "@", "" + ConvertTO.SqlString(v.Heights) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.AREASQ + "@", "" + ConvertTO.SqlString(v.Areasq) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.PRICE + "@", "" + ConvertTO.SqlString(v.Price) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Sgst_percent) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Cgst_percent) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Igst_percent) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + UPVC_INVOICEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Upvc_invoiceitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Upvc_invoiceitems obj = new Upvc_invoiceitems()
                {
                    Upvc_invoice_id = list[i].Upvc_invoice_id,
                    Product_id = list[i].Product_id,
                    Widths = list[i].Widths,
                    Heights = list[i].Heights,
                    Areasq = list[i].Areasq,
                    Qty = list[i].Qty,
                    Price = list[i].Price,
                    Sgst_percent = list[i].Sgst_percent,
                    Cgst_percent = list[i].Cgst_percent,
                    Igst_percent = list[i].Igst_percent,
                    Refered_id = list[i].Refered_id,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Upvc_invoiceitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL + " ( ";
                q += " " + UPVC_INVOICEITEMS.UPVC_INVOICE_ID + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.PRODUCT_ID + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.WIDTHS + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.HEIGHTS + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.AREASQ + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.QTY + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.PRICE + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.SGST_PERCENT + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.CGST_PERCENT + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.IGST_PERCENT + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.REFERED_ID + " \r\n ";
                q += "," + UPVC_INVOICEITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ UPVC_INVOICEITEMS.UPVC_INVOICE_ID + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.WIDTHS + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.HEIGHTS + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.AREASQ + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.QTY + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.PRICE + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.SGST_PERCENT + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.CGST_PERCENT + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.IGST_PERCENT + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.REFERED_ID + "@ \r\n ";
                q += ", @"+ UPVC_INVOICEITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + UPVC_INVOICEITEMS.UPVC_INVOICEITEMS_TBL+ " WHERE " + UPVC_INVOICEITEMS.UPVC_INVOICE_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
