// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:35:20 AM

using CXOFFSET; 
using CXLIB; 

namespace CXSETUP
{
    public class Offset_labour_Tbl
    {
        #region[Create Table]

        public Offset_labour_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE( OFFSET_LABOUR.OFFSET_LABOUR_TBL);
            q += Fields.Primary(OFFSET_LABOUR.OFFSET_LABOUR_ID);
            q += Fields.Unique_500(OFFSET_LABOUR.UNIQUENO);
            q += Fields.Foreign(OFFSET_LABOUR.OFFSET_LABOUR_TBL, OFFSET_LABOUR.COMPANY_ID);
            q += Fields.Foreign(OFFSET_LABOUR.OFFSET_LABOUR_TBL, OFFSET_LABOUR.ACY_ID);
            q += Fields.Foreign(OFFSET_LABOUR.OFFSET_LABOUR_TBL, OFFSET_LABOUR.TAXTYPE_ID); 
            q += Fields.Foreign(OFFSET_LABOUR.OFFSET_LABOUR_TBL, OFFSET_LABOUR.SALESTYPE_ID); 
            q += Fields.Int(OFFSET_LABOUR.OFFSET_LABOUR_NO); 
            q += Fields.Date(OFFSET_LABOUR.OFFSET_LABOUR_DATE); 
            q += Fields.Foreign(OFFSET_LABOUR.OFFSET_LABOUR_TBL, OFFSET_LABOUR.PARTY_ID); 
            q += Fields.VARCHAR_200(OFFSET_LABOUR.TOTAL_QTY); 
            q += Fields.Decimal_2(OFFSET_LABOUR.TOTAL_TAXABLE_AMOUNT); 
            q += Fields.Decimal_2(OFFSET_LABOUR.TOTAL_CGST); 
            q += Fields.Decimal_2(OFFSET_LABOUR.TOTAL_SGST); 
            q += Fields.Decimal_2(OFFSET_LABOUR.TOTAL_IGST); 
            q += Fields.Decimal_2(OFFSET_LABOUR.GSTTOTAL); 
            q += Fields.VARCHAR_500(OFFSET_LABOUR.LEDGER_ID); 
            q += Fields.Decimal_2(OFFSET_LABOUR.ADDITIONAL); 
            q += Fields.Decimal_2(OFFSET_LABOUR.ROUNDS); 
            q += Fields.Decimal_2(OFFSET_LABOUR.GRANDTOTAL); 
            q += Fields.VARCHAR_200(OFFSET_LABOUR.REFERED_AMT); 
            q += Fields.Smallint(OFFSET_LABOUR.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OFFSET_LABOUR.OFFSET_LABOUR_TBL);
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

            Offset_labourItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Offset_labourItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL);
            q += Fields.Primary(OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_ID);
            q += Fields.Foreign(OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL, OFFSET_LABOURITEMS.OFFSET_LABOUR_ID); 
            q += Fields.Int(OFFSET_LABOURITEMS.OFFSET_LABOUR_NO); 
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.OFFSET_LABOUR_PO_NO); 
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.OFFSET_LABOUR_DC_NO); 
            q += Fields.Foreign(OFFSET_LABOURITEMS.OFFSET_LABOURITEMS_TBL, OFFSET_LABOURITEMS.PRODUCT_ID);
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.QTY);
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.PRICE);
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.SGST_PERCENT);
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.CGST_PERCENT);
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.IGST_PERCENT);
            q += Fields.VARCHAR_200(OFFSET_LABOURITEMS.REFERED_ID); 
            q += Fields.Smallint(OFFSET_LABOURITEMS.LOCKED); 
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]
        
        #region[Default Values]

        public static void InsertDefault_labour(string db)
        {
            //string q = USE.DB(db);
            //Pincode obj = new Pincode()
            //{
            //    Pincode_id = "",
            //    Pincode_name = "641601",
            //    Notes = "",
            //    Active_id = Core.Active,
            //    User_id = "1"
            //};

            //CPincode.Insert(obj, new DAL());

        }

        public static void InsertDefault_labouritems(string db)
        {
            //string q = USE.DB(db);
            //Pincode obj = new Pincode()
            //{
            //    Pincode_id = "",
            //    Pincode_name = "641601",
            //    Notes = "",
            //    Active_id = Core.Active,
            //    User_id = "1"
            //};

            //CPincode.Insert(obj, new DAL());

        }


        #endregion[Default Values]

    }//cls
}//ns
