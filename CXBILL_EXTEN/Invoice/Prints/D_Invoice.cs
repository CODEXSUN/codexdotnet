// Version : 7.4 dt : 08-01-2017
// CODESK
// 24-01-2017 03:35:23 PM
// create date : 24-01-2017
// last update : 24-01-2017

using System.Drawing;
using CXLIB;

//
namespace CXBILL_EXTEN.Invoice.Prints
{
    public class D_Invoice
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

                 PRINT_INVOICE.COPY_NAME
                ,PRINT_INVOICE.SALES_TYPE

                ,PRINT_INVOICE.COMPANY_NAME
                ,PRINT_INVOICE.COMPANY_ADDRESS_1
                ,PRINT_INVOICE.COMPANY_ADDRESS_2
                ,PRINT_INVOICE.COMPANY_PHONE
                ,PRINT_INVOICE.COMPANY_CELL1
                ,PRINT_INVOICE.COMPANY_CELL2
                ,PRINT_INVOICE.COMPANY_EMAIL
                ,PRINT_INVOICE.COMPANY_WEBSITE
                ,PRINT_INVOICE.COMPANY_GSTIN

                ,PRINT_INVOICE.INVOICE_ID
                ,PRINT_INVOICE.INVOICE_NO
                ,PRINT_INVOICE.INVOICE_DATE

                ,PRINT_INVOICE.TRANSPORT
                ,PRINT_INVOICE.DELIVERYTO
                ,PRINT_INVOICE.BUNDEL
                ,PRINT_INVOICE.PARTY_NAME
                ,PRINT_INVOICE.PARTY_STREET_1
                ,PRINT_INVOICE.PARTY_STREET_2
                ,PRINT_INVOICE.PARTY_CITY
                ,PRINT_INVOICE.PARTY_STATE
                ,PRINT_INVOICE.PARTY_STATE_CODE
                ,PRINT_INVOICE.PARTY_COUNTRY
                ,PRINT_INVOICE.PARTY_PINCODE
                ,PRINT_INVOICE.PARTY_GSTIN

                ,PRINT_INVOICE.TOTAL_QTY
                ,PRINT_INVOICE.TAXABLE_VALUE

                ,PRINT_INVOICE.CGST_PERCENT
                ,PRINT_INVOICE.SGST_PERCENT
                ,PRINT_INVOICE.IGST_PERCENT

                ,PRINT_INVOICE.TOTAL_CGST
                ,PRINT_INVOICE.TOTAL_SGST
                ,PRINT_INVOICE.TOTAL_IGST
                ,PRINT_INVOICE.TOTAL_CESS
                ,PRINT_INVOICE.TOTAL_SUB
                ,PRINT_INVOICE.LEDGER
                ,PRINT_INVOICE.ADDITIONAL
                ,PRINT_INVOICE.ROUNDS
                ,PRINT_INVOICE.GSTTOTAL

                ,PRINT_INVOICE.GRANDTOTAL
                ,PRINT_INVOICE.AMOUNT_IN_WORDS
                ,PRINT_INVOICE.NOTES
                ,PRINT_INVOICE.ENTRY_BY

                ,PRINT_INVOICE.FORSIGN

                ,PRINT_INVOICE.ACCOUNT_NO
                ,PRINT_INVOICE.IFSC_CODE
                ,PRINT_INVOICE.BANK_NAME
                ,PRINT_INVOICE.BANK_BRANCH

