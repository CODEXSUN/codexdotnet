using System;

namespace CXBILL
{
    public class SALES_GST
    {
        public const string COMPANY_NAME = "COMPANY_NAME";
        public const string ACY_NAME = "ACY_NAME";
        public const string SALES_MONTH = "SALES_MONTH";
        public const string GSTIN = "GSTIN";
        public const string PARTY_NAME = "PARTY_NAME";
        public const string BILL_NO = "BILL_NO";
        public const string BILL_DATE = "BILL_DATE";
        public const string BILL_AMOUNT = "BILL_AMOUNT";
        public const string TAXABLE_VALUE = "TAXABLE_VALUE";
        public const string SGST_PERCENT = "SGST_PERCENT";
        public const string SGST_AMOUNT = "SGST_AMOUNT";
        public const string CGST_PERCENT = "CGST_PERCENT";
        public const string CGST_AMOUNT = "CGST_AMOUNT";
        public const string IGST_PERCENT = "IGST_PERCENT";
        public const string IGST_AMOUNT = "IGST_AMOUNT";
        public const string GST_TOTAL = "GST_TOTAL";

        public const string SALES_GST_TBL = "SALES_GST_TBL";
    }

    public class Sales_Gst
    {
        public string Company_name { get; set; }
        public string Acy_name { get; set; }
        public string Sales_Month { get; set; }
        public string Gstin { get; set; }
        public string Party_name { get; set; }
        public string Bill_no { get; set; }
        public string Bill_date { get; set; }
        public decimal Bill_amount { get; set; }
        public decimal Taxable_value { get; set; }
        public string Sgst_percent { get; set; }
        public decimal Sgst_amount { get; set; }
        public string Cgst_percent { get; set; }
        public decimal Cgst_amount { get; set; }
        public string Igst_percent { get; set; }
        public decimal Igst_amount { get; set; }
        public decimal Gst_total { get; set; }
    }
}
