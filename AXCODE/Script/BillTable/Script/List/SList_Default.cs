using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SList_default
    {
        public static void XList_default(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\L" + tbl_name + ".designer.cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {
            List<SFields> list = obj.SFields;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            string TABLENAME = vtablesname.ToUpper();

            string TRIM_TBL = vtablesname.Remove(vtablesname.Length - 4);

            string CAPITAL = cCultureInfo.toUpperCase(TRIM_TBL);
            string SMALL = cCultureInfo.toLowerCase(TRIM_TBL);
            string UPPERFIRST = ChangeCase.UpperFirst(SMALL);
            string ___result = "";

            //string xDAL = "DAL";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region[Designer]
            //
            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "        { \r\n";
            ___result += "    public partial class L" + UPPERFIRST + "\r\n";
            ___result += "        {\r\n";
            ___result += "        private System.ComponentModel.IContainer components = null; \r\n";
            ___result += "        \r\n";
            ___result += "        protected override void Dispose(bool disposing) \r\n";
            ___result += "        {\r\n";
            ___result += "            if (disposing && (components != null)) \r\n";
            ___result += "            {\r\n";
            ___result += "            components.Dispose(); \r\n";
            ___result += "            }\r\n";
            ___result += "            base.Dispose(disposing); \r\n";
            ___result += "        }\r\n";
            ___result += "        \r\n";
            //___result += "         #region [InitializeComponent] \r\n";
            ___result += "        \r\n";
            ___result += "        private void InitializeComponent() \r\n";
            ___result += "        {\r\n";
            ___result += "            components = new System.ComponentModel.Container();\r\n";
            ___result += "            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;\r\n";
            ___result += "        } \r\n";
            ___result += "        \r\n";
            //___result += "        #endregion [InitializeComponent] \r\n";
            //
            #endregion[Designer]
            
            #region[result]
            //
            ___result += "    }//cls \r\n";
            ___result += "}//ns \r\n";
            //
            return ___result;
            //
            #endregion[result]

        }
    }//cls
}//ns
