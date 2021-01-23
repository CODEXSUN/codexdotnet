using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace CXLIB
{
    public static class Global
    {
        ///[ statics ]////////////////////////////////////////////////////////////////////////////
        public static object BASE_PANEL = "BASE_PANEL"; /*to be used with Tag object*/

        public static Control GetBasePanel(Control cnt)
        {
            Control pcnt = cnt.Parent;
            if (pcnt is TabPage)
            {
                pcnt = pcnt.Parent; ///-- TabControl
                pcnt = pcnt.Parent; ///-- TabControl's parent
            }
            if (pcnt == null)
            {
                return null;
            }
            else if (pcnt.Tag == Global.BASE_PANEL)
            {
                return pcnt;
            }
            else
            {
                return GetBasePanel(pcnt); /**RECURSIVE CALL**/
            }
        }

        public static bool IsBasePanel(Control pcnt)
        {
            if (pcnt == null)
            {
                return false;
            }
            else
            {
                if (pcnt.Tag == Global.BASE_PANEL)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static object INPUT_PANEL = "INPUT_PANEL"; /*to be used with Tag object*/

        public static Control GetInputPanel(Control cnt)
        {
            Control pcnt = cnt.Parent;
            if (pcnt == null)
            {
                return null;
            }
            else if (pcnt.Tag == Global.INPUT_PANEL)
            {
                return pcnt;
            }
            else
            {
                return GetInputPanel(pcnt); /**RECURSIVE CALL**/
            }
        }

        /*
        usage: MessageBox.Show("MAIN->" + Global.FindActiveControl(GlobalApp.F_MAIN));
        */
        public static string FindActiveControl(IContainerControl cc)
        {
            if (cc.ActiveControl == null)
            {
                return "[NULL]";
            }
            else
            {
                if (cc.ActiveControl is IContainerControl)
                {
                    return cc.ActiveControl.GetType().Name + ":" + cc.ActiveControl.Name + "->" + FindActiveControl(cc.ActiveControl as IContainerControl);
                }
                else
                {
                    return cc.ActiveControl.GetType().Name + ":" + cc.ActiveControl.Name;
                }
            }
        }

        public static Rectangle RectangeInflate(Rectangle pBounds, int pTop, int pRight, int pBottom, int pLeft)
        {
            int iTop = pBounds.Top - pTop;
            int iLeft = pBounds.Left - pLeft;
            int iWidth = pLeft + pBounds.Width + (pRight * 1);
            int iHeight = pTop + pBounds.Height + (pBottom * 1);
            Rectangle iRect = new Rectangle(iLeft, iTop, iWidth, iHeight);
            return iRect;
        }

        ///////////////////////////////////////////////////////////////////////////////

        public static string GetAbsolutePath(string relativePath)
        {
            return System.Windows.Forms.Application.StartupPath + @"\" + relativePath;
        }

        public static string JoinString(IEnumerable pValues)
        {
            string vStr = "";
            foreach (object val in pValues)
            {
                if (vStr != "")
                {
                    vStr += ",";
                }
                vStr += val;
            }
            return vStr;
        }


        public static string PadText(string pText, int pWidth)
        {
            return PadText(pText, pWidth, TextAlignEnum.Left, " ");
        }
        public static string PadText(string pText, int pWidth, string pPadChar)
        {
            return PadText(pText, pWidth, TextAlignEnum.Left, pPadChar);
        }
        //==bool pAllowTruncation: if true throw exception on text is truncated/clipped.
        public static string PadText(string pText, int pWidth, TextAlignEnum pAlign, string pPadChar)
        {
            string temp = "";
            switch (pAlign)
            {
                case TextAlignEnum.Left:
                    temp = AlignTextLeft(pText, pWidth, pPadChar);
                    break;
                case TextAlignEnum.Right:
                    temp = AlignTextRight(pText, pWidth, pPadChar);
                    break;
                case TextAlignEnum.Center:
                    //
                    break;
            }
            return temp;
        }


        static string AlignTextLeft(string pText, int pWidth, string pPadChar)
        {
            string temp = "";
            if (pText.Length > pWidth)
            {
                temp = pText.Substring(0, pWidth);
            }
            else
            {
                temp = pText;
                temp = temp + RepeatText(pPadChar, pWidth - temp.Length);
            }
            return temp;
        }

        static string AlignTextRight(string pText, int pWidth, string pPadChar)
        {
            string temp = "";
            if (pText.Length > pWidth)
            {
                temp = pText.Substring(0, pWidth);
            }
            else
            {
                temp = pText;
                temp = RepeatText(pPadChar, pWidth - temp.Length) + temp;
            }
            return temp;
        }

        static string RepeatText(string pText, int pTimes)
        {
            string temp = "";
            for (int i = 1; i <= pTimes; i++)
            {
                temp += pText;
            }
            return temp;
        }



        #region [ VALIDATION ROUTINES ]

        public static bool IsNumber(string numberString)
        {
            decimal d;
            return IsNumber(numberString, out d);
        }

        public static bool IsNumber(string numberString, out decimal number)
        {
            if (Decimal.TryParse("0" + numberString.Trim(), out number) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsIntegerNumber(string numberString)
        {
            int number;
            return IsIntegerNumber(numberString, out number);
        }

        public static bool IsIntegerNumber(string numberString, out int number)
        {
            if (Int32.TryParse("0" + numberString.Trim(), out number) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Validate_Number(System.Windows.Forms.TextBox stringBox)
        {
            stringBox.Text = stringBox.Text.Trim();
            if (IsNumber(stringBox.Text) == true)
            {
                stringBox.Text = Global.ToDecimal(stringBox.Text.Trim()) + "";
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Max(int n1, int n2)
        {
            return (n1 > n2 ? n1 : n2);
        }

        public static decimal Max(decimal n1, decimal n2)
        {
            return (n1 > n2 ? n1 : n2);
        }

        public static int Min(int n1, int n2)
        {
            return (n1 < n2 ? n1 : n2);
        }

        public static decimal Min(decimal n1, decimal n2)
        {
            return (n1 < n2 ? n1 : n2);
        }

        public static int ToInteger(object value)
        {
            if (value == null)
            {
                return 0;
            }
            else if (value is DBNull)
            {
                return 0;
            }
            else if (value.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }

        public static decimal ToDecimal(object value)
        {
            if (value == null)
            {
                return 0M;
            }
            else if (value is DBNull)
            {
                return 0M;
            }
            else if (value.ToString() == "" || value.ToString() == ".")
            {
                return 0M;
            }
            else
            {
                return Convert.ToDecimal(value);
            }
        }

        public static string ToString(object value)
        {
            return value + string.Empty;
        }

        public static bool ToBoolean(object value)
        {
            if (value == null)
            {
                return false;
            }
            else if (value is DBNull)
            {
                return false;
            }
            else
            {
                return Convert.ToBoolean(value);
            }
        }

        public static DateTime? ToDateTime(object dateObject)
        {
            if (dateObject == null)
            {
                return null;
            }
            else if (dateObject is DBNull)
            {
                return null;
            }
            else if (dateObject is DateTime?)
            {
                return (DateTime?)dateObject;
            }
            else if (dateObject is DateTime)
            {
                return (DateTime?)dateObject;
            }
            else if (dateObject is string)
            {
                string dateString = (string)dateObject;
                if (dateString == "")
                {
                    return null;
                }
                else
                {
                    DateTime? date;
                    if (IsDate(dateString, true, out date, Global.DateOrder.D_M_Y) == true)
                    {
                        return date;
                    }
                }
            }
            throw new Exception("ToDateTime() expects a DateTime object.");
        }

        //public static DateTime? ToDateTime(string dateString)
        //{
        //    DateTime? date;
        //    IsDate(dateString, true, out date, Global.DateOrder.D_M_Y);
        //    return date;
        //}

        public static bool IsDate(string dateString, bool allowNull, Global.DateOrder dateOrder)
        {
            DateTime? date;
            return IsDate(dateString, allowNull, out date, dateOrder);
        }

        public static DateTime FirstDayOfMonth(DateTime pDate)
        {
            DateTime vFirstDate = new DateTime(pDate.Year, pDate.Month, 1);
            return vFirstDate;
        }

        public static DateTime LastDayOfMonth(DateTime pDate)
        {
            int vLastDay = DateTime.DaysInMonth(pDate.Year, pDate.Month);
            DateTime vLastDate = new DateTime(pDate.Year, pDate.Month, vLastDay);
            return vLastDate;
        }

        public static DateTime FirstDayOfWeek(int pYear, int pWeek)
        {
            int vDays = (pWeek - 1) * 7; //-- "-1": to get the first day of week, "*7":to get no.of.days.
            DateTime vFirstDate = new DateTime(pYear, 1, 1);
            vFirstDate = vFirstDate.AddDays(vDays); //-- The days that we are added is in 7-folds. 
                                                    //-- Therefore the resulting date and its jan-01 yields same week-day.
                                                    //-- If it is not SUN(start of week) then we have to deduct the previous (week-)days, in the foll.steps.
            int vWeekDay = (int)vFirstDate.DayOfWeek; //-- DoW is 0-6 i.e Sun-Sat 
            vFirstDate = vFirstDate.AddDays(-1 * (vWeekDay)); //--AddDays(-1*(..)) means DeductDays(..)
            return vFirstDate;
        }


        public static string ToSqlString(object pObj)
        {
            string vStr = pObj + "";
            return ToSqlString(vStr);
        }
        public static string ToSqlString(string pStr)
        {
            pStr = pStr + ""; ///to avoid null.
            pStr = "'" + pStr.Replace("'", "''") + "'";
            return pStr;
        }

        public static string ToSqlDateString(object dt)
        {
            string format = "yyyy-MM-dd"; /*ORACLE: "dd-MMM-yy"*/

            if (dt == null)
            {
                return "NULL";
            }
            else if (dt is DBNull)
            {
                return "NULL";
            }
            else if (dt is string && (dt + "").Trim() == "")
            {
                return "NULL";
            }
            else if (dt is string && (dt + "").Trim().ToUpper() == "NULL")
            {
                return "NULL";
            }
            else
            {
                return "'" + ((DateTime)dt).ToString(format) + "'";
            }
        }


        public static string ToSqlDateTimeString(object dt)
        {
            string format = "dd-MMM-yyyy hh:mm:ss.fff tt";

            if (dt == null)
            {
                return "NULL";
            }
            else if (dt is DBNull)
            {
                return "NULL";
            }
            else if (dt is string && (dt + "").Trim() == "")
            {
                return "NULL";
            }
            else if (dt is string && (dt + "").Trim().ToUpper() == "NULL")
            {
                return "NULL";
            }
            else if (dt is DateTime)
            {
                return "'" + ((DateTime)dt).ToString(format) + "'";
            }
            else
            {
                throw new Exception("ToSqlDateTimeString() expects a DateTime object");
            }
        }

        public static string SqlDateToString(object dt)
        {
            string format = "dd/MM/yyyy";

            if (dt == null)
            {
                return "";
            }
            else if (dt is DBNull)
            {
                return "";
            }
            else if (dt is string && (dt + "").Trim() == "")
            {
                return "";
            }
            else if (dt is DateTime)
            {
                return ((DateTime)dt).ToString(format);
            }
            else
            {
                throw new Exception("SqlDateToString() expects a DateTime object");
            }
        }

        public static string SqlDateTimeToString(object dt, string format)
        {
            if (dt == null)
            {
                return "";
            }
            else if (dt is DBNull)
            {
                return "";
            }
            else if (dt is string && (dt + "").Trim() == "")
            {
                return "";
            }
            else if (dt is DateTime)
            {
                return ((DateTime)dt).ToString(format);
            }
            else
            {
                throw new Exception("SqlDateTimeToString() expects a DateTime object");
            }
        }
        public static string SqlDateTimeToString(object dt)
        {
            string format = "dd-MM-yyyy hh:mm:ss tt";
            return SqlDateTimeToString(dt, format);
        }

        public static string NumberToString(object num)
        {
            return NumberToString(num, "0.##", true);
        }
        public static string NumberToString(object num, string format)
        {
            return NumberToString(num, format, true);
        }
        public static string NumberToString(object num, string format, bool suppressIfZero)
        {
            decimal vValue = Global.ToDecimal(num);
            if (suppressIfZero == true && vValue == 0) { return ""; }
            else { return vValue.ToString(format); }
        }

        public static string ToSqlNumber(int pNumber)
        {
            return pNumber + "";
        }
        public static string ToSqlNumber(decimal pNumber)
        {
            return pNumber + "";
        }
        public static string ToSqlNumber(object pNumber)
        {
            if ((pNumber + string.Empty) == string.Empty) { return "0"; }
            else { return ToSqlNumber(Convert.ToDecimal(pNumber)); }
        }

        public static string ToSqlNumberNull(int pNumber)
        {
            if (pNumber == 0) { return "NULL"; }
            else { return pNumber + ""; }
        }
        public static string ToSqlNumberNull(decimal pNumber)
        {
            if (pNumber == 0M) { return "NULL"; }
            else { return pNumber + ""; }
        }
        public static string ToSqlNumberNull(object pNumber)
        {
            if ((pNumber + string.Empty) == string.Empty) { return "NULL"; }
            else { return ToSqlNumberNull(Convert.ToDecimal(pNumber)); }
        }


        public static string SqlBoolToStringYN(object num)
        {
            if (Global.ToInteger(num) == 0) { return "N"; }
            else { return "Y"; }
        }

        public static bool SqlBoolToBool(object num)
        {
            if (Global.ToInteger(num) == 0) { return false; }
            else { return true; }
        }

        public enum DateOrder
        {
            D_M_Y,
            Y_M_D,
            M_D_Y,
            M_Y
        }

        public static int GetMonthNumber(string monthName)
        {
            int monthNumber = -1;
            monthName = monthName.ToUpper().Trim();
            switch (monthName)
            {
                case "1":
                case "01":
                case "JAN":
                case "JANUARY":
                    monthNumber = 1;
                    break;
                case "2":
                case "02":
                case "FEB":
                case "FEBRUARY":
                    monthNumber = 2;
                    break;
                case "3":
                case "03":
                case "MAR":
                case "MARCH":
                    monthNumber = 3;
                    break;
                case "4":
                case "04":
                case "APR":
                case "APRIL":
                    monthNumber = 4;
                    break;
                case "5":
                case "05":
                case "MAY":
                    monthNumber = 5;
                    break;
                case "6":
                case "06":
                case "JUN":
                case "JUNE":
                    monthNumber = 6;
                    break;
                case "7":
                case "07":
                case "JUL":
                case "JULY":
                    monthNumber = 7;
                    break;
                case "8":
                case "08":
                case "AUG":
                case "AUGUST":
                    monthNumber = 8;
                    break;
                case "9":
                case "09":
                case "SEP":
                case "SEPTEMBER":
                    monthNumber = 9;
                    break;
                case "10":
                case "OCT":
                case "OCTOBER":
                    monthNumber = 10;
                    break;
                case "11":
                case "NOV":
                case "NNOVEMBER":
                    monthNumber = 11;
                    break;
                case "12":
                case "DEC":
                case "DECEMBER":
                    monthNumber = 12;
                    break;
            }
            return monthNumber;
        }

        public static bool IsDate(string dateString, bool allowNull, out DateTime? date, DateOrder dateOrder)
        {
            return IsDate(dateString, allowNull, out date, dateOrder, false);
        }
        public static bool IsDate(string dateString, bool allowNull, out DateTime? date, DateOrder dateOrder, bool pIncludeTime)
        {
            date = null;
            dateString = dateString.Trim();
            if (dateString == "")
            {
                if (allowNull == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ///
            string[] datePartsTemp = dateString.Split(new char[] { ' ', '/', '-', '.', ',', '\'', ':', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            if (datePartsTemp.Length > 8)
            {
                return false;
                //throw new Exception("Date format is invalid: " + dateString + ". Supported format is d/m/y h:m:s.ms AMPM");
            }
            string[] dateParts = new string[8] { "", "", "", "", "", "", "", "" };
            ///
            int i = 0;
            string AMPM = "";
            foreach (string dpart in datePartsTemp)
            {
                if (dpart == "AM" || dpart == "PM")
                {
                    AMPM = dpart;
                }
                else
                {
                    dateParts[i] = dpart;
                    i++;
                }
            }
            dateParts[7] = AMPM;

            int year = 0, month = 0, date_of_month = 0, hour = 0, minute = 0, second = 0, millisecond = 0;
            DateTime vNow = DateTime.Now;

            try
            {
                if (dateOrder == DateOrder.D_M_Y)
                {
                    date_of_month = Global.ToInteger(dateParts[0]);
                    month = GetMonthNumber(dateParts[1]);
                    year = Global.ToInteger(dateParts[2]);
                }
                else if (dateOrder == DateOrder.M_Y)
                {
                    date_of_month = 1;
                    month = GetMonthNumber(dateParts[0]);
                    year = Global.ToInteger(dateParts[1]);
                }
            }
            catch (FormatException)
            {
                return false;
            }

            if (date_of_month <= 0 || date_of_month >= 32)
            {
                date_of_month = vNow.Day;
            }
            if (month <= 0 || month >= 13)
            {
                month = vNow.Month;
            }
            if (year == 0)
            {
                year = vNow.Year;
            }
            else if (year < 50)
            {
                year += 2000;
            }
            else if (year < 100)
            {
                year += 1900;
            }
            else if (year < 1000)
            {
                year += 1000;
            }
            hour = Global.ToInteger(dateParts[3]);
            if (dateParts[7] == "AM" && hour == 12)
            {
                hour = 0;
            }
            else if (dateParts[7] == "PM" && hour != 12)
            {
                hour = hour + 12;
            }
            minute = Global.ToInteger(dateParts[4]);
            second = Global.ToInteger(dateParts[5]);
            millisecond = Global.ToInteger(dateParts[6]);

            try
            {
                if (pIncludeTime == true)
                {
                    date = new DateTime(year, month, date_of_month, hour, minute, second, millisecond);
                }
                else
                {
                    date = new DateTime(year, month, date_of_month);
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                return false;
            }

            return true;
            /*
            dateString = dateString.Trim();
            date = default(DateTime);

            if (dateString == "")
            {
                if (allowNull == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                CultureInfo enUS = new CultureInfo("en-US");
                string[] dateStyles = new string[] { "dd/MM/yyyy", "dd/MM/yy", "dd/MM/y", "d/M/y", "d/M/yy", "d/M/yyyy", "dd/M/y", "dd/M/yy", "dd/M/yyyy", "d/MM/y", "d/MM/yy", "d/MM/yyyy", "d/MMM/yy", "dd/MMM/yy" };
                if (DateTime.TryParseExact(dateString, dateStyles, enUS, DateTimeStyles.None, out date) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            */
        }

        public static bool Validate_Date(System.Windows.Forms.TextBox datebox)
        {
            return Validate_Date(datebox, false);
        }
        public static bool Validate_Date(System.Windows.Forms.TextBox datebox, bool allowNull)
        {
            datebox.Text = datebox.Text.Trim();

            if (datebox.Text == "")
            {
                if (allowNull == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                DateTime date;
                CultureInfo enUS = new CultureInfo("en-US");
                string[] dateStyles = new string[] { "dd/MM/yyyy", "dd/MM/yy", "dd/MM/y", "d/M/y", "d/M/yy", "d/M/yyyy", "dd/M/y", "dd/M/yy", "dd/M/yyyy", "d/MM/y", "d/MM/yy", "d/MM/yyyy" };
                if (DateTime.TryParseExact(datebox.Text, dateStyles, enUS, DateTimeStyles.None, out date) == true)
                {
                    datebox.Text = date.ToString("dd/MM/yyyy");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion


        #region [ AMOUNT TO WORDS ]

        public static string AmountInWords(decimal amountDec)
        {
            string words = GetWords(amountDec);
            ///
            if (words != "") /* Since GetWords() is recursive, "Only" is not placed there. */
            {
                words = words + " Only";
            }
            ///
            return words;
        }

        static string GetWords(decimal amountDec)
        {
            string words = "", tmp = "", AND = " And ";
            long amount = (long)amountDec, part = 0;
            long paise = (long)((amountDec - amount) * 100);

            if (paise != 0)
            {
                words = "Paise " + GetHundred(paise);
            }

            if (amount != 0) /* 0 to 99*/
            {
                part = amount % 100;
                amount = amount / 100;
                tmp = GetHundred(part);
                if (words == "")
                {
                    words = tmp;
                }
                else
                {
                    words = tmp + AND + words;
                    AND = " ";
                }

                if (amount != 0) /* 1h to 9h */
                {
                    part = amount % 10;
                    amount = amount / 10;
                    if (part != 0)
                    {
                        tmp = GetHundred(part) + " Hundred";
                        if (words == "")
                        {
                            words = tmp;
                        }
                        else
                        {
                            words = tmp + AND + words;
                            AND = " ";
                        }
                    }

                    if (amount != 0) /* 1t to 99t */
                    {
                        part = amount % 100;
                        amount = amount / 100;
                        if (part != 0)
                        {
                            tmp = GetHundred(part) + " Thousand";
                            if (words == "")
                            {
                                words = tmp;
                            }
                            else
                            {
                                words = tmp + AND + words;
                                AND = " ";
                            }
                        }

                        if (amount != 0) /* 1L to 99L */
                        {
                            part = amount % 100;
                            amount = amount / 100;
                            if (part != 0)
                            {
                                tmp = GetHundred(part) + " Lakh";
                                if (words == "")
                                {
                                    words = tmp;
                                }
                                else
                                {
                                    words = tmp + AND + words;
                                    AND = " ";
                                }
                            }

                            if (amount != 0) /* 1c to {RECURSIVE}c */
                            {
                                tmp = GetWords(amount) + " Crore";
                                if (words == "")
                                {
                                    words = tmp;
                                }
                                else
                                {
                                    words = tmp + AND + words;
                                    AND = " ";
                                }
                            } //if(c)
                        } //if(L)
                    } //if(t)
                } //if(h)
            } //if(<h)

            return words;
        }

        static string GetHundred(long amount)
        {
            string words = "";

            string[] ONES = new string[20] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] TENS = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (amount <= 19)
            {
                words = ONES[amount];
            }
            else
            {
                long tenspart = amount / 10;
                long onespart = amount % 10;
                words = TENS[tenspart];
                if (onespart != 0)
                {
                    words += " " + ONES[onespart];
                }
            }

            return words;
        }

        #endregion


        #region [ POSITIONING ]

        public static Rectangle GetScreenRect(Control ctrl)
        {
            if (ctrl is DataGridView)
            {
                DataGridView dgvCtrl = ctrl as DataGridView;
                Rectangle screenRect = GetScreenRect(dgvCtrl, dgvCtrl.CurrentCell.RowIndex, dgvCtrl.CurrentCell.ColumnIndex);
                return screenRect;
            }
            else
            {
                Rectangle screenRect = ctrl.Parent.RectangleToScreen(ctrl.Bounds);
                return screenRect;
            }
        }

        public static Rectangle GetScreenRect(DataGridView dgvCtrl, int rowIndex, int colIndex)
        {
            Rectangle screenRect = dgvCtrl.RectangleToScreen(dgvCtrl.GetCellDisplayRectangle(colIndex, rowIndex, false));
            return screenRect;
        }

        /*Snap to screen*/
        public static Rectangle GetSnapRect(Rectangle ctrlRect, int formReqWidth, int formReqHeight)
        {
            Rectangle monitorRect = SystemInformation.WorkingArea;
            Rectangle snapRect = new Rectangle();

            if (formReqWidth >= monitorRect.Width)
            {
                snapRect.X = monitorRect.Left;
                snapRect.Width = monitorRect.Width;
            }
            else
            {
                if (ctrlRect.Width > formReqWidth)
                {
                    formReqWidth = ctrlRect.Width;
                }
                snapRect.Width = formReqWidth;

                int leftAlignWidth = monitorRect.Right - ctrlRect.Left;
                int rightAlignWidth = ctrlRect.Right - monitorRect.Left;

                if (formReqWidth <= leftAlignWidth) //TRY LEFT ALIGN FIRST
                {
                    snapRect.X = ctrlRect.Left;
                }
                else if (formReqWidth <= rightAlignWidth)
                {
                    snapRect.X = ctrlRect.Right - formReqWidth;
                }
                else
                {
                    snapRect.X = monitorRect.Right - formReqWidth;
                }
            }
            /////////////////////////////////////////////////////

            int monitorHeight15percent = monitorRect.Height * 15 / 100;

            int bottomAlignHeight = monitorRect.Bottom - ctrlRect.Bottom;
            int topAlignHeight = ctrlRect.Top - monitorRect.Top;

            if (formReqHeight <= bottomAlignHeight)//TRY BOTTOM ALIGN FIRST
            {
                snapRect.Y = ctrlRect.Top; //==Bottom
                snapRect.Height = formReqHeight;
            }
            else if (monitorHeight15percent <= bottomAlignHeight) //TRY BOTTOM ALIGN, AGAIN WITH 15% HEIGHT.
            {
                snapRect.Y = ctrlRect.Top; //==Bottom
                snapRect.Height = monitorRect.Bottom - ctrlRect.Top;
            }
            else if (formReqHeight <= topAlignHeight)
            {
                snapRect.Y = ctrlRect.Top - formReqHeight;
                snapRect.Height = formReqHeight;
            }
            else
            {
                snapRect.Y = monitorRect.Top;
                snapRect.Height = ctrlRect.Top - monitorRect.Top;
            }
            ///////////////////////////////////////////////////////

            const int MIN_WIDTH = 100;
            if (snapRect.Width < MIN_WIDTH) snapRect.Width = MIN_WIDTH;

            const int MIN_HEIGHT = 100;
            if (snapRect.Height < MIN_HEIGHT) snapRect.Height = MIN_HEIGHT;

            return snapRect;
        }

        /*Snap to another container*/
        public static Rectangle GetSnapRect(Rectangle ctrlRect, int formReqWidth, int formReqHeight, Control pParent)
        {
            Rectangle monitorRect = new Rectangle(0, 0, pParent.Width, pParent.Height);
            Rectangle snapRect = new Rectangle();

            if (formReqWidth >= monitorRect.Width)
            {
                snapRect.X = monitorRect.Left;
                snapRect.Width = monitorRect.Width;
            }
            else
            {
                if (ctrlRect.Width > formReqWidth)
                {
                    formReqWidth = ctrlRect.Width;
                }
                snapRect.Width = formReqWidth;

                int leftAlignWidth = monitorRect.Right - ctrlRect.Left;
                int rightAlignWidth = ctrlRect.Right - monitorRect.Left;

                if (formReqWidth <= leftAlignWidth) //TRY LEFT ALIGN FIRST
                {
                    snapRect.X = ctrlRect.Left;
                }
                else if (formReqWidth <= rightAlignWidth)
                {
                    snapRect.X = ctrlRect.Right - formReqWidth;
                }
                else
                {
                    snapRect.X = monitorRect.Right - formReqWidth;
                }
            }
            /////////////////////////////////////////////////////

            int monitorHeight15percent = monitorRect.Height * 15 / 100;

            int bottomAlignHeight = monitorRect.Bottom - ctrlRect.Bottom;
            int topAlignHeight = ctrlRect.Top - monitorRect.Top;

            if (formReqHeight <= bottomAlignHeight)//TRY BOTTOM ALIGN FIRST
            {
                snapRect.Y = ctrlRect.Top; //==Bottom
                snapRect.Height = formReqHeight;
            }
            else if (monitorHeight15percent <= bottomAlignHeight) //TRY BOTTOM ALIGN, AGAIN WITH 15% HEIGHT.
            {
                snapRect.Y = ctrlRect.Top; //==Bottom
                snapRect.Height = monitorRect.Bottom - ctrlRect.Top;
            }
            else if (formReqHeight <= topAlignHeight)
            {
                snapRect.Y = ctrlRect.Top - formReqHeight;
                snapRect.Height = formReqHeight;
            }
            else
            {
                snapRect.Y = monitorRect.Top;
                snapRect.Height = ctrlRect.Top - monitorRect.Top;
            }
            ///////////////////////////////////////////////////////

            const int MIN_WIDTH = 100;
            if (snapRect.Width < MIN_WIDTH) snapRect.Width = MIN_WIDTH;

            const int MIN_HEIGHT = 100;
            if (snapRect.Height < MIN_HEIGHT) snapRect.Height = MIN_HEIGHT;

            return snapRect;
        }

        public static Point GetSnapPoint(Rectangle ctrlRect, int formWidth, int formHeight)
        {
            Rectangle monitorRect = SystemInformation.WorkingArea;
            Point snapPoint = new Point();

            if (formWidth >= monitorRect.Width)
            {
                snapPoint.X = monitorRect.Left;
            }
            else
            {
                int leftAlignWidth = monitorRect.Right - ctrlRect.Left;
                int rightAlignWidth = ctrlRect.Right - monitorRect.Left;

                if (formWidth <= leftAlignWidth) //TRY LEFT ALIGN FIRST
                {
                    snapPoint.X = ctrlRect.Left;
                }
                else if (formWidth <= rightAlignWidth)
                {
                    snapPoint.X = ctrlRect.Right - formWidth;
                }
                else
                {
                    snapPoint.X = monitorRect.Left;
                }
            }
            /////////////////////////////////////////////////////

            int bottomAlignHeight = monitorRect.Bottom - ctrlRect.Bottom;
            int topAlignHeight = ctrlRect.Top - monitorRect.Top;

            if (formHeight <= bottomAlignHeight)//TRY BOTTOM ALIGN FIRST
            {
                snapPoint.Y = ctrlRect.Top; //==Bottom
            }
            else if (formHeight <= topAlignHeight)
            {
                snapPoint.Y = ctrlRect.Top - formHeight;
            }
            else
            {
                snapPoint.Y = monitorRect.Top;
            }
            ///////////////////////////////////////////////////////

            return snapPoint;
        }

        ///===================================================================

        #endregion
    }

    ///////////////////////////////////////////////////////////////////////////////////

    public enum TextAlignEnum
    {
        Left,
        Center,
        Right,
    }//enum//

    ///////////////////////////////////////////////////////////////////////////////////

    public enum Action
    {
        Open,
        New,
        Edit,
        Delete,
        Cancel,
        Print,
        Merge
    }

    ///////////////////////////////////////////////////////////////////////////////////

    public class SgException : Exception
    {
        public SgException(string pMessage)
            : base(pMessage)
        {
            ///
        }

        public SgException(string pMessage, Exception pInnerException)
            : base(pMessage, pInnerException)
        {
            ///
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////

    /* StringObjectPair class is used as ComboBox object; with ToString() support. */
    //public class StringObjectPair : IComparable
    //{
    //    public string DisplayName;
    //    public object Value;

    //    public StringObjectPair(string pKeyDisplayName, object pValue)
    //    {
    //        DisplayName = pKeyDisplayName;
    //        Value = pValue;
    //    }

    //    #region [ Object Impl. - ToString(), Equals() ]

    //    public override string ToString()
    //    {
    //        return DisplayName;
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is DBNull)
    //            return false;
    //        if (!(obj is StringObjectPair))
    //            return false;
    //        StringObjectPair that = (StringObjectPair)obj;
    //        bool vRes = (this.DisplayName.Equals(that.DisplayName) && this.Value.Equals(that.Value));
    //        return vRes;
    //    } 

    //    #endregion

    //    #region [ IComparable Impl. - CompareTo() ]

    //    public int CompareTo(object obj)
    //    {
    //        string that = obj + "";
    //        int vRes = (this.DisplayName.CompareTo(that));
    //        return vRes;
    //    }

    //    #endregion

    //    #region [ Static Mehtods - Search(), Exists() ]

    //    public static StringObjectPair Search(StringObjectPair pSearchItem, IEnumerable pList)
    //    {
    //        StringObjectPair pRes = null;
    //        foreach (object obj in pList)
    //        {
    //            if (obj.Equals(pSearchItem))
    //            {
    //                pRes = (StringObjectPair)obj;
    //                break;
    //            }
    //        }
    //        return pRes;
    //    }

    //    public static bool Exists(StringObjectPair pSearchItem, IEnumerable pList)
    //    {
    //        StringObjectPair vPair = Search(pSearchItem, pList);
    //        if (vPair == null)
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return true;
    //        }
    //    }

    //    #endregion
    //}

    //public class StringValuePair<T> : IComparable
    //{   
    //    public string DisplayName;
    //    public T Value;

    //    public StringValuePair(string pKeyDisplayName, T pValue)
    //    {
    //        DisplayName = pKeyDisplayName;
    //        Value = pValue;
    //    }

    //    #region [ Object Impl. - ToString(), Equals() ]

    //    public override string ToString()
    //    {
    //        return DisplayName;
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is DBNull)
    //            return false;
    //        if (!(obj is StringValuePair<T>))
    //            return false;
    //        StringValuePair<T> that = (StringValuePair<T>)obj;
    //        bool vRes = (this.DisplayName.Equals(that.DisplayName) && this.Value.Equals(that.Value));
    //        return vRes;
    //    }

    //    #endregion

    //    #region [ IComparable Impl. - CompareTo() ]

    //    public int CompareTo(object obj)
    //    {
    //        string that = obj + "";
    //        int vRes = (this.DisplayName.CompareTo(that));
    //        return vRes;
    //    }

    //    #endregion

    //    #region [ Static Mehtods - Search(), Exists() ]

    //    public static StringValuePair<T> Search(StringValuePair<T> pSearchItem, IEnumerable pList)
    //    {
    //        StringValuePair<T> pRes = null;
    //        foreach (object obj in pList)
    //        {
    //            if (obj.Equals(pSearchItem))
    //            {
    //                pRes = (StringValuePair<T>)obj;
    //                break;
    //            }
    //        }
    //        return pRes;
    //    }

    //    public static bool Exists(StringValuePair<T> pSearchItem, IEnumerable pList)
    //    {
    //        StringValuePair<T> vPair = Search(pSearchItem, pList);
    //        if (vPair == null)
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return true;
    //        }
    //    }

    //    #endregion
    //}
    /////////////////////////////////////////////////////////////////////////////////////











}//ns//
