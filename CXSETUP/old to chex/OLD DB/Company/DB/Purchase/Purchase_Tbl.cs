using CXBILL;
using CXLIB;

namespace CXSETUP
{
    public class Purchase_Tbl
    {
        public Purchase_Tbl(string database)
        {
            string q = USE.DB(database);

            q += CREATE.TABLE(PAYMENT.PAYMENT_TBL);
            q += Fields.Primary(PAYMENT.PAYMENT_ID);
            q += Fields.Unique(PAYMENT.UNIQUENO);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.COMPANY_ID);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.DIV_ID);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.ACY_ID);
            q += Fields.Int(PAYMENT.PAYMENT_NO);
            q += Fields.Date(PAYMENT.PAYMENT_DATE);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.PARTY_ID);
            q += Fields.Decimal(PAYMENT.AMOUNT);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.MODE_ID);
            q += Fields.VAR100(PAYMENT.CHEQUE_NO);
            q += Fields.Date(PAYMENT.CHEQUE_DATE);
            q += Fields.Foreign(PAYMENT.PAYMENT_TBL, PAYMENT.BANK_ID);
            q += Fields.Date(PAYMENT.DEPOSITON);
            q += Fields.Notes();
            q += Fields.Active();
            q += Fields.User_id(PAYMENT.PAYMENT_TBL);
            new DAL().Execute(q);
        }
    }
}
