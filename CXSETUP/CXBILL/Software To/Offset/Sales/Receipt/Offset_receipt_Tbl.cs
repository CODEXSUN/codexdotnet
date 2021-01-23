// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:24 AM

using CXOFFSET; 
using CXLIB; 

namespace CXSETUP
{
    public class Offset_receipt_Tbl
    {
        #region[Create Table]

        public Offset_receipt_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL);
            q += Fields.Primary(OFFSET_RECEIPT.OFFSET_RECEIPT_ID);
            q += Fields.Unique_500(OFFSET_RECEIPT.UNIQUENO);
            q += Fields.Foreign(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL, OFFSET_RECEIPT.COMPANY_ID);
            q += Fields.Foreign(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL, OFFSET_RECEIPT.ACY_ID);
            q += Fields.Int(OFFSET_RECEIPT.OFFSET_RECEIPT_NO); 
            q += Fields.Date(OFFSET_RECEIPT.OFFSET_RECEIPT_DATE); 
            q += Fields.Foreign(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL, OFFSET_RECEIPT.PARTY_ID); 
            q += Fields.Foreign(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL, OFFSET_RECEIPT.RECEIPTTYPE_ID); 
            q += Fields.VARCHAR_200(OFFSET_RECEIPT.CHEQ_NO); 
            q += Fields.Decimal_2(OFFSET_RECEIPT.OFFSET_RECEIPT_AMOUNT); 
            q += Fields.VARCHAR_200(OFFSET_RECEIPT.CHEQ_DATE); 
            q += Fields.Foreign(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL, OFFSET_RECEIPT.BANK_ID); 
            q += Fields.Decimal_2(OFFSET_RECEIPT.TOTAL_AMOUNT); 
            //q += Fields.VARCHAR_200(OFFSET_RECEIPT.REFERED_NO); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OFFSET_RECEIPT.OFFSET_RECEIPT_TBL);
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

            Offset_receiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Offset_receiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL);
            q += Fields.Primary(OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_ID);
            q += Fields.Foreign(OFFSET_RECEIPTITEMS.OFFSET_RECEIPTITEMS_TBL, OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_ID); 
            q += Fields.VARCHAR_200(OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY); 
            q += Fields.VARCHAR_200(OFFSET_RECEIPTITEMS.OFFSET_INVOICED_NO); 
            q += Fields.Decimal_2(OFFSET_RECEIPTITEMS.OFFSET_INVOICED_AMOUNT); 
            q += Fields.Decimal_2(OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_AMOUNT); 
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
