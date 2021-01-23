using CXLIB;
using System;
using System.Collections.Generic;
using System.Data;
using CXCORE;
using System.Diagnostics;

namespace CXBILL
{
    public class RCGSTRegister
    {
        #region[Sales List]

        private static List<Sales_Gst> SalesEntityList(string q)
        {
            List<Sales_Gst> list = new List<Sales_Gst>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Sales_Gst obj = new Sales_Gst()
                    {
                        Company_name = "",
                        Acy_name = "",
                        Sales_Month = "",
                        Gstin = redr[SALES_GST.GSTIN].ToString(),
                        Party_name = redr[SALES_GST.PARTY_NAME].ToString(),
                        Bill_no = redr[SALES_GST.BILL_NO].ToString(),
                        Bill_date = ConvertTO.Date2S(redr[SALES_GST.BILL_DATE].ToString()),
                        Bill_amount = ConvertTO.Decimal(redr[SALES_GST.BILL_AMOUNT].ToString()),
                        Taxable_value = ConvertTO.Decimal(redr[SALES_GST.TAXABLE_VALUE].ToString()),
                        Sgst_percent = redr[SALES_GST.SGST_PERCENT].ToString(),
                        Sgst_amount = ConvertTO.Decimal(redr[SALES_GST.SGST_AMOUNT].ToString()),
                        Cgst_percent = redr[SALES_GST.CGST_PERCENT].ToString(),
                        Cgst_amount = ConvertTO.Decimal(redr[SALES_GST.CGST_AMOUNT].ToString()),
                        Igst_percent = redr[SALES_GST.IGST_PERCENT].ToString(),
                        Igst_amount = ConvertTO.Decimal(redr[SALES_GST.IGST_AMOUNT].ToString()),
                        Gst_total = ConvertTO.Decimal(redr[SALES_GST.GST_TOTAL].ToString())
                    };
                    list.Add(obj);
                }
            }

