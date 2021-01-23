using System.Collections.Generic;
using System.IO; //MemoryStream, FileStream
using System.Text; //Encoding class
using System.Drawing.Printing; //PrintDocument class
using System.Drawing.Imaging; //MetaFile class
using Microsoft.Reporting.WinForms;

namespace CXLIB
{
    /*** (1)DIRECT PRINTING (2)PDF ***/
    public static class MSRptViewerUtil
    {

        #region [ PDF -Export the given report as a PDF file ]

        public static void ExportAsPDF(LocalReport pLocalReport, PrinterSettings pPrinterSettings, string pFileName)
        {
            const string EXPORT_FORMAT_PDF = "PDF";
            f_PrinterSettings = pPrinterSettings;
            //string deviceInfo = "<DeviceInfo/>";
            string deviceInfo =
                            "<DeviceInfo> \r\n"
                            + "  <OutputFormat>PDF</OutputFormat> \r\n"
                            + (f_PrinterSettings.DefaultPageSettings.Landscape == false
                                ?
                                "  <PageWidth>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Width / 100M) + "in</PageWidth> \r\n"
                                + "  <PageHeight>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Height / 100M) + "in</PageHeight> \r\n"
                                :
                                "  <PageWidth>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Height / 100M) + "in</PageWidth> \r\n"
                                + "  <PageHeight>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Width / 100M) + "in</PageHeight> \r\n"
                                )
                            + "  <MarginTop>" + (f_PrinterSettings.DefaultPageSettings.Margins.Top / 100M) + "in</MarginTop> \r\n"
                            + "  <MarginLeft>" + (f_PrinterSettings.DefaultPageSettings.Margins.Left / 100M) + "in</MarginLeft> \r\n"
                            + "  <MarginRight>" + (f_PrinterSettings.DefaultPageSettings.Margins.Right / 100M) + "in</MarginRight> \r\n"
                            + "  <MarginBottom>" + (f_PrinterSettings.DefaultPageSettings.Margins.Bottom / 100M) + "in</MarginBottom> \r\n"
                            + "</DeviceInfo> \r\n";
            string mimeType, encoding, fileNameExtension;
            string[] streams;
            Warning[] warnings;
            ///
            byte[] pdfBytes = pLocalReport.Render(EXPORT_FORMAT_PDF, deviceInfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            ///
            using (var f = new FileStream(pFileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                f.Write(pdfBytes, 0, pdfBytes.Length);
            }
        }

        #endregion

        #region [ EMF (1)Vars & Init]

        private static int f_currentPage;
        private static int f_totalPages;
        private static IList<Stream> f_streams; /*keeps one stream per page*/
        private static PrinterSettings f_PrinterSettings;

        public static void SendToPrinter(LocalReport pLocalReport, PrinterSettings pPrinterSettings)
        {
            Cleanup();
            f_PrinterSettings = pPrinterSettings;
            ExportAsEMFImge(pLocalReport);
            PrintDoc();
            Cleanup();
        }

        private static void Cleanup()
        {
            f_currentPage = 0;
            f_totalPages = 0;
            f_streams = null;
            f_PrinterSettings = null;
        }

        #endregion

        #region [ EMF (2)Export the given report as an EMF stream ]

        private static void ExportAsEMFImge(LocalReport pLocalReport)
        {
            const string EXPORT_FORMAT_IMAGE = "Image";
            ///
            string deviceInfo =
                            "<DeviceInfo> \r\n"
                            + "  <OutputFormat>EMF</OutputFormat> \r\n"
                            + (f_PrinterSettings.DefaultPageSettings.Landscape == false
                                ?
                                "  <PageWidth>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Width / 100M) + "in</PageWidth> \r\n"
                                + "  <PageHeight>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Height / 100M) + "in</PageHeight> \r\n"
                                :
                                "  <PageWidth>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Height / 100M) + "in</PageWidth> \r\n"
                                + "  <PageHeight>" + (f_PrinterSettings.DefaultPageSettings.PaperSize.Width / 100M) + "in</PageHeight> \r\n"
                                )
                            + "  <MarginTop>" + (f_PrinterSettings.DefaultPageSettings.Margins.Top / 100M) + "in</MarginTop> \r\n"
                            + "  <MarginLeft>" + (f_PrinterSettings.DefaultPageSettings.Margins.Left / 100M) + "in</MarginLeft> \r\n"
                            + "  <MarginRight>" + (f_PrinterSettings.DefaultPageSettings.Margins.Right / 100M) + "in</MarginRight> \r\n"
                            + "  <MarginBottom>" + (f_PrinterSettings.DefaultPageSettings.Margins.Bottom / 100M) + "in</MarginBottom> \r\n"
                            + "</DeviceInfo> \r\n";
            ///
            Warning[] warnings;
            ///
            f_streams = new List<Stream>();
            ///
            pLocalReport.Render(EXPORT_FORMAT_IMAGE, deviceInfo, CreateStream_Callback, out warnings);
            //==Render() will invoke CreateStream_Callback several times, before returning.
            ///
            foreach (Stream stream in f_streams)
            {
                stream.Position = 0; /*reset all stream's position*/
            }
        }

        /*== Callback to provide to the report renderer, in order to save an image for "each page" of the report. ====*/
        private static Stream CreateStream_Callback(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            f_totalPages++;
            ///
            Stream stream = new MemoryStream(1024); //--Stream stream = new FileStream(@"..\..\" + name + "." + fileNameExtension, FileMode.Create);
            f_streams.Add(stream);
            return stream;
        }
        
        #endregion

        #region [ EMF (3)Print EMF stream data using PrintDocument ]

        private static void PrintDoc()
        {
            if (f_totalPages == 0)
                return;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings = f_PrinterSettings;
            printDoc.DefaultPageSettings = f_PrinterSettings.DefaultPageSettings; /* we can override DefaultPageSettings per page in _PrintPage event */
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            f_currentPage = 1;

            //int nCopies = 1;/* for non-collate mode, invoke PrtDoc.Print() only once. bcoz multi-copies is performed at PrtDoc_PrintPage event level for each page.*/
            //if (f_PrinterSettings.Collate == true)
            //{
            //    nCopies = f_PrinterSettings.Copies;
            //}
            //for (int copy = 1; copy <= nCopies; copy++)
            //{
            printDoc.Print();
        }

        /*== Handler for PrintPageEvents ============================================*/
        private static void printDoc_PrintPage(object sender, PrintPageEventArgs ev)
        {
            /*** Pre-print actions ***/
            if (f_PrinterSettings.PrintRange == PrintRange.SomePages)
            {
                if (f_currentPage < f_PrinterSettings.FromPage)
                {
                    f_currentPage = f_PrinterSettings.FromPage; /*to start from this page*/
                }
            }

            /*** (1)Extract from stream (2) Print ****/
            Metafile pageImage;
            using (Stream emfStream = f_streams[f_currentPage - 1])
            {
                pageImage = new Metafile(emfStream);
                emfStream.Close();
            }
            ev.Graphics.DrawImage(pageImage, ev.PageBounds);
            //int nCopies = 1;/* for collate mode, always print single copy only. bcoz multi-copies is performed at outer level as a whole set.*/
            //if (f_PrinterSettings.Collate == false)
            //{
            //    nCopies = f_PrinterSettings.Copies;
            //}
            //for (int copy = 1; copy <= nCopies; copy++)
            //{

            /*** Post-print actions**/
            if (f_PrinterSettings.PrintRange == PrintRange.SomePages)
            {
                if (f_currentPage < f_PrinterSettings.ToPage)
                {
                    ev.HasMorePages = true;
                }
            }
            else
            {
                ev.HasMorePages = (f_currentPage < f_totalPages);
            }
            ///
            f_currentPage++;
        }
        
        #endregion

    }//cls//

}//ns//

/* EMF (Enhanced MetaFile)
   =======================
"EMF" (Enhanced MetaFile) and "RAW" are terms for spool file formats used in printing 
by the Windows operating system . When a print job is sent to the printer , 
if it is already printing another file, the computer reads the new file and stores it, 
usually on the hard disk or in memory , for printing at a later time. 
Spooling allows multiple print jobs to be given to the printer at one time.

The EMF format is the 32- bit version of the original Windows metafile (WMF) format. 
The EMF format was created to solve the deficiencies of the WMF format in printing graphics 
from sophisticated graphics programs. The EMF format is device-independent. 
This means that the dimensions of a graphic are maintained on the printed copy 
regardless of the resolution in dots per inch of the printer. 
In a network, the smaller file size of the EMF format reduces network traffic. 
EMF is the spool file used by the Windows operating system.

A raw spool file is a one that is sent to the Windows spooler unprocessed 
(which is why it's called "raw"). 
The raw file is used to send Postscript commands to a Postscript printer. 
The Postscript commands are understood by the printer, 
but are just plain data to the Windows spooler. The raw format is device-dependent and slower. 
If printing problems occur while using the EMF format, 
they can sometimes be fixed by simply changing the format to "raw" in the printer Properties.
*/

/* Image Rendering Device Info Settings(As XML)
   =============================================
Setting         Value
============    ===================================================================================
OutputFormat 	One of the Graphics Device Interface (GDI) supported 
                output formats: BMP, EMF, GIF, JPEG, PNG, or TIFF.

PageHeight 	    The page height, in inches, to set for the report. 
                You must include an integer or decimal value followed by "in" (for example, 11in). 
                This value overrides the report's original settings.

PageWidth 	    The page width, in inches, to set for the report. 
                You must include an integer or decimal value followed by "in" (for example, 8.5in). 
                This value overrides the report's original settings.

MarginBottom 	The bottom margin value, in inches, to set for the report. 
                You must include an integer or decimal value followed by "in" (for example, 1in). 
                This value overrides the report's original settings.

MarginLeft 	    The left margin value, in inches, to set for the report. 
                You must include an integer or decimal value followed by "in" (for example, 1in). 
                This value overrides the report's original settings.

MarginRight 	The right margin value, in inches, to set for the report. 
                You must include an integer or decimal value followed by "in" (for example, 1in). 
                This value overrides the report's original settings.

MarginTop 	    The top margin value, in inches, to set for the report. 
                You must include an integer or decimal value followed by "in" (for example, 1in). 
                This value overrides the report's original settings.

DpiX 	        The resolution of the output device in x-direction. The default value is 96.

DpiY 	        The resolution of the output device in y-direction. The default value is 96.

StartPage 	    The first page of the report to render. 
                A value of 0 indicates that all pages are rendered. The default value is 1.

EndPage 	    The last page of the report to render. The default value is the value for StartPage.

ColorDepth 	    The pixel depth of the color range supported by the image output. 
                Valid values are 1, 4, 8, 24, and 32. The default value is 24. 
                ColorDepth is only supported for TIFF rendering and is otherwise 
                ignored by the report server for other image output formats.
                [Note For this release of SQL Server, the value of this setting is ignored, and the TIFF image is always rendered as 24-bit.]

Columns 	    The number of columns to set for the report. 
                This value overrides the report's original settings.

ColumnSpacing 	The column spacing to set for the report. 
                This value overrides the report's original settings.

*/
