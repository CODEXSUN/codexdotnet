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

        private static List<Offset_1_invoiceitems> EntityList(string q)
        {
            List<Offset_1_invoiceitems> list = new List<Offset_1_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_1_invoiceitems obj = new Offset_1_invoiceitems()
                    {
                        Offset_1_invoiceitems_id = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID].ToString(),
                        Offset_1_invoice_id = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_ID].ToString(),
                        Offset_1_invoice_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_NO].ToString(),
                        Offset_1_po_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_PO_NO].ToString(),
                        Offset_1_dc_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_DC_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_1_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_1_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_1_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Offset_1_invoiceitems> FKId(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_ID + " = " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Offset_1_invoiceitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + " \r\n";
            q += " WHERE " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID + ";\r\n";

            List<Offset_1_invoiceitems> list = new List<Offset_1_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_1_invoiceitems obj = new Offset_1_invoiceitems()
                    {
                        Offset_1_invoiceitems_id = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID].ToString(),
                        Offset_1_invoice_id = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_ID].ToString(),
                        Offset_1_invoice_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_NO].ToString(),
                        Offset_1_po_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_PO_NO].ToString(),
                        Offset_1_dc_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_DC_NO].ToString(),
                        Product_id = redr[OFFSET_1_INVOICEITEMS.PRODUCT_ID].ToString(),
                        Qty = redr[OFFSET_1_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_1_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_1_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Offset_1_invoiceitems> FKNo(string id, DAL DAL)
        {
            string q = " SELECT " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICE.OFFSET_1_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_TBL + "." + OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID + ";\r\n";

            List<Offset_1_invoiceitems> list = new List<Offset_1_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Offset_1_invoiceitems obj = new Offset_1_invoiceitems()
                    {
                        Offset_1_invoiceitems_id = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICEITEMS_ID].ToString(),
                        Offset_1_invoice_id = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_ID].ToString(),
                        Offset_1_invoice_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_INVOICE_NO].ToString(),
                        Offset_1_po_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_PO_NO].ToString(),
                        Offset_1_dc_no = redr[OFFSET_1_INVOICEITEMS.OFFSET_1_DC_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = redr[OFFSET_1_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[OFFSET_1_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[OFFSET_1_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[OFFSET_1_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
