using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MasterUpdate
    {
        public static void Create(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Setupfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\U_" + tbl_name + ".cs", result);
        }

        #region []

        private static string XCreate(MasterDetails obj)
        {
            List<MasterTablesItems> list = obj.Mastertablesitems;

            string vtablesname = obj.Mastertable.Mastertables_name;

            string vnamespaces = obj.Mastertable.Namespaces_id;

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

            #region [using] 

            ___result += "using System; \r\n";
            ___result += "using System.Data; \r\n";
            ___result += "using CXLIB; \r\n";
            ___result += "using CXCORE; \r\n";

            ___result += "\r\n";
            #endregion[using]

            #region[Update]

            ___result += "namespace AXCODE\r\n";
            ___result += "{\r\n";
            ___result += "    public static class U_" + UPPERFIRST + "\r\n";
            ___result += "    {\r\n";
            ___result += "        #region[]\r\n";
            ___result += "\r\n";
            ___result += "            public static void GetUpdated(string OldDB)\r\n";
            ___result += "            {\r\n";
            ___result += "\r\n";
            ___result += "                string tablename = " + CAPITAL + "." + CAPITAL + "_TBL;\r\n";
            ___result += "\r\n";
            ___result += "                int count = GetCount(tablename, OldDB);\r\n";
            ___result += "\r\n";
            ___result += "                for (int i = 1; i <= count; i++)\r\n";
            ___result += "                {\r\n";
            ___result += "                    var obj = GetOldData(i, OldDB);\r\n";
            ___result += "\r\n";
            ___result += "                if (obj != null)\r\n";
            ___result += "                {\r\n";
            ___result += "                    InsertData(obj);\r\n";
            ___result += "                }\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[]\r\n";
            ___result += "\r\n";
            ___result += "        #region[Get Count]\r\n";
            ___result += "\r\n";
            ___result += "            private static int GetCount(string tablename, string OldDB)\r\n";
            ___result += "            {\r\n";
            ___result += "                string ID = (tablename.Remove((tablename).Length - 4).ToUpper()) + \"_ID\";\r\n";
            ___result += "\r\n";
            ___result += "                string q = \"USE \" + OldDB + \"; \";\r\n";
            ___result += "                q += \"SELECT * FROM \" + tablename + \" ORDER BY \" + ID + \" DESC LIMIT 1 ; \";\r\n";
            ___result += "\r\n";
            ___result += "                using (IDataReader redr = new DAL().Listreader(q))\r\n";
            ___result += "                {\r\n";
            ___result += "                    while (redr.Read() == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        int lastId = Convert.ToInt32(redr[ID]);\r\n";
            ___result += "\r\n";
            ___result += "                        return lastId;\r\n";
            ___result += "                    }\r\n";
            ___result += "                    return 0;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Get Count]\r\n";
            ___result += "\r\n";
            ___result += "        #region[Get Old data]\r\n";
            ___result += "\r\n";
            ___result += "            private static " + UPPERFIRST + " GetOldData(int id, string OldDB)\r\n";
            ___result += "            {\r\n";
            ___result += "                string q = \"USE \" + OldDB + \"; \";\r\n";
            ___result += "                q += \"SELECT * FROM \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_ID + \" = '\" + id + \"'; \";\r\n";
            ___result += "\r\n";
            ___result += "                using (IDataReader redr = new DAL().Listreader(q))\r\n";
            ___result += "                {\r\n";
            ___result += "                    while (redr.Read() == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        " + UPPERFIRST + " obj = new " + UPPERFIRST + "\r\n";
            ___result += "                        {\r\n";

            for (int r = 0; r <= list.Count - 1; r++)
            {

                switch (list[r].Datatype)
                {
                    case DATATYPES.INT:
                        ___result += "                        " + list[r].Fieldsname.UpperFirst() + " = ConvertTO.Integer(redr[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].ToString()),\r\n";
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
            ___result += "                        User_id = \"1\"\r\n";

            ___result += "                        };\r\n";
            ___result += "\r\n";
            ___result += "                        return obj;\r\n";
            ___result += "                    }\r\n";
            ___result += "                    return null;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Get Old data]\r\n";
            ___result += "\r\n";

            ___result += "#region[Check data]\r\n";
            ___result += "\r\n";
            ___result += "            private static bool CheckData(" + UPPERFIRST + " obj)\r\n";
            ___result += "            {\r\n";
            ___result += "                string q = \"USE CODEXSUN_DB; \";\r\n";
            ___result += "                q += \"SELECT * FROM \" + " + CAPITAL + "." + CAPITAL + "_TBL + \" WHERE \" + " + CAPITAL + "." + CAPITAL + "_NAME + \" = '\" + obj." + UPPERFIRST + "_name + \"'; \";\r\n";
            ___result += "\r\n";
            ___result += "                using (IDataReader redr = new DAL().Listreader(q))\r\n";
            ___result += "                {\r\n";
            ___result += "                    while (redr.Read() == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        obj." + UPPERFIRST + "_id = redr[" + CAPITAL + "." + CAPITAL + "_ID].ToString();\r\n";
            ___result += "\r\n";
            ___result += "                        C" + UPPERFIRST + ".Update(obj, new DAL());\r\n";
            ___result += "\r\n";
            ___result += "                        return true;\r\n";
            ___result += "                    }\r\n";
            ___result += "                    return false;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "            #endregion[Check data]\r\n";
            ___result += "\r\n";
            ___result += "        #region[Insert data]\r\n";
            ___result += "\r\n";
            ___result += "            private static void InsertData(" + UPPERFIRST + " obj)\r\n";
            ___result += "            {\r\n";
            ___result += "                if (CheckData(obj) == false)\r\n";
            ___result += "                {\r\n";
            ___result += "                    C" + UPPERFIRST + ".Insert(obj, new DAL());\r\n";
            ___result += "                };\r\n";
            ___result += "\r\n";
            ___result += "            }\r\n";
            ___result += "        #endregion[Insert data]\r\n";
            ___result += "\r\n";

            #endregion[Default Values]

            #region[result]
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;
            #endregion[result]
        }
    }//cls
}//ns
