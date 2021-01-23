using System.Drawing;

namespace CXLIB
{
    public static class ReportUtil
    {
        public static bool DESIGN_MODE = true;

        public static void AttachRulers(ReportItemsType pReportItems, double pWidth, double pHeight)
        {
            if (DESIGN_MODE == true)
            {
                AttachHorizRuler(pReportItems, pWidth);
                AttachVertRuler(pReportItems, pHeight);
            }
        }

        public static void AttachHorizRuler(ReportItemsType pReportItems, double pWidth)
        {
            Color vRulerColor = Color.LightGray;
            //LineType lineHoriz = AddLine("lineHoriz", pReportItems, 0, 0, pWidth, 0);
            //lineHoriz.Style.BorderColor.Default.Color = vRulerColor;

            for (int x = 0; x <= (int)pWidth; x++)
            {
                LineType lineInch = AddLine("lineInchX" + x, pReportItems, x, -0.1, 0, 0.2);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;

                TextboxType txtInch = AddTextbox("txtInchX" + x, pReportItems, x + 0.02, 0.01, 0.2, 0.2);
                txtInch.Value = x + "";
                txtInch.Style.Color.Color = vRulerColor;
                txtInch.Style.Font("Arial", 6, FontWeightEnum.Normal, FontStyleEnum.Normal);
                
            }

            int n = 1;
            for (double x = 0; x <= pWidth; x += 0.5)
            {
                LineType lineInch = AddLine("lineInch2X" + n, pReportItems, x, -0.05, 0, 0.1);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                n++;
            }

            n = 1;
            for (double x = 0; x <= pWidth; x += 0.25)
            {
                LineType lineInch = AddLine("lineInch4X" + n, pReportItems, x, -0.025, 0, 0.05);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                n++;
            }

            n = 1;
            for (double x = 0; x <= pWidth; x += 0.125)
            {
                LineType lineInch = AddLine("lineInch8X" + n, pReportItems, x, -0.0125, 0, 0.025);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                n++;
            }
        }

        public static void AttachVertRuler(ReportItemsType pReportItems, double pHeight)
        {
            Color vRulerColor = Color.LightGray;
            //LineType lineVert = AddLine("lineVert", pReportItems, 0, 0, 0, pHeight);
            //lineVert.Style.BorderColor.Default.Color = vRulerColor;

            for (int y = 0; y <= (int)pHeight; y++)
            {
                LineType lineInch = AddLine("lineInchY" + y, pReportItems, -0.1, y, 0.2, 0);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                TextboxType txtInch = AddTextbox("txtInchY" + y, pReportItems, 0.02, y + 0.02, 0.2, 0.2);
                txtInch.Value = y + "";
                txtInch.Style.Color.Color = vRulerColor;
                txtInch.Style.Font("Arial", 6, FontWeightEnum.Normal, FontStyleEnum.Normal);
            }


            int n = 1;
            for (double y = 0; y <= pHeight; y += 0.5)
            {
                LineType lineInch = AddLine("lineInch2Y" + n, pReportItems, -0.05, y, 0.1, 0);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                n++;
            }

            n = 1;
            for (double y = 0; y <= pHeight; y += 0.25)
            {
                LineType lineInch = AddLine("lineInch4Y" + n, pReportItems, -0.025, y, 0.05, 0);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                n++;
            }

            n = 1;
            for (double y = 0; y <= pHeight; y += 0.125)
            {
                LineType lineInch = AddLine("lineInch8Y" + n, pReportItems, -0.0125, y, 0.025, 0);
                lineInch.Style.BorderColor.Default.Color = vRulerColor;
                n++;
            }
        }

        public static void AddFields(FieldsType pFields, string[] pFieldNames)
        {
            foreach (string pName in pFieldNames)
            {
                FieldType vField = new FieldType(pName);
                vField.DataField = vField.Name;
                pFields.Add(vField);
            }
        }

        public static void AddParameters(ReportParametersType pParams, string[] pParameterNames)
        {
            foreach (string pName in pParameterNames)
            {
                ReportParameterType param = new ReportParameterType(pName);
                param.DataType = DataTypeEnum.String;
                param.Nullable = true;
                param.AllowBlank = true;
                param.Prompt = param.Name;
                pParams.Add(param);
            }
        }

        public static void AddCompanyParameters(ReportParametersType pParams)
        {
            AddParameters(pParams, new string[] { 
                                                "COMPANY_NAME"
                                                , "COMP_ADDRESS_1"
                                                , "COMP_ADDRESS_2"
                                                , "COMP_ADDRESS_3"
                                                , "COMP_CITY"
                                                , "COMP_STATE"
                                                , "COMP_PIN"
                                                , "COMP_PHONE"
                                                , "COMP_CELL"
                                                , "COMP_FAX"
                                                , "COMP_EMAIL"
                                                , "COMP_TIN_NO"
                                                , "COMP_CST_NO"
                                                , "COPY" 
                                                }
                        );
        }

