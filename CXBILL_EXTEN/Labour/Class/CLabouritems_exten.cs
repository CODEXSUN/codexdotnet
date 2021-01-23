// Version : 3 dt : 01-08-2017
// Auto Generated
// 02-10-2017 07:16:41 PM
// last update : 02-10-2017

using System.Collections.Generic;
using System.Data;
using CXBILL_EXTEN.Labour.Const;
using CXCORE;
using CXLIB;

namespace CXBILL_EXTEN.Labour.Class
{
    public static class CLabouritems_exten
    {
        #region[Entity List] 

        private static List<Labouritems> EntityList(string q)
        {
            List<Labouritems> list = new List<Labouritems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Labouritems obj = new Labouritems()
                    {
                        Labouritems_id = redr[LABOURITEMS.LABOURITEMS_ID].ToString(),
                        Labour_id = redr[LABOURITEMS.LABOUR_ID].ToString(),
                        Po_no = redr[LABOURITEMS.PO_NO].ToString(),
                        Dc_no = redr[LABOURITEMS.DC_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[LABOURITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[LABOURITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[LABOURITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[LABOURITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[LABOURITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[LABOURITEMS.REFERED_ID].ToString(),
                        Locked = redr[LABOURITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[Entity List] 

        #region[FKId] 

        public static List<Labouritems> FKId(string id)
        {
            string q = " SELECT " + LABOURITEMS.LABOURITEMS_TBL + ".* \r\n";
            q += ", " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_NO + " \r\n";
            //q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            //q += ", " + DC.DC_TBL + "." + DC.DC_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + LABOURITEMS.LABOURITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + LABOUR.LABOUR_TBL + "\r\n";
            q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.LABOUR_ID + " = " + LABOUR.LABOUR_TBL + "." + LABOUR.LABOUR_ID + " )\r\n";
            //q += " INNER JOIN  " + PO.PO_TBL + "\r\n";
            //q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + " )\r\n";
            //q += " INNER JOIN  " + DC.DC_TBL + "\r\n";
            //q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.DC_ID + " = " + DC.DC_TBL + "." + DC.DC_ID + " )\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOUR.LABOUR_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.LABOURITEMS_ID + ";\r\n";

            return EntityList(q);
        }

        #endregion[FKId] 

        #region[FK withoutJoin] 

        public static List<Labouritems> FK_withoutJoin(string id, DAL DAL)
        {
            string q = " SELECT * FROM " + LABOURITEMS.LABOURITEMS_TBL + " \r\n";
            q += " WHERE " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOUR.LABOUR_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.LABOURITEMS_ID + ";\r\n";

            List<Labouritems> list = new List<Labouritems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Labouritems obj = new Labouritems()
                    {
                        Labouritems_id = redr[LABOURITEMS.LABOURITEMS_ID].ToString(),
                        Labour_id = redr[LABOURITEMS.LABOUR_ID].ToString(),
                        Po_no = redr[LABOURITEMS.PO_NO].ToString(),
                        Dc_no = redr[LABOURITEMS.DC_NO].ToString(),
                        Product_id = redr[LABOURITEMS.PRODUCT_ID].ToString(),
                        Sizes_id = redr[LABOURITEMS.SIZES_ID].ToString(),
                        Qty = redr[LABOURITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[LABOURITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[LABOURITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[LABOURITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[LABOURITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[LABOURITEMS.REFERED_ID].ToString(),
                        Locked = redr[LABOURITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

        #region[FK withoutJoin] 

        public static List<Labouritems> FKNo(string id, DAL DAL)
        {

            string q = " SELECT " + LABOURITEMS.LABOURITEMS_TBL + ".* \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += " FROM  " + LABOURITEMS.LABOURITEMS_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + "\r\n";
            q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " )\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + "\r\n";
            q += " ON(" + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + " )\r\n";
            q += " WHERE " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOUR.LABOUR_ID + "  = '" + id + "' \r\n";
            q += " ORDER BY  " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.LABOURITEMS_ID + ";\r\n";


            //string q = " SELECT * FROM " + LABOURITEMS.LABOURITEMS_TBL + " \r\n";
            //q += " WHERE " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOUR.LABOUR_ID + "  = '" + id + "' \r\n";
            //q += " ORDER BY  " + LABOURITEMS.LABOURITEMS_TBL + "." + LABOURITEMS.LABOURITEMS_ID + ";\r\n";

            List<Labouritems> list = new List<Labouritems>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Labouritems obj = new Labouritems()
                    {
                        Labouritems_id = redr[LABOURITEMS.LABOURITEMS_ID].ToString(),
                        Labour_id = redr[LABOURITEMS.LABOUR_ID].ToString(),
                        Po_no = redr[LABOURITEMS.PO_NO].ToString(),
                        Dc_no = redr[LABOURITEMS.DC_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Qty = redr[LABOURITEMS.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[LABOURITEMS.PRICE].ToString()),
                        Cgst_percent = ConvertTO.Decimal(redr[LABOURITEMS.CGST_PERCENT].ToString()),
                        Sgst_percent = ConvertTO.Decimal(redr[LABOURITEMS.SGST_PERCENT].ToString()),
                        Igst_percent = ConvertTO.Decimal(redr[LABOURITEMS.IGST_PERCENT].ToString()),
                        Refered_id = redr[LABOURITEMS.REFERED_ID].ToString(),
                        Locked = redr[LABOURITEMS.LOCKED].ToString(),
                    };

                    list.Add(obj);
                }

            }
            return list;
        }

        #endregion[FK withoutJoin] 

    }//cls
}//ns
