﻿// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using CXLIB;
using System.Drawing;

namespace CXOFFSET
{
    public class D_InvoiceItem
    {
        public static string PRINT_FOLDER = "PRINTS";

        private static double RPT_WIDTH = 7.5, RPT_HEIGHT = 10.0;

        public static void Build()
        {
            ReportBuilder rptbuild = new ReportBuilder();
            ReportType vReport = rptbuild.Report;
            BodyType vBody = vReport.Body;

            // double x = 0, y = 0, wd = 0 , ht = 0;

            vReport.Width.Value = RPT_WIDTH;
            vBody.Height.Value = RPT_HEIGHT;

            DataSetType dataSet = rptbuild.Report.DataSets[0];
            dataSet.Name = "MyDataSource_Items";

            ReportUtil.AddFields(dataSet.Fields, new string[] {

                PInvoiceitems.INVOICE_ITEM_ID
                ,PInvoiceitems.INVOICE_ID
                ,PInvoiceitems.SL_NO
                ,PInvoiceitems.PO_ID
                ,PInvoiceitems.DC_ID
                ,PInvoiceitems.PRODUCT_ID
                 ,PInvoiceitems.HSN_CODE_ID
                ,PInvoiceitems.QTY
                ,PInvoiceitems.PRICE
                ,PInvoiceitems.SUB_TOTAL
                ,PInvoiceitems.TAXABLEVALUE
                ,PInvoiceitems.CGST_PERCENT
                ,PInvoiceitems.CGST_AMOUNT
                ,PInvoiceitems.SGST_PERCENT
                ,PInvoiceitems.SGST_AMOUNT
                        });



            BuildDetail(vBody);

            ///== END OF REPORT  ===========================================================================///
            rptbuild.SaveAs(PRINT_FOLDER + @"\P_InvoiceItem.rdlc");
        }

