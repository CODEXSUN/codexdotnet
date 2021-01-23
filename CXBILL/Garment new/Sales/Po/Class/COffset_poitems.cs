// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class COffset_poitems 
    {

        #region[Get New]

        public static List<Offset_poitems> GetNew
        {
            get
            {
                List<Offset_poitems> list = new List<Offset_poitems>();

                Offset_poitems obj = new Offset_poitems()
                {
                    Offset_poitems_id = string.Empty,
                    Offset_po_id = string.Empty,
                    Product_id = string.Empty,
                    Qty = string.Empty,
                    Price = string.Empty,
                    Sub_total = string.Empty,
                    Refered_qty = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Offset_poitems v)
        {
            q = q.Replace("@" + OFFSET_POITEMS.OFFSET_PO_ID + "@", "" + ConvertTO.SqlString(v.Offset_po_id) + "");
            q = q.Replace("@" + OFFSET_POITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + OFFSET_POITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + OFFSET_POITEMS.PRICE + "@", "" + ConvertTO.SqlString(v.Price) + "");
            q = q.Replace("@" + OFFSET_POITEMS.SUB_TOTAL + "@", "" + ConvertTO.SqlString(v.Sub_total) + "");
            q = q.Replace("@" + OFFSET_POITEMS.REFERED_QTY + "@", "" + ConvertTO.SqlString(v.Refered_qty) + "");
            q = q.Replace("@" + OFFSET_POITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Offset_poitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Offset_poitems obj = new Offset_poitems()
                {
                    Offset_po_id = list[i].Offset_po_id,
                    Product_id = list[i].Product_id,
                    Qty = list[i].Qty,
                    Price = list[i].Price,
                    Sub_total = list[i].Sub_total,
                    Refered_qty = list[i].Refered_qty,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Offset_poitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " ( ";
                q += " " + OFFSET_POITEMS.OFFSET_PO_ID + " \r\n ";
                q += "," + OFFSET_POITEMS.PRODUCT_ID + " \r\n ";
                q += "," + OFFSET_POITEMS.QTY + " \r\n ";
                q += "," + OFFSET_POITEMS.PRICE + " \r\n ";
                q += "," + OFFSET_POITEMS.SUB_TOTAL + " \r\n ";
                q += "," + OFFSET_POITEMS.REFERED_QTY + " \r\n ";
                q += "," + OFFSET_POITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ OFFSET_POITEMS.OFFSET_PO_ID + "@ \r\n ";
                q += ", @"+ OFFSET_POITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ OFFSET_POITEMS.QTY + "@ \r\n ";
                q += ", @"+ OFFSET_POITEMS.PRICE + "@ \r\n ";
                q += ", @"+ OFFSET_POITEMS.SUB_TOTAL + "@ \r\n ";
                q += ", @"+ OFFSET_POITEMS.REFERED_QTY + "@ \r\n ";
                q += ", @"+ OFFSET_POITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL+ " WHERE " + OFFSET_POITEMS.OFFSET_PO_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
