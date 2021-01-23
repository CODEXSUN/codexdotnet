// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:14 PM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class Receipt_Tbl
    {
        #region[Create Table]

        public Receipt_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(RECEIPT.RECEIPT_TBL);
            q += AddFields.Primary(RECEIPT.RECEIPT_ID);
            q += AddFields.Unique_500(RECEIPT.UNIQUENO);
            q += AddFields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.COMPANY_ID);
            q += AddFields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.ACY_ID);
            q += AddFields.Int(RECEIPT.RECEIPT_NO); 
            q += AddFields.Date(RECEIPT.RECEIPT_DATE); 
            q += AddFields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.PARTY_ID); 
            q += AddFields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.RECEIPTTYPE_ID); 
            q += AddFields.VARCHAR_200(RECEIPT.CHEQ_NO); 
            q += AddFields.Decimal_2(RECEIPT.RECEIPT_AMOUNT); 
            q += AddFields.VARCHAR_200(RECEIPT.CHEQ_DATE); 
            q += AddFields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.BANK_ID); 
            q += AddFields.Decimal_2(RECEIPT.TOTAL_AMOUNT); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(RECEIPT.RECEIPT_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

            ReceiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void ReceiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(RECEIPTITEMS.RECEIPTITEMS_TBL);
            q += AddFields.Primary(RECEIPTITEMS.RECEIPTITEMS_ID);
            q += AddFields.Foreign(RECEIPTITEMS.RECEIPTITEMS_TBL, RECEIPTITEMS.RECEIPT_ID); 
            q += AddFields.VARCHAR_200(RECEIPTITEMS.RECEIPT_BY); 
            q += AddFields.VARCHAR_200(RECEIPTITEMS.INVOICED_NO); 
            q += AddFields.VARCHAR_200(RECEIPTITEMS.INVOICED_AMOUNT); 
            q += AddFields.Decimal_2(RECEIPTITEMS.RECEIPT_AMOUNT); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
