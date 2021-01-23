// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 08:38:55 PM

using CXLIB;

namespace CXERP
{
    public static class CArticle
    {

        #region[Get New]

        public static Article GetNew
        {
            get
            {
                Article obj = new Article()
                {
                    Article_id = string.Empty,
                    Po_id = string.Empty,
                    Article_no = string.Empty,
                    Product_id = string.Empty,
                    Hsncode_id = string.Empty,
                    Size_id = string.Empty,
                    Colour_id = string.Empty,
                    Qty = string.Empty,
                    Price = decimal.Zero,
                    Barcode = string.Empty,
                    Notes = string.Empty,
                    Active_id = Core.Active,
                    User_id = Current.User
                };
                return obj;
            }
        }

        #endregion[Get New]

        #region[Attach params]

        private static string AttachParams(string q, Article v)
        {
            q = q.Replace("@" + ARTICLE.ARTICLE_ID + "@", "" + ConvertTO.SqlString(v.Article_id) + "");
            q = q.Replace("@" + ARTICLE.PO_ID + "@", "" + ConvertTO.SqlString(v.Po_id) + "");
            q = q.Replace("@" + ARTICLE.ARTICLE_NO + "@", "" + ConvertTO.SqlString(v.Article_no) + "");
            q = q.Replace("@" + ARTICLE.PRODUCT_ID + "@", "" + ConvertTO.SqlString(v.Product_id) + "");
            q = q.Replace("@" + ARTICLE.HSNCODE_ID + "@", "" + ConvertTO.SqlString(v.Hsncode_id) + "");
            q = q.Replace("@" + ARTICLE.SIZES_ID + "@", "" + ConvertTO.SqlString(v.Size_id) + "");
            q = q.Replace("@" + ARTICLE.COLOURS_ID + "@", "" + ConvertTO.SqlString(v.Colour_id) + "");
            q = q.Replace("@" + ARTICLE.QTY + "@", "" + ConvertTO.SqlString(v.Qty) + "");
            q = q.Replace("@" + ARTICLE.PRICE + "@", "" + ConvertTO.SqlDecimal(v.Price) + "");
            q = q.Replace("@" + ARTICLE.BARCODE + "@", "" + ConvertTO.SqlString(v.Barcode) + "");
            q = q.Replace("@" + ARTICLE.NOTES + "@", "" + ConvertTO.SqlString(v.Notes) + "");
            q = q.Replace("@" + ARTICLE.ACTIVE_ID + "@", "" + ConvertTO.SqlString(v.Active_id) + "");
            q = q.Replace("@" + ARTICLE.USER_ID + "@", "" + ConvertTO.SqlString(v.User_id) + "");
            return q;
        }
        #endregion[Attach params]

        #region[Insert]

        public static void Insert(Article v, DAL dalsession)
        {
            string q = " INSERT INTO " + ARTICLE.ARTICLE_TBL + " ( ";
            q += " " + ARTICLE.PO_ID + " \r\n ";
            q += "," + ARTICLE.ARTICLE_NO + " \r\n ";
            q += "," + ARTICLE.PRODUCT_ID + " \r\n ";
            q += "," + ARTICLE.HSNCODE_ID + " \r\n ";
            q += "," + ARTICLE.SIZES_ID + " \r\n ";
            q += "," + ARTICLE.COLOURS_ID + " \r\n ";
            q += "," + ARTICLE.QTY + " \r\n ";
            q += "," + ARTICLE.PRICE + " \r\n ";
            q += "," + ARTICLE.BARCODE + " \r\n ";
            q += "," + ARTICLE.NOTES + " \r\n ";
            q += "," + ARTICLE.ACTIVE_ID + " \r\n ";
            q += "," + ARTICLE.USER_ID + " \r\n ";
            q += " ) VALUES ( ";
            q += "  @" + ARTICLE.PO_ID + "@ \r\n ";
                q += ", @" + ARTICLE.ARTICLE_NO + "@ \r\n ";
                q += ", @" + ARTICLE.PRODUCT_ID + "@ \r\n ";
                q += ", @" + ARTICLE.HSNCODE_ID + "@ \r\n ";
                q += ", @" + ARTICLE.SIZES_ID + "@ \r\n ";
                q += ", @" + ARTICLE.COLOURS_ID + "@ \r\n ";
                q += ", @" + ARTICLE.QTY + "@ \r\n ";
                q += ", @" + ARTICLE.PRICE + "@ \r\n ";
                q += ", @" + ARTICLE.BARCODE + "@ \r\n ";
            q += ", @" + ARTICLE.NOTES + "@ \r\n ";
            q += ", @" + ARTICLE.ACTIVE_ID + "@ \r\n ";
            q += ", @" + ARTICLE.USER_ID + "@ \r\n ";
            q += " ) \r\n ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Insert]

        #region[Update]

        public static void Update(Article v, DAL dalsession)
        {
            string q = "UPDATE " + ARTICLE.ARTICLE_TBL + " SET";
            q += " " + ARTICLE.PO_ID + " = @" + ARTICLE.PO_ID + "@ \r\n ";
            q += "," + ARTICLE.ARTICLE_NO + " = @" + ARTICLE.ARTICLE_NO + "@ \r\n ";
            q += "," + ARTICLE.PRODUCT_ID + " = @" + ARTICLE.PRODUCT_ID + "@ \r\n ";
            q += "," + ARTICLE.HSNCODE_ID + " = @" + ARTICLE.HSNCODE_ID + "@ \r\n ";
            q += "," + ARTICLE.SIZES_ID + " = @" + ARTICLE.SIZES_ID + "@ \r\n ";
            q += "," + ARTICLE.COLOURS_ID + " = @" + ARTICLE.COLOURS_ID + "@ \r\n ";
            q += "," + ARTICLE.QTY + " = @" + ARTICLE.QTY + "@ \r\n ";
            q += "," + ARTICLE.PRICE + " = @" + ARTICLE.PRICE + "@ \r\n ";
            q += "," + ARTICLE.BARCODE + " = @" + ARTICLE.BARCODE + "@ \r\n ";
            q += "," + ARTICLE.NOTES + " = @" + ARTICLE.NOTES + "@ \r\n ";
            q += "," + ARTICLE.ACTIVE_ID + " = @" + ARTICLE.ACTIVE_ID + "@ \r\n ";
            q += "," + ARTICLE.USER_ID + " = @" + ARTICLE.USER_ID + "@ \r\n ";
            q += "  WHERE " + ARTICLE.ARTICLE_ID + " = @" + ARTICLE.ARTICLE_ID + "@ ";
            q = AttachParams(q, v);
            dalsession.Execute(q);
        }
        #endregion[Update]

        #region[Delete]

        public static void Delete(string pkid, DAL dalsession)
        {
            dalsession.Execute("DELETE FROM  " + ARTICLE.ARTICLE_TBL + " WHERE " + ARTICLE.ARTICLE_ID + " =  " + pkid + ";");
        }
        #endregion[Delete]

    }//cls
}//ns
