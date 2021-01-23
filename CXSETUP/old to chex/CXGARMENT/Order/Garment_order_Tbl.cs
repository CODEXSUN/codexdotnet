// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 06:03:19 PM

using CXSETUP; 
using CXLIB; 

namespace CXGARMENT
{
    public class Garment_order_Tbl
    {
        #region[Create Table]

        public Garment_order_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_ORDER.GARMENT_ORDER_TBL);
            q += Fields.Primary(GARMENT_ORDER.GARMENT_ORDER_ID);
            q += Fields.Unique_500(GARMENT_ORDER.UNIQUENO);
            q += Fields.Foreign(GARMENT_ORDER.GARMENT_ORDER_TBL, GARMENT_ORDER.COMPANY_ID);
            q += Fields.Foreign(GARMENT_ORDER.GARMENT_ORDER_TBL, GARMENT_ORDER.ACY_ID);
            q += Fields.Int(GARMENT_ORDER.GARMENT_ORDER_NO); 
            q += Fields.Date(GARMENT_ORDER.GARMENT_ORDER_DATE); 
            q += Fields.Foreign(GARMENT_ORDER.GARMENT_ORDER_TBL, GARMENT_ORDER.ORDERTYPE_ID); 
            q += Fields.Foreign(GARMENT_ORDER.GARMENT_ORDER_TBL, GARMENT_ORDER.PARTY_ID); 
            q += Fields.VARCHAR_500(GARMENT_ORDER.PARTY_REF); 
            q += Fields.VARCHAR_500(GARMENT_ORDER.STYLE_REF); 
            q += Fields.VARCHAR_500(GARMENT_ORDER.REFERED_NO); 
            q += Fields.Smallint(GARMENT_ORDER.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(GARMENT_ORDER.GARMENT_ORDER_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            Garment_orderItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Garment_orderItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_ORDERITEMS.GARMENT_ORDERITEMS_TBL);
            q += Fields.Primary(GARMENT_ORDERITEMS.GARMENT_ORDERITEMS_ID);
            q += Fields.Foreign(GARMENT_ORDERITEMS.GARMENT_ORDERITEMS_TBL, GARMENT_ORDERITEMS.GARMENT_ORDER_ID); 
            q += Fields.VARCHAR_500(GARMENT_ORDERITEMS.GARMENT_ORDER_NO); 
            q += Fields.Foreign(GARMENT_ORDERITEMS.GARMENT_ORDERITEMS_TBL, GARMENT_ORDERITEMS.PRODUCT_ID); 
            q += Fields.Foreign(GARMENT_ORDERITEMS.GARMENT_ORDERITEMS_TBL, GARMENT_ORDERITEMS.COLOURS_ID); 
            q += Fields.Foreign(GARMENT_ORDERITEMS.GARMENT_ORDERITEMS_TBL, GARMENT_ORDERITEMS.SIZES_ID); 
            q += Fields.VARCHAR_200(GARMENT_ORDERITEMS.QTY); 
            q += Fields.Decimal_2(GARMENT_ORDERITEMS.PRICE); 
            q += Fields.VARCHAR_200(GARMENT_ORDERITEMS.REFERED_ID); 
            q += Fields.Smallint(GARMENT_ORDERITEMS.LOCKED); 
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
