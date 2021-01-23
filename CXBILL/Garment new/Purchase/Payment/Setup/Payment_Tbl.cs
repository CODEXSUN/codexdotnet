// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 10:15:25 PM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class Payment_Tbl
    {
        #region[Create Table]

        public Payment_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PAYMENT.PAYMENT_TBL);
            q += AddFields.Primary(PAYMENT.PAYMENT_ID);
            q += AddFields.Unique_500(PAYMENT.UNIQUENO);
            q += AddFields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.COMPANY_ID);
            q += AddFields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.ACY_ID);
            q += AddFields.Int(PAYMENT.PAYMENT_NO); 
            q += AddFields.Date(PAYMENT.PAYMENT_DATE); 
            q += AddFields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.PARTY_ID); 
            q += AddFields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.RECEIPTTYPE_ID); 
            q += AddFields.VARCHAR_200(PAYMENT.CHEQUE_NO); 
            q += AddFields.Decimal_2(PAYMENT.PAYMENT_AMOUNT); 
            q += AddFields.VARCHAR_200(PAYMENT.CHEQUE_DATE); 
            q += AddFields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.BANK_ID); 
            //q += Fields.Decimal_2(GARMENT_PAYMENT.TOTAL_AMOUNT); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(PAYMENT.PAYMENT_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            paymentItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void paymentItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PAYMENTITEMS.PAYMENTITEMS_TBL);
            q += AddFields.Primary(PAYMENTITEMS.PAYMENTITEMS_ID);
            q += AddFields.Foreign(PAYMENTITEMS.PAYMENTITEMS_TBL, PAYMENTITEMS.PAYMENT_ID); 
            q += AddFields.VARCHAR_500(PAYMENTITEMS.PAYMENT_BY); 
            q += AddFields.VARCHAR_300(PAYMENTITEMS.PURCHASE_NO); 
            q += AddFields.Decimal_2(PAYMENTITEMS.PURCHASE_AMOUNT); 
            q += AddFields.Decimal_2(PAYMENTITEMS.PAYMENT_AMOUNT); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