        private static void BuildDetail(BodyType rectWarper)
        {
            double x = 0, y = 0, wd = 0, ht = 0;
            string sufx = ""; /*Now unused. Used before in A4 (i.e 2xA5) print*/
                              //
            x = 0; y = 0; wd = 7.5; ht = 0.1;
            RectangleType subrect = ReportUtil.AddRectangle("manirect" + sufx, rectWarper.ReportItems, x, y, wd, ht);
            subrect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //subrect.Style.BackgroundColor.Color = Color.Red;
            //
            #region [HEADING AREA]
            //
            x = 0; y = 0; wd = subrect.Width.Value; ht = 0.3;
            RectangleType heading = ReportUtil.AddRectangle("heading" + sufx, subrect.ReportItems, x, y, wd, ht);
            heading.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //heading.Style.BackgroundColor.Color = Color.Orange;

            x = 6.08; y = 0; wd = 0.03; ht = 0.3;
            RectangleType heading_line = ReportUtil.AddRectangle("heading_line" + sufx, subrect.ReportItems, x, y, wd, ht);
            heading_line.Style.BorderStyle.Default = BorderStyleEnum.None;
            heading_line.Style.BorderStyle.Left = BorderStyleEnum.Outset;
            //heading_line.Style.BackgroundColor.Color = Color.Orange;
            //
            #endregion [HEADING AREA]
            //
            #region [Lines AREA]
            //
            x = 0; y = 0; wd = 0.23; ht = 5;
            RectangleType slno = ReportUtil.AddRectangle("slno" + sufx, subrect.ReportItems, x, y, wd, ht);
            slno.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //slno.Style.BackgroundColor.Color = Color.MistyRose;
            //
            x = slno.Width.Value; y = 0; wd = 0.5; ht = ht + 0;
            RectangleType po = ReportUtil.AddRectangle("po" + sufx, subrect.ReportItems, x, y, wd, ht);
            po.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //po.Style.BackgroundColor.Color = Color.Green;
            //
            x = x + po.Width.Value; y = 0; wd = 0.5; ht = ht + 0;
            RectangleType dc = ReportUtil.AddRectangle("dc" + sufx, subrect.ReportItems, x, y, wd, ht);
            dc.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //dc.Style.BackgroundColor.Color = Color.Blue;
            //
            x = x + dc.Width.Value; y = 0; wd = 2; ht = ht + 0;
            RectangleType particulars = ReportUtil.AddRectangle("particulars" + sufx, subrect.ReportItems, x, y, wd, ht);
            particulars.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //particulars.Style.BackgroundColor.Color = Color.FloralWhite;
            //
            x = x + particulars.Width.Value; y = 0; wd = 0.5; ht = ht + 0;
            RectangleType hsn_code = ReportUtil.AddRectangle("hsn_code" + sufx, subrect.ReportItems, x, y, wd, ht);
            hsn_code.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            // hsn_code.Style.BackgroundColor.Color = Color.Chocolate;
            //
            x = x + hsn_code.Width.Value; y = 0; wd = 0.6; ht = ht + 0;
            RectangleType qtys = ReportUtil.AddRectangle("qtys" + sufx, subrect.ReportItems, x, y, wd, ht);
            qtys.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //qtys.Style.BackgroundColor.Color = Color.SaddleBrown;
            //
            x = x + qtys.Width.Value; y = 0; wd = 0.45; ht = ht + 0;
            RectangleType price = ReportUtil.AddRectangle("price" + sufx, subrect.ReportItems, x, y, wd, ht);
            price.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //price.Style.BackgroundColor.Color = Color.Aquamarine;
            //
            x = x + price.Width.Value; y = 0; wd = 0.6; ht = ht + 0;
            RectangleType taxableamt = ReportUtil.AddRectangle("taxableamt" + sufx, subrect.ReportItems, x, y, wd, ht);
            taxableamt.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //amount.Style.BackgroundColor.Color = Color.Green;
            //
            x = x + taxableamt.Width.Value; y = 0.3; wd = 0.2; ht = ht - 0.3;
            RectangleType sgst_per = ReportUtil.AddRectangle("sgst_per" + sufx, subrect.ReportItems, x, y, wd, ht);
            sgst_per.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //sgst_per.Style.BackgroundColor.Color = Color.Firebrick;

            x = x + sgst_per.Width.Value; y = 0.3; wd = 0.5; ht = ht + 0;
            RectangleType sgst_amt = ReportUtil.AddRectangle("sgst_amt" + sufx, subrect.ReportItems, x, y, wd, ht);
            sgst_amt.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //sgst_amt.Style.BackgroundColor.Color = Color.DodgerBlue;

            x = x + sgst_amt.Width.Value; y = 0.3; wd = 0.2; ht = ht + 0;
            RectangleType cgst_per = ReportUtil.AddRectangle("cgst_per" + sufx, subrect.ReportItems, x, y, wd, ht);
            cgst_per.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //cgst_per.Style.BackgroundColor.Color = Color.DarkGoldenrod;

            x = x + cgst_per.Width.Value; y = 0.3; wd = 0.5; ht = ht + 0;
            RectangleType cgst_amt = ReportUtil.AddRectangle("cgst_amt" + sufx, subrect.ReportItems, x, y, wd, ht);
            cgst_amt.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            // cgst_amt.Style.BackgroundColor.Color = Color.Yellow;

            x = x + cgst_amt.Width.Value; y = 0; wd = 0.72; ht = ht + 0.3;
            RectangleType Totalv = ReportUtil.AddRectangle("Totalv" + sufx, subrect.ReportItems, x, y, wd, ht);
            Totalv.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //Totalv.Style.BackgroundColor.Color = Color.Blue;

            #endregion [Lines AREA]
            //
            #region [Header ]
            ///
            x = slno.Left.Value + 0.01; y = 0.09; wd = slno.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_slno = ReportUtil.AddTextbox("lbl_slno" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_slno.Value = "S.No";
            lbl_slno.Style.Font("Calibri", 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_slno.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_slno.Style.BackgroundColor.Color = Color.Salmon;
            ///
            x = po.Left.Value + 0.01; y = y + 0; wd = po.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_po_no = ReportUtil.AddTextbox("lbl_po_no" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_po_no.Value = "PO.No";
            lbl_po_no.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_po_no.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_po_no.Style.BackgroundColor.Color = Color.SeaGreen;
            //
            x = dc.Left.Value + 0.01; y = y + 0; wd = dc.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_dc_no = ReportUtil.AddTextbox("lbl_dc_no" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_dc_no.Value = "DC.No";
            lbl_dc_no.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_dc_no.Style.TextAlign = TextAlignRptEnum.Center;
            // lbl_dc_no.Style.BackgroundColor.Color = Color.Bisque;

            x = particulars.Left.Value + 0.11; y = y + 0; wd = particulars.Width.Value - 0.13; ht = 0.16;
            TextboxType lbl_particulars = ReportUtil.AddTextbox("lbl_particulars" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_particulars.Value = "Particulars";
            lbl_particulars.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_particulars.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_particulars.Style.BackgroundColor.Color = Color.SteelBlue;

            x = hsn_code.Left.Value + 0.05; y = y + 0; wd = hsn_code.Width.Value - 0.08; ht = 0.16;
            TextboxType lbl_hsn_code = ReportUtil.AddTextbox("lbl_hsn_code" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_hsn_code.Value = "HSN Code";
            lbl_hsn_code.Style.Font("Calibri", 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_hsn_code.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_hsn_code.Style.BackgroundColor.Color = Color.Blue;

            x = qtys.Left.Value + 0.01; y = y + 0; wd = qtys.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_qty = ReportUtil.AddTextbox("lbl_qty" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_qty.Value = "Quantity";
            lbl_qty.Style.Font("Calibri", 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_qty.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_qty.Style.BackgroundColor.Color = Color.DimGray;
            ///
            x = price.Left.Value + 0.01; y = y + 0; wd = price.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_price = ReportUtil.AddTextbox("lbl_price" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_price.Value = "Price";
            lbl_price.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_price.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_price.Style.BackgroundColor.Color = Color.Coral;
            ///
            x = taxableamt.Left.Value + 0.01; y = y + 0; wd = taxableamt.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_taxableamt = ReportUtil.AddTextbox("lbl_taxableamt" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_taxableamt.Value = "Taxable Amt";
            lbl_taxableamt.Style.Font("Calibri", 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_taxableamt.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_taxableamt.Style.BackgroundColor.Color = Color.Wheat;

            x = sgst_per.Left.Value + 0.01; y = 0.02; wd = sgst_per.Width.Value + sgst_amt.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_sgst = ReportUtil.AddTextbox("lbl_sgst" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_sgst.Value = "SGST";
            lbl_sgst.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_sgst.Style.TextAlign = TextAlignRptEnum.Center;
            // lbl_sgst.Style.BackgroundColor.Color = Color.Violet;

            x = sgst_per.Left.Value + 0.03; y = y + 0.1; wd = sgst_per.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_sgst_per = ReportUtil.AddTextbox("lbl_sgst_per" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_sgst_per.Value = "%";
            lbl_sgst_per.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_sgst_per.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_sgst_per.Style.BackgroundColor.Color = Color.Aquamarine;

            x = sgst_amt.Left.Value + 0.01; y = y + 0; wd = sgst_amt.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_sgst_amt = ReportUtil.AddTextbox("lbl_sgst_amt" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_sgst_amt.Value = "Amt";
            lbl_sgst_amt.Style.Font("Calibri", 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_sgst_amt.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_sgst_amt.Style.BackgroundColor.Color = Color.DimGray;

            x = cgst_per.Left.Value + 0.01; y = 0.02; wd = cgst_per.Width.Value + cgst_amt.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_cgst = ReportUtil.AddTextbox("lbl_cgst" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_cgst.Value = "CGST";
            lbl_cgst.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_cgst.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_cgst.Style.BackgroundColor.Color = Color.Cyan;

            x = cgst_per.Left.Value + 0.03; y = y + 0.1; wd = cgst_per.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_cgst_per = ReportUtil.AddTextbox("lbl_cgst_per" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_cgst_per.Value = "%";
            lbl_cgst_per.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_cgst_per.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_cgst_per.Style.BackgroundColor.Color = Color.Goldenrod;

            x = cgst_amt.Left.Value + 0.02; y = y + 0; wd = cgst_amt.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_cgst_amt = ReportUtil.AddTextbox("lbl_cgst_amt" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_cgst_amt.Value = "Amt";
            lbl_cgst_amt.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_cgst_amt.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_cgst_amt.Style.BackgroundColor.Color = Color.Khaki;

            x = Totalv.Left.Value + 0.06; y = y + 0; wd = Totalv.Width.Value - 0.09; ht = 0.16;
            TextboxType lbl_Totalv = ReportUtil.AddTextbox("lbl_Totalv" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_Totalv.Value = "Sub Total";
            lbl_Totalv.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_Totalv.Style.TextAlign = TextAlignRptEnum.Center;
            // lbl_Totalv.Style.BackgroundColor.Color = Color.DodgerBlue;

            #endregion [Header]
            //
            #region [ Detail-Line ]
            //
            x = 0; y = 0.4; wd = subrect.Width.Value; ht = 0.03;
            ListType listDetlLine = ReportUtil.AddList("listDetlLine" + sufx, subrect.ReportItems, x, y, wd, ht);
            listDetlLine.DataSetName = "MyDataSource_Items";
            listDetlLine.Grouping = new GroupingType("group_" + PInvoiceitems.SL_NO + "");
            listDetlLine.Grouping.GroupExpressions.Add("=Fields!" + PInvoiceitems.SL_NO + ".Value");
            //listDetlLine.Style.BackgroundColor.Color = Color.Red;
            //
            x = 0; y = 0; wd = 0.55; ht = 0.25;
            RectangleType listdetails_rect = ReportUtil.AddRectangle("listdetails_rect" + sufx, listDetlLine.ReportItems, x, y, wd, ht);
            listdetails_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //listdetails_rect.Style.BackgroundColor.Color = Color.Azure;
            //
            x = slno.Left.Value + 0.01; y = 0; wd = slno.Width.Value - 0.03; ht = ht + 0;
            TextboxType txt_slno = ReportUtil.AddTextbox("txt_slno" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_slno.Value = "=Fields!" + PInvoiceitems.SL_NO + ".Value";
            txt_slno.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_slno.Style.TextAlign = TextAlignRptEnum.Center;

            //  txt_slno.Style.BackgroundColor.Color = Color.Red;
            //
            x = po.Left.Value + 0.01; y = 0; wd = po.Width.Value - 0.03; ht = ht + 0;
            TextboxType txt_po_no = ReportUtil.AddTextbox("txt_po_no" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_po_no.Value = "=Fields!" + PInvoiceitems.PO_ID + ".Value";
            txt_po_no.Style.TextAlign = TextAlignRptEnum.Center;
            txt_po_no.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
            //
            x = dc.Left.Value + 0.01; y = 0; wd = dc.Width.Value - 0.03; ht = ht + 0;
            TextboxType txt_dc_no = ReportUtil.AddTextbox("txt_dc_no" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_dc_no.Value = "=Fields!" + PInvoiceitems.DC_ID + ".Value";
            txt_dc_no.Style.TextAlign = TextAlignRptEnum.Center;
            txt_dc_no.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //  txt_dc_no.Style.BackgroundColor.Color = Color.Red;
            //
            x = particulars.Left.Value + 0.05; y = 0; wd = particulars.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_product_name = ReportUtil.AddTextbox("txt_product_name" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_product_name.Value = "=Fields!" + PInvoiceitems.PRODUCT_ID + ".Value";
            txt_product_name.Style.TextAlign = TextAlignRptEnum.Left;
            txt_product_name.CanGrow = true;
            txt_product_name.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //txt_product_name.Style.BackgroundColor.Color = Color.Red;

            x = hsn_code.Left.Value + 0.08; y = 0; wd = hsn_code.Width.Value - 0.08; ht = ht + 0;
            TextboxType txt_hsn_code = ReportUtil.AddTextbox("txt_hsn_code" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_hsn_code.Value = "=Fields!HSN_CODE_ID.Value";
            txt_hsn_code.Style.TextAlign = TextAlignRptEnum.Left;
            txt_hsn_code.Style.Font("Tahoma", 6, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //txt_product_name.Style.BackgroundColor.Color = Color.Red;
            //
            x = qtys.Left.Value + 0.02; y = 0; wd = qtys.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_qty = ReportUtil.AddTextbox("txt_qty" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_qty.Value = "=Fields!" + PInvoiceitems.QTY + ".Value";
            txt_qty.Style.TextAlign = TextAlignRptEnum.Center;
            txt_qty.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_qty.Style.BackgroundColor.Color = Color.Red;
            //
            x = price.Left.Value + 0.02; y = 0; wd = price.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_price = ReportUtil.AddTextbox("txt_price" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_price.Value = "=Fields!" + PInvoiceitems.PRICE + ".Value";
            txt_price.Style.TextAlign = TextAlignRptEnum.Right;
            txt_price.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);
            //txt_price.Style.BackgroundColor.Color = Color.Red;


            x = taxableamt.Left.Value + 0.01; y = 0; wd = taxableamt.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_taxable = ReportUtil.AddTextbox("txt_taxable" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_taxable.Value = "=Fields!" + PInvoiceitems.TAXABLEVALUE + ".Value";
            txt_taxable.Style.TextAlign = TextAlignRptEnum.Right;
            txt_taxable.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_taxable.Style.BackgroundColor.Color = Color.Red;



            x = sgst_per.Left.Value + 0.01; y = 0; wd = sgst_per.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_sgst_per = ReportUtil.AddTextbox("txt_sgst_per" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_sgst_per.Value = "=Fields!" + PInvoiceitems.SGST_PERCENT + ".Value";
            txt_sgst_per.Style.TextAlign = TextAlignRptEnum.Center;
            txt_sgst_per.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_sgst_per.Style.BackgroundColor.Color = Color.Red;


            x = sgst_amt.Left.Value + 0.01; y = 0; wd = sgst_amt.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_sgst_amt = ReportUtil.AddTextbox("txt_sgst_amt" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_sgst_amt.Value = "=Fields!" + PInvoiceitems.SGST_AMOUNT + ".Value";
            txt_sgst_amt.Style.TextAlign = TextAlignRptEnum.Right;
            txt_sgst_amt.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_sgst_amt.Style.BackgroundColor.Color = Color.Red;


            x = cgst_per.Left.Value + 0.01; y = 0; wd = cgst_per.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_cgst_per = ReportUtil.AddTextbox("txt_cgst_per" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_cgst_per.Value = "=Fields!" + PInvoiceitems.CGST_PERCENT + ".Value";
            txt_cgst_per.Style.TextAlign = TextAlignRptEnum.Center;
            txt_cgst_per.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_cgst_per.Style.BackgroundColor.Color = Color.Red;


            x = cgst_amt.Left.Value + 0.01; y = 0; wd = cgst_amt.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_cgst_amt = ReportUtil.AddTextbox("txt_cgst_amt" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_cgst_amt.Value = "=Fields!" + PInvoiceitems.CGST_AMOUNT + ".Value";
            txt_cgst_amt.Style.TextAlign = TextAlignRptEnum.Right;
            txt_cgst_amt.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //txt_cgst_amt.Style.BackgroundColor.Color = Color.ForestGreen;

            //
            x = Totalv.Left.Value + 0.01; y = 0; wd = Totalv.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_amount = ReportUtil.AddTextbox("txt_amount" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_amount.Value = "=Fields!" + PInvoiceitems.SUB_TOTAL + ".Value";
            txt_amount.Style.TextAlign = TextAlignRptEnum.Right;
            txt_amount.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_amount.Style.BackgroundColor.Color = Color.Red;
            //





            #endregion [Detail-Line]
            //
        }// fn build details

    }//cls
}//ns
