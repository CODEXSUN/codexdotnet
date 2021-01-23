// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 16-12-2018 01:30:03 PM

using CXBILL;
using CXLIB;

namespace CXSETUP
{
    public class PaymentTbl
    {

        #region[Table]

        public PaymentTbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PAYMENT.PAYMENT_TBL);
            q += Fields.Primary(PAYMENT.PAYMENT_ID);
            q += Fields.Unique_500(PAYMENT.UNIQUENO);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.COMPANY_ID);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.DIV_ID);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.ACY_ID);
            q += Fields.Int(PAYMENT.PAYMENT_NO);
            q += Fields.Date(PAYMENT.PAYMENT_DATE);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.PARTY_ID);
            q += Fields.Decimal_2(PAYMENT.PAYMENT_AMOUNT);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.RECEIPTTYPE_ID);
            q += Fields.VARCHAR_100(PAYMENT.CHEQUE_NO);
            q += Fields.VARCHAR_100(PAYMENT.CHEQUE_DATE);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.BANK_ID);
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(PAYMENT.PAYMENT_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            Paymentitems_tbl(db);
        }
        #endregion[Table]

        #region[Table Items]

        public void Paymentitems_tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PAYMENTITEMS.PAYMENTITEMS_TBL);
            q += Fields.Primary(PAYMENTITEMS.PAYMENTITEMS_ID);
            q += Fields.Foreign(PAYMENTITEMS.PAYMENTITEMS_TBL, PAYMENTITEMS.PAYMENT_ID);
            q += Fields.VARCHAR_100(PAYMENTITEMS.PAYMENT_BY);
            q += Fields.VARCHAR_100(PAYMENTITEMS.PURCHASE_NO);
            q += Fields.Decimal_2(PAYMENTITEMS.PURCHASE_AMOUNT);
            q += Fields.Decimal_2(PAYMENTITEMS.PAYMENT_AMOUNT);
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
