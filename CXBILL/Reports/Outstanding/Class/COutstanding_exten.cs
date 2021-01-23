// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 07-12-2018 05:57:08 PM

using System.Data;
using CXLIB;
using System.Collections.Generic;
using CXCORE;

namespace CXBILL
{
    public class COutstanding_exten
    {

        public static List<Outstanding> GetOutstanding(string v)
        {


            string q = "SELECT P. " + PARTY.PARTY_ID + " \r\n";
            q += " , " + PARTY.PARTY_NAME + " \r\n";
            q += " , " + PARTY.OPENING_BALANCE + " \r\n";
            q += " , (SELECT SUM(" + INVOICE.GRANDTOTAL + ") FROM " + INVOICE.INVOICE_TBL + " WHERE " + PARTY.PARTY_ID + " = P." + PARTY.PARTY_ID + " AND " + INVOICE.COMPANY_ID + " = " + Current.Company_id + ") AS INVOICE_AMOUNT \r\n";
            q += " , (SELECT SUM(" + RECEIPT.RECEIPT_AMOUNT + ") FROM " + RECEIPT.RECEIPT_TBL + " WHERE " + PARTY.PARTY_ID + " = P." + PARTY.PARTY_ID + "  AND " + INVOICE.COMPANY_ID + " = " + Current.Company_id + " ) AS RECEIPT_AMOUNT \r\n";
            q += " , " + PARTY.CREDIT_DAYS + " \r\n";
            q += " , (SELECT SUM(" + QUOTATION.GRANDTOTAL + ") FROM " + QUOTATION.QUOTATION_TBL + " WHERE " + PARTY.PARTY_ID + " = P." + PARTY.PARTY_ID + "  AND " + INVOICE.COMPANY_ID + " = " + Current.Company_id + " ) AS QUOTATION_AMOUNT \r\n";
            q += " , (SELECT SUM(" + QRECEIPT.QRECEIPT_AMOUNT + ") FROM " + QRECEIPT.QRECEIPT_TBL + " WHERE " + PARTY.PARTY_ID + " = P." + PARTY.PARTY_ID + "  AND " + INVOICE.COMPANY_ID + " = " + Current.Company_id + " ) AS QRECEIPT_AMOUNT \r\n";
            q += " FROM " + PARTY.PARTY_TBL + " P \r\n";

            if (v.Trim().Length != 0)
            {
                q += " WHERE " + PARTY.PARTY_NAME + " = '" + v + "' \r\n";
            }

            q += " ORDER BY " + PARTY.PARTY_NAME + "; \r\n";

            List<Outstanding> list = new List<Outstanding>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Outstanding obj = new Outstanding()
                    {
                        Party_id = redr[PARTY.PARTY_NAME].ToString(),
                        Opening_balance = redr[OUTSTANDING.OPENING_BALANCE].ToString(),
                        Invoice_amount = redr[OUTSTANDING.INVOICE_AMOUNT].ToString(),
                        Receipt_amount = redr[OUTSTANDING.RECEIPT_AMOUNT].ToString(),
                        Qop = redr[OUTSTANDING.QOP].ToString(),
                        Quotation_amount = redr[OUTSTANDING.QUOTATION_AMOUNT].ToString(),
                        Qreceipt_amount = redr[OUTSTANDING.QRECEIPT_AMOUNT].ToString(),
                    };

                    list.Add(obj);
                }

                redr.Close();
            }
            return list;


        }


    }//cls
}//ns
