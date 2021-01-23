using System;

namespace CXLIB
{
    public static class Current
    {

        public static bool IsLogged { get; set; }

        public static string User { get; set; }
        public static string User_name { get; set; }

        public static string Company_id { get; set; }
        public static string Company_Name { get; set; }

        public static string Comp_code { get; set; }

        public static string Acy_id { get; set; }
        public static string Acy_Name { get; set; }
        public static DateTime Acy_From { get; set; }
        public static DateTime Acy_To { get; set; }




        public static string Codexsun { get { return "1"; } }

        public static string Datetime { get { return DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"); } }
        public static string Date { get { return DateTime.Now.ToString("dd-MM-yyyy"); } }
        public static string Time { get { return DateTime.Now.ToString("hh:mm:ss tt"); } }




        public static string Rat_DB = "RAT_DB";
        public static string DB { get; set; } = "SUNDARV22_DB";
        public static string DatabaseVersion { get; set; } = "4.0.0.1";
        public static string SoftwareVersion { get; set; } = "4.0.0.1";

        public static string SoftwareType { get; set; } 
        public static string SoftwareTo { get; set; } 


    }




    public enum Listcompany
    {
        skenterprises,
        rajaannamalaitex,
        rainbowgraphics,
        rainbowincorp,
        sarascreens,
        thirumuruganprinters,
        Kathirprinters,
        beeline,
        Amaltex,
        eshaknitting,
        panchamuga
    }

    public class CompanyDivision
    {
        public const String BeelineExports = "1";
        public const String SriRajeswariTex = "2";
        public const String Rajaannamalai = "3";
        public const String Ariknits = "4";
        public const String Sureshwarammart = "5";
        public const String SriSankaraClothingPvtLtd = "35";
        public const String SaravanaFashions = "6";
        public const String NprFabrics = "7";
        public const String pranaexports = "8";
        public const String Panchamuga = "16";

        public const String SriRagavendraYarns = "13";
        public const String SriSharadhaImpex = "14";

    }

    public enum Companytype
    {
        Basictype,
        InvoiceOnly,
        PODconInvoice
    }

    public enum InvoicePrintFormat
    {

        PlainPaper,
        PlainPaperWithoutLogo,
        PrePrinted,

    }



}
