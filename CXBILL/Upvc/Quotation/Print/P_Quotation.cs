// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Drawing.Printing;
using CXLIB;
using CXCORE;
//
namespace CXBILL
{
    public static class P_Quotation
    {

        private static string vPId;

        public static void Print(ReportViewer pRptViewer, string pP_id, List<PrintCopies> printdata)
        {
            vPId = pP_id;
            Print_QuotationList data = GetData(pP_id, printdata);

            LocalReport localReport = pRptViewer.LocalReport;


            localReport.ReportPath = Application.StartupPath + @"\PRINTS\P_Invoice.rdlc"; //(1)//
            localReport.DisplayName = "invoice";


            localReport.DataSources.Add(new ReportDataSource("MyDataSource", data)); //(2)//

            localReport.SubreportProcessing += localReport_SubreportProcessing;



            PrinterSettings v_PrinterSettings = GetPrinterSettings();
            pRptViewer.PrinterSettings = v_PrinterSettings;
            pRptViewer.SetPageSettings(v_PrinterSettings.DefaultPageSettings);
            pRptViewer.RefreshReport();
        }

        static void localReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            switch (e.DataSourceNames[0])
            {
                case "MyDataSource_Items":
                    try
                    {
                        Print_QuotationItemsList data_AT = P_QuotationItem.GetData(vPId);
                        e.DataSources.Add(new ReportDataSource("MyDataSource_Items", data_AT));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                    }
                    break;
            }
        }

        private static PrinterSettings GetPrinterSettings()
        {
            PrinterSettings v_PrinterSettings = new PrinterSettings();
            PaperSize vUPaperSize = new PaperSize("User Defined Paper Size", 827, 1166);
            v_PrinterSettings.DefaultPageSettings.PaperSize = vUPaperSize;
            v_PrinterSettings.DefaultPageSettings.Landscape = false;
            v_PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            return v_PrinterSettings;
        }

