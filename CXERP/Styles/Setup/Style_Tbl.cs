// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 06:03:19 PM

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
            q += AddFields.VARCHAR_500(STYLE.STYLE_NO); 
            q += AddFields.Date(STYLE.STYLE_DATE); 
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
            q += AddFields.VARCHAR_500(STYLEITEMS.STYLE_NO); 
            q += AddFields.Foreign(STYLEITEMS.STYLEITEMS_TBL, STYLEITEMS.STYLE_ID); 
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
