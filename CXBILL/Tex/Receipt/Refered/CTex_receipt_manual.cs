using System.Data;
using CXCORE;
using CXLIB;

namespace CXBILL
{
    class CTex_receipt_manual
    {
        public static DataTable GetReceiptby(DAL dal)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(TEX_RECEIPTITEMS.RECEIPT_BY, typeof(string));
            tbl.Rows.Add("INVOICE");
            return tbl;
        }

        public static DataTable ReceiptLookup(string vParty)
        {
            string q = " SELECT " + TEX_INVOICE.TEX_INVOICE_TBL + ".* \r\n";
            q += ", " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " \r\n";
            q += " FROM  " + TEX_INVOICE.TEX_INVOICE_TBL + " \r\n";
            q += " INNER JOIN  " + PARTY.PARTY_TBL + "\r\n";
            q += " ON(" + TEX_INVOICE.TEX_INVOICE_TBL + "." + TEX_INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + " )\r\n";
            q += " WHERE " + TEX_INVOICE.COMPANY_ID + " = " + Current.Company_id + " \r\n";
            q += " AND  " + PARTY.PARTY_NAME + " = '" + vParty + "' \r\n";
            q += " AND NOT  " + TEX_INVOICE.LOCKED + " = '" + Core.Locked + "' \r\n";
            q += " ORDER BY " + TEX_INVOICE.INVOICE_NO + " \r\n";
            DataTable invoicelist = new DAL().Listdata(q);


            DataTable newxlist = new DataTable();

            newxlist.Columns.Add(TEX_RECEIPTITEMS.RECEIPT_BY, typeof(string));
            newxlist.Columns.Add(TEX_RECEIPTITEMS.TEX_INVOICED_NO, typeof(string));
            newxlist.Columns.Add(TEX_RECEIPTITEMS.TEX_INVOICED_AMOUNT, typeof(string));
            newxlist.Columns.Add(TEX_RECEIPTITEMS.TEX_RECEIPT_AMOUNT, typeof(string));

            newxlist.Rows.Add(Core.Advance, "   No   ", "     Amount    ", "   Balance   ");

            if (invoicelist.Rows.Count != 0)
            {

                for (int i = 0; i < invoicelist.Rows.Count; i++)
                {
                    newxlist.Rows.Add(
                        Core.Invoice,
                        (invoicelist.Rows[i][TEX_INVOICE.INVOICE_NO] + ""),
                        (invoicelist.Rows[i][TEX_INVOICE.GRANDTOTAL] + ""),
                        (invoicelist.Rows[i][TEX_INVOICE.REFERED_AMT] + "")
                        );
                }
            }
            return newxlist;
        }
    }
}
