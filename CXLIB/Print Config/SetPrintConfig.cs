// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 28-03-2019 11:17:05 PM

using System.CodeDom.Compiler;

namespace CXLIB
{
    public class SetPrintConfig
    {
        public SetPrintConfig()
        {
            DefaultSetting();

            switch (Current.Comp_code)
            {
                case Client.RAJA_ANNAMALAI_TEX:
                    RajannamalaiTex();
                    break;
                case Client.ARI_KNITS:
                    Ariknits();
                    break;
                case Client.SURESHWARAM_MART:
                    Sureshwarammart();
                    break;
                case Client.VAANARAYA_INTERNATIONAL:
                    VaanarayaInternatinal();
                    break;

                case Client.MARK_INTERNATIONAL:
                    MarkInternatinal();
                    break;

                case Client.PRAPTHI_IMPEX:
                    Prapthiimpex();
                    break;

                case Client.COLOURS_PRINTING:
                    ColoursPrinting();
                    break;
                case Client.JJ_PRINTERS:
                    JjPrinters();
                    break;
                case Client.SARA_SCREENS:
                    SaraScreens();
                    break;

                case Client.SK_ENTERPRISES:
                    skenterprises();
                    break;
                case Client.SK_PRINTERS:
                    Skprinters();
                    break;
                case Client.SRI_GANAPATHI_PRINTING_PRESS:
                    sriganapathi();
                    break;
                case Client.SRI_MURUGAN_PRINTING:
                    srimurugan();
                    break;

                case Client.Amaltex:
                    amaltex();
                    break;


                case Client.AGTORIA_GLOBAL:
                    AgtoriaGlobal();
                    break;

                case Client.MPL_GARMENT:
                    MplGarments();
                    break;


                case Client.CALLISTO_GARMENTS:
                    CallistoGarments();
                    break;

            }
        }



        void DefaultSetting()
        {
            PrintConfig.PrintLogo = false;
            PrintConfig.Logo = "";
            PrintConfig.LogoText = "";
            PrintConfig.SubReportHeight = 4.95;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.TitleTxtFont = XFont.Arial;
            PrintConfig.CopyTxtFont = XFont.Arial;
            PrintConfig.HeaderHeight = 0.95;
            PrintConfig.PrintHeader = false;
            PrintConfig.HeaderTxtFont = XFont.Arial;
            PrintConfig.HeaderAddressTxtFont = XFont.Arial;
            PrintConfig.PartyTxtFont = XFont.Tahoma;
            PrintConfig.BodyTxtFont = XFont.Tahoma;
            PrintConfig.FORTxtFont = XFont.TimesNewRoman;
            PrintConfig.PrintJuridication = true;
            PrintConfig.JuridicationTxt = "Tirupur";

            PrintConfig.With_PO_Dc = false;
            PrintConfig.With_sizes = false;

            PrintConfig.LogoLeft = 1.2;
            PrintConfig.LogoTop = 0.5;
            PrintConfig.Logo_width = 0.9;
            PrintConfig.Logo_height = 0.9;
            PrintConfig.Company_name_FontSize = 30;


            PrintConfig.Account_no = "";
            PrintConfig.IFSC = "";
            PrintConfig.BankName = "";
            PrintConfig.BankBranch = "";

            PrintConfig.Terms_4 = "";

            PrintConfig.Company_address_FontSize = 8;



        }


        void RajannamalaiTex()
        {
            PrintConfig.HeaderHeight = 1.65;
            PrintConfig.SubReportHeight = 4.1;


            PrintConfig.Account_no =  "A/C NO          : 1238261000297";
            PrintConfig.IFSC = "IFSC CODE    : CNRB0001238";
            PrintConfig.BankName = "BANK NAME  : CANARA BANK";
            PrintConfig.BankBranch = "BRANCH        : ONDIPUDUR BRANCH - COIMBATORE";


            PrintConfig.Terms_4 = "Raja Annamalai Tex - Vendor Code : 222911";
        }
        void Ariknits()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "ari.png";
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.TimesNewRoman;
        }

        void Sureshwarammart()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "sureshwaram.png";
            PrintConfig.HeaderHeight = 1.1;
            PrintConfig.SubReportHeight = 4.8;
            PrintConfig.Title1 = false;
            PrintConfig.Title2 = true;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Arial;
            PrintConfig.Company_name_FontSize = 28;
            PrintConfig.Company_address_FontSize = 9;

            PrintConfig.LogoLeft = 1;
            PrintConfig.LogoTop = 0.4;
            PrintConfig.Logo_width = 0.9;
            PrintConfig.Logo_height = 0.9;


