// Version : 3 dt : 01-08-2017
// Auto Generated
// 17-08-2017 02:11:56 PM
// last update : 17-08-2017

using CXLIB;
using System;
using System.Collections.Generic;

namespace CXBILL
{
    public class CPayment_refered
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

        public static void Refered(List<Paymentitems> item, DAL dal)
        {

            if (item.Count != 0)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].Payment_by != "Advance")
                    {
                        decimal purchaseAmount = ConvertTO.Decimal(item[i].Purchase_amount);
                        decimal paymentAmount = GetPurchaseAmount(item[i].Purchase_no, dal);

                        if (paymentAmount == purchaseAmount)
                        {
                            InvoiceLocked((paymentAmount - purchaseAmount), item[i].Purchase_no, dal);
                        }
                        else if (paymentAmount > purchaseAmount)
                        {
                            InvoiceExcess((paymentAmount - purchaseAmount), item[i].Purchase_no, dal);
                        }
                        else if (paymentAmount < purchaseAmount)
                        {
                            InvoicePartial((paymentAmount - purchaseAmount), item[i].Purchase_no, dal);
                        }
                        else if (paymentAmount == 0)
                        {
                            InvoiceUnlocked((paymentAmount - purchaseAmount), item[i].Purchase_no, dal);
                        }
                    }
                }
            }
        }

        private static decimal GetPurchaseAmount(string purchase_no, DAL dal)
        {
            string q = "SELECT SUM(" + PAYMENTITEMS.PAYMENT_AMOUNT + ") FROM " + PAYMENTITEMS.PAYMENTITEMS_TBL + " WHERE " + PAYMENTITEMS.PURCHASE_NO + " =" + purchase_no + " ; ";

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
            string q = "UPDATE " + PURCHASE.PURCHASE_TBL + " SET \r\n ";
            q += " " + PURCHASE.LOCKED + " = '" + Core.Unlocked + "' \r\n ";
            q += "  WHERE " + PURCHASE.PURCHASE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoicePartial(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + PURCHASE.PURCHASE_TBL + " SET \r\n ";
            q += " " + PURCHASE.LOCKED + " = '" + Core.Partial + "' \r\n ";
            q += "  WHERE " + PURCHASE.PURCHASE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoiceExcess(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + PURCHASE.PURCHASE_TBL + " SET \r\n ";
            q += " " + PURCHASE.LOCKED + " = '" + Core.Excess + "' \r\n ";
            q += "  WHERE " + PURCHASE.PURCHASE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

        private static void InvoiceLocked(decimal v, string invoiced_no, DAL dal)
        {
            string q = "UPDATE " + PURCHASE.PURCHASE_TBL + " SET \r\n ";
            q += " " + PURCHASE.LOCKED + " = '" + Core.Locked + "' \r\n ";
            q += "  WHERE " + PURCHASE.PURCHASE_NO + " = '" + invoiced_no + "' \r\n ";
            q += "  AND " + PURCHASE.COMPANY_ID + " = '" + Current.Company_id + "' ; \r\n ";
            dal.Execute(q);
        }

    }//cls
}//ns
