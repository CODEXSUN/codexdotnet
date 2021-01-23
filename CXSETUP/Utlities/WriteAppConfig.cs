using System.IO;
using CXLIB;

namespace CXSETUP
{
    public class WriteAppConfig
    {
        public WriteAppConfig(Setup obj)
        {
            string vpath = @"" + (Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            File.WriteAllText(vpath + "\\App.config", XmlCode(obj));
        }
        private static string XmlCode(Setup obj)
        {
            string __result = "<? xml version = \"1.0\" encoding = \"utf - 8\" ?>\r\n";
            __result += "<configuration>\r\n";
            __result += "<appSettings>\r\n";
            __result += "<add key = \"DBHOST\" value = \"localhost\"/>\r\n";
            __result += "<add key = \"DBNAME\" value = \""+obj.Database+"\" />\r\n";
            __result += "<add key = \"UPDATEURL\" value = \"http://www.codexsun.com/autoupdate/codexsun/updater.xml\" />\r\n";
            //__result += "<add key = \"BACKUPPATH\" value = \"sundar\" />\r\n";
            __result += "</appSettings>\r\n";
            __result += "</configuration>\r\n";
            return __result;

        }
    }
}