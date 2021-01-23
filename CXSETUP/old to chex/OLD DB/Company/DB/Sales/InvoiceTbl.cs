// Version : 2.0.0.0 dt : 16-10-2018
// Auto Generated
// last update : 16-10-2018 11:04:26 PM

using CXBILL; 
using CXLIB; 
 
namespace CXSETUP 
{ 
    public class Invoice_Tbl 
    { 

        #region[]

        public Invoice_Tbl(string database)
        {
            if (Check.Table("INVOICE_TBL", database) == false)
            {
                Insert(database);
            }
            else
            {
                Update(database);
            }
        }

        #endregion[]

        #region[Insert]

        public void Insert(string database) 
        { 
            string q = USE.DB(database); 

            q += CREATE.TABLE(INVOICE.INVOICE_TBL); 
            q += Fields.Primary(INVOICE.INVOICE_ID); 
            q += Fields.Unique(INVOICE.UNIQUENO); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.COMPANY_ID); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.DIV_ID); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.ACY_ID); 
            q += Fields.Int(INVOICE.INVOICE_NO); 
            q += Fields.Date(INVOICE.INVOICE_DATE); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.TAXTYPE_ID); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.SALESTYPE_ID); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.PARTY_ID); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.TRANSPORT_ID); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.DELIVERYAT_ID); 
            q += Fields.VAR100(INVOICE.BUNDLE); 
            q += Fields.Decimal(INVOICE.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal(INVOICE.TOTAL_CGST); 
            q += Fields.Decimal(INVOICE.TOTAL_SGST); 
            q += Fields.Decimal(INVOICE.TOTAL_IGST); 
            q += Fields.Decimal(INVOICE.GSTTOTAL); 
            q += Fields.Foreign(INVOICE.INVOICE_TBL, INVOICE.LEDGER_ID); 
            q += Fields.Decimal(INVOICE.ADDITIONAL); 
            q += Fields.Decimal(INVOICE.ROUNDS); 
            q += Fields.Decimal(INVOICE.GRANDTOTAL); 
            q += Fields.Decimal(INVOICE.REFERED_AMT); 
            q += Fields.Notes(); 
            q += Fields.Active(); 
            q += Fields.User_id(INVOICE.INVOICE_TBL); 
            new DAL().Execute(q); 
        } 
        #endregion[Insert]

        #region[Update]

        public void Update(string database) 
        { 
            string q = USE.DB(database);
            q += "";

            new DAL().Execute(q); 
        } 

        #endregion[Update]

    }//cls
}//ns