            return list;
        }

        #endregion[Sales List]

        #region[Purchase List]

        private static List<Purchase_Gst> PurchaseEntityList(string q)
        {
            List<Purchase_Gst> list = new List<Purchase_Gst>();

            using (IDataReader redr = new DAL().Listreader(q))
            {
                while (redr.Read() == true)
                {
                    Purchase_Gst obj = new Purchase_Gst()
                    {
                        Company_name = "",
                        Acy_name = "",
                        Purchase_Month = "",
                        Gstin = redr[PURCHASE_GST.GSTIN].ToString(),
                        Party_name = redr[PURCHASE_GST.PARTY_NAME].ToString(),
                        Bill_no = redr[PURCHASE_GST.BILL_NO].ToString(),
                        Bill_date = ConvertTO.Date2S(redr[PURCHASE_GST.BILL_DATE].ToString()),
                        Bill_amount = ConvertTO.Decimal(redr[SALES_GST.BILL_AMOUNT].ToString()),
                        Taxable_value = ConvertTO.Decimal(redr[SALES_GST.TAXABLE_VALUE].ToString()),
                        Sgst_percent = redr[SALES_GST.SGST_PERCENT].ToString(),
                        Sgst_amount = ConvertTO.Decimal(redr[SALES_GST.SGST_AMOUNT].ToString()),
                        Cgst_percent = redr[SALES_GST.CGST_PERCENT].ToString(),
                        Cgst_amount = ConvertTO.Decimal(redr[SALES_GST.CGST_AMOUNT].ToString()),
                        Igst_percent = redr[SALES_GST.IGST_PERCENT].ToString(),
                        Igst_amount = ConvertTO.Decimal(redr[SALES_GST.IGST_AMOUNT].ToString()),
                        Gst_total = ConvertTO.Decimal(redr[SALES_GST.GST_TOTAL].ToString())
                    };
                    list.Add(obj);
                }
            }

            return list;
        }

        #endregion[List]

        #region[Sales Query]

        public static List<Sales_Gst> SalesData(string fromDt, string toDt)
        {
            String q = " SELECT DISTINCT \r\n";
            q += " " + INVOICE.COMPANY_ID + ", \r\n";
            q += " " + SALES_GST.GSTIN + ", \r\n";
            q += " " + SALES_GST.PARTY_NAME + ", \r\n";
            q += " " + SALES_GST.BILL_NO + ", \r\n";
            q += " " + SALES_GST.BILL_DATE + ", \r\n";
            q += " " + SALES_GST.BILL_AMOUNT + ", \r\n";
            q += " " + SALES_GST.TAXABLE_VALUE + ", \r\n";
            q += " " + SALES_GST.SGST_PERCENT + ", \r\n";
            q += " " + SALES_GST.SGST_AMOUNT + ", \r\n";
            q += " " + SALES_GST.CGST_PERCENT + ", \r\n";
            q += " " + SALES_GST.CGST_AMOUNT + ", \r\n";
            q += " " + SALES_GST.IGST_PERCENT + ", \r\n";
            q += " " + SALES_GST.IGST_AMOUNT + ", \r\n";
            q += " " + SALES_GST.GST_TOTAL + " \r\n";
            q += " FROM ( \r\n";

            q += " SELECT  \r\n";
            q += " " + INVOICE.COMPANY_ID + ", \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.GSTIN + " AS " + SALES_GST.GSTIN + ", \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS " + SALES_GST.PARTY_NAME + ", \r\n";
            q += " " + INVOICE.INVOICE_TBL + "." + INVOICE.INVOICE_NO + " AS " + SALES_GST.BILL_NO + ", \r\n";
            q += " " + INVOICE.INVOICE_DATE + " AS " + SALES_GST.BILL_DATE + ", \r\n";
            q += " " + INVOICE.GRANDTOTAL + " AS " + SALES_GST.BILL_AMOUNT + ", \r\n";
            q += " " + INVOICE.TOTAL_TAXABLE_AMOUNT + " AS " + SALES_GST.TAXABLE_VALUE + ", \r\n";
            q += " " + INVOICEITEMS.SGST_PERCENT + " AS " + SALES_GST.SGST_PERCENT + ", \r\n";
            q += " " + INVOICE.TOTAL_SGST + " AS " + SALES_GST.SGST_AMOUNT + ", \r\n";
            q += " " + INVOICEITEMS.CGST_PERCENT + " AS " + SALES_GST.CGST_PERCENT + ", \r\n";
            q += " " + INVOICE.TOTAL_CGST + " AS " + SALES_GST.CGST_AMOUNT + ", \r\n";
            q += " " + INVOICEITEMS.IGST_PERCENT + " AS " + SALES_GST.IGST_PERCENT + ", \r\n";
            q += " " + INVOICE.TOTAL_IGST + " AS " + SALES_GST.IGST_AMOUNT + ", \r\n";
            q += " " + INVOICE.GSTTOTAL + " AS " + SALES_GST.GST_TOTAL + " \r\n";

            q += " FROM " + INVOICE.INVOICE_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + INVOICE.INVOICE_TBL + "." + INVOICE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";

            q += " INNER JOIN " + INVOICEITEMS.INVOICEITEMS_TBL + " ON(" + INVOICEITEMS.INVOICEITEMS_TBL + "." + INVOICEITEMS.INVOICE_ID + " = " + INVOICE.INVOICE_TBL + "." + INVOICE.INVOICE_ID + ") \r\n";

            q += " ) s \r\n";

            q += " WHERE " + INVOICE.COMPANY_ID + " =  " + Current.Company_id + " \r\n";
            q += " AND " + SALES_GST.BILL_NO + " <> '0' \r\n";

            if ((fromDt != "") && (fromDt != null))
            {
                if ((toDt != "") && (toDt != null))
                {
                    q += " AND  " + SALES_GST.BILL_DATE + " BETWEEN " + ConvertTO.SqlDate(fromDt) + " AND  " + ConvertTO.SqlDate(toDt) + " \r\n";
                }
                else
                {
                    q += " AND  " + SALES_GST.BILL_DATE + " BETWEEN " + ConvertTO.SqlDate(fromDt) + " AND  " + ConvertTO.SqlDate(DateTime.Now.ToString()) + " \r\n";
                }
            }
            q += " ORDER BY " + SALES_GST.BILL_DATE + "," + SALES_GST.BILL_NO + ";\r\n";

            return SalesEntityList(q);
        }

        #endregion[SQuery]

        #region[Purchase Query]

        public static List<Purchase_Gst> PurchaseData(string fromDt, string toDt)
        {

            String q = " SELECT DISTINCT \r\n";
            q += " " + PURCHASE.COMPANY_ID + ", \r\n";
            q += " " + PURCHASE_GST.GSTIN + ", \r\n";
            q += " " + PURCHASE_GST.PARTY_NAME + ", \r\n";
            q += " " + PURCHASE_GST.BILL_NO + ", \r\n";
            q += " " + PURCHASE_GST.BILL_DATE + ", \r\n";
            q += " " + PURCHASE_GST.BILL_AMOUNT + ", \r\n";
            q += " " + PURCHASE_GST.TAXABLE_VALUE + ", \r\n";
            q += " " + PURCHASE_GST.SGST_PERCENT + ", \r\n";
            q += " " + PURCHASE_GST.SGST_AMOUNT + ", \r\n";
            q += " " + PURCHASE_GST.CGST_PERCENT + ", \r\n";
            q += " " + PURCHASE_GST.CGST_AMOUNT + ", \r\n";
            q += " " + PURCHASE_GST.IGST_PERCENT + ", \r\n";
            q += " " + PURCHASE_GST.IGST_AMOUNT + ", \r\n";
            q += " " + PURCHASE_GST.GST_TOTAL + " \r\n";
            q += " FROM ( \r\n";

            q += " SELECT  \r\n";
            q += " " + PURCHASE.COMPANY_ID + ", \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.GSTIN + " AS " + PURCHASE_GST.GSTIN + ", \r\n";
            q += " " + PARTY.PARTY_TBL + "." + PARTY.PARTY_NAME + " AS " + PURCHASE_GST.PARTY_NAME + ", \r\n";
            q += " " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_NO + " AS " + PURCHASE_GST.BILL_NO + ", \r\n";
            q += " " + PURCHASE.PURCHASE_DATE + " AS " + PURCHASE_GST.BILL_DATE + ", \r\n";
            q += " " + PURCHASE.GRANDTOTAL + " AS " + PURCHASE_GST.BILL_AMOUNT + ", \r\n";
            q += " " + PURCHASE.TOTAL_TAXABLE_AMOUNT + " AS " + PURCHASE_GST.TAXABLE_VALUE + ", \r\n";
            q += " " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.SGST_PERCENT + " AS " + PURCHASE_GST.SGST_PERCENT + ", \r\n";
            q += " " + PURCHASE.TOTAL_SGST + " AS " + PURCHASE_GST.SGST_AMOUNT + ", \r\n";
            q += " " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.CGST_PERCENT + " AS " + PURCHASE_GST.CGST_PERCENT + ", \r\n";
            q += " " + PURCHASE.TOTAL_CGST + " AS " + PURCHASE_GST.CGST_AMOUNT + ", \r\n";
            q += " " + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.IGST_PERCENT + " AS " + PURCHASE_GST.IGST_PERCENT + ", \r\n";
            q += " " + PURCHASE.TOTAL_IGST + " AS " + PURCHASE_GST.IGST_AMOUNT + ", \r\n";
            q += " " + PURCHASE.GSTTOTAL + " AS " + PURCHASE_GST.GST_TOTAL + " \r\n";

            q += " FROM " + PURCHASE.PURCHASE_TBL + " \r\n";
            q += " INNER JOIN " + PARTY.PARTY_TBL + " ON(" + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PARTY_ID + " = " + PARTY.PARTY_TBL + "." + PARTY.PARTY_ID + ") \r\n";
            q += " INNER JOIN " + PURCHASEITEMS.PURCHASEITEMS_TBL + " ON(" + PURCHASEITEMS.PURCHASEITEMS_TBL + "." + PURCHASEITEMS.PURCHASE_ID + " = " + PURCHASE.PURCHASE_TBL + "." + PURCHASE.PURCHASE_ID + ") \r\n";

            q += " ) s \r\n";

            q += " WHERE " + PURCHASE.COMPANY_ID + " =  " + Current.Company_id + " \r\n";
            q += " AND " + PURCHASE_GST.BILL_NO + " <> '0' \r\n";

            if ((fromDt != "") && (fromDt != null))
            {
                if ((toDt != "") && (toDt != null))
                {
                    q += " AND  " + PURCHASE_GST.BILL_DATE + " BETWEEN " + ConvertTO.SqlDate(fromDt) + " AND  " + ConvertTO.SqlDate(toDt) + " \r\n";
                }
                else
                {
                    q += " AND  " + PURCHASE_GST.BILL_DATE + " BETWEEN " + ConvertTO.SqlDate(fromDt) + " AND  " + ConvertTO.SqlDate(DateTime.Now.ToString()) + " \r\n";
                }
            }
            q += " ORDER BY " + PURCHASE_GST.BILL_DATE + "," + PURCHASE_GST.BILL_NO + ";\r\n";

            return PurchaseEntityList(q);
        }

        #endregion[Purchase]

    }//cls
}//ns
