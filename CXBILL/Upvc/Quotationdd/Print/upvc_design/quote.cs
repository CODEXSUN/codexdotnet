using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXUPVC
{
    public class PQuote
    {
        public string COPIES { get; set; }
        public string QUOTATION_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string COMPANY_TIN { get; set; }
        public string COMPANY_GST { get; set; }
        public string SALES_TYPE { get; set; }
        public string QUOTATION_NO { get; set; }
        public string QUOTATION_DATE { get; set; }
        public string PARTY_NAME { get; set; }
        public string STREET1 { get; set; }
        public string STREET2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string PINCODE { get; set; }
        public string GSTIN { get; set; }
        public string SHIPPING_NAME { get; set; }
        public string SHIPPING_STREET1 { get; set; }
        public string SHIPPING_STREET2 { get; set; }
        public string SHIPPING_CITY { get; set; }
        public string SHIPPING_STATE { get; set; }
        public string SHIPPING_COUNTRY { get; set; }
        public string SHIPPING_PINCODE { get; set; }
        public string SHIPPING_GSTIN { get; set; }
        public string TOTAL_QTY { get; set; }
        public string TOTAL_AREASQ { get; set; }
        public string TAXABLE_VALUE { get; set; }
        public string LBL_CGST { get; set; }
        public string TOTAL_CGST { get; set; }
        public string LBL_SGST { get; set; }
        public string TOTAL_SGST { get; set; }
        public string TOTAL_SUB { get; set; }
        public string LEDGER { get; set; }
        public string ADDITIONAL { get; set; }
        public string ROUNDS { get; set; }
        public string GSTTOTAL { get; set; }
        public string GRANDTOTAL { get; set; }
        public string AMOUNT_IN_WORDS { get; set; }
        public string NOTES { get; set; }
        public string TERMS { get; set; }
        public string ENTRY_BY { get; set; }
    }

    public class PQuoteitems
    {
        public string QUOTATION_ITEM_ID { get; set; }
        public string QUOTATION_ID { get; set; }
        public string SL_NO { get; set; }
        public string PRODUCT_ID { get; set; }
        public string HSN_CODE_ID { get; set; }
        public string QTY { get; set; }
        public string WIDTHS { get; set; }
        public string HEIGTHS { get; set; }
        public string AREASQ { get; set; }
        public string PRICE { get; set; }
        public string TAXABLEVALUE { get; set; }
        public string CGST_PERCENT { get; set; }
        public string CGST_AMOUNT { get; set; }
        public string SGST_PERCENT { get; set; }
        public string SGST_AMOUNT { get; set; }
        public string SUB_TOTAL { get; set; }
    }
}
