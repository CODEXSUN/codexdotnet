// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 10:01:14 PM

using CXSETUP; 
using CXLIB; 

namespace CXBILL
{
    public class QReceipt_Tbl
    {
        #region[Create Table]

        public QReceipt_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(QRECEIPT.QRECEIPT_TBL);
            q += AddFields.Primary(QRECEIPT.QRECEIPT_ID);
            q += AddFields.Unique_500(QRECEIPT.UNIQUENO);
            q += AddFields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.COMPANY_ID);
            q += AddFields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.ACY_ID);
            q += AddFields.Int(QRECEIPT.QRECEIPT_NO); 
            q += AddFields.Date(QRECEIPT.QRECEIPT_DATE); 
            q += AddFields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.PARTY_ID); 
            q += AddFields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.RECEIPTTYPE_ID); 
            q += AddFields.VARCHAR_200(QRECEIPT.CHEQ_NO); 
            q += AddFields.Decimal_2(QRECEIPT.QRECEIPT_AMOUNT); 
            q += AddFields.VARCHAR_200(QRECEIPT.CHEQ_DATE); 
            q += AddFields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.BANK_ID); 
            q += AddFields.Decimal_2(QRECEIPT.TOTAL_AMOUNT); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(QRECEIPT.QRECEIPT_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

            QReceiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void QReceiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(QRECEIPTITEMS.QRECEIPTITEMS_TBL);
            q += AddFields.Primary(QRECEIPTITEMS.QRECEIPTITEMS_ID);
            q += AddFields.Foreign(QRECEIPTITEMS.QRECEIPTITEMS_TBL, QRECEIPTITEMS.QRECEIPT_ID); 
            q += AddFields.VARCHAR_200(QRECEIPTITEMS.QRECEIPT_BY); 
            q += AddFields.VARCHAR_200(QRECEIPTITEMS.QUOTATION_NO); 
            q += AddFields.VARCHAR_200(QRECEIPTITEMS.QUOTATION_AMOUNT); 
            q += AddFields.Decimal_2(QRECEIPTITEMS.QRECEIPT_AMOUNT); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
