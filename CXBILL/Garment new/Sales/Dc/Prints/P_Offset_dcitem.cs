// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Drawing.Printing;
using CXLIB;
using CXCORE;

//
namespace CXBILL
{
    public class P_Offset_dcItem
    {


        public static void Print(ReportViewer pRptViewer, string p_id)
        {
            Print_dcItemsList data = GetData(p_id);

            LocalReport localReport = pRptViewer.LocalReport;

            //= Set Report Path
			localReport.ReportPath = Application.StartupPath + @"\PRINTS\P_DcItem.rdlc"; //(1)//
            localReport.DisplayName = "dc items";

            //= Set Report Data Source
            localReport.DataSources.Add(new ReportDataSource("MyDataSource_Items", data)); //(2)//

            //= Refresh the report

            PrinterSettings v_PrinterSettings = GetPrinterSettings();
            pRptViewer.PrinterSettings = v_PrinterSettings;
            pRptViewer.SetPageSettings(v_PrinterSettings.DefaultPageSettings);
            pRptViewer.RefreshReport();
        }

        private static PrinterSettings GetPrinterSettings()
        {
            PrinterSettings v_PrinterSettings = new PrinterSettings();

            //			vPrnSet.PrinterName = this.PrinterName;
            PaperSize vUPaperSize = new PaperSize("User Defined Paper Size", 827, 583);
            v_PrinterSettings.DefaultPageSettings.PaperSize = vUPaperSize;
            v_PrinterSettings.DefaultPageSettings.Landscape = false;
            v_PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;

            return v_PrinterSettings;
        }

        public static Print_dcItemsList GetData(string p_id)
        {
            Print_dcItemsList list = new Print_dcItemsList();
            //
            List<Offset_dcitems> dcitems = COffset_dcitems_exten.FKId(p_id , new DAL());

            for (int r = 0; r <= dcitems.Count - 1; r++)
            {
                Print_dcitemsRow row = new Print_dcitemsRow();
               //
                row.DC_ITEM_ID = dcitems[r].Offset_dcitems_id;
                row.DC_ID = dcitems[r].Offset_dc_id;
                row.SL_NO = (r + 1).ToString();

                if (dcitems[r].Offset_po_id == "Without PO")
                {
                    row.PO_ID = "";
                }
                else
                {
                    row.PO_ID = dcitems[r].Offset_po_id;
                }


                if (dcitems[r].Offset_dc_id == "1")
                {
                    row.DC_ID = "";
                }
                else
                {
                    row.DC_ID = dcitems[r].Offset_dc_id;
                }

                row.PRODUCT_ID = dcitems[r].Product_id;

                row.HSN_CODE_ID = Ccoreplus.GetHsncode_name(dcitems[r].Product_id);

                row.QTY = ConvertTO.DecimalToS(dcitems[r].Qty);
                //
                list.Add(row);
                //
            }
            //
            return list;
        }
    }//cls

    public class Print_dcItemsList : System.ComponentModel.BindingList<Print_dcitemsRow>
    {
    }

    public class Print_dcitemsRow
    {
		public string DC_ITEM_ID { get; set; }
		public string DC_ID { get; set; }
        public string SL_NO { get; set; }
        public string PO_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string HSN_CODE_ID { get; set; }
        public string QTY { get; set; }

    }//cls


    public class PDcitems
    {
        public static string DC_ITEM_ID = "DC_ITEM_ID";
        public static string DC_ID = "DC_ID";
        public static string SL_NO = "SL_NO";
        public static string PO_ID = "PO_ID";
        public static string PRODUCT_ID = "PRODUCT_ID";
        public static string HSN_CODE_ID = "HSN_CODE_ID";
        public static string QTY = "QTY";
    }



}//ns
