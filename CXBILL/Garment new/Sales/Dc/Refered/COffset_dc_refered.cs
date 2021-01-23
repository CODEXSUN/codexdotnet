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
    public class COffset_dc_refered
    {

        public static void Refered(List<Offset_invoiceitems> item, List<Offset_invoiceitems> item2, DAL dal)
        {
            if (item.Count != 0)
            {
                for (int i = 0; i < item2.Count; i++)
                {
                    if (item2[i].Offset_dc_id != "1")
                    {
                        Reset_items(item2[i].Offset_dc_id, item2[i].Product_id, dal); // reset all item to unlock and then lock particular
                    }
                }

                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].Offset_dc_id != "1")
                    {
                        string id = item[i].Offset_dc_id; // assign simplyfy for typing 
                        string itemid = item[i].Offset_dcitems_id; // assign simplyfy for typing 

                        Decimal invoiceqty = GetInvoiceQty(itemid, dal); // getting sum of dc qty by poitems id 
                        Decimal dcqty = GetDcQty(itemid, dal); // getting qty of poitems id

                        if (invoiceqty >= dcqty) // compare if greater or equals qty
                        {
                            DCitems_Locked(itemid, dal); // lock poitems id
                        }
                        else if (invoiceqty == 0)
                        {
                            Dcitems_Unlocked(itemid, dal);
                        }
                        else
                        {
                            DCitems_Partial(itemid, dal); // lock poitems id
                        }

                        var count = ItemsCount(id, dal);

                        if (UnlockedCount(id, dal) == count)
                        {
                            Dc_Unlocked(id, dal); // if all items unlocked 
                        }
                        else if (LockedCount(id, dal) == count)
                        {
                            Dc_Locked(id, dal); // if all items locked
                        }
                        else
                        {
                            Dc_Partial(id, dal);
                        }

                        Refered_no(id, dal); // update refer dc no

                        Refered_Qty(itemid, dal); // update refer qty
                    }
                }
            }
        }

        private static void Reset_items(string id, string productid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " SET " + OFFSET_DCITEMS.LOCKED + " = " + Core.Unlocked + " \r\n ";
            q += " WHERE " + OFFSET_DCITEMS.OFFSET_DC_ID + " = " + id + " \r\n ";
            q += " AND " + OFFSET_DCITEMS.PRODUCT_ID + " = " + productid + " ; ";
            dal.Execute(q);
        }

        private static Decimal GetInvoiceQty(string itemid, DAL dal)
        {
            string q = "SELECT SUM(QTY) FROM " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " WHERE " + OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID + " =" + itemid + " ; ";

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

        private static Decimal GetDcQty(string itemid, DAL dal)
        {
            string q = "SELECT QTY FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " WHERE " + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + " =" + itemid + " ; ";

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
            string q = "SELECT COUNT(*) FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " WHERE " + OFFSET_DCITEMS.OFFSET_DC_ID + " = " + id + " ; ";

            return dal.ExecuteScalar(q).ToString();
        }

        private static string UnlockedCount(string id, DAL dal)
        {
            string q = "SELECT COUNT(*) FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " WHERE " + OFFSET_DCITEMS.LOCKED + " = " + Core.Unlocked + " AND " + OFFSET_DCITEMS.OFFSET_DC_ID + " = " + id + " ; ";

            return dal.ExecuteScalar(q).ToString();
        }

        private static string LockedCount(string id, DAL dal)
        {
            string q = "SELECT COUNT(*) FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " WHERE " + OFFSET_DCITEMS.LOCKED + " = " + Core.Locked + " AND " + OFFSET_DCITEMS.OFFSET_DC_ID + " = " + id + " ; ";

            return dal.ExecuteScalar(q).ToString();
        }

        private static void Dcitems_Unlocked(string itemid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_DCITEMS.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + " = '" + itemid + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void DCitems_Locked(string itemid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_DCITEMS.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += " WHERE " + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + " = '" + itemid + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void DCitems_Partial(string itemid, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_DCITEMS.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += " WHERE " + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + " = '" + itemid + "' ; \r\n ";
            dal.Execute(q);
        }


        private static void Dc_Unlocked(string id, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DC.OFFSET_DC_TBL + " SET \r\n ";
            q += " " + OFFSET_DC.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + OFFSET_DC.OFFSET_DC_ID + " = '" + id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Dc_Locked(string id, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DC.OFFSET_DC_TBL + " SET \r\n ";
            q += " " + OFFSET_DC.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += "  WHERE " + OFFSET_DC.OFFSET_DC_ID + " = '" + id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Dc_Partial(string id, DAL dal)
        {
            string q = "UPDATE " + OFFSET_DC.OFFSET_DC_TBL + " SET \r\n ";
            q += " " + OFFSET_DC.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += "  WHERE " + OFFSET_DC.OFFSET_DC_ID + " = '" + id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void Refered_no(string id, DAL dal)
        {
            string vdcno = "";

            string q = "SELECT DISTINCT " + OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO + " FROM " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " WHERE " + OFFSET_INVOICEITEMS.OFFSET_DC_ID + " = " + id + " ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    vdcno += redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO].ToString();
                }
            }

            q = "UPDATE " + OFFSET_DC.OFFSET_DC_TBL + " SET \r\n ";
            q += " " + OFFSET_DC.REFERED_NO + " = '" + vdcno + "' \r\n ";
            q += "  WHERE " + OFFSET_DC.OFFSET_DC_ID + " = '" + id + "' ; \r\n ";

            dal.Execute(q);
        }

        private static void Refered_Qty(string itemid, DAL dal)
        {
            string refQty = (GetDcQty(itemid, dal) - GetInvoiceQty(itemid, dal)).ToString();

            string q = "UPDATE " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " SET \r\n ";
            q += " " + OFFSET_DCITEMS.REFERED_QTY + " = '" + refQty + "' \r\n ";
            q += "  WHERE " + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + " = '" + itemid + "' ; \r\n ";

            dal.Execute(q);
        }

    }//cls
}//ns
