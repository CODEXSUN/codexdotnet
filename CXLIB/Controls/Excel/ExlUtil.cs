using System;
using System.Windows.Forms; //.Application
using System.Diagnostics; //.Process
using System.Runtime.InteropServices; //.Marshal
using System.Drawing; //.Color
using Excel = Microsoft.Office.Interop.Excel;

namespace CXLIB
{
    using System.Windows.Forms;

    public static class ExlUtil
    {
        public static void ExportGrid(DataGridView pGrid, string pFileNamePrefix)
        {
            object[] vHeader = new object[pGrid.ColumnCount];
            string[] vFormat = new string[pGrid.ColumnCount];
            ExlHAlign[] vHAlign = new ExlHAlign[pGrid.ColumnCount];
            object[,] vData = new object[pGrid.RowCount, pGrid.ColumnCount];
            int vColIndex = -1;
            ///
            for (int c = 0; c <= pGrid.ColumnCount - 1; c++)
            {
                if (pGrid.Columns[c].Visible == true && pGrid.Columns[c].Name != "FILLER")
                {
                    vColIndex++;
                    ///
                    vHeader[vColIndex] = pGrid.Columns[c].HeaderText;
                    ///
                    vFormat[vColIndex] = pGrid.Columns[c].DefaultCellStyle.Format;
                    ///
                    switch (pGrid.Columns[c].DefaultCellStyle.Alignment)
                    {
                        default:
                        case DataGridViewContentAlignment.TopLeft:
                        case DataGridViewContentAlignment.BottomLeft:
                        case DataGridViewContentAlignment.MiddleLeft:
                            vHAlign[vColIndex] = ExlHAlign.xlHAlignLeft;
                            break;
                        case DataGridViewContentAlignment.TopRight:
                        case DataGridViewContentAlignment.BottomRight:
                        case DataGridViewContentAlignment.MiddleRight:
                            vHAlign[vColIndex] = ExlHAlign.xlHAlignRight;
                            break;
                        case DataGridViewContentAlignment.TopCenter:
                        case DataGridViewContentAlignment.BottomCenter:
                        case DataGridViewContentAlignment.MiddleCenter:
                            vHAlign[vColIndex] = ExlHAlign.xlHAlignCenter;
                            break;
                    }
                    ///
                    for (int r = 0; r <= pGrid.RowCount - 1; r++)
                    {
                        vData[r, vColIndex] = pGrid[c, r].FormattedValue;
                    }
                }
            }
            ///
            Array.Resize<object>(ref vHeader, (vColIndex + 1));
            Array.Resize<string>(ref vFormat, (vColIndex + 1));
            Array.Resize<ExlHAlign>(ref vHAlign, (vColIndex + 1));
            ///
            ExlUtil.Export(vHeader, vFormat, vHAlign, vData, pFileNamePrefix);
        }

        public static void Export(object[] pHeader, string[] pFormat, ExlHAlign[] pHAlign, object[,] pData, string pFileNamePrefix)
        {
            const int RX_HEADER = 1;
            const string FMT_TEXT = "@";

            ExlBook xlBook = new ExlBook();
            xlBook.FileNamePrefix = (pFileNamePrefix != "" ? pFileNamePrefix : "Export");
            ExlSheet xlSheet = xlBook.Sheet(1);

            //== default formatting ======
            //xlSheet.CellsEntireSheetRange().NumberFormat = FMT_TEXT;
            xlSheet.CellsEntireSheetRange().IndentLevel = 1;
            //--xlSheet.Font(vExcel.GetRange_EntireSheet(), "Arial", 9);

            for (int c = 0; c <= pHeader.Length - 1; c++)
            {
                string vFormat = pFormat[c];
                if (vFormat == "") vFormat = FMT_TEXT;
                xlSheet.CellsColRange(c+1).NumberFormat = vFormat;
                ///
                xlSheet.CellsColRange(c+1).HorizontalAlignment = pHAlign[c];
            }

            //== headers formatting ====
            xlSheet.CellsRowRange(RX_HEADER).NumberFormat = FMT_TEXT;
            xlSheet.CellsRowRange(RX_HEADER).HorizontalAlignment = ExlHAlign.xlHAlignCenter;
            xlSheet.CellsRowRange(RX_HEADER).FontBold = true;
            xlSheet.CellsRowRange(RX_HEADER).BackColor = Color.WhiteSmoke;

            //== set data ====
            xlSheet.Cell(1, 1).SetValuesHoriz(pHeader);
            xlSheet.Cell(2, 1).SetValues(pData);

            xlSheet.CellsUsedRange().Border(ExlLineStyle.xlContinuous, ExlBorderWeight.xlHairline);
            xlSheet.CellsUsedRange().AutoFitColumns();
            xlSheet.CellsRowRange(RX_HEADER).AutoFilter();

            xlBook.Save();
            xlBook.Open();
        }
    }
}

