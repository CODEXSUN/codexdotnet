// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 08-12-2018 12:07:12 PM

using CXBILL; 
using CXLIB; 

namespace CXSETUP
{
    public class Gstfile
    {
        #region[Create Table]

        public Gstfile(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GSTFILE.GSTFILE_TBL);
            q += Fields.Primary(GSTFILE.GSTFILE_ID);
            q += Fields.VAR100(GSTFILE.MONTH); 
            q += Fields.VAR100(GSTFILE.INVOICEDATE); 
            q += Fields.VAR100(GSTFILE.INVOICENO); 
            q += Fields.Foreign(GSTFILE.GSTFILE_TBL, GSTFILE.PARTY_ID); 
            q += Fields.VAR100(GSTFILE.GSTNO); 
            q += Fields.Decimal_2(GSTFILE.TAXABLEVALUE); 
            q += Fields.Decimal_2(GSTFILE.SGST_PERCENT); 
            q += Fields.Decimal_2(GSTFILE.SGST_AMOUNT); 
            q += Fields.Decimal_2(GSTFILE.CGST_PERCENT); 
            q += Fields.Decimal_2(GSTFILE.CGST_AMOUNT); 
            q += Fields.Decimal_2(GSTFILE.IGST_PERCENT); 
            q += Fields.Decimal_2(GSTFILE.IGST_AMOUNT); 
            q += Fields.Decimal_2(GSTFILE.GST_AMOUNT); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(GSTFILE.GSTFILE_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

    }//cls
}//ns
