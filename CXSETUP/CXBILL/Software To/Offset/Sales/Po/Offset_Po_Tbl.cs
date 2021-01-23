// Version : 2.2.0.0 dt : 15-03-2019
// Auto Generated
// last update : 30-03-2019 01:12:14 PM

using CXOFFSET; 
using CXLIB;
using System.Collections.Generic;

namespace CXSETUP
{
    public class Offset_po_Tbl
    {
        #region[Create Table]

        public Offset_po_Tbl (string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_PO.OFFSET_PO_TBL);
            q += Fields.Primary(OFFSET_PO.OFFSET_PO_ID);
            q += Fields.Unique_500(OFFSET_PO.UNIQUENO);
            q += Fields.Foreign(OFFSET_PO.OFFSET_PO_TBL, OFFSET_PO.COMPANY_ID);
            q += Fields.Foreign(OFFSET_PO.OFFSET_PO_TBL, OFFSET_PO.ACY_ID);
            q += Fields.Unique_500(OFFSET_PO.OFFSET_PO_NO); 
            q += Fields.Date(OFFSET_PO.OFFSET_PO_DATE); 
            q += Fields.Foreign(OFFSET_PO.OFFSET_PO_TBL, OFFSET_PO.PARTY_ID); 
            q += Fields.VARCHAR_500(OFFSET_PO.PARTY_PO_REF); 
            q += Fields.Date(OFFSET_PO.DELIVERY_DATE); 
            q += Fields.VARCHAR_500(OFFSET_PO.TOTAL_QTY); 
            q += Fields.Decimal_2(OFFSET_PO.TOTAL_AMOUNT); 
            q += Fields.VARCHAR_200(OFFSET_PO.REFERED_NO); 
            q += Fields.Smallint(OFFSET_PO.LOCKED); 
            q += Fields.Notes;
            q += Fields.Active;
            q += Fields.User_id(OFFSET_PO.OFFSET_PO_TBL);
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

            Offset_poItems_Tbl(db);

        }
        #endregion[Table]

        #region[Table Items]

        public void Offset_poItems_Tbl(string db)
        {
            string q = USE.DB(db);

            q += CREATE.TABLE(OFFSET_POITEMS.OFFSET_POITEMS_TBL);
            q += Fields.Primary(OFFSET_POITEMS.OFFSET_POITEMS_ID);
            q += Fields.Foreign(OFFSET_POITEMS.OFFSET_POITEMS_TBL, OFFSET_POITEMS.OFFSET_PO_ID); 
            q += Fields.Foreign(OFFSET_POITEMS.OFFSET_POITEMS_TBL, OFFSET_POITEMS.PRODUCT_ID); 
            q += Fields.Decimal_3(OFFSET_POITEMS.QTY); 
            q += Fields.Decimal_2(OFFSET_POITEMS.PRICE); 
            q += Fields.Decimal_2(OFFSET_POITEMS.SUB_TOTAL); 
            q += Fields.VARCHAR_200(OFFSET_POITEMS.REFERED_QTY); 
            q += Fields.Smallint(OFFSET_POITEMS.LOCKED); 
            q += Fields.EOF;

            new SYS_DAL().Execute(q);

        }
        #endregion[Table Items]

        #region[Default Values]

        public static void InsertDefault_offset_po(string db)
        {
            string q = USE.DB(db);

            Offset_po obj = new Offset_po()
            {
                Offset_po_id = "1",
                Uniqueno = "admin~1~000",
                Company_id = "1",
                Acy_id = "1",
                Offset_po_no = "0",
                Offset_po_date = "31-03-2019",
                Party_id="1",
                Party_po_ref="party_po_ref",
                Delivery_date="31-03-2019",
                Total_qty="0",
                Total_amount="0",
                Locked="1",
                Refered_no="0",
                Notes = "",
                Active_id = Core.Active,
                User_id = "1"
            };

            COffset_po.Insert(obj, new DAL());

            InsertDefault_poitems(db);

        }

        public static void InsertDefault_poitems(string db)
        {
            string q = USE.DB(db);

            List<Offset_poitems> list = new List<Offset_poitems>();

            Offset_poitems obj = new Offset_poitems()
            {
                Offset_poitems_id = "1",
                Offset_po_id = "1",
                Product_id = "1",
                Qty = "0",
                Price = "0",
                Sub_total = "0",
                Refered_qty = "0",
                Locked = "1",
            };

            list.Add(obj);

            COffset_poitems.Insert(list, new DAL());
        }

        #endregion[Default Values]

    }//cls
}//ns
