// Version : 3 dt : 01-08-2017
// Auto Generated
// 23-08-2017 10:05:48 AM
// last update : 23-08-2017

using System.Collections.Generic;
using CXLIB;

namespace CXUPVC
{
    public class CUpvc_quotationitems 
    {
        #region[Attach params]
        
        private static string AttachParams(string q, Upvc_quotationitems v)
        {
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID + "@", "" + ConvertTO.SqlString(v.Upvc_quotation_id) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.WIDTHS + "@", "" + ConvertTO.SqlString(v.Widths) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.HEIGHTS + "@", "" + ConvertTO.SqlString(v.Heights) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.AREASQ + "@", "" + ConvertTO.SqlString(v.Areasq) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.PRICE + "@", "" + ConvertTO.SqlString(v.Price) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Sgst_percent) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Cgst_percent) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Igst_percent) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + UPVC_QUOTATIONITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Upvc_quotationitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Upvc_quotationitems obj = new Upvc_quotationitems()
                {
                    Upvc_quotation_id = list[i].Upvc_quotation_id,
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
        
        public static void InsertSub(Upvc_quotationitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL + " ( ";
                q += " " + UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.PRODUCT_ID + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.WIDTHS + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.HEIGHTS + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.AREASQ + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.QTY + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.PRICE + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.SGST_PERCENT + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.CGST_PERCENT + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.IGST_PERCENT + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.REFERED_ID + " \r\n ";
                q += "," + UPVC_QUOTATIONITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.WIDTHS + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.HEIGHTS + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.AREASQ + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.QTY + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.PRICE + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.SGST_PERCENT + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.CGST_PERCENT + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.IGST_PERCENT + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.REFERED_ID + "@ \r\n ";
                q += ", @"+ UPVC_QUOTATIONITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + UPVC_QUOTATIONITEMS.UPVC_QUOTATIONITEMS_TBL+ " WHERE " + UPVC_QUOTATIONITEMS.UPVC_QUOTATION_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
