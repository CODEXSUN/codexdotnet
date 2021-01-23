// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 06:03:19 PM

using CXLIB; 

namespace CXERP
{
    public class Article_Tbl
    {
        #region[Create Table]

        public Article_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ARTICLE.ARTICLE_TBL);
            q += AddFields.Primary(ARTICLE.ARTICLE_ID);
            q += AddFields.Unique_500(ARTICLE.UNIQUENO);
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.COMPANY_ID);
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.ACY_ID);
            q += AddFields.VARCHAR_500(ARTICLE.ARTICLE_NO); 
            q += AddFields.Date(ARTICLE.ARTICLE_DATE); 
            q += AddFields.Smallint(ARTICLE.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(ARTICLE.ARTICLE_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

            ArticleItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public static void ArticleItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ARTICLEITEMS.ARTICLEITEMS_TBL);
            q += AddFields.Primary(ARTICLEITEMS.ARTICLEITEMS_ID);
            q += AddFields.Foreign(ARTICLEITEMS.ARTICLEITEMS_TBL, ARTICLEITEMS.ARTICLE_ID); 
            q += AddFields.VARCHAR_500(ARTICLEITEMS.ARTICLE_NO); 
            q += AddFields.Foreign(ARTICLEITEMS.ARTICLEITEMS_TBL, ARTICLEITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(ARTICLEITEMS.ARTICLEITEMS_TBL, ARTICLEITEMS.COLOURS_ID); 
            q += AddFields.Foreign(ARTICLEITEMS.ARTICLEITEMS_TBL, ARTICLEITEMS.SIZES_ID); 
            q += AddFields.VARCHAR_200(ARTICLEITEMS.QTY); 
            q += AddFields.Decimal_2(ARTICLEITEMS.PRICE); 
            q += AddFields.VARCHAR_200(ARTICLEITEMS.REFERED_ID); 
            q += AddFields.Smallint(ARTICLEITEMS.LOCKED); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
