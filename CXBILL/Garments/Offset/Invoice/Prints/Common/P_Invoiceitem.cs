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
            List<Offset_invoiceitems> inv_item_list = new List<Offset_invoiceitems>();

            //if (Customise.Invoice_poid_dcid == true)
            //{
                inv_item_list = COffset_invoiceitems_exten.FKId(p_id, new DAL());
            //}

            //if ((Customise.Invoice_pono_dcno == true) || (Customise.Invoice_Without_podc == true))
            //{
            //    inv_item_list = COffset_invoiceitems_exten.FKNo(p_id, new DAL());
            //}

            for (int r = 0; r <= inv_item_list.Count - 1; r++)
            {
                Print_invoiceitemsRow row = new Print_invoiceitemsRow();
                //
                row.INVOICE_ITEM_ID = inv_item_list[r].Offset_invoiceitems_id;
                row.INVOICE_ID = inv_item_list[r].Offset_invoice_id;
                row.SL_NO = (r + 1).ToString();

                if (inv_item_list[r].Offset_po_id == "Without Po")
                {
                    row.PO_ID = "";
                }
                else
                {
                    row.PO_ID = inv_item_list[r].Offset_po_id;
                }


                if (inv_item_list[r].Offset_dc_id == "0")
                {
                    row.DC_ID = "";
                }
                else
                {
                    row.DC_ID = inv_item_list[r].Offset_dc_id;
                }

                row.PRODUCT_ID = inv_item_list[r].Product_id;

                row.HSN_CODE_ID = Ccoreplus.GetHsncode_name(inv_item_list[r].Product_id);

                row.QTY = ConvertTO.DecimalToS(inv_item_list[r].Qty);
                row.PRICE = ConvertTO.Decimal2d(inv_item_list[r].Price.ToString());

                decimal vAmount = 0M;
                decimal vTaxableValue = 0M;

                decimal vQty = Global.ToDecimal(row.QTY);
                decimal vPrice = Global.ToDecimal(row.PRICE);

                decimal vcgst_per = Global.ToDecimal(inv_item_list[r].Cgst_percent);
                decimal vsgst_per = Global.ToDecimal(inv_item_list[r].Sgst_percent);
                decimal vigst_per = Global.ToDecimal(inv_item_list[r].Igst_percent);

                vTaxableValue = vQty * vPrice;

                decimal vCGST = decimal.Round(((vTaxableValue * vcgst_per) / 100), 2);
                decimal vSGST = decimal.Round(((vTaxableValue * vsgst_per) / 100), 2);
                decimal vIGST = decimal.Round(((vTaxableValue * vigst_per) / 100), 2);

                vAmount = vTaxableValue + vCGST + vSGST + vIGST;

                row.TAXABLEVALUE = ConvertTO.Decimal2d(vTaxableValue.ToString());

                row.CGST_PERCENT = ConvertTO.DecimalToS(vcgst_per.ToString());

                row.CGST_AMOUNT = ConvertTO.Decimal2d(vCGST.ToString());

                row.SGST_PERCENT = ConvertTO.DecimalToS(vsgst_per.ToString());

                row.SGST_AMOUNT = ConvertTO.Decimal2d(vSGST.ToString());

                row.IGST_PERCENT = ConvertTO.DecimalToS(vigst_per.ToString());

                row.IGST_AMOUNT = ConvertTO.Decimal2d(vIGST.ToString());

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
        public string PO_ID { get; set; }
        public string DC_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string HSN_CODE_ID { get; set; }
        public string QTY { get; set; }
        public string PRICE { get; set; }
        public string SUB_TOTAL { get; set; }
        public string TAXABLEVALUE { get; set; }
        public string SGST_PERCENT { get; set; }
        public string SGST_AMOUNT { get; set; }
        public string CGST_PERCENT { get; set; }
        public string CGST_AMOUNT { get; set; }
        public string IGST_PERCENT { get; set; }
        public string IGST_AMOUNT { get; set; }

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
        public static string PRICE = "PRICE";
        public static string SUB_TOTAL = "SUB_TOTAL";
        public static string TAXABLEVALUE = "TAXABLEVALUE";
        public static string SGST_PERCENT = "SGST_PERCENT";
        public static string SGST_AMOUNT = "SGST_AMOUNT";
        public static string CGST_PERCENT = "CGST_PERCENT";
        public static string CGST_AMOUNT = "CGST_AMOUNT";
        public static string IGST_PERCENT = "IGST_PERCENT";
        public static string IGST_AMOUNT = "IGST_AMOUNT";
    }



}//ns
