// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 09:42:03 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;

namespace CXERP
{
    public class CArticle_exten
    {
        #region[Entity Data]

        private static Article EntityData(string q)
        {
            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Article obj = new Article()
                    {
                        Article_id = redr[ARTICLE.ARTICLE_ID].ToString(),
                        Po_id = redr[PO.PO_NO].ToString(),
                        Article_no = redr[ARTICLE.ARTICLE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Hsncode_id = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Colours_id = redr[COLOURS.COLOURS_NAME].ToString(),
                        Qty = redr[ARTICLE.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[ARTICLE.PRICE].ToString()),
                        Barcode = redr[ARTICLE.BARCODE].ToString(),
                        Notes = redr[ARTICLE.NOTES].ToString(),
                        Active_id = redr[ARTICLE.ACTIVE_ID].ToString(),
                        User_id = redr[USER.USER_NAME].ToString()
                    };
                    return obj;
                }
                redr.Close();
                return new Article();
            }
        }

        #endregion[Entity Data]

        #region[Entity List]

        private static List<Article> EntityList(string q)
        {
            List<Article> list = new List<Article>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Article obj = new Article()
                    {
                        Article_id = redr[ARTICLE.ARTICLE_ID].ToString(),
                        Po_id = redr[PO.PO_NO].ToString(),
                        Article_no = redr[ARTICLE.ARTICLE_NO].ToString(),
                        Product_id = redr[PRODUCT.PRODUCT_NAME].ToString(),
                        Hsncode_id = redr[HSNCODE.HSNCODE_NAME].ToString(),
                        Sizes_id = redr[SIZES.SIZES_NAME].ToString(),
                        Colours_id = redr[COLOURS.COLOURS_NAME].ToString(),
                        Qty = redr[ARTICLE.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[ARTICLE.PRICE].ToString()),
                        Barcode = redr[ARTICLE.BARCODE].ToString(),
                        Notes = redr[ARTICLE.NOTES].ToString(),
                        Active_id = redr[ARTICLE.ACTIVE_ID].ToString(),
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

        public static List<Article> Active()
        {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += ", " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + PO.PO_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PO.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + ")\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PRODUCT.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + SIZES.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + ")\r\n";
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + COLOURS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[Active]

        #region[NotActive]

        public static List<Article> NotActive()
        {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += ", " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + PO.PO_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PO.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + ")\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PRODUCT.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + SIZES.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + ")\r\n";
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + COLOURS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.NotActive + "' \r\n";
            //q += " AND NOT " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityList(q);
        }

        #endregion[NotActive]

        #region[Primary Key]

        public static Article PKId(string v)
        {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += ", " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + PO.PO_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PO.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + ")\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PRODUCT.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + SIZES.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + ")\r\n";
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + COLOURS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_ID + "  = '" + v + "' \r\n";

            return EntityData(q);
        }

        #endregion[Primary Key]

        #region[Search by name]

        public static Article SearchName(string v)
        {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += ", " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + PO.PO_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PO.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + ")\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PRODUCT.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + SIZES.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + ")\r\n";
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + COLOURS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + "  = '" + v + "' \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return EntityData(q);
        }

        #endregion[Search by name]

        #region[Look up]

        public static DataTable GetforLookup()
        {
            string q = " SELECT " + ARTICLE.ARTICLE_TBL + ".* \r\n";
            q += ", " + PO.PO_TBL + "." + PO.PO_NO + " \r\n";
            q += ", " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_NAME + " \r\n";
            q += ", " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_NAME + " \r\n";
            q += ", " + SIZES.SIZES_TBL + "." + SIZES.SIZES_NAME + " \r\n";
            q += ", " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_NAME + " \r\n";
            q += ", " + USER.USER_TBL + "." + USER.USER_NAME + " \r\n";
            q += " FROM  " + ARTICLE.ARTICLE_TBL + " \r\n";
            q += " INNER JOIN  " + PO.PO_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PO.PO_ID + " = " + PO.PO_TBL + "." + PO.PO_ID + ")\r\n";
            q += " INNER JOIN  " + PRODUCT.PRODUCT_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + PRODUCT.PRODUCT_ID + " = " + PRODUCT.PRODUCT_TBL + "." + PRODUCT.PRODUCT_ID + ")\r\n";
            q += " INNER JOIN  " + HSNCODE.HSNCODE_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + HSNCODE.HSNCODE_ID + " = " + HSNCODE.HSNCODE_TBL + "." + HSNCODE.HSNCODE_ID + ")\r\n";
            q += " INNER JOIN  " + SIZES.SIZES_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + SIZES.SIZES_ID + " = " + SIZES.SIZES_TBL + "." + SIZES.SIZES_ID + ")\r\n";
            q += " INNER JOIN  " + COLOURS.COLOURS_TBL + " \r\n";
            q += " ON( " + ARTICLE.ARTICLE_TBL + "." + COLOURS.COLOURS_ID + " = " + COLOURS.COLOURS_TBL + "." + COLOURS.COLOURS_ID + ")\r\n";
            q += " INNER JOIN  " + USER.USER_TBL + "\r\n";
            q += " ON(" + ARTICLE.ARTICLE_TBL + "." + USER.USER_ID + "  = " + USER.USER_TBL + "." + USER.USER_ID + ")\r\n";
            q += " WHERE " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ACTIVE_ID + "  = '" + Core.Active + "' \r\n";
            //q += " AND NOT " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_ID + " = '" + Core.One + "' \r\n";
            q += " ORDER BY  " + ARTICLE.ARTICLE_TBL + "." + ARTICLE.ARTICLE_NO + ";\r\n";

            return new DAL().Listdata(q);
        }

        #endregion[Look up]

        #region[Get id - Name]

        public static string GetName_Id(string v)
        {
            Article obj = PKId(v);

            if (obj != null)
            {
                return obj.Article_no;
            }
            return "";
        }

        public static string GetId_Name(string v)
        {
            Article obj = SearchName(v);

            if (obj != null)
            {
                return obj.Article_id;
            }
            return "";
        }

        #endregion[Get id - Name]

    }//cls
}//ns
