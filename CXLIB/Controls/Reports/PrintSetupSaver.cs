using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Xml;

namespace CXLIB
{
    public class PrintSetupData
    {
        private static List<string> _PrintModules = new List<string>();
        public static List<string> PrintModules /*It is a registry of Print Modules' names */
        {
            get { return _PrintModules; }
        }

        public SortedList<string, PrintSetupProfile> Profiles = new SortedList<string, PrintSetupProfile>();
        public SortedList<string, PrintSetupMap> Mappings = new SortedList<string, PrintSetupMap>();

        private const string FileName = "PrinterSettings.config";

        public string GetProfileNameForModule(string pPrintModuleName)
        {
            return Mappings[pPrintModuleName].ProfileName;
        }

        public PrintSetupProfile GetProfile(string pProfileName)
        {
            return Profiles[pProfileName];
        }

        //public DataTable GetProfileList()
        //{
        //    DataTable xelist = new DataTable("ProfileName");
        //    foreach(KeyValuePair<string, PrintSetupProfile> kvp in Profiles)
        //    {
        //        XEntity xe = new XEntity("ProfileName");
        //        xe.Add("ProfileName", kvp.Value.ProfileName);
        //        xelist.Add(xe);
        //    }
        //    return xelist;
        //}

        private string Validate(string pProfileName, PrinterSettings pPrinterSettings, string pOriginalProfileName)
        {
            pProfileName = pProfileName.Trim();
            if (pProfileName == "")
            {
                return "Profile Name must not be left blank";
            }

            foreach (KeyValuePair<string, PrintSetupProfile> vProfile in Profiles)
            {
                if (vProfile.Value.ProfileName != pOriginalProfileName) //--exclude
                {
                    if (vProfile.Value.ProfileName == pProfileName)
                    {
                        return "Profile '" + pProfileName + "' Already Exists";
                    }
                }
            }

            return "";
        }

        /*-STATIC-*/
        public static string NewProfile(string pProfileName, PrinterSettings pPrinterSettings)
        {
            PrintSetupData vPrintSetupData = ReadFromFile();

            string vErr = vPrintSetupData.Validate(pProfileName, pPrinterSettings, "");
            if (vErr != "")
            {
                return vErr;
            }

            PrintSetupProfile vProfile = PrintSetupProfile.ToProfile(pProfileName, pPrinterSettings);
            vPrintSetupData.Profiles.Add(pProfileName, vProfile);

            WriteToFile(vPrintSetupData);

            return "";
        }

        /*-STATIC-*/
        public static string EditProfile(string pProfileName_Original, string pProfileName, PrinterSettings pPrinterSettings)
        {
            PrintSetupData vPrintSetupData = ReadFromFile();

            string vErr = vPrintSetupData.Validate(pProfileName, pPrinterSettings, pProfileName_Original);
            if (vErr != "")
            {
                return vErr;
            }

            vPrintSetupData.Profiles.Remove(pProfileName_Original);
            PrintSetupProfile vProfile = PrintSetupProfile.ToProfile(pProfileName, pPrinterSettings);
            vPrintSetupData.Profiles.Add(pProfileName, vProfile);

            WriteToFile(vPrintSetupData);

            return "";
        }

        /*-STATIC-*/
        public static string DeleteProfile(string pProfileName)
        {
            PrintSetupData vPrintSetupData = ReadFromFile();

            //string vErr = vPrintSetupData.Validate(pProfileName, pPrinterSettings);
            //if (vErr != "")
            //{
            //    return vErr;
            //}

            vPrintSetupData.Profiles.Remove(pProfileName);

            WriteToFile(vPrintSetupData);

            return "";
        }

