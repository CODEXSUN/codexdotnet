// Version : 4 dt : 04-10-2017
// Auto Generated
// 04-10-2017 10:07:29 PM
// last update : 04-10-2017

using System;
using System.Data;
using CXLIB;
using CXCORE;
using System.Collections.Generic;

namespace CXBILL
{
    public class COffset_dc_Lookup
    {
         #region[GetforLookup]

        public static DataTable LookupDC_Party_forInvoice(string partyid)
        {
            string q = "  SELECT * \r\n";
            q += " FROM " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + " \r\n";
            q += " INNER JOIN  DC_TBL ON (" + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " =" + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.OFFSET_DC_ID + ") \r\n";
            q += " WHERE " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.COMPANY_ID + " = " + Current.Company_id + "  \r\n";
            q += " AND  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.PARTY_ID + " = " + partyid + "  \r\n";
            q += " AND  " + OFFSET_DC.OFFSET_DC_TBL + "." + OFFSET_DC.ACTIVE_ID + " = " + Core.Active + " \r\n";
            q += " AND  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_PO_ID + " = " + Core.One + " \r\n";
            q += " AND NOT " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.LOCKED + "  =  " + Core.Locked + "  \r\n";
            q += " ORDER BY  " + OFFSET_DCITEMS.OFFSET_DCITEMS_TBL + "." + OFFSET_DCITEMS.OFFSET_DC_ID + " ASC;  \r\n";

            DataTable xPO = new DAL().Listdata(q);
            //
            DataTable xList = new DataTable();
            //
            xList.Columns.Add(OFFSET_DC.OFFSET_DC_NO, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.OFFSET_DCITEMS_ID, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.PRODUCT_ID, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.QTY, typeof(string));
            xList.Columns.Add(OFFSET_DCITEMS.REFERED_QTY, typeof(string));
            xList.Columns.Add(OFFSET_POITEMS.PRICE, typeof(string));
            xList.Rows.Add(Core.Without_Dc, " DC_item_id", "  Particulars  ", "DC Qty", "  Billed  ", "  Price  ");
            if (xPO.Rows.Count != 0)
            {
                for (int i = 0; i < xPO.Rows.Count; i++)
                {
                    string _poid = string.Empty;

                    //if (xPO.Rows[i][DC_ITEM.PO_ID] + "" == "1")
                    //{
                    //    _poid = "Without Po...";
                    //}
                    //else
                    //{
                    //    _poid = cPo_exten.GetPartypono_poid((xPO.Rows[i][DC_ITEM.PO_ID]) + "");
                    //}

                    xList.Rows.Add(
                        (xPO.Rows[i][OFFSET_DC.OFFSET_DC_NO]),
                        (xPO.Rows[i][OFFSET_DCITEMS.OFFSET_DCITEMS_ID]),
                        CProduct_exten.GetName_Id((xPO.Rows[i][OFFSET_DCITEMS.PRODUCT_ID]) + ""),
                        (xPO.Rows[i][OFFSET_DCITEMS.QTY]),
                        (xPO.Rows[i][OFFSET_DCITEMS.REFERED_QTY]),
                        COffset_Poitems_exten.GetPrice_po((xPO.Rows[i][OFFSET_DCITEMS.OFFSET_PO_ID]) + "", (xPO.Rows[i][OFFSET_DCITEMS.PRODUCT_ID]) + "")
                        );
                }
            }
            //
            return xList;

        }

        #endregion[GetforLookup]
                 
    }//cls
}//ns
