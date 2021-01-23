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
using CodeskLib;
using CodeskCore;
//
namespace Billing
{
    public class P2_Invoice
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
            Invoice inv_list = CInvoice.Invoice_Data(CInvoice_exten.Primarykey_invoiceid(p_id));

            Print_InvoiceList list = new Print_InvoiceList();

            for (int i = 0; i < printcopies.Count; i++)
            {
                Print_InvoiceRow row = new Print_InvoiceRow();

                row.COPIES = printcopies[i].Copies;

                Company obj = Company.SetCompany(Current.Company_id);
                row.COMPANY_NAME = obj.Display_name.ToUpper();
                row.ADDRESS1 = obj.Street1 + " , " + obj.Street2;
                row.ADDRESS2 = obj.City_id + " - " + obj.Pincode_id + " , " + obj.State_id + ".    Email : " + obj.Email;
                //row.COMPANY_TIN = " TIN  " + obj.Tin + " ,    GSTIN  " + obj.Cst + " , PAN " + obj.Pan;
                row.COMPANY_TIN = "   GSTIN  " + obj.Cst ;

                row.INVOICE_ID = p_id;
                row.INVOICE_NO = inv_list.Invoice_no;
                row.INVOICE_DATE = ConvertTO.Date2S(inv_list.Invoice_date);

                row.PARTY_NAME = CParty_exten.GetName_Id(inv_list.Party_id);

                Party _party_list = CParty.Party_Data(CParty_exten.PrimarykeyPartyId(inv_list.Party_id));

                if (_party_list.Party_name != null)
                {

                    row.STREET1 = _party_list.Street1 + ", " + _party_list.Street2;
                    row.STREET2 = "";
                    row.CITY = cCity.GetName_Id(_party_list.City_id) + " - " + cPincode_exten.GetName_Id(_party_list.Pincode_id) + " , " + cState_exten.GetName_Id(_party_list.State_id);
                    row.STATE = "";
                    row.COUNTRY = _party_list.Country_id;
                    row.PINCODE = "";
                    //if (_party_list.Tin.Trim().Length != 0)
                    //{
                    //    row.GSTIN = "TIN No : " + _party_list.Tin;
                    //}
                    if (_party_list.Gst.Trim().Length != 0)
                    {
                        row.GSTIN = "GSTIN No : " + _party_list.Gst;
                    }

                }
                row.TOTAL_QTY = ConvertTO.DecimalToS(inv_list.Total_qty);

                row.TAXABLE_VALUE = ConvertTO.Decimal2d(inv_list.Total_taxable_amount);
                row.TOTAL_CGST = ConvertTO.Decimal2d(inv_list.Total_cgst);
                row.TOTAL_SGST = ConvertTO.Decimal2d(inv_list.Total_sgst);
                row.TOTAL_IGST = ConvertTO.Decimal2d(inv_list.Total_igst);
                row.TOTAL_CESS = ConvertTO.Decimal2d(inv_list.Total_cess);



                row.TOTAL_SUB = (Global.ToDecimal(row.TAXABLE_VALUE) + Global.ToDecimal(row.TOTAL_CGST) + Global.ToDecimal(row.TOTAL_SGST) + Global.ToDecimal(row.TOTAL_IGST) + Global.ToDecimal(row.TOTAL_CESS)).ToString();



                if (inv_list.Ledger_id != null)
                {
                    if (inv_list.Ledger_id.Trim() != "")
                    {
                        row.LEDGER = cLedger.GetName_Id(inv_list.Ledger_id);
                        row.ADDITIONAL = inv_list.Additional;
                    }
                    else
                    {
                        row.LEDGER = "";
                        row.ADDITIONAL = "";
                    }
                }
                row.ROUNDS = inv_list.Rounds;
                row.GSTTOTAL = inv_list.Gsttotal;
                row.GRANDTOTAL = inv_list.Grandtotal;

                if (inv_list.Notes != null)
                {
                    if (inv_list.Notes.Trim().Length != 0)
                    {
                        row.NOTES = "Notes :  " + inv_list.Notes;
                    }
                }
                row.AMOUNT_IN_WORDS = "Rupees   : " + Global.AmountInWords(Convert.ToDecimal(inv_list.Grandtotal));
                row.ENTRY_BY = inv_list.User_id;

                list.Add(row);
            }

            return list;
        }
    }

    public class Print2_InvoiceList : System.ComponentModel.BindingList<Print2_InvoiceRow>
    {
    }
    public class Print2_InvoiceRow
    {
        public string COPIES { get; set; }
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
    public class P2Invoice
    {
        public static string COPIES = "COPIES";
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
