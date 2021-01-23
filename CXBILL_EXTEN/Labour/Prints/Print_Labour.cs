namespace CXBILL_EXTEN.Labour.Prints
{
    public class Print_Labour
    {
        public string COPY_NAME { get; set; }
        public string TAX_TYPE { get; set; }
        public string SALES_TYPE { get; set; }

        public string COMPANY_NAME { get; set; }
        public string COMPANY_ADDRESS_1 { get; set; }
        public string COMPANY_ADDRESS_2 { get; set; }
        public string COMPANY_PHONE { get; set; }
        public string COMPANY_CELL1 { get; set; }
        public string COMPANY_CELL2 { get; set; }
        public string COMPANY_EMAIL { get; set; }
        public string COMPANY_WEBSITE { get; set; }
        public string COMPANY_GSTIN { get; set; }

        public string LABOUR_ID { get; set; }
        public string LABOUR_NO { get; set; }
        public string LABOUR_DATE { get; set; }

        public string TRANSPORT { get; set; }
        public string DELIVERYTO { get; set; }
        public string BUNDEL { get; set; }
        public string PARTY_NAME { get; set; }
        public string PARTY_STREET_1 { get; set; }
        public string PARTY_STREET_2 { get; set; }
        public string PARTY_CITY { get; set; }
        public string PARTY_STATE { get; set; }
        public string PARTY_STATE_CODE { get; set; }
        public string PARTY_COUNTRY { get; set; }
        public string PARTY_PINCODE { get; set; }
        public string PARTY_GSTIN { get; set; }

        public string TOTAL_QTY { get; set; }
        public string TAXABLE_VALUE { get; set; }

        public string CGST_PERCENT { get; set; }
        public string SGST_PERCENT { get; set; }
        public string IGST_PERCENT { get; set; }

        public string TOTAL_CGST { get; set; }
        public string TOTAL_SGST { get; set; }
        public string TOTAL_IGST { get; set; }
        public string TOTAL_CESS { get; set; }
        public string TOTAL_SUB { get; set; }
        public string LEDGER { get; set; }
        public string ADDITIONAL { get; set; }
        public string ROUNDS { get; set; }
        public string GSTTOTAL { get; set; }

        public string GRANDTOTAL { get; set; }
        public string AMOUNT_IN_WORDS { get; set; }
        public string NOTES { get; set; }
        public string ENTRY_BY { get; set; }

        public string FORSIGN { get; set; }

        public string ACCOUNT_NO { get; set; }
        public string IFSC_CODE { get; set; } 
        public string BANK_NAME { get; set; } 
        public string BRANCH { get; set; } 

        public string TERMS_1 { get; set; }
        public string TERMS_2 { get; set; }
        public string TERMS_3 { get; set; }
        public string TERMS_4 { get; set; }

    }

    public static class PRINT_LABOUR
    {
        public const string COPY_NAME = "COPY_NAME";

        public const string TAX_TYPE = "TAX_TYPE";
        public const string SALES_TYPE = "SALES_TYPE";

        public const string COMPANY_NAME = "COMPANY_NAME";
        public const string COMPANY_ADDRESS_1 = "COMPANY_ADDRESS_1";
        public const string COMPANY_ADDRESS_2 = "COMPANY_ADDRESS_2";
        public const string COMPANY_PHONE = "COMPANY_PHONE";
        public const string COMPANY_CELL1 = "COMPANY_CELL1";
        public const string COMPANY_CELL2 = "COMPANY_CELL2";
        public const string COMPANY_EMAIL = "COMPANY_EMAIL";
        public const string COMPANY_WEBSITE = "COMPANY_WEBSITE";
        public const string COMPANY_GSTIN = "COMPANY_GSTIN";

        public const string LABOUR_ID = "LABOUR_ID";
        public const string LABOUR_NO = "LABOUR_NO";
        public const string LABOUR_DATE = "LABOUR_DATE";

        public const string TRANSPORT = "TRANSPORT";
        public const string DELIVERYTO = "DELIVERYTO";
        public const string BUNDEL = "BUNDEL";

        public const string PARTY_NAME = "PARTY_NAME";
        public const string PARTY_STREET_1 = "PARTY_STREET_1";
        public const string PARTY_STREET_2 = "PARTY_STREET_2";
        public const string PARTY_CITY = "PARTY_CITY";
        public const string PARTY_STATE = "PARTY_STATE";
        public const string PARTY_STATE_CODE = "PARTY_STATE_CODE";
        public const string PARTY_COUNTRY = "PARTY_COUNTRY";
        public const string PARTY_PINCODE = "PARTY_PINCODE";
        public const string PARTY_GSTIN = "PARTY_GSTIN";

        public const string TOTAL_QTY = "TOTAL_QTY";
        public const string TAXABLE_VALUE = "TAXABLE_VALUE";

        public const string CGST_PERCENT = "CGST_PERCENT";
        public const string SGST_PERCENT = "SGST_PERCENT";
        public const string IGST_PERCENT = "IGST_PERCENT";

        public const string TOTAL_CGST = "TOTAL_CGST";
        public const string TOTAL_SGST = "TOTAL_SGST";
        public const string TOTAL_IGST = "TOTAL_IGST";
        public const string TOTAL_CESS = "TOTAL_CESS";
        public const string TOTAL_SUB = "TOTAL_SUB";

        public const string LEDGER = "LEDGER";
        public const string ADDITIONAL = "ADDITIONAL";
        public const string ROUNDS = "ROUNDS";

        public const string GSTTOTAL = "GSTTOTAL";
        public const string GRANDTOTAL = "GRANDTOTAL";

        public const string AMOUNT_IN_WORDS = "AMOUNT_IN_WORDS";
        public const string NOTES = "NOTES";
        public const string ENTRY_BY = "ENTRY_BY";

        public const string FORSIGN = "FORSIGN";

        public const string ACCOUNT_NO = "ACCOUNT_NO";
        public const string IFSC_CODE = "IFSC_CODE";
        public const string BANK_NAME = "BANK_NAME";
        public const string BANK_BRANCH = "BRANCH";

        public const string TERMS_1 = "TERMS_1";
        public const string TERMS_2 = "TERMS_2";
        public const string TERMS_3 = "TERMS_3";
        public const string TERMS_4 = "TERMS_4";
    }


}
