﻿using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MClass
    {
        public static void XClass(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Classfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\C" + tbl_name + ".cs", result);
        }

        #region []
        //
        private static string XCreate(MasterDetails obj)
        {
            List<MasterTablesItems> list = obj.Mastertablesitems;

            string vtablesname = obj.Mastertable.Mastertables_name;

            string vnamespaces = obj.Mastertable.Namespaces_id;

            string TABLENAME = vtablesname.ToUpper();

            string TRIM_TBL = vtablesname.Remove(vtablesname.Length - 4);

            string CAPITAL = ChangeCase.ToUpper(TRIM_TBL);
            string SMALL = ChangeCase.ToLower(TRIM_TBL);
            string UPPERFIRST = ChangeCase.UpperFirst(SMALL);

            string ___result = "";

            string xDAL = "DAL";

            //
            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region [using] 

            //___result += "using System.Collections.Generic;\r\n";
            //___result += "using System.Data;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "\r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public static class C" + UPPERFIRST + "\r\n";
            ___result += "    {\r\n";

            #endregion [namespace]

            #region[Get New]

            ___result += "\r\n";
            ___result += "        #region[Get New]\r\n";
            ___result += "\r\n";
            ___result += "        public static " + UPPERFIRST + " GetNew\r\n";
            ___result += "        {\r\n";
            ___result += "            get\r\n";
            ___result += "            {\r\n";
            ___result += "                " + UPPERFIRST + " obj = new " + UPPERFIRST + "()\r\n";
            ___result += "                {\r\n";
            ___result += "                    " + UPPERFIRST + "_id = string.Empty,\r\n";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                switch (list[r].Datatype)
                {
                    case DATATYPES.INT:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = 0,\r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = decimal.Zero,\r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = decimal.Zero,\r\n";
                        break;

                    default:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = string.Empty,\r\n";
                        break;
                }
            }

            ___result += "                    Notes = string.Empty,\r\n";
            ___result += "                    Active_id = Core.Active,\r\n";
            ___result += "                    User_id = Current.User\r\n";
            ___result += "                };\r\n";
            ___result += "                return obj;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Get New]\r\n";
            ___result += "\r\n";

            #endregion[Get New]

            #region [Attach params ]    

            ___result += "        #region[Attach params]\r\n";
            ___result += "\r\n";
            ___result += "        private static string AttachParams(string q, " + UPPERFIRST + " v)\r\n";
            ___result += "        {\r\n";
            ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "." + CAPITAL + "_ID + \"@\", \"\" + ConvertTO.SqlString(v." + UPPERFIRST + "_id) + \"\");\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                string sqlstr = "";

                switch (list[r].Datatype)
                {
                    case DATATYPES.DATE:
                        sqlstr = "SqlDate";
                        break;

                    case DATATYPES.DATETIME:
                        sqlstr = "SqlDateTime";
                        break;

                    case DATATYPES.INT:
                        sqlstr = "SqlInt";
                        break;

                    case DATATYPES.DECMIAL_2:
                        sqlstr = "SqlDecimal";
                        break;

                    case DATATYPES.DECMIAL_3:
                        sqlstr = "SqlDecimal";
                        break;

                    default:
                        sqlstr = "SqlString";
                        break;
                }

                ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \"@\", \"\" + ConvertTO." + sqlstr + "(v." + list[r].Fieldsname.UpperFirst() + ") + \"\");\r\n";
            }
            ___result += "            q = q.Replace(\"@\" + " + CAPITAL + ".NOTES + \"@\", \"\" + ConvertTO.SqlString(v.Notes) + \"\");\r\n";
            ___result += "            q = q.Replace(\"@\" + " + CAPITAL + ".ACTIVE_ID + \"@\", \"\" + ConvertTO.SqlString(v.Active_id) + \"\");\r\n";
            ___result += "            q = q.Replace(\"@\" + " + CAPITAL + ".USER_ID + \"@\", \"\" + ConvertTO.SqlString(v.User_id) + \"\");\r\n";
            ___result += "            return q;\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Attach params]\r\n";
            ___result += "\r\n";

            #endregion[Attach params ]

            #region [Insert Query]   

            ___result += "        #region[Insert]\r\n";
            ___result += "\r\n";
            ___result += "        public static void Insert(" + UPPERFIRST + " v, " + xDAL + " dalsession)\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = \" INSERT INTO \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" ( \";\r\n";
            ___result += "            q += \" \" + " + CAPITAL + "." + list[0].Fieldsname.ToUpper() + " + \" \\r\\n \";\r\n";

            for (int r = 1; r < list.Count; r++)
            {
                ___result += "            q += \",\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" \\r\\n \";\r\n";

            }
            ___result += "            q += \",\" + " + CAPITAL + ".NOTES + \" \\r\\n \";\r\n";
            ___result += "            q += \",\" + " + CAPITAL + ".ACTIVE_ID + \" \\r\\n \";\r\n";
            ___result += "            q += \",\" + " + CAPITAL + ".USER_ID + \" \\r\\n \";\r\n";
            ___result += "            q += \" ) VALUES ( \";\r\n";
            ___result += "            q += \"  @\" + " + CAPITAL + "." + list[0].Fieldsname.ToUpper() + " + \"@ \\r\\n \";\r\n";

            for (int r = 1; r < list.Count; r++)
            {
                ___result += "                q += \", @\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \"@ \\r\\n \";\r\n";
            }

            ___result += "            q += \", @\" + " + CAPITAL + ".NOTES + \"@ \\r\\n \";\r\n";
            ___result += "            q += \", @\" + " + CAPITAL + ".ACTIVE_ID + \"@ \\r\\n \";\r\n";
            ___result += "            q += \", @\" + " + CAPITAL + ".USER_ID + \"@ \\r\\n \";\r\n";
            ___result += "            q += \" ) \\r\\n \";\r\n";
            ___result += "            q = AttachParams(q, v);\r\n";
            ___result += "            dalsession.Execute(q);\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Insert]\r\n";
            ___result += "\r\n";

            #endregion [Insert Query] 

            #region [Update query]

            ___result += "        #region[Update]\r\n";
            ___result += "\r\n";
            ___result += "        public static void Update(" + UPPERFIRST + " v, " + xDAL + " dalsession)\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = \"UPDATE \" + " + CAPITAL + "." + TABLENAME + " + \" SET\";\r\n";

            ___result += "            q += " + "\" \" + " + CAPITAL + "." + list[0].Fieldsname.ToUpper() + " + \" = @\" + " + CAPITAL + "." + list[0].Fieldsname.ToUpper() + " + \"@ \\r\\n \";\r\n";

            for (int r = 1; r < list.Count; r++)
            {
                ___result += "            q += " + "\",\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = @\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \"@ \\r\\n \";\r\n";
            }

            ___result += "            q += " + "\",\" + " + CAPITAL + ".NOTES + \" = @\" + " + CAPITAL + ".NOTES + \"@ \\r\\n \";\r\n";
            ___result += "            q += " + "\",\" + " + CAPITAL + ".ACTIVE_ID + \" = @\" + " + CAPITAL + ".ACTIVE_ID + \"@ \\r\\n \";\r\n";
            ___result += "            q += " + "\",\" + " + CAPITAL + ".USER_ID + \" = @\" + " + CAPITAL + ".USER_ID + \"@ \\r\\n \";\r\n";
            ___result += "            q += \"  WHERE \" + " + CAPITAL + "." + CAPITAL + "_ID + \" = @\" + " + CAPITAL + "." + CAPITAL + "_ID + \"@ \";\r\n";
            ___result += "            q = AttachParams(q, v);\r\n";
            ___result += "            dalsession.Execute(q);\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Update]\r\n";
            ___result += "\r\n";

            #endregion [Update query]

            #region[Build delete query]

            ___result += "        #region[Delete]\r\n";
            ___result += "\r\n";
            ___result += "        public static void Delete(string pkid, " + xDAL + " dalsession)\r\n"; ;
            ___result += "        {\r\n";
            ___result += "            dalsession.Execute(\"DELETE FROM  \" + " + CAPITAL + "." + TABLENAME + " + \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_ID + \" =  \" + pkid + \";\");\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Delete]\r\n";
            ___result += "\r\n";

            #endregion [delete query]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns
