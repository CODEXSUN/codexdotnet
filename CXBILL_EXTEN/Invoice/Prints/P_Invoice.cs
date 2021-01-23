// Version : 4.0.0.2 dt : 08-01-2017
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using CXLIB;
using Microsoft.Reporting.WinForms;

//
namespace CXBILL_EXTEN.Invoice.Prints
{
    public class P_Invoice
    {

        private static string vPId;

        public static void Print(ReportViewer pRptViewer, string pP_id, List<PrintCopies> printdata)
        {
            vPId = pP_id;
            Print_InvoiceList data = PrintInvoiceExchange.GetData(pP_id, printdata);

            LocalReport localReport = pRptViewer.LocalReport;

            D_Invoice.Build();

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

        //private static Print_InvoiceList GetData(string p_id, List<PrintCopies> printcopies)
        //{
        //    Invoice invoice = CInvoice_exten.PKId(p_id);

        //    Print_InvoiceList list = new Print_InvoiceList();

        //    for (int i = 0; i < printcopies.Count; i++)
        //    {
        //        Print_InvoiceRow row = new Print_InvoiceRow();

        //        row.COPIES = printcopies[i].Copies;
        //        row.SALESTYPE = invoice.Salestype_id;

        //        Company obj = CCompany_exten.PKId(Current.Company_id);
        //        row.COMPANY_NAME = obj.Company_name;
        //        row.ADDRESS1 = obj.Street1 + " , " + obj.Street2;
        //        row.ADDRESS2 = obj.City_id + " - " + obj.Pincode_id + " , " + obj.State_id + ". STATE Code -33,";
        //        row.COMPANY_TIN = "PAN : " + obj.Pan + "  GSTIN : " + obj.Gstin + ", Cell :  098659 62999 , 090033 55404";// ,    Cell :    " + obj.Cell1 + " ";

        //        row.INVOICE_ID = p_id;
        //        row.INVOICE_NO = ".: " + invoice.Invoice_no.ToString();
        //        row.INVOICE_DATE = " : " + ConvertTO.Date2S(invoice.Invoice_date);

        //        row.PARTY_NAME = invoice.Party_id;

        //        Party _party_list = CParty_exten.SearchName(invoice.Party_id, new DAL());

        //        if (_party_list.Party_name != null)
        //        {

        //            row.STREET1 = _party_list.Street1 + ", " + _party_list.Street2;
        //            row.STREET2 = "";
        //            row.CITY = _party_list.City_id + " - " + _party_list.Pincode_id + " ,";
        //            row.STATE = "State Code - " + CState_exten.GetStateCode_Id(_party_list.State_id);
        //            row.COUNTRY = _party_list.Country_id;
        //            row.PINCODE = "";
        //            if (_party_list.Gstin.Trim().Length != 0)
        //            {
        //                row.GSTIN += "GSTIN No : " + _party_list.Gstin;
        //            }

        //        }

        //        row.TRANSPORT = " : " + invoice.Transport_id.ToString();
        //        row.DELIVERYTO = " : " + invoice.Deliveredto_id.ToString();
        //        row.BUNDEL = " : " + invoice.Bundel.ToString();


        //        row.TOTAL_QTY = ConvertTO.DecimalToS(invoice.Total_qty.ToString());

        //        row.TAXABLE_VALUE = ConvertTO.Decimal2d(invoice.Total_taxable_amount.ToString());


        //        List<Invoiceitems> klist = CInvoiceitems_exten.FKId(p_id);

        //        if (klist.Count != 0)
        //        {

        //            row.LBL_CGST = "  Add CGST tax @ " + ConvertTO.DecimalToS(klist[0].Cgst_percent.ToString()) + " %";
        //            row.LBL_SGST = "  Add SGST tax @ " + ConvertTO.DecimalToS(klist[0].Sgst_percent.ToString()) + " %";
        //            row.LBL_IGST = "  Add IGST tax @ " + ConvertTO.DecimalToS(klist[0].Igst_percent.ToString()) + " %";

        //        }
        //        else
        //        {
        //            row.LBL_CGST = "  Add CGST tax ";
        //            row.LBL_SGST = "  Add SGST tax ";
        //            row.LBL_SGST = "  Add IGST tax ";
        //        }

        //        row.TOTAL_CGST = ConvertTO.Decimal2d(invoice.Total_cgst.ToString());
        //        row.TOTAL_SGST = ConvertTO.Decimal2d(invoice.Total_sgst.ToString());
        //        row.TOTAL_IGST = ConvertTO.Decimal2d(invoice.Total_igst.ToString());

        //        row.TOTAL_SUB = (Global.ToDecimal(row.TAXABLE_VALUE) + Global.ToDecimal(row.TOTAL_CGST) + Global.ToDecimal(row.TOTAL_SGST) + Global.ToDecimal(row.TOTAL_IGST) + Global.ToDecimal(row.TOTAL_CESS)).ToString();

        //        if (invoice.Ledger_id != null)
        //        {
        //            if (invoice.Ledger_id.Trim() != "")
        //            {
        //                row.LEDGER = "  " + CLedger_exten.GetName_Id(invoice.Ledger_id);
        //                row.ADDITIONAL = invoice.Additional.ToString();
        //            }
        //            else
        //            {
        //                row.LEDGER = "";
        //                row.ADDITIONAL = "";
        //            }
        //        }
        //        row.ROUNDS = invoice.Rounds.ToString();
        //        row.GSTTOTAL = invoice.Gsttotal.ToString();
        //        row.GRANDTOTAL = invoice.Grandtotal.ToString();

        //        if (invoice.Notes != null)
        //        {
        //            if (invoice.Notes.Trim().Length != 0)
        //            {
        //                row.NOTES = "Notes :  " + invoice.Notes;
        //            }
        //        }
        //        row.AMOUNT_IN_WORDS = "Rupees   : " + Global.AmountInWords(Convert.ToDecimal(invoice.Grandtotal));
        //        row.ENTRY_BY = invoice.User_id;

        //        list.Add(row);
        //    }

        //    return list;
        //}
    }

    public class Print_InvoiceList : System.ComponentModel.BindingList<Print_Invoice>
    {
    }

}//ns
