// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 20-05-2019 07:49:58 PM

using CXSETUP; 
using CXLIB; 

namespace CXGARMENT
{
    public class Garment_Purchase_Tbl
    {
        #region[Create Table]

        public Garment_Purchase_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL);
            q += Fields.Primary(GARMENT_PURCHASE.GARMENT_PURCHASE_ID);
            q += Fields.Unique_500(GARMENT_PURCHASE.UNIQUENO);
            q += Fields.Foreign(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL, GARMENT_PURCHASE.COMPANY_ID);
            q += Fields.Foreign(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL, GARMENT_PURCHASE.ACY_ID);
            q += Fields.Foreign(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL, GARMENT_PURCHASE.GARMENT_ORDER_ID); 
            q += Fields.Foreign(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL, GARMENT_PURCHASE.TAXTYPE_ID); 
            q += Fields.Foreign(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL, GARMENT_PURCHASE.SALESTYPE_ID); 
            q += Fields.Int(GARMENT_PURCHASE.ENTRY_NO); 
            q += Fields.VARCHAR_500(GARMENT_PURCHASE.GARMENT_PURCHASE_NO); 
            q += Fields.Date(GARMENT_PURCHASE.GARMENT_PURCHASE_DATE); 
            q += Fields.Foreign(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL, GARMENT_PURCHASE.PARTY_ID); 
            q += Fields.Decimal_3(GARMENT_PURCHASE.TOTAL_QTY); 
            q += Fields.Decimal_2(GARMENT_PURCHASE.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal_3(GARMENT_PURCHASE.TOTAL_CGST); 
            q += Fields.Decimal_3(GARMENT_PURCHASE.TOTAL_SGST); 
            q += Fields.Decimal_3(GARMENT_PURCHASE.TOTAL_IGST); 
            q += Fields.Decimal_3(GARMENT_PURCHASE.GSTTOTAL); 
            q += Fields.VARCHAR_500(GARMENT_PURCHASE.LEDGER_ID); 
            q += Fields.Decimal_2(GARMENT_PURCHASE.ADDITIONAL); 
            q += Fields.Decimal_2(GARMENT_PURCHASE.ROUNDS); 
            q += Fields.Decimal_2(GARMENT_PURCHASE.GRANDTOTAL); 
            q += Fields.Decimal_2(GARMENT_PURCHASE.REFERED_AMT); 
            q += Fields.Smallint(GARMENT_PURCHASE.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(GARMENT_PURCHASE.GARMENT_PURCHASE_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            PurchaseItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void PurchaseItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_PURCHASEITEMS.GARMENT_PURCHASEITEMS_TBL);
            q += Fields.Primary(GARMENT_PURCHASEITEMS.GARMENT_PURCHASEITEMS_ID);
            q += Fields.Foreign(GARMENT_PURCHASEITEMS.GARMENT_PURCHASEITEMS_TBL, GARMENT_PURCHASEITEMS.GARMENT_PURCHASE_ID); 
            q += Fields.VARCHAR_200(GARMENT_PURCHASEITEMS.PURCHASE_NO); 
            q += Fields.Foreign(GARMENT_PURCHASEITEMS.GARMENT_PURCHASEITEMS_TBL, GARMENT_PURCHASEITEMS.PRODUCT_ID); 
            q += Fields.Decimal_3(GARMENT_PURCHASEITEMS.QTY); 
            q += Fields.Decimal_2(GARMENT_PURCHASEITEMS.PRICE); 
            q += Fields.Decimal_2(GARMENT_PURCHASEITEMS.CGST_PERCENT); 
            q += Fields.Decimal_2(GARMENT_PURCHASEITEMS.SGST_PERCENT); 
            q += Fields.Decimal_2(GARMENT_PURCHASEITEMS.IGST_PERCENT); 
            q += Fields.VARCHAR_200(GARMENT_PURCHASEITEMS.REFERED_ID); 
            q += Fields.Smallint(GARMENT_PURCHASEITEMS.LOCKED); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
