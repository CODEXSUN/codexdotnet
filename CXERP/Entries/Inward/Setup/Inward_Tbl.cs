// Version : 5.0.0.0 Date : 27-01-2021
// Auto Generated
// last update : 28-01-2021 10:33:45 PM

using CXLIB; 

namespace CXERP
{
    public class Inward_Tbl
    {
        #region[Create Table]

        public Inward_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(INWARD.INWARD_TBL);
            q += AddFields.Primary(INWARD.INWARD_ID);
            q += AddFields.Unique_500(INWARD.UNIQUENO);
            q += AddFields.Foreign(INWARD.INWARD_TBL, INWARD.COMPANY_ID);
            q += AddFields.Foreign(INWARD.INWARD_TBL, INWARD.ACY_ID);
            q += AddFields.Foreign(INWARD.INWARD_TBL, INWARD.ORDER_ID); 
            q += AddFields.Int(INWARD.INWARD_NO); 
            q += AddFields.Date(INWARD.INWARD_DATE); 
            q += AddFields.VARCHAR_200(INWARD.PARTY_DCNO); 
            q += AddFields.Int(INWARD.PARTY_ID); 
            q += AddFields.VARCHAR_200(INWARD.REFERED_QTY); 
            q += AddFields.Smallint(INWARD.LOCKED); 
            q += AddFields.Notes;
            q += AddFields.Active;
            q += AddFields.User_id(INWARD.INWARD_TBL);
            q += AddFields.EOF;

            new DAL().Execute(q);

            InwardItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public static void InwardItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(INWARDITEMS.INWARDITEMS_TBL);
            q += AddFields.Primary(INWARDITEMS.INWARDITEMS_ID);
            q += AddFields.Foreign(INWARDITEMS.INWARDITEMS_TBL, INWARDITEMS.INWARD_ID); 
            q += AddFields.Foreign(INWARDITEMS.INWARDITEMS_TBL, INWARDITEMS.PRODUCT_ID); 
            q += AddFields.Foreign(INWARDITEMS.INWARDITEMS_TBL, INWARDITEMS.COLOURS_ID); 
            q += AddFields.Foreign(INWARDITEMS.INWARDITEMS_TBL, INWARDITEMS.SIZES_ID); 
            q += AddFields.VARCHAR_200(INWARDITEMS.BUNDLE); 
            q += AddFields.Smallint(INWARDITEMS.LOCKED); 
            q += AddFields.EOF;

            new DAL().Execute(q);

        }
        #endregion[Table Items]

    }//cls
}//ns
