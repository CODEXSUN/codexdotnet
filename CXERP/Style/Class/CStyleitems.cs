// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System.Collections.Generic;
using CXLIB;

namespace CXERP
{
    public static class CArticleitems 
    {

        #region[Get New]

        public static List<Articleitems> GetNew
        {
            get
            {
            List<Articleitems> list = new List<Articleitems>();

                Articleitems obj = new Articleitems()
                {
                    Articleitems_id = string.Empty,
                    Article_id = string.Empty,
                    Article_no = string.Empty,
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
        
        private static string AttachParams(string q, Articleitems v)
        {
            q = q.Replace("@" + ARTICLEITEMS.ARTICLE_ID + "@", "" + ConvertTO.SqlString(v.Article_id) + "");
            q = q.Replace("@" + ARTICLEITEMS.ARTICLE_NO + "@", "" + ConvertTO.SqlString(v.Article_no) + "");
            q = q.Replace("@" + ARTICLEITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + ARTICLEITEMS.COLOURS_ID + "@", "" + ConvertTO.SqlString(v.Colours_id) + "");
            q = q.Replace("@" + ARTICLEITEMS.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Sizes_id) + "");
            q = q.Replace("@" + ARTICLEITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + ARTICLEITEMS.PRICE + "@", "" + ConvertTO.SqlDecimal(v.Price) + "");
            q = q.Replace("@" + ARTICLEITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + ARTICLEITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Articleitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Articleitems obj = new Articleitems()
                {
                    Article_id = list[i].Article_id,
                    Article_no = list[i].Article_no,
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
        
        public static void InsertSub(Articleitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + ARTICLEITEMS.ARTICLEITEMS_TBL + " ( ";
                q += " " + ARTICLEITEMS.ARTICLE_ID + " \r\n ";
                q += "," + ARTICLEITEMS.ARTICLE_NO + " \r\n ";
                q += "," + ARTICLEITEMS.PRODUCT_ID + " \r\n ";
                q += "," + ARTICLEITEMS.COLOURS_ID + " \r\n ";
                q += "," + ARTICLEITEMS.SIZES_ID + " \r\n ";
                q += "," + ARTICLEITEMS.QTY + " \r\n ";
                q += "," + ARTICLEITEMS.PRICE + " \r\n ";
                q += "," + ARTICLEITEMS.REFERED_ID + " \r\n ";
                q += "," + ARTICLEITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ ARTICLEITEMS.ARTICLE_ID + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.ARTICLE_NO + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.COLOURS_ID + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.SIZES_ID + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.QTY + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.PRICE + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.REFERED_ID + "@ \r\n ";
                q += ", @"+ ARTICLEITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + ARTICLEITEMS.ARTICLEITEMS_TBL+ " WHERE " + ARTICLEITEMS.ARTICLE_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
