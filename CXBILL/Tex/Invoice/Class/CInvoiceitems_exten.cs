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
    public class CTex_Invoiceitems_exten
    {
        #region[Entity List] 

        private static List<Tex_invoiceitems> EntityList(string q)
        {
            List<Tex_invoiceitems> list = new List<Tex_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Tex_invoiceitems obj = new Tex_invoiceitems()
                    {
                        Tex_invoiceitems_id = redr[TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID].ToString(),
                        Tex_invoice_id = redr[TEX_INVOICEITEMS.TEX_INVOICE_ID].ToString(),
                        //Tex_invoice_no = redr[TEX_INVOICEITEMS.INVOICE_NO].ToString(),
                        //Po_id = redr[PO.PO_NO].ToString(),
                        //Dc_id = redr[DC.DC_NO].ToString(),
                        //Dcitems_id = redr[INVOICEITEMS.DCITEMS_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[TEX_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[TEX_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[TEX_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Tex_invoiceitems> FKId(string id)
        {
            string q = " SELECT " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.INVOICE_NO + " \r\n";
            //q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            //q += ", " + DC.DC_TBL + "." + DC.DC_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + TEX_INVOICE.TEX_INVOICE_TBL + "\r\n";
            q += " ON(" + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.TEX_INVOICE_ID + " = " + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + " )\r\n";
            //q += " INNER JOIN  " + PO.PO_TBL + "\r\n";
            //q += " ON(" + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + " )\r\n";
            //q += " INNER JOIN  " + DC.DC_TBL + "\r\n";
            //q += " ON(" + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.DC_ID + " = " + DC.DC_TBL + "." + DC.DC_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Tex_invoiceitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + " \r\n";
            q += " WHERE " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID + ";\r\n";

            List<Tex_invoiceitems> list = new List<Tex_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Tex_invoiceitems obj = new Tex_invoiceitems()
                    {
                        Tex_invoiceitems_id = redr[TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID].ToString(),
                        Tex_invoice_id = redr[TEX_INVOICEITEMS.TEX_INVOICE_ID].ToString(),
                        //Tex_invoice_no = redr[TEX_INVOICEITEMS.INVOICE_NO].ToString(),
                        Product_id = redr[TEX_INVOICEITEMS.PRODUCT_ID].ToString(),
                        Sizes_id = redr[TEX_INVOICEITEMS.SIZES_ID].ToString(),
                        Qty = redr[TEX_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[TEX_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[TEX_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Tex_invoiceitems> FKNo(string id, DAL DAL)
        {

            string q = " SELECT " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICE.TEX_INVOICE_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + TEX_INVOICEITEMS.TEX_INVOICEITEMS_TBL + "." + TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID + ";\r\n";


            //string q = " SELECT * FROM " + INVOICEITEMS.INVOICEITEMS_TBL + " \r\n";
            //q += " WHERE " + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICE.INVOICE_ID + "  = '" + id + "' \r\n";
            //q += " ORDER BY  " + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.INVOICEITEMS_ID + ";\r\n";

            List<Tex_invoiceitems> list = new List<Tex_invoiceitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Tex_invoiceitems obj = new Tex_invoiceitems()
                    {
                        Tex_invoiceitems_id = redr[TEX_INVOICEITEMS.TEX_INVOICEITEMS_ID].ToString(),
                        Tex_invoice_id = redr[TEX_INVOICEITEMS.TEX_INVOICE_ID].ToString(),
                        //Tex_invoice_no = redr[TEX_INVOICEITEMS.INVOICE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[TEX_INVOICEITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[TEX_INVOICEITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[TEX_INVOICEITEMS.REFERED_ID].ToString(),
                        Locked = redr[TEX_INVOICEITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
