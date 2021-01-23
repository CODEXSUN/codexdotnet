// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXBILL_EXTEN.Invoice.Const;
using CXLIB;

namespace CXBILL_EXTEN.Invoice.Class
{
    public static class CInvoiceitems
    {

        #region[Get New]

        public static List<Invoiceitems> GetNew
        {
            get
            {
                List<Invoiceitems> list = new List<Invoiceitems>();

                Invoiceitems obj = new Invoiceitems()
                {
                    Invoiceitems_id = string.Empty,
                    Invoice_id = string.Empty,
                    Po_no = string.Empty,
                    Dc_no = string.Empty,
                    Product_id = string.Empty,
                    Sizes_id = string.Empty,
                    Qty = string.Empty,
                    Price = decimal.Zero,
                    Cgst_percent = decimal.Zero,
                    Sgst_percent = decimal.Zero,
                    Igst_percent = decimal.Zero,
                    Refered_id = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Invoiceitems v)
        {
            q = q.Replace("@" + INVOICEITEMS.INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Invoice_id) + "");
            q = q.Replace("@" + INVOICEITEMS.PO_NO + "@", "" + ConvertTO.SqlString(v.Po_no) + "");
            q = q.Replace("@" + INVOICEITEMS.DC_NO + "@", "" + ConvertTO.SqlString(v.Dc_no) + "");
            q = q.Replace("@" + INVOICEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + INVOICEITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + INVOICEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + INVOICEITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + INVOICEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Cgst_percent) + ""));
            q = q.Replace("@" + INVOICEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Sgst_percent) + ""));
            q = q.Replace("@" + INVOICEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Igst_percent) + ""));
            q = q.Replace("@" + INVOICEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + INVOICEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Invoiceitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Invoiceitems obj = new Invoiceitems()
                {
                    Invoice_id = list[i].Invoice_id,
                    Po_no = list[i].Po_no,
                    Dc_no = list[i].Dc_no,
                    Product_id = list[i].Product_id,
                    Sizes_id = list[i].Sizes_id,
                    Qty = list[i].Qty,
                    Price = list[i].Price,
                    Cgst_percent = list[i].Cgst_percent,
                    Sgst_percent = list[i].Sgst_percent,
                    Igst_percent = list[i].Igst_percent,
                    Refered_id = list[i].Refered_id,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]

        public static void InsertSub(Invoiceitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + INVOICEITEMS.INVOICEITEMS_TBL + " ( ";
            q += " " + INVOICEITEMS.INVOICE_ID + " \r\n ";
            q += "," + INVOICEITEMS.PO_NO + " \r\n ";
            q += "," + INVOICEITEMS.DC_NO + " \r\n ";
            q += "," + INVOICEITEMS.PRODUCT_ID + " \r\n ";
            q += "," + INVOICEITEMS.SIZES_ID + " \r\n ";
            q += "," + INVOICEITEMS.QTY + " \r\n ";
            q += "," + INVOICEITEMS.PRICE + " \r\n ";
            q += "," + INVOICEITEMS.CGST_PERCENT + " \r\n ";
            q += "," + INVOICEITEMS.SGST_PERCENT + " \r\n ";
            q += "," + INVOICEITEMS.IGST_PERCENT + " \r\n ";
            q += "," + INVOICEITEMS.REFERED_ID + " \r\n ";
            q += "," + INVOICEITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + INVOICEITEMS.INVOICE_ID + "@ \r\n ";
            q += ", @" + INVOICEITEMS.PO_NO + "@ \r\n ";
            q += ", @" + INVOICEITEMS.DC_NO + "@ \r\n ";
            q += ", @" + INVOICEITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + INVOICEITEMS.SIZES_ID + "@ \r\n ";
            q += ", @" + INVOICEITEMS.QTY + "@ \r\n ";
            q += ", @" + INVOICEITEMS.PRICE + "@ \r\n ";
            q += ", @" + INVOICEITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + INVOICEITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + INVOICEITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + INVOICEITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + INVOICEITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + INVOICEITEMS.INVOICEITEMS_TBL + " WHERE " + INVOICEITEMS.INVOICE_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
