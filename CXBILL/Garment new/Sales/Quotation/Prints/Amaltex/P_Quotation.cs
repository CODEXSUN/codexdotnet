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
    public class P_Quotation
    {

        private static string vPId;

        public static void Print(ReportViewer pRptViewer, string pP_id)
        {
            vPId = pP_id;
            Print_QuotationList data = GetData(pP_id);

            LocalReport localReport = pRptViewer.LocalReport;


            localReport.ReportPath = Application.StartupPath + @"\PRINTS\P_Quotation.rdlc"; //(1)//
            localReport.DisplayName = "quotation";


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
                        Print_quotationItemsList data_AT = P_QuotationItem.GetData(vPId);
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

        private static Print_QuotationList GetData(string p_id)
        {
            Quotation quotation = CQuotation_exten.PKId(p_id, new DAL());

            Print_QuotationList list = new Print_QuotationList();

            Print_QuotationRow row = new Print_QuotationRow();

            Company obj = CCompany_exten.PKId(Current.Company_id);
            row.COMPANY_NAME = obj.Display_name.ToUpper();
            row.ADDRESS1 = obj.Street1 + " , " + obj.Street2;
            row.ADDRESS2 = obj.City_id + " - " + obj.Pincode_id + " , " + obj.State_id + ". Code -33,    Email : " + obj.Email;
            row.COMPANY_TIN = " GSTIN : " + obj.Gstin + "";// ,    Cell :    " + obj.Cell1 + " ";

            row.QUOTATION_ID = p_id;
            row.QUOTATION_NO = "NO    : " + quotation.Quotation_no.ToString();
            row.QUOTATION_DATE = "DATE  : " + ConvertTO.Date2S(quotation.Quotation_date);

            row.PARTY_NAME = quotation.Party_id;

            Party _party_list = CParty_exten.SearchName(quotation.Party_id, new DAL());

            if (_party_list.Party_name != null)
            {

                row.STREET1 = _party_list.Street_1 + ", " + _party_list.Street_2;
                row.STREET2 = "";
                row.CITY = _party_list.City_id + " - " + _party_list.Pincode_id + " ,";
                //row.STATE = _party_list.State_id + " - " + CState_exten.GetStateCode(_party_list.State_id);
                row.COUNTRY = _party_list.Country_id;
                row.PINCODE = "";

                if (_party_list.Gstin.Trim().Length != 0)
                {
                    row.GSTIN += "GSTIN No : " + _party_list.Gstin;
                }

            }

            row.TOTAL_QTY = ConvertTO.DecimalToS(quotation.Total_qty.ToString());

            row.TAXABLE_VALUE = ConvertTO.Decimal2d(quotation.Total_taxable_amount.ToString());


            List<Quotationitems> klist = CQuotationitems_exten.FKId(p_id, new DAL());

            row.TOTAL_SUB = (Global.ToDecimal(row.TAXABLE_VALUE).ToString());

            if (quotation.Ledger_id != null)
            {
                if (quotation.Ledger_id.Trim() != "")
                {
                    row.LEDGER = "Add TAX Invoice " + quotation.Ledger_id;
                }
                else
                {
                    row.LEDGER = "";
                }
            }

            row.ADDITIONAL = quotation.Additional.ToString();
            row.OUTSTANDING = "Total Outstanding Amount : " + CQuotation_exten.GetBalance(CParty_exten.GetId_Name(quotation.Party_id));
            row.GRANDTOTAL = quotation.Grandtotal.ToString();
            row.AMOUNT_IN_WORDS = "Rupees   : " + Global.AmountInWords(Convert.ToDecimal(quotation.Grandtotal));

            list.Add(row);

            return list;
        }
    }

    public class Print_QuotationList : System.ComponentModel.BindingList<Print_QuotationRow>
    {
    }
    public class Print_QuotationRow
    {
        public string COPIES { get; set; }
        public string SALESTYPE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string COMPANY_TIN { get; set; }
        public string QUOTATION_ID { get; set; }
        public string QUOTATION_NO { get; set; }
        public string QUOTATION_DATE { get; set; }
        public string PARTY_NAME { get; set; }
        public string STREET1 { get; set; }
        public string STREET2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string PINCODE { get; set; }
        public string GSTIN { get; set; }
        public string TOTAL_QTY { get; set; }
        public string TAXABLE_VALUE { get; set; }
        public string TOTAL_SUB { get; set; }
        public string LEDGER { get; set; }
        public string ADDITIONAL { get; set; }
        public string OUTSTANDING { get; set; }
        public string GSTTOTAL { get; set; }
        public string GRANDTOTAL { get; set; }
        public string AMOUNT_IN_WORDS { get; set; }
    }
    public class PQuotation
    {
        public static string COPIES = "COPIES";
        public static string SALESTYPE = "SALESTYPE";
        public static string COMPANY_NAME = "COMPANY_NAME";
        public static string ADDRESS1 = "ADDRESS1";
        public static string ADDRESS2 = "ADDRESS2";
        public static string COMPANY_TIN = "COMPANY_TIN";

        public static string QUOTATION_ID = "QUOTATION_ID";
        public static string QUOTATION_NO = "QUOTATION_NO";
        public static string QUOTATION_DATE = "QUOTATION_DATE";

        public static string TRANSPORT = "TRANSPORT";
        public static string DELIVERYTO = "DELIVERYTO";
        public static string BUNDEL = "BUNDEL";


        public static string PARTY_NAME = "PARTY_NAME";
        public static string STREET1 = "STREET1";
        public static string STREET2 = "STREET2";
        public static string CITY = "CITY";
        public static string STATE = "STATE";
        public static string STATE_CODE = "STATE_CODE";
        public static string COUNTRY = "COUNTRY";
        public static string PINCODE = "PINCODE";
        public static string GSTIN = "GSTIN";

        public static string TOTAL_QTY = "TOTAL_QTY";
        public static string TAXABLE_VALUE = "TAXABLE_VALUE";

        public static string TOTAL_SUB = "TOTAL_SUB";

        public static string LEDGER = "LEDGER";
        public static string ADDITIONAL = "ADDITIONAL";
        public static string OUTSTANDING = "OUTSTANDING";

        public static string GSTTOTAL = "GSTTOTAL";
        public static string GRANDTOTAL = "GRANDTOTAL";

        public static string AMOUNT_IN_WORDS = "AMOUNT_IN_WORDS";
        public static string NOTES = "NOTES";
        public static string ENTRY_BY = "ENTRY_BY";

    }//cls  
}//ns
