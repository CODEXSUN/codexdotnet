// Version : 3 dt : 01-08-2017
// Auto Generated
// 02-10-2017 07:16:41 PM
// last update : 02-10-2017

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_1_invoiceitems_exten
    {
        #region[Entity List] 

        private static List<Offset_labouritems> EntityList(string q)
        {
            List<Offset_labouritems> list = new List<Offset_labouritems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_labouritems obj = new Offset_labouritems()
                    {
                        Offset_labouritems_id = redr[OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID].ToString(),
                        Offset_labour_id = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_ID].ToString(),
                        Offset_labour_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_NO].ToString(),
                        Offset_labour_po_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO].ToString(),
                        Offset_labour_dc_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_LABOURITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_LABOURITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_LABOURITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Offset_labouritems> FKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOURITEMS.OFFSET_LABOUR_ID + " = " + OFFSET_LABOUR.OFFSET_LABOUR_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOURITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Offset_labouritems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + " \r\n";
            q += " WHERE " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID + ";\r\n";

            List<Offset_labouritems> list = new List<Offset_labouritems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_labouritems obj = new Offset_labouritems()
                    {
                        Offset_labouritems_id = redr[OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID].ToString(),
                        Offset_labour_id = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_ID].ToString(),
                        Offset_labour_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_NO].ToString(),
                        Offset_labour_po_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO].ToString(),
                        Offset_labour_dc_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO].ToString(),
                        Product_id = redr[OFFSET_LABOURITEMS.PRODUCT_ID].ToString(),
                        Qty = redr[OFFSET_LABOURITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_LABOURITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_LABOURITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Offset_labouritems> FKNo(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOURITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOUR.OFFSET_LABOUR_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL + "." + OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID + ";\r\n";

            List<Offset_labouritems> list = new List<Offset_labouritems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_labouritems obj = new Offset_labouritems()
                    {
                        Offset_labouritems_id = redr[OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID].ToString(),
                        Offset_labour_id = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_ID].ToString(),
                        Offset_labour_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_NO].ToString(),
                        Offset_labour_po_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO].ToString(),
                        Offset_labour_dc_no = redr[OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_LABOURITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_LABOURITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_LABOURITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_LABOURITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
