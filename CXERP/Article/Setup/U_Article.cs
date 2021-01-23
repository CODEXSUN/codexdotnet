// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 09:42:04 PM

using System; 
using System.Data; 
using CXLIB; 
using CXCORE; 

namespace CXERP
{
    public static class U_Article
    {
        #region[]

            public static void GetUpdated(string OldDB)
            {

                string tablename = ARTICLE.ARTICLE_TBL;

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

            private static Article GetOldData(int id, string OldDB)
            {
                string q = "USE " + OldDB + "; ";
                q += "SELECT * FROM " + ARTICLE.ARTICLE_TBL + " WHERE " + ARTICLE.ARTICLE_ID + " = '" + id + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        Article obj = new Article
                        {
                        Po_id = redr[ARTICLE.PO_ID].ToString(),
                        Article_no = redr[ARTICLE.ARTICLE_NO].ToString(),
                        Product_id = redr[ARTICLE.PRODUCT_ID].ToString(),
                        Hsncode_id = redr[ARTICLE.HSNCODE_ID].ToString(),
                        Sizes_id = redr[ARTICLE.SIZES_ID].ToString(),
                        Colours_id = redr[ARTICLE.COLOURS_ID].ToString(),
                        Qty = redr[ARTICLE.QTY].ToString(),
                        Price = ConvertTO.Decimal(redr[ARTICLE.PRICE].ToString()),
                        Barcode = redr[ARTICLE.BARCODE].ToString(),
                        Notes = redr[ARTICLE.NOTES].ToString(),
                        Active_id = redr[ARTICLE.ACTIVE_ID].ToString(),
                        User_id = "1"
                        };

                        return obj;
                    }
                    return null;
                }
            }

        #endregion[Get Old data]

#region[Check data]

            private static bool CheckData(Article obj)
            {
                string q = "USE CODEXSUN_DB; ";
                q += "SELECT * FROM " + ARTICLE.ARTICLE_TBL + " WHERE " + ARTICLE.ARTICLE_NO + " = '" + obj.Article_no + "'; ";

                using (IDataReader redr = new DAL().Listreader(q))
                {
                    while (redr.Read() == true)
                    {
                        obj.Article_id = redr[ARTICLE.ARTICLE_ID].ToString();

                        CArticle.Update(obj, new DAL());

                        return true;
                    }
                    return false;
                }
            }
            #endregion[Check data]

        #region[Insert data]

            private static void InsertData(Article obj)
            {
                if (CheckData(obj) == false)
                {
                    CArticle.Insert(obj, new DAL());
                };

            }
        #endregion[Insert data]

    }//cls
}//ns
