using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SClassitems
    {
        public static void XClassitems(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Classfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\C" + tbl_name + "items.cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {
            List<SFieldsItems> list = obj.SFieldsItems;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            //string TABLENAME = vtablesname.ToUpper();

            string TRIM_TBL = vtablesname.Remove(vtablesname.Length - 4);

            string CAPITAL = cCultureInfo.toUpperCase(TRIM_TBL);
            string SMALL = cCultureInfo.toLowerCase(TRIM_TBL);
            string UPPERFIRST = ChangeCase.UpperFirst(SMALL);
            string ___result = "";

            string xDAL = "DAL";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region [using] 

            ___result += "using System.Collections.Generic;\r\n";
            //___result += "using System.Data;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "\r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public class C" + UPPERFIRST + "items \r\n";
            ___result += "    {\r\n";

            #endregion [namespace]

            #region[Get New]

            ___result += "\r\n";
            ___result += "        #region[Get New]\r\n";
            ___result += "\r\n";
            ___result += "        public static List<" + UPPERFIRST + "items> GetNew\r\n";
            ___result += "        {\r\n";
            ___result += "            get\r\n";
            ___result += "            {\r\n";
            ___result += "            List<" + UPPERFIRST + "items> list = new List<" + UPPERFIRST + "items>();\r\n";
            ___result += "\r\n";
            ___result += "                " + UPPERFIRST + "items obj = new " + UPPERFIRST + "items()\r\n";
            ___result += "                {\r\n";
            ___result += "                    " + UPPERFIRST + "items_id = string.Empty,\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                switch (list[r].Datatype)

                {

                    //case DATATYPES.VARCHAR_500:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.VARCHAR_300:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.VARCHAR_200:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.VARCHAR_100:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.UNIQUE_500:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.INT:
                    //    ___result += "        public int " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.FORIEGN:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;


                    //case DATATYPES.DATE:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.DATETIME:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    //case DATATYPES.ENUM_Y_N:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;
                    //case DATATYPES.SMALLINT:
                    //    ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                    //    break;

                    case DATATYPES.BOOLX:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " =  false,\r\n";
                        break;
                    case DATATYPES.FALSEX:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " =  false,\r\n";
                        break;
                    case DATATYPES.TRUEX:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " =  false,\r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " =  decimal.Zero,\r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " =  decimal.Zero,\r\n";
                        break;

                    case DATATYPES.DOUBLE:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = 0,\r\n";
                        break;


                    default:
                        ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = string.Empty,\r\n";
                        break;

                }
            }
            ___result += "                };\r\n";
            ___result += "                list.Add(obj);\r\n";
            ___result += "                return list;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Get New]\r\n";
            ___result += "\r\n";

            #endregion[Get New]

            #region [Attach params ]    

            ___result += "        #region[Attach params]\r\n";
            ___result += "        \r\n";
            ___result += "        private static string AttachParams(string q, " + UPPERFIRST + "items v)\r\n";
            ___result += "        {\r\n";
            //___result += "            q = q.Replace(\"@\" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_ID + \"@\", \"\" + ConvertTO.SqlString(v." + UPPERFIRST + "items_id) + \"\");\r\n";

            for (int r = 0; r <= list.Count - 1; r++)
            {

                switch (list[r].Datatype)
                {
                    case DATATYPES.DATE:
                        ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \"@\", \"\" + ConvertTO.SqlDate(v." + list[r].Fieldsname.UpperFirst() + ") + \"\");\r\n";
                        break;

                    case DATATYPES.DATETIME:
                        ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \"@\", \"\" + ConvertTO.SqlDateTime(v." + list[r].Fieldsname.UpperFirst() + ") + \"\");\r\n";
                        break;

                    //case DATATYPES.INT:
                    //    sqlstr = "SqlInt";
                    //    break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \"@\", \"\" + ConvertTO.SqlDecimal(v." + list[r].Fieldsname.UpperFirst() + ") + \"\");\r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \"@\", \"\" + ConvertTO.SqlDecimal(v." + list[r].Fieldsname.UpperFirst() + ") + \"\");\r\n";
                        break;

                    default:
                        ___result += "            q = q.Replace(\"@\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \"@\", \"\" + ConvertTO.SqlString(v." + list[r].Fieldsname.UpperFirst() + ") + \"\");\r\n";
                        break;
                }
            }
            ___result += "            return q;\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Attach params]\r\n";
            ___result += "        \r\n";

            #endregion[Attach params ]

            #region [Insert]

            ___result += "        #region[Insert]\r\n";
            ___result += "        \r\n";
            ___result += "        public static void Insert(List<" + UPPERFIRST + "items> list, " + xDAL + " dalsession)\r\n";
            ___result += "        {\r\n";
            ___result += "            for (int i = 0; i < list.Count; i++)\r\n";
            ___result += "            {\r\n";
            ___result += "                " + UPPERFIRST + "items obj = new " + UPPERFIRST + "items()\r\n";
            ___result += "                {\r\n";
            //___result += "                " + UPPERFIRST + "items_id = list[i]." + UPPERFIRST + "items_id,\r\n";

            for (int r = 0; r < list.Count - 1; r++)
            {
                ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = list[i]." + list[r].Fieldsname.UpperFirst() + ",\r\n";
            }
            //remove , from last line
            for (int r = list.Count - 1; r < list.Count; r++)
            {
                ___result += "                    " + list[r].Fieldsname.UpperFirst() + " = list[i]." + list[r].Fieldsname.UpperFirst() + "\r\n";
            }

            ___result += "                };\r\n";
            ___result += "                InsertSub(obj, dalsession);\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Insert]\r\n";
            ___result += "\r\n";

            #endregion [Insert]

            #region [Insert Sub]   

            ___result += "        #region[InsertSub]\r\n";
            ___result += "        \r\n";
            ___result += "        public static void InsertSub(" + UPPERFIRST + "items v, " + xDAL + " dalsession)\r\n";
            ___result += "        {\r\n";
            ___result += "                string q = \" INSERT INTO \" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL + \" ( \";\r\n";

            ___result += "                q += \" \" + " + CAPITAL + "ITEMS." + list[0].Fieldsname.ToUpper() + " + \" \\r\\n \";\r\n";
            for (int r = 1; r < list.Count; r++)
            {
                ___result += "                q += \",\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \" \\r\\n \";\r\n";

            }
            ___result += "                q += \" ) VALUES ( \";\r\n";
            ___result += "                q += \"  @\"+ " + CAPITAL + "ITEMS." + list[0].Fieldsname.ToUpper() + " + \"@ \\r\\n \";\r\n";

            for (int r = 1; r < list.Count; r++)
            {
                ___result += "                q += \", @\"+ " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \"@ \\r\\n \";\r\n";
            }
            ___result += "                q += \" ) \\r\\n \";\r\n";
            ___result += "                q = AttachParams(q, v);\r\n";
            ___result += "                dalsession.Execute(q);\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Insert]\r\n";
            ___result += "        \r\n";

            #endregion [InsertSub] 

            #region[Build delete query]

            ___result += "        #region[Delete]\r\n";
            ___result += "        \r\n";
            ___result += "        public static void Delete(string fkid , " + xDAL + " dalsession)\r\n"; ;
            ___result += "        {\r\n";
            ___result += "                dalsession.Execute(\"DELETE FROM  \" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL+ \" WHERE \" + " + CAPITAL + "ITEMS." + CAPITAL + "_ID + \" =  \" + fkid +\";\");\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Delete]\r\n";
            ___result += "        \r\n";

            #endregion [delete query]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns
