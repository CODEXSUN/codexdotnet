using System;

namespace CXBILL
{
    public class REPORTQUOTATIONSTATEMENT
    {
        public const string SNO = "SNO";
        public const string VNO = "VNO";
        public const string SDATE = "SDATE";
        public const string STYPE = "STYPE";
        public const string CHEQUE = "CHEQUE";
        public const string QUOTATION_AMOUNT = "QUOTATION_AMOUNT";
        public const string QRECEIPT_AMOUNT = "QRECEIPT_AMOUNT";
        public const string BALANCE_AMOUNT = "BALANCE";
        public const string PARTY = "PARTY";
        public const string OPENING_BALANCE = "OPENING_BALANCE";
        public const string STMDATE = "STMDATE";
    }

    public class ReportQuotaionStatement
    {
        public int Sno { get; set; }
        public string Vno { get; set; }
        public string Sdate { get; set; }
        public DateTime  S2date { get; set; }
        public string Stype { get; set; }
        public string Cheque { get; set; }
        public decimal Quotaion_amount { get; set; }
        public decimal Qreceipt_amount { get; set; }
        public decimal Balance_amount { get; set; }
        public string Party { get; set; }
        public decimal Opening { get; set; }
        public string Stmdate { get; set; }

    }
}
