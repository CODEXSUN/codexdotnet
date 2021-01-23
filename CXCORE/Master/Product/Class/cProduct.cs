// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 10:11:09 PM

using CXLIB;

namespace CXCORE
{
    public class CProduct
    {

        #region[Get New]

        public static Product GetNew
        {
            get
            {
                Product obj = new Product()
                {
                    Product_id = string.Empty,
                    Product_name = string.Empty,
                    Producttype_id = string.Empty,
                    Hsncode_id = string.Empty,
                    Unit_id = string.Empty,
                    Purchase_price = decimal.Zero,
                    Selling_price = decimal.Zero,
                    Sgst_percent = string.Empty,
                    Cgst_percent = string.Empty,
                    Igst_percent = string.Empty,
                    Opening_stock = decimal.Zero,
                    Opening_price = decimal.Zero,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Product v)
        {
            q = q.Replace("@" + PRODUCT.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + PRODUCT.PRODUCT_NAME + "@", "" + ConvertTO.SqlString(v.Product_name) + "");
            q = q.Replace("@" + PRODUCT.PRODUCTTYPE_ID + "@", "" + ConvertTO.SqlString(v.Producttype_id) + "");
            q = q.Replace("@" + PRODUCT.HSNCODE_ID + "@", "" + ConvertTO.SqlString(v.Hsncode_id) + "");
            q = q.Replace("@" + PRODUCT.UNIT_ID + "@", "" + ConvertTO.SqlString(v.Unit_id) + "");
            q = q.Replace("@" + PRODUCT.PURCHASE_PRICE + "@", "" + ConvertTO.SqlDecimal(v.Purchase_price) + "");
            q = q.Replace("@" + PRODUCT.SELLING_PRICE + "@", "" + ConvertTO.SqlDecimal(v.Selling_price) + "");
            q = q.Replace("@" + PRODUCT.SGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Sgst_percent) + "");
            q = q.Replace("@" + PRODUCT.CGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Cgst_percent) + "");
            q = q.Replace("@" + PRODUCT.IGST_PERCENT + "@", "" + ConvertTO.SqlString(v.Igst_percent) + "");
            q = q.Replace("@" + PRODUCT.OPENING_STOCK + "@", "" + ConvertTO.SqlDecimal(v.Opening_stock) + "");
            q = q.Replace("@" + PRODUCT.OPENING_PRICE + "@", "" + ConvertTO.SqlDecimal(v.Opening_price) + "");
            q = q.Replace("@" + PRODUCT.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + PRODUCT.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + PRODUCT.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Product v, DAL dalsession)
        {
                string q = " INSERT INTO " + PRODUCT.PRODUCT_TBL + " ( ";
                q += " " + PRODUCT.PRODUCT_NAME + " \r\n ";
                q += "," + PRODUCT.PRODUCTTYPE_ID + " \r\n ";
                q += "," + PRODUCT.HSNCODE_ID + " \r\n ";
                q += "," + PRODUCT.UNIT_ID + " \r\n ";
                q += "," + PRODUCT.PURCHASE_PRICE + " \r\n ";
                q += "," + PRODUCT.SELLING_PRICE + " \r\n ";
                q += "," + PRODUCT.SGST_PERCENT + " \r\n ";
                q += "," + PRODUCT.CGST_PERCENT + " \r\n ";
                q += "," + PRODUCT.IGST_PERCENT + " \r\n ";
                q += "," + PRODUCT.OPENING_STOCK + " \r\n ";
                q += "," + PRODUCT.OPENING_PRICE + " \r\n ";
                q += "," + PRODUCT.NOTES + " \r\n ";
                q += "," + PRODUCT.ACTIVE_ID + " \r\n ";
                q += "," + PRODUCT.USER_ID + " \r\n ";
                q += " ) VALUES ( ";
                q += "  @"+ PRODUCT.PRODUCT_NAME + "@ \r\n ";
                q += ", @"+ PRODUCT.PRODUCTTYPE_ID + "@ \r\n ";
                q += ", @"+ PRODUCT.HSNCODE_ID + "@ \r\n ";
                q += ", @"+ PRODUCT.UNIT_ID + "@ \r\n ";
                q += ", @"+ PRODUCT.PURCHASE_PRICE + "@ \r\n ";
                q += ", @"+ PRODUCT.SELLING_PRICE + "@ \r\n ";
                q += ", @"+ PRODUCT.SGST_PERCENT + "@ \r\n ";
                q += ", @"+ PRODUCT.CGST_PERCENT + "@ \r\n ";
                q += ", @"+ PRODUCT.IGST_PERCENT + "@ \r\n ";
                q += ", @"+ PRODUCT.OPENING_STOCK + "@ \r\n ";
                q += ", @"+ PRODUCT.OPENING_PRICE + "@ \r\n ";
                q += ", @"+ PRODUCT.NOTES + "@ \r\n ";
                q += ", @"+ PRODUCT.ACTIVE_ID + "@ \r\n ";
                q += ", @"+ PRODUCT.USER_ID + "@ \r\n ";
                q += " ) \r\n ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Product v, DAL dalsession)
        {
                string q = "UPDATE " + PRODUCT.PRODUCT_TBL + " SET";
                q += " " + PRODUCT.PRODUCT_NAME + " = @" + PRODUCT.PRODUCT_NAME + "@ \r\n ";
                q += "," + PRODUCT.PRODUCTTYPE_ID + " = @" + PRODUCT.PRODUCTTYPE_ID + "@ \r\n ";
                q += "," + PRODUCT.HSNCODE_ID + " = @" + PRODUCT.HSNCODE_ID + "@ \r\n ";
                q += "," + PRODUCT.UNIT_ID + " = @" + PRODUCT.UNIT_ID + "@ \r\n ";
                q += "," + PRODUCT.PURCHASE_PRICE + " = @" + PRODUCT.PURCHASE_PRICE + "@ \r\n ";
                q += "," + PRODUCT.SELLING_PRICE + " = @" + PRODUCT.SELLING_PRICE + "@ \r\n ";
                q += "," + PRODUCT.SGST_PERCENT + " = @" + PRODUCT.SGST_PERCENT + "@ \r\n ";
                q += "," + PRODUCT.CGST_PERCENT + " = @" + PRODUCT.CGST_PERCENT + "@ \r\n ";
                q += "," + PRODUCT.IGST_PERCENT + " = @" + PRODUCT.IGST_PERCENT + "@ \r\n ";
                q += "," + PRODUCT.OPENING_STOCK + " = @" + PRODUCT.OPENING_STOCK + "@ \r\n ";
                q += "," + PRODUCT.OPENING_PRICE + " = @" + PRODUCT.OPENING_PRICE + "@ \r\n ";
                q += "," + PRODUCT.NOTES + " = @" + PRODUCT.NOTES + "@ \r\n ";
                q += "," + PRODUCT.ACTIVE_ID + " = @" + PRODUCT.ACTIVE_ID + "@ \r\n ";
                q += "," + PRODUCT.USER_ID + " = @" + PRODUCT.USER_ID + "@ \r\n ";
                q += "  WHERE " + PRODUCT.PRODUCT_ID + " = @" + PRODUCT.PRODUCT_ID + "@ ";
                q = AttachParams(q, v);
                dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid , DAL dalsession)
        {
                dalsession.Execute("DELETE FROM  " + PRODUCT.PRODUCT_TBL+ " WHERE " + PRODUCT.PRODUCT_ID + " =  " + pkid +";");
        }
        #endregion[Delete]

    }//cls
}//ns
