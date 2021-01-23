// Version : 3 dt : 01-08-2017
// Auto Generated
// 01-10-2017 09:52:50 PM
// last update : 01-10-2017

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_dcitems_exten
    {
        #region[Entity List] 

        private static List<Offset_dcitems> EntityList(string q)
        {
            List<Offset_dcitems> list = new List<Offset_dcitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_dcitems obj = new Offset_dcitems()
                    {
                        Offset_dcitems_id = redr[OFFSET_DCITEMS.OFFSET_DCITEMS_ID].ToString(),
                        Offset_dc_id = redr[OFFSET_DCITEMS.OFFSET_DC_ID].ToString(),
                        Offset_dc_no = redr[OFFSET_DCITEMS.OFFSET_DC_NO].ToString(),
                        Offset_po_id = redr[OFFSET_PO.OFFSET_PO_NO].ToString(),
                        Offset_poitems_id = redr[OFFSET_DCITEMS.OFFSET_POITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_DCITEMS.QTY].ToString(),
                        Refered_qty = redr[OFFSET_DCITEMS.REFERED_QTY].ToString(),
                        Locked = redr[OFFSET_DCITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Offset_dcitems> FKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + " \r\n";
            q += ", " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_DC.OFFSET_DC_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " = " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " )\r\n";
            q += " INNER JOIN  " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_PO_ID + " = " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DC.OFFSET_DC_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin]  

        public static List<Offset_dcitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT  * FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " \r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_DCITEMS.OFFSET_DCITEMS_ID + ";\r\n";

            List<Offset_dcitems> list = new List<Offset_dcitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_dcitems obj = new Offset_dcitems()
                    {
                        Offset_dcitems_id = redr[OFFSET_DCITEMS.OFFSET_DCITEMS_ID].ToString(),
                        Offset_dc_id = redr[OFFSET_DCITEMS.OFFSET_DC_ID].ToString(),
                        Offset_dc_no = redr[OFFSET_DCITEMS.OFFSET_DC_NO].ToString(),
                        Offset_po_id = redr[OFFSET_DCITEMS.OFFSET_PO_ID].ToString(),
                        Offset_poitems_id = redr[OFFSET_DCITEMS.OFFSET_POITEMS_ID].ToString(),
                        Product_id = redr[OFFSET_DCITEMS.PRODUCT_ID].ToString(),
                        Qty = redr[OFFSET_DCITEMS.QTY].ToString(),
                        Refered_qty = redr[OFFSET_DCITEMS.REFERED_QTY].ToString(),
                        Locked = redr[OFFSET_DCITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin]  

    }//cls
}//ns
