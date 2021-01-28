// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 14-06-2019 09:02:20 PM

using System.Collections.Generic;
using CXLIB;

namespace CXERP
{
    public static class COrderitems 
    {

        #region[Get New]

        public static List<Orderitems> GetNew
        {
            get
            {
            List<Orderitems> list = new List<Orderitems>();

                Orderitems obj = new Orderitems()
                {
                    Orderitems_id = string.Empty,
                    Order_id = string.Empty,
                    Order_no = string.Empty,
                    Style_id = string.Empty,
                    Style_name = string.Empty,
                    Colours_id = string.Empty,
                    Qty = string.Empty,
                    Price =  decimal.Zero,
                    Mrp =  decimal.Zero,
                    Refered_id = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Orderitems v)
        {
            q = q.Replace("@" + ORDERITEMS.ORDER_ID + "@", "" + ConvertTO.SqlString(v.Order_id) + "");
            q = q.Replace("@" + ORDERITEMS.ORDER_NO + "@", "" + ConvertTO.SqlString(v.Order_no) + "");
            q = q.Replace("@" + ORDERITEMS.STYLE_ID + "@", "" + ConvertTO.SqlString(v.Style_id) + "");
            q = q.Replace("@" + ORDERITEMS.STYLE_NAME + "@", "" + ConvertTO.SqlString(v.Style_name) + "");
            q = q.Replace("@" + ORDERITEMS.COLOURS_ID + "@", "" + ConvertTO.SqlString(v.Colours_id) + "");
            q = q.Replace("@" + ORDERITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + ORDERITEMS.PRICE + "@", "" + ConvertTO.SqlDecimal(v.Price) + "");
            q = q.Replace("@" + ORDERITEMS.MRP + "@", "" + ConvertTO.SqlDecimal(v.Mrp) + "");
            q = q.Replace("@" + ORDERITEMS.REFERED_ID + "@", "" + ConvertTO.SqlString(v.Refered_id) + "");
            q = q.Replace("@" + ORDERITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Orderitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Orderitems obj = new Orderitems()
                {
                    Order_id = list[i].Order_id,
                    Order_no = list[i].Order_no,
                    Style_id = list[i].Style_id,
                    Style_name = list[i].Style_name,
                    Colours_id = list[i].Colours_id,
                    Qty = list[i].Qty,
                    Price = list[i].Price,
                    Mrp = list[i].Mrp,
                    Refered_id = list[i].Refered_id,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Orderitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + ORDERITEMS.ORDERITEMS_TBL + " ( ";
                q += " " + ORDERITEMS.ORDER_ID + " \r\n ";
                q += "," + ORDERITEMS.ORDER_NO + " \r\n ";
                q += "," + ORDERITEMS.STYLE_ID + " \r\n ";
                q += "," + ORDERITEMS.STYLE_NAME + " \r\n ";
                q += "," + ORDERITEMS.COLOURS_ID + " \r\n ";
                q += "," + ORDERITEMS.QTY + " \r\n ";
                q += "," + ORDERITEMS.PRICE + " \r\n ";
                q += "," + ORDERITEMS.MRP + " \r\n ";
                q += "," + ORDERITEMS.REFERED_ID + " \r\n ";
                q += "," + ORDERITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ ORDERITEMS.ORDER_ID + "@ \r\n ";
                q += ", @"+ ORDERITEMS.ORDER_NO + "@ \r\n ";
                q += ", @"+ ORDERITEMS.STYLE_ID + "@ \r\n ";
                q += ", @"+ ORDERITEMS.STYLE_NAME + "@ \r\n ";
                q += ", @"+ ORDERITEMS.COLOURS_ID + "@ \r\n ";
                q += ", @"+ ORDERITEMS.QTY + "@ \r\n ";
                q += ", @"+ ORDERITEMS.PRICE + "@ \r\n ";
                q += ", @"+ ORDERITEMS.MRP + "@ \r\n ";
                q += ", @"+ ORDERITEMS.REFERED_ID + "@ \r\n ";
                q += ", @"+ ORDERITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + ORDERITEMS.ORDERITEMS_TBL+ " WHERE " + ORDERITEMS.ORDER_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
