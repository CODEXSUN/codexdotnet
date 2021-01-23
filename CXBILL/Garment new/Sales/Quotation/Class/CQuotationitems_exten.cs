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
    public class CQuotationitems_exten
    {
        #region[Entity List] 

        private static List<Quotationitems> EntityList(string q)
        {
            List<Quotationitems> list = new List<Quotationitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotationitems obj = new Quotationitems()
                    {
                        Quotationitems_id = redr[QUOTATIONITEMS.QUOTATIONITEMS_ID].ToString(),
                        Quotation_id = redr[QUOTATIONITEMS.QUOTATION_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[QUOTATIONITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[QUOTATIONITEMS.PRICE].ToString()),
                        Refered_id = redr[QUOTATIONITEMS.REFERED_ID].ToString(),
                        Locked = redr[QUOTATIONITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Quotationitems> FKId(string id, DAL DAL)
        {
            string q = " SELECT " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + ".* \r\n";
            q += ", " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + QUOTATION.QUOTATION_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.QUOTATION_ID + " = " + QUOTATION.QUOTATION_TBL + "." + QUOTATION.QUOTATION_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATION.QUOTATION_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.QUOTATIONITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Quotationitems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " \r\n";
            q += " WHERE " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATION.QUOTATION_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.QUOTATIONITEMS_ID + ";\r\n";

            List<Quotationitems> list = new List<Quotationitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotationitems obj = new Quotationitems()
                    {
                        Quotationitems_id = redr[QUOTATIONITEMS.QUOTATIONITEMS_ID].ToString(),
                        Quotation_id = redr[QUOTATIONITEMS.QUOTATION_ID].ToString(),
                        Product_id = redr[QUOTATIONITEMS.PRODUCT_ID].ToString(),
                        Sizes_id = redr[QUOTATIONITEMS.SIZES_ID].ToString(),
                        Qty = redr[QUOTATIONITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[QUOTATIONITEMS.PRICE].ToString()),
                        Refered_id = redr[QUOTATIONITEMS.REFERED_ID].ToString(),
                        Locked = redr[QUOTATIONITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Quotationitems> FKNo(string id, DAL DAL)
        {

            string q = " SELECT " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATION.QUOTATION_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.QUOTATIONITEMS_ID + ";\r\n";


            //string q = " SELECT * FROM " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + " \r\n";
            //q += " WHERE " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATION.QUOTATION_ID + "  = '" + id + "' \r\n";
            //q += " ORDER BY  " + QUOTATIONITEMS.QUOTATIONITEMS_TBL + "." + QUOTATIONITEMS.QUOTATIONITEMS_ID + ";\r\n";

            List<Quotationitems> list = new List<Quotationitems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Quotationitems obj = new Quotationitems()
                    {
                        Quotationitems_id = redr[QUOTATIONITEMS.QUOTATIONITEMS_ID].ToString(),
                        Quotation_id = redr[QUOTATIONITEMS.QUOTATION_ID].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[QUOTATIONITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[QUOTATIONITEMS.PRICE].ToString()),
                        Refered_id = redr[QUOTATIONITEMS.REFERED_ID].ToString(),
                        Locked = redr[QUOTATIONITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
