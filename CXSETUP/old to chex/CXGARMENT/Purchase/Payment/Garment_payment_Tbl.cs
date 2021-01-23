// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 10:15:25 PM

using CXSETUP; 
using CXLIB; 

namespace CXGARMENT
{
    public class Garment_payment_Tbl
    {
        #region[Create Table]

        public Garment_payment_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL);
            q += Fields.Primary(GARMENT_PAYMENT.GARMENT_PAYMENT_ID);
            q += Fields.Unique_500(GARMENT_PAYMENT.UNIQUENO);
            q += Fields.Foreign(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL, GARMENT_PAYMENT.COMPANY_ID);
            q += Fields.Foreign(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL, GARMENT_PAYMENT.ACY_ID);
            q += Fields.Int(GARMENT_PAYMENT.GARMENT_PAYMENT_NO); 
            q += Fields.Date(GARMENT_PAYMENT.GARMENT_PAYMENT_DATE); 
            q += Fields.Foreign(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL, GARMENT_PAYMENT.PARTY_ID); 
            q += Fields.Foreign(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL, GARMENT_PAYMENT.RECEIPTTYPE_ID); 
            q += Fields.VARCHAR_200(GARMENT_PAYMENT.CHEQUE_NO); 
            q += Fields.Decimal_2(GARMENT_PAYMENT.GARMENT_PAYMENT_AMOUNT); 
            q += Fields.VARCHAR_200(GARMENT_PAYMENT.CHEQUE_DATE); 
            q += Fields.Foreign(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL, GARMENT_PAYMENT.BANK_ID); 
            //q += Fields.Decimal_2(GARMENT_PAYMENT.TOTAL_AMOUNT); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(GARMENT_PAYMENT.GARMENT_PAYMENT_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            paymentItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void paymentItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_PAYMENTITEMS.GARMENT_PAYMENTITEMS_TBL);
            q += Fields.Primary(GARMENT_PAYMENTITEMS.GARMENT_PAYMENTITEMS_ID);
            q += Fields.Foreign(GARMENT_PAYMENTITEMS.GARMENT_PAYMENTITEMS_TBL, GARMENT_PAYMENTITEMS.GARMENT_PAYMENT_ID); 
            q += Fields.VARCHAR_500(GARMENT_PAYMENTITEMS.PAYMENT_BY); 
            q += Fields.VARCHAR_300(GARMENT_PAYMENTITEMS.GARMENT_PURCHASE_NO); 
            q += Fields.Decimal_2(GARMENT_PAYMENTITEMS.GARMENT_PURCHASE_AMOUNT); 
            q += Fields.Decimal_2(GARMENT_PAYMENTITEMS.PAYMENT_AMOUNT); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
