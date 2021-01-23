using System.Threading;
using System.Globalization;

namespace CXLIB
{
    public class cCultureInfo
    {
        public static string toUpperCase(string sString)
        {
            //Get the culture property of the thread.
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            //Create TextInfo object.
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToUpper(sString);
        }
        ///
        public static string toLowerCase(string sString)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToLower(sString);
        }
        ///
        public static string toTitleCase(string sString)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(sString);
        }
        ///
    }///cls
}///ns