namespace CXLIB
{
    /*
    TODO: Multi-sheet support
        ExlBook(rename of ExcelUtil) => ExlSheet => ExlRange, ..
    */
    public class ExlBook : IDisposable
    {
        public string FileNamePrefix = "Export"; /* Default. User can change. */

        //== Excel object variables are kept "public", so that user can intrude. ======
        public Excel.Application xlApp;
        public Excel.Workbooks xlBooks;
        public Excel.Workbook xlBook;
        public Excel.Sheets xlSheets;

        public object xlMissing = System.Reflection.Missing.Value; /* The optional argument for Excel calls. */

        private string f_FileName; /* Used by Open(). */

        public ExlBook()
        {
            this.Init("");
        }

        public ExlBook(string pFileName)
        {
            this.Init(pFileName);
        }

        private void Init(string pFileName)
        {
            f_FileName = pFileName;
            ///
            //== PREPARE EXCEL OBJECTS.
            xlApp = new Excel.Application();
            xlBooks = (Excel.Workbooks)xlApp.Workbooks;
            if (pFileName != "")
            {
                xlBooks.Open(
                    pFileName
                    , xlMissing, xlMissing, xlMissing, xlMissing, xlMissing, xlMissing
                    , xlMissing, xlMissing, xlMissing, xlMissing, xlMissing, xlMissing
                    , xlMissing, xlMissing
                    );
                xlBook = xlBooks.get_Item(1);
            }
            else
            {
                xlBook = (Excel.Workbook)(xlBooks.Add(xlMissing));
            }
            xlSheets = (Excel.Sheets)xlBook.Worksheets;
            ///--xlSheet = (Excel.Worksheet)(xlSheets.get_Item(1));
        }

        /*
        Ref: KB317109 - Office application does not quit after automation from Visual Studio .NET client
        ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/enu_kboffdev/offdev/317109.htm
        */
        private void ReleaseComObject(object obj)
        {
            if (obj == null) return;
            ///
            try
            {
                Marshal.ReleaseComObject(obj);
            }
            catch (Exception)
            {
                //-- ignore exceptions.
            }
            finally
            {
                obj = null; /// ??? but the object is passed by value. the actual param variable will hold the reference.
                GC.Collect(); 
            }
        }