        /*-STATIC-*/
        public static void WriteToFile(PrintSetupData vPrintSetupData)
        {
            XmlWriterSettings xset = new XmlWriterSettings();
            xset.Indent = true;
            xset.IndentChars = "    ";
            XmlWriter wr = XmlWriter.Create(Global.GetAbsolutePath(FileName), xset);
            
            wr.WriteStartDocument();
            wr.WriteStartElement("PrinterSettings");

            
            wr.WriteStartElement("Profiles");
            foreach (KeyValuePair<string, PrintSetupProfile> kvp in vPrintSetupData.Profiles)
            {
                PrintSetupProfile vProfile = kvp.Value;
                wr.WriteStartElement("Profile");

                wr.WriteStartElement("ProfileName");
                wr.WriteValue(vProfile.ProfileName);
                wr.WriteEndElement();

                wr.WriteStartElement("PrinterName");
                wr.WriteValue(vProfile.PrinterName);
                wr.WriteEndElement();


                wr.WriteStartElement("PaperSizeName");
                wr.WriteValue(vProfile.PaperSizeName);
                wr.WriteEndElement();

                wr.WriteStartElement("PaperSizeKind");
                wr.WriteValue(vProfile.PaperSizeKind);
                wr.WriteEndElement();

                wr.WriteStartElement("PaperSizeRawKind");
                wr.WriteValue(vProfile.PaperSizeRawKind);
                wr.WriteEndElement();

                wr.WriteStartElement("PaperSizeUWidth");
                wr.WriteValue(vProfile.PaperSizeUWidth);
                wr.WriteEndElement();

                wr.WriteStartElement("PaperSizeUHeight");
                wr.WriteValue(vProfile.PaperSizeUHeight);
                wr.WriteEndElement();


                wr.WriteStartElement("PaperSourceName");
                wr.WriteValue(vProfile.PaperSourceName);
                wr.WriteEndElement();

                wr.WriteStartElement("PaperSourceKind");
                wr.WriteValue(vProfile.PaperSourceKind);
                wr.WriteEndElement();

                wr.WriteStartElement("PaperSourceRawKind");
                wr.WriteValue(vProfile.PaperSourceRawKind);
                wr.WriteEndElement();


                wr.WriteStartElement("PrinterResolutionKind");
                wr.WriteValue(vProfile.PrinterResolutionKind);
                wr.WriteEndElement();


                wr.WriteStartElement("PrinterResolutionX");
                wr.WriteValue(vProfile.PrinterResolutionX);
                wr.WriteEndElement();

                wr.WriteStartElement("PrinterResolutionY");
                wr.WriteValue(vProfile.PrinterResolutionY);
                wr.WriteEndElement();


                wr.WriteStartElement("Landscape");
                wr.WriteValue(vProfile.Landscape);
                wr.WriteEndElement();

                wr.WriteStartElement("Color");
                wr.WriteValue(vProfile.Color);
                wr.WriteEndElement();


                wr.WriteStartElement("MarginLeft");
                wr.WriteValue(vProfile.MarginLeft);
                wr.WriteEndElement();

                wr.WriteStartElement("MarginRight");
                wr.WriteValue(vProfile.MarginRight);
                wr.WriteEndElement();

                wr.WriteStartElement("MarginTop");
                wr.WriteValue(vProfile.MarginTop);
                wr.WriteEndElement();

                wr.WriteStartElement("MarginBottom");
                wr.WriteValue(vProfile.MarginBottom);
                wr.WriteEndElement();

                wr.WriteEndElement(); //Profile
            }
            wr.WriteEndElement(); //Profiles


            wr.WriteStartElement("Mappings");
            foreach (KeyValuePair<string, PrintSetupMap> kvp in vPrintSetupData.Mappings)
            {
                PrintSetupMap vMap = kvp.Value;
                wr.WriteStartElement("Mapping");

                wr.WriteStartElement("PrintModuleName");
                wr.WriteValue(vMap.PrintModuleName);
                wr.WriteEndElement();

                wr.WriteStartElement("ProfileName");
                wr.WriteValue(vMap.ProfileName);
                wr.WriteEndElement();

                wr.WriteEndElement(); //Mapping
            }
            wr.WriteEndElement(); //Mappings

            
            wr.WriteEndElement(); //Root
            wr.WriteEndDocument();
            wr.Flush();
            wr.Close();
        }

