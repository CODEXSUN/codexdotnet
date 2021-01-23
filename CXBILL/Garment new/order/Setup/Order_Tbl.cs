// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 06:03:19 PM

using CXLIB; 

namespace CXBILL
{
    public class Order_Tbl
    {
        #region[Create Table]

        public Order_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ORDER.ORDER_TBL);
            q += AddFields.Primary(ORDER.ORDER_ID);
            q += AddFields.Unique_500(ORDER.UNIQUENO);
            q += AddFields.Foreign(ORDER.ORDER_TBL, ORDER.COMPANY_ID);
            q += AddFields.Foreign(ORDER.ORDER_TBL, ORDER.ACY_ID);
            q += AddFields.VARCHAR_500(ORDER.ORDER_NO); 
            q += AddFields.Date(ORDER.ORDER_DATE); 
            q += AddFields.Foreign(ORDER.ORDER_TBL, ORDER.ORDERTYPE_ID); 
            q += AddFields.Foreign(ORDER.ORDER_TBL, ORDER.PARTY_ID); 
            q += AddFields.VARCHAR_500(ORDER.PARTY_REF); 
            q += AddFields.VARCHAR_500(ORDER.STYLE_REF); 
            q += AddFields.VARCHAR_500(ORDER.REFERED_NO); 
            q += AddFields.Smallint(ORDER.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(ORDER.ORDER_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

            OrderItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void OrderItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(ORDERITEMS.ORDERITEMS_TBL);
            q += AddFields.Primary(ORDERITEMS.ORDERITEMS_ID);
            q += AddFields.Foreign(ORDERITEMS.ORDERITEMS_TBL, ORDERITEMS.ORDER_ID); 
            q += AddFields.VARCHAR_500(ORDERITEMS.ORDER_NO); 
            q += AddFields.Foreign(ORDERITEMS.ORDERITEMS_TBL, ORDERITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(ORDERITEMS.ORDERITEMS_TBL, ORDERITEMS.COLOURS_ID); 
            q += AddFields.Foreign(ORDERITEMS.ORDERITEMS_TBL, ORDERITEMS.SIZES_ID); 
            q += AddFields.VARCHAR_200(ORDERITEMS.QTY); 
            q += AddFields.Decimal_2(ORDERITEMS.PRICE); 
            q += AddFields.VARCHAR_200(ORDERITEMS.REFERED_ID); 
            q += AddFields.Smallint(ORDERITEMS.LOCKED); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