        ////public static void SetCompanyParameterValues(LocalReport pLocalReport)
        ////{
        ////    Global.FetchCurrentCompany();
        ////    ///
        ////    ReportParameter[] rparams = new ReportParameter[] {
        ////        new ReportParameter("COMPANY_NAME", Global.COMPANY_NAME),
        ////        new ReportParameter("COMP_ADDRESS_1", Global.COMP_ADDRESS_1),
        ////        new ReportParameter("COMP_ADDRESS_2", Global.COMP_ADDRESS_2),
        ////        new ReportParameter("COMP_ADDRESS_3", Global.COMP_ADDRESS_3),
        ////        new ReportParameter("COMP_CITY", Global.COMP_CITY),
        ////        new ReportParameter("COMP_STATE", Global.COMP_STATE),
        ////        new ReportParameter("COMP_PIN", Global.COMP_PIN),
        ////        new ReportParameter("COMP_PHONE", Global.COMP_PHONE),
        ////        new ReportParameter("COMP_CELL", Global.COMP_CELL),
        ////        new ReportParameter("COMP_FAX", Global.COMP_FAX),
        ////        new ReportParameter("COMP_EMAIL", Global.COMP_EMAIL),
        ////        new ReportParameter("COMP_TIN_NO", Global.COMP_TIN_NO),
        ////        new ReportParameter("COMP_CST_NO", Global.COMP_CST_NO)
        ////        };
        ////    pLocalReport.SetParameters(rparams);
        ////}


        public static void SetBounds(ReportItemType pControl, double pLeft, double pTop, double pWidth, double pHeight)
        {
            SetLocation(pControl, pLeft, pTop);
            SetSize(pControl, pWidth, pHeight);
        }

