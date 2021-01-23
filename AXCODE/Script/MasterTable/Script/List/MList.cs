using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MList
    {
        public static void XList(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\L" + tbl_name + ".cs", result);
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

            #region[using]

            ___result += "using System; \r\n";
            ___result += "using System.Drawing; \r\n";
            ___result += "using System.Windows.Forms; \r\n";
            ___result += "using CXLIB; \r\n";
            ___result += " \r\n";

            #endregion[using]

            #region[namespace]

            ___result += "namespace " + vnamespaces + " \r\n";
            ___result += "{ \r\n";
            ___result += "    public partial class L" + UPPERFIRST + "\r\n";
            ___result += "    { \r\n";

            #endregion[namespace]

            #region[Init Grid ]

            ___result += "\r\n";
            ___result += "         #region[Init Grid]\r\n";
            ___result += "\r\n";
            ___result += "         private void InitGrid()\r\n";
            ___result += "         {\r\n";
            ___result += "            listgrid.RowAction += Listgrid_RowAction;\r\n";
            ___result += "\r\n";

            ___result += "            DataGridViewTextBoxColumn col_" + UPPERFIRST + "_Id = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.Name = " + CAPITAL + "." + CAPITAL + "_ID;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.HeaderText = \"" + CAPITAL + "_ID \";\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.Visible = false; \r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.Width = 100;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_" + UPPERFIRST + "_Id );\r\n";
            ___result += "\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                string field = (list[r].Fieldsname.ToLower()).UpperFirst();

                ___result += "            DataGridViewTextBoxColumn col_" + field + " = new DataGridViewTextBoxColumn();\r\n";
                ___result += "            col_" + field + ".Name = " + CAPITAL + "." + list[r].Fieldsname + ";\r\n";
                ___result += "            col_" + field + ".HeaderText = \"" + list[r].Displayname.Replace("_", " ") + "\";\r\n";
                ___result += "            //col_" + field + ".Visible = false; \r\n";
                ___result += "            col_" + field + ".Width = " + Find.TxtLength_Point(list[r].Displayname) + ";\r\n";
                ___result += "            col_" + field + ".DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
                ___result += "            col_" + field + ".AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
                ___result += "            listgrid.Columns.Add(col_" + field + ");\r\n";
                ___result += "\r\n";
            }

            ___result += "            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_Notes.Name = " + CAPITAL + ".NOTES;\r\n";
            ___result += "            col_Notes.HeaderText = \"NOTES\";\r\n";
            ___result += "            col_Notes.Visible = false; \r\n";
            ___result += "            col_Notes.Width = 200;\r\n";
            ___result += "            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_Notes );\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_Active_Id.Name = " + CAPITAL + ".ACTIVE_ID;\r\n";
            ___result += "            col_Active_Id.HeaderText = \"ACTIVE ID\";\r\n";
            ___result += "            col_Active_Id.Visible = false; \r\n";
            ___result += "            col_Active_Id.Width = 200;\r\n";
            ___result += "            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_Active_Id );\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_User_Id.Name = " + CAPITAL + ".USER_ID;\r\n";
            ___result += "            col_User_Id.HeaderText = \"ENTRY BY\";\r\n";
            ___result += "            //col_User_Id.Visible = false; \r\n";
            ___result += "            col_User_Id.Width = 120;\r\n";
            ___result += "            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_User_Id );\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            colFiller.Name = \"FILLER\";\r\n";
            ___result += "            colFiller.HeaderText = \"\";\r\n";
            ___result += "            colFiller.ReadOnly = true;\r\n";
            ___result += "            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;\r\n";
            ___result += "            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;\r\n";
            ___result += "            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;\r\n";
            ___result += "            listgrid.Columns.Add(colFiller);\r\n";
            ___result += "}\r\n";

            ___result += "\r\n";
            ___result += "            #endregion[Init Grid]\r\n";
            ___result += "\r\n";

            #endregion[Init Grid]

            #region[Grid Action] 

            ___result += "         #region[Grid Action]\r\n";
            ___result += "\r\n";
            ___result += "         void Listgrid_RowAction(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             if (listgrid.SelectedRow == null)\r\n";
            ___result += "             {\r\n";
            ___result += "                 return;\r\n";
            ___result += "             }\r\n";
            ___result += "             if (f" + SMALL + " == null)\r\n";
            ___result += "             {\r\n";
            ___result += "                 f" + SMALL + " = new F" + UPPERFIRST + "();\r\n";
            ___result += "             }\r\n";
            ___result += "             BuildForm();\r\n";
            ___result += "             string pkValue = GetSelectedPkValue();\r\n";
            ___result += "             if (pkValue != null)\r\n";
            ___result += "             {\r\n";
            ___result += "                 f" + SMALL + ".SetAction(BtnEvent.Open, pkValue);\r\n";
            ___result += "             }\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Grid Action]\r\n";
            ___result += "\r\n";

            #endregion[Grid Action]

            #region[Enter Event]
            ___result += "         #region[Enter Event]\r\n";
            ___result += "\r\n";
            ___result += "         private void Txt_" + SMALL + "type_Enter(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             Change_infocus();\r\n";
            ___result += "             lbl_" + SMALL + "_name.BackColor = Theme.lbl_EnterBackColor;\r\n";
            ___result += "             lbl_" + SMALL + "_name.BorderColor = Theme.lbl_EnterBorderColor;\r\n";
            ___result += "             lbl_" + SMALL + "_name.ForeColor = Theme.lbl_EnterForeColor;\r\n";
            ___result += "         }\r\n";
            ___result += "         private void Change_infocus()\r\n";
            ___result += "         {\r\n";
            ___result += "             lbl_" + SMALL + "_name.BackColor = Theme.lbl_BackColor;\r\n";
            ___result += "             lbl_" + SMALL + "_name.BorderColor = Theme.lbl_BorderColor;\r\n";
            ___result += "             lbl_" + SMALL + "_name.ForeColor = Theme.lbl_ForeColor;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Enter Event]\r\n";
            ___result += "\r\n";

            #endregion[Enter Event]

            #region[Build Form]

            ___result += "         #region[Build Form]\r\n";
            ___result += "\r\n";
            ___result += "         private void BuildForm()\r\n";
            ___result += "         {\r\n";
            ___result += "             if (f" + SMALL + " == null)\r\n";
            ___result += "             {\r\n";
            ___result += "                 f" + SMALL + " = new F" + UPPERFIRST + "();\r\n";
            ___result += "             }\r\n";
            ___result += "             f" + SMALL + ".F" + UPPERFIRST + "_NeedToRefresh += V" + UPPERFIRST + "_NeedToRefresh;\r\n";
            ___result += "             Parent.Controls.Add(f" + SMALL + ");\r\n";
            ___result += "             f" + SMALL + ".Dock = DockStyle.Fill;\r\n";
            ___result += "             f" + SMALL + ".Show();\r\n";
            ___result += "             f" + SMALL + ".BringToFront();\r\n";
            ___result += "             \r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Build Form]\r\n";
            ___result += "\r\n";

            #endregion[Build Form] 

            #region[Checkbox Event]

            ___result += "         #region[Checkbox Event] \r\n";
            ___result += "\r\n";
            ___result += "                private void Chk_notactive_CheckedChanged(object sender, EventArgs e) \r\n";
            ___result += "                { \r\n";
            ___result += "                    List_Option(ListOption.notactive); \r\n";
            ___result += "                } \r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Checkbox Event] \r\n";
            ___result += "\r\n";
            #endregion[Checkbox Event]

            #region[Btn Event]


            ___result += "         #region[Btn Event] \r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_refresh_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            List_Option(ListOption.active);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_new_Click(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            BuildForm(); \r\n";
            ___result += "                f" + SMALL + ".SetAction(BtnEvent.New, null); \r\n";
            ___result += "                f" + SMALL + ".SetFocus(); \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_edit_Click(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            BuildForm(); \r\n";
            ___result += "            string pkValue = GetSelectedPkValue(); \r\n";
            ___result += "            if (pkValue != null) \r\n";
            ___result += "            { \r\n";
            ___result += "                f" + SMALL + ".SetAction(BtnEvent.Edit, pkValue); \r\n";
            ___result += "                f" + SMALL + ".SetFocus(); \r\n";
            ___result += "            } \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_delete_Click(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            BuildForm(); \r\n";
            ___result += "            string pkValue = GetSelectedPkValue(); \r\n";
            ___result += "            if (pkValue != null) \r\n";
            ___result += "            { \r\n";
            ___result += "                f" + SMALL + ".SetAction(BtnEvent.Delete, pkValue); \r\n";
            ___result += "                f" + SMALL + ".SetFocus(); \r\n";
            ___result += "            } \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_print_Click(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            BuildForm(); \r\n";
            ___result += "            string pkValue = GetSelectedPkValue(); \r\n";
            ___result += "            if (pkValue != null) \r\n";
            ___result += "            { \r\n";
            ___result += "                f" + SMALL + ".SetAction(BtnEvent.Print, pkValue); \r\n";
            ___result += "                f" + SMALL + ".SetFocus(); \r\n";
            ___result += "            } \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_close_Click(object sender, EventArgs e) \r\n";
            ___result += "        { \r\n";
            ___result += "            Hide(); \r\n";
            ___result += "            RaiseEvent_NeedToRefresh(); \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_search_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            List_Option(ListOption.Search);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Btn Event] \r\n";
            ___result += "\r\n";

            #endregion[Btn Event]

            #region[lookup]

            ___result += "         #region[lookup] \r\n";
            ___result += "\r\n";
            ___result += "         public void " + UPPERFIRST + "_lookup()\r\n";
            ___result += "         {\r\n";
            ___result += "             txt_" + list[0].Fieldsname.ToLower() + ".LookupColNames = new string[] { " + CAPITAL + "." + list[0].Fieldsname.ToUpper() + " };\r\n";
            ___result += "             txt_" + list[0].Fieldsname.ToLower() + ".LookupUpdate += txt_" + SMALL + "_LookupUpdate;\r\n";
            ___result += "             txt_" + list[0].Fieldsname.ToLower() + ".AllowNewEntry = true;\r\n";
            ___result += "             txt_" + list[0].Fieldsname.ToLower() + ".NewEntryNeeded += txt_" + SMALL + "_NewEntryNeeded;\r\n";
            ___result += "         }\r\n";
            ___result += "         void txt_" + SMALL + "_LookupUpdate(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             txt_" + list[0].Fieldsname.ToLower() + ".LookupList = C" + UPPERFIRST + "_exten.GetforLookup();\r\n";
            ___result += "         }\r\n";
            ___result += "         private F" + UPPERFIRST + " fs" + SMALL + " = null;\r\n";
            ___result += "         void txt_" + SMALL + "_NewEntryNeeded(object sender, string pValue)\r\n";
            ___result += "         {\r\n";
            ___result += "             if (fs" + SMALL + " == null)\r\n";
            ___result += "             {\r\n";
            ___result += "                 fs" + SMALL + " = new F" + UPPERFIRST + "();\r\n";
            ___result += "             }\r\n";
            ___result += "             Parent.Controls.Add(fs" + SMALL + ");\r\n";
            ___result += "             fs" + SMALL + ".Dock = DockStyle.Fill;\r\n";
            ___result += "             fs" + SMALL + ".Show();\r\n";
            ___result += "             fs" + SMALL + ".BringToFront();\r\n";
            ___result += "             fs" + SMALL + ".Focus();\r\n";
            ___result += "             \r\n";
            ___result += "             fs" + SMALL + ".SetAction(BtnEvent.New, null);\r\n";
            ___result += "             fs" + SMALL + ".SetFocus();\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[lookup] \r\n";
            ___result += "\r\n";

            #endregion[" + CAMELCASE + " lookup]

            #region[Get selected pk value]

            ___result += "         #region[Get selected pk value]\r\n";
            ___result += "\r\n";
            ___result += "         private string GetSelectedPkValue()\r\n";
            ___result += "         {\r\n";
            ___result += "             DataGridViewRow vSelRow = null;\r\n";
            ___result += "             if (listgrid.SelectedRows != null && listgrid.SelectedRows.Count != 0)\r\n";
            ___result += "             {\r\n";
            ___result += "                 vSelRow = listgrid.SelectedRows[0];\r\n";
            ___result += "             }\r\n";
            ___result += "             \r\n";
            ___result += "             string selPkValue = null;\r\n";
            ___result += "             if (vSelRow != null)\r\n";
            ___result += "             {\r\n";
            ___result += "                 selPkValue = vSelRow.Cells[" + CAPITAL + "." + CAPITAL + "_ID].Value.ToString();\r\n";
            ___result += "             }\r\n";
            ___result += "             return selPkValue;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Get selected pk value]\r\n";
            ___result += "\r\n";

            #endregion[Get selected pk value]

            #region[RaiseEvent]

            ___result += "        #region[RaiseEvent]\r\n";
            ___result += "\r\n";
            ___result += "        void V" + UPPERFIRST + "_NeedToRefresh(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            List_Option(ListOption.active);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            //___result += "        public event EventHandler L" + UPPERFIRST + "_NeedToRefresh;\r\n";
            //___result += "\r\n";
            //___result += "        public void RaiseEvent_NeedToRefresh()\r\n";
            //___result += "        {\r\n";
            //___result += "            L" + UPPERFIRST + "_NeedToRefresh?.Invoke(this, new EventArgs());\r\n";
            //___result += "        }\r\n";
            //___result += "\r\n";
            ___result += "        #endregion[RaiseEvent]\r\n";

            #endregion[RaiseEvent]

            #region[finally return]

            ___result += "\r\n";
            ___result += "}//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;

            #endregion[Finally return]

        }

    }//cls
}//ns

