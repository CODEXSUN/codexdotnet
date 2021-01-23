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
            q += Fields.Primary(RECEIPT.RECEIPT_ID);
            q += Fields.Unique_500(RECEIPT.UNIQUENO);
            q += Fields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.COMPANY_ID);
            q += Fields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.ACY_ID);
            q += Fields.Int(RECEIPT.RECEIPT_NO); 
            q += Fields.Date(RECEIPT.RECEIPT_DATE); 
            q += Fields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.PARTY_ID); 
            q += Fields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.RECEIPTTYPE_ID); 
            q += Fields.VARCHAR_200(RECEIPT.CHEQ_NO); 
            q += Fields.Decimal_2(RECEIPT.RECEIPT_AMOUNT); 
            q += Fields.VARCHAR_200(RECEIPT.CHEQ_DATE); 
            q += Fields.Foreign(RECEIPT.RECEIPT_TBL, RECEIPT.BANK_ID); 
            q += Fields.Decimal_2(RECEIPT.TOTAL_AMOUNT); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(RECEIPT.RECEIPT_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            ReceiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void ReceiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(RECEIPTITEMS.RECEIPTITEMS_TBL);
            q += Fields.Primary(RECEIPTITEMS.RECEIPTITEMS_ID);
            q += Fields.Foreign(RECEIPTITEMS.RECEIPTITEMS_TBL, RECEIPTITEMS.RECEIPT_ID); 
            q += Fields.VARCHAR_200(RECEIPTITEMS.RECEIPT_BY); 
            q += Fields.VARCHAR_200(RECEIPTITEMS.INVOICED_NO); 
            q += Fields.VARCHAR_200(RECEIPTITEMS.INVOICED_AMOUNT); 
            q += Fields.Decimal_2(RECEIPTITEMS.RECEIPT_AMOUNT); 
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
