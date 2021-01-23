using System;

namespace CXBILL
{
    public class SALESREGISTER
    {
        public const string SDATE = "SDATE";
        public const string PARTYNAME = "PARTYNAME";
        public const string VNO = "VNO";
        public const string STYPE = "STYPE";
        public const string SALES_AMOUNT = "SALES_AMOUNT";
        public const string GST_AMOUNT = "GST_AMOUNT";
    }

    public class Salesregister
    {
        public string Sdate { get; set; }
        public string Partyname { get; set; }
        public string Vno { get; set; }
        public string Stype { get; set; }
        public decimal Sales_amount { get; set; }
        public decimal Gst_amount { get; set; }
    }
}
