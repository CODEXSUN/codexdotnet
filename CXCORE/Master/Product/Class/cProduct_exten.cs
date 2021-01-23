// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:11:09 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;

namespace CXCORE
{
    public class CProduct_exten
    {
        #region[Entity Data]

        private static Product EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Product obj = new Product()
                    {
                        Product_id = redr[PRODUCT.PRODUCT_ID].ToString(),
                        Product_name = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Producttype_id = redr[PRODUCTTYPE.PRODUCTTYPE_NAME].ToString(),
                        Hsncode_id = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Unit_id = redr[UNIT.UNIT_NAME].ToString(),
                        Purchase_price = ConvertTO.Decimal(redr[PRODUCT.PURCHASE_PRICE].ToString()),
                        Selling_price = ConvertTO.Decimal(redr[PRODUCT.SELLING_PRICE].ToString()),
                        Sgst_percent = redr[PRODUCT.SGST_PERCENT].ToString(),
                        Cgst_percent = redr[PRODUCT.CGST_PERCENT].ToString(),
                        Igst_percent = redr[PRODUCT.IGST_PERCENT].ToString(),
                        Opening_stock = ConvertTO.Decimal(redr[PRODUCT.OPENING_STOCK].ToString()),
                        Opening_price = ConvertTO.Decimal(redr[PRODUCT.OPENING_PRICE].ToString()),
                        Notes = redr[PRODUCT.NOTES].ToString(),
                        Active_id = redr[PRODUCT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Product();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Product> EntityList(string q)
        {
            List<Product> list = new List<Product>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Product obj = new Product()
                    {
                        Product_id = redr[PRODUCT.PRODUCT_ID].ToString(),
                        Product_name = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Producttype_id = redr[PRODUCTTYPE.PRODUCTTYPE_NAME].ToString(),
                        Hsncode_id = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Unit_id = redr[UNIT.UNIT_NAME].ToString(),
                        Purchase_price = ConvertTO.Decimal(redr[PRODUCT.PURCHASE_PRICE].ToString()),
                        Selling_price = ConvertTO.Decimal(redr[PRODUCT.SELLING_PRICE].ToString()),
                        Sgst_percent = redr[PRODUCT.SGST_PERCENT].ToString(),
                        Cgst_percent = redr[PRODUCT.CGST_PERCENT].ToString(),
                        Igst_percent = redr[PRODUCT.IGST_PERCENT].ToString(),
                        Opening_stock = ConvertTO.Decimal(redr[PRODUCT.OPENING_STOCK].ToString()),
                        Opening_price = ConvertTO.Decimal(redr[PRODUCT.OPENING_PRICE].ToString()),
                        Notes = redr[PRODUCT.NOTES].ToString(),
                        Active_id = redr[PRODUCT.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;
        }

        #endregion[Entity List]

        #region[Active]

        public static List<Product> Active(DAL DAL)
        {
            string q = " SELECT " + PRODUCT.PRODUCT_TBL + ".* \r\n";
            q += ", " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + UNIT.UNIT_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + UNIT.UNIT_ID + " = " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCT.PRODUCT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Product> NotActive(DAL DAL)
        {
            string q = " SELECT " + PRODUCT.PRODUCT_TBL + ".* \r\n";
            q += ", " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + UNIT.UNIT_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + UNIT.UNIT_ID + " = " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCT.PRODUCT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Product PKId(string v, DAL DAL)
        {
            string q = " SELECT " + PRODUCT.PRODUCT_TBL + ".* \r\n";
            q += ", " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + UNIT.UNIT_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + UNIT.UNIT_ID + " = " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCT.PRODUCT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Product SearchName(string v, DAL DAL)
        {
            string q = " SELECT " + PRODUCT.PRODUCT_TBL + ".* \r\n";
            q += ", " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + UNIT.UNIT_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + UNIT.UNIT_ID + " = " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCT.PRODUCT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup(DAL DAL)
        {
            string q = " SELECT " + PRODUCT.PRODUCT_TBL + ".* \r\n";
            q += ", " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + UNIT.UNIT_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + UNIT.UNIT_ID + " = " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + PRODUCT.PRODUCT_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + ";\r\n";

            return DAL.Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string _pId)
        {
            Product obj = PKId(_pId, new DAL());

            if (obj != null)
            {
                return obj.Product_name;
            }
            return "";
        }

        public static string GetId_Name(string _pName)
        {
            Product obj = SearchName(_pName, new DAL());

            if (obj != null)
            {
                return obj.Product_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
