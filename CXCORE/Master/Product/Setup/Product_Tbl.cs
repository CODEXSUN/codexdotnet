// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Product_Tbl
    {
        #region[Create Table]

        public Product_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PRODUCT.PRODUCT_TBL);
            q += AddFields.Primary(PRODUCT.PRODUCT_ID);
            q += AddFields.Unique_500(PRODUCT.PRODUCT_NAME); 
            q += AddFields.Foreign(PRODUCT.PRODUCT_TBL, PRODUCT.PRODUCTTYPE_ID); 
            q += AddFields.Foreign(PRODUCT.PRODUCT_TBL, PRODUCT.HSNCODE_ID); 
            q += AddFields.Foreign(PRODUCT.PRODUCT_TBL, PRODUCT.UNIT_ID); 
            q += AddFields.Decimal_2(PRODUCT.PURCHASE_PRICE); 
            q += AddFields.Decimal_2(PRODUCT.SELLING_PRICE); 
            q += AddFields.VARCHAR_200(PRODUCT.SGST_PERCENT); 
            q += AddFields.VARCHAR_200(PRODUCT.CGST_PERCENT); 
            q += AddFields.VARCHAR_200(PRODUCT.IGST_PERCENT); 
            q += AddFields.Decimal_3(PRODUCT.OPENING_STOCK); 
            q += AddFields.Decimal_2(PRODUCT.OPENING_PRICE); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(PRODUCT.PRODUCT_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Product(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(PRODUCT.PRODUCT_TBL);
            q += DB.FIELD_1ST(PRODUCT.PRODUCT_ID);
            q += DB.FIELD(PRODUCT.PRODUCT_NAME);
            q += DB.FIELD(PRODUCT.PRODUCTTYPE_ID);
            q += DB.FIELD(PRODUCT.HSNCODE_ID);
            q += DB.FIELD(PRODUCT.UNIT_ID);
            q += DB.FIELD(PRODUCT.PURCHASE_PRICE);
            q += DB.FIELD(PRODUCT.SELLING_PRICE);
            q += DB.FIELD(PRODUCT.SGST_PERCENT);
            q += DB.FIELD(PRODUCT.CGST_PERCENT);
            q += DB.FIELD(PRODUCT.IGST_PERCENT);
            q += DB.FIELD(PRODUCT.OPENING_STOCK);
            q += DB.FIELD(PRODUCT.OPENING_PRICE);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("0");
            q += DB.VALUE("0");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("-");
            q += DB.VALUE("0");
            q += DB.VALUE("0");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

           new SYS_DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
