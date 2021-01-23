
using CXLIB;
using CXBILL;


namespace CXSETUP
{
    public class QreceiptTbl
    {
        #region[Create Table]

        public QreceiptTbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(QRECEIPT.QRECEIPT_TBL);
            q += Fields.Primary(QRECEIPT.QRECEIPT_ID);
            q += Fields.Unique_500(QRECEIPT.UNIQUENO);
            q += Fields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.COMPANY_ID);
            q += Fields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.DIV_ID);
            q += Fields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.ACY_ID);
            q += Fields.Int(QRECEIPT.QRECEIPT_NO);
            q += Fields.Date(QRECEIPT.QRECEIPT_DATE);
            q += Fields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.PARTY_ID);
            q += Fields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.RECEIPTTYPE_ID);
            q += Fields.VARCHAR_200(QRECEIPT.CHEQ_NO);
            q += Fields.Decimal_2(QRECEIPT.QRECEIPT_AMOUNT);
            q += Fields.VARCHAR_100(QRECEIPT.CHEQ_DATE);
            q += Fields.Foreign(QRECEIPT.QRECEIPT_TBL, QRECEIPT.BANK_ID);
            q += Fields.Decimal_2(QRECEIPT.TOTAL_AMOUNT);
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(QRECEIPT.QRECEIPT_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

            QreceiptitemsTbl(db);

        }
        #endregion[Create Table]

        #region[Create Items Table]

        public void QreceiptitemsTbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(QRECEIPTITEMS.QRECEIPTITEMS_TBL);
            q += Fields.Primary(QRECEIPTITEMS.QRECEIPTITEMS_ID);
            q += Fields.Foreign(QRECEIPTITEMS.QRECEIPTITEMS_TBL, QRECEIPTITEMS.QRECEIPT_ID);
            q += Fields.VARCHAR_200(QRECEIPTITEMS.QRECEIPT_BY);
            q += Fields.Int(QRECEIPTITEMS.QUOTATION_NO);
            q += Fields.Decimal_2(QRECEIPTITEMS.QUOTATION_AMOUNT);
            q += Fields.Decimal_2(QRECEIPTITEMS.QRECEIPT_AMOUNT);
            q += Fields.EOF;

            new DAL().Execute(q);
        }
        #endregion[Create Items Table]

    }//cls
}//ns
