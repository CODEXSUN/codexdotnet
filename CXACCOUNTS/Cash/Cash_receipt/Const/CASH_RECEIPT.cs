// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 09-08-2020 09:29:47 PM

namespace CXACCOUNTS
{
    #region[Properties]

    public class Cash_receipt
    {
        public string Cash_receipt_id { get; set; }
        public string Receipt_date { get; set; }
        public string Party_id { get; set; }
        public string Purpose { get; set; }
        public decimal Receipt_amount { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
        public string User_id { get; set; }
    }

    #endregion[Properties]

    #region[Const]

    public static class CASH_RECEIPT
    {
        public const string CASH_RECEIPT_ID = "CASH_RECEIPT_ID";
        public const string RECEIPT_DATE = "RECEIPT_DATE";
        public const string PARTY_ID = "PARTY_ID";
        public const string PURPOSE = "PURPOSE";
        public const string RECEIPT_AMOUNT = "RECEIPT_AMOUNT";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";

        public const string CASH_RECEIPT_TBL = "CASH_RECEIPT_TBL";
    }

    #endregion[Const]

}//ns
