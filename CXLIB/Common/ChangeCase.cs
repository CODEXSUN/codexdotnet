using System;
using System.Threading;
using System.Globalization;

namespace CXLIB
{
    public static class ChangeCase
    {
        //
        #region[ToUpper]

        public static string ToUpper(this string value)
        {
            if (value == null || value.Length < 2)
                return value;

            //Get the culture property of the thread.

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;

            //Create TextInfo object.

            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToUpper(value);
        }

        #endregion[ToUppe]

        #region[ToLower]

        public static string ToLower(this string value)
        {
            if (value == null || value.Length < 2)
                return value;

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToLower(value);
        }

        #endregion[ToLower]

        #region[ToTitle]

        public static string ToTitle(this string value)
        {
            if (value == null || value.Length < 2)
                return value;

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(value.ToLower());
        }

        #endregion[ToTitle]

        #region[ToCamel]

        public static string ToCamel(this string value)
        {
            // If there are 0 or 1 characters, just return the string.
            if (value == null || value.Length < 2)
                return value;

            // Split the string into words.

            string[] words = value.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.

            string result = words[0].ToLower();

            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }
        #endregion[ToCamel]

        #region[ToPascal]

        public static string ToPascal(this string value)
        {
            // If there are 0 or 1 characters, just return the string.

            if (value == null) return value;
            if (value.Length < 2) return value.ToUpper();

            // Split the string into words.

            string[] words = value.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.

            string result = "";
            foreach (string word in words)
            {
                result +=
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1);
            }

            return result;
        }
        #endregion[ToPascal]

        #region[ToProper]

        public static string ToProper(this string value)
        {
            // If there are 0 or 1 characters, just return the string.

            if (value == null) return value;
            if (value.Length < 2) return value.ToUpper();

            // Start with the first character.

            string result = value.Substring(0, 1).ToUpper();

            // Add the remaining characters.

            for (int i = 1; i < value.Length; i++)
            {
                if (char.IsUpper(value[i])) result += " ";

                result += value[i].ToString();
            }
            return result;
        }

        #endregion[ToProper]
        //
        #region[UpperFirst]

        public static string UpperFirst(this string value)
        {
            // If there are 0 or 1 characters, just return the string.

            if (value == null) return value;
            if (value.Length < 2) return value.ToUpper();

            // Start with the first character.

            string result = value.Substring(0, 1).ToUpper();

            // Add the remaining characters.

            for (int i = 1; i < value.Length; i++)
            {
                result += value[i].ToString().ToLower();
            }
            return result;
        }

        #endregion[UpperFirst]

    }//cls
}//ns
