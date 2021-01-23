using System;

namespace CXLIB
{

    public class Customise
    {

        public static bool InvoiceWithPo { get; set; }
        public static bool InvoiceWithDc { get; set; }
        public static bool InvoiceWithSizes { get; set; }


    }


    public class GetCustomised
    {
        public GetCustomised()
        {
            DefaultSetting();

            switch (Current.Comp_code)
            {
                //case Client.RAJA_ANNAMALAI_TEX:
                //    RajannamalaiTex();
                //    break;
                //case Client.ARI_KNITS:
                //    Ariknits();
                //    break;
                //case Client.SURESHWARAM_MART:
                //    Sureshwarammart();
                //    break;
                //case Client.VAANARAYA_INTERNATIONAL:
                //    VaanarayaInternatinal();
                //    break;

                //case Client.MARK_INTERNATIONAL:
                //    MarkInternatinal();
                //    break;

                //case Client.PRAPTHI_IMPEX:
                //    Prapthiimpex();
                //    break;

                //case Client.COLOURS_PRINTING:
                //    ColoursPrinting();
                //    break;
                case Client.JJ_PRINTERS:
                    Jjprinters();
                    break;
                case Client.SARA_SCREENS:
                    SaraScreens();
                    break;

                //case Client.SK_ENTERPRISES:
                //    skenterprises();
                //    break;
                case Client.SK_PRINTERS:
                    Skprinters();
                    break;
                //case Client.SRI_GANAPATHI_PRINTING_PRESS:
                //    sriganapathi();
                //    break;
                //case Client.SRI_MURUGAN_PRINTING:
                //    srimurugan();
                //    break;

                //case Client.Amaltex:
                //    amaltex();
                //    break;


                //case Client.AGTORIA_GLOBAL:
                //    AgtoriaGlobal();
                //    break;

                //case Client.MPL_GARMENT:
                //    MplGarments();
                //    break;


                //case Client.CALLISTO_GARMENTS:
                //    CallistoGarments();
                //    break;


               // default:
                   // throw new NotImplementedException("Client is not valid. or not implemented.");
            }
        }


        private void DefaultSetting()
        {
            Customise.InvoiceWithPo = false;
            Customise.InvoiceWithDc = false;
            Customise.InvoiceWithSizes = false;

        }

        private void Skprinters()
        {
            Customise.InvoiceWithPo = true;
            Customise.InvoiceWithDc = true;
            Customise.InvoiceWithSizes = false;
        }

        private void Jjprinters()
        {
            Customise.InvoiceWithPo = true;
            Customise.InvoiceWithDc = true;
            Customise.InvoiceWithSizes = false;
        }


        private void SaraScreens()
        {
            Customise.InvoiceWithPo = true;
            Customise.InvoiceWithDc = true;
            Customise.InvoiceWithSizes = false;
        }
    }
}