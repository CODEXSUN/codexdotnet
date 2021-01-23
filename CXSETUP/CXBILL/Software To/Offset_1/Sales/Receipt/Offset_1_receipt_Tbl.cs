// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 29-03-2019 01:02:53 PM

using CXBILL;
using CXLIB;
using CXOFFSET_1;

namespace CXSETUP
{
    public class Offset_1_receipt_Tbl
    {
        #region[Create Table]

        public Offset_1_receipt_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL);
            q += Fields.Primary(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_ID);
            q += Fields.Unique_500(OFFSET_1_RECEIPT.UNIQUENO);
            q += Fields.Foreign(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL, OFFSET_1_RECEIPT.COMPANY_ID);
            q += Fields.Foreign(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL, OFFSET_1_RECEIPT.ACY_ID);
            q += Fields.Int(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_NO);
            q += Fields.Date(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_DATE);
            q += Fields.Foreign(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL, OFFSET_1_RECEIPT.PARTY_ID);
            q += Fields.Foreign(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL, OFFSET_1_RECEIPT.RECEIPTTYPE_ID);
            q += Fields.VARCHAR_200(OFFSET_1_RECEIPT.CHEQ_NO);
            q += Fields.Decimal_2(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_AMOUNT);
            q += Fields.VARCHAR_200(OFFSET_1_RECEIPT.CHEQ_DATE);
            q += Fields.Foreign(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL, OFFSET_1_RECEIPT.BANK_ID);
            q += Fields.Decimal_2(OFFSET_1_RECEIPT.TOTAL_AMOUNT);
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OFFSET_1_RECEIPT.OFFSET_1_RECEIPT_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            ReceiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void ReceiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL);
            q += Fields.Primary(OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_ID);
            q += Fields.Foreign(OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPTITEMS_TBL, OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_ID);
            q += Fields.VARCHAR_200(OFFSET_1_RECEIPTITEMS.RECEIPT_BY);
            q += Fields.VARCHAR_200(OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_NO);
            q += Fields.Decimal_2(OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_AMOUNT);
            q += Fields.Decimal_2(OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_AMOUNT);
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
