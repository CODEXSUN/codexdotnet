// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 09:52:02 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CPurchaseitems
    {

        #region[Get New]

        public static List<Purchaseitems> GetNew
        {
            get
            {
                List<Purchaseitems> list = new List<Purchaseitems>();

                Purchaseitems obj = new Purchaseitems()
                {
                    Purchaseitems_id = string.Empty,
                    Purchase_id = string.Empty,
                    Purchase_no = string.Empty,
                    Product_id = string.Empty,
                    Qty = decimal.Zero,
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

        private static string AttachParams(string q, Purchaseitems v)
        {
            q = q.Replace("@" + PURCHASEITEMS.PURCHASE_ID + "@", "" + ConvertTO.SqlString(v.Purchase_id) + "");
            q = q.Replace("@" + PURCHASEITEMS.PURCHASE_NO + "@", "" + ConvertTO.SqlString(v.Purchase_no) + "");
            q = q.Replace("@" + PURCHASEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + PURCHASEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty + ""));
            q = q.Replace("@" + PURCHASEITEMS.PRICE + "@", "" + ConvertTO.SqlString(v.Price + ""));
            q = q.Replace("@" + PURCHASEITEMS.CGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Cgst_percent + ""));
            q = q.Replace("@" + PURCHASEITEMS.SGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Sgst_percent + ""));
            q = q.Replace("@" + PURCHASEITEMS.IGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Igst_percent + ""));
            q = q.Replace("@" + PURCHASEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + PURCHASEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Purchaseitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Purchaseitems obj = new Purchaseitems()
                {
                    Purchase_id = list[i].Purchase_id,
                    Purchase_no = list[i].Purchase_no,
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

        public static void InsertSub(Purchaseitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + PURCHASEITEMS.PURCHASEITEMS_TBL + " ( ";
            q += " " + PURCHASEITEMS.PURCHASE_ID + " \r\n ";
            q += "," + PURCHASEITEMS.PURCHASE_NO + " \r\n ";
            q += "," + PURCHASEITEMS.PRODUCT_ID + " \r\n ";
            q += "," + PURCHASEITEMS.QTY + " \r\n ";
            q += "," + PURCHASEITEMS.PRICE + " \r\n ";
            q += "," + PURCHASEITEMS.CGST_PERCENT + " \r\n ";
            q += "," + PURCHASEITEMS.SGST_PERCENT + " \r\n ";
            q += "," + PURCHASEITEMS.IGST_PERCENT + " \r\n ";
            q += "," + PURCHASEITEMS.REFERED_ID + " \r\n ";
            q += "," + PURCHASEITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + PURCHASEITEMS.PURCHASE_ID + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.PURCHASE_NO + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.QTY + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.PRICE + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.CGST_PERCENT + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.SGST_PERCENT + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.IGST_PERCENT + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + PURCHASEITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + PURCHASEITEMS.PURCHASEITEMS_TBL + " WHERE " + PURCHASEITEMS.PURCHASE_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
