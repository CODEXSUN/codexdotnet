// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 16-10-2018 11:04:26 PM

namespace CXBILL
{
    #region[Properties]

    public class Quotation
    {
        public string Quotation_id { get; set; }
        public string Uniqueno { get; set; }
        public string Company_id { get; set; }
        //public string Div_id { get; set; }
        public string Acy_id { get; set; }
        public string Order_id { get; set; }
        public string Quotation_no { get; set; }
        public string Quotation_date { get; set; }
        public string Party_id { get; set; }
        public decimal Total_qty { get; set; }
        public decimal Total_taxable_amount { get; set; }
        public string Ledger_id { get; set; }
        public decimal Additional { get; set; }
        public decimal Rounds { get; set; }
        public decimal Grandtotal { get; set; }
        public decimal Refered_amt { get; set; }
        public string Locked { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
        public string User_id { get; set; }
    }

    #endregion[Properties]

    #region[string Const class]

    public class QUOTATION
    {
        public const string QUOTATION_ID = "QUOTATION_ID";
        public const string UNIQUENO = "UNIQUENO";
        public const string COMPANY_ID = "COMPANY_ID";
//        public const string DIV_ID = "DIV_ID";
        public const string ACY_ID = "ACY_ID";
        public const string ORDER_ID = "ORDER_ID";
        public const string QUOTATION_NO = "QUOTATION_NO";
        public const string QUOTATION_DATE = "QUOTATION_DATE";
        public const string PARTY_ID = "PARTY_ID";
        public const string TOTAL_QTY = "TOTAL_QTY";
        public const string TOTAL_TAXABLE_AMOUNT = "TOTAL_TAXABLE_AMOUNT";
        public const string LEDGER_ID = "LEDGER_ID";
        public const string ADDITIONAL = "ADDITIONAL";
        public const string ROUNDS = "ROUNDS";
        public const string GRANDTOTAL = "GRANDTOTAL";
        public const string REFERED_AMT = "REFERED_AMT";
        public const string LOCKED = "LOCKED";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";

        public const string QUOTATION_TBL = "QUOTATION_TBL";
    }

    #endregion[string Const class]

}
