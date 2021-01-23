// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CGarment_invoiceitems
    {

        #region[Get New]

        public static List<Garment_invoiceitems> GetNew
        {
            get
            {
                List<Garment_invoiceitems> list = new List<Garment_invoiceitems>();

                Garment_invoiceitems obj = new Garment_invoiceitems()
                {
                    Garment_invoiceitems_id = string.Empty,
                    Garment_invoice_id = string.Empty,
                    Garment_invoice_no = string.Empty,
                    Product_id = string.Empty,
                    Qty = decimal.Zero,
                    Price = decimal.Zero,
                    Sgst_percent = decimal.Zero,
                    Cgst_percent = decimal.Zero,
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

        private static string AttachParams(string q, Garment_invoiceitems v)
        {
            q = q.Replace("@" + GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Garment_invoice_id) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Garment_invoice_no) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.QTY + "@", "" + ConvertTO.SqlDecimal(v.Qty) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.PRICE + "@", "" + ConvertTO.SqlDecimal(v.Price) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlDecimal(v.Sgst_percent) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlDecimal(v.Cgst_percent) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlDecimal(v.Igst_percent) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + GARMENT_INVOICEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Garment_invoiceitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Garment_invoiceitems obj = new Garment_invoiceitems()
                {
                    Garment_invoice_id = list[i].Garment_invoice_id,
                    Garment_invoice_no = list[i].Garment_invoice_no,
                    Product_id = list[i].Product_id,
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

        public static void InsertSub(Garment_invoiceitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + " ( ";
            q += " " + GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.PRODUCT_ID + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.QTY + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.PRICE + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.SGST_PERCENT + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.CGST_PERCENT + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.IGST_PERCENT + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.REFERED_ID + " \r\n ";
            q += "," + GARMENT_INVOICEITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.QTY + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.PRICE + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + GARMENT_INVOICEITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + " WHERE " + GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
