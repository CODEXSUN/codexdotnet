using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SClass_exten
    {
        public static void XClass_exten(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Classfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\C" + tbl_name + "_exten.cs", result);
        }

        #region []
        //
        private static string XCreate(BillTable obj)
        {
            List<SFields> list = obj.SFields;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            //string TABLENAME = vtablesname.ToUpper();

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

            ___result += "using System;\r\n";
            ___result += "using System.Data;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "using CXCORE;\r\n";
            ___result += "using System.Collections.Generic;\r\n";
            ___result += "\r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public class C" + UPPERFIRST + "_exten\r\n";
            ___result += "    {\r\n";

            #endregion [namespace]

            #region[Entity Data]

            ___result += "         #region[Entity Data]\r\n";
            ___result += "\r\n";
            ___result += "        private static " + UPPERFIRST + " EntityData(string q)\r\n";
            ___result += "        {\r\n";
            ___result += "            using (IDataReader redr = new " + xDAL + "().Listreader(q))\r\n";
            ___result += "            {\r\n";
            ___result += "                 while (redr.Read() == true)\r\n";
            ___result += "                 {\r\n";
            ___result += "                    " + UPPERFIRST + " obj = new " + UPPERFIRST + "()\r\n";
            ___result += "                    {\r\n";
            ___result += "                        " + UPPERFIRST + "_id = redr[" + CAPITAL + "." + CAPITAL + "_ID].ToString(),\r\n";
            ___result += "                        Uniqueno = redr[" + CAPITAL + ".UNIQUENO].ToString(),\r\n";
            ___result += "                        Company_id = redr[" + CAPITAL + ".COMPANY_ID].ToString(),\r\n";
            ___result += "                        Acy_id = redr[" + CAPITAL + ".ACY_ID].ToString(),\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                switch (list[r].Datatype)
                {

                    case DATATYPES.FORIEGN:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + "].ToString(),\r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = ConvertTO.Decimal(redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString()),\r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = ConvertTO.Decimal(redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString()),\r\n";
                        break;


                    default:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString(),\r\n";
                        break;
                }

            }

            ___result += "                        Notes = redr[" + CAPITAL + ".NOTES].ToString(),\r\n";
            ___result += "                        Active_id = redr[" + CAPITAL + ".ACTIVE_ID].ToString(),\r\n";
            ___result += "                        User_id = redr[USER.USER_NAME].ToString()\r\n";
            ___result += "                        };\r\n";
            ___result += "                    return obj;\r\n";
            ___result += "                 }\r\n";
            ___result += "            redr.Close();\r\n";
            ___result += "            return new " + UPPERFIRST + "();\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Entity Data]\r\n";
            ___result += "\r\n";

            #endregion[Entity Data]

            #region[Entity List]

            ___result += "         #region[Entity List]\r\n";
            ___result += "\r\n";
            ___result += "         private static List<" + UPPERFIRST + "> EntityList(string q)\r\n";
            ___result += "         {\r\n";
            ___result += "             List<" + UPPERFIRST + "> list = new List<" + UPPERFIRST + ">();\r\n";
            ___result += "\r\n";
            ___result += "             using (IDataReader redr = new " + xDAL + "().Listreader(q))\r\n";
            ___result += "             {\r\n";
            ___result += "                 while (redr.Read() == true)\r\n";
            ___result += "                 {\r\n";
            ___result += "                      " + UPPERFIRST + " obj = new " + UPPERFIRST + "()\r\n";
            ___result += "                     {\r\n";
            ___result += "                        " + UPPERFIRST + "_id = redr[" + CAPITAL + "." + CAPITAL + "_ID].ToString(),\r\n";
            ___result += "                        Uniqueno = redr[" + CAPITAL + ".UNIQUENO].ToString(),\r\n";
            ___result += "                        Company_id = redr[" + CAPITAL + ".COMPANY_ID].ToString(),\r\n";
            ___result += "                        Acy_id = redr[" + CAPITAL + ".ACY_ID].ToString(),\r\n";
            for (int r = 0; r < list.Count; r++)
            {
                switch (list[r].Datatype)
                {

                    case DATATYPES.FORIEGN:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + "].ToString(),\r\n";
                        break;

                    case DATATYPES.DECMIAL_2:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = ConvertTO.Decimal(redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString()),\r\n";
                        break;

                    case DATATYPES.DECMIAL_3:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = ConvertTO.Decimal(redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString()),\r\n";
                        break;


                    default:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString(),\r\n";
                        break;
                }
            }
            ___result += "                        Notes = redr[" + CAPITAL + ".NOTES].ToString(),\r\n";
            ___result += "                        Active_id = redr[" + CAPITAL + ".ACTIVE_ID].ToString(),\r\n";
            ___result += "                        User_id = redr[USER.USER_NAME].ToString()\r\n";
            ___result += "                     };\r\n";
            ___result += "\r\n";
            ___result += "                     list.Add(obj);\r\n";
            ___result += "                 }\r\n";
            ___result += "\r\n";
            ___result += "             redr.Close();\r\n";
            ___result += "             }\r\n";
            ___result += "             return list;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Entity List]\r\n";
            ___result += "\r\n";

            #endregion[Entity List]

            #region[Unrefer]

            ___result += "         #region[Unrefer]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> Unrefer()\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY
                    {
                        ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                            + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                    }
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY  
                    {
                        ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";\r\n";
                        ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \" )\\r\\n\";\r\n";
                    }
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".LOCKED + \" = '\" + Core.Unlocked + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Unrefer]\r\n";
            ___result += "\r\n";

            #endregion[Unrefer]

            #region[refer]

            ___result += "         #region[refer]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> Refer()\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY
                    {
                        ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                            + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                    }
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY  
                    {
                        ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";\r\n";
                        ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \" )\\r\\n\";\r\n";
                    }
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".LOCKED + \" = '\" + Core.Unlocked + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[refer]\r\n";
            ___result += "\r\n";
            #endregion[refer]

            #region[showall]

            ___result += "         #region[showall]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> Showall()\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY
                    {
                        ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                            + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                    }
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY  
                    {
                        ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";\r\n";
                        ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \" )\\r\\n\";\r\n";
                    }
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[showall]\r\n";
            ___result += "\r\n";
            #endregion[showall]

            #region[not active]

            ___result += "         #region[not active]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> Notactive()\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY
                    {
                        ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                            + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                    }
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY  
                    {
                        ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";\r\n";
                        ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \" )\\r\\n\";\r\n";
                    }
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.NotActive + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[not active]\r\n";
            ___result += "\r\n";
            #endregion[not active]

            #region[PKId]

            ___result += "         #region[PKId]\r\n";
            ___result += "\r\n";
            ___result += "         public static " + UPPERFIRST + " PKId(string id)\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY
                    {
                        ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                            + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                    }
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY  
                    {
                        ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";\r\n";
                        ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \" )\\r\\n\";\r\n";
                    }
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + id + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityData(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[PKId]\r\n";
            ___result += "\r\n";

            #endregion[PKId]

            #region[Searchby]

            ___result += "         #region[Searchby]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> Searchby(string no, string date, string dateTo, string party)\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY
                    {
                        ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                            + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                    }
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.ToUpper() != "COMPANY_ID") // OMIT COMPANY  
                    {
                        ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";\r\n";
                        ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \" )\\r\\n\";\r\n";
                    }
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";

            ___result += "            if (no != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \" = '\" + no + \"'\\r\\n\";\r\n";
            ___result += "            }\r\n";
            ___result += "            if (dateTo != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_DATE + \"  BETWEEN \" + ConvertTO.SqlDate(date) + \" AND \" + ConvertTO.SqlDate(dateTo) + \"\\r\\n\";\r\n";
            ___result += "            }\r\n";
            ___result += "            else if (date != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "\r\n";
            ___result += "                q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_DATE + \" = \" + ConvertTO.SqlDate(date) + \"\\r\\n\";\r\n";
            ___result += "            }\r\n";
            ___result += "            if (party != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                q += \" AND \" + PARTY.PARTY_TBL + \".\" + PARTY.PARTY_NAME + \" = '\" + party + \"'  \\r\\n\";\r\n";
            ___result += "            }\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Searchby]\r\n";
            ___result += "\r\n";

            #endregion[Searchby]

            #region[GetforLookup]

            ___result += "         #region[GetforLookup]\r\n";
            ___result += "\r\n";
            ___result += "        public static DataTable LookupNo()\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = \" SELECT  DISTINCT \\r\\n\";\r\n";
            ___result += "            q += \" \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "            return new DAL().Listdata(q);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        public static DataTable LookupParty()\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = \" SELECT  DISTINCT \\r\\n\";\r\n";
            ___result += "            q += \" \" + PARTY.PARTY_TBL + \".\" + PARTY.PARTY_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";
            ___result += "            q += \" INNER JOIN  \" + PARTY.PARTY_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".PARTY_ID + \" = \" + PARTY.PARTY_TBL + \".\" + PARTY.PARTY_ID + \" )\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "            return new DAL().Listdata(q);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        public static DataTable LookupDate()\r\n";
            ___result += "        {\r\n";
            ___result += "            string q = \" SELECT  DISTINCT \\r\\n\";\r\n";
            ___result += "            q += \" \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_DATE + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" AND \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".COMPANY_ID + \" = '\" + Current.Company_id + \"'  \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NO + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "            DataTable xtbl = new DAL().Listdata(q);\r\n";
            ___result += "\r\n";
            ___result += "            DataTable tbl = new DataTable();\r\n";
            ___result += "\r\n";
            ___result += "            tbl.Columns.Add(" + CAPITAL + "." + CAPITAL + "_DATE, typeof(string));\r\n";
            ___result += "            if (xtbl.Rows.Count != 0)\r\n";
            ___result += "            {\r\n";
            ___result += "                for (int i = 0; i < xtbl.Rows.Count; i++)\r\n";
            ___result += "                {\r\n";
            ___result += "                    tbl.Rows.Add(ConvertTO.Date2S(xtbl.Rows[i][" + CAPITAL + "." + CAPITAL + "_DATE] + \"\")\r\n";
            ___result += "                    );\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "            return tbl;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[GetforLookup]\r\n";
            ___result += "\r\n";

            #endregion[GetforLookup]

            #region[GetNext_No]

            ___result += "        #region[GetNext_No]\r\n";
            ___result += "\r\n";
            ___result += "        public static string GetNext_No\r\n";
            ___result += "        {\r\n";
            ___result += "            get\r\n";
            ___result += "            {\r\n";
            ___result += "                string q = \"SELECT \" + " + CAPITAL + "." + CAPITAL + "_NO + \" FROM \" + " + CAPITAL + "." + CAPITAL + "_TBL + \"\\r\\n\";\r\n";
            ___result += "                q += \" WHERE \" + " + CAPITAL + ".COMPANY_ID + \" = \" + Current.Company_id + \" \\r\\n\";\r\n";
            ___result += "                q += \" ORDER BY \" + " + CAPITAL + "." + CAPITAL + "_NO + \" DESC LIMIT 1;\\r\\n\";\r\n";
            ___result += "                using (IDataReader redr = new DAL().Listreader(q))\r\n";
            ___result += "                {\r\n";
            ___result += "                    while (redr.Read() == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        return ((Convert.ToInt32(redr[" + CAPITAL + "." + CAPITAL + "_NO].ToString())) + 1).ToString();\r\n";
            ___result += "                    }\r\n";
            ___result += "                     redr.Close();\r\n";
            ___result += "                    return Core.One;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[GetNext_No]\r\n";
            ___result += "\r\n";

            #endregion[GetforLookup]

            #region[Lock Status]

            ___result += "        #region[Lock Status]\r\n";
            ___result += "\r\n";
            ___result += "        public static bool LockStatus(string pkValue)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (pkValue != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                " + UPPERFIRST + " obj = PKId(pkValue);\r\n";
            ___result += "                if (obj.Locked == Core.Unlocked)\r\n";
            ___result += "                {\r\n";
            ___result += "                    return false;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "            return true;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Lock Status]\r\n";
            ___result += "\r\n";

            #endregion[Lock Status]

            #region[Get id - FieldsName]

            ___result += "        #region[Get id - FieldsName]\r\n";
            ___result += "\r\n ";
            ___result += "        public static string GetName_Id(string _pId)\r\n";
            ___result += "        {\r\n";
            ___result += "            " + UPPERFIRST + " obj = PKId(_pId);\r\n";
            ___result += "\r\n ";
            ___result += "            if (obj != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                return obj." + UPPERFIRST + "_no;\r\n";
            ___result += "            }\r\n";
            ___result += "            return \"\";\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n ";
            ___result += "        public static string GetId_Name(string _pName)\r\n";
            ___result += "        {\r\n";
            ___result += "            var list = Searchby(\"\",\"\",\"\",_pName);\r\n";
            ___result += "\r\n ";
            ___result += "            if (list.Count != 0)\r\n";
            ___result += "            {\r\n";
            ___result += "                return list[0]." + UPPERFIRST + "_id;\r\n";
            ___result += "            }\r\n";
            ___result += "            return \"\";\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n ";
            ___result += "        #endregion[Get id - FieldsName]\r\n";
            ___result += "\r\n";
            #endregion[Get id - FieldsName]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns

