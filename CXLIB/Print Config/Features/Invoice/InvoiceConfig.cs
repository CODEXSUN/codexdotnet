using System;
using System.Configuration;

namespace CXLIB
{
    public class InvoiceConfig
    {

        private object Config;


        public InvoiceConfig()
        {
            Config = ConfigurationManager.GetSection("InvoiceSettings") is InvoiceSettings invoicesettings;

            if (Config == null)
            {
                Console.WriteLine("InvoiceSettings are not defined");
            }
        }



        public static void GetConfigurationUsingCustomClass()
        {
            if (!(ConfigurationManager.GetSection("InvoiceSettings") is InvoiceSettings invoicesettings))
            {
                Console.WriteLine("InvoiceSettings Settings are not defined");
            }
            else
            {
                var productNumber = invoicesettings.InvoiceFeatures.Invoice_without_PoDc;
                var productName = invoicesettings.InvoiceFeatures.Invoice_without_PoDc;

            }
        }
    }
}