// Version : 3 dt : 01-08-2017
// Auto Generated
// 24-08-2017 08:36:46 PM
// last update : 24-08-2017

using CXLIB;

namespace CXUPVC
{
    #region[Properties]

    public class Upvc_quotation
    {
        public string Upvc_quotation_id { get; set; }
        public string Uniqueno { get; set; }
        public string Company_id { get; set; }
        public string Salestype { get; set; }
        public string Upvc_salesmode_id { get; set; }
        public string Upvc_quotation_no { get; set; }
        public string Upvc_quotation_date { get; set; }
        public string Party_id { get; set; }
        public string Shipping_id { get; set; }
        //public string Transport_mode_id { get; set; }
        //public string Vehicle_no { get; set; }
        public string Total_qty { get; set; }
        public string Total_areasq { get; set; }
        public string Total_taxable_amount { get; set; }
        public string Total_cgst { get; set; }
        public string Total_sgst { get; set; }
        public string Total_igst { get; set; }
        public string Gsttotal { get; set; }
        public string Ledger_id { get; set; }
        public string Additional { get; set; }
        public string Rounds { get; set; }
        public string Grandtotal { get; set; }
        public string Refered_no { get; set; }
        public string Locked { get; set; }
        public string Notes { get; set; }
        public string Active_id { get; set; }
        public string User_id { get; set; }

        public static Upvc_quotation GetNew()
        {
            Upvc_quotation obj = new Upvc_quotation
            {
                Upvc_quotation_id = string.Empty,
                Uniqueno = string.Empty,
                Company_id = string.Empty,
                Salestype = Core.SGST,
                Upvc_salesmode_id = "B2C",
                Upvc_quotation_no = CUpvc_quotation_exten.GetNext_No,
                Upvc_quotation_date = string.Empty,
                Party_id = string.Empty,
                Shipping_id = string.Empty,
                //Transport_mode_id = "ROAD",
                //Vehicle_no = string.Empty,
                Total_qty = string.Empty,
                Total_areasq = string.Empty,
                Total_taxable_amount = string.Empty,
                Total_cgst = string.Empty,
                Total_sgst = string.Empty,
                Total_igst = string.Empty,
                Gsttotal = string.Empty,
                Ledger_id = string.Empty,
                Additional = string.Empty,
                Rounds = string.Empty,
                Grandtotal = string.Empty,
                Refered_no = string.Empty,
                Locked = string.Empty,
                Notes = string.Empty,
                Active_id = Core.Active,
                User_id = Current.User
            };
            return obj;
        }

    }

    #endregion[Properties]

    #region[string Const class]

    public class UPVC_QUOTATION
    {
        public const string UPVC_QUOTATION_ID = "UPVC_QUOTATION_ID";
        public const string YEAR_NO = "YEAR_NO";
        public const string COMPANY_ID = "COMPANY_ID";
        public const string SALESTYPE = "SALESTYPE";
        public const string UPVC_SALESMODE_ID = "UPVC_SALESMODE_ID";
        public const string UPVC_QUOTATION_NO = "UPVC_QUOTATION_NO";
        public const string UPVC_QUOTATION_DATE = "UPVC_QUOTATION_DATE";
        public const string PARTY_ID = "PARTY_ID";
        public const string SHIPPING_ID = "SHIPPING_ID";
        //public const string TRANSPORT_ID = "TRANSPORT_ID";
        //public const string VEHICLE_NO = "VEHICLE_NO";
        public const string TOTAL_QTY = "TOTAL_QTY";
        public const string TOTAL_AREASQ = "TOTAL_AREASQ";
        public const string TOTAL_TAXABLE_AMOUNT = "TOTAL_TAXABLE_AMOUNT";
        public const string TOTAL_CGST = "TOTAL_CGST";
        public const string TOTAL_SGST = "TOTAL_SGST";
        public const string TOTAL_IGST = "TOTAL_IGST";
        public const string GSTTOTAL = "GSTTOTAL";
        public const string LEDGER_ID = "LEDGER_ID";
        public const string ADDITIONAL = "ADDITIONAL";
        public const string ROUNDS = "ROUNDS";
        public const string GRANDTOTAL = "GRANDTOTAL";
        public const string REFERED_NO = "REFERED_NO";
        public const string LOCKED = "LOCKED";
        public const string NOTES = "NOTES";
        public const string ACTIVE_ID = "ACTIVE_ID";
        public const string USER_ID = "USER_ID";
        // 
        public const string UPVC_QUOTATION_TBL = "UPVC_QUOTATION_TBL";
    }

    #endregion[string Const class]

}
