// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using CXLIB;
//
namespace CXBILL
{
    public class D_Quotation
    {
        public static string PRINT_FOLDER = "PRINTS";

        private static double RPT_WIDTH = 8, RPT_HEIGHT = 11.5;

        public static void Build()
        {
            ReportBuilder rptbuild = new ReportBuilder();
            ReportType vReport = rptbuild.Report;
            BodyType vBody = vReport.Body;

            double x = 0, y = 0, wd = 0, ht = 0;

            vReport.Width.Value = RPT_WIDTH;
            vBody.Height.Value = RPT_HEIGHT;

            DataSetType dataSet = rptbuild.Report.DataSets[0];

            ReportUtil.AddFields(dataSet.Fields, new string[] {

                PQuotation.COPIES
                ,PQuotation.SALESTYPE

                ,PQuotation.COMPANY_NAME
                ,PQuotation.ADDRESS1
                ,PQuotation.ADDRESS2
                ,PQuotation.COMPANY_TIN

                ,PQuotation.QUOTATION_ID
                ,PQuotation.QUOTATION_NO
                ,PQuotation.QUOTATION_DATE

                ,PQuotation.TRANSPORT
                ,PQuotation.DELIVERYTO
                ,PQuotation.BUNDEL

                ,PQuotation.PARTY_NAME
                ,PQuotation.STREET1
                ,PQuotation.STREET2
                ,PQuotation.CITY
                ,PQuotation.STATE
                ,PQuotation.COUNTRY
                ,PQuotation.PINCODE
                ,PQuotation.GSTIN
                ,PQuotation.TOTAL_QTY

                ,PQuotation.TAXABLE_VALUE

                ,PQuotation.TOTAL_SUB
                ,PQuotation.LEDGER
                ,PQuotation.ADDITIONAL
                ,PQuotation.OUTSTANDING

                ,PQuotation.GSTTOTAL

                ,PQuotation.GRANDTOTAL
                ,PQuotation.AMOUNT_IN_WORDS
                ,PQuotation.NOTES
                ,PQuotation.ENTRY_BY
                });

            x = 0; y = 0; wd = RPT_WIDTH; ht = RPT_HEIGHT;
            ListType Reportlist = ReportUtil.AddList("Reportlist", vBody.ReportItems, x, y, wd, ht);

            Reportlist.Grouping = new GroupingType("group_" + PQuotation.QUOTATION_ID + "");
            Reportlist.Grouping.GroupExpressions.Add("=Fields!" + PQuotation.QUOTATION_ID + ".Value");
            Reportlist.Grouping.GroupExpressions.Add("=Fields!" + PQuotation.COPIES + ".Value");
            Reportlist.Grouping.PageBreakAtEnd = true;


            x = 0; y = 0; wd = RPT_WIDTH; ht = RPT_HEIGHT;
            RectangleType rectWarper = ReportUtil.AddRectangle("rectWarper", Reportlist.ReportItems, x, y, wd, ht);
            rectWarper.Style.BorderStyle.Default = BorderStyleEnum.None;
            BuildDetail(rectWarper);

            //ReportUtil.AttachRulers(Reportlist.ReportItems, RPT_WIDTH, RPT_HEIGHT);
            rptbuild.SaveAs(PRINT_FOLDER + @"\P_Quotation.rdlc");

        }