        private static Print_QuotationList GetData(string p_id, List<PrintCopies> printcopies)
        {
            Upvc_Quotation quote_obj = CUpvc_Quotation_exten.PKId(p_id, new DAL());

            Print_QuotationList list = new Print_QuotationList();

            for (int i = 0; i < printcopies.Count; i++)
            {
                Print_QuotationRow row = new Print_QuotationRow();

                row.COPIES = printcopies[i].Copies;

                row.QUOTATION_ID = p_id;

                //Company obj = Company.SetCompany(Current.Company_id);
                Company obj = CCompany_exten.PKId(Current.Company_id);

                row.COMPANY_NAME = obj.Display_name.ToUpper();

                row.ADDRESS1 = obj.Street1 + ", " + obj.Street2 + ", " + obj.City_id + " - " + obj.Pincode_id + " , " + obj.State_id + ". State code - 33";

                row.ADDRESS2 = "Email : " + obj.Email + "  www.smsupvc.com ";

                row.COMPANY_GST = "GSTIN                             :  " + obj.Gst;
                row.SALES_TYPE = "Create Quotation     :  " + quote_obj.Salestype_id;
                row.QUOTATION_NO = "Serial no.of Quotation      :  " + quote_obj.Quotation_no + " / " + CAcy_exten.GetDesc_Id(quote_obj.Acy_id);
                row.QUOTATION_DATE = "Invoice Date                  :  " + ConvertTO.Date2S(quote_obj.Quotation_date);


                row.TRANSPORT = "Mode of Transport      :  " + quote_obj.Transport_id;
                row.VEHICLE_NO = "";
                row.PLACE = "Place of Supply            :  " + Ccoreplus.GetCity_id(quote_obj.Delivered_id);


                row.PARTY_NAME = quote_obj.Party_id;

                Party party_obj = CParty_exten.SearchName(quote_obj.Party_id, new DAL());

                if (party_obj.Party_name != null)
                {

                    row.STREET1 = party_obj.Street1 + ", " + party_obj.Street2;
                    row.STREET2 = "";
                    row.CITY = party_obj.City_id + " - " + party_obj.Pincode_id + " , " + party_obj.State_id + ", State Code -" + Ccoreplus.GetStateCode(party_obj.State_id);
                    row.STATE = "";
                    row.COUNTRY = party_obj.Country_id;
                    row.PINCODE = "";
                    if (party_obj.Gst.Trim().Length != 0)
                    {
                        row.GSTIN = "TIN No : " + party_obj.Gst;
                    }
                    if (party_obj.Gst.Trim().Length != 0)
                    {
                        row.GSTIN += ",   GSTIN No : " + party_obj.Gst;
                    }

                }


                row.SHIPPING_NAME = CParty_exten.GetName_Id(quote_obj.Delivered_id);

                Party shipping_obj = CParty_exten.PKId(quote_obj.Delivered_id, new DAL());

                if (shipping_obj.Party_name != null)
                {

                    row.SHIPPING_STREET1 = shipping_obj.Street1 + ", " + shipping_obj.Street2;
                    row.SHIPPING_STREET2 = "";
                    row.SHIPPING_CITY = shipping_obj.City_id + " - " + shipping_obj.Pincode_id + " , " + shipping_obj.State_id + ", State Code -" + Ccoreplus.GetStateCode(shipping_obj.State_id);
                    row.SHIPPING_STATE = "";
                    row.SHIPPING_COUNTRY = shipping_obj.Country_id;
                    row.SHIPPING_PINCODE = "";
                    if (shipping_obj.Gst.Trim().Length != 0)
                    {
                        row.SHIPPING_GSTIN += ",   GSTIN No : " + shipping_obj.Gst;
                    }

                }


                row.TOTAL_QTY = ConvertTO.DecimalToS(quote_obj.Total_qty + "");

                row.TOTAL_AREASQ = ConvertTO.DecimalToS(quote_obj.Total_areasq + "");

                row.TAXABLE_VALUE = ConvertTO.Decimal2d(quote_obj.Total_taxable_amount + "");

                List<Upvc_Quotationitems> klist = CUpvc_Quotationitems_exten.FKId(p_id, new DAL());

                row.LBL_SGST = "  Add SGST tax @ " + ConvertTO.DecimalToS(klist[0].Sgst_percent) + " %";
                row.TOTAL_SGST = ConvertTO.Decimal2d(quote_obj.Total_sgst + "");

                row.LBL_CGST = "  Add CGST tax @ " + ConvertTO.DecimalToS(klist[0].Cgst_percent) + " %";
                row.TOTAL_CGST = ConvertTO.Decimal2d(quote_obj.Total_cgst + "");



                row.TOTAL_SUB = (ConvertTO.Decimal(row.TAXABLE_VALUE) + ConvertTO.Decimal(row.TOTAL_CGST) + ConvertTO.Decimal(row.TOTAL_SGST)).ToString();



                if (quote_obj.Ledger_id != null)
                {
                    if (quote_obj.Ledger_id.Trim() != "")
                    {
                        row.LEDGER = "  " + quote_obj.Ledger_id;
                        row.ADDITIONAL = quote_obj.Additional + "";
                    }
                    else
                    {
                        row.LEDGER = "";
                        row.ADDITIONAL = "";
                    }
                }
                row.ROUNDS = quote_obj.Rounds + "";
                row.GSTTOTAL = quote_obj.Gsttotal + "";
                row.GRANDTOTAL = quote_obj.Grandtotal + "";

                if (quote_obj.Notes != null)
                {
                    if (quote_obj.Notes.Trim().Length != 0)
                    {
                        row.NOTES = "Notes :  " + quote_obj.Notes;
                    }
                }
                row.AMOUNT_IN_WORDS = "Rupees   : " + Global.AmountInWords(Convert.ToDecimal(quote_obj.Grandtotal));
                row.ENTRY_BY = quote_obj.User_id;

                list.Add(row);
            }

            return list;
        }
    }

    public class Print_QuotationList : System.ComponentModel.BindingList<Print_QuotationRow>
    {
    }
    public class Print_QuotationRow
    {
        public string COPIES { get; set; }
        public string QUOTATION_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string COMPANY_TIN { get; set; }
        public string COMPANY_GST { get; set; }
        public string SALES_TYPE { get; set; }
        public string QUOTATION_NO { get; set; }
        public string QUOTATION_DATE { get; set; }

        public string TRANSPORT { get; set; }
        public string VEHICLE_NO { get; set; }
        public string PLACE { get; set; }

        public string PARTY_NAME { get; set; }
        public string STREET1 { get; set; }
        public string STREET2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string PINCODE { get; set; }
        public string GSTIN { get; set; }


        public string SHIPPING_NAME { get; set; }
        public string SHIPPING_STREET1 { get; set; }
        public string SHIPPING_STREET2 { get; set; }
        public string SHIPPING_CITY { get; set; }
        public string SHIPPING_STATE { get; set; }
        public string SHIPPING_COUNTRY { get; set; }
        public string SHIPPING_PINCODE { get; set; }
        public string SHIPPING_GSTIN { get; set; }


        public string TOTAL_QTY { get; set; }
        public string TOTAL_AREASQ { get; set; }
        public string TAXABLE_VALUE { get; set; }
        public string LBL_CGST { get; set; }
        public string TOTAL_CGST { get; set; }
        public string LBL_SGST { get; set; }
        public string TOTAL_SGST { get; set; }
        public string TOTAL_SUB { get; set; }
        public string LEDGER { get; set; }
        public string ADDITIONAL { get; set; }
        public string ROUNDS { get; set; }
        public string GSTTOTAL { get; set; }
        public string GRANDTOTAL { get; set; }
        public string AMOUNT_IN_WORDS { get; set; }
        public string NOTES { get; set; }
        public string ENTRY_BY { get; set; }
    }
    public class PQuotation
    {
        public static string COPIES = "COPIES";
        public static string INVOICE_ID = "INVOICE_ID";
        public static string COMPANY_NAME = "COMPANY_NAME";
        public static string ADDRESS1 = "ADDRESS1";
        public static string ADDRESS2 = "ADDRESS2";
        public static string COMPANY_TIN = "COMPANY_TIN";

        public static string COMPANY_GST = "COMPANY_GST";
        public static string SALES_TYPE = "SALES_TYPE";
        public static string QUOTATION_NO = "QUOTATION_NO";
        public static string QUOTATION_DATE = "QUOTATION_DATE";

        public static string TRANSPORT = "TRANSPORT";
        public static string VEHICLE_NO = "VEHICLE_NO";
        public static string PLACE = "PLACE";

        public static string PARTY_NAME = "PARTY_NAME";
        public static string STREET1 = "STREET1";
        public static string STREET2 = "STREET2";
        public static string CITY = "CITY";
        public static string STATE = "STATE";
        public static string STATE_CODE = "STATE_CODE";
        public static string COUNTRY = "COUNTRY";
        public static string PINCODE = "PINCODE";
        public static string GSTIN = "GSTIN";

        public static string SHIPPING_NAME = "SHIPPING_NAME";
        public static string SHIPPING_STREET1 = "SHIPPING_STREET1";
        public static string SHIPPING_STREET2 = "SHIPPING_STREET2";
        public static string SHIPPING_CITY = "SHIPPING_CITY";
        public static string SHIPPING_STATE = "SHIPPING_STATE";
        public static string SHIPPING_COUNTRY = "SHIPPING_COUNTRY";
        public static string SHIPPING_PINCODE = "SHIPPING_PINCODE";
        public static string SHIPPING_GSTIN = "SHIPPING_GSTIN";

        public static string TOTAL_QTY = "TOTAL_QTY";
        public static string TOTAL_AREASQ = "TOTAL_AREASQ";
        public static string TAXABLE_VALUE = "TAXABLE_VALUE";

        public static string LBL_CGST = "LBL_CGST";
        public static string TOTAL_CGST = "TOTAL_CGST";
        public static string LBL_SGST = "LBL_SGST";
        public static string TOTAL_SGST = "TOTAL_SGST";
        public static string TOTAL_SUB = "TOTAL_SUB";

        public static string LEDGER = "LEDGER";
        public static string ADDITIONAL = "ADDITIONAL";
        public static string ROUNDS = "ROUNDS";

        public static string GSTTOTAL = "GSTTOTAL";
        public static string GRANDTOTAL = "GRANDTOTAL";

        public static string AMOUNT_IN_WORDS = "AMOUNT_IN_WORDS";
        public static string NOTES = "NOTES";
        public static string ENTRY_BY = "ENTRY_BY";

    }//cls  
}//ns
