// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:18 AM

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class CGarment_invoiceitems_exten
    {
        #region[Entity List] 

        private static List<Garment_invoiceitems> EntityList(string q)
        {
            List<Garment_invoiceitems> list = new List<Garment_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Garment_invoiceitems obj = new Garment_invoiceitems()
                    {
                        Garment_invoiceitems_id = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID].ToString(),
                        Garment_invoice_id = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID].ToString(),
                        Garment_invoice_no = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.PRICE].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[GARMENT_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[GARMENT_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Garment_invoiceitems> FKId(string id)
        {
            string q = " SELECT " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID + " = " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Garment_invoiceitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + " \r\n";
            q += " WHERE " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID + ";\r\n";

            List<Garment_invoiceitems> list = new List<Garment_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Garment_invoiceitems obj = new Garment_invoiceitems()
                    {
                        Garment_invoiceitems_id = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID].ToString(),
                        Garment_invoice_id = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID].ToString(),
                        Garment_invoice_no = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_ID].ToString(),
                        Qty = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[GARMENT_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[GARMENT_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Garment_invoiceitems> FKNo(string id, DAL DAL)
        {

            string q = " SELECT " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICE.GARMENT_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_TBL + "." + GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID + ";\r\n";

            List<Garment_invoiceitems> list = new List<Garment_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Garment_invoiceitems obj = new Garment_invoiceitems()
                    {
                        Garment_invoiceitems_id = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICEITEMS_ID].ToString(),
                        Garment_invoice_id = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICE_ID].ToString(),
                        Garment_invoice_no = redr[GARMENT_INVOICEITEMS.GARMENT_INVOICE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Qty = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.QTY].ToString()),
                        Price = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[GARMENT_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[GARMENT_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[GARMENT_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns

