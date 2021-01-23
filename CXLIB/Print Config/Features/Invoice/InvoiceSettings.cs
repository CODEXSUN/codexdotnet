using System.Configuration;

namespace CXLIB
{
        public class InvoiceSettings : ConfigurationSection
        {
            [ConfigurationProperty("InvoiceSettings")]
            public InvoiceFeatures InvoiceFeatures
            {
                get
                {
                    return (InvoiceFeatures)this["InvoiceSettings"];
                }
                set
                {
                    value = (InvoiceFeatures)this["InvoiceSettings"];
                }
            }
        }
    }
