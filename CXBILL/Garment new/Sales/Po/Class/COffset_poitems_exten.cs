// Version : 3 dt : 01-08-2017
// Auto Generated
// 20-08-2017 10:33:49 PM
// last update : 20-08-2017

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_Poitems_exten
    {
        #region[Entity data] 

        private static Offset_poitems EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_poitems obj = new Offset_poitems()
                    {
                        Offset_poitems_id = redr[OFFSET_POITEMS.OFFSET_POITEMS_ID].ToString(),
                        Offset_po_id = redr[OFFSET_POITEMS.OFFSET_PO_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_POITEMS.QTY].ToString(),
                        Price = redr[OFFSET_POITEMS.PRICE].ToString(),
                        Sub_total = redr[OFFSET_POITEMS.SUB_TOTAL].ToString(),
                        Refered_qty = redr[OFFSET_POITEMS.REFERED_QTY].ToString(),
                        Locked = redr[OFFSET_POITEMS.LOCKED].ToString(),
                    };

                    return obj;
                }

            }
            return new Offset_poitems();
        }

        #endregion[Entity List] 

        #region[Entity List] 

        private static List<Offset_poitems> EntityList(string q)
        {
            List<Offset_poitems> list = new List<Offset_poitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_poitems obj = new Offset_poitems()
                    {
                        Offset_poitems_id = redr[OFFSET_POITEMS.OFFSET_POITEMS_ID].ToString(),
                        Offset_po_id = redr[OFFSET_POITEMS.OFFSET_PO_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_POITEMS.QTY].ToString(),
                        Price = redr[OFFSET_POITEMS.PRICE].ToString(),
                        Sub_total = redr[OFFSET_POITEMS.SUB_TOTAL].ToString(),
                        Refered_qty = redr[OFFSET_POITEMS.REFERED_QTY].ToString(),
                        Locked = redr[OFFSET_POITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[PKId] 

        public static Offset_poitems PKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            q += " ON(" + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_PO_ID + " = " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_POITEMS_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_POITEMS_ID + ";\r\n";

            return EntityData(q);
        }

        #endregion[FKId] 

        #region[FKId] 

        public static List<Offset_poitems> FKId(string poid, DAL DAL)
        {
            string q = " SELECT " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            q += " ON(" + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_PO_ID + " = " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_PO.OFFSET_PO_ID + "  = '" + poid + "' \r\n";
            q += " ORDER BY  " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + "." + OFFSET_POITEMS.OFFSET_POITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        public static string GetPrice_po(string poid, string productid)
        {
            if ((poid != "1") && (productid != null))
            {
                string q = " SELECT " + OFFSET_POITEMS.PRICE + " FROM " + OFFSET_POITEMS.OFFSET_POITEMS_TBL + " \r\n";
                q += " WHERE " + OFFSET_POITEMS.OFFSET_PO_ID + " = '" + poid + "' \r\n";
                q += " AND " + OFFSET_POITEMS.PRODUCT_ID + " = '" + productid + "' \r\n";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Offset_poitems obj = new Offset_poitems()
                        {
                            Price = redr[OFFSET_POITEMS.PRICE].ToString(),
                        };

                        return obj.Price;
                    }

                }
            }
            return "0";
        }



    }//cls
}//ns
