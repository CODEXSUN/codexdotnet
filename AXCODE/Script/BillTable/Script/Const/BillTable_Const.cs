﻿using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public static class BillTable_Const
    {
        public static void Create(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).ToUpper();

            string vpath = CodeIT.NPath + obj.SPath.Contfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\" + tbl_name + ".cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {

            List<SFields> list = obj.SFields;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            string TABLENAME = vtablesname.ToUpper();

            string TRIM_TBL = vtablesname.Remove(vtablesname.Length - 4);

            string CAPITAL = ChangeCase.ToUpper(TRIM_TBL);
            string SMALL = ChangeCase.ToLower(TRIM_TBL);
            string UPPERFIRST = ChangeCase.UpperFirst(SMALL);

            string ___result = "";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + "\r\n";
            ___result += "\r\n";
            #endregion [Conclusion]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";

            #endregion [namespace]

            #region [string Properties]

            ___result += "    #region[Properties]\r\n";
            ___result += "\r\n";
            ___result += "    public class " + UPPERFIRST + "\r\n";
            ___result += "    {\r\n";
            ___result += "        public string " + UPPERFIRST + "_id { get; set; }\r\n";
            ___result += "        public string Uniqueno { get; set; }\r\n";
            ___result += "        public string Company_id { get; set; }\r\n";
            ___result += "        public string Acy_id { get; set; }\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                switch (list[r].Datatype)
                {
                    case DATATYPES.INT:
                        ___result += "        public int " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;
                    case DATATYPES.DECMIAL_2:
                        ___result += "        public decimal " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;
                    case DATATYPES.DECMIAL_3:
                        ___result += "        public decimal " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;
                    default:
                        ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;

                }
            }
            ___result += "        public string Notes { get; set; }\r\n";
            ___result += "        public string Active_id { get; set; }\r\n";
            ___result += "        public string User_id { get; set; }\r\n";
            ___result += "    }\r\n";
            ___result += "\r\n";
            ___result += "    #endregion[Properties]\r\n";
            ___result += "\r\n";

            #endregion [string Properties]

            #region [string Const class]

            ___result += "    #region[string Const class]\r\n";
            ___result += "\r\n";
            ___result += "    public class " + CAPITAL + "\r\n";
            ___result += "    {\r\n";
            ___result += "        public const string " + CAPITAL + "_ID = \"" + CAPITAL + "_ID\";\r\n";
            ___result += "        public const string UNIQUENO = \"UNIQUENO\";\r\n";
            ___result += "        public const string COMPANY_ID = \"COMPANY_ID\";\r\n";
            ___result += "        public const string ACY_ID = \"ACY_ID\";\r\n";
            for (int r = 0; r < list.Count; r++)
            {

                ___result += "        public const string " + list[r].Fieldsname.ToUpper() + " = \"" + list[r].Fieldsname.ToUpper() + "\";\r\n";
            }

            ___result += "        public const string NOTES = \"NOTES\";\r\n";
            ___result += "        public const string ACTIVE_ID = \"ACTIVE_ID\";\r\n";
            ___result += "        public const string USER_ID = \"USER_ID\";\r\n";
            ___result += "\r\n";
            ___result += "        public const string " + TABLENAME.ToUpper() + " = \"" + TABLENAME.ToUpper() + "\";\r\n";
            ___result += "    }\r\n";
            ___result += "\r\n";
            ___result += "    #endregion[string Const class]\r\n";
            ___result += "\r\n";
            ___result += "}//ns\r\n";

            #endregion [string Const class]

            #region [result]

            return ___result;
        }
        #endregion [result]

    }//cls
}//ns

