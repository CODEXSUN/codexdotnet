// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 07:49:58 PM

namespace CXBILL
{
    #region[Properties]

    public class Purchaseitems
    {
        public string Purchaseitems_id { get; set; }
        public string Purchase_id { get; set; }
        public string Purchase_no { get; set; }
        public string Product_id { get; set; }
        public string Sizes_id { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Cgst_percent { get; set; }
        public decimal Sgst_percent { get; set; }
        public decimal Igst_percent { get; set; }
        public string Refered_id { get; set; }
        public string Locked { get; set; }
    }

    #endregion[Properties]

    #region[string Const class]

    public static class PURCHASEITEMS
    {
        public const string PURCHASEITEMS_ID = "PURCHASEITEMS_ID";
        public const string PURCHASE_ID = "PURCHASE_ID";
        public const string PURCHASE_NO = "PURCHASE_NO";
        public const string PRODUCT_ID = "PRODUCT_ID";
        public const string SIZES_ID = "SIZES_ID";
        public const string QTY = "QTY";
        public const string PRICE = "PRICE";
        public const string CGST_PERCENT = "CGST_PERCENT";
        public const string SGST_PERCENT = "SGST_PERCENT";
        public const string IGST_PERCENT = "IGST_PERCENT";
        public const string REFERED_ID = "REFERED_ID";
        public const string LOCKED = "LOCKED";

        public const string PURCHASEITEMS_TBL = "PURCHASEITEMS_TBL";

        public const string TAXABLEAMOUNT = "TAXABLEAMOUNT";
        public const string SGST_AMOUNT = "SGST_AMOUNT";
        public const string CGST_AMOUNT = "CGST_AMOUNT";
        public const string IGST_AMOUNT = "IGST_AMOUNT";
    }

    #endregion[string Const class]

}//ns