        private static void BuildDetail(RectangleType rectWarper)
        {
            double x = 0, y = 0, wd = 0, ht = 0;


            #region[rect]

            x = 0.35; y = 0.20; wd = 7.65; ht = 01;
            RectangleType manirect = ReportUtil.AddRectangle("manirect", rectWarper.ReportItems, x, y, wd, ht);
            manirect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //manirect.Style.BackgroundColor.Color = Color.Red;

            x = 0; y = 0; wd = wd + 0; ht = 5.6;
            RectangleType rect_1 = ReportUtil.AddRectangle("rect_1", manirect.ReportItems, x, y, wd, ht);
            rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //rect_1.Style.BackgroundColor.Color = Color.Orange;

            x = 0; y = 0; wd = wd + 0; ht = 0.01;
            RectangleType title_rect = ReportUtil.AddRectangle("title_rect", rect_1.ReportItems, x, y, wd, ht);
            title_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //title_rect.Style.BackgroundColor.Color = Color.Orange;

            x = 0; y = y + title_rect.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType party_rect = ReportUtil.AddRectangle("party_rect", rect_1.ReportItems, x, y, wd, ht);
            party_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //party_rect.Style.BackgroundColor.Color = Color.Blue;

            x = 0; y = y + party_rect.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType items_rect = ReportUtil.AddRectangle("items_rect", rect_1.ReportItems, x, y, wd, ht);
            items_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            items_rect.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //items_rect.Style.BackgroundColor.Color = Color.Green;

            x = 0; y = y + items_rect.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType ledger_rect = ReportUtil.AddRectangle("ledger_rect", rect_1.ReportItems, x, y, wd, ht);
            ledger_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            ledger_rect.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //ledger_rect.Style.BackgroundColor.Color = Color.Red;

            x = 0; y = y + ledger_rect.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType grandtotal_rect = ReportUtil.AddRectangle("grandtotal_rect", rect_1.ReportItems, x, y, wd, ht);
            grandtotal_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            grandtotal_rect.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //grandtotal_rect.Style.BackgroundColor.Color = Color.Aquamarine;

            x = 0; y = y + grandtotal_rect.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType balance_rect = ReportUtil.AddRectangle("balance_rect", rect_1.ReportItems, x, y, wd, ht);
            balance_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            balance_rect.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //balance_rect.Style.BackgroundColor.Color = Color.Aquamarine;

            x = 0; y = y + balance_rect.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType Sign_rect = ReportUtil.AddRectangle("Sign_rect", rect_1.ReportItems, x, y, wd, ht);
            Sign_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //Sign_rect.Style.BackgroundColor.Color = Color.Aquamarine;

            #endregion[rect]

            #region[Title]

            x = 0; y = 0.01; wd = title_rect.Width.Value; ht = 0.30;
            TextboxType txt_title = ReportUtil.AddTextbox("txt_title", title_rect.ReportItems, x, y, wd, ht);
            txt_title.Value = "QUOTATION";
            txt_title.Style.TextAlign = TextAlignRptEnum.Center;
            txt_title.Style.Font(PrintConfig.TitleTxtFont, 16, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_title.Style.TextDecoration = TextDecorationEnum.Underline;

            #endregion[Title]

            #region[party]

            x = 0; y = 0; wd = 5; ht = 0.1;
            RectangleType party_area = ReportUtil.AddRectangle("party_area", party_rect.ReportItems, x, y, wd, ht);
            party_area.Style.BorderStyle.Default = BorderStyleEnum.None;
            //party_area.Style.BackgroundColor.Color = Color.Green;

            x = wd; y = 0; wd = party_rect.Width.Value - wd; ht = ht + 0;
            RectangleType nodt_rect = ReportUtil.AddRectangle("nodt_rect", party_rect.ReportItems, x, y, wd, ht);
            nodt_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //nodt_rect.Style.BackgroundColor.Color = Color.DarkOrange;


            x = 0.2; y = 0.08; wd = party_area.Width.Value - (x + 0.2); ht = 0.20;
            TextboxType txt_partyname = ReportUtil.AddTextbox("txt_partyname", party_area.ReportItems, x, y, wd, ht);
            txt_partyname.Value = "=Fields!" + PQuotation.PARTY_NAME + ".Value";
            txt_partyname.CanGrow = true;
            txt_partyname.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_partyname.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_partyname.Style.BackgroundColor.Color = Color.SandyBrown;

            x = x + 0; y = y + 0.2; wd = wd + 0; ht = ht + 0;
            TextboxType txt_city = ReportUtil.AddTextbox("txt_city", party_area.ReportItems, x, y, wd, ht);
            txt_city.Value = "=Fields!" + PQuotation.CITY + ".Value";
            txt_city.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_city.Style.TextAlign = TextAlignRptEnum.Left;
            txt_city.CanGrow = true;
            //txt_city.Style.BackgroundColor.Color = Color.SkyBlue;

            x = 0.20; y = txt_partyname.Top.Value; wd = nodt_rect.Width.Value - (x + 0.01); ht = 0.25;
            TextboxType txt_no = ReportUtil.AddTextbox("txt_no", nodt_rect.ReportItems, x, y, wd, ht);
            txt_no.Value = "=Fields!" + PQuotation.QUOTATION_NO + ".Value";
            txt_no.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Normal, FontStyleEnum.Normal);

            x = x + 0; y = y + 0.25; wd = wd + 0; ht = 0.20;
            TextboxType txt_date = ReportUtil.AddTextbox("txt_date", nodt_rect.ReportItems, x, y, wd, ht);
            txt_date.Value = "=Fields!" + PQuotation.QUOTATION_DATE + ".Value";
            txt_date.Style.Format = "dd-MM-yyyy";
            txt_date.Style.Font(PrintConfig.PartyTxtFont, 11, FontWeightEnum.Normal, FontStyleEnum.Normal);

            #endregion[party]

            #region[sub]

            x = 0; y = 0; wd = items_rect.Width.Value; ht = 0.1;
            ReportUtil.AddSubreport("subreport_Print_quotationItems", "P_QuotationItem", items_rect.ReportItems, x, y, wd, ht);

            #endregion[sub]

            #region[Ledger]

            x = 4.8; y = 0.01; wd = 2; ht = 0.18;
            TextboxType txt_ledger = ReportUtil.AddTextbox("txt_ledger", ledger_rect.ReportItems, x, y, wd, ht);
            txt_ledger.Value = "=Fields!" + PQuotation.LEDGER + ".Value";
            txt_ledger.Style.Font(PrintConfig.BodyTxtFont, 11, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_ledger.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_ledger.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 6.3; y = txt_ledger.Top.Value; wd = 1.33; ht = 0.18;
            TextboxType txt_additional = ReportUtil.AddTextbox("txt_additional", ledger_rect.ReportItems, x, y, wd, ht);
            txt_additional.Value = "=Fields!" + PQuotation.ADDITIONAL + ".Value";
            txt_additional.Style.Font(PrintConfig.BodyTxtFont, 11, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_additional.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_additional.Style.BackgroundColor.Color = Color.Tan;

            #endregion[Ledger]

            #region [Grand total]

            x = 0; y = 0; wd = 5.05; ht = 0.1;
            RectangleType amtnwords = ReportUtil.AddRectangle("amtnwords", grandtotal_rect.ReportItems, x, y, wd, ht);
            amtnwords.Style.BorderStyle.Default = BorderStyleEnum.None;
            //amtnwords.Style.BackgroundColor.Color = Color.Red;

            x = 0.05; y = 0.01; wd = 4.7; ht = 0.19;
            TextboxType txt_amtnwords = ReportUtil.AddTextbox("txt_amtnwords", amtnwords.ReportItems, x, y, wd, ht);
            txt_amtnwords.Value = "=Fields!" + PQuotation.AMOUNT_IN_WORDS + ".Value";
            txt_amtnwords.CanGrow = true;
            txt_amtnwords.Style.Font(PrintConfig.BodyTxtFont, 9, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_amtnwords.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_amtnwords.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 5; y = 0.01; wd = 1.3; ht = 0.19;
            TextboxType lbl_grandtotal = ReportUtil.AddTextbox("lbl_grandtotal", grandtotal_rect.ReportItems, x, y, wd, ht);
            lbl_grandtotal.Value = "  GRAND TOTAL";
            lbl_grandtotal.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_grandtotal.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_grandtotal.Style.BackgroundColor.Color = Color.DeepSkyBlue;
            //lbl_grandtotal.Style.BorderStyle.Left = BorderStyleEnum.Outset;

            x = 6.2; y = 0.01; wd = 1.43; ht = 0.19;
            TextboxType txt_grandtotal = ReportUtil.AddTextbox("txt_grandtotal", grandtotal_rect.ReportItems, x, y, wd, ht);
            txt_grandtotal.Value = "=Fields!" + PQuotation.GRANDTOTAL + ".Value";
            txt_grandtotal.Style.Font(PrintConfig.BodyTxtFont, 11, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_grandtotal.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_grandtotal.Style.BackgroundColor.Color = Color.Tomato;

            #endregion [Grand total]

            #region[Outstanding]

            x = 0; y = 0.01; wd = balance_rect.Width.Value - 0.03; ht = 0.18;
            TextboxType txt_balance = ReportUtil.AddTextbox("txt_balance", balance_rect.ReportItems, x, y, wd, ht);
            txt_balance.Value = "=Fields!" + PQuotation.OUTSTANDING + ".Value";
            txt_balance.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_balance.Style.TextAlign = TextAlignRptEnum.Center;
            //txt_balance.Style.BackgroundColor.Color = Color.Tomato;

            #endregion[Outstanding]

            #region[sign]

            x = 0; y = 0.08; wd = Sign_rect.Width.Value - 0.8; ht = 0.28;
            TextboxType txt_forsign = ReportUtil.AddTextbox("txt_forsign", Sign_rect.ReportItems, x, y, wd, ht);
            txt_forsign.Value = "Recevier Sign                                Prepared by                                               Party Sign";
            txt_forsign.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_forsign.Style.TextAlign = TextAlignRptEnum.Center;
            //txt_forsign.Style.BackgroundColor.Color = Color.Tomato;

            #endregion[sign]

            //
            // copy 2
            //

            #region[rect]

           x = 0; y = rect_1.Height.Value + 0.10; wd = 7.65; ht = 5.6;
            RectangleType rect_2 = ReportUtil.AddRectangle("rect_2", manirect.ReportItems, x, y, wd, ht);
            rect_2.Style.BorderStyle.Default = BorderStyleEnum.None;
            //rect_2.Style.BackgroundColor.Color = Color.Green;

            x = 0; y = Sign_rect.Height.Value + 0.10; wd = wd + 0; ht = 0.01;
            RectangleType title_rect_1 = ReportUtil.AddRectangle("title_rect_1", rect_2.ReportItems, x, y, wd, ht);
            title_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //title_rect_1.Style.BackgroundColor.Color = Color.Orange;

            x = 0; y = y + title_rect_1.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType party_rect_1 = ReportUtil.AddRectangle("party_rect_1", rect_2.ReportItems, x, y, wd, ht);
            party_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //party_rect_1.Style.BackgroundColor.Color = Color.Blue;

            x = 0; y = y + party_rect_1.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType items_rect_1 = ReportUtil.AddRectangle("items_rect_1", rect_2.ReportItems, x, y, wd, ht);
            items_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            items_rect_1.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //items_rect_1.Style.BackgroundColor.Color = Color.Green;

            x = 0; y = y + items_rect_1.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType ledger_rect_1 = ReportUtil.AddRectangle("ledger_rect_1", rect_2.ReportItems, x, y, wd, ht);
            ledger_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            ledger_rect_1.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //ledger_rect_1.Style.BackgroundColor.Color = Color.Red;

            x = 0; y = y + ledger_rect_1.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType grandtotal_rect_1 = ReportUtil.AddRectangle("grandtotal_rect_1", rect_2.ReportItems, x, y, wd, ht);
            grandtotal_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            grandtotal_rect_1.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //grandtotal_rect_1.Style.BackgroundColor.Color = Color.Aquamarine;

            x = 0; y = y + grandtotal_rect_1.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType balance_rect_1 = ReportUtil.AddRectangle("balance_rect_1", rect_2.ReportItems, x, y, wd, ht);
            balance_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            balance_rect_1.Style.BorderStyle.Bottom = BorderStyleEnum.Outset;
            //balance_rect_1.Style.BackgroundColor.Color = Color.Aquamarine;

            x = 0; y = y + balance_rect_1.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType Sign_rect_1 = ReportUtil.AddRectangle("Sign_rect_1", rect_2.ReportItems, x, y, wd, ht);
            Sign_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //Sign_rect_1.Style.BackgroundColor.Color = Color.SaddleBrown;

            #endregion[rect]

            #region[Title]

            x = 0; y = 0.01; wd = title_rect_1.Width.Value; ht = 0.30;
            TextboxType txt_title_1 = ReportUtil.AddTextbox("txt_title_1", title_rect_1.ReportItems, x, y, wd, ht);
            txt_title_1.Value = "QUOTATION";
            txt_title_1.Style.TextAlign = TextAlignRptEnum.Center;
            txt_title_1.Style.Font(PrintConfig.TitleTxtFont, 16, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_title_1.Style.TextDecoration = TextDecorationEnum.Underline;

            #endregion[Title]

            #region[party]

            x = 0; y = 0; wd = 5; ht = 0.1;
            RectangleType party_area_1 = ReportUtil.AddRectangle("party_area_1", party_rect_1.ReportItems, x, y, wd, ht);
            party_area_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //party_area_1.Style.BackgroundColor.Color = Color.Green;

            x = wd; y = 0; wd = party_rect_1.Width.Value - wd; ht = ht + 0;
            RectangleType nodt_rect_1 = ReportUtil.AddRectangle("nodt_rect_1", party_rect_1.ReportItems, x, y, wd, ht);
            nodt_rect_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //nodt_rect_1.Style.BackgroundColor.Color = Color.DarkOrange;


            x = 0.2; y = 0.08; wd = party_area_1.Width.Value - (x + 0.2); ht = 0.20;
            TextboxType txt_partyname_1 = ReportUtil.AddTextbox("txt_partyname_1", party_area_1.ReportItems, x, y, wd, ht);
            txt_partyname_1.Value = "=Fields!" + PQuotation.PARTY_NAME + ".Value";
            txt_partyname_1.CanGrow = true;
            txt_partyname_1.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_partyname_1.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_partyname_1.Style.BackgroundColor.Color = Color.SandyBrown;

            x = x + 0; y = y + 0.2; wd = wd + 0; ht = ht + 0;
            TextboxType txt_city_1 = ReportUtil.AddTextbox("txt_city_1", party_area_1.ReportItems, x, y, wd, ht);
            txt_city_1.Value = "=Fields!" + PQuotation.CITY + ".Value";
            txt_city_1.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_city_1.Style.TextAlign = TextAlignRptEnum.Left;
            txt_city_1.CanGrow = true;
            //txt_city_1.Style.BackgroundColor.Color = Color.SkyBlue;

            x = 0.20; y = txt_partyname_1.Top.Value; wd = nodt_rect_1.Width.Value - (x + 0.01); ht = 0.25;
            TextboxType txt_no_1 = ReportUtil.AddTextbox("txt_no_1", nodt_rect_1.ReportItems, x, y, wd, ht);
            txt_no_1.Value = "=Fields!" + PQuotation.QUOTATION_NO + ".Value";
            txt_no_1.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Normal, FontStyleEnum.Normal);

            x = x + 0; y = y + 0.25; wd = wd + 0; ht = 0.20;
            TextboxType txt_date_1 = ReportUtil.AddTextbox("txt_date_1", nodt_rect_1.ReportItems, x, y, wd, ht);
            txt_date_1.Value = "=Fields!" + PQuotation.QUOTATION_DATE + ".Value";
            txt_date_1.Style.Format = "dd-MM-yyyy";
            txt_date_1.Style.Font(PrintConfig.PartyTxtFont, 11, FontWeightEnum.Normal, FontStyleEnum.Normal);

            #endregion[party]

            #region[sub]

            x = 0; y = 0; wd = items_rect_1.Width.Value; ht = 0.1;
            ReportUtil.AddSubreport("subreport_Print_quotationItems_1", "P_QuotationItem", items_rect_1.ReportItems, x, y, wd, ht);

            #endregion[sub]

            #region[Ledger]

            x = 4.8; y = 0.01; wd = 2; ht = 0.18;
            TextboxType txt_ledger_1 = ReportUtil.AddTextbox("txt_ledger_1", ledger_rect_1.ReportItems, x, y, wd, ht);
            txt_ledger_1.Value = "=Fields!" + PQuotation.LEDGER + ".Value";
            txt_ledger_1.Style.Font(PrintConfig.BodyTxtFont, 11, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_ledger_1.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_ledger_1.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 6.3; y = txt_ledger_1.Top.Value; wd = 1.33; ht = 0.18;
            TextboxType txt_additional_1 = ReportUtil.AddTextbox("txt_additional_1", ledger_rect_1.ReportItems, x, y, wd, ht);
            txt_additional_1.Value = "=Fields!" + PQuotation.ADDITIONAL + ".Value";
            txt_additional_1.Style.Font(PrintConfig.BodyTxtFont, 11, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_additional_1.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_additional_1.Style.BackgroundColor.Color = Color.Tan;

            #endregion[Ledger]

            #region [Grand total]

            x = 0; y = 0; wd = 5.05; ht = 0.1;
            RectangleType amtnwords_1 = ReportUtil.AddRectangle("amtnwords_1", grandtotal_rect_1.ReportItems, x, y, wd, ht);
            amtnwords_1.Style.BorderStyle.Default = BorderStyleEnum.None;
            //amtnwords_1.Style.BackgroundColor.Color = Color.Red;

            x = 0.05; y = 0.01; wd = 4.7; ht = 0.19;
            TextboxType txt_amtnwords_1 = ReportUtil.AddTextbox("txt_amtnwords_1", amtnwords_1.ReportItems, x, y, wd, ht);
            txt_amtnwords_1.Value = "=Fields!" + PQuotation.AMOUNT_IN_WORDS + ".Value";
            txt_amtnwords_1.CanGrow = true;
            txt_amtnwords_1.Style.Font(PrintConfig.BodyTxtFont, 9, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_amtnwords_1.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_amtnwords_1.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 5; y = 0.01; wd = 1.3; ht = 0.19;
            TextboxType lbl_grandtotal_1 = ReportUtil.AddTextbox("lbl_grandtotal_1", grandtotal_rect_1.ReportItems, x, y, wd, ht);
            lbl_grandtotal_1.Value = "  GRAND TOTAL";
            lbl_grandtotal_1.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_grandtotal_1.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_grandtotal_1.Style.BackgroundColor.Color = Color.DeepSkyBlue;
            //lbl_grandtotal_1.Style.BorderStyle.Left = BorderStyleEnum.Outset;

            x = 6.2; y = 0.01; wd = 1.43; ht = 0.19;
            TextboxType txt_grandtotal_1 = ReportUtil.AddTextbox("txt_grandtotal_1", grandtotal_rect_1.ReportItems, x, y, wd, ht);
            txt_grandtotal_1.Value = "=Fields!" + PQuotation.GRANDTOTAL + ".Value";
            txt_grandtotal_1.Style.Font(PrintConfig.BodyTxtFont, 11, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_grandtotal_1.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_grandtotal_1.Style.BackgroundColor.Color = Color.Tomato;

            #endregion [Grand total]

            #region[Outstanding]

            x = 0; y = 0.01; wd = balance_rect_1.Width.Value - 0.03; ht = 0.18;
            TextboxType txt_balance_1 = ReportUtil.AddTextbox("txt_balance_1", balance_rect_1.ReportItems, x, y, wd, ht);
            txt_balance_1.Value = "=Fields!" + PQuotation.OUTSTANDING + ".Value";
            txt_balance_1.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_balance_1.Style.TextAlign = TextAlignRptEnum.Center;
            //txt_balance_1.Style.BackgroundColor.Color = Color.Tomato;

            #endregion[Outstanding]

            #region[sign]

            x = 0; y = 0.08; wd = Sign_rect_1.Width.Value - 0.8; ht = 0.28;
            TextboxType txt_forsign_1 = ReportUtil.AddTextbox("txt_forsign_1", Sign_rect_1.ReportItems, x, y, wd, ht);
            txt_forsign_1.Value = "Recevier Sign                                Prepared by                                               Party Sign";
            txt_forsign_1.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_forsign_1.Style.TextAlign = TextAlignRptEnum.Center;
            //txt_forsign_1.Style.BackgroundColor.Color = Color.Tomato;

            #endregion[sign]

        }// fn build details

    }//cls
}//ns
