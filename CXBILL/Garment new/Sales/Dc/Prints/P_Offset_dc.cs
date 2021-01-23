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
    public class P_Offset_dc
    {

        private static string vPId;

        public static void Print(ReportViewer pRptViewer, string pP_id, List<PrintCopies> printdata)
        {
            vPId = pP_id;
            Print_DcList data = GetData(pP_id, printdata);

            LocalReport localReport = pRptViewer.LocalReport;


            localReport.ReportPath = Application.StartupPath + @"\PRINTS\P_Dc.rdlc"; //(1)//
            localReport.DisplayName = "dc";


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
                        Print_dcItemsList data_AT = P_Offset_dcItem.GetData(vPId);
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

        private static Print_DcList GetData(string p_id, List<PrintCopies> printcopies)
        {
            Offset_dc dc = COffset_dc_exten.PKId(p_id,new DAL());

            Print_DcList list = new Print_DcList();

            for (int i = 0; i < printcopies.Count; i++)
            {
                Print_DcRow row = new Print_DcRow()
                {
                    COPIES = printcopies[i].Copies
                };

                Company obj = CCompany_exten.PKId(Current.Company_id);
                row.COMPANY_NAME = obj.Display_name.ToUpper();
                row.ADDRESS1 = obj.Street1 + " , " + obj.Street2;
                row.ADDRESS2 = obj.City_id + " - " + obj.Pincode_id + " , " + obj.State_id + ". Code -33,    Email : " + obj.Email;
                row.COMPANY_TIN = " GSTIN : " + obj.Gst + " ,    Cell :    " + obj.Cell1 + " ";

                row.DC_ID = p_id;
                row.DC_NO = dc.Offset_dc_no;
                row.DC_DATE = ConvertTO.Date2S(dc.Offset_dc_date);

                row.PARTY_NAME = dc.Party_id;

                Party _party_list = CParty_exten.SearchName(dc.Party_id, new DAL());

                if (_party_list.Party_name != null)
                {

                    row.STREET1 = _party_list.Street1 + ", " + _party_list.Street2;
                    row.STREET2 = "";
                    row.CITY = _party_list.City_id + " - " + _party_list.Pincode_id + " , " + _party_list.State_id;
                    row.STATE = "";
                    row.COUNTRY = _party_list.Country_id;
                    row.PINCODE = "";

                    if (_party_list.Gstin.Trim().Length != 0)
                    {
                        row.GSTIN += "GSTIN No : " + _party_list.Gstin;
                    }

                }
                row.TOTAL_QTY = ConvertTO.DecimalToS(dc.Total_qty);

                if (dc.Notes != null)
                {
                    if (dc.Notes.Trim().Length != 0)
                    {
                        row.NOTES = "Notes :  " + dc.Notes;
                    }
                }
                row.ENTRY_BY = dc.User_id;

                list.Add(row);
            }

            return list;
        }
    }

    public class Print_DcList : System.ComponentModel.BindingList<Print_DcRow>
    {
    }
    public class Print_DcRow
    {
        public string COPIES { get; set; }
        public string COMPANY_NAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string COMPANY_TIN { get; set; }
        public string DC_ID { get; set; }
        public string DC_NO { get; set; }
        public string DC_DATE { get; set; }
        public string PARTY_NAME { get; set; }
        public string STREET1 { get; set; }
        public string STREET2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string PINCODE { get; set; }
        public string GSTIN { get; set; }
        public string TOTAL_QTY { get; set; }
        public string NOTES { get; set; }
        public string ENTRY_BY { get; set; }
    }
    public class PDc
    {
        public static string COPIES = "COPIES";
        public static string COMPANY_NAME = "COMPANY_NAME";
        public static string ADDRESS1 = "ADDRESS1";
        public static string ADDRESS2 = "ADDRESS2";
        public static string COMPANY_TIN = "COMPANY_TIN";

        public static string DC_ID = "DC_ID";
        public static string DC_NO = "DC_NO";
        public static string DC_DATE = "DC_DATE";

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
        public static string NOTES = "NOTES";
        public static string ENTRY_BY = "ENTRY_BY";

    }//cls  
}//ns
