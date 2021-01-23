// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-05-2019 04:10:38 PM

using CXLIB; 

namespace CXCORE
{
    public class Vouchertype_Tbl
    {
        #region[Create Table]

        public Vouchertype_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(VOUCHERTYPE.VOUCHERTYPE_TBL);
            q += AddFields.Primary(VOUCHERTYPE.VOUCHERTYPE_ID);
            q += AddFields.Unique_500(VOUCHERTYPE.VOUCHERTYPE_NAME); 
            q += AddFields.Foreign(VOUCHERTYPE.VOUCHERTYPE_TBL, VOUCHERTYPE.METHOD_ID); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(VOUCHERTYPE.VOUCHERTYPE_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Vouchertype(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(VOUCHERTYPE.VOUCHERTYPE_TBL);
            q += DB.FIELD_1ST(VOUCHERTYPE.VOUCHERTYPE_ID);
            q += DB.FIELD(VOUCHERTYPE.VOUCHERTYPE_NAME);
            q += DB.FIELD(VOUCHERTYPE.METHOD_ID);
            q += DB.NOTES;
            q += DB.ACTIVE_ID;
            q += DB.USER_ID;
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("-");
            q += DB.VALUE("1");
            q += DB.NotesValue;
            q += DB.ActiveValue;
            q += DB.UserValue;
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
