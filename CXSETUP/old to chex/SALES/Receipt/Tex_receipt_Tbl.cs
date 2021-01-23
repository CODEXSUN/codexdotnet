// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:24 AM

using CXSETUP; 
using CXLIB; 

namespace CXTEX
{
    public class Tex_receipt_Tbl
    {
        #region[Create Table]

        public Tex_receipt_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(TEX_RECEIPT.TEX_RECEIPT_TBL);
            q += Fields.Primary(TEX_RECEIPT.TEX_RECEIPT_ID);
            q += Fields.Unique_500(TEX_RECEIPT.UNIQUENO);
            q += Fields.Foreign(TEX_RECEIPT.TEX_RECEIPT_TBL, TEX_RECEIPT.COMPANY_ID);
            q += Fields.Foreign(TEX_RECEIPT.TEX_RECEIPT_TBL, TEX_RECEIPT.ACY_ID);
            q += Fields.Int(TEX_RECEIPT.TEX_RECEIPT_NO); 
            q += Fields.Date(TEX_RECEIPT.TEX_RECEIPT_DATE); 
            q += Fields.Foreign(TEX_RECEIPT.TEX_RECEIPT_TBL, TEX_RECEIPT.PARTY_ID); 
            q += Fields.Foreign(TEX_RECEIPT.TEX_RECEIPT_TBL, TEX_RECEIPT.RECEIPTTYPE_ID); 
            q += Fields.VARCHAR_200(TEX_RECEIPT.CHEQ_NO); 
            q += Fields.Decimal_2(TEX_RECEIPT.TEX_RECEIPT_AMOUNT); 
            q += Fields.VARCHAR_200(TEX_RECEIPT.CHEQ_DATE); 
            q += Fields.Foreign(TEX_RECEIPT.TEX_RECEIPT_TBL, TEX_RECEIPT.BANK_ID); 
            q += Fields.Decimal_2(TEX_RECEIPT.TOTAL_AMOUNT); 
            q += Fields.VARCHAR_200(TEX_RECEIPT.REFERED_NO); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(TEX_RECEIPT.TEX_RECEIPT_TBL);
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

            Offset_receiptItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Offset_receiptItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(TEX_RECEIPTITEMS.TEX_RECEIPTITEMS_TBL);
            q += Fields.Primary(TEX_RECEIPTITEMS.TEX_RECEIPTITEMS_ID);
            q += Fields.Foreign(TEX_RECEIPTITEMS.TEX_RECEIPTITEMS_TBL, TEX_RECEIPTITEMS.TEX_RECEIPT_ID); 
            q += Fields.VARCHAR_200(TEX_RECEIPTITEMS.RECEIPT_BY); 
            q += Fields.VARCHAR_200(TEX_RECEIPTITEMS.TEX_INVOICED_NO); 
            q += Fields.Decimal_2(TEX_RECEIPTITEMS.TEX_INVOICED_AMOUNT); 
            q += Fields.Decimal_2(TEX_RECEIPTITEMS.TEX_RECEIPT_AMOUNT); 
            q += Fields.EOF;

           new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
