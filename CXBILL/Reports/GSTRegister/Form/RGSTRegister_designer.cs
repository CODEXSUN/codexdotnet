// Version : 3.0.0.0 dt : 09-02-2020
// Auto Generated
// last update : 09-02-2020 09:02:20 PM

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CXLIB;
using CXCORE;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace CXBILL
{
    public partial class RGSTRegister : CxControl
    {
        public RGSTRegister()
        {
            InitializeComponent();
            InitGrid();
            InitGrid_1();
            Month_lookup();
            list_GSTregister(action.showall);
        }

        #region[Grid]
        //
        private void InitGrid()
        {
            //Listgrid.RowAction += gridItems_RowAction;

            DataGridViewTextBoxColumn col_month = new DataGridViewTextBoxColumn();
            col_month.Name = SALES_GST.SALES_MONTH;
            col_month.HeaderText = ".";
            col_month.Width = 25;
            //col_month.Visible = false;
            col_month.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_month.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_month);

            DataGridViewTextBoxColumn col_gstin = new DataGridViewTextBoxColumn();
            col_gstin.Name = SALES_GST.GSTIN;
            col_gstin.HeaderText = "GSTIN";
            col_gstin.Width = 90;
            col_gstin.Visible = false;
            col_gstin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_gstin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_gstin);

            DataGridViewTextBoxColumn col_partyname = new DataGridViewTextBoxColumn();
            col_partyname.Name = SALES_GST.PARTY_NAME;
            col_partyname.HeaderText = "PARTY";
            col_partyname.Width = 226;
            col_partyname.ValueType = typeof(int);
            col_partyname.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_partyname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_partyname);

            DataGridViewTextBoxColumn col_no = new DataGridViewTextBoxColumn();
            col_no.Name = SALES_GST.BILL_NO;
            col_no.HeaderText = "NO";
            col_no.Width = 55;
            col_no.ValueType = typeof(int);
            col_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_no);

            DataGridViewTextBoxColumn col_date = new DataGridViewTextBoxColumn();
            col_date.Name = SALES_GST.BILL_DATE;
            col_date.HeaderText = "DATE";
            col_date.ValueType = typeof(DateTime);
            col_date.Width = 90;
            col_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_date);

            DataGridViewTextBoxColumn col_invoice_amount = new DataGridViewTextBoxColumn();
            col_invoice_amount.Name = SALES_GST.BILL_AMOUNT;
            col_invoice_amount.HeaderText = "AMOUNT";
            col_invoice_amount.ReadOnly = true;
            col_invoice_amount.Width = 110;
            col_invoice_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_invoice_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_invoice_amount);


            DataGridViewTextBoxColumn col_taxable_value = new DataGridViewTextBoxColumn();
            col_taxable_value.Name = SALES_GST.TAXABLE_VALUE;
            col_taxable_value.HeaderText = "TAXABLE_VALUE";
            col_taxable_value.Width = 90;
            col_taxable_value.Visible = false;
            col_taxable_value.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_taxable_value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_taxable_value);

            DataGridViewTextBoxColumn col_sgst_percent = new DataGridViewTextBoxColumn();
            col_sgst_percent.Name = SALES_GST.SGST_PERCENT;
            col_sgst_percent.HeaderText = "SGST_PERCENT";
            col_sgst_percent.Width = 90;
            col_sgst_percent.Visible = false;
            col_sgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_sgst_percent);

            DataGridViewTextBoxColumn col_sgst_amount = new DataGridViewTextBoxColumn();
            col_sgst_amount.Name = SALES_GST.SGST_AMOUNT;
            col_sgst_amount.HeaderText = "SGST_AMOUNT";
            col_sgst_amount.Width = 90;
            col_sgst_amount.Visible = false;
            col_sgst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sgst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_sgst_amount);

            DataGridViewTextBoxColumn col_cgst_percent = new DataGridViewTextBoxColumn();
            col_cgst_percent.Name = SALES_GST.CGST_PERCENT;
            col_cgst_percent.HeaderText = "CGST_PERCENT";
            col_cgst_percent.Width = 90;
            col_cgst_percent.Visible = false;
            col_cgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_cgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_cgst_percent);

            DataGridViewTextBoxColumn col_cgst_amount = new DataGridViewTextBoxColumn();
            col_cgst_amount.Name = SALES_GST.CGST_AMOUNT;
            col_cgst_amount.HeaderText = "CGST_AMOUNT";
            col_cgst_amount.Width = 90;
            col_cgst_amount.Visible = false;
            col_cgst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_cgst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_cgst_amount);


            DataGridViewTextBoxColumn col_igst_percent = new DataGridViewTextBoxColumn();
            col_igst_percent.Name = SALES_GST.IGST_PERCENT;
            col_igst_percent.HeaderText = "IGST_PERCENT";
            col_igst_percent.Width = 90;
            col_igst_percent.Visible = false;
            col_igst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_igst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_igst_percent);

            DataGridViewTextBoxColumn col_igst_amount = new DataGridViewTextBoxColumn();
            col_igst_amount.Name = SALES_GST.IGST_AMOUNT;
            col_igst_amount.HeaderText = "IGST_AMOUNT";
            col_igst_amount.Width = 90;
            col_igst_amount.Visible = false;
            col_igst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_igst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_igst_amount);

            DataGridViewTextBoxColumn col_gst_amount = new DataGridViewTextBoxColumn();
            col_gst_amount.Name = SALES_GST.GST_TOTAL;
            col_gst_amount.HeaderText = "GST";
            col_gst_amount.ReadOnly = true;
            col_gst_amount.Width = 110;
            col_gst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_gst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid.Columns.Add(col_gst_amount);
        }

        //void gridItems_RowAction(object sender, EventArgs e)
        //{
        //    for (int r = 0; r < Listgrid.RowCount; r++)
        //    {
        //        decimal sales = +ConvertTO.Decimal(Listgrid[SALE_GST.SALES_AMOUNT, r].Value + "0");
        //        decimal sales_gst = +ConvertTO.Decimal(Listgrid[SALE_GST.SALES_AMOUNT, r].Value + "0");

        //        txt_gst_difference.Text = (sales_gst - purchase_gst).ToString();
        //    }
        //}

        #endregion[Grid]

        #region[Grid 1]
        //
        private void InitGrid_1()
        {
            DataGridViewTextBoxColumn col_month = new DataGridViewTextBoxColumn();
            col_month.Name = PURCHASE_GST.PURCHASE_MONTH;
            col_month.HeaderText = ".";
            col_month.Width = 25;
            //col_month.Visible = false;
            col_month.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_month.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_month);

            DataGridViewTextBoxColumn col_gstin = new DataGridViewTextBoxColumn();
            col_gstin.Name = PURCHASE_GST.GSTIN;
            col_gstin.HeaderText = "GSTIN";
            col_gstin.Width = 90;
            col_gstin.Visible = false;
            col_gstin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_gstin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_gstin);

            DataGridViewTextBoxColumn col_partyname = new DataGridViewTextBoxColumn();
            col_partyname.Name = PURCHASE_GST.PARTY_NAME;
            col_partyname.HeaderText = "PARTY";
            col_partyname.Width = 218;
            col_partyname.ValueType = typeof(int);
            col_partyname.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_partyname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_partyname);

            DataGridViewTextBoxColumn col_no = new DataGridViewTextBoxColumn();
            col_no.Name = PURCHASE_GST.BILL_NO;
            col_no.HeaderText = "NO";
            col_no.Width = 65;
            col_no.ValueType = typeof(int);
            col_no.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_no.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_no);

            DataGridViewTextBoxColumn col_date = new DataGridViewTextBoxColumn();
            col_date.Name = PURCHASE_GST.BILL_DATE;
            col_date.HeaderText = "DATE";
            col_date.ValueType = typeof(DateTime);
            col_date.Width = 90;
            col_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_date);

            DataGridViewTextBoxColumn col_invoice_amount = new DataGridViewTextBoxColumn();
            col_invoice_amount.Name = PURCHASE_GST.BILL_AMOUNT;
            col_invoice_amount.HeaderText = "AMOUNT";
            col_invoice_amount.ReadOnly = true;
            col_invoice_amount.Width = 110;
            col_invoice_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_invoice_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_invoice_amount);


            DataGridViewTextBoxColumn col_taxable_value = new DataGridViewTextBoxColumn();
            col_taxable_value.Name = PURCHASE_GST.TAXABLE_VALUE;
            col_taxable_value.HeaderText = "TAXABLE_VALUE";
            col_taxable_value.Width = 90;
            col_taxable_value.Visible = false;
            col_taxable_value.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_taxable_value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_taxable_value);

            DataGridViewTextBoxColumn col_sgst_percent = new DataGridViewTextBoxColumn();
            col_sgst_percent.Name = PURCHASE_GST.SGST_PERCENT;
            col_sgst_percent.HeaderText = "SGST_PERCENT";
            col_sgst_percent.Width = 90;
            col_sgst_percent.Visible = false;
            col_sgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_sgst_percent);

            DataGridViewTextBoxColumn col_sgst_amount = new DataGridViewTextBoxColumn();
            col_sgst_amount.Name = PURCHASE_GST.SGST_AMOUNT;
            col_sgst_amount.HeaderText = "SGST_AMOUNT";
            col_sgst_amount.Width = 90;
            col_sgst_amount.Visible = false;
            col_sgst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sgst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_sgst_amount);

            DataGridViewTextBoxColumn col_cgst_percent = new DataGridViewTextBoxColumn();
            col_cgst_percent.Name = PURCHASE_GST.CGST_PERCENT;
            col_cgst_percent.HeaderText = "CGST_PERCENT";
            col_cgst_percent.Width = 90;
            col_cgst_percent.Visible = false;
            col_cgst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_cgst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_cgst_percent);

            DataGridViewTextBoxColumn col_cgst_amount = new DataGridViewTextBoxColumn();
            col_cgst_amount.Name = PURCHASE_GST.CGST_AMOUNT;
            col_cgst_amount.HeaderText = "CGST_AMOUNT";
            col_cgst_amount.Width = 90;
            col_cgst_amount.Visible = false;
            col_cgst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_cgst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_cgst_amount);


            DataGridViewTextBoxColumn col_igst_percent = new DataGridViewTextBoxColumn();
            col_igst_percent.Name = PURCHASE_GST.IGST_PERCENT;
            col_igst_percent.HeaderText = "IGST_PERCENT";
            col_igst_percent.Width = 90;
            col_igst_percent.Visible = false;
            col_igst_percent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_igst_percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_igst_percent);

            DataGridViewTextBoxColumn col_igst_amount = new DataGridViewTextBoxColumn();
            col_igst_amount.Name = PURCHASE_GST.IGST_AMOUNT;
            col_igst_amount.HeaderText = "IGST_AMOUNT";
            col_igst_amount.Width = 90;
            col_igst_amount.Visible = false;
            col_igst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_igst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_igst_amount);

            DataGridViewTextBoxColumn col_gst_amount = new DataGridViewTextBoxColumn();
            col_gst_amount.Name = PURCHASE_GST.GST_TOTAL;
            col_gst_amount.HeaderText = "GST";
            col_gst_amount.ReadOnly = true;
            col_gst_amount.Width = 110;
            col_gst_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_gst_amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Listgrid_1.Columns.Add(col_gst_amount);
        }

        #endregion[Grid 1]

        #region[Btn event]
        //
        private void Btn_search_Click(object sender, EventArgs e)
        {
            if ((Txt_month.Text != "") && (Txt_month.Text != null))
            {
                list_GSTregister(action.showall);
            }
        }

        private void Btn_print_sales_Click(object sender, EventArgs e)
        {
            FReportPreview frpt = new FReportPreview();

            LocalReport localReport = frpt.reportViewer1.LocalReport;

            List<Sales_Gst> SALES_DS = CollectSales();

            localReport.ReportPath = Application.StartupPath + @"\Reports\Sales_GST.rdlc"; //(1)//
            localReport.DisplayName = "Sales GST Report";

            localReport.DataSources.Add(new ReportDataSource("SALES_GST_DS", SALES_DS)); //(2)//


            PrinterSettings v_PrinterSettings = new PrinterSettings();
            PaperSize vUPaperSize = new PaperSize("User Defined Paper Size", 827, 1166);
            v_PrinterSettings.DefaultPageSettings.PaperSize = vUPaperSize;
            v_PrinterSettings.DefaultPageSettings.Landscape = true;
            v_PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;

            frpt.reportViewer1.PrinterSettings = v_PrinterSettings;

            frpt.reportViewer1.ShowPrintButton = true;
            frpt.reportViewer1.SetPageSettings(v_PrinterSettings.DefaultPageSettings);
            frpt.reportViewer1.RefreshReport();
            frpt.Show();

        }


        private void Btn_print_purchase_Click(object sender, EventArgs e)
        {

            FReportPreview frpt = new FReportPreview();

            LocalReport localReport = frpt.reportViewer1.LocalReport;

            List<Purchase_Gst> PURCHASE_DS = CollectPurchase();

            localReport.ReportPath = Application.StartupPath + @"\Reports\Purchase_GST.rdlc"; //(1)//
            localReport.DisplayName = "Purchase GST Report";

            localReport.DataSources.Add(new ReportDataSource("PURCHASE_GST_DS", PURCHASE_DS)); //(2)//


            PrinterSettings v_PrinterSettings = new PrinterSettings();
            PaperSize vUPaperSize = new PaperSize("User Defined Paper Size", 827, 1166);
            v_PrinterSettings.DefaultPageSettings.PaperSize = vUPaperSize;
            v_PrinterSettings.DefaultPageSettings.Landscape = true;
            v_PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            v_PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;

            frpt.reportViewer1.PrinterSettings = v_PrinterSettings;

            frpt.reportViewer1.ShowPrintButton = true;
            frpt.reportViewer1.SetPageSettings(v_PrinterSettings.DefaultPageSettings);
            frpt.reportViewer1.RefreshReport();
            frpt.Show();


        }



        private void Btn_close_Click(object sender, EventArgs e)
        {
            RaiseEvent_NeedToRefresh();
            Hide();
        }
        //
        #endregion[Btn event]

        #region[Need to refresh]

        private void From_Datepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_from_date.Text = ConvertTO.Date2S(from_Datepicker.Value.ToString());
            list_GSTregister(action.showall);
        }

        private void To_Datepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_to_date.Text = ConvertTO.Date2S(to_Datepicker.Value.ToString());
            list_GSTregister(action.showall);
        }

        #endregion[Need to refresh]

        private void Retotal_Click(object sender, EventArgs e)
        {
            decimal sales = 0M, sales_gst = 0M, purchase = 0M, purchase_gst = 0M;
            for (int r = 0; r < Listgrid.RowCount; r++)
            {
                sales += ConvertTO.Decimal(Listgrid[SALES_GST.BILL_AMOUNT, r].Value + "0");
                sales_gst += ConvertTO.Decimal(Listgrid[SALES_GST.GST_TOTAL, r].Value + "0");
            }

            for (int k = 0; k < Listgrid_1.RowCount; k++)
            {
                purchase += ConvertTO.Decimal(Listgrid_1[PURCHASE_GST.BILL_AMOUNT, k].Value + "0");
                purchase_gst += ConvertTO.Decimal(Listgrid_1[PURCHASE_GST.GST_TOTAL, k].Value + "0");
            }

            txt_sales_total.Text = ConvertTO.Decimal2d(sales.ToString());
            txt_purchase_total.Text = ConvertTO.Decimal2d(purchase.ToString());
            txt_Sales_gst_total.Text = ConvertTO.Decimal2d(sales_gst.ToString());
            txt_purchase_gst_total.Text = ConvertTO.Decimal2d(purchase_gst.ToString());

            txt_difference.Text = ConvertTO.Decimal2d((sales - purchase).ToString());
            txt_gst_difference.Text = ConvertTO.Decimal2d((sales_gst - purchase_gst).ToString());
        }

        private List<Sales_Gst> CollectSales()
        {
            List<Sales_Gst> list = new List<Sales_Gst>();

            for (int r = 0; r < Listgrid.RowCount; r++)
            {
                Sales_Gst obj = new Sales_Gst()
                {
                    Company_name = Current.Company_Name,
                    Acy_name = Current.Acy_Name,
                    Sales_Month = Txt_month.Text.ToString(),
                    Gstin = Listgrid[SALES_GST.GSTIN, r].Value + "",
                    Party_name = Listgrid[SALES_GST.PARTY_NAME, r].Value + "",
                    Bill_no = Listgrid[SALES_GST.BILL_NO, r].Value + "",
                    Bill_date = Listgrid[SALES_GST.BILL_DATE, r].Value + "",
                    Bill_amount = ConvertTO.Decimal("0" + (Listgrid[SALES_GST.BILL_AMOUNT, r].Value)),
                    Taxable_value = ConvertTO.Decimal("0" + (Listgrid[SALES_GST.TAXABLE_VALUE, r].Value)),
                    Sgst_percent = Listgrid[SALES_GST.SGST_PERCENT, r].Value + "",
                    Sgst_amount = ConvertTO.Decimal("0" + (Listgrid[SALES_GST.SGST_AMOUNT, r].Value)),
                    Cgst_percent = Listgrid[SALES_GST.CGST_PERCENT, r].Value + "",
                    Cgst_amount = ConvertTO.Decimal("0" + (Listgrid[SALES_GST.CGST_AMOUNT, r].Value)),
                    Igst_percent = Listgrid[SALES_GST.IGST_PERCENT, r].Value + "",
                    Igst_amount = ConvertTO.Decimal("0" + (Listgrid[SALES_GST.IGST_AMOUNT, r].Value)),
                    Gst_total = ConvertTO.Decimal("0" + (Listgrid[SALES_GST.GST_TOTAL, r].Value))
                };
                list.Add(obj);
            }
            return list;
        }

        private List<Purchase_Gst> CollectPurchase()
        {
            List<Purchase_Gst> list = new List<Purchase_Gst>();

            for (int k = 0; k < Listgrid_1.RowCount; k++)
            {

                Purchase_Gst obj = new Purchase_Gst()
                {
                    Company_name = Current.Company_Name,
                    Acy_name = Current.Acy_Name,
                    Purchase_Month = Txt_month.Text.ToString(),
                    Gstin = Listgrid_1[PURCHASE_GST.GSTIN, k].Value + "",
                    Party_name = Listgrid_1[PURCHASE_GST.PARTY_NAME, k].Value + "",
                    Bill_no = Listgrid_1[PURCHASE_GST.BILL_NO, k].Value + "",
                    Bill_date = Listgrid_1[PURCHASE_GST.BILL_DATE, k].Value + "",
                    Bill_amount = ConvertTO.Decimal("0" + Listgrid_1[PURCHASE_GST.BILL_AMOUNT, k].Value),
                    Taxable_value = ConvertTO.Decimal("0" + Listgrid_1[PURCHASE_GST.TAXABLE_VALUE, k].Value),
                    Sgst_percent = Listgrid_1[PURCHASE_GST.SGST_PERCENT, k].Value + "",
                    Sgst_amount = ConvertTO.Decimal("0" + Listgrid_1[PURCHASE_GST.SGST_AMOUNT, k].Value),
                    Cgst_percent = Listgrid_1[PURCHASE_GST.CGST_PERCENT, k].Value + "",
                    Cgst_amount = ConvertTO.Decimal("0" + Listgrid_1[PURCHASE_GST.CGST_AMOUNT, k].Value),
                    Igst_percent = Listgrid_1[PURCHASE_GST.IGST_PERCENT, k].Value + "",
                    Igst_amount = ConvertTO.Decimal("0" + Listgrid_1[PURCHASE_GST.IGST_AMOUNT, k].Value),
                    Gst_total = ConvertTO.Decimal("0" + Listgrid_1[PURCHASE_GST.GST_TOTAL, k].Value)
                };

                list.Add(obj);
            }

            return list;
        }

    }//cls 
}//ns 