        /*-STATIC-*/
        public static PrintSetupData ReadFromFile()
        {
            PrintSetupData vPrintSetup = new PrintSetupData();
            XmlDocument doc = new XmlDocument();
            doc.Load(Global.GetAbsolutePath(FileName));

            XmlNodeList vProfileNodeList = doc.DocumentElement.GetElementsByTagName("Profiles");
            foreach (XmlNode vProfileNode in vProfileNodeList[0].ChildNodes)
            {
                PrintSetupProfile vProfile = new PrintSetupProfile();
                ///
                foreach (XmlNode vNode in vProfileNode.ChildNodes)
                {
                    switch (vNode.Name)
                    {
                        case "ProfileName":
                            vProfile.ProfileName = vNode.InnerText;
                            break;
                        case "PrinterName":
                            vProfile.PrinterName = vNode.InnerText;
                            break;

                        case "PaperSizeName":
                            vProfile.PaperSizeName = vNode.InnerText;
                            break;
                        case "PaperSizeKind":
                            vProfile.PaperSizeKind = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "PaperSizeRawKind":
                            vProfile.PaperSizeRawKind = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "PaperSizeUWidth":
                            vProfile.PaperSizeUWidth = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "PaperSizeUHeight":
                            vProfile.PaperSizeUHeight = Convert.ToInt32(vNode.InnerText);
                            break;

                        case "PaperSourceName":
                            vProfile.PaperSourceName = vNode.InnerText;
                            break;
                        case "PaperSourceKind":
                            vProfile.PaperSourceKind = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "PaperSourceRawKind":
                            vProfile.PaperSourceRawKind = Convert.ToInt32(vNode.InnerText);
                            break;

                        case "PrinterResolutionKind":
                            vProfile.PrinterResolutionKind = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "PrinterResolutionX":
                            vProfile.PrinterResolutionX = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "PrinterResolutionY":
                            vProfile.PrinterResolutionY = Convert.ToInt32(vNode.InnerText);
                            break;

                        case "Landscape":
                            vProfile.Landscape = Convert.ToBoolean(vNode.InnerText);
                            break;
                        case "Color":
                            vProfile.Color = Convert.ToBoolean(vNode.InnerText);
                            break;

                        case "MarginLeft":
                            vProfile.MarginLeft = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "MarginRight":
                            vProfile.MarginRight = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "MarginTop":
                            vProfile.MarginTop = Convert.ToInt32(vNode.InnerText);
                            break;
                        case "MarginBottom":
                            vProfile.MarginBottom = Convert.ToInt32(vNode.InnerText);
                            break;
                    }
                }
                ///
                vPrintSetup.Profiles.Add(vProfile.ProfileName, vProfile);
            }


            XmlNodeList vMappingNodeList = doc.DocumentElement.GetElementsByTagName("Mappings");
            foreach (XmlNode vMappingNode in vMappingNodeList[0].ChildNodes)
            {
                PrintSetupMap vMap = new PrintSetupMap();
                ///
                foreach (XmlNode vNode in vMappingNode.ChildNodes)
                {
                    switch (vNode.Name)
                    {
                        case "PrintModuleName":
                            vMap.PrintModuleName = vNode.InnerText;
                            break;
                        case "ProfileName":
                            vMap.ProfileName = vNode.InnerText;
                            break;

                    }
                }
                ///
                vPrintSetup.Mappings.Add(vMap.PrintModuleName, vMap);
            }


            return vPrintSetup;
        }

    }


    public class PrintSetupProfile
    {
        public string ProfileName;
        public string PrinterName;

        public string PaperSizeName;
        public int PaperSizeKind;
        public int PaperSizeRawKind;
        public int PaperSizeUWidth;
        public int PaperSizeUHeight;

        public string PaperSourceName;
        public int PaperSourceKind;
        public int PaperSourceRawKind;

        public int PrinterResolutionKind;
        public int PrinterResolutionX;
        public int PrinterResolutionY;

        public bool Landscape;
        public bool Color;

        public int MarginLeft;
        public int MarginRight;
        public int MarginTop;
        public int MarginBottom;

        private void SetPaperSize(PrinterSettings pPrinterSettings, string pPaperName, PaperKind pKind, int pRawKind, int pUWidth, int pUHeight)
        {
            bool vPaperSizeFound = false;
            if (pKind == PaperKind.Custom && pRawKind == 0)
            {
                //do-nothing here; User Defined Size is added after this if-else block.
            }
            else
            {
                /* First match for exact paper size name*/
                foreach (PaperSize vStockPaperSize in pPrinterSettings.PaperSizes)
                {
                    if (vStockPaperSize.PaperName==pPaperName) 
                    {
                        vPaperSizeFound = true;
                        pPrinterSettings.DefaultPageSettings.PaperSize = vStockPaperSize;
                        break;
                    }
                }
                /*Second match for Kind and RawKind*/
                if (vPaperSizeFound == false)
                {
                    foreach (PaperSize vStockPaperSize in pPrinterSettings.PaperSizes)
                    {
                        if (vStockPaperSize.Kind == pKind && vStockPaperSize.RawKind == pRawKind)
                        {
                            vPaperSizeFound = true;
                            pPrinterSettings.DefaultPageSettings.PaperSize = vStockPaperSize;
                            break;
                        }
                    }
                }
                /*Thid, match for Paper Width and Height*/
                if (vPaperSizeFound == false)
                {
                    foreach (PaperSize vStockPaperSize in pPrinterSettings.PaperSizes)
                    {
                        if (vStockPaperSize.Width == pUWidth && vStockPaperSize.Height == pUHeight)
                        {
                            vPaperSizeFound = true;
                            pPrinterSettings.DefaultPageSettings.PaperSize = vStockPaperSize;
                            break;
                        }
                    }
                }
            }
            ///
            if (vPaperSizeFound == false)
            {
                PaperSize vUPaperSize = new PaperSize("User Defined Paper Size", pUWidth, pUHeight);
                pPrinterSettings.DefaultPageSettings.PaperSize = vUPaperSize;
            }
        }

        private bool SetPaperSource(PrinterSettings pPrinterSettings, string pPaperSourceName, PaperSourceKind pKind, int pRawKind)
        {
            bool vPaperSourceFound = false;
            foreach (PaperSource vStockPaperSource in pPrinterSettings.PaperSources)
            {
                if ((vStockPaperSource.SourceName == pPaperSourceName)
                    || (vStockPaperSource.Kind == pKind && vStockPaperSource.RawKind == pRawKind))
                {
                    vPaperSourceFound = true;
                    pPrinterSettings.DefaultPageSettings.PaperSource = vStockPaperSource;
                    break;
                }
            }
            return vPaperSourceFound;
        }

