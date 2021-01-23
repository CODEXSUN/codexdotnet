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
    public class P_Invoice
    {

        private static string vPId;

        public static void Print(ReportViewer pRptViewer, string pP_id, List<PrintCopies> printdata)
        {
            vPId = pP_id;
            Print_InvoiceList data = GetData(pP_id, printdata);

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
                        Print_invoiceItemsList data_AT = P_InvoiceItem.GetData(vPId);
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

        private static Print_InvoiceList GetData(string p_id, List<PrintCopies> printcopies)
        {
            Garment_invoice invoice = CGarment_invoice_exten.PKId(p_id);

            Print_InvoiceList list = new Print_InvoiceList();

            for (int i = 0; i < printcopies.Count; i++)
            {
                Print_InvoiceRow row = new Print_InvoiceRow();

                row.COPIES = printcopies[i].Copies;
                row.SALESTYPE = invoice.Salestype_id;

                Company obj = CCompany_exten.PKId(Current.Company_id);
                row.COMPANY_NAME = obj.Display_name.ToUpper();
                row.ADDRESS1 = obj.Street1 + " , " + obj.Street2;
                row.ADDRESS2 = obj.City_id + " - " + obj.Pincode_id + " , " + obj.State_id + ". Code -33,    Email : " + obj.Email;
                row.COMPANY_TIN = " GSTIN : " + obj.Gst + "";// ,    Cell :    " + obj.Cell1 + " ";

                row.INVOICE_ID = p_id;
                row.INVOICE_NO = invoice.Garment_invoice_no;
                row.INVOICE_DATE = ConvertTO.Date2S(invoice.Garment_invoice_date);

                row.PARTY_NAME = invoice.Party_id;

                Party _party_list = CParty_exten.SearchName(invoice.Party_id, new DAL());

                if (_party_list.Party_name != null)
                {

                    row.STREET1 = _party_list.Street1 + ", " ;
                    row.STREET2 = _party_list.Street2 + ",";
                    row.CITY = _party_list.City_id + "  " + _party_list.Pincode_id + "  " + _party_list.State_id + ".";
                    row.STATE = "";
                    row.COUNTRY = _party_list.Country_id;
                    row.PINCODE = "";

                    if (_party_list.Gst.Trim().Length != 0)
                    {
                        row.GSTIN += "GSTIN No : " + _party_list.Gst;
                    }

                }
                row.TOTAL_QTY = ConvertTO.DecimalToS(invoice.Total_qty.ToString());

                row.TAXABLE_VALUE = ConvertTO.Decimal2d(invoice.Total_taxable_amount.ToString());


                List<Garment_invoiceitems> klist = CGarment_invoiceitems_exten.FKId(p_id);

                if (klist.Count != 0)
                {

                    row.LBL_CGST = "  Add CGST tax @ " + ConvertTO.DecimalToS(klist[0].Cgst_percent.ToString()) + " %";
                    row.LBL_SGST = "  Add SGST tax @ " + ConvertTO.DecimalToS(klist[0].Sgst_percent.ToString()) + " %";
                }
                else
                {
                    row.LBL_CGST = "  Add CGST tax ";
                    row.LBL_SGST = "  Add SGST tax ";
                }

                row.TOTAL_CGST = ConvertTO.Decimal2d(invoice.Total_cgst.ToString());
                row.TOTAL_SGST = ConvertTO.Decimal2d(invoice.Total_sgst.ToString());
                row.TOTAL_IGST = ConvertTO.Decimal2d(invoice.Total_igst.ToString());

                row.TOTAL_SUB = (Global.ToDecimal(row.TAXABLE_VALUE) + Global.ToDecimal(row.TOTAL_CGST) + Global.ToDecimal(row.TOTAL_SGST) + Global.ToDecimal(row.TOTAL_IGST) + Global.ToDecimal(row.TOTAL_CESS)).ToString();

                if (invoice.Ledger_id != null)
                {
                    if (invoice.Ledger_id.Trim() != "")
                    {
                        row.LEDGER = "  "+ CLedger_exten.GetName_Id(invoice.Ledger_id);
                        row.ADDITIONAL = invoice.Additional.ToString();
                    }
                    else
                    {
                        row.LEDGER = "";
                        row.ADDITIONAL = "";
                    }
                }
                row.ROUNDS = invoice.Rounds.ToString();
                row.GSTTOTAL = invoice.Gsttotal.ToString();
                row.GRANDTOTAL = invoice.Grandtotal.ToString();

                if (invoice.Notes != null)
                {
                    if (invoice.Notes.Trim().Length != 0)
                    {
                        row.NOTES = "Notes :  " + invoice.Notes;
                    }
                }
                row.AMOUNT_IN_WORDS = "Rupees   : " + Global.AmountInWords(Convert.ToDecimal(invoice.Grandtotal));
                row.ENTRY_BY = invoice.User_id;

                list.Add(row);
            }

            return list;
        }
    }

    public class Print_InvoiceList : System.ComponentModel.BindingList<Print_InvoiceRow>
    {
    }
    public class Print_InvoiceRow
    {
        public string COPIES { get; set; }
        public string SALESTYPE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string COMPANY_TIN { get; set; }
        public string INVOICE_ID { get; set; }
        public string INVOICE_NO { get; set; }
        public string INVOICE_DATE { get; set; }
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
        public string LBL_CGST { get; set; }
        public string LBL_SGST { get; set; }
        public string TOTAL_CGST { get; set; }
        public string TOTAL_SGST { get; set; }
        public string TOTAL_IGST { get; set; }
        public string TOTAL_CESS { get; set; }
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
    public class PInvoice
    {
        public static string COPIES = "COPIES";
        public static string SALESTYPE = "SALESTYPE";
        public static string COMPANY_NAME = "COMPANY_NAME";
        public static string ADDRESS1 = "ADDRESS1";
        public static string ADDRESS2 = "ADDRESS2";
        public static string COMPANY_TIN = "COMPANY_TIN";

        public static string INVOICE_ID = "INVOICE_ID";
        public static string INVOICE_NO = "INVOICE_NO";
        public static string INVOICE_DATE = "INVOICE_DATE";

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

        public static string LBL_CGST = "LBL_CGST";
        public static string LBL_SGST = "LBL_SGST";

        public static string TOTAL_CGST = "TOTAL_CGST";
        public static string TOTAL_SGST = "TOTAL_SGST";
        public static string TOTAL_IGST = "TOTAL_IGST";
        public static string TOTAL_CESS = "TOTAL_CESS";
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
