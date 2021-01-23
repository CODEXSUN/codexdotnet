﻿// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using CXLIB;
using System.Drawing;

namespace CXBILL
{
    public class D_Offset_dcItem
    {
        public static string PRINT_FOLDER = "PRINTS";

        private static double RPT_WIDTH = 7.5, RPT_HEIGHT = 10.0;

        public static void build()
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

                PDcitems.DC_ITEM_ID
                ,PDcitems.DC_ID
                ,PDcitems.SL_NO
                ,PDcitems.PO_ID
                ,PDcitems.PRODUCT_ID
                 ,PDcitems.HSN_CODE_ID
                ,PDcitems.QTY
                        });



            BuildDetail(vBody);

            ///== END OF REPORT  ===========================================================================///
            rptbuild.SaveAs(PRINT_FOLDER + @"\P_DcItem.rdlc");
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
            heading.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //heading.Style.BackgroundColor.Color = Color.Orange;

            #endregion [HEADING AREA]
            //
            #region [Lines AREA]
            //
            x = 0; y = 0; wd = 0.23; ht = 5.2;
            RectangleType slno = ReportUtil.AddRectangle("slno" + sufx, subrect.ReportItems, x, y, wd, ht);
            slno.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //slno.Style.BackgroundColor.Color = Color.MistyRose;
            //
            x = slno.Width.Value; y = 0; wd = 0.8; ht = ht +0;
            RectangleType po = ReportUtil.AddRectangle("po" + sufx, subrect.ReportItems, x, y, wd, ht);
            po.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //po.Style.BackgroundColor.Color = Color.Green;
            //
            x = x + po.Width.Value; y = 0; wd = 4.72; ht = ht + 0;
            RectangleType particulars = ReportUtil.AddRectangle("particulars" + sufx, subrect.ReportItems, x, y, wd, ht);
            particulars.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //particulars.Style.BackgroundColor.Color = Color.FloralWhite;
            //
            x = x + particulars.Width.Value; y = 0; wd = 1; ht = ht + 0;
            RectangleType hsn_code = ReportUtil.AddRectangle("hsn_code" + sufx, subrect.ReportItems, x, y, wd, ht);
            hsn_code.Style.BorderStyle.Default = BorderStyleEnum.Outset;
           // hsn_code.Style.BackgroundColor.Color = Color.Chocolate;
            //
            x = x + hsn_code.Width.Value ; y = 0; wd = 0.9; ht = ht + 0;
            RectangleType qtys = ReportUtil.AddRectangle("qtys" + sufx, subrect.ReportItems, x, y, wd, ht);
            qtys.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //qtys.Style.BackgroundColor.Color = Color.SaddleBrown;
            //
            #endregion [Lines AREA]
            //
            #region [Header ]
            ///
            x = slno.Left.Value + 0.01; y = 0.09; wd = slno.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_slno = ReportUtil.AddTextbox("lbl_slno" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_slno.Value = "S.No";
            lbl_slno.Style.Font("Calibri",7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_slno.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_slno.Style.BackgroundColor.Color = Color.Salmon;
            ///
            x = po.Left.Value + 0.01; y = y+0; wd = po.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_po_no = ReportUtil.AddTextbox("lbl_po_no" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_po_no.Value = "PO.No";
            lbl_po_no.Style.Font("Calibri", 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_po_no.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_po_no.Style.BackgroundColor.Color = Color.SeaGreen;
            //
            x = particulars.Left.Value + 0.11; y = y + 0; wd = particulars.Width.Value - 0.13; ht = 0.16;
            TextboxType lbl_particulars = ReportUtil.AddTextbox("lbl_particulars" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_particulars.Value = "Particulars";
            lbl_particulars.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_particulars.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_particulars.Style.BackgroundColor.Color = Color.SteelBlue;
           
            x = hsn_code.Left.Value + 0.16; y = y + 0; wd = hsn_code.Width.Value - 0.08; ht = 0.16;
            TextboxType lbl_hsn = ReportUtil.AddTextbox("lbl_hsn" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_hsn.Value = "HSN CODE";
            lbl_hsn.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_hsn.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_hsn_code.Style.BackgroundColor.Color = Color.Blue;

            //x = hsn_code.Left.Value + 0.1; y = y + 0.12; wd = hsn_code.Width.Value - 0.08; ht = 0.16;
            //TextboxType lbl_hsn_code = ReportUtil.AddTextbox("lbl_hsn_code" + sufx, subrect.ReportItems, x, y, wd, ht);
            //lbl_hsn_code.Value = "Code";
            //lbl_hsn_code.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            //lbl_hsn_code.Style.TextAlign = TextAlignRptEnum.Left;
            ////lbl_hsn_code.Style.BackgroundColor.Color = Color.Blue;

            x = qtys.Left.Value + 0.01; y = 0.09; wd = qtys.Width.Value - 0.03; ht = 0.16;
            TextboxType lbl_qty = ReportUtil.AddTextbox("lbl_qty" + sufx, subrect.ReportItems, x, y, wd, ht);
            lbl_qty.Value = "Quantity";
            lbl_qty.Style.Font("Calibri", 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_qty.Style.TextAlign = TextAlignRptEnum.Center;
            //lbl_qty.Style.BackgroundColor.Color = Color.DimGray;
 
            #endregion [Header]
            //
            #region [ Detail-Line ]
            //
            x = 0; y = 0.4; wd = subrect.Width.Value; ht = 0.03;
            ListType listDetlLine = ReportUtil.AddList("listDetlLine" + sufx, subrect.ReportItems, x, y, wd, ht);
            listDetlLine.DataSetName = "MyDataSource_Items";
            listDetlLine.Grouping = new GroupingType("group_"+ PDcitems.SL_NO + "");
            listDetlLine.Grouping.GroupExpressions.Add("=Fields!" + PDcitems.SL_NO + ".Value");
            //listDetlLine.Style.BackgroundColor.Color = Color.Red;
            //
            x = 0; y = 0; wd = 0.55; ht = 0.25;
            RectangleType listdetails_rect = ReportUtil.AddRectangle("listdetails_rect" + sufx, listDetlLine.ReportItems, x, y, wd, ht);
            listdetails_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //listdetails_rect.Style.BackgroundColor.Color = Color.Azure;
            //
            x = slno.Left.Value + 0.01; y = 0; wd = slno.Width.Value - 0.03; ht = ht+0;
            TextboxType txt_slno = ReportUtil.AddTextbox("txt_slno" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_slno.Value = "=Fields!" + PDcitems.SL_NO + ".Value";
            txt_slno.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_slno.Style.TextAlign = TextAlignRptEnum.Center;

          //  txt_slno.Style.BackgroundColor.Color = Color.Red;
            //
            x = po.Left.Value + 0.01; y = 0; wd = po.Width.Value - 0.03; ht = ht + 0;
            TextboxType txt_po_no = ReportUtil.AddTextbox("txt_po_no" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_po_no.Value = "=Fields!" + PDcitems.PO_ID + ".Value";
            txt_po_no.Style.TextAlign = TextAlignRptEnum.Center;
            txt_po_no.CanGrow = true;
            txt_po_no.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
            //
          
          //  txt_dc_no.Style.BackgroundColor.Color = Color.Red;
            //
            x = particulars.Left.Value + 0.05; y = 0; wd = particulars.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_product_name = ReportUtil.AddTextbox("txt_product_name" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_product_name.Value = "=Fields!" + PDcitems.PRODUCT_ID + ".Value";
            txt_product_name.Style.TextAlign = TextAlignRptEnum.Left;
            txt_product_name.CanGrow = true;
            txt_product_name.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

            //txt_product_name.Style.BackgroundColor.Color = Color.Red;

            x = hsn_code.Left.Value + 0.01; y = 0; wd = hsn_code.Width.Value - 0.02; ht = ht + 0;
            TextboxType txt_hsn_code = ReportUtil.AddTextbox("txt_hsn_code" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_hsn_code.Value = "=Fields!HSN_CODE_ID.Value";
            txt_hsn_code.Style.TextAlign = TextAlignRptEnum.Center;
            txt_hsn_code.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);
           // txt_hsn_code.Style.BackgroundColor.Color = Color.Red;

            //txt_product_name.Style.BackgroundColor.Color = Color.Red;
            //
            x = qtys.Left.Value + 0.02; y = 0; wd = qtys.Width.Value - 0.05; ht = ht + 0;
            TextboxType txt_qty = ReportUtil.AddTextbox("txt_qty" + sufx, listdetails_rect.ReportItems, x, y, wd, ht);
            txt_qty.Value = "=Fields!" + PDcitems.QTY + ".Value";
            txt_qty.Style.TextAlign = TextAlignRptEnum.Center;
            txt_qty.Style.Font("Tahoma", 8, FontWeightEnum.Normal, FontStyleEnum.Normal);

           // txt_qty.Style.BackgroundColor.Color = Color.Red;

            #endregion [Detail-Line]
            //
        }// fn build details

    }//cls
}//ns
