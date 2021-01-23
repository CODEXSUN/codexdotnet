// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 12:32:15 PM

using System.Collections.Generic;
using CXLIB;

namespace CXBILL
{
    public class COffset_dcitems 
    {

        #region[Get New]

        public static List<Offset_dcitems> GetNew
        {
            get
            {
                List<Offset_dcitems> list = new List<Offset_dcitems>();

                Offset_dcitems obj = new Offset_dcitems()
                {
                    Offset_dcitems_id = string.Empty,
                    Offset_dc_id = string.Empty,
                    Offset_dc_no = string.Empty,
                    Offset_po_id = string.Empty,
                    Offset_poitems_id = string.Empty,
                    Product_id = string.Empty,
                    Qty = string.Empty,
                    Refered_qty = string.Empty,
                    Locked = string.Empty,
                };
                list.Add(obj);
                return list;
            }
        }

        #endregion[Get New]

        #region[Attach params]
        
        private static string AttachParams(string q, Offset_dcitems v)
        {
            q = q.Replace("@" + OFFSET_DCITEMS.OFFSET_DC_ID + "@", "" + ConvertTO.SqlString(v.Offset_dc_id) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.OFFSET_DC_NO + "@", "" + ConvertTO.SqlString(v.Offset_dc_no) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.OFFSET_PO_ID + "@", "" + ConvertTO.SqlString(v.Offset_po_id) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.OFFSET_POITEMS_ID + "@", "" + ConvertTO.SqlString(v.Offset_poitems_id) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.REFERED_QTY + "@", "" + ConvertTO.SqlString(v.Refered_qty) + "");
            q = q.Replace("@" + OFFSET_DCITEMS.LOCKED + "@", "" + ConvertTO.SqlString(v.Locked) + "");
            return q;
        }
        #endregion[Attach params]
        
        #region[Insert]
        
        public static void Insert(List<Offset_dcitems> list, DAL dalsession)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Offset_dcitems obj = new Offset_dcitems()
                {
                    Offset_dc_id = list[i].Offset_dc_id,
                    Offset_dc_no = list[i].Offset_dc_no,
                    Offset_po_id = list[i].Offset_po_id,
                    Offset_poitems_id = list[i].Offset_poitems_id,
                    Product_id = list[i].Product_id,
                    Qty = list[i].Qty,
                    Refered_qty = list[i].Refered_qty,
                    Locked = list[i].Locked
                };
                InsertSub(obj, dalsession);
            }
        }

        #endregion[Insert]

        #region[InsertSub]
        
        public static void InsertSub(Offset_dcitems v, DAL dalsession)
        {
                string q = " INSERT INTO " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " ( ";
                q += " " + OFFSET_DCITEMS.OFFSET_DC_ID + " \r\n ";
                q += "," + OFFSET_DCITEMS.OFFSET_DC_NO + " \r\n ";
                q += "," + OFFSET_DCITEMS.OFFSET_PO_ID + " \r\n ";
                q += "," + OFFSET_DCITEMS.OFFSET_POITEMS_ID + " \r\n ";
                q += "," + OFFSET_DCITEMS.PRODUCT_ID + " \r\n ";
                q += "," + OFFSET_DCITEMS.QTY + " \r\n ";
                q += "," + OFFSET_DCITEMS.REFERED_QTY + " \r\n ";
                q += "," + OFFSET_DCITEMS.LOCKED + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ OFFSET_DCITEMS.OFFSET_DC_ID + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.OFFSET_DC_NO + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.OFFSET_PO_ID + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.OFFSET_POITEMS_ID + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.PRODUCT_ID + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.QTY + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.REFERED_QTY + "@ \r\n ";
                q += ", @"+ OFFSET_DCITEMS.LOCKED + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]
        
        #region[Delete]
        
        public static void Delete(string fkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL+ " WHERE " + OFFSET_DCITEMS.OFFSET_DC_ID + " =  " + fkid +";");
        }
        #endregion[Delete]
        
    }//cls
}//ns
