using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SList
    {
        public static void XList(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\L" + tbl_name + ".cs", result);
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

            #region[using]

            ___result += "using System;\r\n";
            //___result += "using System.Drawing;\r\n";
            ___result += "using System.Windows.Forms;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "using CXCORE;\r\n";
            ___result += "\r\n";

            #endregion[using]

            #region[namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public partial class L" + UPPERFIRST + " : CxControl\r\n";
            ___result += "    {\r\n";

            #endregion[namespace]

            #region[Grid Action] 

            ___result += "            #region[Grid Action]\r\n";
            ___result += "\r\n";
            ___result += "            void Listgrid_RowAction(object sender, EventArgs e)\r\n";
            ___result += "            {\r\n";
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
            ___result += "\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Build Form]\r\n";
            ___result += "\r\n";

            #endregion[Build Form] 

            #region[Radio btn event]

            ___result += "       #region[Radio btn event]\r\n";
            ___result += "\r\n";
            ___result += "       private void Rdo_unrefer_CheckedChanged(object sender, EventArgs e)\r\n";
            ___result += "       {\r\n";
            ___result += "            if (rdo_unrefer.Checked == true)\r\n";
            ___result += "            {\r\n";
            ___result += "                List_Option(ListOption.unrefer);\r\n";
            ___result += "            }\r\n";
            ___result += "       }\r\n";
            ___result += "\r\n";
            ___result += "       private void Rdo_refer_CheckedChanged(object sender, EventArgs e)\r\n";
            ___result += "       {\r\n";
            ___result += "            if (rdo_refer.Checked == true)\r\n";
            ___result += "            {\r\n";
            ___result += "                List_Option(ListOption.refer);\r\n";
            ___result += "            }\r\n";
            ___result += "       }\r\n";
            ___result += "\r\n";
            ___result += "       private void Rdo_showall_CheckedChanged(object sender, EventArgs e)\r\n";
            ___result += "       {\r\n";
            ___result += "            if (rdo_showall.Checked == true)\r\n";
            ___result += "            {\r\n";
            ___result += "                List_Option(ListOption.showall);\r\n";
            ___result += "            }\r\n";
            ___result += "       }\r\n";
            ___result += "\r\n";
            ___result += "       private void Rdo_notactive_CheckedChanged(object sender, EventArgs e)\r\n";
            ___result += "       {\r\n";
            ___result += "            if (rdo_notactive.Checked == true)\r\n";
            ___result += "            {\r\n";
            ___result += "                List_Option(ListOption.notactive);\r\n";
            ___result += "            }\r\n";
            ___result += "       }\r\n";
            ___result += "\r\n";
            ___result += "       #endregion[Radio btn event]\r\n";
            ___result += "\r\n";
            #endregion[Radio btn event]

            #region[Btn Event]

            ___result += "         #region[Btn Event]\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_refresh_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            List_Option(ListOption.active);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_new_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            BuildForm();\r\n";
            ___result += "                f" + SMALL + ".SetAction(BtnEvent.New, null);\r\n";
            ___result += "                f" + SMALL + ".SetFocus();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_edit_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            string pkValue = GetSelectedPkValue();\r\n";
            //___result += "            if (CPo_exten.LockStatus(pkValue) == false)\r\n";
            //___result += "            {\r\n";
            ___result += "                BuildForm();\r\n";
            ___result += "                if (pkValue != null)\r\n";
            ___result += "                {\r\n";
            ___result += "                    f" + SMALL + ".SetAction(BtnEvent.Edit, pkValue);\r\n";
            ___result += "                    f" + SMALL + ".SetFocus();\r\n";
            ___result += "                }\r\n";
            //___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_delete_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            string pkValue = GetSelectedPkValue();\r\n";
            //___result += "            if (CPo_exten.LockStatus(pkValue) == false)\r\n";
            //___result += "            {\r\n";
            ___result += "                BuildForm();\r\n";
            ___result += "                if (pkValue != null)\r\n";
            ___result += "                {\r\n";
            ___result += "                    f" + SMALL + ".SetAction(BtnEvent.Delete, pkValue);\r\n";
            ___result += "                    f" + SMALL + ".SetFocus();\r\n";
            ___result += "                }\r\n";
            //___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_print_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            BuildForm();\r\n";
            ___result += "            string pkValue = GetSelectedPkValue();\r\n";
            ___result += "            if (pkValue != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                f" + SMALL + ".SetAction(BtnEvent.Print, pkValue);\r\n";
            ___result += "                f" + SMALL + ".SetFocus();\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_close_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            Hide();\r\n";
            ___result += "            RaiseEvent_NeedToRefresh();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_search_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            List_Option(ListOption.Search);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Btn Event]\r\n";
            ___result += "\r\n";

            #endregion[Btn Event]

            #region[text change event]

            ___result += "         #region[text change event]\r\n";
            ___result += "\r\n";
            ___result += "        private void Txt_datePicker_TextChanged(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            txt_date.Text = txt_datePicker.Text;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Txt_TodatePicker_TextChanged(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            txt_Todate.Text = txt_TodatePicker.Text;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[text change event]\r\n";
            ___result += "\r\n";

            #endregion[text change event]

            #region[Enter Event]
            ___result += "         #region[Enter Event]\r\n";
            ___result += "\r\n";
            ___result += "         private void Txt_no_Enter(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             Change_infocus();\r\n";
            ___result += "             lbl_no.BackColor = XTheme.lbl_EnterBackColor;\r\n";
            ___result += "             lbl_no.BorderColor = XTheme.lbl_EnterBorderColor;\r\n";
            ___result += "             lbl_no.ForeColor = XTheme.lbl_EnterForeColor;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         private void Txt_date_Enter(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             lbl_date.BackColor = XTheme.lbl_EnterBackColor;\r\n";
            ___result += "             lbl_date.BorderColor = XTheme.lbl_EnterBorderColor;\r\n";
            ___result += "             lbl_date.ForeColor = XTheme.lbl_EnterForeColor;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         private void Txt_party_Enter(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             lbl_party.BackColor = XTheme.lbl_EnterBackColor;\r\n";
            ___result += "             lbl_party.BorderColor = XTheme.lbl_EnterBorderColor;\r\n";
            ___result += "             lbl_party.ForeColor = XTheme.lbl_EnterForeColor;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         private void Change_infocus()\r\n";
            ___result += "         {\r\n";
            ___result += "\r\n";
            ___result += "             lbl_no.BackColor = XTheme.lbl_BackColor;\r\n";
            ___result += "             lbl_no.BorderColor = XTheme.lbl_BorderColor;\r\n";
            ___result += "             lbl_no.ForeColor = XTheme.lbl_ForeColor;\r\n";
            ___result += "\r\n";
            ___result += "             lbl_date.BackColor = XTheme.lbl_BackColor;\r\n";
            ___result += "             lbl_date.BorderColor = XTheme.lbl_BorderColor;\r\n";
            ___result += "             lbl_date.ForeColor = XTheme.lbl_ForeColor;\r\n";
            ___result += "\r\n";
            ___result += "             lbl_party.BackColor = XTheme.lbl_BackColor;\r\n";
            ___result += "             lbl_party.BorderColor = XTheme.lbl_BorderColor;\r\n";
            ___result += "             lbl_party.ForeColor = XTheme.lbl_ForeColor;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Enter Event]\r\n";
            ___result += "\r\n";

            #endregion[Enter Event]

            #region[lookup]

            ___result += "         #region[No lookup]\r\n";
            ___result += "\r\n";
            ___result += "         public void No_lookup()\r\n";
            ___result += "         {\r\n";
            ___result += "             txt_no.LookupColNames = new string[] { " + CAPITAL + "." + CAPITAL + "_NO };\r\n";
            ___result += "             txt_no.LookupUpdate += Txt_no_LookupUpdate;\r\n";
            ___result += "         }\r\n";
            ___result += "         void Txt_no_LookupUpdate(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             txt_no.LookupList = C" + UPPERFIRST + "_exten.LookupNo();\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[No lookup]\r\n";
            ___result += "\r\n";
            ___result += "         #region[Party lookup]\r\n";
            ___result += "\r\n";
            ___result += "         public void Party_lookup()\r\n";
            ___result += "         {\r\n";
            ___result += "             txt_party.LookupColNames = new string[] { PARTY.PARTY_NAME };\r\n";
            ___result += "             txt_party.LookupUpdate += Txt_party_LookupUpdate;\r\n";
            ___result += "         }\r\n";
            ___result += "         void Txt_party_LookupUpdate(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             txt_party.LookupList = CParty_exten.GetforLookup(new DAL());\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[Party lookup]\r\n";
            ___result += "\r\n";

            #endregion[lookup]

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
            ___result += "\r\n";
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

            ___result += "         #region[RaiseEvent]\r\n";
            ___result += "\r\n";
            ___result += "         void V" + UPPERFIRST + "_NeedToRefresh(object sender, EventArgs e)\r\n";
            ___result += "         {\r\n";
            ___result += "             List_Option(ListOption.active);\r\n";
            ___result += "         }\r\n";

            //___result += "         public event EventHandler L" + UPPERFIRST + "_NeedToRefresh;\r\n";
            //___result += "         public void RaiseEvent_NeedToRefresh()\r\n";
            //___result += "         {\r\n";
            //___result += "             L" + UPPERFIRST + "_NeedToRefresh?.Invoke(this, new EventArgs());\r\n";
            //___result += "         }\r\n";
            ___result += "\r\n";
            ___result += "         #endregion[RaiseEvent]\r\n";
            ___result += "\r\n";

            #endregion[RaiseEvent]

            #region[finally return]

            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";
            return ___result;

            #endregion[Finally return]

        }

    }//cls
}//ns

