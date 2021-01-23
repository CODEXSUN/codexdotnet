using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MClass_exten
    {
        public static void XClass_exten(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Classfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\C" + tbl_name + "_exten.cs", result);
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

            ___result += "using System.Data;\r\n";
            ___result += "using CXLIB;\r\n";
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

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + "].ToString(),\r\n";
                }
                else
                {
                    ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString(),\r\n";
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
            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + "].ToString(),\r\n";
                }
                else
                {
                    ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString(),\r\n";
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

            #region[Active]

            ___result += "         #region[Active]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> Active()\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                        + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                }
            }

            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \" \\r\\n\";\r\n";
                    ___result += "            q += \" ON( \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper();
                    ___result += " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + "+ \".\" +" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \")\\r\\n\";\r\n";
                }
            }

            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            //q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NAME + \";\\r\\n\";\r\n";
            ___result += "\r\n";

            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Active]\r\n";
            ___result += "\r\n";
            #endregion[Active]

            #region[Not Active]

            ___result += "         #region[NotActive]\r\n";
            ___result += "\r\n";
            ___result += "         public static List<" + UPPERFIRST + "> NotActive()\r\n";
            ___result += "         {\r\n";
            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                        + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                }
            }
            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \" \\r\\n\";\r\n";
                    ___result += "            q += \" ON( \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper();
                    ___result += " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + "+ \".\" +" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \")\\r\\n\";\r\n";
                }
            }

            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.NotActive + \"' \\r\\n\";\r\n";
            ___result += "            //q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NAME + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityList(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[NotActive]\r\n";
            ___result += "\r\n";

            #endregion[Check Box]

            #region[Primary Key]

            ___result += "         #region[Primary Key]\r\n";
            ___result += "\r\n";
            ___result += "         public static " + UPPERFIRST + " PKId(string v)\r\n";
            ___result += "         {\r\n";
            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                        + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                }
            }
            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \" \\r\\n\";\r\n";
                    ___result += "            q += \" ON( \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper();
                    ___result += " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + "+ \".\" +" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \")\\r\\n\";\r\n";
                }
            }

            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \"  = '\" + v + \"' \\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityData(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Primary Key]\r\n";
            ___result += "\r\n";

            #endregion[Primary Key] 

            #region[Search by name]

            ___result += "         #region[Search by name]\r\n";
            ___result += "\r\n";
            ___result += "         public static " + UPPERFIRST + " SearchName(string v)\r\n";
            ___result += "         {\r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                        + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                }
            }
            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \" \\r\\n\";\r\n";
                    ___result += "            q += \" ON( \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper();
                    ___result += " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + "+ \".\" +" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \")\\r\\n\";\r\n";
                }
            }

            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NAME + \"  = '\" + v + \"' \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NAME + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return EntityData(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Search by name]\r\n";
            ___result += "\r\n";

            #endregion[Search by name]

            #region[Look up]

            ___result += "         #region[Look up]\r\n";
            ___result += "\r\n";
            ___result += "         public static DataTable GetforLookup()\r\n";
            ___result += "         {\r\n";
            ___result += "            string q = \" SELECT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".* \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \", \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL")

                        + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NAME") + " + \" \\r\\n\";\r\n";
                }
            }
            ___result += "            q += \", \" + USER.USER_TBL + \".\" + USER.USER_NAME + \" \\r\\n\";\r\n";
            ___result += "            q += \" FROM  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" \\r\\n\";\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \" \\r\\n\";\r\n";
                    ___result += "            q += \" ON( \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper();
                    ___result += " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + "+ \".\" +" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + " + \")\\r\\n\";\r\n";
                }
            }
            ___result += "            q += \" INNER JOIN  \" + USER.USER_TBL + \"\\r\\n\";\r\n";
            ___result += "            q += \" ON(\" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + USER.USER_ID + \"  = \" + USER.USER_TBL + \".\" + USER.USER_ID + \")\\r\\n\";\r\n";
            ___result += "            q += \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + ".ACTIVE_ID + \"  = '\" + Core.Active + \"' \\r\\n\";\r\n";
            ___result += "            //q += \" AND NOT \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + Core.One + \"' \\r\\n\";\r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "." + CAPITAL + "_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_NAME + \";\\r\\n\";\r\n";
            ___result += "\r\n";
            ___result += "             return new " + xDAL + "().Listdata(q);\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Look up]\r\n";
            ___result += "\r\n";

            #endregion[Look up]

            #region[Get id - Name]

            ___result += "        #region[Get id - Name]\r\n";
            ___result += "\r\n ";
            ___result += "        public static string GetName_Id(string v)\r\n";
            ___result += "        {\r\n";
            ___result += "            " + UPPERFIRST + " obj = PKId(v);\r\n";
            ___result += "\r\n ";
            ___result += "            if (obj != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                return obj." + UPPERFIRST + "_name;\r\n";
            ___result += "            }\r\n";
            ___result += "            return \"\";\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n ";
            ___result += "        public static string GetId_Name(string v)\r\n";
            ___result += "        {\r\n";
            ___result += "            " + UPPERFIRST + " obj = SearchName(v);\r\n";
            ___result += "\r\n ";
            ___result += "            if (obj != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                return obj." + UPPERFIRST + "_id;\r\n";
            ___result += "            }\r\n";
            ___result += "            return \"\";\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n ";
            ___result += "        #endregion[Get id - Name]\r\n";
            ___result += "\r\n";
            #endregion[Get id - Name]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns

