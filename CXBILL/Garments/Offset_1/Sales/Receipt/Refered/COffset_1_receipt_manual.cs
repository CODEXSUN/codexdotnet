using System.Data;
using CXCORE;
using CXLIB;
using CXOFFSET;

namespace CXBILL
{
    class CReceipt_manual
    {
        public static DataTable GetReceiptby(DAL dal)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(OFFSET_1_RECEIPTITEMS.RECEIPT_BY, typeof(string));
            tbl.Rows.Add("INVOICE");
            return tbl;
        }

        public static DataTable ReceiptLookup(string vParty)
        {
            string q = " SELECT " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_1_INVOICE.OFFSET_1_INVOICE_TBL + "." + OFFSET_1_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_1_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
            q += " AND  " + PARTY.PARTY_NAME + " = '" + vParty + "' \r\n";
            q += " AND NOT  " + OFFSET_1_INVOICE.LOCKED + " = '" + Core.Locked + "' \r\n";
            q += " ORDER BY " + OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO + " \r\n";
            DataTable invoicelist = new DAL().Listdata(q);


            DataTable newxlist = new DataTable();

            newxlist.Columns.Add(OFFSET_1_RECEIPTITEMS.RECEIPT_BY, typeof(string));
            newxlist.Columns.Add(OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_NO, typeof(string));
            newxlist.Columns.Add(OFFSET_1_RECEIPTITEMS.OFFSET_1_INVOICED_AMOUNT, typeof(string));
            newxlist.Columns.Add(OFFSET_1_RECEIPTITEMS.OFFSET_1_RECEIPT_AMOUNT, typeof(string));

            newxlist.Rows.Add(Core.Advance, "   No   ", "     Amount    ", "   Balance   ");

            if (invoicelist.Rows.Count != 0)
            {

                for (int i = 0; i < invoicelist.Rows.Count; i++)
                {
                    newxlist.Rows.Add(
                        Core.Invoice,
                        (invoicelist.Rows[i][OFFSET_1_INVOICE.OFFSET_1_INVOICE_NO] + ""),
                        (invoicelist.Rows[i][OFFSET_1_INVOICE.GRANDTOTAL] + ""),
                        (invoicelist.Rows[i][OFFSET_1_INVOICE.REFERED_AMT] + "")
                        );
                }
            }
            return newxlist;
        }
    }
}
