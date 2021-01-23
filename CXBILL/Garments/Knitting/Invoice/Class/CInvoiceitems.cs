// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXKNITTING
{
    public class CInvoiceitems
    {

        #region[Get New]

        public static List<Knitting_Invoiceitems> GetNew
        {
            get
            {
                List<Knitting_Invoiceitems> list = new List<Knitting_Invoiceitems>();

                Knitting_Invoiceitems obj = new Knitting_Invoiceitems()
                {
                    Knitting_Invoiceitems_id = string.Empty,
                    Knitting_Invoice_id = string.Empty,
                    Knitting_Invoice_no = string.Empty,
                    Product_id = string.Empty,
                    Noofrolls = string.Empty,
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

        private static string AttachParams(string q, Knitting_Invoiceitems v)
        {
            q = q.Replace("@" + KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID + "@", "" + ConvertTO.SqlString(v.Knitting_Invoice_id) + "");
            q = q.Replace("@" + KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO + "@", "" + ConvertTO.SqlString(v.Knitting_Invoice_no) + "");
            q = q.Replace("@" + KNITTING_INVOICEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + KNITTING_INVOICEITEMS.NOOFROLLS + "@", "" + ConvertTO.SqlString(v.Noofrolls) + "");
            q = q.Replace("@" + KNITTING_INVOICEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + KNITTING_INVOICEITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + KNITTING_INVOICEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Cgst_percent) + ""));
            q = q.Replace("@" + KNITTING_INVOICEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Sgst_percent) + ""));
            q = q.Replace("@" + KNITTING_INVOICEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Igst_percent) + ""));
            q = q.Replace("@" + KNITTING_INVOICEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + KNITTING_INVOICEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Knitting_Invoiceitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Knitting_Invoiceitems obj = new Knitting_Invoiceitems()
                {
                    Knitting_Invoice_id = list[i].Knitting_Invoice_id,
                    Knitting_Invoice_no = list[i].Knitting_Invoice_no,
                    Product_id = list[i].Product_id,
                    Noofrolls = list[i].Noofrolls,
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

        public static void InsertSub(Knitting_Invoiceitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + " ( ";
            q += " " + KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.PRODUCT_ID + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.NOOFROLLS + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.QTY + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.PRICE + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.CGST_PERCENT + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.SGST_PERCENT + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.IGST_PERCENT + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.REFERED_ID + " \r\n ";
            q += "," + KNITTING_INVOICEITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.NOOFROLLS + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.QTY + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.PRICE + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + KNITTING_INVOICEITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + " WHERE " + KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
