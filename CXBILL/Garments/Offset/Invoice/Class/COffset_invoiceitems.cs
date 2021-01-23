// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class COffset_invoiceitems
    {

        #region[Get New]

        public static List<Offset_invoiceitems> GetNew
        {
            get
            {
                List<Offset_invoiceitems> list = new List<Offset_invoiceitems>();

                Offset_invoiceitems obj = new Offset_invoiceitems()
                {
                    Offset_invoiceitems_id = string.Empty,
                    Offset_invoice_id = string.Empty,
                    Offset_invoice_no = string.Empty,
                    Offset_po_id = string.Empty,
                    Offset_poitems_id = string.Empty,
                    Offset_dc_id = string.Empty,
                    Offset_dcitems_id = string.Empty,
                    Product_id = string.Empty,
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

        private static string AttachParams(string q, Offset_invoiceitems v)
        {
            q = q.Replace("@" + OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Offset_invoice_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Offset_invoice_no) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.OFFSET_PO_ID + "@", "" + ConvertTO.SqlString(v.Offset_po_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.OFFSET_POITEMS_ID + "@", "" + ConvertTO.SqlString(v.Offset_poitems_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.OFFSET_DC_ID + "@", "" + ConvertTO.SqlString(v.Offset_dc_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID + "@", "" + ConvertTO.SqlString(v.Offset_dcitems_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + OFFSET_INVOICEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Cgst_percent) + ""));
            q = q.Replace("@" + OFFSET_INVOICEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Sgst_percent) + ""));
            q = q.Replace("@" + OFFSET_INVOICEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Igst_percent) + ""));
            q = q.Replace("@" + OFFSET_INVOICEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + OFFSET_INVOICEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Offset_invoiceitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Offset_invoiceitems obj = new Offset_invoiceitems()
                {
                    Offset_invoice_id = list[i].Offset_invoice_id,
                    Offset_invoice_no = list[i].Offset_invoice_no,
                    Offset_po_id = list[i].Offset_po_id,
                    Offset_poitems_id = list[i].Offset_poitems_id,
                    Offset_dc_id = list[i].Offset_dc_id,
                    Offset_dcitems_id = list[i].Offset_dcitems_id,
                    Product_id = list[i].Product_id,
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

        public static void InsertSub(Offset_invoiceitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " ( ";
            q += " " + OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.OFFSET_PO_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.OFFSET_POITEMS_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.OFFSET_DC_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.PRODUCT_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.QTY + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.PRICE + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.CGST_PERCENT + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.SGST_PERCENT + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.IGST_PERCENT + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.REFERED_ID + " \r\n ";
            q += "," + OFFSET_INVOICEITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.OFFSET_PO_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.OFFSET_POITEMS_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.OFFSET_DC_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.QTY + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.PRICE + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + OFFSET_INVOICEITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " WHERE " + OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
