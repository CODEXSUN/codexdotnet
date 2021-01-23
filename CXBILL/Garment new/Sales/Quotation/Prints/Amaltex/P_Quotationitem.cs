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
    public class P_QuotationItem
    {
        public static void Print(ReportViewer pRptViewer, string p_id)
        {
            Print_quotationItemsList data = GetData(p_id);

            LocalReport localReport = pRptViewer.LocalReport;

            //= Set Report Path
            localReport.ReportPath = Application.StartupPath + @"\PRINTS\P_QuotationItem.rdlc"; //(1)//
            localReport.DisplayName = "quotation items";

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

            //vPrnSet.PrinterName = this.PrinterName;
            PaperSize vUPaperSize = new PaperSize("User Defined Paper Size", 827, 583);
            v_PrinterSettings.DefaultPageSettings.PaperSize = vUPaperSize;
            v_PrinterSettings.DefaultPageSettings.Landscape = false;
            v_PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;

            return v_PrinterSettings;
        }

        public static Print_quotationItemsList GetData(string p_id)
        {
            Print_quotationItemsList list = new Print_quotationItemsList();
            //
            List<Quotationitems> inv_item_list = new List<Quotationitems>();

            //if (Customise.Invoice_poid_dcid == true)
            //{
            //    inv_item_list = CQuotationitems_exten.FKId(p_id, new DAL());
            //}

            //if ((Customise.Invoice_pono_dcno == true) || (Customise.Invoice_Without_podc == true))
            //{
                inv_item_list = CQuotationitems_exten.FKNo(p_id, new DAL());
            //}

            for (int r = 0; r <= inv_item_list.Count - 1; r++)
            {
                Print_quotationitemsRow row = new Print_quotationitemsRow();
                //
                row.QUOTATION_ITEM_ID = inv_item_list[r].Quotationitems_id;
                row.QUOTATION_ID = inv_item_list[r].Quotation_id;
                row.SL_NO = (r + 1).ToString();

                row.PRODUCT_ID = Checks.RemoveEscape(inv_item_list[r].Product_id);

                row.HSN_CODE_ID = Ccoreplus.GetHsncode_name(inv_item_list[r].Product_id);


                row.SIZES_ID = inv_item_list[r].Sizes_id;

                row.QTY = ConvertTO.DecimalToS(inv_item_list[r].Qty);

                row.PRICE = ConvertTO.Decimal2d(inv_item_list[r].Price.ToString());

                decimal vAmount = 0M;
                decimal vTaxableValue = 0M;

                decimal vQty = Global.ToDecimal(row.QTY);
                decimal vPrice = Global.ToDecimal(row.PRICE);


                vTaxableValue = vQty * vPrice;

                vAmount = vTaxableValue;

                row.TAXABLEVALUE = ConvertTO.Decimal2d(vTaxableValue.ToString());



                row.SUB_TOTAL = ConvertTO.Decimal2d(vAmount.ToString());
                //
                list.Add(row);
                //
            }
            //
            return list;
        }
    }//cls

    public class Print_quotationItemsList : System.ComponentModel.BindingList<Print_quotationitemsRow>
    {
    }

    public class Print_quotationitemsRow
    {
        public string QUOTATION_ITEM_ID { get; set; }
        public string QUOTATION_ID { get; set; }
        public string SL_NO { get; set; }
        public string PO_ID { get; set; }
        public string DC_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string SIZES_ID { get; set; }
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


    public class PQuotationitems
    {
        public static string QUOTATION_ITEM_ID = "QUOTATION_ITEM_ID";
        public static string QUOTATION_ID = "QUOTATION_ID";
        public static string SL_NO = "SL_NO";
        public static string PO_ID = "PO_ID";
        public static string DC_ID = "DC_ID";
        public static string PRODUCT_ID = "PRODUCT_ID";
        public static string SIZES_ID = "SIZES_ID";
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