            //PrintConfig.Account_no = "Account No   : 920020008371822";
            //PrintConfig.IFSC = "IFSC Code     : UTIB0003164";
            //PrintConfig.BankName = "Bank Name   : AXIS BANK";
            //PrintConfig.BankBranch = "Bank Branch : ANUPPARPALAYAM BRANCH";
        }

        void VaanarayaInternatinal()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "vaanaraya.jpg";
            PrintConfig.HeaderHeight = 1.1;
            PrintConfig.SubReportHeight = 4.8;
            PrintConfig.Title1 = false;
            PrintConfig.Title2 = true;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Garamond;
            PrintConfig.Company_name_FontSize = 28;
            PrintConfig.Company_address_FontSize = 9;

            PrintConfig.LogoLeft = 0.5;
            PrintConfig.LogoTop = 0.4;
            PrintConfig.Logo_width = 0.8;
            PrintConfig.Logo_height = 0.8;

            
            PrintConfig.Account_no = "Account No   : 920020008371822";
            PrintConfig.IFSC =       "IFSC Code     : UTIB0003164";
            PrintConfig.BankName =   "Bank Name   : AXIS BANK";
            PrintConfig.BankBranch = "Bank Branch : ANUPPARPALAYAM BRANCH";

        }




        void MarkInternatinal()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "mark.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 5;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Arial;
        }

        void Prapthiimpex()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "prapthi.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 5;
            PrintConfig.Title1 = false;
            PrintConfig.Title2 = true;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.TimesNewRoman;
        }

        void ColoursPrinting()
        {
            PrintConfig.PrintLogo = false;
            PrintConfig.HeaderHeight = 1.8;
            PrintConfig.SubReportHeight = 4.7;
            PrintConfig.Title1 = false;
            PrintConfig.Title2 = true;
        }

        void JjPrinters()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "jjprinters.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 4.2;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.TimesNewRoman;
            PrintConfig.With_PO_Dc = true;


            //PrintConfig.Account_no = "Account No   : 510909010138768";
            //PrintConfig.IFSC = "IFSC Code     : CIUB0000523";
            //PrintConfig.BankName = "Bank Name   : CITY UNION BANK";
            //PrintConfig.BankBranch = "Bank Branch : NALLUR BRANCH";
        }


        void SaraScreens()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "sara.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 4.7;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.CooperBlack;
            PrintConfig.With_PO_Dc = true;

            PrintConfig.Account_no = "Account No   : 615405044450";
            PrintConfig.IFSC = "IFSC Code     : ICIC0006154";
            PrintConfig.BankName = "Bank Name   : ICICI BANK";
            PrintConfig.BankBranch = "Bank Branch : TIRUPUR BRANCH";

        }


        void Skprinters()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "skprinters.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 4.7;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Arial;
            PrintConfig.With_PO_Dc = true;

            PrintConfig.Account_no = "Account No   : 2344201000991";
            PrintConfig.IFSC = "IFSC Code     : CNRB0002344";
            PrintConfig.BankName = "Bank Name   : CANARA BANK";
            PrintConfig.BankBranch = "Bank Branch : OVERSEAS BRANCH, 60 FEET ROAD";


        }

        void srimurugan()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "skprinters.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 5;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Arial;
        }
        void sriganapathi()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "vinay.jpg";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 5;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.TimesNewRoman;

        }
        void skenterprises()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "skprinters.png";
            PrintConfig.HeaderHeight = 1.2;
            PrintConfig.SubReportHeight = 5;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Arial;
        }


        void amaltex()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "amal.png";
            PrintConfig.LogoText = "";
            PrintConfig.HeaderHeight = 1;
            PrintConfig.SubReportHeight = 4.3;
            PrintConfig.Title1 = true;
            PrintConfig.Title2 = false;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.BlackChancery;
            PrintConfig.With_sizes = true;


            PrintConfig.Account_no = "Account No   : 253805500216";
            PrintConfig.IFSC = "IFSC Code     : ICIC0002538";
            PrintConfig.BankName = "Bank Name   : ICICI BANK";
            PrintConfig.BankBranch = "Bank Branch : P.N.ROAD BRANCH - TIRUPUR";
        }



        void AgtoriaGlobal()
        {
            PrintConfig.PrintLogo = true;
            PrintConfig.Logo = "agtoria.png";
            PrintConfig.HeaderHeight = 1.1;
            PrintConfig.SubReportHeight = 4.8;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Calibri;
            PrintConfig.Company_name_FontSize = 28;
            PrintConfig.Company_address_FontSize = 9;

            PrintConfig.LogoLeft = 1.2;
            PrintConfig.LogoTop = 0.36;
            PrintConfig.Logo_width = 1;
            PrintConfig.Logo_height = 1;

            PrintConfig.Account_no = "Account No   : 615405064843";
            PrintConfig.IFSC = "IFSC Code     : ICIC0006154";
            PrintConfig.BankName = "Bank Name   : ICICI BANK";
            PrintConfig.BankBranch = "Bank Branch : TIRUPUR BRANCH";

        }

        void MplGarments()
        {
            PrintConfig.PrintLogo = false;
            PrintConfig.Logo = "agtoria.png";
            PrintConfig.HeaderHeight = 1.1;
            PrintConfig.SubReportHeight = 4.8;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.CooperBlack;
            PrintConfig.Company_name_FontSize = 28;
            PrintConfig.Company_address_FontSize = 9;

            //PrintConfig.LogoLeft = 1.2;
            //PrintConfig.LogoTop = 0.36;
            //PrintConfig.Logo_width = 1;
            //PrintConfig.Logo_height = 1;

            //PrintConfig.Account_no = "Account No   : 615405064843";
            //PrintConfig.IFSC = "IFSC Code     : ICIC0006154";
            //PrintConfig.BankName = "Bank Name   : ICICI BANK";
            //PrintConfig.BankBranch = "Bank Branch : TIRUPUR BRANCH";

        }

        void CallistoGarments()
        {
            PrintConfig.PrintLogo = false;
            PrintConfig.Logo = "agtoria.png";
            PrintConfig.HeaderHeight = 1.1;
            PrintConfig.SubReportHeight = 4.8;
            PrintConfig.PrintHeader = true;
            PrintConfig.HeaderTxtFont = XFont.Arial;
            PrintConfig.Company_name_FontSize = 30;
            PrintConfig.Company_address_FontSize = 9;

            //PrintConfig.LogoLeft = 1.2;
            //PrintConfig.LogoTop = 0.36;
            //PrintConfig.Logo_width = 1;
            //PrintConfig.Logo_height = 1;

            //PrintConfig.Account_no = "Account No   : 615405064843";
            //PrintConfig.IFSC = "IFSC Code     : ICIC0006154";
            //PrintConfig.BankName = "Bank Name   : ICICI BANK";
            //PrintConfig.BankBranch = "Bank Branch : TIRUPUR BRANCH";

        }

    }
}