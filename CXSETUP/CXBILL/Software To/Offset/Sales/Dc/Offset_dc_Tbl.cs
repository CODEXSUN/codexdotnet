// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 08:34:44 AM

using CXOFFSET; 
using CXLIB;
using System.Collections.Generic;

namespace CXSETUP
{
    public class Offset_dc_Tbl
    {
        #region[Create Table]

        public Offset_dc_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_DC.OFFSET_DC_TBL);
            q += Fields.Primary(OFFSET_DC.OFFSET_DC_ID);
            q += Fields.Unique_500(OFFSET_DC.UNIQUENO);
            q += Fields.Foreign(OFFSET_DC.OFFSET_DC_TBL, OFFSET_DC.COMPANY_ID);
            q += Fields.Foreign(OFFSET_DC.OFFSET_DC_TBL, OFFSET_DC.ACY_ID);
            q += Fields.Int(OFFSET_DC.OFFSET_DC_NO); 
            q += Fields.Date(OFFSET_DC.OFFSET_DC_DATE); 
            q += Fields.Foreign(OFFSET_DC.OFFSET_DC_TBL, OFFSET_DC.PARTY_ID); 
            q += Fields.VARCHAR_200(OFFSET_DC.TOTAL_QTY); 
            q += Fields.VARCHAR_200(OFFSET_DC.REFERED_NO); 
            q += Fields.Smallint(OFFSET_DC.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OFFSET_DC.OFFSET_DC_TBL);
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

            Offset_dcItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Offset_dcItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_DCITEMS.OFFSET_DCITEMS_TBL);
            q += Fields.Primary(OFFSET_DCITEMS.OFFSET_DCITEMS_ID);
            q += Fields.Foreign(OFFSET_DCITEMS.OFFSET_DCITEMS_TBL, OFFSET_DCITEMS.OFFSET_DC_ID); 
            q += Fields.Int(OFFSET_DCITEMS.OFFSET_DC_NO); 
            q += Fields.Foreign(OFFSET_DCITEMS.OFFSET_DCITEMS_TBL, OFFSET_DCITEMS.OFFSET_PO_ID); 
            q += Fields.Int(OFFSET_DCITEMS.OFFSET_POITEMS_ID); 
            q += Fields.Foreign(OFFSET_DCITEMS.OFFSET_DCITEMS_TBL, OFFSET_DCITEMS.PRODUCT_ID); 
            q += Fields.VARCHAR_200(OFFSET_DCITEMS.QTY); 
            q += Fields.VARCHAR_200(OFFSET_DCITEMS.REFERED_QTY); 
            q += Fields.Smallint(OFFSET_DCITEMS.LOCKED); 
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

        #region[Default Values]

        public static void InsertDefault_offset_dc(string db)
        {
            string q = USE.DB(db);

            Offset_dc obj = new Offset_dc()
            {
                Offset_dc_id = "1",
                Unqiueno = "admin~1~000",
                Company_id = "1",
                Acy_id = "1",
                Offset_dc_no = "1",
                Offset_dc_date = "31-03-2019",
                Party_id = "1",
                Total_qty = "0",
                Refered_no = "0",
                Locked = "1",
                Notes = "Notes",
                Active_id = Core.Active,
                User_id = "1"
            };

            COffset_dc.Insert(obj, new DAL());

            InsertDefault_offset_dcitems(db);
        }

        public static void InsertDefault_offset_dcitems(string db)
        {
            string q = USE.DB(db);

            List<Offset_dcitems> list = new List<Offset_dcitems>();

            Offset_dcitems obj = new Offset_dcitems()
            {
                Offset_dcitems_id = "1",
                Offset_dc_id = "1",
                Offset_dc_no = "0",
                Offset_po_id = "1",
                Offset_poitems_id = "1",
                Product_id = "1",
                Qty = "0",
                Refered_qty = "0",
                Locked = "1",
            };

            list.Add(obj);

            COffset_dcitems.Insert(list, new DAL());
        }

        #endregion[Default Values]

    }//cls
}//ns
