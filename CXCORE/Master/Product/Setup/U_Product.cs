// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 07-08-2020 01:34:46 PM

using System;
using System.Data;
using CXLIB;
using CXCORE;

namespace CXCORE
{
    public static class U_Product
    {
        #region[]

        public static void GetUpdated(string OldDB)
        {

            string tablename = PRODUCT.PRODUCT_TBL;

            int count = GetCount(tablename, OldDB);

            for (int i = 1; i <= count; i++)
            {
                var obj = GetOldData(i, OldDB);

                if (obj != null)
                {
                    InsertData(obj);
                }
            }
        }

        #endregion[]

        #region[Get Count]

        private static int GetCount(string tablename, string OldDB)
        {
            string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + "_ID";

            string q = "USE " + OldDB + "; ";
            q += "SELECT * FROM " + tablename + " ORDER BY " + ID + " DESC LIMIT 1 ; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    int lastId = Convert.ToInt32(redr[ID]);

                    return lastId;
                }
                return 0;
            }
        }

        #endregion[Get Count]

        #region[Get Old data]

        private static Product GetOldData(int id, string OldDB)
        {
            string q = "USE " + OldDB + "; ";

            q += " SELECT " + PRODUCT.PRODUCT_TBL + ".* \r\n";
            q += ", " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + UNIT.UNIT_TBL + "." + UNIT.UNIT_NAME + " \r\n";
            q += " FROM  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " INNER JOIN  " + PRODUCTTYPE.PRODUCTTYPE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + " = " + PRODUCTTYPE.PRODUCTTYPE_TBL + "." + PRODUCTTYPE.PRODUCTTYPE_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + UNIT.UNIT_TBL + " \r\n";
            q += " ON( " + PRODUCT.PRODUCT_TBL + "." + UNIT.UNIT_ID + " = " + UNIT.UNIT_TBL + "." + UNIT.UNIT_ID + ")\r\n";
            q += " WHERE " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + "  = '" + id + "' \r\n";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Product obj = new Product
                    {
                        Product_name = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Producttype_id = CProducttype_exten.GetId_Name(redr[PRODUCTTYPE.PRODUCTTYPE_NAME].ToString()),
                        Hsncode_id = CHsncode_exten.GetId_Name(redr[HSNCODE.HSNCODE_NAME].ToString()),
                        Unit_id = CUnit_exten.GetId_Name(redr[UNIT.UNIT_NAME].ToString()),
                        Purchase_price = ConvertTO.Decimal(redr[PRODUCT.PURCHASE_PRICE].ToString()),
                        Selling_price = ConvertTO.Decimal(redr[PRODUCT.SELLING_PRICE].ToString()),
                        Sgst_percent = (redr[PRODUCT.SGST_PERCENT].ToString()),
                        Cgst_percent = (redr[PRODUCT.CGST_PERCENT].ToString()),
                        Igst_percent = (redr[PRODUCT.IGST_PERCENT].ToString()),
                        Opening_stock = ConvertTO.Decimal(redr[PRODUCT.OPENING_STOCK].ToString()),
                        Opening_price = ConvertTO.Decimal(redr[PRODUCT.OPENING_PRICE].ToString()),
                        Notes = redr[PRODUCT.NOTES].ToString(),
                        Active_id = redr[PRODUCT.ACTIVE_ID].ToString(),
                        User_id = "1"
                    };

                    return obj;
                }
                return null;
            }
        }

        #endregion[Get Old data]

        #region[Check data]

        private static bool CheckData(Product obj)
        {
            string q = "USE CODEXSUN_DB; ";
            q += "SELECT * FROM " + PRODUCT.PRODUCT_TBL + " WHERE " + PRODUCT.PRODUCT_NAME + " = '" + obj.Product_name + "'; ";

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    obj.Product_id = redr[PRODUCT.PRODUCT_ID].ToString();

                    CProduct.Update(obj, new DAL());

                    return true;
                }
                return false;
            }
        }
        #endregion[Check data]

        #region[Insert data]

        private static void InsertData(Product obj)
        {
            if (CheckData(obj) == false)
            {
                CProduct.Insert(obj, new DAL());
            };

        }
        #endregion[Insert data]

    }//cls
}//ns
