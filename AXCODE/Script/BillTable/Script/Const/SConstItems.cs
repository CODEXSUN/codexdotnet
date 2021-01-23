using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SConstItems
    {
        public static void XConstItems(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).ToUpper();

            string vpath = CodeIT.NPath + obj.SPath.Contfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\" + tbl_name + "ITEMS.cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {

            List<SFieldsItems> list = obj.SFieldsItems;

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
            ___result += "    public class " + UPPERFIRST + "items\r\n";
            ___result += "    {\r\n";
            ___result += "        public string " + UPPERFIRST + "items_id { get; set; }\r\n";

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
                        ___result += "        public bool " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;
                    case DATATYPES.FALSEX:
                        ___result += "        public bool " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;
                    case DATATYPES.TRUEX:
                        ___result += "        public bool " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "        public decimal " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "        public decimal " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;

                    case DATATYPES.DOUBLE:
                        ___result += "        public double " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;


                    default:
                        ___result += "        public string " + ChangeCase.UpperFirst(list[r].Fieldsname.ToLower()) + " { get; set; }\r\n";
                        break;

                }
            }
            ___result += "    }\r\n";
            ___result += "\r\n";
            ___result += "    #endregion[Properties]\r\n";
            ___result += "\r\n";

            #endregion [string Properties]

            #region [string Const class]

            ___result += "    #region[string Const class]\r\n";
            ___result += "\r\n";
            ___result += "    public class " + CAPITAL + "ITEMS\r\n";
            ___result += "    {\r\n";
            ___result += "        public const string " + CAPITAL + "ITEMS_ID = \"" + CAPITAL + "ITEMS_ID\";\r\n";


            for (int r = 0; r < list.Count; r++)
            {

                ___result += "        public const string " + list[r].Fieldsname.ToUpper() + " = \"" + list[r].Fieldsname.ToUpper() + "\";\r\n";
            }

            ___result += "\r\n";
            ___result += "        public const string " + CAPITAL + "ITEMS_TBL = \"" + CAPITAL + "ITEMS_TBL\";\r\n";
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

