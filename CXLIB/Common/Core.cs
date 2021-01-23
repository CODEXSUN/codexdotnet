using System;

namespace CXLIB
{
    public class Core
    {
        static string _stative = Idle;

        static string _tagive = Idle;

        
        public static string Stative
        {
            get { return _stative; }
            set { _stative = value; }
        }



        public const string ACTIVE_TXT = "Active";
        public const string NOTACTIVE_TXT = "Not active";
        public const string IDLE_TXT = "Idle";

        public static string Active { get { return "1"; } }
        public static string NotActive { get { return "0"; } }
        public static string Idle { get { return "2"; } }
        public static string ETag { get { return ""; } }

        public static string Emptystring { get { return ""; } }
        public static string One { get { return "1"; } }


        public static string Without_Po { get { return "Without Po"; } }
        public static string _Without_po_ { get { return "Without Po..."; } }
        public static string Without_Dc { get { return "Without Dc"; } }
        public static string Without_Inv { get { return "Without Inv"; } }



        static string _TaxType = Idle;
        public static string TaxType
        {
            get { return _TaxType; }
            set { _TaxType = value; }
        }


        public const string SGST = "SGST";
        public const string IGST = "IGST";

        public const string B2B = "B2B";
        public const string B2C = "B2C";
        public const string TAX_INVOICE = "TAX INVOICE";
        public const string LABOUR_BILL = "LABOUR BILL";
        public const string DEBIT_NOTE = "DEBIT NOTE";
        public const string QUOTATION = "QUOTATION";


        public const string Excess = "3";

        public const string Partial = "2";

        public const string Locked = "1";

        public const string Unlocked = "0";

        public const string Txt_Partial = "PARTIAL";

        public const string Txt_Locked = "LOCKED";

        public const string Txt_Unlocked = "NOT";
        public const string  ByRoad = "By Road";




        public static string Invoice { get { return "Invoice"; } }
        public static string Quotation { get { return "Quotation"; } }
        public static string purchase { get { return "purchase"; } }

        public static string Labour { get { return "Labour Bill"; } }
        public static string Advance { get { return "Advance"; } }
        public static string Receipt { get { return "Receipt"; } }
        public static string Debitnote { get { return "Debit Note"; } }


        public static string Date_Now { get { return DateTime.Now.ToString("dd-MM-yyyy"); } }



        public const string SLNO = "SLNO";

        public static string EmptyNotes = "EmptyNotes";
        public static string saveprint ="saveprint";

        public static string DUMMY = "";
        
    }
}