        /* Cleanup() is autoly called at the end of Save(). */
        private void Cleanup()
        {
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    Excel.Worksheet vSheet = (Excel.Worksheet)xlSheets.get_Item(i);
                    this.ReleaseComObject(vSheet);
                }
            }
            catch { /*ignore ex*/ }
            this.ReleaseComObject(xlSheets);
            this.ReleaseComObject(xlBook);
            this.ReleaseComObject(xlBooks);
            this.ReleaseComObject(xlApp);
            ///
            xlApp = null;
            xlBooks = null;
            xlBook = null;
            xlSheets = null;
            ///
            GC.Collect();
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Cleanup();
        }

        #endregion

        /* This class' object is reusable, only when Reset() is called */
        ////public void Reset()
        ////{
        ////    this.Cleanup();
        ////    this.Init("");
        ////}


        /* Save into .XLSX or .XLS as available. */
        public void Save()
        {
            string xlFileName = "";
            int xlVersion = 12; /* O2003:v11, O2007:v12, O2010:v14 */
            string xlExtension = "xlsx";

            //== PREPARE FILE NAME. ==========
            if (f_FileName != "")
            {
                int idx = f_FileName.LastIndexOf('.');
                if (idx != -1)
                {
                    xlExtension = f_FileName.Substring(idx + 1);
                }
            }
            else
            {
                try
                {
                    xlVersion = Convert.ToInt32(xlApp.Version.Substring(0, 2));
                }
                catch
                {
                    /*Do-nothing*/
                }
                if (xlVersion <= 11)
                {
                    xlExtension = "xls";
                }
            }

            xlFileName =
                Application.StartupPath
                + "\\TEMP\\"
                + this.FileNamePrefix
                + "_"
                + DateTime.Now.ToString("ddMMMyy_hhmmsstt")
                + "."
                + xlExtension
                ;

            //== SAVE Workbook ==========
            xlBook.SaveAs(
                xlFileName
                , xlMissing, xlMissing, xlMissing, xlMissing,xlMissing
                , Excel.XlSaveAsAccessMode.xlNoChange
                , xlMissing, xlMissing, xlMissing, xlMissing, xlMissing
                );

            f_FileName = xlFileName;

            this.Close();
        }


        /* OPEN workbook file with shell. */
        public void Open()
        {
            Process vProcessRef = Process.Start(f_FileName);
            /// if (vProcessRef != null)
        }

        public void Close()
        {
            xlBook.Close(false, xlMissing, xlMissing);
            xlApp.Quit();

            //== cleanup Excel objects, and quit Excel. ========
            this.Cleanup();
        }

        public ExlSheet Sheet(int pSheetNum_OneBased)
        {
            Excel.Worksheet vSheet = (Excel.Worksheet)(xlSheets.get_Item(pSheetNum_OneBased));
            return new ExlSheet(vSheet);
        }
    }

    public class ExlSheet
    {
        public Excel.Worksheet xlSheet;

        public object xlMissing = System.Reflection.Missing.Value; /* The optional argument for Excel calls. */


        public ExlSheet(Excel.Worksheet pSheet)
        {
            xlSheet = pSheet;
        }

        
        /* Function to convert Row & Col number into a cell reference string  */
        /* (INPUT: R2,C4 --> OUTPUT cell ref: "D2"), (R2,C28->AB2), (R2,C55->BC2) */
        private string A1(int pRow, int pCol)
        {
            string vColName = "";
            int temp;
            ///
            while (pCol > 0)
            {
                temp = pCol % 26;
                pCol = pCol / 26;
                vColName = char.ToString((char)(temp + 64)) + vColName;
            }
            ///
            return vColName + pRow;
        }


        /* Range Ref: Single-Cell, Block-of-Cells, Entire-Row, Entire-Column, Entire sheet, Used-Range */
        public ExlRange Cell(int pRow, int pCol)
        {
            /* 
            string cref = A1(pRow, pCol);
            Excel.Range vXlRange = xlSheet.get_Range(cref, xlMissing);
            --OR--
            */
            Excel.Range vXlRange = (Excel.Range)xlSheet.Cells[pRow, pCol];
            return new ExlRange(vXlRange);
        }
        public ExlRange CellsRange(int pRow, int pCol, int pNumRows, int pNumCols)
        {
            string cref = A1(pRow, pCol);
            Excel.Range vXlRange = xlSheet.get_Range(cref, xlMissing).get_Resize(pNumRows, pNumCols);
            return new ExlRange(vXlRange);
        }
        public ExlRange CellsRowRange(int pRow)
        {
            string cref = A1(pRow, 1);
            Excel.Range vXlRange = xlSheet.get_Range(cref, xlMissing).EntireRow;
            return new ExlRange(vXlRange);
        }
        public ExlRange CellsRowRange(int pRow, int pNumRows)
        {
            string cref = A1(pRow, 1);
            Excel.Range vXlRange = xlSheet.get_Range(cref, xlMissing).get_Resize(pNumRows, 1).EntireRow;
            return new ExlRange(vXlRange);
        }
        public ExlRange CellsColRange(int pCol)
        {
            string cref = A1(1, pCol);
            Excel.Range vXlRange = xlSheet.get_Range(cref, xlMissing).EntireColumn;
            return new ExlRange(vXlRange);
        }
        public ExlRange CellsColRange(int pCol, int pNumCols)
        {
            string cref = A1(1, pCol);
            Excel.Range vXlRange = xlSheet.get_Range(cref, xlMissing).get_Resize(1, pNumCols).EntireColumn;
            return new ExlRange(vXlRange);
        }
        public ExlRange CellsEntireSheetRange()
        {
            return new ExlRange(xlSheet.Cells);
        }
        public ExlRange CellsUsedRange()
        {
            return new ExlRange(xlSheet.UsedRange);
        }


        public void PrintPreview()
        {
            xlSheet.PrintPreview(xlMissing);
        }

        public void PrintOut()
        {
            xlSheet.PrintOut(xlMissing, xlMissing, xlMissing, xlMissing, xlMissing, xlMissing, xlMissing, xlMissing);
        }

        ///////* Set a 2D array of values */
        //////public void SetValues(int pRow, int pCol, object[,] pValues)
        //////{
        //////    this.Cell(pRow, pCol).SetValues(pValues);
        //////}

        ///////* Set an array of values Horizantally. */
        //////public void SetValuesHoriz(int pRow, int pCol, object[] pValues)
        //////{
        //////    this.Cell(pRow, pCol).SetValuesHoriz(pValues);
        //////}

        ///////* Set an array of values Vertically. */
        //////public void SetValuesVert(int pRow, int pCol, object[] pValues)
        //////{
        //////    this.Cell(pRow, pCol).SetValuesVert(pValues);
        //////}

        ///////* Set a 2D array of values */
        //////public void SetValues(int pRow, int pCol, object[,] pValue)
        //////{
        //////    int vRowSize = pValue.GetLength(0);
        //////    int vColSize = pValue.GetLength(1);
        //////    Excel.Range xlRange = this.CellsRange(pRow, pCol, vRowSize, vColSize)._Range;
        //////    xlRange.set_Value(xlMissing, pValue);
        //////}
        ///////* Set an array of values Horizantally. */
        //////public void SetValuesHoriz(int pRow, int pCol, object[] pValue)
        //////{
        //////    int vColSize = pValue.Length;
        //////    Excel.Range xlRange = this.CellsRange(pRow, pCol, 1, vColSize)._Range;
        //////    xlRange.set_Value(xlMissing, pValue);
        //////}
        ///////* Set an array of values Vertically. */
        //////public void SetValuesVert(int pRow, int pCol, object[] pValue)
        //////{
        //////    int vRowSize = pValue.Length;
        //////    Excel.Range xlRange = this.CellsRange(pRow, pCol, vRowSize, 1)._Range;
        //////    xlRange.set_Value(xlMissing, pValue);
        //////}

    }

    public class ExlRange
    {
        internal Excel.Range _Range;
        private object xlMissing = System.Reflection.Missing.Value; /* The optional argument for Excel calls. */

        public ExlRange(Excel.Range pRange)
        {
            _Range = pRange;
        }

        /* Get/Set a single value */
        public object Value
        {
            set
            {
                _Range.set_Value(xlMissing, value);
            }
            get
            {
                return _Range.get_Value(xlMissing);
            }
        }

        /* Get/Set a formula */
        public object Formula
        {
            set
            {
                _Range.Formula = value;
            }
            get
            {
                return _Range.Formula;
            }
        }

        /* Set a 2D array of values */
        public void SetValues(object[,] pValue)
        {
            int vRowSize = pValue.GetLength(0);
            int vColSize = pValue.GetLength(1);
            if (vRowSize != 0 && vColSize != 0)
            {
                Excel.Range xlRangeResized = _Range.get_Resize(vRowSize, vColSize);
                xlRangeResized.set_Value(xlMissing, pValue);
            }
        }

        /* Set an array of values Horizantally. */
        public void SetValuesHoriz(object[] pValue)
        {
            int vColSize = pValue.Length;
            Excel.Range xlRangeResized = _Range.get_Resize(1, vColSize);
            xlRangeResized.set_Value(xlMissing, pValue);
        }

        /* Set an array of values Vertically. */
        public void SetValuesVert(object[] pValue)
        {
            int vRowSize = pValue.Length;
            Excel.Range xlRangeResized = _Range.get_Resize(vRowSize, 1);
            xlRangeResized.set_Value(xlMissing, pValue);
        }


        /*
        Format-String: for number, date, text cells
        ms-help://MS.EXCEL.14.1033/EXCEL/content/HP10342952.htm
        Number format's 4 sections: _( POS _);_( NEG _);_( ZER _);_( NAN _)
            POS: format string used for a postive number.
            NEG: format string used for a negative number.
            ZER: format string used for Zero.
            NAN: format string used for it is not a number.
        //== default formatting ======
            string FMT_TEXT = "@";
            string FMT_NUM_INT = "_(0_);_(-0_);_(_);_(@_)";
            string FMT_NUM_MONEY = "_(#,##,##,##0.00_);_(-#,##,##,##0.0_);_(_);_(@_)";
        */
        public string NumberFormat
        {
            set
            {
                _Range.NumberFormat = value;
            }
            get
            {
                return _Range.NumberFormat + "";
            }
        }

        /* Alignments */
        public ExlHAlign HorizontalAlignment
        {
            set
            {
                _Range.HorizontalAlignment = value;
            }
            get
            {
                return (ExlHAlign)_Range.HorizontalAlignment;
            }
        }

        public ExlVAlign VerticalAlignment
        {
            set
            {
                _Range.VerticalAlignment = value;
            }
            get
            {
                return (ExlVAlign)_Range.VerticalAlignment;
            }
        }

        /* Cell Indent */
        public int IndentLevel
        {
            set
            {
                /*
                PBM: Use of 'IndentLevel', raises mal-behaviour with Alignments.
                SOL: use 'IndentLevel()' before 'V/H-Alignment()'.
                */
                _Range.IndentLevel = value;
                //--pRange.InsertIndent(pIndentLevel); /*Adds(plus) to IndentLevel*/            }
            }
            get
            {
                return (int)_Range.IndentLevel;
            }
        }

        /* Font: Name, Size, B, I, U */
        public void Font(string pFontName, double pSize)
        {
            _Range.Font.Name = pFontName;
            _Range.Font.Size = pSize;
        }
        public string FontName
        {
            set
            {
                _Range.Font.Name = value;
            }
            get
            {
                return _Range.Font.Name + "";
            }
        }
        public double FontSize
        {
            set
            {
                _Range.Font.Size = value;
            }
            get
            {
                return (double)_Range.Font.Size;
            }
        }
        public bool FontBold
        {
            set
            {
                _Range.Font.Bold = value;
            }
            get
            {
                return (bool)_Range.Font.Bold;
            }
        }
        public bool FontItalic
        {
            set
            {
                _Range.Font.Italic = value;
            }
            get
            {
                return (bool)_Range.Font.Italic;
            }
        }
        public bool FontUnderline
        {
            set
            {
                _Range.Font.Underline = value;
            }
            get
            {
                return (bool)_Range.Font.Underline;
            }
        }


        /* Colors: Text color, Cell Fill color */
        public Color ForeColor ///--Font/Text Color
        {
            set
            {
                _Range.Font.Color = ColorTranslator.ToOle(value);
            }
            get
            {
                return ColorTranslator.FromOle((int)_Range.Font.Color);
            }
        }
        public Color BackColor
        {
            set
            {
                _Range.Interior.Color = ColorTranslator.ToOle(value);
            }
            get
            {
                return ColorTranslator.FromOle((int)_Range.Interior.Color);
            }
        }


        /* Borders: Style, Weight, Color */
        public void Border(ExlLineStyle pLineStyle, ExlBorderWeight pBorderWeight, Color pBorderColor)
        {
            //--pRange.BorderAround(pLineStyle, pBorderWeight, ColorTranslator.ToOle(pBorderColor), xlMissing);
            _Range.Borders.LineStyle = pLineStyle;
            _Range.Borders.Weight = pBorderWeight;
            _Range.Borders.Color = ColorTranslator.ToOle(pBorderColor);
        }
        public void Border(ExlLineStyle pLineStyle, ExlBorderWeight pBorderWeight)
        {
            //-- pRange.BorderAround((Excel.XlLineStyle)pLineStyle, (Excel.XlBorderWeight)pBorderWeight, Excel.XlColorIndex.xlColorIndexAutomatic, xlMissing);
            _Range.Borders.LineStyle = pLineStyle;
            _Range.Borders.Weight = pBorderWeight;
        }
        public void Border(ExlLineStyle pLineStyle)
        {
            _Range.Borders.LineStyle = pLineStyle;
        }

        public bool Visible
        {
            set
            {
                //--_Range.Hidden = (!value);
                if (_Range.Column >= 1)
                {
                    if (value == true)
                    {
                        _Range.UseStandardWidth = true;
                    }
                    else
                    {
                        _Range.EntireColumn.ColumnWidth = 0;
                    }
                }
                else if (_Range.Row >= 1)
                {
                    if (value == true)
                    {
                        _Range.UseStandardHeight = true;
                    }
                    else
                    {
                        _Range.EntireRow.RowHeight = 0;
                    }
                }
            }
            get
            {
                //--return (!((bool)_Range.Hidden));
                if (_Range.Column >= 1)
                {
                    return ((int)_Range.ColumnWidth != 0);
                }
                else if (_Range.Row >= 1)
                {
                    return ((int)_Range.ColumnWidth != 0);
                }
                return false;
            }
        }

        /* Col-Width & Row-Height & Accommodations */
        public int ColumnWidth
        {
            set
            {
                _Range.ColumnWidth = value;
            }
            get
            {
                return (int)_Range.ColumnWidth;
            }
        }

        public int RowHeight
        {
            set
            {
                _Range.RowHeight = value;
            }
            get
            {
                return (int)_Range.RowHeight;
            }
        }

        public void AutoFitColumns()
        {
            _Range.EntireColumn.AutoFit();
        }

        public void AutoFitRows()
        {
            _Range.EntireRow.AutoFit();
        }

        public bool WrapText
        {
            set
            {
                _Range.WrapText = value;
            }
            get
            {
                return (bool)_Range.WrapText;
            }
        }

        public bool ShrinkToFit
        {
            set
            {
                _Range.ShrinkToFit = value;
            }
            get
            {
                return (bool)_Range.ShrinkToFit;
            }
        }

        /* Merge Cells */
        public void Merge()
        {
            _Range.Merge(false);
        }

        public void UnMerge()
        {
            _Range.UnMerge();
        }

        public void RowWiseMerge()
        {
            _Range.Merge(true);
        }

        /* Data handling */
        public void AutoFilter()
        {
            _Range.AutoFilter("1", xlMissing, Excel.XlAutoFilterOperator.xlOr, xlMissing, xlMissing);
        }

    }//cls//


    /*== ENUMS ===========================================================================================================*/

    public enum ExlHAlign
    {
        xlHAlignLeft = Excel.XlHAlign.xlHAlignLeft,
        xlHAlignRight = Excel.XlHAlign.xlHAlignRight,
        xlHAlignCenter = Excel.XlHAlign.xlHAlignCenter,
        xlHAlignJustify = Excel.XlHAlign.xlHAlignJustify,
        xlHAlignFill = Excel.XlHAlign.xlHAlignFill,
        xlHAlignGeneral = Excel.XlHAlign.xlHAlignGeneral,
        xlHAlignDistributed = Excel.XlHAlign.xlHAlignDistributed,
        xlHAlignCenterAcrossSelection = Excel.XlHAlign.xlHAlignCenterAcrossSelection
    }

    public enum ExlVAlign
    {
        xlVAlignTop = Excel.XlVAlign.xlVAlignTop,
        xlVAlignBottom = Excel.XlVAlign.xlVAlignBottom,
        xlVAlignCenter = Excel.XlVAlign.xlVAlignCenter,
        xlVAlignJustify = Excel.XlVAlign.xlVAlignJustify,
        xlVAlignDistributed = Excel.XlVAlign.xlVAlignDistributed
    }

    public enum ExlLineStyle
    {
        xlLineStyleNone = Excel.XlLineStyle.xlLineStyleNone,
        xlContinuous = Excel.XlLineStyle.xlContinuous,
        xlDouble = Excel.XlLineStyle.xlDouble,
        xlDash = Excel.XlLineStyle.xlDash,
        xlDot = Excel.XlLineStyle.xlDot,
        xlDashDot = Excel.XlLineStyle.xlDashDot,
        xlDashDotDot = Excel.XlLineStyle.xlDashDotDot,
        xlSlantDashDot = Excel.XlLineStyle.xlSlantDashDot
    }

    public enum ExlBorderWeight
    {
        xlHairline = Excel.XlBorderWeight.xlHairline,
        xlThin = Excel.XlBorderWeight.xlThin,
        xlMedium = Excel.XlBorderWeight.xlMedium,
        xlThick = Excel.XlBorderWeight.xlThick
    }

}//ns//
