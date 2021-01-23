// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 07:49:58 PM

namespace CXBILL
{
    #region[Properties]

    public class Purchase
    {
        public string Purchase_id { get; set; }
        public string Uniqueno { get; set; }
        public string Company_id { get; set; }
        public string Acy_id { get; set; }
        public string Order_id { get; set; }
        public string Taxtype_id { get; set; }
        public string Salestype_id { get; set; }
        public string Entry_no { get; set; }
        public string Purchase_no { get; set; }
        public string Purchase_date { get; set; }
        public string Party_id { get; set; }
        public decimal Total_qty { get; set; }
        public decimal Total_taxable_amount { get; set; }
        public decimal Total_cgst { get; set; }
        public decimal Total_sgst { get; set; }
        public decimal Total_igst { get; set; }
        public decimal Gsttotal { get; set; }
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

    public static class PURCHASE
    {
        public const string PURCHASE_ID = "PURCHASE_ID";
        public const string UNIQUENO = "UNIQUENO";
        public const string COMPANY_ID = "COMPANY_ID";
        public const string ACY_ID = "ACY_ID";
        public const string ORDER_ID = "ORDER_ID";
        public const string TAXTYPE_ID = "TAXTYPE_ID";
        public const string SALESTYPE_ID = "SALESTYPE_ID";
        public const string ENTRY_NO = "ENTRY_NO";
        public const string PURCHASE_NO = "PURCHASE_NO";
        public const string PURCHASE_DATE = "PURCHASE_DATE";
        public const string PARTY_ID = "PARTY_ID";
        public const string TOTAL_QTY = "TOTAL_QTY";
        public const string TOTAL_TAXABLE_AMOUNT = "TOTAL_TAXABLE_AMOUNT";
        public const string TOTAL_CGST = "TOTAL_CGST";
        public const string TOTAL_SGST = "TOTAL_SGST";
        public const string TOTAL_IGST = "TOTAL_IGST";
        public const string GSTTOTAL = "GSTTOTAL";
        public const string LEDGER_ID = "LEDGER_ID";
        public const string ADDITIONAL = "ADDITIONAL";
        public const string ROUNDS = "ROUNDS";
        public const string GRANDTOTAL = "GRANDTOTAL";
        public const string REFERED_AMT = "REFERED_AMT";
        public const string LOCKED = "LOCKED";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";

        public const string PURCHASE_TBL = "PURCHASE_TBL";
    }

    #endregion[string Const class]

}//ns
