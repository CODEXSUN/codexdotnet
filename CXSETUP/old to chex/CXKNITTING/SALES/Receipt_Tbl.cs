// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:24 AM

using CXLIB;
using CXSETUP;

namespace CXKNITTING
{
    public class Knitting_receipt_Tbl
    {
        #region[Create Table]

        public Knitting_receipt_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL);
            q += Fields.Primary(KNITTING_RECEIPT.KNITTING_RECEIPT_ID);
            q += Fields.Unique_500(KNITTING_RECEIPT.UNIQUENO);
            q += Fields.Foreign(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL, KNITTING_RECEIPT.COMPANY_ID);
            q += Fields.Foreign(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL, KNITTING_RECEIPT.ACY_ID);
            q += Fields.Int(KNITTING_RECEIPT.KNITTING_RECEIPT_NO); 
            q += Fields.Date(KNITTING_RECEIPT.KNITTING_RECEIPT_DATE); 
            q += Fields.Foreign(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL, KNITTING_RECEIPT.PARTY_ID); 
            q += Fields.Foreign(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL, KNITTING_RECEIPT.RECEIPTTYPE_ID); 
            q += Fields.VARCHAR_200(KNITTING_RECEIPT.CHEQ_NO); 
            q += Fields.Decimal_2(KNITTING_RECEIPT.KNITTING_RECEIPT_AMOUNT); 
            q += Fields.VARCHAR_200(KNITTING_RECEIPT.CHEQ_DATE); 
            q += Fields.Foreign(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL, KNITTING_RECEIPT.BANK_ID); 
            q += Fields.Decimal_2(KNITTING_RECEIPT.TOTAL_AMOUNT); 
            q += Fields.VARCHAR_200(KNITTING_RECEIPT.REFERED_NO); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(KNITTING_RECEIPT.KNITTING_RECEIPT_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            Knitting_receiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Knitting_receiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL);
            q += Fields.Primary(KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_ID);
            q += Fields.Foreign(KNITTING_RECEIPTITEMS.KNITTING_RECEIPTITEMS_TBL, KNITTING_RECEIPTITEMS.KNITTING_RECEIPT_ID); 
            q += Fields.VARCHAR_200(KNITTING_RECEIPTITEMS.RECEIPT_BY); 
            q += Fields.VARCHAR_200(KNITTING_RECEIPTITEMS.KNITTING_INVOICED_NO); 
            q += Fields.Decimal_2(KNITTING_RECEIPTITEMS.KNITTING_INVOICED_AMOUNT); 
            q += Fields.Decimal_2(KNITTING_RECEIPTITEMS.RECEIPT_AMOUNT); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
