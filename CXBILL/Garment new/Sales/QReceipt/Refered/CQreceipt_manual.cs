using System.Data;
using CXCORE;
using CXLIB;

namespace CXBILL
{
    class CQreceipt_manual
    {
        public static DataTable GetReceiptby(DAL dal)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(QRECEIPTITEMS.QRECEIPT_BY, typeof(string));
            tbl.Rows.Add("QUOTATION");
            tbl.Rows.Add("LABOUR BILL");
            return tbl;
        }


        public static DataTable ReceiptLookup(string vParty)
        {
            string q = " SELECT " +     QUOTATION.QUOTATION_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + QUOTATION.QUOTATION_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + QUOTATION.QUOTATION_TBL + "." + QUOTATION.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + QUOTATION.COMPANY_ID + " = " + Current.Company_id + " \r\n";
            q += " AND  " + PARTY.PARTY_NAME + " = '" + vParty + "' \r\n";
            q += " AND NOT  " + QUOTATION.LOCKED + " = '" + Core.Locked + "' \r\n";
            q += " ORDER BY " + QUOTATION.QUOTATION_NO + " \r\n";
            DataTable invoicelist = new DAL().Listdata(q);

            //q = " SELECT * FROM  " + Labour.LABOUR_TBL + "  \r\n";
            //q += " WHERE " + Labour.COMPANY_ID + " = " + Current.Company_id + " \r\n";
            //q += " AND  " + Labour.PARTY_ID + " = '" + _partyid + "' \r\n";
            //q += " AND NOT  " + Labour.LABOUR_LOCK + " = '" + core.Locked + "' \r\n";
            //q += " ORDER BY " + Labour.LABOUR_NO + " \r\n";
            //DataTable labourlist = new DAL().Listdata(q);

            DataTable newxlist = new DataTable();

            newxlist.Columns.Add(QRECEIPTITEMS.QRECEIPT_BY, typeof(string));
            newxlist.Columns.Add(QRECEIPTITEMS.QUOTATION_NO, typeof(string));
            newxlist.Columns.Add(QRECEIPTITEMS.QUOTATION_AMOUNT, typeof(string));
            newxlist.Columns.Add(QRECEIPTITEMS.QRECEIPT_AMOUNT, typeof(string));

            newxlist.Rows.Add(Core.Advance, "   No   ", "     Amount    ", "   Balance   ");

            if (invoicelist.Rows.Count != 0)
            {

                for (int i = 0; i < invoicelist.Rows.Count; i++)
                {
                    newxlist.Rows.Add(
                        Core.Quotation,
                        (invoicelist.Rows[i][QUOTATION.QUOTATION_NO] + ""),
                        (invoicelist.Rows[i][QUOTATION.GRANDTOTAL] + ""),
                        (invoicelist.Rows[i][QUOTATION.REFERED_AMT] + "")
                        );
                }
            }
            //if (labourlist.Rows.Count != 0)
            //{
            //    for (int i = 0; i < labourlist.Rows.Count; i++)
            //    {
            //        newxlist.Rows.Add(
            //            core.Labour,
            //            (labourlist.Rows[i][Labour.LABOUR_NO] + ""),
            //            (labourlist.Rows[i][Labour.GRANDTOTAL] + ""),
            //            (labourlist.Rows[i][Labour.RECEIPTED_AMOUNT] + "")
            //            );
            //    }
            //}
            return newxlist;
        }
    }
}
