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

        public static void Refered(List<Garment_receiptitems> item, DAL dal)
        {

            if (item.Count != 0)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].Receipt_by != "Advance")
                    {
                        decimal invoiceAmount = item[i].Garment_invoiced_amount;
                        decimal receiptAmount = GetReceiptAmount(item[i].Garment_invoiced_no, dal);

                        if (receiptAmount == invoiceAmount)
                        {
                            InvoiceLocked((receiptAmount - invoiceAmount), item[i].Garment_invoiced_no, dal);
                        }
                        else if (receiptAmount > invoiceAmount)
                        {
                            InvoiceExcess((receiptAmount - invoiceAmount), item[i].Garment_invoiced_no, dal);
                        }
                        else if (receiptAmount < invoiceAmount)
                        {
                            InvoicePartial((receiptAmount - invoiceAmount), item[i].Garment_invoiced_no, dal);
                        }
                        else if (receiptAmount == 0)
                        {
                            InvoiceUnlocked((receiptAmount - invoiceAmount), item[i].Garment_invoiced_no, dal);
                        }
                    }
                }
            }
        }

        private static decimal GetReceiptAmount(string invoiced_no, DAL dal)
        {
            string q = "SELECT SUM(" + GARMENT_RECEIPTITEMS.GARMENT_RECEIPT_AMOUNT + ") FROM " + GARMENT_RECEIPTITEMS.GARMENT_RECEIPTITEMS_TBL + " WHERE " + GARMENT_RECEIPTITEMS.GARMENT_INVOICED_NO + " =" + invoiced_no + " ; ";

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
            string q = "UPDATE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " SET \r\n ";
            q += " " + GARMENT_INVOICE.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoicePartial(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " SET \r\n ";
            q += " " + GARMENT_INVOICE.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += "  WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoiceExcess(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " SET \r\n ";
            q += " " + GARMENT_INVOICE.LOCKED + " = '" + Core.Excess + "' \r\n ";
            q += "  WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoiceLocked(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + GARMENT_INVOICE.GARMENT_INVOICE_TBL + " SET \r\n ";
            q += " " + GARMENT_INVOICE.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += "  WHERE " + GARMENT_INVOICE.GARMENT_INVOICE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + GARMENT_INVOICE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

    }//cls
}//ns
