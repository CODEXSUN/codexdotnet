using System;

namespace CXBILL
{
    public static class REPORTPARTYSTATEMENT
    {
        public const string SNO = "SNO";
        public const string VNO = "VNO";
        public const string SDATE = "SDATE";
        public const string STYPE = "STYPE";
        public const string CHEQUE = "CHEQUE";
        public const string SALES_AMOUNT = "SALES_AMOUNT";
        public const string RECEIPT_AMOUNT = "RECEIPT_AMOUNT";
        public const string BALANCE_AMOUNT = "BALANCE";
        public const string PARTY = "PARTY";
        public const string OPENING_BALANCE = "OPENING_BALANCE";
        public const string STMDATE = "STMDATE";
    }

    public class ReportPartyStatement
    {
        public int Sno { get; set; }
        public string Vno { get; set; }
        public string Sdate { get; set; }
        public DateTime  S2date { get; set; }
        public string Stype { get; set; }
        public string Cheque { get; set; }
        public decimal Sales_amount { get; set; }
        public decimal Receipt_amount { get; set; }
        public decimal Balance_amount { get; set; }
        public string Party { get; set; }
        public decimal Opening { get; set; }
        public string Stmdate { get; set; }

    }
}
