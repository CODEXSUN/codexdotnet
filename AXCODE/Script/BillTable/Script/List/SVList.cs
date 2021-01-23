using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SVList
    {
        public static void XVlist(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\VL" + tbl_name + ".cs", result);
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

            #region [using]

            //___result += "using System;\r\n";
            ___result += "using System.Windows.Forms;\r\n";
            ___result += "using System.Collections.Generic;\r\n";
            ___result += "using System.Drawing;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "\r\n";

            #endregion [using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public partial class L" + UPPERFIRST + "\r\n";
            ___result += "    {\r\n";

            #endregion [namespace]

            #region[list Option]

            ___result += "        #region[list Option]\r\n";
            ___result += "\r\n";
            ___result += "        public void ListRefresh()\r\n";
            ___result += "        {\r\n";
            ___result += "            List_Option(fAction);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private ListOption fAction = ListOption.active;\r\n";
            ___result += "        public void List_Option(ListOption pAction)\r\n";
            ___result += "        {\r\n";
            ___result += "            fAction = pAction;\r\n";
            ___result += "           \r\n";
            ___result += "            switch (fAction)\r\n";
            ___result += "            {\r\n";

            ___result += "                case ListOption.refer:\r\n";
            ___result += "\r\n";
            ___result += "                    if (rdo_refer.Checked == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Refer());\r\n";
            ___result += "                    }\r\n";
            ___result += "                    else\r\n";
            ___result += "                    {\r\n";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Unrefer());\r\n";
            ___result += "                    }\r\n";
            ___result += "\r\n";
            ___result += "                    break;\r\n";
            ___result += "\r\n";

            ___result += "                case ListOption.showall:\r\n";
            ___result += "\r\n";
            ___result += "                    if (rdo_showall.Checked == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Showall());\r\n";
            ___result += "                    }\r\n";
            ___result += "                    else\r\n";
            ___result += "                    {\r\n";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Unrefer());\r\n";
            ___result += "                    }\r\n";
            ___result += "\r\n";
            ___result += "                    break;\r\n";
            ___result += "\r\n";
            ___result += "                case ListOption.notactive:\r\n";
            ___result += "\r\n";
            ___result += "                    if (rdo_notactive.Checked == true)\r\n";
            ___result += "                    {\r\n";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Notactive());\r\n";
            ___result += "                    }\r\n";
            ___result += "                    else\r\n";
            ___result += "                    {\r\n";
            ___result += "                        LoadData(C" + UPPERFIRST + "_exten.Unrefer());\r\n";
            ___result += "                    }\r\n";
            ___result += "\r\n";
            ___result += "                    break;\r\n";
            ___result += "\r\n";
            ___result += "                case ListOption.Search:\r\n";
            ___result += "                    LoadData(C" + UPPERFIRST + "_exten.Searchby(txt_no.Text, txt_date.Text,  txt_Todate.Text, txt_party.Text ));\r\n";
            ___result += "                    break;\r\n";
            ___result += "\r\n";
            ___result += "                default:\r\n";
            ___result += "                     LoadData(C" + UPPERFIRST + "_exten.Unrefer());\r\n";
            ___result += "                    break;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[list Option]\r\n";
            ___result += "\r\n";

            #endregion[list Option]

            #region[Load Data]

            ___result += "        #region[Load Data]\r\n";
            ___result += "\r\n";
            ___result += "        public void LoadData(List<" + UPPERFIRST + "> list)\r\n";
            ___result += "        {\r\n";
            ___result += "        if (constructed_flag == false)\r\n";
            ___result += "        {\r\n";
            ___result += "        return;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        listgrid.SuspendLayout();\r\n";
            ___result += "\r\n";
            ___result += "            listgrid.RowCount = 0;\r\n";
            ___result += "            listgrid.RowCount = list.Count;\r\n";
            ___result += "            for (int r = 0; r < list.Count; r++)\r\n";
            ___result += "            {\r\n";
            ___result += "                DataGridViewRow row = listgrid.Rows[r];\r\n";
            ___result += "               \r\n";
            ___result += "                row.Cells[" + CAPITAL + "." + CAPITAL + "_ID].Value = list[r]." + UPPERFIRST + "_id;\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Inputtype == InputControls.DATEBOX)
                    {
                        ___result += "                row.Cells[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].Value = ConvertTO.Date2S(list[r]." + list[r].Fieldsname.UpperFirst() + ");\r\n";
                    }
                    else if (list[r].Inputtype == InputControls.DATETIMEBOX)
                    {
                        ___result += "                row.Cells[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].Value = ConvertTO.DateTime12S(list[r]." + list[r].Fieldsname.UpperFirst() + ");\r\n";
                    }
                    else
                    {
                        ___result += "                row.Cells[" + CAPITAL + "." + list[r].Fieldsname.ToUpper() + "].Value = list[r]." + list[r].Fieldsname.UpperFirst() + ";\r\n";
                    }
                }
            }
            //___result += "                row.Cells[" + CAPITAL + ".NOTES].Value = list[r].Notes;\r\n";
            //___result += "                row.Cells[" + CAPITAL + ".ACTIVE_ID].Value = list[r].Active_id;\r\n";
            ___result += "                row.Cells[" + CAPITAL + ".USER_ID].Value = list[r].User_id;\r\n";
            ___result += "\r\n";
            ___result += "                switch (list[r].Locked)\r\n";
            ___result += "                {\r\n";
            ___result += "                    case Core.Locked:\r\n";
            ___result += "                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(0, 152, 70);\r\n";
            ___result += "                        row.Cells[GRID.CELL].Style.ForeColor = Color.White;\r\n";
            ___result += "                        row.Cells[GRID.CELL].Value = Core.Txt_Locked;\r\n";
            ___result += "                        break;\r\n";
            ___result += "                    case Core.Partial:\r\n";
            ___result += "                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(255, 237, 0);\r\n";
            ___result += "                        row.Cells[GRID.CELL].Style.ForeColor = Color.FromArgb(0, 141, 210);\r\n";
            ___result += "                        row.Cells[GRID.CELL].Value = Core.Txt_Partial;\r\n";
            ___result += "\r\n";
            ___result += "                        break;\r\n";
            ___result += "                    default:\r\n";
            ___result += "                        row.Cells[GRID.CELL].Style.BackColor = Color.FromArgb(227, 30, 36);\r\n";
            ___result += "                        row.Cells[GRID.CELL].Style.ForeColor = Color.White;\r\n";
            ___result += "                        row.Cells[GRID.CELL].Value = Core.Txt_Unlocked;\r\n";
            ___result += "                        break;\r\n";
            ___result += "                }\r\n";
            ___result += "\r\n";
            ___result += "                listgrid.Refresh();\r\n";
            ___result += "                if (listgrid.RowCount != 0)\r\n";
            ___result += "                {\r\n";
            ___result += "                    listgrid.CurrentCell = listgrid[" + CAPITAL + ".PARTY_ID, listgrid.RowCount - 1];\r\n";
            ___result += "                }\r\n";
            ___result += "                }\r\n";
            ___result += "                listgrid.ResumeLayout(true);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Load Data]\r\n";
            ___result += "\r\n";
            #endregion[Load Data]

            #region[finally return]

            ___result += "\r\n";
            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;

            #endregion [Finally return]

        }

    }//cls
}//ns

