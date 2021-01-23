// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using CXLIB;

namespace CXBILL
{
    public class D_QuotationItem
    {
        public static string PRINT_FOLDER = "PRINTS";

        private static double RPT_WIDTH = 7.65, RPT_HEIGHT = 10.0;

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

                PQuotationitems.QUOTATION_ITEM_ID
                ,PQuotationitems.QUOTATION_ID
                ,PQuotationitems.SL_NO
                ,PQuotationitems.PO_ID
                ,PQuotationitems.DC_ID
                ,PQuotationitems.PRODUCT_ID
                ,PQuotationitems.SIZES_ID
                 ,PQuotationitems.HSN_CODE_ID
                ,PQuotationitems.QTY
                ,PQuotationitems.PRICE
                ,PQuotationitems.SUB_TOTAL
                ,PQuotationitems.TAXABLEVALUE
                ,PQuotationitems.CGST_PERCENT
                ,PQuotationitems.CGST_AMOUNT
                ,PQuotationitems.SGST_PERCENT
                ,PQuotationitems.SGST_AMOUNT
                        });



            BuildDetail(vBody);

            ///== END OF REPORT  ===========================================================================///
            rptbuild.SaveAs(PRINT_FOLDER + @"\P_QuotationItem.rdlc");
        }

        private static void BuildDetail(BodyType rectWarper)
        {
            double x = 0, y = 0, wd = 0, ht = 0;
            string sufx = ""; /*Now unused. Used before in A4 (i.e 2xA5) print*/
                              //
            x = 0; y = 0; wd = 7.65; ht = 0.1;
            RectangleType subrect = ReportUtil.AddRectangle("manirect" + sufx, rectWarper.ReportItems, x, y, wd, ht);
            subrect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //subrect.Style.BackgroundColor.Color = Color.Red;
            //
            #region [HEADING AREA]
            //
            x = 0; y = 0; wd = subrect.Width.Value; ht = 0.3;
            RectangleType heading = ReportUtil.AddRectangle("heading" + sufx, subrect.ReportItems, x, y, wd, ht);
            heading.Style.BorderStyle.Default = BorderStyleEnum.None;
            heading.Style.BorderStyle.Top = BorderStyleEnum.Outset;
            heading.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //heading.Style.BackgroundColor.Color = Color.Orange;


            #endregion [HEADING AREA]
            //
            #region [Lines AREA]

            x = 0; y = 0; wd = 0.23; ht = 3;
            RectangleType slno = ReportUtil.AddRectangle("slno" + sufx, subrect.ReportItems, x, y, wd, ht);
            slno.Style.BorderStyle.Default = BorderStyleEnum.None;
            //slno.Style.BackgroundColor.Color = Color.MistyRose;

            x = x + slno.Width.Value; y = 0; wd = 4.02; ht = ht + 0;
            RectangleType particulars = ReportUtil.AddRectangle("particulars" + sufx, subrect.ReportItems, x, y, wd, ht);
            particulars.Style.BorderStyle.Default = BorderStyleEnum.None;
            //particulars.Style.BackgroundColor.Color = Color.FloralWhite;
            //
            x = x + particulars.Width.Value; y = 0; wd = 0.8; ht = ht + 0;
            RectangleType sizes = ReportUtil.AddRectangle("sizes" + sufx, subrect.ReportItems, x, y, wd, ht);
            sizes.Style.BorderStyle.Default = BorderStyleEnum.None;
            //sizes.Style.BackgroundColor.Color = Color.SaddleBrown;
            //
            x = x + sizes.Width.Value; y = 0; wd = 0.9; ht = ht + 0;
            RectangleType qtys = ReportUtil.AddRectangle("qtys" + sufx, subrect.ReportItems, x, y, wd, ht);
            qtys.Style.BorderStyle.Default = BorderStyleEnum.None;
            //qtys.Style.BackgroundColor.Color = Color.SaddleBrown;
            //
            x = x + qtys.Width.Value; y = 0; wd = 0.8; ht = ht + 0;
            RectangleType price = ReportUtil.AddRectangle("price" + sufx, subrect.ReportItems, x, y, wd, ht);
            price.Style.BorderStyle.Default = BorderStyleEnum.None;
            //price.Style.BackgroundColor.Color = Color.Aquamarine;
            //
            x = x + price.Width.Value; y = 0; wd = 0.9; ht = ht + 0;
            RectangleType taxableamt = ReportUtil.AddRectangle("taxableamt" + sufx, subrect.ReportItems, x, y, wd, ht);
            taxableamt.Style.BorderStyle.Default = BorderStyleEnum.None;
            //amount.Style.BackgroundColor.Color = Color.Green;
            //
            #endregion [Lines AREA]

            #region [Header ]
            ///
            x = slno.Left.Value + 0.01; y = 0.09; wd = slno.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_slno = ReportUtil.AddTextbox("lbl_slno" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_slno.Value = "S.No";
            lbl_slno.Style.Font("Calibri", 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_slno.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_slno.Style.BackgroundColor.Color = Color.Salmon;

            x = particulars.Left.Value + 0.11; y = y + 0; wd = particulars.Width.Value - 0.13; ht = 0.16;
            TextboxType lbl_particulars = ReportUtil.AddTextbox("lbl_particulars" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_particulars.Value = "Particulars";
            lbl_particulars.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_particulars.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_particulars.Style.BackgroundColor.Color = Color.SteelBlue;

            x = sizes.Left.Value + 0.01; y = 0.09; wd = sizes.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_sizes = ReportUtil.AddTextbox("lbl_sizes" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_sizes.Value = "Sizes";
            lbl_sizes.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_sizes.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_sizes.Style.BackgroundColor.Color = Color.Blue;

            x = qtys.Left.Value + 0.01; y = 0.09; wd = qtys.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_qty = ReportUtil.AddTextbox("lbl_qty" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_qty.Value = "Quantity";
            lbl_qty.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_qty.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_qty.Style.BackgroundColor.Color = Color.DimGray;
            ///
            x = price.Left.Value + 0.01; y = y + 0; wd = price.Width.Value - 0.01; ht = 0.16;
            TextboxType lbl_price = ReportUtil.AddTextbox("lbl_price" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_price.Value = "Price";
            lbl_price.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_price.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_price.Style.BackgroundColor.Color = Color.Coral;
            ///

            x = taxableamt.Left.Value + 0.01; y = y + 0; wd = price.Width.Value - 0.01; ht = 0.16;
            TextboxType lbl_taxableamt = ReportUtil.AddTextbox("lbl_taxableamt" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_taxableamt.Value = "Amount";
            lbl_taxableamt.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_taxableamt.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_taxableamt.Style.BackgroundColor.Color = Color.Coral;
            ///
            #endregion [Header]

            #region [ Detail-Line ]
            //
            x = 0; y = 0.4; wd = subrect.Width.Value; ht = 0.03;
            ListType listDetlLine = ReportUtil.AddList("listDetlLine" + sufx, subrect.ReportItems, x, y, wd, ht);
            listDetlLine.DataSetName = "MyDataSource_Items";
            listDetlLine.Grouping = new GroupingType("group_" + PQuotationitems.SL_NO + "");
            listDetlLine.Grouping.GroupExpressions.Add("=Fields!" + PQuotationitems.SL_NO + ".Value");
            //listDetlLine.Style.BackgroundColor.Color = Color.Red;
            //
            x = 0; y = 0; wd = 0.55; ht = 0.25;
            RectangleType listdetails_rect = ReportUtil.AddRectangle("listdetails_rect" + sufx, listDetlLine.ReportItems, x, y, wd, ht);
            listdetails_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //listdetails_rect.Style.BackgroundColor.Color = Color.Azure;
            //
            x = slno.Left.Value + 0.01; y = 0; wd = slno.Width.Value - 0.03; ht = ht + 0;
            TextboxType txt_slno = ReportUtil.AddTextbox("txt_slno" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_slno.Value = "=Fields!" + PQuotationitems.SL_NO + ".Value";
            txt_slno.Style.Font("Tahoma", 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_slno.Style.TextAlign = TextAlignRptEnum.Center;

            //  txt_slno.Style.BackgroundColor.Color = Color.Red;
            //
            x = particulars.Left.Value + 0.05; y = 0; wd = particulars.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_product_name = ReportUtil.AddTextbox("txt_product_name" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_product_name.Value = "=Fields!" + PQuotationitems.PRODUCT_ID + ".Value";
            txt_product_name.Style.TextAlign = TextAlignRptEnum.Left;
            txt_product_name.CanGrow = true;
            txt_product_name.Style.Font("Tahoma", 10, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //txt_product_name.Style.BackgroundColor.Color = Color.Red;

            x = sizes.Left.Value + 0.01; y = 0; wd = sizes.Width.Value - 0.01; ht = ht + 0;
            TextboxType txt_sizes = ReportUtil.AddTextbox("txt_sizes" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_sizes.Value = "=Fields!" + PQuotationitems.SIZES_ID + ".Value";
            txt_sizes.Style.TextAlign = TextAlignRptEnum.Center;
            txt_sizes.Style.Font("Tahoma", 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            //txt_sizes.Style.BackgroundColor.Color = Color.Red;

            //txt_product_name.Style.BackgroundColor.Color = Color.Red;
            //
            x = qtys.Left.Value + 0.02; y = 0; wd = qtys.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_qty = ReportUtil.AddTextbox("txt_qty" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_qty.Value = "=Fields!" + PQuotationitems.QTY + ".Value";
            txt_qty.Style.TextAlign = TextAlignRptEnum.Center;
            txt_qty.Style.Font("Tahoma", 10, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // txt_qty.Style.BackgroundColor.Color = Color.Red;
            //
            x = price.Left.Value + 0.02; y = 0; wd = price.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_price = ReportUtil.AddTextbox("txt_price" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_price.Value = "=Fields!" + PQuotationitems.PRICE + ".Value";
            txt_price.Style.TextAlign = TextAlignRptEnum.Right;
            txt_price.Style.Font("Tahoma", 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            //txt_price.Style.BackgroundColor.Color = Color.Red;


            x = taxableamt.Left.Value + 0.01; y = 0; wd = taxableamt.Width.Value - 0.04; ht = ht + 0;
            TextboxType txt_taxable = ReportUtil.AddTextbox("txt_taxable" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_taxable.Value = "=Fields!" + PQuotationitems.TAXABLEVALUE + ".Value";
            txt_taxable.Style.TextAlign = TextAlignRptEnum.Right;
            txt_taxable.Style.Font("Tahoma", 10, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //txt_taxable.Style.BackgroundColor.Color = Color.Red;
            #endregion [Detail-Line]

        }// fn build details

    }//cls
}//ns
