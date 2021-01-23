using System;
using System.Collections.Generic;
using System.IO;

namespace CXSETUP
{
    public class SQL_DB_Query
    {

        public static void Build(string db)
        {
            string __result = "";

            //__result += DB_Setup.CreateDatabase(db);
            __result += "\r\n";
            __result += "\r\n";
            __result += "\r\n";
            __result += "\r\n";
            __result += "\r\n";


















            //Finally Write to File
            WriteScript(__result);

        }

        #region[Write]
        private static void WriteScript(string v) 
        {
            string Vpath = (Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)).Replace(@"CXTEST\bin\Debug", "")
             + @"CXSETUP\SQL\";

            File.WriteAllText(@"" + Vpath + "\\codexsun.sql", v);
        }

        #endregion
    }
}
