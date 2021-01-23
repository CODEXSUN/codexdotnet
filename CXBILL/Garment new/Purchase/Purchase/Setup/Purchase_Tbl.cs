// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 07:49:58 PM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class Purchase_Tbl
    {
        #region[Create Table]

        public Purchase_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PURCHASE.PURCHASE_TBL);
            q += AddFields.Primary(PURCHASE.PURCHASE_ID);
            q += AddFields.Unique_500(PURCHASE.UNIQUENO);
            q += AddFields.Foreign(PURCHASE.PURCHASE_TBL, PURCHASE.COMPANY_ID);
            q += AddFields.Foreign(PURCHASE.PURCHASE_TBL, PURCHASE.ACY_ID);
            q += AddFields.Foreign(PURCHASE.PURCHASE_TBL, PURCHASE.ORDER_ID); 
            q += AddFields.Foreign(PURCHASE.PURCHASE_TBL, PURCHASE.TAXTYPE_ID); 
            q += AddFields.Foreign(PURCHASE.PURCHASE_TBL, PURCHASE.SALESTYPE_ID); 
            q += AddFields.Int(PURCHASE.ENTRY_NO); 
            q += AddFields.VARCHAR_500(PURCHASE.PURCHASE_NO); 
            q += AddFields.Date(PURCHASE.PURCHASE_DATE); 
            q += AddFields.Foreign(PURCHASE.PURCHASE_TBL, PURCHASE.PARTY_ID); 
            q += AddFields.Decimal_3(PURCHASE.TOTAL_QTY); 
            q += AddFields.Decimal_2(PURCHASE.TOTAL_TAXABLE_AMOUNT); 
            q += AddFields.Decimal_3(PURCHASE.TOTAL_CGST); 
            q += AddFields.Decimal_3(PURCHASE.TOTAL_SGST); 
            q += AddFields.Decimal_3(PURCHASE.TOTAL_IGST); 
            q += AddFields.Decimal_3(PURCHASE.GSTTOTAL); 
            q += AddFields.VARCHAR_500(PURCHASE.LEDGER_ID); 
            q += AddFields.Decimal_2(PURCHASE.ADDITIONAL); 
            q += AddFields.Decimal_2(PURCHASE.ROUNDS); 
            q += AddFields.Decimal_2(PURCHASE.GRANDTOTAL); 
            q += AddFields.Decimal_2(PURCHASE.REFERED_AMT); 
            q += AddFields.Smallint(PURCHASE.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(PURCHASE.PURCHASE_TBL);
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

            PurchaseItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void PurchaseItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(PURCHASEITEMS.PURCHASEITEMS_TBL);
            q += AddFields.Primary(PURCHASEITEMS.PURCHASEITEMS_ID);
            q += AddFields.Foreign(PURCHASEITEMS.PURCHASEITEMS_TBL, PURCHASEITEMS.PURCHASE_ID); 
            q += AddFields.VARCHAR_200(PURCHASEITEMS.PURCHASE_NO); 
            q += AddFields.Foreign(PURCHASEITEMS.PURCHASEITEMS_TBL, PURCHASEITEMS.PRODUCT_ID); 
            q += AddFields.Decimal_3(PURCHASEITEMS.QTY); 
            q += AddFields.Decimal_2(PURCHASEITEMS.PRICE); 
            q += AddFields.Decimal_2(PURCHASEITEMS.CGST_PERCENT); 
            q += AddFields.Decimal_2(PURCHASEITEMS.SGST_PERCENT); 
            q += AddFields.Decimal_2(PURCHASEITEMS.IGST_PERCENT); 
            q += AddFields.VARCHAR_200(PURCHASEITEMS.REFERED_ID); 
            q += AddFields.Smallint(PURCHASEITEMS.LOCKED); 
            q += AddFields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
