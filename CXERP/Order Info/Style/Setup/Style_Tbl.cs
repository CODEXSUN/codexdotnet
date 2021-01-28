// Version : 5.0.0.0 Date : 27-01-2021
// Auto Generated
// last update : 28-01-2021 03:36:48 PM

using CXLIB; 

namespace CXERP
{
    public class Style_Tbl
    {
        #region[Create Table]

        public Style_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(STYLE.STYLE_TBL);
            q += AddFields.Primary(STYLE.STYLE_ID);
            q += AddFields.Unique_500(STYLE.UNIQUENO);
            q += AddFields.Foreign(STYLE.STYLE_TBL, STYLE.COMPANY_ID);
            q += AddFields.Foreign(STYLE.STYLE_TBL, STYLE.ACY_ID);
            q += AddFields.Int(STYLE.STYLE_NO); 
            q += AddFields.Foreign(STYLE.STYLE_TBL, STYLE.PO_ID); 
            q += AddFields.VARCHAR_500(STYLE.STYLE_NAME); 
            q += AddFields.Smallint(STYLE.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(STYLE.STYLE_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

            StyleItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public static void StyleItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(STYLEITEMS.STYLEITEMS_TBL);
            q += AddFields.Primary(STYLEITEMS.STYLEITEMS_ID);
            q += AddFields.Foreign(STYLEITEMS.STYLEITEMS_TBL, STYLEITEMS.STYLE_ID); 
            q += AddFields.VARCHAR_200(STYLEITEMS.STYLE_NO); 
            q += AddFields.Foreign(STYLEITEMS.STYLEITEMS_TBL, STYLEITEMS.ARTICLE_ID); 
            q += AddFields.Foreign(STYLEITEMS.STYLEITEMS_TBL, STYLEITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(STYLEITEMS.STYLEITEMS_TBL, STYLEITEMS.COLOURS_ID); 
            q += AddFields.Foreign(STYLEITEMS.STYLEITEMS_TBL, STYLEITEMS.SIZES_ID); 
            q += AddFields.VARCHAR_200(STYLEITEMS.QTY); 
            q += AddFields.Decimal_2(STYLEITEMS.PRICE); 
            q += AddFields.VARCHAR_200(STYLEITEMS.REFERED_ID); 
            q += AddFields.Smallint(STYLEITEMS.LOCKED); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
