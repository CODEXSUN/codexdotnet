namespace CXLIB
{
    public class Checks
    {
        public static string Escape(string v)
        {

            if (v.Contains(@"\"))
            {
                v = v.Replace(@"\", @"\\");
            }
            else if (v.Contains(@"/"))
            {
                v = v.Replace(@"/", @"//");
            }
            else if (v.Contains(@"'"))
            {
                v = v.Replace("'", "''");
            }
            else if (v == null)
            {
                return "";
            }
            return v;


        }


        public static string RemoveEscape(string v)
        {

            if (v.Contains(@"\\"))
            {
                v = v.Replace(@"\\", @"\");
            }
            else if (v.Contains(@"//"))
            {
                v = v.Replace(@"//", @"/");
            }
            else if (v.Contains(@"''"))
            {
                v = v.Replace("''", "'");
            }
            else if (v == null)
            {
                return "";
            }
            return v;

        }


    }
}
