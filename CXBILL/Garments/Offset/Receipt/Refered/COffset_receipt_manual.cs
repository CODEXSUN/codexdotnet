using System.Data;
using CXCORE;
using CXLIB;

namespace CXBILL
{
    class CReceipt_manual
    {
        public static DataTable GetReceiptby(DAL dal)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY, typeof(string));
            tbl.Rows.Add("INVOICE");
            return tbl;
        }

        public static DataTable ReceiptLookup(string vParty)
        {
            string q = " SELECT " + OFFSET_INVOICE.OFFSET_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + OFFSET_INVOICE.OFFSET_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + OFFSET_INVOICE.OFFSET_INVOICE_TBL + "." + OFFSET_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + OFFSET_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
            q += " AND  " + PARTY.PARTY_NAME + " = '" + vParty + "' \r\n";
            q += " AND NOT  " + OFFSET_INVOICE.LOCKED + " = '" + Core.Locked + "' \r\n";
            q += " ORDER BY " + OFFSET_INVOICE.OFFSET_INVOICE_NO + " \r\n";
            DataTable invoicelist = new DAL().Listdata(q);


            DataTable newxlist = new DataTable();

            newxlist.Columns.Add(OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_BY, typeof(string));
            newxlist.Columns.Add(OFFSET_RECEIPTITEMS.OFFSET_INVOICED_NO, typeof(string));
            newxlist.Columns.Add(OFFSET_RECEIPTITEMS.OFFSET_INVOICED_AMOUNT, typeof(string));
            newxlist.Columns.Add(OFFSET_RECEIPTITEMS.OFFSET_RECEIPT_AMOUNT, typeof(string));

            newxlist.Rows.Add(Core.Advance, "   No   ", "     Amount    ", "   Balance   ");

            if (invoicelist.Rows.Count != 0)
            {

                for (int i = 0; i < invoicelist.Rows.Count; i++)
                {
                    newxlist.Rows.Add(
                        Core.Invoice,
                        (invoicelist.Rows[i][OFFSET_INVOICE.OFFSET_INVOICE_NO] + ""),
                        (invoicelist.Rows[i][OFFSET_INVOICE.GRANDTOTAL] + ""),
                        (invoicelist.Rows[i][OFFSET_INVOICE.REFERED_AMT] + "")
                        );
                }
            }
            return newxlist;
        }
    }
}
