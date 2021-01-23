// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 30-01-2019 09:18:06 PM

using CXCORE; 
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
            q += Fields.Decimal_2(OUTSTANDING.OPENING); 
            q += Fields.Decimal_2(OUTSTANDING.SALES); 
            q += Fields.Decimal_2(OUTSTANDING.RECEIPT); 
            q += Fields.Decimal_2(OUTSTANDING.QOP); 
            q += Fields.Decimal_2(OUTSTANDING.QUOTATION); 
            q += Fields.Decimal_2(OUTSTANDING.QRECEIPT); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OUTSTANDING.OUTSTANDING_TBL);
            q += Fields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Create Table]

    }//cls
}//ns