        public static void SetLocation(ReportItemType pControl, double pLeft, double pTop)
        {
            if (pControl is LineType)
            {
                LineType vLine = pControl as LineType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is RectangleType)
            {
                RectangleType vLine = pControl as RectangleType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is TextboxType)
            {
                TextboxType vLine = pControl as TextboxType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is ImageType)
            {
                ImageType vLine = pControl as ImageType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is SubreportType)
            {
                SubreportType vLine = pControl as SubreportType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is ListType)
            {
                ListType vLine = pControl as ListType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is MatrixType)
            {
                MatrixType vLine = pControl as MatrixType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is TableType)
            {
                TableType vLine = pControl as TableType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is ChartType)
            {
                ChartType vLine = pControl as ChartType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
            else if (pControl is CustomReportItemType)
            {
                CustomReportItemType vLine = pControl as CustomReportItemType;
                vLine.Left.Value = pLeft;
                vLine.Top.Value = pTop;
            }
        }

        public static void SetSize(ReportItemType pControl, double pWidth, double pHeight)
        {
            if (pControl is LineType)
            {
                LineType vLine = pControl as LineType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is RectangleType)
            {
                RectangleType vLine = pControl as RectangleType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is TextboxType)
            {
                TextboxType vLine = pControl as TextboxType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is ImageType)
            {
                ImageType vLine = pControl as ImageType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is SubreportType)
            {
                SubreportType vLine = pControl as SubreportType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is ListType)
            {
                ListType vLine = pControl as ListType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is MatrixType)
            {
                MatrixType vLine = pControl as MatrixType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is TableType)
            {
                TableType vLine = pControl as TableType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is ChartType)
            {
                ChartType vLine = pControl as ChartType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
            else if (pControl is CustomReportItemType)
            {
                CustomReportItemType vLine = pControl as CustomReportItemType;
                vLine.Width.Value = pWidth;
                vLine.Height.Value = pHeight;
            }
        }


        public static ListType AddList(string pName, ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight)
        {
            ListType vList = new ListType(pName);
            vList.DataSetName = "MyDataSource";
            vList.Left.Value = pLeft;
            vList.Top.Value = pTop;
            vList.Width.Value = pWidth;
            vList.Height.Value = pHeight;
            ///
            pReportItems.Add(vList);
            return vList;
        }

        public static RectangleType AddRectangle(string pName, ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight)
        {
            RectangleType vRect = new RectangleType(pName);
            vRect.Left.Value = pLeft;
            vRect.Top.Value = pTop;
            vRect.Width.Value = pWidth;
            vRect.Height.Value = pHeight;
            ///
            vRect.Style.BorderStyle = new BorderStyleType();
            vRect.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            vRect.Style.BorderWidth = new BorderWidthType();
            vRect.Style.BorderWidth.Default.Value = 1.00;
            ///
            pReportItems.Add(vRect);
            return vRect;
        }

        public static TextboxType AddTextbox(string pName, ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight)
        {
            TextboxType vTextbox = new TextboxType(pName);
            vTextbox.Left.Value = pLeft;
            vTextbox.Top.Value = pTop;
            vTextbox.Width.Value = pWidth;
            vTextbox.Height.Value = pHeight;
            ///
            //== vTextbox.CanGrow = true;
            ///
            pReportItems.Add(vTextbox);
            return vTextbox;
        }

        public static LineType AddLine(string pName, ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight)
        {
            LineType vLine = new LineType(pName);
            vLine.Left.Value = pLeft;
            vLine.Top.Value = pTop;
            vLine.Width.Value = pWidth;
            vLine.Height.Value = pHeight;
            ///
            vLine.Style.BorderStyle = new BorderStyleType();
            vLine.Style.BorderStyle.Default = BorderStyleEnum.Solid;
            vLine.Style.BorderWidth = new BorderWidthType();
            vLine.Style.BorderWidth.Default.Value = 1;
            ///
            pReportItems.Add(vLine);
            return vLine;
        }


        public static SubreportType AddSubreport(string pName, string vReportName_WithoutFileExtn, ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight)
        {
            SubreportType vSubreport = new SubreportType(pName);
            vSubreport.ReportName = vReportName_WithoutFileExtn; // The sub-report must exist in the same folder, having file name = <ReportName>+".rdlc"
            vSubreport.Left.Value = pLeft;
            vSubreport.Top.Value = pTop;
            vSubreport.Width.Value = pWidth;
            vSubreport.Height.Value = pHeight;
            //
            pReportItems.Add(vSubreport);
            return vSubreport;
        }


        public static EmbeddedImageType EmbedImage(string pName, string pImagePath, ReportType pReport)
        {
            Image vImage = Image.FromFile(pImagePath);
            string vMIMEType = Base64Util.GetMIMEType(pImagePath);
            return EmbedImage(pName, vImage, vMIMEType, pReport);
        }

        public static EmbeddedImageType EmbedImage(string pName, Image pImage, string pMIMEType, ReportType pReport)
        {
            EmbeddedImageType embededImage = new EmbeddedImageType(pName);
            embededImage.MIMEType = pMIMEType;
            embededImage.ImageData = Base64Util.ImageToBase64String(pImage); ;
            pReport.EmbeddedImages.Add(embededImage);
            return embededImage;
        }

        public static ImageType AddImage
            (
            string pName, EmbeddedImageType pEmbededImage, 
            ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight
            )
        {
            ImageType vImage = new ImageType(pName);
            vImage.Left.Value = pLeft;
            vImage.Top.Value = pTop;
            vImage.Width.Value = pWidth;
            vImage.Height.Value = pHeight;
            ///
            vImage.Source = SourceEnum.Embedded;
            vImage.Sizing = SizingEnum.FitProportional;
            vImage.Value = pEmbededImage.Name;
            vImage.MIMEType = pEmbededImage.MIMEType;
            ///
            pReportItems.Add(vImage);
            return vImage;
        }

        /* To add image from database stored in a field */
        public static ImageType AddImage
            (
            string pName, string pFieldName, string pMIMEType, 
            ReportItemsType pReportItems, double pLeft, double pTop, double pWidth, double pHeight)
        {
            ImageType vImage = new ImageType(pName);
            vImage.Left.Value = pLeft;
            vImage.Top.Value = pTop;
            vImage.Width.Value = pWidth;
            vImage.Height.Value = pHeight;
            ///
            vImage.Source = SourceEnum.Database;
            vImage.Sizing = SizingEnum.FitProportional;
            vImage.Value = "=Fields!" + pFieldName + ".Value";
            vImage.MIMEType = pMIMEType;
            ///
            pReportItems.Add(vImage);
            return vImage;
        }




        //public static void ApplyPrinterProfiler(ReportViewer pReportViewer, string pProfileName)
        //{
        //    PrintSetupData fPrintSetupData = PrintSetupData.ReadFromFile();
        //    if (fPrintSetupData.Mappings.ContainsKey(PrintSetupData.PRINT_RECEIPT))
        //    {
        //        string vProfileName = fPrintSetupData.Mappings[PrintSetupData.PRINT_RECEIPT].ProfileName;
        //        if (fPrintSetupData.Profiles.ContainsKey(vProfileName))
        //        {
        //            PrintSetupProfile vProfile = fPrintSetupData.Profiles[vProfileName];
        //            PrinterSettings vPrinterSettings = vProfile.GetPrinterSettings();
        //            pReportViewer.PrinterSettings = vPrinterSettings; //(3)//
        //            pReportViewer.SetPageSettings(vPrinterSettings.DefaultPageSettings); //(4)//
        //        }
        //    }
        //}


    }//cls//
}//ns//
