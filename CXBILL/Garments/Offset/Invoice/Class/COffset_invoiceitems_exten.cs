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
    public class COffset_invoiceitems_exten
    {
        #region[Entity List] 

        private static List<Offset_invoiceitems> EntityList(string q)
        {
            List<Offset_invoiceitems> list = new List<Offset_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_invoiceitems obj = new Offset_invoiceitems()
                    {
                        Offset_invoiceitems_id = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID].ToString(),
                        Offset_invoice_id = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID].ToString(),
                        Offset_invoice_no = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO].ToString(),
                        Offset_po_id = redr[OFFSET_PO.OFFSET_PO_NO].ToString(),
                        Offset_dc_id = redr[OFFSET_DC.OFFSET_DC_NO].ToString(),
                        Offset_dcitems_id = redr[OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Offset_invoiceitems> FKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_INVOICE.OFFSET_INVOICE_TBL + "." + OFFSET_INVOICE.OFFSET_INVOICE_NO + " \r\n";
            q += ", " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_NO + " \r\n";
            q += ", " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_INVOICE.OFFSET_INVOICE_TBL + "\r\n";
            q += " ON(" + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID + " = " + OFFSET_INVOICE.OFFSET_INVOICE_TBL + "." + OFFSET_INVOICE.OFFSET_INVOICE_ID + " )\r\n";
            q += " INNER JOIN  " + OFFSET_PO.OFFSET_PO_TBL + "\r\n";
            q += " ON(" + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.OFFSET_PO_ID + " = " + OFFSET_PO.OFFSET_PO_TBL + "." + OFFSET_PO.OFFSET_PO_ID + " )\r\n";
            q += " INNER JOIN  " + OFFSET_DC.OFFSET_DC_TBL + "\r\n";
            q += " ON(" + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.OFFSET_DC_ID + " = " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICE.OFFSET_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Offset_invoiceitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " \r\n";
            q += " WHERE " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICE.OFFSET_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID + ";\r\n";

            List<Offset_invoiceitems> list = new List<Offset_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_invoiceitems obj = new Offset_invoiceitems()
                    {
                        Offset_invoiceitems_id = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID].ToString(),
                        Offset_invoice_id = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID].ToString(),
                        Offset_invoice_no = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO].ToString(),
                        Offset_po_id = redr[OFFSET_PO.OFFSET_PO_ID].ToString(),
                        Offset_dc_id = redr[OFFSET_DC.OFFSET_DC_ID].ToString(),
                        Offset_dcitems_id = redr[OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID].ToString(),
                        Product_id = redr[OFFSET_INVOICEITEMS.PRODUCT_ID].ToString(),
                        Qty = redr[OFFSET_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Offset_invoiceitems> FKNo(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICE.OFFSET_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_TBL + "." + OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID + ";\r\n";

            List<Offset_invoiceitems> list = new List<Offset_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_invoiceitems obj = new Offset_invoiceitems()
                    {
                        Offset_invoiceitems_id = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICEITEMS_ID].ToString(),
                        Offset_invoice_id = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_ID].ToString(),
                        Offset_invoice_no = redr[OFFSET_INVOICEITEMS.OFFSET_INVOICE_NO].ToString(),
                        Offset_po_id = redr[OFFSET_INVOICEITEMS.OFFSET_PO_ID].ToString(),
                        Offset_dc_id = redr[OFFSET_INVOICEITEMS.OFFSET_DC_ID].ToString(),
                        Offset_dcitems_id = redr[OFFSET_INVOICEITEMS.OFFSET_DCITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
