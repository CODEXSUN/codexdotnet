
using System;

namespace CXLIB
{
    public class ConvertTO
    {

        #region[ObjString]
        public static string ObjString(object v)
        {

            if (v is DBNull)
            {
                return string.Empty;
            }
            else
            {
                return v.ToString();
            }

        }

        #endregion[ObjString]

        #region[Sql String]

        public static string SqlString(string pText)
        {
            if (pText != null)
            {
                return "'" + pText.Replace("'", "''") + "'";
            }
            else
            {
                return "''";
            }
        }

        public static string SqlInt(int pText)
        {
                return "'" + pText + "'";
        }

        public static string SqlDecimal(Decimal pText)
        {
            return "'" + pText + "'";
        }

        #endregion[Sql String

        #region[Date 2 String]

        public static string Date2S(string v)
        {
            if ((v != "")&& (v != null))
            {
                //return (DateTime.ParseExact(v, "yyyy-MM-dd HH:mm tt", null)).ToString();
               // return (DateTime.ParseExact(v.Trim(), "dd-MM-yyyy", null)).ToString();
                return "" + (Convert.ToDateTime(v.Trim())).ToString("dd-MM-yyyy") + "";
            }
            return DateTime.Now.ToString("dd-MM-yyyy");
        }
        #endregion[Date 2 String]


        #region[Date]

        public static DateTime DDate(string v)
        {
            if ((v != "") && (v != null))
            {
                return Convert.ToDateTime(v.Trim());
            }
            return DateTime.Now;
        }
        
        #endregion[Date]


        public static int Integer(object value)
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
        }//integer


        //public static string SqlString(string value)
        //{
        //    if (value != null)
        //    {
        //        return "'" + value.Replace("'", "''") + "'";
        //    }
        //    else
        //    {
        //        return "''";
        //    }

        //}
        ///
        public static string SqlDate(string pDate)
        {
            if (pDate != "")
            {
                return "'" + (Convert.ToDateTime(pDate)).ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                return "'" + DateTime.Now.ToString(("yyyy-MM-dd")) + "'";
            }
        }
        ///
        public static string SqlDateTime(string pDateTime)
        {
            return "'" + (Convert.ToDateTime(pDateTime)).ToString("yyyy-MM-dd HH:mm:ss") + "'";
        }
        ///
        public static string SqlTime(string pTime)
        {
            //return "'" + (Convert.ToDateTime("02-12-2015 " + pTime)).ToString("HH:mm:ss") + "'";
            return "'" + (Convert.ToDateTime(pTime)).ToString("HH:mm:ss") + "'";
        }

        public static string AccesDateTime(string pDateTime)
        {
            return " #" + (Convert.ToDateTime(pDateTime)).ToString("MM-dd-yyyy HH:mm:ss") + "# ";
        }
        ///
        //public static string Date2S(string pTime)
        //{
        //    string sTime = "";

        //    if (pTime != "")
        //    {
        //        sTime = "" + (Convert.ToDateTime(pTime)).ToString("dd-MM-yyyy") + "";
        //    }
        //    return sTime;
        //}
        public static DateTime SystemDateTime(string pTime)
        {
            DateTime sTime = DateTime.Now;

            if (pTime != "")
            {
                sTime = DateTime.Parse(pTime, new System.Globalization.CultureInfo("nl-BE").DateTimeFormat);
            }
            return sTime;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pTime"></param>
        /// <returns></returns>
        public static string Year2S(string pTime)
        {
            string sTime = "";

            if (pTime != "")
            {
                sTime = "" + (Convert.ToDateTime(pTime)).ToString("yyyy") + "";
            }
            return sTime;
        }
        /// 
        public static string Year1S(string pTime)
        {
            string sTime = "";

            if (pTime != "")
            {
                sTime = "" + (Convert.ToDateTime(pTime)).ToString("yy") + "";
            }
            return sTime;
        }
        /// 
        ///
        public static string Time2S(string pTime)
        {
            return "" + (Convert.ToDateTime(pTime)).ToString("HH:mm:ss") + "";
        }
        ///
        ///
        ///
        public static string DateTime24S(string pTime)
        {
            return "" + (Convert.ToDateTime(pTime)).ToString("dd-MM-yyyy HH:mm:ss") + "";
        }
        ///
        public static string DateTime12S(string pTime)
        {
            return "" + (Convert.ToDateTime(pTime)).ToString("dd-MM-yyyy hh:mm:ss tt") + "";
        }
        ///
        public static string Time12h(string pTime)
        {
            return "" + (Convert.ToDateTime("02-12-2015 " + pTime)).ToString("hh:mm:ss tt") + "";
        }
        ///
        public static string Time24h(string pTime)
        {
            string sTime = "";
            if (pTime != "")
            {
                sTime = "" + (Convert.ToDateTime("02-12-2015 " + pTime)).ToString("HH:mm:ss") + "";
            }
            return sTime;
        }
        ///
        public static string Decimal2d(string pDecimal)
        {
            if (pDecimal != null)
            {
                if (pDecimal != "")
                {
                    return "" + string.Format("{0:0.00}", decimal.Parse(pDecimal)) + "";
                }
            }
            return "0";
        }
        ///
        public static string Decimal3d(string pDecimal)
        {
            if (pDecimal != "")
            {
                return "" + string.Format("{0:0.000}", decimal.Parse(pDecimal)) + "";
            }
            return "";
        }
        ///
        /// 
        ///
        public static string DecimalToS(string pDecimal)
        {
            if (pDecimal != null)
            {
                if (pDecimal != "")
                {
                    //return "" + string.Format("{0:0.###}", (Convert.ToDecimal(pDecimal))) + "";
                    return "" + string.Format("{0:G29}", decimal.Parse(pDecimal)) + "";

                }
            }
            return "";
        }
        ///
        public static string Money2N(string pMoney)
        {
            return "" + Math.Truncate(Convert.ToDecimal(pMoney)) + "";
        }
        /// <summary>
        //  converting form timespan to string format 
        /// </summary>
        public static string Timespan2String(TimeSpan pText)
        {
            return (string.Format("{0:00}:{1:00}:{2:00}", (int)pText.TotalHours, pText.Minutes, pText.Seconds) + "");
        }


        ///
        public static string addDays(string pDate, int pDays)
        {
            if (pDate != "")
            {
                return "" + (Convert.ToDateTime(pDate).AddDays(pDays)).ToString("dd-MM-yyyy") + "";
            }
            return string.Empty;
        }
        ///
        public static string Rtf2String(string pText)
        {
            System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();
            rtBox.Rtf = pText + "";
            return "" + rtBox.Text + "";

        }


        public static decimal Decimal(object value)
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

        ///

    }//cls
}//ns