        private bool SetPrinterResolution(PrinterSettings pPrinterSettings, PrinterResolutionKind pKind, int pResolutionX, int pResolutionY)
        {
            bool vResolutionFound = false;
            foreach (PrinterResolution vStockResolution in pPrinterSettings.PrinterResolutions)
            {
                if (pKind < 0)
                {
                    if (vStockResolution.Kind == pKind)
                    {
                        vResolutionFound = true;
                        pPrinterSettings.DefaultPageSettings.PrinterResolution = vStockResolution;
                        break;
                    }
                }
                else
                {
                    if (vStockResolution.X == pResolutionX && vStockResolution.Y == pResolutionY)
                    {
                        vResolutionFound = true;
                        pPrinterSettings.DefaultPageSettings.PrinterResolution = vStockResolution;
                        break;
                    }
                }
            }
            return vResolutionFound;
        }

        public PrinterSettings GetPrinterSettings()
        {
            PrinterSettings vPrnSet = new PrinterSettings();

            vPrnSet.PrinterName = this.PrinterName;
            this.SetPaperSize(vPrnSet, this.PaperSizeName, (PaperKind)this.PaperSizeKind, this.PaperSizeRawKind, this.PaperSizeUWidth, this.PaperSizeUHeight);
            this.SetPaperSource(vPrnSet, this.PaperSourceName, (PaperSourceKind)this.PaperSourceKind, this.PaperSourceRawKind);
            this.SetPrinterResolution(vPrnSet, (PrinterResolutionKind)this.PrinterResolutionKind, this.PrinterResolutionX, this.PrinterResolutionY);
            vPrnSet.DefaultPageSettings.Landscape = this.Landscape;
            //--TO BE IMPL.-- vPrnSet.DefaultPageSettings.Color = this.Color;
            vPrnSet.DefaultPageSettings.Margins.Left = this.MarginLeft;
            vPrnSet.DefaultPageSettings.Margins.Right = this.MarginRight;
            vPrnSet.DefaultPageSettings.Margins.Top = this.MarginTop;
            vPrnSet.DefaultPageSettings.Margins.Bottom = this.MarginBottom;

            return vPrnSet;
        }

        public static PrintSetupProfile ToProfile(string pProfileName, PrinterSettings pPrinterSettings)
        {
            PrintSetupProfile vProfile = new PrintSetupProfile();
            vProfile.ProfileName = pProfileName;
            vProfile.PrinterName = pPrinterSettings.PrinterName;

            vProfile.PaperSizeName = pPrinterSettings.DefaultPageSettings.PaperSize.PaperName;
            vProfile.PaperSizeKind = (int)pPrinterSettings.DefaultPageSettings.PaperSize.Kind;
            vProfile.PaperSizeRawKind = pPrinterSettings.DefaultPageSettings.PaperSize.RawKind;
            vProfile.PaperSizeUWidth = pPrinterSettings.DefaultPageSettings.PaperSize.Width;
            vProfile.PaperSizeUHeight = pPrinterSettings.DefaultPageSettings.PaperSize.Height;

            vProfile.PaperSourceName = pPrinterSettings.DefaultPageSettings.PaperSource.SourceName;
            vProfile.PaperSourceKind = (int)pPrinterSettings.DefaultPageSettings.PaperSource.Kind;
            vProfile.PaperSourceRawKind = pPrinterSettings.DefaultPageSettings.PaperSource.RawKind;

            vProfile.PrinterResolutionKind = (int)pPrinterSettings.DefaultPageSettings.PrinterResolution.Kind;
            vProfile.PrinterResolutionX = pPrinterSettings.DefaultPageSettings.PrinterResolution.X;
            vProfile.PrinterResolutionY = pPrinterSettings.DefaultPageSettings.PrinterResolution.Y;

            vProfile.Landscape = pPrinterSettings.DefaultPageSettings.Landscape;
            vProfile.Color = pPrinterSettings.DefaultPageSettings.Color;

            vProfile.MarginLeft = pPrinterSettings.DefaultPageSettings.Margins.Left;
            vProfile.MarginRight = pPrinterSettings.DefaultPageSettings.Margins.Right;
            vProfile.MarginTop = pPrinterSettings.DefaultPageSettings.Margins.Top;
            vProfile.MarginBottom = pPrinterSettings.DefaultPageSettings.Margins.Bottom;

            return vProfile;
        }

    }


    public class PrintSetupMap
    {
        public string PrintModuleName;
        public string ProfileName;
    }
}
