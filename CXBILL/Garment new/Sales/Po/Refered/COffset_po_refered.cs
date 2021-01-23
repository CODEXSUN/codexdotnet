// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:56 PM
// last update : 17-08-2017

using CXLIB;
using System;
using System.Collections.Generic;
using System.Data;

namespace CXBILL
{
    public class CPo_refered
    {

        public static void Refered(List<Offset_dcitems> item, List<Offset_dcitems> item2, DAL dal)
        {
            
            if (item.Count != 0)
            {
                for (int i = 0; i < item2.Count; i++)
                {
                    if (item[i].Offset_po_id != "1")
                    {
                        Reset_items(item2[i].Offset_po_id, item2[i].Product_id, dal); // reset all item to unlock and then lock particular
                    }
                }

                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].Offset_po_id != "1")
                    {
                        string id = item[i].Offset_po_id; // assign simplyfy for typing 
                        string itemid = item[i].Offset_poitems_id; // assign simplyfy for typing 

                        Decimal dcqty = GetDcQty(itemid, dal); // getting sum of dc qty by poitems id 
                        Decimal poqty = GetPoQty(itemid, dal); // getting qty of poitems id

                        if (dcqty >= poqty) // compare if greater or equals qty
                        {
                            Poitems_Locked(itemid, dal); // lock poitems id
                        }
                        else if (dcqty == 0)
                        {
                            Poitems_Unlocked(itemid, dal);
                        }
                        else
                        {
                            Poitems_Partial(itemid, dal); // lock poitems id
                        }


                        var count = ItemsCount(id, dal);


                        if (UnlockedCount(id, dal) == count)
                        {
                            Po_Unlocked(id, dal); // if all items unlocked 
                        }
                        else if (LockedCount(id, dal) == count)
                        {
                            Po_Locked(id, dal); // if all items locked
                        }
                        else
                        {
                            Po_Partial(id, dal);
                        }


                        //if (UnlockedCount(id, dal) == "0")
                        //{
                        //    Po_Locked(id, dal); // if all items locked 
                        //}
                        //else if (LockedCount(id, dal) == "0")
                        //{
                        //    Po_Unlocked(id, dal); // if all items unlocked
                        //}
                        //else
                        //{
                        //    Po_Partial(id, dal);
                        //}

                        Refered_no(id, dal); // update refer dc no

                        Refered_Qty(itemid, dal); // update refer qty
                    }
                }

                for (int i = 0; i < item2.Count; i++)
                {
                    if (item[i].Offset_po_id != "1")
                    {
                        Refered_Qty(item2[i].Offset_poitems_id, dal);// re check qty while delete
                    }
                }
            }
        }

        private static void Reset_items(string id, string productid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " SET " + OFFSET_POITEMS.LOCKED + " = " + Core.Unlocked + " \r\n ";
            q += " WHERE " + OFFSET_POITEMS.OFFSET_PO_ID + " = " + id + " \r\n ";
            q += " AND " + OFFSET_POITEMS.PRODUCT_ID + " = " + productid + " ; ";
            dal.Execute(q);
        }

        private static Decimal GetDcQty(string itemid, DAL dal)
        {
            string q = "SELECT SUM(QTY) FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " WHERE " + OFFSET_DCITEMS.OFFSET_POITEMS_ID + " =" + itemid + "  ; ";

            object obj = dal.ExecuteScalar(q);

            if (obj != DBNull.Value)
            {
                return Convert.ToDecimal(obj);
            }
            else
            {
                return 0;
            }
        }

        private static Decimal GetPoQty(string itemid, DAL dal)
        {
            string q = "SELECT QTY FROM " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_ID + " =" + itemid + " ; ";

            object obj = dal.ExecuteScalar(q);

            if (obj != DBNull.Value)
            {
                return Convert.ToDecimal(obj);
            }
            else
            {
                return 0;
            }
        }

        private static string ItemsCount(string id, DAL dal)
        {
            string q = "SELECT COUNT(*) FROM " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " WHERE " + OFFSET_POITEMS.OFFSET_PO_ID + " = " + id + " ; ";

            return dal.ExecuteScalar(q).ToString();
        }

        private static string UnlockedCount(string id, DAL dal)
        {
            string q = "SELECT COUNT(*) FROM " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " WHERE " + OFFSET_POITEMS.LOCKED + " = " + Core.Unlocked + " AND " + OFFSET_POITEMS.OFFSET_PO_ID + " = " + id + " ; ";

            return dal.ExecuteScalar(q).ToString();
        }

        private static string LockedCount(string id, DAL dal)
        {
            string q = "SELECT COUNT(*) FROM " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " WHERE " + OFFSET_POITEMS.LOCKED + " = " + Core.Locked + " AND " + OFFSET_POITEMS.OFFSET_PO_ID + " = " + id + " ; ";

            return dal.ExecuteScalar(q).ToString();
        }

        private static void Poitems_Unlocked(string itemid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_POITEMS.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_ID + " = '" + itemid + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Poitems_Locked(string itemid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_POITEMS.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += " WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_ID + " = '" + itemid + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Poitems_Partial(string itemid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_POITEMS.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += " WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_ID + " = '" + itemid + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Po_Unlocked(string id, DAL dal)
        {
            string q = "UPDATE " + OFFSET_PO.OFFSET_PO_TBL + " SET \r\n ";
            q += " " + OFFSET_PO.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + OFFSET_PO.OFFSET_PO_ID + " = '" + id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Po_Locked(string id, DAL dal)
        {
            string q = "UPDATE " + OFFSET_PO.OFFSET_PO_TBL + " SET \r\n ";
            q += " " + OFFSET_PO.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += "  WHERE " + OFFSET_PO.OFFSET_PO_ID + " = '" + id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Po_Partial(string id, DAL dal)
        {
            string q = "UPDATE " + OFFSET_PO.OFFSET_PO_TBL + " SET \r\n ";
            q += " " + OFFSET_PO.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += "  WHERE " + OFFSET_PO.OFFSET_PO_ID + " = '" + id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Refered_no(string id, DAL dal)
        {
            string vdcno = "";

            string q = "SELECT DISTINCT " + OFFSET_DCITEMS.OFFSET_DC_NO + " FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " WHERE " + OFFSET_DCITEMS.OFFSET_PO_ID + " = " + id + " ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    vdcno += redr[OFFSET_DCITEMS.OFFSET_DC_NO].ToString();
                }
            }

            q = "UPDATE " + OFFSET_PO.OFFSET_PO_TBL + " SET \r\n ";
            q += " " + OFFSET_PO.REFERED_NO + " = '" + vdcno + "' \r\n ";
            q += "  WHERE " + OFFSET_PO.OFFSET_PO_ID + " = '" + id + "' ; \r\n ";

            dal.Execute(q);
        }

        private static void Refered_Qty(string itemid, DAL dal)
        {
            string refQty = (GetPoQty(itemid, dal) - GetDcQty(itemid, dal)).ToString();

            string q = "UPDATE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_POITEMS.REFERED_QTY + " = '" + refQty + "' \r\n ";
            q += "  WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_ID + " = '" + itemid + "' ; \r\n ";

            dal.Execute(q);
        }

    }//cls
}//ns
