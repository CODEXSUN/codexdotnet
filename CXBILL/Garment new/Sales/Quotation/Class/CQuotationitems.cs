// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class CQuotationitems
    {

        #region[Get New]

        public static List<Quotationitems> GetNew
        {
            get
            {
                List<Quotationitems> list = new List<Quotationitems>();

                Quotationitems obj = new Quotationitems()
                {
                    Quotationitems_id = string.Empty,
                    Quotation_id = string.Empty,
                    Product_id = string.Empty,
                    Sizes_id = string.Empty,
                    Qty = string.Empty,
                    Price = decimal.Zero,
                    Refered_id = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Quotationitems v)
        {
            q = q.Replace("@" + QUOTATIONITEMS.QUOTATION_ID + "@", "" + ConvertTO.SqlString(v.Quotation_id) + "");
            q = q.Replace("@" + QUOTATIONITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + QUOTATIONITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + QUOTATIONITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + QUOTATIONITEMS.PRICE + "@", "" + ConvertTO.SqlString((v.Price) + ""));
            q = q.Replace("@" + QUOTATIONITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + QUOTATIONITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(List<Quotationitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Quotationitems obj = new Quotationitems()
                {
                    Quotation_id = list[i].Quotation_id,
                    Product_id = list[i].Product_id,
                    Sizes_id = list[i].Sizes_id,
                    Qty = list[i].Qty,
                    Price = list[i].Price,
                    Refered_id = list[i].Refered_id,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]

        public static void InsertSub(Quotationitems v, DAL dalsession)
        {
            string q = " INSERT INTO " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " ( ";
            q += " " + QUOTATIONITEMS.QUOTATION_ID + " \r\n ";
            q += "," + QUOTATIONITEMS.PRODUCT_ID + " \r\n ";
            q += "," + QUOTATIONITEMS.SIZES_ID + " \r\n ";
            q += "," + QUOTATIONITEMS.QTY + " \r\n ";
            q += "," + QUOTATIONITEMS.PRICE + " \r\n ";
            q += "," + QUOTATIONITEMS.REFERED_ID + " \r\n ";
            q += "," + QUOTATIONITEMS.LOCKED + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + QUOTATIONITEMS.QUOTATION_ID + "@ \r\n ";
            q += ", @" + QUOTATIONITEMS.PRODUCT_ID + "@ \r\n ";
            q += ", @" + QUOTATIONITEMS.SIZES_ID + "@ \r\n ";
            q += ", @" + QUOTATIONITEMS.QTY + "@ \r\n ";
            q += ", @" + QUOTATIONITEMS.PRICE + "@ \r\n ";
            q += ", @" + QUOTATIONITEMS.REFERED_ID + "@ \r\n ";
            q += ", @" + QUOTATIONITEMS.LOCKED + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Delete]

        public static void Delete(string fkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " WHERE " + QUOTATIONITEMS.QUOTATION_ID + " =  " + fkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
