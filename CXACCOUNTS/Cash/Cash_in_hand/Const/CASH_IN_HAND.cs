// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:37 PM

namespace CXACCOUNTS
{
    #region[Properties]

    public class Cash_in_hand
    {
        public string Cash_in_hand_id { get; set; }
        public string Entry_date { get; set; }
        public string Cash_receipt_id { get; set; }
        public string Cash_payment_id { get; set; }
        public decimal Receipt_amount { get; set; }
        public decimal Payment_amount { get; set; }
        public decimal Balance_amount { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
        public string User_id { get; set; }
    }

    #endregion[Properties]

    #region[Const]

    public static class CASH_IN_HAND
    {
        public const string CASH_IN_HAND_ID = "CASH_IN_HAND_ID";
        public const string ENTRY_DATE = "ENTRY_DATE";
        public const string CASH_RECEIPT_ID = "CASH_RECEIPT_ID";
        public const string CASH_PAYMENT_ID = "CASH_PAYMENT_ID";
        public const string RECEIPT_AMOUNT = "RECEIPT_AMOUNT";
        public const string PAYMENT_AMOUNT = "PAYMENT_AMOUNT";
        public const string BALANCE_AMOUNT = "BALANCE_AMOUNT";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";

        public const string CASH_IN_HAND_TBL = "CASH_IN_HAND_TBL";
    }

    #endregion[Const]

}//ns
