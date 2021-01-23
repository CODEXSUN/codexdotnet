// Version : 1.0.0.4 dt : 14-11-2017
// Auto Generated
// last update : 22-11-2017 11:05:55 AM


namespace CXBILL
{
    #region[Properties]

    public class Tex_invoiceitems
    {
        public string Tex_invoiceitems_id { get; set; }
        public string Tex_invoice_id { get; set; }
        //public string Tex_invoice_no { get; set; }
        //public string Po_id { get; set; }
        //public string Poitems_id { get; set; }
        //public string Dc_id { get; set; }
        //public string Dcitems_id { get; set; }
        public string Product_id { get; set; }
        public string Sizes_id { get; set; }
        public string Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Cgst_percent { get; set; }
        public decimal Sgst_percent { get; set; }
        public decimal Igst_percent { get; set; }
        public string Refered_id { get; set; }
        public string Locked { get; set; }
    }

    #endregion[Properties]

    #region[string Const class]

    public class TEX_INVOICEITEMS
    {
        public const string TEX_INVOICEITEMS_ID  = "TEX_INVOICEITEMS_ID";
        public const string TEX_INVOICE_ID = "TEX_INVOICE_ID";
        //public const string INVOICE_NO = "INVOICE_NO";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string SIZES_ID = "SIZES_ID";
        public const string QTY = "QTY";
        public const string PRICE = "PRICE";
        public const string CGST_PERCENT = "CGST_PERCENT";
        public const string SGST_PERCENT = "SGST_PERCENT";
        public const string IGST_PERCENT = "IGST_PERCENT";
        public const string REFERED_ID = "REFERED_ID";
        public const string LOCKED = "LOCKED";
        // 
        public const string TEX_INVOICEITEMS_TBL = "TEX_INVOICEITEMS_TBL";

        public const string TAXABLEAMOUNT = "TAXABLEAMOUNT";
        public const string SGST_AMOUNT = "SGST_AMOUNT";
        public const string CGST_AMOUNT = "CGST_AMOUNT";
        public const string IGST_AMOUNT = "IGST_AMOUNT";
    }

    #endregion[string Const class]

    }
