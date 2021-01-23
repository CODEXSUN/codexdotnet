// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class Csara_invoiceitems
    {

        #region[Get New]

        public static List<Offset_labouritems> GetNew
        {
            get
            {
                List<Offset_labouritems> list = new List<Offset_labouritems>();

                Offset_labouritems obj = new Offset_labouritems()
                {
                    Offset_labouritems_id = string.Empty,
                    Offset_labour_id = string.Empty,
                    Offset_labour_no = string.Empty,
                    Offset_labour_po_no = string.Empty,
                    Offset_labour_dc_no = string.Empty,
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

        private static string AttachParams(string q, Offset_labouritems v)
        {
            q = q.Replace("@" + OFFSET_LABOURITEMS.OFFSET_LABOUR_ID + "@", "" + ConvertTO.SqlString(v.Offset_labour_id) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.OFFSET_LABOUR_NO + "@", "" + ConvertTO.SqlString(v.Offset_labour_no) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO + "@", "" + ConvertTO.SqlString(v.Offset_labour_po_no) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO + "@", "" + ConvertTO.SqlString(v.Offset_labour_dc_no) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + OFFSET_LABOURITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Cgst_percent) + ""));
            q = q.Replace("@" + OFFSET_LABOURITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Sgst_percent) + ""));
            q = q.Replace("@" + OFFSET_LABOURITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Igst_percent) + ""));
            q = q.Replace("@" + OFFSET_LABOURITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + OFFSET_LABOURITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Offset_labouritems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Offset_labouritems obj = new Offset_labouritems()
                {
                    Offset_labour_id = list[i].Offset_labour_id,
                    Offset_labour_no = list[i].Offset_labour_no,
                    Offset_labour_po_no = list[i].Offset_labour_po_no,
                    Offset_labour_dc_no = list[i].Offset_labour_dc_no,
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

        public static void InsertSub(Offset_labouritems v, DAL dalsession)
        {
            string q = " INSERT INTO " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + " ( ";
            q += " " + OFFSET_LABOURITEMS.OFFSET_LABOUR_ID + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.OFFSET_LABOUR_NO + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.PRODUCT_ID + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.QTY + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.PRICE + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.CGST_PERCENT + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.SGST_PERCENT + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.IGST_PERCENT + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.REFERED_ID + " \r\n ";
            q += "," + OFFSET_LABOURITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + OFFSET_LABOURITEMS.OFFSET_LABOUR_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.OFFSET_LABOUR_NO + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.QTY + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.PRICE + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + OFFSET_LABOURITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + " WHERE " + OFFSET_LABOURITEMS.OFFSET_LABOUR_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
