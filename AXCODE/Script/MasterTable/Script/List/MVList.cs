using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MVList
    {
        public static void XVlist(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\VL" + tbl_name + ".cs", result);
        }

        #region []

        private static string XCreate(MasterDetails obj)
        {
            List<MasterTablesItems> list = obj.Mastertablesitems;

            string vtablesname = obj.Mastertable.Mastertables_name;

            string vnamespaces = obj.Mastertable.Namespaces_id;

            //string TABLENAME = vtablesname.ToUpper();

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

            //___result += "using System; \r\n";
            ___result += "using System.Windows.Forms; \r\n";
            ___result += "using System.Collections.Generic; \r\n";
            //___result += "using System.Data; \r\n";
            ___result += "using CXLIB; \r\n";
            ___result += " \r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + " \r\n";
            ___result += "{ \r\n";
            ___result += "    public partial class L" + UPPERFIRST + "\r\n";
            ___result += "    { \r\n";

            #endregion [namespace]

            #region[list Option]

            ___result += "        #region[list Option] \r\n ";
            ___result += " \r\n ";
            ___result += "        public void ListRefresh() \r\n ";
            ___result += "        { \r\n ";
            ___result += "            List_Option(fAction); \r\n ";
            ___result += "        } \r\n ";
            ___result += "        \r\n ";
            ___result += "        private ListOption fAction = ListOption.active; \r\n ";
            ___result += "        public void List_Option(ListOption action) \r\n ";
            ___result += "        { \r\n ";
            ___result += "            fAction = action; \r\n ";
            ___result += "            \r\n ";
            ___result += "            switch (fAction) \r\n ";
            ___result += "            { \r\n ";
            ___result += "                case ListOption.active: \r\n ";
            ___result += " \r\n ";
            ___result += "                    if (chk_notactive.Checked == true) \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.NotActive()); \r\n ";
            ___result += "                    } \r\n ";
            ___result += "                    else \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Active()); \r\n ";
            ___result += "                    } \r\n ";
            ___result += " \r\n ";
            ___result += "                    break; \r\n ";
            ___result += " \r\n ";
            ___result += "                case ListOption.notactive: \r\n ";
            ___result += " \r\n ";
            ___result += "                    if (chk_notactive.Checked == true) \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.NotActive()); \r\n ";
            ___result += "                    } \r\n ";
            ___result += "                    else \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Active()); \r\n ";
            ___result += "                    } \r\n ";
            ___result += " \r\n ";
            ___result += "                    break; \r\n ";
            ___result += " \r\n ";
            ___result += "                case ListOption.Search: \r\n ";
            ___result += "                    if (txt_" + SMALL + "_name.Text != \"\") \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                    List<" + UPPERFIRST + "> list = new List<" + UPPERFIRST + "> \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                    C" + UPPERFIRST + "_exten.SearchName(txt_" + SMALL + "_name.Text) \r\n ";
            ___result += "                    }; \r\n ";
            ___result += "                    LoadData(list); \r\n ";
            ___result += "                    } \r\n ";
            ___result += "                    else \r\n ";
            ___result += "                    { \r\n ";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Active()); \r\n ";
            ___result += "                    } \r\n ";
            ___result += "                    break; \r\n ";
            ___result += " \r\n ";
            ___result += "                default: \r\n ";
            ___result += "                    LoadData(C" + UPPERFIRST + "_exten.Active()); \r\n ";
            ___result += "                    break; \r\n ";
            ___result += "            } \r\n ";
            ___result += "        } \r\n ";
            ___result += " \r\n ";
            ___result += "        #endregion[list Option] \r\n ";
            ___result += " \r\n ";

            #endregion[list Option]

            #region[Load Data]

            ___result += "        #region[Load Data] \r\n ";
            ___result += " \r\n ";
            ___result += "        public void LoadData(List<" + UPPERFIRST + "> list) \r\n ";
            ___result += "        { \r\n ";
            ___result += "            listgrid.RowCount = 0; \r\n ";
            ___result += "            listgrid.RowCount = list.Count; \r\n ";
            ___result += "            for (int r = 0; r < list.Count; r++) \r\n ";
            ___result += "            { \r\n ";
            ___result += "                DataGridViewRow row = listgrid.Rows[r]; \r\n ";
            ___result += "                \r\n ";
            ___result += "                row.Cells[" + CAPITAL + "." + CAPITAL + "_ID].Value = list[r]." + UPPERFIRST + "_id; \r\n ";

            for (int r = 0; r < list.Count; r++)
            {
                ___result += "                row.Cells[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].Value = list[r]." + list[r].Fieldsname.UpperFirst() + "; \r\n ";
            }
            ___result += "                row.Cells[" + CAPITAL + ".NOTES].Value = list[r].Notes; \r\n ";
            ___result += "                row.Cells[" + CAPITAL + ".ACTIVE_ID].Value = list[r].Active_id; \r\n ";
            ___result += "                row.Cells[" + CAPITAL + ".USER_ID].Value = list[r].User_id; \r\n ";
            ___result += "            } \r\n ";
            ___result += "        } \r\n ";
            ___result += "        \r\n ";
            ___result += "        #endregion[Load Data] \r\n ";

            #endregion[Load Data]

            #region[finally return]

            ___result += "\r\n ";
            ___result += "}//cls \r\n";
            ___result += "}//ns \r\n";
            return ___result;

            #endregion [Finally return]

        }

    }//cls
}//ns

