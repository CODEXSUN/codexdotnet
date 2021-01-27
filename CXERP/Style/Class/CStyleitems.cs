// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System.Collections.Generic;
using CXLIB;

namespace CXERP
{
    public static class CStyleitems 
    {

        #region[Get New]

        public static List<Styleitems> GetNew
        {
            get
            {
            List<Styleitems> list = new List<Styleitems>();

                Styleitems obj = new Styleitems()
                {
                    Styleitems_id = string.Empty,
                    Style_id = string.Empty,
                    Style_no = string.Empty,
                    Article_id = string.Empty,
                    Product_id = string.Empty,
                    Colours_id = string.Empty,
                    Sizes_id = string.Empty,
                    Qty = string.Empty,
                    Price =  decimal.Zero,
                    Refered_id = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Styleitems v)
        {
            q = q.Replace("@" + STYLEITEMS.STYLE_ID + "@", "" + ConvertTO.SqlString(v.Style_id) + "");
            q = q.Replace("@" + STYLEITEMS.STYLE_NO + "@", "" + ConvertTO.SqlString(v.Style_no) + "");
            q = q.Replace("@" + STYLEITEMS.ARTICLE_ID + "@", "" + ConvertTO.SqlString(v.Article_id) + "");
            q = q.Replace("@" + STYLEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + STYLEITEMS.COLOURS_ID + "@", "" + ConvertTO.SqlString(v.Colours_id) + "");
            q = q.Replace("@" + STYLEITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + STYLEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + STYLEITEMS.PRICE + "@", "" + ConvertTO.SqlDecimal(v.Price) + "");
            q = q.Replace("@" + STYLEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + STYLEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Styleitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Styleitems obj = new Styleitems()
                {
                    Style_id = list[i].Style_id,
                    Style_no = list[i].Style_no,
                    Article_id = list[i].Article_id,
                    Product_id = list[i].Product_id,
                    Colours_id = list[i].Colours_id,
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
        
        public static void InsertSub(Styleitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + STYLEITEMS.STYLEITEMS_TBL + " ( ";
                q += " " + STYLEITEMS.STYLE_ID + " \r\n ";
                q += "," + STYLEITEMS.STYLE_NO + " \r\n ";
                q += "," + STYLEITEMS.ARTICLE_ID + " \r\n ";
                q += "," + STYLEITEMS.PRODUCT_ID + " \r\n ";
                q += "," + STYLEITEMS.COLOURS_ID + " \r\n ";
                q += "," + STYLEITEMS.SIZES_ID + " \r\n ";
                q += "," + STYLEITEMS.QTY + " \r\n ";
                q += "," + STYLEITEMS.PRICE + " \r\n ";
                q += "," + STYLEITEMS.REFERED_ID + " \r\n ";
                q += "," + STYLEITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ STYLEITEMS.STYLE_ID + "@ \r\n ";
                q += ", @"+ STYLEITEMS.STYLE_NO + "@ \r\n ";
                q += ", @"+ STYLEITEMS.ARTICLE_ID + "@ \r\n ";
                q += ", @"+ STYLEITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ STYLEITEMS.COLOURS_ID + "@ \r\n ";
                q += ", @"+ STYLEITEMS.SIZES_ID + "@ \r\n ";
                q += ", @"+ STYLEITEMS.QTY + "@ \r\n ";
                q += ", @"+ STYLEITEMS.PRICE + "@ \r\n ";
                q += ", @"+ STYLEITEMS.REFERED_ID + "@ \r\n ";
                q += ", @"+ STYLEITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + STYLEITEMS.STYLEITEMS_TBL+ " WHERE " + STYLEITEMS.STYLE_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
