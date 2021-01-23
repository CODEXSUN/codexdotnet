// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXBILL_EXTEN.Labour.Const;
using CXLIB;

namespace CXBILL_EXTEN.Labour.Class
{
    public static class CLabouritems
    {

        #region[Get New]

        public static List<Labouritems> GetNew
        {
            get
            {
                List<Labouritems> list = new List<Labouritems>();

                Labouritems obj = new Labouritems()
                {
                    Labouritems_id = string.Empty,
                    Labour_id = string.Empty,
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

        private static string AttachParams(string q, Labouritems v)
        {
            q = q.Replace("@" + LABOURITEMS.LABOUR_ID + "@", "" + ConvertTO.SqlString(v.Labour_id) + "");
            q = q.Replace("@" + LABOURITEMS.PO_NO + "@", "" + ConvertTO.SqlString(v.Po_no) + "");
            q = q.Replace("@" + LABOURITEMS.DC_NO + "@", "" + ConvertTO.SqlString(v.Dc_no) + "");
            q = q.Replace("@" + LABOURITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + LABOURITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + LABOURITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + LABOURITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + LABOURITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Cgst_percent) + ""));
            q = q.Replace("@" + LABOURITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Sgst_percent) + ""));
            q = q.Replace("@" + LABOURITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString((v.Igst_percent) + ""));
            q = q.Replace("@" + LABOURITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + LABOURITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Labouritems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Labouritems obj = new Labouritems()
                {
                    Labour_id = list[i].Labour_id,
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

        public static void InsertSub(Labouritems v, DAL dalsession)
        {
            string q = " INSERT INTO " + LABOURITEMS.LABOURITEMS_TBL + " ( ";
            q += " " + LABOURITEMS.LABOUR_ID + " \r\n ";
            q += "," + LABOURITEMS.PO_NO + " \r\n ";
            q += "," + LABOURITEMS.DC_NO + " \r\n ";
            q += "," + LABOURITEMS.PRODUCT_ID + " \r\n ";
            q += "," + LABOURITEMS.SIZES_ID + " \r\n ";
            q += "," + LABOURITEMS.QTY + " \r\n ";
            q += "," + LABOURITEMS.PRICE + " \r\n ";
            q += "," + LABOURITEMS.CGST_PERCENT + " \r\n ";
            q += "," + LABOURITEMS.SGST_PERCENT + " \r\n ";
            q += "," + LABOURITEMS.IGST_PERCENT + " \r\n ";
            q += "," + LABOURITEMS.REFERED_ID + " \r\n ";
            q += "," + LABOURITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + LABOURITEMS.LABOUR_ID + "@ \r\n ";
            q += ", @" + LABOURITEMS.PO_NO + "@ \r\n ";
            q += ", @" + LABOURITEMS.DC_NO + "@ \r\n ";
            q += ", @" + LABOURITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + LABOURITEMS.SIZES_ID + "@ \r\n ";
            q += ", @" + LABOURITEMS.QTY + "@ \r\n ";
            q += ", @" + LABOURITEMS.PRICE + "@ \r\n ";
            q += ", @" + LABOURITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + LABOURITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + LABOURITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + LABOURITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + LABOURITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + LABOURITEMS.LABOURITEMS_TBL + " WHERE " + LABOURITEMS.LABOUR_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
