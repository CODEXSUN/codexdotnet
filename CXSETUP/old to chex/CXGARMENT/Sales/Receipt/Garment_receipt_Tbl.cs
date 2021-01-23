// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:24 AM

using CXSETUP; 
using CXLIB; 

namespace CXGARMENT
{
    public class Garment_Receipt_Tbl
    {
        #region[Create Table]

        public Garment_Receipt_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL);
            q += Fields.Primary(GARMENT_RECEIPT.GARMENT_RECEIPT_ID);
            q += Fields.Unique_500(GARMENT_RECEIPT.UNIQUENO);
            q += Fields.Foreign(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL, GARMENT_RECEIPT.COMPANY_ID);
            q += Fields.Foreign(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL, GARMENT_RECEIPT.ACY_ID);
            q += Fields.Int(GARMENT_RECEIPT.GARMENT_RECEIPT_NO); 
            q += Fields.Date(GARMENT_RECEIPT.GARMENT_RECEIPT_DATE); 
            q += Fields.Foreign(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL, GARMENT_RECEIPT.PARTY_ID); 
            q += Fields.Foreign(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL, GARMENT_RECEIPT.RECEIPTTYPE_ID); 
            q += Fields.VARCHAR_200(GARMENT_RECEIPT.CHEQ_NO); 
            q += Fields.Decimal_2(GARMENT_RECEIPT.GARMENT_RECEIPT_AMOUNT); 
            q += Fields.VARCHAR_200(GARMENT_RECEIPT.CHEQ_DATE); 
            q += Fields.Foreign(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL, GARMENT_RECEIPT.BANK_ID); 
            q += Fields.Decimal_2(GARMENT_RECEIPT.TOTAL_AMOUNT); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(GARMENT_RECEIPT.GARMENT_RECEIPT_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            Garment_receiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Garment_receiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL);
            q += Fields.Primary(GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_ID);
            q += Fields.Foreign(GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL, GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_ID); 
            q += Fields.VARCHAR_200(GARMENT_RECEIPTITEMS.RECEIPT_BY); 
            q += Fields.VARCHAR_200(GARMENT_RECEIPTITEMS.GARMENT_INVOICED_NO); 
            q += Fields.Decimal_2(GARMENT_RECEIPTITEMS.GARMENT_INVOICED_AMOUNT); 
            q += Fields.Decimal_2(GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_AMOUNT); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
