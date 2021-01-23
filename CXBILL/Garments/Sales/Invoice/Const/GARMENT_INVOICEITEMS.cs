// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 21-06-2019 10:08:17 AM

namespace CXBILL
{
    #region[Properties]

    public class Garment_invoiceitems
    {
        public string Garment_invoiceitems_id { get; set; }
        public string Garment_invoice_id { get; set; }
        public string Garment_invoice_no { get; set; }
        public string Product_id { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Sgst_percent { get; set; }
        public decimal Cgst_percent { get; set; }
        public decimal Igst_percent { get; set; }
        public string Refered_id { get; set; }
        public string Locked { get; set; }
    }

    #endregion[Properties]

    #region[string Const class]

    public class GARMENT_INVOICEITEMS
    {
        public const string GARMENT_INVOICEITEMS_ID = "GARMENT_INVOICEITEMS_ID";
        public const string GARMENT_INVOICE_ID = "GARMENT_INVOICE_ID";
        public const string GARMENT_INVOICE_NO = "GARMENT_INVOICE_NO";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string QTY = "QTY";
        public const string PRICE = "PRICE";
        public const string SGST_PERCENT = "SGST_PERCENT";
        public const string CGST_PERCENT = "CGST_PERCENT";
        public const string IGST_PERCENT = "IGST_PERCENT";
        public const string REFERED_ID = "REFERED_ID";
        public const string LOCKED = "LOCKED";

        public const string GARMENT_INVOICEITEMS_TBL = "GARMENT_INVOICEITEMS_TBL";

        public const string TAXABLEAMOUNT = "TAXABLEAMOUNT";
        public const string SGST_AMOUNT = "SGST_AMOUNT";
        public const string CGST_AMOUNT = "CGST_AMOUNT";
        public const string IGST_AMOUNT = "IGST_AMOUNT";
    }

    #endregion[string Const class]

}//ns
