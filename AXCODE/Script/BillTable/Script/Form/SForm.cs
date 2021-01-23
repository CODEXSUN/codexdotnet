using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SForm
    {
        public static void XForm(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Formfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\F" + tbl_name + ".cs", result);
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

            string xDAL = "DAL";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region[using ]

            ___result += "using System;\r\n";
            ___result += "using System.Windows.Forms;\r\n";
            ___result += "using System.Drawing;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "using CXCORE;\r\n";
            ___result += "\r\n";
            ___result += "\r\n";

            #endregion[using ]

            #region[namespace ]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{ \r\n";
            ___result += "    public partial class F" + UPPERFIRST + " : UserControl \r\n";
            ___result += "    { \r\n";
            ___result += "\r\n";

            #endregion[namespace ]

            #region[Split Timer]

            ___result += "        #region[Split Timer]\r\n";
            ___result += "\r\n";
            ___result += "        private bool expand;\r\n";
            ___result += "\r\n";
            ___result += "        private void SplitTimer_Tick(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (expand)\r\n";
            ___result += "            {\r\n";
            ___result += "                if (split_container.SplitterDistance < Convert.ToInt32(ClientSize.Width) - 29)\r\n";
            ___result += "                {\r\n";
            ___result += "                    split_container.SplitterDistance += 50;\r\n";
            ___result += "                }\r\n";
            ___result += "                else\r\n";
            ___result += "                {\r\n";
            ___result += "                    btn_splitter.Text = \"⁞⁞\";\r\n";
            ___result += "                    expand = false;\r\n";
            ___result += "                    splitTimer.Stop();\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "            else\r\n";
            ___result += "            {\r\n";
            ___result += "                if (split_container.SplitterDistance > Convert.ToInt32(ClientSize.Width) - 150)\r\n";
            ___result += "                {\r\n";
            ___result += "                    split_container.SplitterDistance += -50;\r\n";
            ___result += "                }\r\n";
            ___result += "                else\r\n";
            ___result += "                {\r\n";
            ___result += "                    btn_splitter.Text = \">>\";\r\n";
            ___result += "                    expand = true;\r\n";
            ___result += "                    splitTimer.Stop();\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "        private void Btn_splitter_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            splitTimer.Enabled = true;\r\n";
            ___result += "        }\r\n";
            ___result += "        private void Btn_close_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            Hide();\r\n";
            ___result += "            Form_NeedToRefresh();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Split Timer]\r\n";
            ___result += "\r\n";

            #endregion [btn Split Timer]

            #region[Enter Event]

            ___result += "        #region[Enter Event]\r\n";
            ___result += "\r\n";
            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {

                    ___result += "        private void Txt_" + list[r].Fieldsname.ToLower() + "_Enter(object sender, EventArgs e)\r\n";
                    ___result += "        {\r\n";
                    ___result += "            Change_infocus();\r\n";
                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".BackColor = Theme.lbl_EnterBackColor;\r\n";
                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".BorderColor = Theme.lbl_EnterBorderColor;\r\n";
                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".ForeColor = Theme.lbl_EnterForeColor;\r\n";
                    ___result += "        }\r\n";
                }
            }
            ___result += "        private void Txt_notes_Enter(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            Change_infocus();\r\n";
            ___result += "            lbl_notes.BackColor = Theme.lbl_EnterBackColor;\r\n";
            ___result += "            lbl_notes.BorderColor = Theme.lbl_EnterBorderColor;\r\n";
            ___result += "            lbl_notes.ForeColor = Theme.lbl_EnterForeColor;\r\n";
            ___result += "        }\r\n";
            ___result += "        private void Change_infocus()\r\n";
            ___result += "        {\r\n";
            ___result += "            \r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".BackColor = Theme.lbl_BackColor;\r\n";
                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".BorderColor = Theme.lbl_BorderColor;\r\n";
                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".ForeColor = Theme.lbl_ForeColor;\r\n";
                    ___result += "            \r\n";
                }
            }

            ___result += "            lbl_notes.BackColor = Theme.lbl_BackColor;\r\n";
            ___result += "            lbl_notes.BorderColor = Theme.lbl_BorderColor;\r\n";
            ___result += "            lbl_notes.ForeColor = Theme.lbl_ForeColor;\r\n";
            ___result += "            \r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Enter Event]\r\n";
            ___result += "\r\n";

            #endregion[Enter Event]

            #region[btn Event ]

            ___result += "        #region[Btn Event ]\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_active_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            ToggleActive();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_save_click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            Save_Event();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_list_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            splitTimer.Enabled = true;\r\n";
            ___result += "            this.Hide();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_new_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            splitTimer.Enabled = true;\r\n";
            ___result += "            SetAction(BtnEvent.New, null);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_edit_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (vId != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                splitTimer.Enabled = true;\r\n";
            ___result += "                SetAction(BtnEvent.Edit, vId);\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_delete_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (vId != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                splitTimer.Enabled = true;\r\n";
            ___result += "                SetAction(BtnEvent.Delete, vId);\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Btn_print_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            if (vId != \"\")\r\n";
            ___result += "            {\r\n";
            ___result += "                splitTimer.Enabled = true;\r\n";
            ___result += "                SetAction(BtnEvent.Print, vId);\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Btn Event ]\r\n";
            ___result += "\r\n";

            #endregion[btn Event ]

            #region[Lbl Event]

            ___result += "        #region[Lbl Event ]\r\n";
            ___result += "\r\n";
            ___result += "        private void Lbl_notes_Click(object sender, EventArgs e)\r\n";
            ___result += "        {\r\n";
            ___result += "            txt_notes.Refresh();\r\n";
            ___result += "            if (txt_notes.Height == 600)\r\n";
            ___result += "            {\r\n";
            ___result += "                txt_notes.BackColor = Color.White;\r\n";
            ___result += "                txt_notes.Width = Theme.F_txt_notes_width - 100;\r\n";
            ___result += "                txt_notes.Height = Theme.F_txt_notes_height;\r\n";
            ___result += "                txt_notes.Location = new Point(Theme.txt_left, Theme.Fpanel_height - 75);\r\n";
            ___result += "            }\r\n";
            ___result += "            else if (txt_notes.Height == Theme.F_txt_notes_height)\r\n";
            ___result += "            {\r\n";
            ___result += "                txt_notes.Location = new Point(lbl_notes.Right - 1, 137);\r\n";
            ___result += "                txt_notes.Width = 1170;\r\n";
            ___result += "                txt_notes.Height = 600;\r\n";
            ___result += "                txt_notes.BackColor = Color.FromArgb(255, 255, 192);\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Lbl Event ]\r\n";
            ___result += "\r\n";

            #endregion[Lbl Event]

            #region [Active Event]

            ___result += "        #region[Active Event ]\r\n";
            ___result += "\r\n";
            ___result += "        private void ToggleActive()\r\n";
            ___result += "        {\r\n";
            ___result += "            if (btn_active.Text != Core.ACTIVE_TXT)\r\n";
            ___result += "            {\r\n";
            ___result += "                btn_active.Themes = Themescheme.Green;\r\n";
            ___result += "                btn_active.Text = Core.ACTIVE_TXT;\r\n";
            ___result += "                Core.Stative = Core.Active;\r\n";
            ___result += "            }\r\n";
            ___result += "            else\r\n";
            ___result += "            {\r\n";
            ___result += "                btn_active.Themes = Themescheme.RED;\r\n";
            ___result += "                btn_active.Text = Core.NOTACTIVE_TXT;\r\n";
            ___result += "                Core.Stative = Core.NotActive;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        private void Setactives()\r\n";
            ___result += "        {\r\n";
            ___result += "            if (Core.Stative == Core.Active)\r\n";
            ___result += "            {\r\n";
            ___result += "                btn_active.Themes = Themescheme.Green;\r\n";
            ___result += "                btn_active.Text = Core.ACTIVE_TXT;\r\n";
            ___result += "                btn_save.Focus();\r\n";
            ___result += "                this.Refresh();\r\n";
            ___result += "            }\r\n";
            ___result += "            else if (Core.Stative == Core.NotActive)\r\n";
            ___result += "            {\r\n";
            ___result += "                btn_active.Themes = Themescheme.RED;\r\n";
            ___result += "                btn_active.Text = Core.NOTACTIVE_TXT;\r\n";
            ___result += "                this.Refresh();\r\n";
            ___result += "            }\r\n";
            ___result += "            else if (Core.Stative == Core.Idle)\r\n";
            ___result += "            {\r\n";
            ___result += "                btn_active.Themes = Themescheme.WHITE;\r\n";
            ___result += "                btn_active.Text = Core.IDLE_TXT;\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Active Event ]\r\n";
            ___result += "\r\n";

            #endregion [Active Event]

            #region [RaiseEvent]

            ___result += "        #region[Raise Event ]\r\n";
            ___result += "\r\n";
            ___result += "        public event EventHandler F" + UPPERFIRST + "_NeedToRefresh;\r\n";
            ___result += "\r\n";
            ___result += "        public void Form_NeedToRefresh()\r\n";
            ___result += "        {\r\n";
            ___result += "            if (F" + UPPERFIRST + "_NeedToRefresh != null)\r\n";
            ___result += "            {\r\n";
            ___result += "                F" + UPPERFIRST + "_NeedToRefresh(this, new EventArgs());\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "        #endregion[Raise Event ]\r\n";
            ___result += "\r\n";

            #endregion [RaiseEvent]

            #region[Lookup]

            for (int r = 0; r < list.Count; r++)
            {
                if ((list[r].Inputtype == InputControls.LOOKUPBOX) || (list[r].Inputtype == InputControls.LOOKUPBOX_FIRST))
                {
                    string xTRIMTABLE = list[r].Fieldsname.ToUpper().Replace("_ID","");
                    string xCAPITAL = ChangeCase.ToUpper(xTRIMTABLE);
                    string xSMALL = ChangeCase.ToLower(xTRIMTABLE);
                    string xUPPERFIRST = ChangeCase.UpperFirst(xSMALL);

                    string _field = string.Empty;

                    //List<structure> _structure = cStructure_exten.GetTableFromreal(xDATABASE, xTABLENAME);

                    //_field = _structure[1].field;

                    ___result += "        #region[" + xUPPERFIRST + " Lookup]\r\n";
                    ___result += "\r\n";
                    ___result += "        public void " + xUPPERFIRST + "_lookup() \r\n";
                    ___result += "        { \r\n";
                    ___result += "            txt_" + xSMALL + "_id.LookupColNames = new string[] {" + xCAPITAL + "." + xCAPITAL + "_NAME }; \r\n";
                    ___result += "            txt_" + xSMALL + "_id.LookupUpdate += txt_" + xSMALL + "_LookupUpdate; \r\n";
                    ___result += "            txt_" + xSMALL + "_id.AllowNewEntry = true; \r\n";
                    ___result += "            txt_" + xSMALL + "_id.NewEntryNeeded += txt_" + xSMALL + "_NewEntryNeeded; \r\n";
                    ___result += "        } \r\n";
                    ___result += "        void txt_" + xSMALL + "_LookupUpdate(object sender, EventArgs e) \r\n";
                    ___result += "        { \r\n";
                    ___result += "            txt_" + xSMALL + "_id.LookupList = C" + xUPPERFIRST + "_exten.GetforLookup(new " + xDAL + "()); \r\n";
                    ___result += "        } \r\n";
                    ___result += "        private F" + xUPPERFIRST + " x" + xSMALL + " = null; \r\n";
                    ___result += "        void txt_" + xSMALL + "_NewEntryNeeded(object sender, string pValue) \r\n";
                    ___result += "        { \r\n";
                    ___result += "            if (x" + xSMALL + " == null) \r\n";
                    ___result += "            { \r\n";
                    ___result += "                x" + xSMALL + " = new F" + xUPPERFIRST + "(); \r\n";
                    ___result += "                x" + xSMALL + ".F" + xUPPERFIRST + "_NeedToRefresh += " + xUPPERFIRST + "_NeedToRefresh; \r\n";
                    ___result += "            } \r\n";
                    ___result += "            this.Parent.Controls.Add(x" + xSMALL + "); \r\n";
                    ___result += "            x" + xSMALL + ".Dock = DockStyle.Fill; \r\n";
                    ___result += "            x" + xSMALL + ".Show(); \r\n";
                    ___result += "            x" + xSMALL + ".BringToFront(); \r\n";
                    ___result += "            x" + xSMALL + ".Focus(); \r\n";
                    ___result += "               \r\n";
                    ___result += "            x" + xSMALL + ".SetAction(BtnEvent.New, null); \r\n";
                    ___result += "            x" + xSMALL + ".SetFocus(); \r\n";
                    ___result += "            x" + xSMALL + ".setname(pValue); \r\n";
                    ___result += "        } \r\n";
                    ___result += "        void " + xUPPERFIRST + "_NeedToRefresh(object sender, EventArgs e) \r\n";
                    ___result += "        { \r\n";
                    ___result += "            txt_" + xSMALL + "_id.Text = x" + xSMALL + ".GetName(); \r\n";

                    if (r + 1 < list.Count)
                    {
                        ___result += "            txt_" + list[r + 1].Fieldsname.ToLower() + ".Focus(); \r\n";
                    }
                    else
                    {
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Focus(); \r\n";
                    }


                    ___result += "        } \r\n";
                    ___result += "\r\n";
                    ___result += "        #endregion[" + xUPPERFIRST + "Lookup]\r\n";
                    ___result += "\r\n";
                }
            }

            #endregion[Lookup]

            #region[Set Focus]

            ___result += "        #region[Set Focus]\r\n";
            ___result += "\r\n";
            ___result += "        public void SetFocus()\r\n";
            ___result += "        {\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Isdefault == AutoCode.YES)
                {
                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Focus();\r\n";
                }
            }
            ___result += "        }\r\n";
            ___result += "        #endregion[Set Focus]\r\n";
            ___result += "\r\n";

            #endregion[Set Focus]

            #region[result]

            ___result += "}//cls \r\n";
            ___result += "}//ns \r\n";

            return ___result;

            #endregion[result]

        }
        //
    }//cls
}//ns