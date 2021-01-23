// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 07-12-2018 05:57:08 PM

using CXBILL; 
using CXLIB; 

namespace CXSETUP
{
    public class Outstanding
    {
        #region[Create Table]

        public Outstanding(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OUTSTANDING.OUTSTANDING_TBL);
            q += Fields.Primary(OUTSTANDING.OUTSTANDING_ID);
            q += Fields.Foreign(OUTSTANDING.OUTSTANDING_TBL, OUTSTANDING.PARTY_ID); 
            q += Fields.Decimal_2(OUTSTANDING.OPENING_BALANCE); 
            q += Fields.Decimal_2(OUTSTANDING.GRANDTOTAL); 
            q += Fields.Decimal_2(OUTSTANDING.RECEIPT_AMOUNT); 
            q += Fields.Decimal_2(OUTSTANDING.QOP); 
            q += Fields.Decimal_2(OUTSTANDING.QGRANDTOTAL); 
            q += Fields.Decimal_2(OUTSTANDING.QRECEIPT_AMOUNT); 
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]


//        USE AMALTEX_DB;
//        CREATE TABLE IF NOT EXISTS OUTSTANDING_TBL(
//        OUTSTANDING_ID INT NOT NULL AUTO_INCREMENT , CONSTRAINT PK_OUTSTANDING_ID PRIMARY KEY(OUTSTANDING_ID)
//        , PARTY_ID INT NOT NULL, CONSTRAINT FK_OUTSTANDING_PARTY_ID FOREIGN KEY(PARTY_ID) REFERENCES PARTY_TBL(PARTY_ID)
//        , OPENING_BALANCE DECIMAL(11,2) NOT NULL
//        , GRANDTOTAL DECIMAL(11,2) NOT NULL
//        , RECEIPT_AMOUNT DECIMAL(11,2) NOT NULL
//        , QOP DECIMAL(11,2) NOT NULL
//        , QGRANDTOTAL DECIMAL(11,2) NOT NULL
//        , QRECEIPT_AMOUNT DECIMAL(11,2) NOT NULL
//);



    }//cls
}//ns
