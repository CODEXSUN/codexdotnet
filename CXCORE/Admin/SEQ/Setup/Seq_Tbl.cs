// Version : 4.0.0.1 dt : 12-07-2020
// Auto Generated
// last update : 14-07-2020 07:57:12 AM

using CXLIB; 

namespace CXCORE
{
    public class Seq_Tbl
    {
        #region[Create Table]

        public Seq_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(SEQ.SEQ_TBL);
            q += AddFields.Primary(SEQ.SEQ_ID);
            q += AddFields.Int(SEQ.SEQ_NO); 
            q += AddFields.Int(SEQ.COMP_CODE);
            q += AddFields.Int(SEQ.ORDER_NO);
            q += AddFields.Int(SEQ.DC_NO); 
            q += AddFields.Int(SEQ.PO_NO); 
            q += AddFields.Int(SEQ.INV_NO); 
            q += AddFields.Int(SEQ.RECEIPT_NO); 
            q += AddFields.Int(SEQ.QUOTATION_NO); 
            q += AddFields.Int(SEQ.QRECEIPT_NO); 
            q += AddFields.Int(SEQ.PURCHASE_NO); 
            q += AddFields.Int(SEQ.PAYMENT_NO); 
            q += AddFields.Int(SEQ.CASHBOOK_NO); 
            q += AddFields.Int(SEQ.BANKBOOK_NO); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

        #region[Default Values]

        public static void InsertDefault_Seq(string db)
        {
            string q = USE.DB(db);

            q += DB.INSERT(SEQ.SEQ_TBL);
            q += DB.FIELD_1ST(SEQ.SEQ_ID);
            q += DB.FIELD(SEQ.SEQ_NO);
            q += DB.FIELD(SEQ.COMP_CODE);
            q += DB.FIELD(SEQ.ORDER_NO);
            q += DB.FIELD(SEQ.DC_NO);
            q += DB.FIELD(SEQ.PO_NO);
            q += DB.FIELD(SEQ.INV_NO);
            q += DB.FIELD(SEQ.RECEIPT_NO);
            q += DB.FIELD(SEQ.QUOTATION_NO);
            q += DB.FIELD(SEQ.QRECEIPT_NO);
            q += DB.FIELD(SEQ.PURCHASE_NO);
            q += DB.FIELD(SEQ.PAYMENT_NO);
            q += DB.FIELD(SEQ.CASHBOOK_NO);
            q += DB.FIELD(SEQ.BANKBOOK_NO);
            q += DB.MID;
            q += DB.VALUE_1ST("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.VALUE("1");
            q += DB.EOF;

            new DAL().Execute(q);

        }

        #endregion[Default Values]

    }//cls
}//ns
