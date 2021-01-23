using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SClassitems_exten
    {
        public static void XClassitems_exten(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Classfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\C" + tbl_name + "items_exten.cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {
            List<SFieldsItems> list = obj.SFieldsItems;

            string vtablesname = obj.STables.Stables_name;

            string vnamespaces = obj.STables.Namespaces_id;

            string TABLENAME = vtablesname.ToUpper();

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

            ___result += "using System.Data;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "using CXCORE;\r\n";
            ___result += "using System.Collections.Generic;\r\n";
            ___result += "\r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public class C" + UPPERFIRST + "items_exten\r\n";
            ___result += "    {\r\n";

            #endregion [namespace]

            #region[Entity List]
            ___result += "         #region[Entity List] \r\n";
            ___result += "  \r\n";
            ___result += "         private static List<" + UPPERFIRST + "items> EntityList(string q) \r\n";
            ___result += "         { \r\n";
            ___result += "             List<" + UPPERFIRST + "items> list = new List<" + UPPERFIRST + "items>(); \r\n";
            ___result += "  \r\n";
            ___result += "             using (IDataReader redr = new " + xDAL + "().Listreader(q)) \r\n";
            ___result += "             { \r\n";
            ___result += "                 while (redr.Read() == true) \r\n";
            ___result += "                 { \r\n";
            ___result += "                      " + UPPERFIRST + "items  obj = new  " + UPPERFIRST + "items () \r\n";
            ___result += "                     { \r\n";
            ___result += "                        " + UPPERFIRST + "items_id = redr[" + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_ID].ToString(), \r\n";

            for (int r = 0; r <= list.Count - 1; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if (list[r].Fieldsname.UpperFirst() == UPPERFIRST + "_id")
                    {
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + "].ToString(),\r\n";
                    }
                    else
                    {
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NO") + "].ToString(),\r\n";
                    }
                }
                else
                {
                    ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = redr[" + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + "].ToString(),\r\n";
                }


            }

            ___result += "                     }; \r\n";
            ___result += "  \r\n";
            ___result += "                     list.Add(obj); \r\n";
            ___result += "                 } \r\n";
            ___result += "  \r\n";
            ___result += "             } \r\n";
            ___result += "             return list; \r\n";
            ___result += "         } \r\n";
            ___result += "  \r\n";
            ___result += "         #endregion[Entity List] \r\n";
            ___result += "  \r\n";

            #endregion[Entity List]

            #region[FKId]

            ___result += "         #region[FKId] \r\n";
            ___result += "  \r\n";
            ___result += "         public static List<" + UPPERFIRST + "items> FKId(string id ) \r\n";
            ___result += "         { \r\n";

            ___result += "            string q = \" SELECT \" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL +\".* \\r\\n\"; \r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    if ((list[r].Fieldsname.ToUpper()) == CAPITAL + "_ID")
                    {
                        ___result += "            q += \", \"+ " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL");
                        ___result += " + \".\"+ " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NO") + " + \" \\r\\n\"; \r\n";
                    }
                    else
                    {
                        ___result += "            q += \", \"+ " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL");
                        ___result += " + \".\"+ " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_NO") + " + \" \\r\\n\"; \r\n";
                    }
                }
            }

            ___result += "            q += \" FROM  \" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL + \" \\r\\n\"; \r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Datatype == DATATYPES.FORIEGN)
                {
                    ___result += "            q += \" INNER JOIN  \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \"\\r\\n\";  \r\n";
                    ___result += "            q += \" ON(\" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL + \".\" + " + CAPITAL + "ITEMS." + list[r].Fieldsname.ToUpper() + " + \" = \" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + (list[r].Fieldsname.ToUpper()).Replace("_ID", "_TBL") + " + \".\" + " + (list[r].Fieldsname.ToUpper()).Replace("_ID", "") + "." + list[r].Fieldsname.ToUpper() + "+\" )\\r\\n\";  \r\n";
                }
            }
            ___result += "            q += \" WHERE \" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL + \".\" + " + CAPITAL + "." + CAPITAL + "_ID + \"  = '\" + id + \"' \\r\\n\"; \r\n";
            ___result += "            q += \" ORDER BY  \" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_TBL + \".\" + " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_ID + \";\\r\\n\"; \r\n";
            ___result += "  \r\n";
            ___result += "             return EntityList(q); \r\n";
            ___result += "         } \r\n";
            ___result += "  \r\n";
            ___result += "         #endregion[FKId] \r\n";
            ___result += "  \r\n";

            #endregion[FKId]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns

