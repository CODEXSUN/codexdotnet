// Version : 3 dt : 01-08-2017
// Auto Generated
// 02-10-2017 07:16:41 PM
// last update : 02-10-2017

using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXKNITTING
{
    public class CInvoiceitems_exten
    {
        #region[Entity List] 

        private static List<Knitting_Invoiceitems> EntityList(string q)
        {
            List<Knitting_Invoiceitems> list = new List<Knitting_Invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Knitting_Invoiceitems obj = new Knitting_Invoiceitems()
                    {
                        Knitting_Invoiceitems_id = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID].ToString(),
                        Knitting_Invoice_id = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID].ToString(),
                        Knitting_Invoice_no = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Noofrolls = redr[KNITTING_INVOICEITEMS.NOOFROLLS].ToString(),
                        Qty = redr[KNITTING_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[KNITTING_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[KNITTING_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Knitting_Invoiceitems> FKId(string id, DAL DAL)
        {
            string q = " SELECT " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + KNITTING_INVOICE.KNITTING_INVOICE_TBL + "." + KNITTING_INVOICE.KNITTING_INVOICE_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += " FROM  " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + KNITTING_INVOICE.KNITTING_INVOICE_TBL + "\r\n";
            q += " ON(" + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID + " = " + KNITTING_INVOICE.KNITTING_INVOICE_TBL + "." + KNITTING_INVOICE.KNITTING_INVOICE_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " WHERE " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICE.KNITTING_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Knitting_Invoiceitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + " \r\n";
            q += " WHERE " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICE.KNITTING_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID + ";\r\n";

            List<Knitting_Invoiceitems> list = new List<Knitting_Invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Knitting_Invoiceitems obj = new Knitting_Invoiceitems()
                    {
                        Knitting_Invoiceitems_id = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID].ToString(),
                        Knitting_Invoice_id = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID].ToString(),
                        Knitting_Invoice_no = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO].ToString(),
                        Product_id = redr[KNITTING_INVOICEITEMS.PRODUCT_ID].ToString(),
                        Noofrolls = redr[KNITTING_INVOICEITEMS.NOOFROLLS].ToString(),
                        Qty = redr[KNITTING_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[KNITTING_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[KNITTING_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Knitting_Invoiceitems> FKNo(string id, DAL DAL)
        {

            string q = " SELECT " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.NOOFROLLS + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICE.KNITTING_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_TBL + "." + KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID + ";\r\n";


            //string q = " SELECT * FROM " + INVOICEITEMS.INVOICEITEMS_TBL + " \r\n";
            //q += " WHERE " + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICE.INVOICE_ID + "  = '" + id + "' \r\n";
            //q += " ORDER BY  " + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.INVOICEITEMS_ID + ";\r\n";

            List<Knitting_Invoiceitems> list = new List<Knitting_Invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Knitting_Invoiceitems obj = new Knitting_Invoiceitems()
                    {
                        Knitting_Invoiceitems_id = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICEITEMS_ID].ToString(),
                        Knitting_Invoice_id = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICE_ID].ToString(),
                        Knitting_Invoice_no = redr[KNITTING_INVOICEITEMS.KNITTING_INVOICE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Noofrolls = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[KNITTING_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[KNITTING_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[KNITTING_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[KNITTING_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
