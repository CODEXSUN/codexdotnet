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
    public class P_InvoiceItem
    {


        public static void Print(ReportViewer pRptViewer, string p_id)
        {
            Print_invoiceItemsList data = GetData(p_id);

            LocalReport localReport = pRptViewer.LocalReport;

            //= Set Report Path
			localReport.ReportPath = Application.StartupPath + @"\PRINTS\P_InvoiceItem.rdlc"; //(1)//
            localReport.DisplayName = "invoice items";

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

        public static Print_invoiceItemsList GetData(string p_id)
        {
            Print_invoiceItemsList list = new Print_invoiceItemsList();
            //
            List<Upvc_invoiceitems> inv_item_list = CUpvc_invoiceitems_exten.FKId(p_id,new DAL());

            for (int r = 0; r <= inv_item_list.Count - 1; r++)
            {
                Print_invoiceitemsRow row = new Print_invoiceitemsRow();
               //
                row.INVOICE_ITEM_ID = inv_item_list[r].Upvc_invoiceitems_id;
                row.INVOICE_ID = inv_item_list[r].Upvc_invoice_id;
                row.SL_NO = (r + 1).ToString();
                row.PRODUCT_ID = inv_item_list[r].Product_id;

                row.HSN_CODE_ID = Ccoreplus.GetHsncode_name(inv_item_list[r].Product_id);

                row.QTY = ConvertTO.DecimalToS(inv_item_list[r].Qty);

                row.WIDTHS = ConvertTO.DecimalToS(inv_item_list[r].Widths);
                row.HEIGTHS = ConvertTO.DecimalToS(inv_item_list[r].Heights);
                row.AREASQ = ConvertTO.DecimalToS(inv_item_list[r].Areasq);

                row.PRICE = ConvertTO.Decimal2d(inv_item_list[r].Price);

                decimal vAmount = 0M;
                decimal vTaxableValue = 0M;

                decimal vareasq = ConvertTO.Decimal(inv_item_list[r].Areasq);
                decimal vQty = ConvertTO.Decimal(inv_item_list[r].Qty);
                decimal vPrice = ConvertTO.Decimal(inv_item_list[r].Price);

                if (inv_item_list[r].Product_id != null)
                {
                    if (CUpvc_invoice_exten.Producttype(inv_item_list[r].Product_id) == true)
                    {
                        vTaxableValue = vPrice * vQty;
                    }
                    else
                    {
                        vTaxableValue = vareasq * vPrice * vQty;
                    }
                }

                decimal vcgst_per = ConvertTO.Decimal(inv_item_list[r].Cgst_percent);
                decimal vsgst_per = ConvertTO.Decimal(inv_item_list[r].Sgst_percent);

               

                decimal vCGST = decimal.Round(((vTaxableValue * vcgst_per) / 100), 2);
                decimal vSGST = decimal.Round(((vTaxableValue * vsgst_per) / 100), 2);

                vAmount = vTaxableValue + vCGST + vSGST;

                row.TAXABLEVALUE = ConvertTO.Decimal2d(vTaxableValue.ToString());

                row.CGST_PERCENT = ConvertTO.DecimalToS(vcgst_per.ToString());

                row.CGST_AMOUNT = ConvertTO.Decimal2d(vCGST.ToString());

                row.SGST_PERCENT = ConvertTO.DecimalToS(vsgst_per.ToString());

                row.SGST_AMOUNT = ConvertTO.Decimal2d(vSGST.ToString());

                row.SUB_TOTAL = ConvertTO.Decimal2d(vAmount.ToString());
                //
                list.Add(row);
                //
            }
            //
            return list;
        }
    }//cls

    public class Print_invoiceItemsList : System.ComponentModel.BindingList<Print_invoiceitemsRow>
    {
    }

    public class Print_invoiceitemsRow
    {
		public string INVOICE_ITEM_ID { get; set; }
		public string INVOICE_ID { get; set; }
        public string SL_NO { get; set; }
        public string PRODUCT_ID { get; set; }
        public string HSN_CODE_ID { get; set; }
        public string QTY { get; set; }
        public string WIDTHS { get; set; }
        public string HEIGTHS { get; set; }
        public string AREASQ { get; set; }
        public string PRICE { get; set; }
        public string TAXABLEVALUE { get; set; }
        public string CGST_PERCENT { get; set; }
        public string CGST_AMOUNT { get; set; }
        public string SGST_PERCENT { get; set; }
        public string SGST_AMOUNT { get; set; }
        public string SUB_TOTAL { get; set; }

    }//cls


    public class PInvoiceitems
    {
        public static string INVOICE_ITEM_ID = "INVOICE_ITEM_ID";
        public static string INVOICE_ID = "INVOICE_ID";
        public static string SL_NO = "SL_NO";
        public static string PO_ID = "PO_ID";
        public static string DC_ID = "DC_ID";
        public static string PRODUCT_ID = "PRODUCT_ID";
        public static string HSN_CODE_ID = "HSN_CODE_ID";
        public static string QTY = "QTY";
        public static string WIDTHS = "WIDTHS";
        public static string HEIGTHS = "HEIGTHS";
        public static string AREASQ = "AREASQ";
        public static string PRICE = "PRICE";
        public static string TAXABLEVALUE = "TAXABLEVALUE";
        public static string SGST_PERCENT = "SGST_PERCENT";
        public static string SGST_AMOUNT = "SGST_AMOUNT";
        public static string CGST_PERCENT = "CGST_PERCENT";
        public static string CGST_AMOUNT = "CGST_AMOUNT";
        public static string SUB_TOTAL = "SUB_TOTAL";
    }



}//ns