                ,PRINT_INVOICE.TERMS_1
                ,PRINT_INVOICE.TERMS_2
                ,PRINT_INVOICE.TERMS_3
                ,PRINT_INVOICE.TERMS_4

                });

            x = 0; y = 0; wd = RPT_WIDTH; ht = RPT_HEIGHT;
            ListType Reportlist = ReportUtil.AddList("Reportlist", vBody.ReportItems, x, y, wd, ht);

            Reportlist.Grouping = new GroupingType("group_" + PRINT_INVOICE.INVOICE_ID + "");
            Reportlist.Grouping.GroupExpressions.Add("=Fields!" + PRINT_INVOICE.INVOICE_ID + ".Value");
            Reportlist.Grouping.GroupExpressions.Add("=Fields!" + PRINT_INVOICE.COPY_NAME + ".Value");
            Reportlist.Grouping.PageBreakAtEnd = true;


            if (PrintConfig.PrintLogo == true)
            {
                EmbeddedImageType myEmbeddedImage1 = ReportUtil.EmbedImage("Image1", Global.GetAbsolutePath("PRINTS\\" + PrintConfig.Logo + ""), vReport);
                ImageType myImage1 = ReportUtil.AddImage("Image1", myEmbeddedImage1, Reportlist.ReportItems, PrintConfig.LogoLeft, PrintConfig.LogoTop, PrintConfig.Logo_width, PrintConfig.Logo_height); //  1.2, 0.5, 0.9, 0.9);
                myImage1.Sizing = SizingEnum.FitProportional; //.AutoSize //.Fit //.Clip
            }

            x = 0; y = 0; wd = RPT_WIDTH; ht = RPT_HEIGHT;
            RectangleType rectWarper = ReportUtil.AddRectangle("rectWarper", Reportlist.ReportItems, x, y, wd, ht);
            rectWarper.Style.BorderStyle.Default = BorderStyleEnum.None;
            BuildDetail(rectWarper);

            //ReportUtil.AttachRulers(Reportlist.ReportItems, RPT_WIDTH, RPT_HEIGHT);
            rptbuild.SaveAs(PRINT_FOLDER + @"\P_Invoice.rdlc");

        }

        private static void BuildDetail(RectangleType rectWarper)
        {
            double x = 0, y = 0, wd = 0, ht = 0;
            string sufx = "";

            x = 0.35; y = 0.32; wd = 7.65; ht = 01;
            RectangleType manirect = ReportUtil.AddRectangle("manirect" + sufx, rectWarper.ReportItems, x, y, wd, ht);
            manirect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //manirect.Style.BackgroundColor.Color = Color.Red;

            #region [rectangles]


            x = 0; y = 0; wd = wd + 0; ht = 1;
            RectangleType company_rect = ReportUtil.AddRectangle("company_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            company_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //company_rect.Style.BackgroundColor.Color = Color.Red;


            x = 0; y = ht + 0; wd = wd + 0; ht = 0.01;
            RectangleType Title_rect = ReportUtil.AddRectangle("Title_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            Title_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            if (PrintConfig.Title2 == false)
            {
                Title_rect.Style.BackgroundColor.Color = Color.Gray;
            }

            x = 0; y = y + Title_rect.Height.Value; wd = wd + 0; ht = 0.01;
            RectangleType party_rect = ReportUtil.AddRectangle("party_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            party_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //party_rect.Style.BackgroundColor.Color = Color.DarkBlue;

            x = 0; y = y + party_rect.Height.Value + 0.04; wd = wd + 0; ht = PrintConfig.SubReportHeight;
            RectangleType items_rect = ReportUtil.AddRectangle("items_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            items_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //items_rect.Style.BackgroundColor.Color = Color.Orange;

            x = 0; y = y + items_rect.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType subtotal_rect = ReportUtil.AddRectangle("subtotal_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            subtotal_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //subtotal_rect.Style.BackgroundColor.Color = Color.Orange;

            x = 0; y = y + subtotal_rect.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType total_rect = ReportUtil.AddRectangle("total_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            total_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //total_rect.Style.BackgroundColor.Color = Color.Crimson;

            x = 0; y = y + total_rect.Height.Value; wd = wd + 0; ht = 0.1;
            RectangleType grandtotal_rect = ReportUtil.AddRectangle("grandtotal_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            grandtotal_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //grandtotal_rect.Style.BackgroundColor.Color = Color.Aquamarine;

            x = 0; y = y + grandtotal_rect.Height.Value; wd = wd = wd + 0; ht = 0.1;
            RectangleType sign_rect = ReportUtil.AddRectangle("sign_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            sign_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //sign_rect.Style.BackgroundColor.Color = Color.Black;

            x = 0; y = y + sign_rect.Height.Value; wd = wd = wd + 0; ht = 0.1;
            RectangleType juridiction_rect = ReportUtil.AddRectangle("juridiction_rect" + sufx, manirect.ReportItems, x, y, wd, ht);
            juridiction_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            ////juridiction_rect.Style.BackgroundColor.Color = Color.Cyan;

            #endregion[rectangles]

            #region [ Title ]

            if (PrintConfig.Title1 == true)
            {
                x = 0; y = 0.01; wd = Title_rect.Width.Value; ht = 0.28;
                TextboxType txt_title = ReportUtil.AddTextbox("txtTitle" + sufx, Title_rect.ReportItems, x, y, wd, ht);
                txt_title.Value = "=Fields!" + PRINT_INVOICE.SALES_TYPE + ".Value";
                txt_title.Style.TextAlign = TextAlignRptEnum.Center;
                txt_title.Style.Color.Color = Color.White;
                txt_title.Style.Font(PrintConfig.TitleTxtFont, 20, FontWeightEnum.Bolder, FontStyleEnum.Normal);

                x = 0; y = 0.04; wd = Title_rect.Width.Value; ht = ht + 0;
                TextboxType txt_copy = ReportUtil.AddTextbox("txtCopy" + sufx, Title_rect.ReportItems, x, y, wd, ht);
                txt_copy.Value = "=Fields!" + PRINT_INVOICE.COPY_NAME + ".Value";
                txt_copy.Style.TextAlign = TextAlignRptEnum.Right;
                txt_copy.Style.Font(PrintConfig.CopyTxtFont, 14, FontWeightEnum.Bolder, FontStyleEnum.Italic);
                txt_copy.Style.Color.Color = Color.White;

            }

            if (PrintConfig.Title2 == true)
            {
                x = 0; y = 0.01; wd = Title_rect.Width.Value; ht = 0.28;
                TextboxType txt_title = ReportUtil.AddTextbox("txtTitle" + sufx, Title_rect.ReportItems, x, y, wd, ht);
                txt_title.Value = "=Fields!" + PRINT_INVOICE.SALES_TYPE + ".Value";
                txt_title.Style.TextAlign = TextAlignRptEnum.Center;
                //txt_title.Style.Color.Color = Color.White;
                txt_title.Style.Font(PrintConfig.TitleTxtFont, 18, FontWeightEnum.Bolder, FontStyleEnum.Normal);

                x = 0; y = 0.04; wd = Title_rect.Width.Value; ht = ht + 0;
                TextboxType txt_copy = ReportUtil.AddTextbox("txtCopy" + sufx, Title_rect.ReportItems, x, y, wd, ht);
                txt_copy.Value = "=Fields!" + PRINT_INVOICE.COPY_NAME + ".Value";
                txt_copy.Style.TextAlign = TextAlignRptEnum.Right;
                txt_copy.Style.Font(PrintConfig.CopyTxtFont, 12, FontWeightEnum.Bolder, FontStyleEnum.Italic);
                //txt_copy.Style.Color.Color = Color.White;

            }

            #endregion [ Title ]

            #region [ COMPANY AREA]

            x = 0; y = 0; wd = 0.9; ht = PrintConfig.HeaderHeight;
            RectangleType Company_logo = ReportUtil.AddRectangle("Company_logo" + sufx, company_rect.ReportItems, x, y, wd, ht);
            Company_logo.Style.BorderStyle.Default = BorderStyleEnum.None;
            //Company_logo.Style.BackgroundColor.Color = Color.DarkBlue;


            if (PrintConfig.PrintLogo == true)
            {
                x = wd + 0; y = 0; wd = company_rect.Width.Value - (x + 0.01); ht = ht + 0;
            }
            else
            {
                x = 0.02; y = 0; wd = company_rect.Width.Value - (x + 0.01); ht = ht + 0;
            }


            RectangleType Company_txt = ReportUtil.AddRectangle("Company_txt" + sufx, company_rect.ReportItems, x, y, wd, ht);
            Company_txt.Style.BorderStyle.Default = BorderStyleEnum.None;
            //Company_txt.Style.BackgroundColor.Color = Color.SaddleBrown;

            #region [ Company txt]

            if (PrintConfig.PrintHeader == true)
            {
                x = 0; y = 0.05; wd = Company_txt.Width.Value - 0.02; ht = 0.4;
                TextboxType txt_compname = ReportUtil.AddTextbox("txt_compname" + sufx, Company_txt.ReportItems, x, y, wd, ht);
                txt_compname.Value = "=Fields!" + PRINT_INVOICE.COMPANY_NAME + ".Value";
                txt_compname.Style.Font(PrintConfig.HeaderTxtFont, PrintConfig.Company_name_FontSize, FontWeightEnum.Bolder, FontStyleEnum.Normal);
                txt_compname.Style.TextAlign = TextAlignRptEnum.Center;
                //txt_compname.Style.BackgroundColor.Color = Color.Tan;

                x = 0; y = 0.50; wd = wd + 0; ht = 0.18;
                TextboxType txt_address1 = ReportUtil.AddTextbox("txt_address1" + sufx, Company_txt.ReportItems, x, y, wd, ht);
                txt_address1.Value = "=Fields!" + PRINT_INVOICE.COMPANY_ADDRESS_1 + ".Value";
                txt_address1.Style.Font(PrintConfig.HeaderAddressTxtFont, PrintConfig.Company_address_FontSize, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_address1.Style.TextAlign = TextAlignRptEnum.Center;
                //txt_address1.Style.BackgroundColor.Color = Color.AntiqueWhite;

                x = 0; y = y + 0.17; wd = wd + 0; ht = 0.18;
                TextboxType txt_address2 = ReportUtil.AddTextbox("txt_address2" + sufx, Company_txt.ReportItems, x, y, wd, ht);
                txt_address2.Value = "=Fields!" + PRINT_INVOICE.COMPANY_ADDRESS_2 + ".Value";
                txt_address2.Style.Font(PrintConfig.HeaderAddressTxtFont, PrintConfig.Company_address_FontSize, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_address2.Style.TextAlign = TextAlignRptEnum.Center;
                //t_address2.Style.BackgroundColor.Color = Color.SeaGreen;

                x = 0.03; y = y + 0.17; wd = wd - x; ht = 0.18;
                TextboxType txt_company_tin = ReportUtil.AddTextbox("txt_company_tin" + sufx, Company_txt.ReportItems, x, y, wd, ht);
                txt_company_tin.Value = "=Fields!" + PRINT_INVOICE.COMPANY_GSTIN + ".Value";
                txt_company_tin.Style.Font(PrintConfig.HeaderAddressTxtFont, PrintConfig.Company_address_FontSize, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_company_tin.Style.TextAlign = TextAlignRptEnum.Center;
                //txt_company_tin.Style.BackgroundColor.Color = Color.RoyalBlue;

            }

            #endregion [ Company txt]

            #endregion [ COMPANY AREA]

            #region [ Party AREA]

            x = 0; y = 0; wd = 4.5; ht = 0.1;
            RectangleType party_area = ReportUtil.AddRectangle("party_area" + sufx, party_rect.ReportItems, x, y, wd, ht);
            party_area.Style.BorderStyle.Default = BorderStyleEnum.None;
            party_area.Style.BorderStyle.Right = BorderStyleEnum.Outset;
            //party_area.Style.BackgroundColor.Color = Color.Green;

            x = wd; y = 0; wd = party_rect.Width.Value - wd; ht = ht + 0;
            RectangleType nodt_rect = ReportUtil.AddRectangle("nodt_rect" + sufx, party_rect.ReportItems, x, y, wd, ht);
            nodt_rect.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //nodt_rect.Style.BackgroundColor.Color = Color.DarkOrange;

            #region [ Party - Address]

            x = 0.18; y = 0.12; wd = party_area.Width.Value - (x + 0.2); ht = 0.20;
            TextboxType lbl_partyname = ReportUtil.AddTextbox("lbl_partyname" + sufx, party_area.ReportItems, x, y, wd, ht);
            lbl_partyname.Value = "TO.M/S.  ";
            lbl_partyname.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_partyname.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_partyname.Style.BackgroundColor.Color = Color.Salmon;

            x = 0.8; y = 0.08; wd = party_area.Width.Value - (x + 0.2); ht = 0.20;
            TextboxType txt_partyname = ReportUtil.AddTextbox("txt_partyname" + sufx, party_area.ReportItems, x, y, wd, ht);
            txt_partyname.Value = "=Fields!" + PRINT_INVOICE.PARTY_NAME + ".Value";
            txt_partyname.CanGrow = true;
            txt_partyname.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_partyname.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_partyname.Style.BackgroundColor.Color = Color.SandyBrown;

            x = x + 0; y = y + 0.20; wd = party_area.Width.Value - (x + 0.2); ht = ht + 0;
            TextboxType txt_street1 = ReportUtil.AddTextbox("txtStreet1" + sufx, party_area.ReportItems, x, y, wd, ht);
            txt_street1.CanGrow = true;
            txt_street1.Value = "=Fields!" + PRINT_INVOICE.PARTY_STREET_1 + ".Value";
            txt_street1.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_street1.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_street1.Style.BackgroundColor.Color = Color.SeaGreen;

            x = x + 0; y = y + 0.20; wd = party_area.Width.Value - (x + 0.2); ht = ht + 0;
            TextboxType txt_street_2 = ReportUtil.AddTextbox("txt_street_2" + sufx, party_area.ReportItems, x, y, wd, ht);
            txt_street_2.CanGrow = true;
            txt_street_2.Value = "=Fields!" + PRINT_INVOICE.PARTY_STREET_2 + ".Value";
            txt_street_2.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_street_2.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_street_2.Style.BackgroundColor.Color = Color.SeaGreen;

            x = x + 0; y = y + 0.2; wd = wd + 0; ht = ht + 0;
            TextboxType txt_city = ReportUtil.AddTextbox("txt_city" + sufx, party_area.ReportItems, x, y, wd, ht);
            txt_city.Value = "=Fields!" + PRINT_INVOICE.PARTY_CITY + ".Value";
            txt_city.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_city.Style.TextAlign = TextAlignRptEnum.Left;
            txt_city.CanGrow = true;
            //txt_city.Style.BackgroundColor.Color = Color.SkyBlue;

            x = x + 0; y = y + 0.2; wd = wd + 0; ht = ht + 0;
            TextboxType txt_State = ReportUtil.AddTextbox("txt_State" + sufx, party_area.ReportItems, x, y, wd, ht);
            txt_State.Value = "=Fields!" + PRINT_INVOICE.PARTY_STATE + ".Value";
            txt_State.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_State.Style.TextAlign = TextAlignRptEnum.Left;
            txt_State.CanGrow = true;
            //txt_State.Style.BackgroundColor.Color = Color.SkyBlue;

            x = x + 0; y = y + 0.18; wd = wd + 0; ht = ht + 0;
            TextboxType txt_tin = ReportUtil.AddTextbox("txt_tin" + sufx, party_area.ReportItems, x, y, wd, ht);
            txt_tin.Value = "=Fields!" + PRINT_INVOICE.PARTY_GSTIN + ".Value";
            txt_tin.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_tin.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_tin.Style.BackgroundColor.Color = Color.Sienna;

            #endregion [ Party - Address ]

            #region [ No - Dt ]

            // Labels

            x = 0.20; y = lbl_partyname.Top.Value; wd = nodt_rect.Width.Value - (x + 0.01); ht = 0.25;
            TextboxType lbl_no = ReportUtil.AddTextbox("lbl_no" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            lbl_no.Value = "No  ";
            lbl_no.Style.Font(PrintConfig.PartyTxtFont, 16, FontWeightEnum.Bolder, FontStyleEnum.Normal);

            x = x + 0; y = lbl_no.Top.Value + 0.4; wd = wd + 0; ht = 0.20;
            TextboxType lbl_date = ReportUtil.AddTextbox("lbl_date" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            lbl_date.Value = "Date  ";
            lbl_date.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Normal, FontStyleEnum.Normal);

            x = x + 0; y = y + 0.25; wd = wd + 0; ht = 0.20;
            TextboxType lbl_transport = ReportUtil.AddTextbox("lbl_transport" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            lbl_transport.Value = "Transport";
            lbl_transport.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);


            x = x + 0; y = y + 0.25; wd = wd + 0; ht = 0.20;
            TextboxType lbl_deliveryto = ReportUtil.AddTextbox("lbl_deliveryto" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            lbl_deliveryto.Value = "Delivery To";
            lbl_deliveryto.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);

            x = x + 0; y = y + 0.25; wd = wd + 0; ht = 0.20;
            TextboxType lbl_bundel = ReportUtil.AddTextbox("lbl_bundel" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            lbl_bundel.Value = "No of Bundel";
            lbl_bundel.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);

            // fields value

            x = 1.2; y = lbl_partyname.Top.Value - 0.001; wd = nodt_rect.Width.Value - (x + 0.01); ht = 0.25;
            TextboxType txt_no = ReportUtil.AddTextbox("txt_no" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            txt_no.Value = "=Fields!" + PRINT_INVOICE.INVOICE_NO + ".Value";
            txt_no.Style.Font(PrintConfig.PartyTxtFont, 16, FontWeightEnum.Bolder, FontStyleEnum.Normal);

            x = x + 0; y = lbl_date.Top.Value; wd = wd + 0; ht = 0.20;
            TextboxType txt_date = ReportUtil.AddTextbox("txt_date" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            txt_date.Value = "=Fields!" + PRINT_INVOICE.INVOICE_DATE + ".Value";
            txt_date.Style.Format = "dd-MM-yyyy";
            txt_date.Style.Font(PrintConfig.PartyTxtFont, 12, FontWeightEnum.Normal, FontStyleEnum.Normal);

            x = x + 0; y = lbl_transport.Top.Value; wd = wd + 0; ht = 0.20;
            TextboxType txt_transport = ReportUtil.AddTextbox("txt_transport" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            txt_transport.Value = "=Fields!" + PRINT_INVOICE.TRANSPORT + ".Value";
            txt_transport.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_transport.CanGrow = true;

            x = x + 0; y = lbl_deliveryto.Top.Value; wd = wd + 0; ht = 0.20;
            TextboxType txt_deliveryto = ReportUtil.AddTextbox("txt_deliveryto" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            txt_deliveryto.Value = "=Fields!" + PRINT_INVOICE.DELIVERYTO + ".Value";
            txt_deliveryto.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);

            x = x + 0; y = lbl_bundel.Top.Value; wd = wd + 0; ht = 0.20;
            TextboxType txt_bundel = ReportUtil.AddTextbox("txt_bundel" + sufx, nodt_rect.ReportItems, x, y, wd, ht);
            txt_bundel.Value = "=Fields!" + PRINT_INVOICE.BUNDEL + ".Value";
            txt_bundel.Style.Font(PrintConfig.PartyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);


            #endregion [ No - Dt ]

            #endregion [Party area]

            #region [ ITEMS DETAILS AREA]

            x = 0; y = 0; wd = items_rect.Width.Value; ht = 0.1;
            ReportUtil.AddSubreport("subreport_Print_invoiceItems", "P_InvoiceItem", items_rect.ReportItems, x, y, wd, ht);

            #endregion [ ITEMS DETAILS AREA]

            #region [SUB TOTAL AREA]

            if (PrintConfig.TaxType == Core.SGST)
            {
                x = 0.03; y = 0.05; wd = 1.5; ht = 0.16;
                TextboxType lbl_eoe = ReportUtil.AddTextbox("lbl_eoe" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                lbl_eoe.Value = "E&OE";
                lbl_eoe.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                lbl_eoe.Style.TextAlign = TextAlignRptEnum.Left;
                //lbl_eoe.Style.BackgroundColor.Color = Color.DeepSkyBlue;

                x = 2.18; y = 0.03; wd = 1.35; ht = 0.16;
                TextboxType lbl_total = ReportUtil.AddTextbox("lbl_total" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                lbl_total.Value = "Total";
                lbl_total.Style.Font(PrintConfig.BodyTxtFont, 9, FontWeightEnum.Normal, FontStyleEnum.Normal);
                lbl_total.Style.TextAlign = TextAlignRptEnum.Right;

                x = 3.73; y = 0; wd = 0.6; ht = 0.2;
                RectangleType total_qty = ReportUtil.AddRectangle("total_qty" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_qty.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_qty.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_qty.Style.BorderStyle.Right = BorderStyleEnum.Outset;

                x = 0; y = 0.03; wd = 0.6; ht = 0.16;
                TextboxType txt_qtys = ReportUtil.AddTextbox("txt_qtys" + sufx, total_qty.ReportItems, x, y, wd, ht);
                txt_qtys.Value = "=Fields!" + PRINT_INVOICE.TOTAL_QTY + ".Value";
                txt_qtys.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_qtys.Style.TextAlign = TextAlignRptEnum.Center;

                x = 4.782; y = 0; wd = 0.65; ht = 0.2;
                RectangleType total_amt = ReportUtil.AddRectangle("total_amt" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_amt.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_amt.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_amt.Style.BorderStyle.Right = BorderStyleEnum.Outset;
                //total_amt.Style.BackgroundColor.Color = Color.OrangeRed;

                x = 0; y = 0.03; wd = 0.63; ht = 0.16;
                TextboxType txt_total = ReportUtil.AddTextbox("txt_total" + sufx, total_amt.ReportItems, x, y, wd, ht);
                txt_total.Value = "=Fields!" + PRINT_INVOICE.TAXABLE_VALUE + ".Value";
                txt_total.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_total.Style.TextAlign = TextAlignRptEnum.Right;

                x = 5.64; y = 0; wd = 0.55; ht = 0.2;
                RectangleType total_sgst_rect = ReportUtil.AddRectangle("total_sgst_rect" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_sgst_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_sgst_rect.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_sgst_rect.Style.BorderStyle.Right = BorderStyleEnum.Outset;
                //total_sgst_rect.Style.BackgroundColor.Color = Color.BlueViolet;

                x = 0; y = 0.03; wd = 0.52; ht = 0.16;
                TextboxType total_sgst = ReportUtil.AddTextbox("total_sgst" + sufx, total_sgst_rect.ReportItems, x, y, wd, ht);
                total_sgst.Value = "=Fields!" + PRINT_INVOICE.TOTAL_SGST + ".Value";
                total_sgst.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                total_sgst.Style.TextAlign = TextAlignRptEnum.Right;

                x = 6.39; y = 0; wd = 0.565; ht = 0.2;
                RectangleType total_cgst_rec = ReportUtil.AddRectangle("total_cgst_rec" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_cgst_rec.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_cgst_rec.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_cgst_rec.Style.BorderStyle.Right = BorderStyleEnum.Outset;
                //total_cgst_rec.Style.BackgroundColor.Color = Color.OrangeRed;

                x = 0; y = 0.03; wd = 0.52; ht = 0.16;
                TextboxType total_cgst = ReportUtil.AddTextbox("total_cgst" + sufx, total_cgst_rec.ReportItems, x, y, wd, ht);
                total_cgst.Value = "=Fields!" + PRINT_INVOICE.TOTAL_CGST + ".Value";
                total_cgst.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                total_cgst.Style.TextAlign = TextAlignRptEnum.Right;

                x = 6.92; y = 0; wd = 0.71; ht = 0.2;
                RectangleType total_sub_rec = ReportUtil.AddRectangle("total_sub_rec" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_sub_rec.Style.BorderStyle.Default = BorderStyleEnum.None;
                //total_sub_rec.Style.BackgroundColor.Color = Color.OrangeRed;

                x = 0; y = 0.03; wd = 0.69; ht = 0.16;
                TextboxType total_sub = ReportUtil.AddTextbox("total_sub" + sufx, total_sub_rec.ReportItems, x, y, wd, ht);
                total_sub.Value = "=Fields!" + PRINT_INVOICE.TOTAL_SUB + ".Value";
                total_sub.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                total_sub.Style.TextAlign = TextAlignRptEnum.Right;

            }
            else if (PrintConfig.TaxType == Core.IGST)
            {

                x = 0.03; y = 0.05; wd = 1.5; ht = 0.16;
                TextboxType lbl_eoe = ReportUtil.AddTextbox("lbl_eoe" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                lbl_eoe.Value = "E&OE";
                lbl_eoe.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                lbl_eoe.Style.TextAlign = TextAlignRptEnum.Left;
                //lbl_eoe.Style.BackgroundColor.Color = Color.DeepSkyBlue;

                x = 2.05; y = 0.03; wd = 1.25; ht = 0.16;
                TextboxType lbl_total = ReportUtil.AddTextbox("lbl_total" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                lbl_total.Value = "Total";
                lbl_total.Style.Font("Tahoma", 9, FontWeightEnum.Normal, FontStyleEnum.Normal);
                lbl_total.Style.TextAlign = TextAlignRptEnum.Right;

                x = 4.25; y = 0; wd = 0.6; ht = 0.2;
                RectangleType total_qty = ReportUtil.AddRectangle("total_qty" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_qty.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_qty.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_qty.Style.BorderStyle.Right = BorderStyleEnum.Outset;

                x = 0; y = 0.03; wd = 0.6; ht = 0.16;
                TextboxType txt_qtys = ReportUtil.AddTextbox("txt_qtys" + sufx, total_qty.ReportItems, x, y, wd, ht);
                txt_qtys.Value = "=Fields!" + PRINT_INVOICE.TOTAL_QTY + ".Value";
                txt_qtys.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_qtys.Style.TextAlign = TextAlignRptEnum.Center;

                x = 5.3; y = 0; wd = 0.65; ht = 0.2;
                RectangleType total_amt = ReportUtil.AddRectangle("total_amt" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_amt.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_amt.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_amt.Style.BorderStyle.Right = BorderStyleEnum.Outset;
                //total_amt.Style.BackgroundColor.Color = Color.OrangeRed;

                x = 0; y = 0.03; wd = 0.63; ht = 0.16;
                TextboxType txt_total = ReportUtil.AddTextbox("txt_total" + sufx, total_amt.ReportItems, x, y, wd, ht);
                txt_total.Value = "=Fields!" + PRINT_INVOICE.TAXABLE_VALUE + ".Value";
                txt_total.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                txt_total.Style.TextAlign = TextAlignRptEnum.Right;

                x = 6.2; y = 0; wd = 0.752; ht = 0.2;
                RectangleType total_igst_rect = ReportUtil.AddRectangle("total_igst_rect" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_igst_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
                total_igst_rect.Style.BorderStyle.Left = BorderStyleEnum.Outset;
                total_igst_rect.Style.BorderStyle.Right = BorderStyleEnum.Outset;
                //total_igst_rect.Style.BackgroundColor.Color = Color.BlueViolet;

                x = 0; y = 0.03; wd = 0.73; ht = 0.16;
                TextboxType total_igst = ReportUtil.AddTextbox("total_igst" + sufx, total_igst_rect.ReportItems, x, y, wd, ht);
                total_igst.Value = "=Fields!" + PRINT_INVOICE.TOTAL_SGST + ".Value";
                total_igst.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                total_igst.Style.TextAlign = TextAlignRptEnum.Right;

                x = 6.92; y = 0; wd = 0.71; ht = 0.2;
                RectangleType total_sub_rec = ReportUtil.AddRectangle("total_sub_rec" + sufx, subtotal_rect.ReportItems, x, y, wd, ht);
                total_sub_rec.Style.BorderStyle.Default = BorderStyleEnum.None;
                //total_sub_rec.Style.BackgroundColor.Color = Color.OrangeRed;

                x = 0; y = 0.03; wd = 0.69; ht = 0.16;
                TextboxType total_sub = ReportUtil.AddTextbox("total_sub" + sufx, total_sub_rec.ReportItems, x, y, wd, ht);
                total_sub.Value = "=Fields!" + PRINT_INVOICE.TOTAL_SUB + ".Value";
                total_sub.Style.Font("Tahoma", 7, FontWeightEnum.Normal, FontStyleEnum.Normal);
                total_sub.Style.TextAlign = TextAlignRptEnum.Right;

            }

            #endregion [SUB TOTAL AREA]

            #region [notes]

            x = 0; y = 0; wd = 4.93; ht = 0.6;
            RectangleType rect_notes = ReportUtil.AddRectangle("rect_notes" + sufx, total_rect.ReportItems, x, y, wd, ht);
            rect_notes.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //rect_notes.Style.BackgroundColor.Color = Color.OrangeRed;

            x = 0.05; y = 0.06; wd = 4.5; ht = 0.26;
            TextboxType txt_terms_1 = ReportUtil.AddTextbox("txt_terms_1" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_terms_1.Value = "=Fields!" + PRINT_INVOICE.TERMS_1 + ".Value";
            txt_terms_1.CanGrow = true;
            txt_terms_1.Style.Font(PrintConfig.BodyTxtFont, 6, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_terms_1.Style.TextAlign = TextAlignRptEnum.Left;

            x = 0.05; y = txt_terms_1.Height.Value + 0.08; wd = wd + 0; ht = 0.26;
            TextboxType txt_terms_2 = ReportUtil.AddTextbox("txt_terms_2" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_terms_2.Value = "=Fields!" + PRINT_INVOICE.TERMS_2 + ".Value";
            txt_terms_2.Style.Font(PrintConfig.BodyTxtFont, 6, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_terms_2.Style.TextAlign = TextAlignRptEnum.Left;

            x = 0.05; y = 0.15 + y; wd = wd + 0; ht = 0.26;
            TextboxType txt_terms_3 = ReportUtil.AddTextbox("txt_terms_3" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_terms_3.Value = "=Fields!" + PRINT_INVOICE.TERMS_3 + ".Value";
            txt_terms_3.Style.Font(PrintConfig.BodyTxtFont, 6, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_terms_3.Style.TextAlign = TextAlignRptEnum.Left;

            x = 0.05; y = 0.15 + y; wd = wd + 0; ht = 0.26;
            TextboxType txt_terms_4 = ReportUtil.AddTextbox("txt_terms_4" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_terms_4.Value = "=Fields!" + PRINT_INVOICE.TERMS_4 + ".Value";
            txt_terms_4.Style.Font(PrintConfig.BodyTxtFont, 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_terms_4.Style.TextAlign = TextAlignRptEnum.Left;

            double notegap = 0.15;

            x = 0.05; y = notegap + 0.04 + y; wd = wd + 0; ht = 0.26;
            TextboxType txt_account_no = ReportUtil.AddTextbox("txt_account_no" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_account_no.Value = "=Fields!" + PRINT_INVOICE.ACCOUNT_NO + ".Value";
            txt_account_no.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_account_no.Style.TextAlign = TextAlignRptEnum.Left;

            x = 0.05; y = notegap + y; wd = wd + 0; ht = 0.26;
            TextboxType txt_ifsc_code = ReportUtil.AddTextbox("txt_ifsc_code" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_ifsc_code.Value = "=Fields!" + PRINT_INVOICE.IFSC_CODE + ".Value";
            txt_ifsc_code.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_ifsc_code.Style.TextAlign = TextAlignRptEnum.Left;

            x = 0.05; y = notegap + y; wd = wd + 0; ht = 0.26;
            TextboxType txt_bank_name = ReportUtil.AddTextbox("txt_bank_name" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_bank_name.Value = "=Fields!" + PRINT_INVOICE.BANK_NAME + ".Value";
            txt_bank_name.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_bank_name.Style.TextAlign = TextAlignRptEnum.Left;

            x = 0.05; y = notegap + y; wd = wd + 0; ht = 0.20;
            TextboxType txt_bank_branch = ReportUtil.AddTextbox("txt_bank_branch" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            txt_bank_branch.Value = "=Fields!" + PRINT_INVOICE.BANK_BRANCH + ".Value";
            txt_bank_branch.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_bank_branch.Style.TextAlign = TextAlignRptEnum.Left;

            //x = 0.05; y = 0.06 + y; wd = 4.5; ht = 0.26;
            //TextboxType txt_notes = ReportUtil.AddTextbox("txt_notes" + sufx, rect_notes.ReportItems, x, y, wd, ht);
            //txt_notes.Value = "=Fields!" + PRINT_INVOICE.NOTES + ".Value";
            //txt_notes.CanGrow = true;
            //txt_notes.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            //txt_notes.Style.TextAlign = TextAlignRptEnum.Left;

            #endregion [notes]

            #region [Labels]

            x = 4.93; y = 0; wd = 2.72; ht = 0.1;
            RectangleType rect_totallbl = ReportUtil.AddRectangle("rect_totallbl" + sufx, total_rect.ReportItems, x, y, wd, ht);
            rect_totallbl.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //rect_totallbl.Style.BackgroundColor.Color = Color.Tan;

            x = 0; y = 0; wd = 2.72; ht = 0.01;
            RectangleType bx_1 = ReportUtil.AddRectangle("bx_1" + sufx, rect_totallbl.ReportItems, x, y, wd, ht);
            bx_1.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            //bx_1.Style.BackgroundColor.Color = Color.Tan;

            x = 0; y = 0.03; wd = 1.8; ht = 0.18;
            TextboxType lbl_taxablevalue = ReportUtil.AddTextbox("lbl_taxablevalue" + sufx, bx_1.ReportItems, x, y, wd, ht);
            lbl_taxablevalue.Value = "  Taxable Value";
            lbl_taxablevalue.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_taxablevalue.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_taxablevalue.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 1.85; y = lbl_taxablevalue.Top.Value; wd = 0.82; ht = 0.12;
            TextboxType txt_taxable_amt = ReportUtil.AddTextbox("txt_taxable_amt" + sufx, bx_1.ReportItems, x, y, wd, ht);
            txt_taxable_amt.Value = "=Fields!" + PRINT_INVOICE.TAXABLE_VALUE + ".Value";
            txt_taxable_amt.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_taxable_amt.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_taxable_amt.Style.BackgroundColor.Color = Color.White;


            x = 0; y = 0.01; wd = 2.72; ht = 0.01;
            RectangleType bx_2 = ReportUtil.AddRectangle("bx_2" + sufx, rect_totallbl.ReportItems, x, y, wd, ht);
            bx_2.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            //bx_2.Style.BackgroundColor.Color = Color.Tan;

            x = 0; y = 0.03; wd = 1.8; ht = 0.18;
            TextboxType lbl_Sgst = ReportUtil.AddTextbox("lbl_Sgst" + sufx, bx_2.ReportItems, x, y, wd, ht);
            lbl_Sgst.Value = "=Fields!" + PRINT_INVOICE.SGST_PERCENT + ".Value";
            lbl_Sgst.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_Sgst.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_Sgst.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 1.85; y = lbl_Sgst.Top.Value; wd = 0.82; ht = 0.12;
            TextboxType txt_Sgst = ReportUtil.AddTextbox("txt_Sgst" + sufx, bx_2.ReportItems, x, y, wd, ht);
            txt_Sgst.Value = "=Fields!" + PRINT_INVOICE.TOTAL_SGST + ".Value";
            txt_Sgst.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_Sgst.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_Sgst.Style.BackgroundColor.Color = Color.White;


            x = 0; y = 0.02; wd = 2.72; ht = 0.01;
            RectangleType bx_3 = ReportUtil.AddRectangle("bx_3" + sufx, rect_totallbl.ReportItems, x, y, wd, ht);
            bx_3.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            //bx_3.Style.BackgroundColor.Color = Color.MistyRose;

            x = 0; y = 0.03; wd = 1.8; ht = 0.18;
            TextboxType lbl_cgst = ReportUtil.AddTextbox("lbl_cgst" + sufx, bx_3.ReportItems, x, y, wd, ht);
            lbl_cgst.Value = "=Fields!" + PRINT_INVOICE.CGST_PERCENT + ".Value";
            lbl_cgst.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_cgst.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_cgst.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 1.85; y = lbl_cgst.Top.Value; wd = 0.82; ht = 0.12;
            TextboxType txt_cgst = ReportUtil.AddTextbox("txt_cgst" + sufx, bx_3.ReportItems, x, y, wd, ht);
            txt_cgst.Value = "=Fields!" + PRINT_INVOICE.TOTAL_CGST + ".Value";
            txt_cgst.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_cgst.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_cgst.Style.BackgroundColor.Color = Color.White;

            x = 0; y = 0.03; wd = 2.72; ht = 0.01;
            RectangleType bx_4 = ReportUtil.AddRectangle("bx_4" + sufx, rect_totallbl.ReportItems, x, y, wd, ht);
            bx_1.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            //bx_1.Style.BackgroundColor.Color = Color.Tan;

            x = 0; y = 0.03; wd = 1.8; ht = 0.18;
            TextboxType lbl_GSTTotal = ReportUtil.AddTextbox("lbl_GSTTotal" + sufx, bx_4.ReportItems, x, y, wd, ht);
            lbl_GSTTotal.Value = "  TOTAL GST TAX ";
            lbl_GSTTotal.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_GSTTotal.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_GSTTotal.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 1.85; y = lbl_GSTTotal.Top.Value; wd = 0.82; ht = 0.12;
            TextboxType txt_GSTTotal = ReportUtil.AddTextbox("txt_GSTTotal" + sufx, bx_4.ReportItems, x, y, wd, ht);
            txt_GSTTotal.Value = "=Fields!" + PRINT_INVOICE.GSTTOTAL + ".Value";
            txt_GSTTotal.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_GSTTotal.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_GSTTotal.Style.BackgroundColor.Color = Color.White;


            x = 0; y = 0.04; wd = 2.72; ht = 0.01;
            RectangleType bx_5 = ReportUtil.AddRectangle("bx_5" + sufx, rect_totallbl.ReportItems, x, y, wd, ht);
            bx_1.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            //bx_1.Style.BackgroundColor.Color = Color.Tan;

            x = 0; y = 0.03; wd = 1.8; ht = 0.18;
            TextboxType txt_ledger = ReportUtil.AddTextbox("txt_ledger" + sufx, bx_5.ReportItems, x, y, wd, ht);
            txt_ledger.Value = "=Fields!" + PRINT_INVOICE.LEDGER + ".Value";
            txt_ledger.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_ledger.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_ledger.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 1.85; y = txt_ledger.Top.Value; wd = 0.82; ht = 0.12;
            TextboxType txt_additional = ReportUtil.AddTextbox("txt_additional" + sufx, bx_5.ReportItems, x, y, wd, ht);
            txt_additional.Value = "=Fields!" + PRINT_INVOICE.ADDITIONAL + ".Value";
            txt_additional.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_additional.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_additional.Style.BackgroundColor.Color = Color.White;


            x = 0; y = 0.05; wd = 2.72; ht = 0.01;
            RectangleType bx_6 = ReportUtil.AddRectangle("bx_6" + sufx, rect_totallbl.ReportItems, x, y, wd, ht);
            bx_1.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            //bx_1.Style.BackgroundColor.Color = Color.Tan;

            x = 0; y = 0.03; wd = 1.8; ht = 0.18;
            TextboxType lbl_round = ReportUtil.AddTextbox("lbl_round" + sufx, bx_6.ReportItems, x, y, wd, ht);
            lbl_round.Value = "  Round off ";
            lbl_round.Style.Font(PrintConfig.BodyTxtFont, 8, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_round.Style.TextAlign = TextAlignRptEnum.Left;
            //lbl_round.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 1.85; y = lbl_round.Top.Value; wd = 0.82; ht = 0.12;
            TextboxType txt_round = ReportUtil.AddTextbox("txt_round" + sufx, bx_6.ReportItems, x, y, wd, ht);
            txt_round.Value = "=Fields!" + PRINT_INVOICE.ROUNDS + ".Value";
            txt_round.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_round.Style.TextAlign = TextAlignRptEnum.Right;
            //txt_round.Style.BackgroundColor.Color = Color.Beige;

            #endregion [total field]

            #region [Grand total]

            x = 0; y = 0; wd = 4.93; ht = 0.45;
            RectangleType amtnwords = ReportUtil.AddRectangle("amtnwords" + sufx, grandtotal_rect.ReportItems, x, y, wd, ht);
            amtnwords.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //amtnwords.Style.BackgroundColor.Color = Color.Red;

            x = 0.05; y = 0.01; wd = 4.7; ht = 0.4;
            TextboxType txt_amtnwords = ReportUtil.AddTextbox("txt_amtnwords" + sufx, amtnwords.ReportItems, x, y, wd, ht);
            txt_amtnwords.Value = "=Fields!" + PRINT_INVOICE.AMOUNT_IN_WORDS + ".Value";
            txt_amtnwords.CanGrow = true;
            txt_amtnwords.Style.Font(PrintConfig.BodyTxtFont, 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_amtnwords.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_amtnwords.Style.BackgroundColor.Color = Color.DeepSkyBlue;

            x = 4.93; y = 0.08; wd = 1.3; ht = 0.28;
            TextboxType lbl_grandtotal = ReportUtil.AddTextbox("lbl_grandtotal" + sufx, grandtotal_rect.ReportItems, x, y, wd, ht);
            lbl_grandtotal.Value = "  GRAND TOTAL";
            lbl_grandtotal.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_grandtotal.Style.TextAlign = TextAlignRptEnum.Left;
            // lbl_grandtotal.Style.BackgroundColor.Color = Color.DeepSkyBlue;
            //lbl_grandtotal.Style.BorderStyle.Left = BorderStyleEnum.Outset;

            x = 6.20; y = 0.08; wd = 1.43; ht = 0.28;
            TextboxType txt_grandtotal = ReportUtil.AddTextbox("txt_grandtotal" + sufx, grandtotal_rect.ReportItems, x, y, wd, ht);
            txt_grandtotal.Value = "=Fields!" + PRINT_INVOICE.GRANDTOTAL + ".Value";
            txt_grandtotal.Style.Font(PrintConfig.BodyTxtFont, 12, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            txt_grandtotal.Style.TextAlign = TextAlignRptEnum.Right;
            // txt_grandtotal.Style.BackgroundColor.Color = Color.Tomato;

            #endregion [Grand total]

            //#endregion [TOTAL AREA]

            #region [for SIGN AREA]

            #region [amounts in words]
            x = 0; y = 0; wd = 4.5; ht = 0.5;
            RectangleType receiver_rect = ReportUtil.AddRectangle("receiver_rect" + sufx, sign_rect.ReportItems, x, y, wd, ht);
            receiver_rect.Style.BorderStyle.Default = BorderStyleEnum.None;
            //amtnwords.Style.BackgroundColor.Color = Color.Red;

            x = 0.05; y = 0.08; wd = wd - 0.2; ht = 0.18;
            TextboxType txt_receiversign = ReportUtil.AddTextbox("txt_receiversign" + sufx, receiver_rect.ReportItems, x, y, wd, ht);
            txt_receiversign.Value = "Receiver Signature";
            //txt_receiversign.CanGrow = true;
            txt_receiversign.Style.Font(PrintConfig.BodyTxtFont, 10, FontWeightEnum.Normal, FontStyleEnum.Normal);
            txt_receiversign.Style.TextAlign = TextAlignRptEnum.Left;
            //txt_receiversign.Style.BackgroundColor.Color = Color.Violet;

            #endregion [amounts in words]

            #region [Signature]

            x = amtnwords.Width.Value; y = 0; wd = 2.72; ht = 0.95;
            RectangleType forspace = ReportUtil.AddRectangle("forspace" + sufx, sign_rect.ReportItems, x, y, wd, ht);
            forspace.Style.BorderStyle.Default = BorderStyleEnum.Outset;
            //forspace.Style.BackgroundColor.Color = Color.Violet;

            x = 0.05; y = 0.06; wd = 2.4; ht = 0.16;
            TextboxType lbl_for = ReportUtil.AddTextbox("lbl_for" + sufx, forspace.ReportItems, x, y, wd, ht);
            lbl_for.Value = "For";
            lbl_for.Style.Font(PrintConfig.FORTxtFont, 9, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_for.Style.TextAlign = TextAlignRptEnum.Left;

            x = x + 0.3; y = 0.04; wd = 2.7 - x; ht = 0.20;
            TextboxType lbl_forcompany = ReportUtil.AddTextbox("lbl_forcompany" + sufx, forspace.ReportItems, x, y, wd, ht);
            lbl_forcompany.Value = "=Fields!" + PRINT_INVOICE.COMPANY_NAME + ".Value";
            lbl_forcompany.Style.Font(PrintConfig.FORTxtFont, 10, FontWeightEnum.Bolder, FontStyleEnum.Normal);
            lbl_forcompany.Style.TextAlign = TextAlignRptEnum.Left;

            x = lbl_for.Left.Value + 0.2; y = 0.70; wd = 2.7 - x; ht = 0.15;
            TextboxType lbl_sign = ReportUtil.AddTextbox("lbl_sign" + sufx, forspace.ReportItems, x, y, wd, ht);
            lbl_sign.Value = "    Authorized signatory";
            lbl_sign.Style.Font(PrintConfig.BodyTxtFont, 9, FontWeightEnum.Normal, FontStyleEnum.Normal);
            lbl_sign.Style.TextAlign = TextAlignRptEnum.Left;

            #endregion [Signature]

            #endregion [for SIGN AREA]

            #region [Juridication]

            if (PrintConfig.PrintJuridication == true)
            {
                x = 0.09; y = 0.01; wd = juridiction_rect.Width.Value - x; ht = 0.16;
                TextboxType lbl_stj = ReportUtil.AddTextbox("lbl_stj" + sufx, juridiction_rect.ReportItems, x, y, wd, ht);
                lbl_stj.Value = "Subject to " + PrintConfig.JuridicationTxt + " Juridication";
                lbl_stj.Style.Font(PrintConfig.BodyTxtFont, 7, FontWeightEnum.Bolder, FontStyleEnum.Normal);
                lbl_stj.Style.TextAlign = TextAlignRptEnum.Left;
            }
            #endregion [Juridication]

        }// fn build details

    }//cls
}//ns
