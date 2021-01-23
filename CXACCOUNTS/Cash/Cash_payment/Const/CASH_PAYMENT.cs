// Version : 4.0.0.2 Date : 10-08-2020
// Auto Generated
// last update : 10-08-2020 01:02:27 PM

namespace CXACCOUNTS
{
    #region[Properties]

    public class Cash_payment
    {
        public string Cash_payment_id { get; set; }
        public string Order_id { get; set; }
        public string Payment_date { get; set; }
        public string Ledger_id { get; set; }
        public string Purpose { get; set; }
        public string Party_id { get; set; }
        public decimal Payment_amount { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
        public string User_id { get; set; }
    }

    #endregion[Properties]

    #region[Const]

    public static class CASH_PAYMENT
    {
        public const string CASH_PAYMENT_ID = "CASH_PAYMENT_ID";
        public const string ORDER_ID = "ORDER_ID";
        public const string PAYMENT_DATE = "PAYMENT_DATE";
        public const string LEDGER_ID = "LEDGER_ID";
        public const string PURPOSE = "PURPOSE";
        public const string PARTY_ID = "PARTY_ID";
        public const string PAYMENT_AMOUNT = "PAYMENT_AMOUNT";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";

        public const string CASH_PAYMENT_TBL = "CASH_PAYMENT_TBL";
    }

    #endregion[Const]

}//ns
