using System.Collections.Generic;

namespace CXBILL
{
    public class GarmentXtn
    {

        #region[Get id - No] 

        public static string FindInvoiceGstTotal(string No)
        {
            List<Garment_invoice> list = CGarment_invoice_exten.Searchby(No, "", "", "");

            if (list.Count != 0)
            {
                return list[0].Gsttotal.ToString();
            }
            return "";
        }

        #endregion[Get id - No] 
    }
}
