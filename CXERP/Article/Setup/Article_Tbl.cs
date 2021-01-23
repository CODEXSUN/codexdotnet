// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 23-01-2021 09:42:04 PM

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
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.PO_ID); 
            q += AddFields.VARCHAR_500(ARTICLE.ARTICLE_NO); 
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.PRODUCT_ID); 
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.HSNCODE_ID); 
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.SIZES_ID); 
            q += AddFields.Foreign(ARTICLE.ARTICLE_TBL, ARTICLE.COLOURS_ID); 
            q += AddFields.VARCHAR_200(ARTICLE.QTY); 
            q += AddFields.Decimal_2(ARTICLE.PRICE); 
            q += AddFields.VARCHAR_500(ARTICLE.BARCODE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(ARTICLE.ARTICLE_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Article(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(ARTICLE.ARTICLE_TBL);
            q += DB.FIELD_1ST(ARTICLE.ARTICLE_ID);
            q += DB.FIELD(ARTICLE.PO_ID);
            q += DB.FIELD(ARTICLE.ARTICLE_NO);
            q += DB.FIELD(ARTICLE.PRODUCT_ID);
            q += DB.FIELD(ARTICLE.HSNCODE_ID);
            q += DB.FIELD(ARTICLE.SIZES_ID);
            q += DB.FIELD(ARTICLE.COLOURS_ID);
            q += DB.FIELD(ARTICLE.QTY);
            q += DB.FIELD(ARTICLE.PRICE);
            q += DB.FIELD(ARTICLE.BARCODE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("1");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("-");
            q += DB.VALUE("0");
            q += DB.VALUE("-");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
