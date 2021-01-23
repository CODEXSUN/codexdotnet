using System.Configuration;

namespace CXLIB
{
    public class InvoiceFeatures : ConfigurationElement
    {

        [ConfigurationProperty("Invoice_without_PoDc", DefaultValue = false, IsRequired = true)]
        public bool Invoice_without_PoDc
        {
            get
            {
                return (bool)this["Invoice_without_PoDc"];
            }
            set
            {
                value = (bool)this["Invoice_without_PoDc"];
            }
        }


        [ConfigurationProperty("Invoice_with_PoDc", DefaultValue = false, IsRequired = true)]
        public bool ProductNumber
        {
            get
            {
                return (bool)this["Invoice_with_PoDc"];
            }
            set
            {
                value = (bool)this["Invoice_with_PoDc"];
            }
        }

    }
}
