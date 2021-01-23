// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:56 PM
// last update : 17-08-2017

using CXLIB;
using System;
using System.Collections.Generic;

namespace CXBILL
{
    public class CReceipt_refered
    {
        /// <summary>
        /// get invoice amount
        /// get total receipt amount
        /// calculate difference
        /// update to invoice refered_amount
        /// lock particulars
        /// </summary>
        /// <param name="item"></param>
        /// <param name="dal"></param>

        public static void Refered(List<Receiptitems> item, DAL dal)
        {

            if (item.Count != 0)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].Receipt_by != "Advance")
                    {
                        decimal invoiceAmount = ConvertTO.Decimal(item[i].Invoiced_amount);
                        decimal receiptAmount = GetReceiptAmount(item[i].Invoiced_no, dal);

                        if (receiptAmount == invoiceAmount)
                        {
                            InvoiceLocked((receiptAmount - invoiceAmount), item[i].Invoiced_no, dal);
                        }
                        else if (receiptAmount > invoiceAmount)
                        {
                            InvoiceExcess((receiptAmount - invoiceAmount), item[i].Invoiced_no, dal);
                        }
                        else if (receiptAmount < invoiceAmount)
                        {
                            InvoicePartial((receiptAmount - invoiceAmount), item[i].Invoiced_no, dal);
                        }
                        else if (receiptAmount == 0)
                        {
                            InvoiceUnlocked((receiptAmount - invoiceAmount), item[i].Invoiced_no, dal);
                        }
                    }
                }
            }
        }

        private static decimal GetReceiptAmount(string invoiced_no, DAL dal)
        {
            string q = "SELECT SUM(" + RECEIPTITEMS.RECEIPT_AMOUNT + ") FROM " + RECEIPTITEMS.RECEIPTITEMS_TBL + " WHERE " + RECEIPTITEMS.INVOICED_NO + " =" + invoiced_no + " ; ";

            object obj = dal.ExecuteScalar(q);

            if (obj != DBNull.Value)
            {
                return Convert.ToDecimal(obj);
            }
            else
            {
                return 0;
            }
        }

        private static void InvoiceUnlocked(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + INVOICE.INVOICE_TBL + " SET \r\n ";
            q += " " + INVOICE.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + INVOICE.INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoicePartial(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + INVOICE.INVOICE_TBL + " SET \r\n ";
            q += " " + INVOICE.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += "  WHERE " + INVOICE.INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoiceExcess(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + INVOICE.INVOICE_TBL + " SET \r\n ";
            q += " " + INVOICE.LOCKED + " = '" + Core.Excess + "' \r\n ";
            q += "  WHERE " + INVOICE.INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoiceLocked(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + INVOICE.INVOICE_TBL + " SET \r\n ";
            q += " " + INVOICE.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += "  WHERE " + INVOICE.INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

    }//cls
}//ns
