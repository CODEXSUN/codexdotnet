// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 13-07-2020 08:01:31 AM

using CXLIB; 

namespace CXCORE
{
    public class Shipping_Tbl
    {
        #region[Create Table]

        public Shipping_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(SHIPPING.SHIPPING_TBL);
            q += AddFields.Primary(SHIPPING.SHIPPING_ID);
            q += AddFields.Unique_500(SHIPPING.SHIPPING_NAME); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(SHIPPING.SHIPPING_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Shipping(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(SHIPPING.SHIPPING_TBL);
            q += DB.FIELD_1ST(SHIPPING.SHIPPING_ID);
            q += DB.FIELD(SHIPPING.SHIPPING_NAME);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
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
