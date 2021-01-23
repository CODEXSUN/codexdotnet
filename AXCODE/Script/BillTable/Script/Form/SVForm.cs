using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SVForm
    {
        public static void XForm(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Formfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\V" + tbl_name + ".cs", result);
        }

        #region []

        private static string XCreate(BillTable obj)
        {
            List<SFields> list = obj.SFields;
            List<SFieldsItems> sub = obj.SFieldsItems;


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
            ___result += "// " + DateTime.Now + "\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region[using]

            ___result += "using System; \r\n";
            //___result += "using System.ComponentModel; \r\n";
            ___result += "using System.Collections.Generic; \r\n";
            //___result += "using System.Drawing; \r\n";
            ___result += "using System.Windows.Forms; \r\n";
            ___result += "using CXLIB; \r\n";
            ___result += "using CXCORE; \r\n";
            ___result += " \r\n";
            ___result += "//  \r\n";

            #endregion[using]

            #region[namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{ \r\n";
            ___result += "    public partial class F" + UPPERFIRST + " : UserControl \r\n";
            ___result += "    { \r\n";

            #endregion[namespace]

            #region[Action]

            ___result += "        #region[Action]\r\n";
            ___result += "\r\n";
            ___result += "        private BtnEvent fAction = BtnEvent.Open;\r\n";
            ___result += "        private " + UPPERFIRST + " obj;\r\n";
            ___result += "        private List<" + UPPERFIRST + "items> list;\r\n";
            ___result += "        private string vId;\r\n";
            ___result += "\r\n";
            ___result += "        public void SetAction(BtnEvent action, string pk)\r\n";
            ___result += "        {\r\n";
            ___result += "            fAction = action;\r\n";
            ___result += "           \r\n";
            ___result += "            switch (fAction)\r\n";
            ___result += "            {\r\n";
            ___result += "                case BtnEvent.Open:\r\n";
            ___result += "                    btn_save.Text = \"&CLOSE\";\r\n";
            ___result += "                    obj = C" + UPPERFIRST + "_exten.PKId(pk);\r\n";
            ___result += "                    list = C" + UPPERFIRST + "items_exten.FKId(pk);\r\n";
            ___result += "                    this.EnableControls(false);\r\n";
            ___result += "                    break;\r\n";
            ___result += "                case BtnEvent.New:\r\n";
            ___result += "                    btn_save.Text = \"&SAVE\";\r\n";
            ___result += "                    obj = C" + UPPERFIRST + ".GetNew;\r\n";
            ___result += "                    list = new List<" + UPPERFIRST + "items>();\r\n";
            ___result += "                    this.EnableControls(true);\r\n";
            ___result += "                    break;\r\n";
            ___result += "                case BtnEvent.Edit:\r\n";
            ___result += "                    btn_save.Text = \"&UPDATE\";\r\n";
            ___result += "                    obj = C" + UPPERFIRST + "_exten.PKId(pk);\r\n";
            ___result += "                    list = C" + UPPERFIRST + "items_exten.FKId(pk);\r\n";
            ___result += "                    this.EnableControls(true);\r\n";
            ___result += "                    break;\r\n";
            ___result += "                case BtnEvent.Delete:\r\n";
            ___result += "                    btn_save.Text = \"CONFIRM\\r\\n&DELETE\";\r\n";
            ___result += "                    obj = C" + UPPERFIRST + "_exten.PKId(pk);\r\n";
            ___result += "                    list = C" + UPPERFIRST + "items_exten.FKId(pk);\r\n";
            ___result += "                    this.EnableControls(false);\r\n";
            ___result += "                    break;\r\n";
            ___result += "                case BtnEvent.Print:\r\n";
            ___result += "                    btn_save.Text = \"&PRINT\";\r\n";
            ___result += "                    obj = C" + UPPERFIRST + "_exten.PKId(pk);\r\n";
            ___result += "                    list = C" + UPPERFIRST + "items_exten.FKId(pk);\r\n";
            ___result += "                    this.EnableControls(false);\r\n";
            ___result += "                    print_panel.Show();\r\n";
            ___result += "                    break;\r\n";
            ___result += "            }\r\n";
            ___result += "           \r\n";
            ___result += "            LoadData(obj);\r\n";
            ___result += "            Loaditems(list);\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Action]\r\n";
            ___result += "\r\n";

            #endregion[Action]

            #region[Load Data]

            ___result += "        #region[Load Data]\r\n";
            ___result += "\r\n";
            ___result += "        private void LoadData(" + UPPERFIRST + " obj)\r\n";
            ___result += "        {\r\n";
            ___result += "            vId = obj." + UPPERFIRST + "_id;\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Text = obj." + list[r].Fieldsname.UpperFirst() + ";\r\n";
                }
            }
            ___result += "            txt_notes.Text = obj.Notes;\r\n";
            ___result += "            Core.Stative = obj.Active_id;\r\n";
            ___result += "            Setactives();\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Load Data]\r\n";
            ___result += "\r\n";

            #endregion[Load Data]

            #region[load items]

            ___result += "        #region[load items] \r\n";
            ___result += "\r\n";
            ___result += "        public void Loaditems(List<" + UPPERFIRST + "items> list) \r\n";
            ___result += "        { \r\n";
            ___result += "            editgrid.RowCount = 0; \r\n";
            ___result += "            if(list != null)\r\n";
            ___result += "            { \r\n";
            ___result += "                editgrid.RowCount = list.Count; \r\n";
            ___result += "                for (int r = 0; r < list.Count; r++) \r\n";
            ___result += "                { \r\n";
            ___result += "                    DataGridViewRow row = editgrid.Rows[r]; \r\n";
            ___result += " \r\n";
            ___result += "                    row.Cells[" + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_ID].Value = (list[r]." + UPPERFIRST + "items_id) + \"\"; \r\n";

            for (int r = 0; r < sub.Count - 2; r++)
            {
                ___result += "                    row.Cells[" + CAPITAL + "ITEMS." + sub[r].Fieldsname.ToUpper() + "].Value = (list[r]." + sub[r].Fieldsname.UpperFirst() + ") + \"\"; \r\n";
            }

            ___result += "                } \r\n";
            ___result += "            } \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        #endregion[load items] \r\n";
            ___result += "\r\n";
            #endregion[load items]

            #region[Enable  Disable Controls]

            ___result += "        #region[Enable  Disable Controls]\r\n";
            ___result += "\r\n";
            ___result += "        private void EnableControls(bool pEnabled)\r\n";
            ___result += "        {\r\n";
            ___result += "            bool pReadOnly = !pEnabled;\r\n";
            ___result += "           \r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Enabled = !pReadOnly;\r\n";
                }
            }
            ___result += "            txt_notes.Enabled = !pReadOnly;\r\n";
            ___result += "           \r\n";
            ___result += "            btn_active.Enabled = !pReadOnly;\r\n";
            ___result += "           \r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Enable  Disable Controls]\r\n";
            ___result += "\r\n";

            #endregion[Enable  Disable Controls]

            #region[Save Event]

            ___result += "        #region[Save Event]\r\n";
            ___result += "\r\n";
            ___result += "        private DAL dalsession;\r\n";

            ___result += "        private void Save_Event()\r\n";
            ___result += "        {\r\n";
            ___result += "            if (Validation() != false)\r\n";
            ___result += "            {\r\n";
            ___result += "                switch (fAction)\r\n";
            ___result += "                {\r\n";
            ___result += "                                        case BtnEvent.Open: \r\n ";
            ___result += "                                            this.Hide(); \r\n ";
            ___result += "                                            Form_NeedToRefresh(); \r\n ";
            ___result += "                                            break; \r\n ";
            ___result += "\r\n ";
            ___result += "                                        case BtnEvent.New: \r\n ";
            ___result += "                                            try \r\n ";
            ___result += "                                            { \r\n ";
            ___result += "                                                var vData = CollectData(); \r\n ";
            ___result += "\r\n ";
            ___result += "                                                dalsession = new DAL(); \r\n ";
            ___result += "                                                dalsession.BeginTransaction(); \r\n ";
            ___result += "                                                C" + UPPERFIRST + ".Insert(vData, dalsession); \r\n ";
            ___result += "                                                vId = DAL.GetIdentity(dalsession); \r\n ";
            ___result += "                                                var itemsList = Collectitems(vId); \r\n ";
            ___result += "                                                C" + UPPERFIRST + "items.Insert(itemsList, dalsession); \r\n ";
            ___result += "                                                dalsession.Commit(); \r\n ";
            ___result += "\r\n ";
            ___result += "                                                MessageBox.Show(this.FindForm(), \"Record Saved Successfully.\", \"Save...\", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); \r\n ";
            ___result += "                                                this.Hide(); \r\n ";
            ___result += "                                                Form_NeedToRefresh(); \r\n ";
            ___result += "                                            } \r\n ";
            ___result += "                                            catch (Exception ex) \r\n ";
            ___result += "                                            { \r\n ";
            ___result += "                                                if (dalsession != null) \r\n ";
            ___result += "                                                { \r\n ";
            ___result += "                                                    dalsession.Rollback(); \r\n ";
            ___result += "                                                } \r\n ";
            ___result += "                                                MessageBox.Show(this.FindForm(), \"Something Goes Wrong \\r\\n\" + ex.Message, \"Could Not Save...\", MessageBoxButtons.OK, MessageBoxIcon.Error); \r\n ";
            ___result += "                                                SetFocus(); \r\n ";
            ___result += "                                                return; \r\n ";
            ___result += "                                            } \r\n ";
            ___result += "                                            break; \r\n ";
            ___result += "\r\n ";
            ___result += "                                        case BtnEvent.Edit: \r\n ";
            ___result += "                                            try \r\n ";
            ___result += "                                            { \r\n ";
            ___result += "                                                var vData = CollectData(); \r\n ";
            ___result += "\r\n ";
            ___result += "                                                dalsession = new DAL(); \r\n ";
            ___result += "                                                dalsession.BeginTransaction(); \r\n ";
            ___result += "                                                C" + UPPERFIRST + "items.Delete(vId, dalsession); \r\n ";
            ___result += "                                                C" + UPPERFIRST + ".Update(vData, dalsession); \r\n ";
            ___result += "                                                var itemsList = Collectitems(vId); \r\n ";
            ___result += "                                                C" + UPPERFIRST + "items.Insert(itemsList, dalsession); \r\n ";
            ___result += "                                                dalsession.Commit(); \r\n ";
            ___result += "\r\n ";
            ___result += "                                                MessageBox.Show(this.FindForm(), \"Record Updated Successfully.\", \"Update...\", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); \r\n ";
            ___result += "                                                this.Hide(); \r\n ";
            ___result += "                                                Form_NeedToRefresh(); \r\n ";
            ___result += "                                            } \r\n ";
            ___result += "                                            catch (Exception ex) \r\n ";
            ___result += "                                            { \r\n ";
            ___result += "                                                if (dalsession != null) \r\n ";
            ___result += "                                                { \r\n ";
            ___result += "                                                    dalsession.Rollback(); \r\n ";
            ___result += "                                                } \r\n ";
            ___result += "                                                MessageBox.Show(this.FindForm(), \"Something Goes Wrong \\r\\n\" + ex.Message, \"Could Not Update...\", MessageBoxButtons.OK, MessageBoxIcon.Error); \r\n ";
            ___result += "                                                SetFocus(); \r\n ";
            ___result += "                                                return; \r\n ";
            ___result += "                                            } \r\n ";
            ___result += "                                            break; \r\n ";
            ___result += "                                         \r\n ";
            ___result += "                                        case BtnEvent.Delete: \r\n ";
            ___result += "                                            try \r\n ";
            ___result += "                                            { \r\n ";
            ___result += "                                                dalsession = new DAL(); \r\n ";
            ___result += "                                                dalsession.BeginTransaction(); \r\n ";
            ___result += "                                                C" + UPPERFIRST + "items.Delete(vId, dalsession); \r\n ";
            ___result += "                                                C" + UPPERFIRST + ".Delete(vId, dalsession); \r\n ";
            ___result += "                                                dalsession.Commit(); \r\n ";
            ___result += "\r\n ";
            ___result += "                                                MessageBox.Show(this.FindForm(), \"Record Deleted Successfully.\", \"Delete...\", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); \r\n ";
            ___result += "                                                this.Hide(); \r\n ";
            ___result += "                                                Form_NeedToRefresh(); \r\n ";
            ___result += "                                            } \r\n ";
            ___result += "                                            catch (Exception ex) \r\n ";
            ___result += "                                            { \r\n ";
            ___result += "                                                if (dalsession != null) \r\n ";
            ___result += "                                                { \r\n ";
            ___result += "                                                    dalsession.Rollback(); \r\n ";
            ___result += "                                                } \r\n ";
            ___result += "                                                MessageBox.Show(this.FindForm(), \"Something Goes Wrong \\r\\n\" + ex.Message, \"Could Not Update...\", MessageBoxButtons.OK, MessageBoxIcon.Error); \r\n ";
            ___result += "                                                SetFocus(); \r\n ";
            ___result += "                                                return; \r\n ";
            ___result += "                                            } \r\n ";
            ___result += "                                            break; \r\n ";
            ___result += "\r\n";
            ___result += "                    case BtnEvent.Print:\r\n";
            ___result += "                        this.Hide();\r\n";
            ___result += "                        Form_NeedToRefresh();\r\n";
            ___result += "                        break;\r\n";
            ___result += "                }\r\n";
            ___result += "            }\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Save Event]\r\n";
            ___result += "\r\n";

            #endregion[Event]

            #region[Collect Data]

            ___result += "        #region[Collect Data]\r\n";
            ___result += "\r\n";
            ___result += "        private " + UPPERFIRST + " CollectData()\r\n";
            ___result += "        {\r\n";
            ___result += "            " + UPPERFIRST + " fobj = new " + UPPERFIRST + "()\r\n";
            ___result += "           {\r\n";
            ___result += "                " + UPPERFIRST + "_id = vId,\r\n";

            for (int r = 0; r < list.Count; r++)
            {

                switch (list[r].Fieldsname.UpperFirst())
                {
                    case "Year_no":

                        #region[find no field]

                        if (CAPITAL == "PO")
                        {
                            ___result += "                Year_no =Current.AYear + \"~\" + Current.Company_id + \"~\" + txt_po_no.Text,\r\n";
                        }
                        else
                        {
                            ___result += "                Year_no =Current.AYear + \"~\" + Current.Company_id + \"~\" + C" + UPPERFIRST + "_exten.GetNext_No,\r\n";
                        }

                        #endregion[find no field]

                        break;
                    case "Company_id":
                        ___result += "                Company_id =Current.Company_id,\r\n";
                        break;
                    case "Refered_no":
                        ___result += "                Refered_no =\"\",\r\n";
                        break;
                    case "Locked":
                        ___result += "                Locked =Core.Unlocked,\r\n";
                        break;

                    default:
                        if (list[r].Inputtype == InputControls.LOOKUPBOX)
                        {
                            ___result += "                " + list[r].Fieldsname.UpperFirst() + " = C" + (list[r].Fieldsname.UpperFirst()).Replace("_id", "") + "_exten.GetId_Name(txt_" + list[r].Fieldsname.ToLower() + ".Text),\r\n";
                        }
                        else
                        {

                            if (list[r].Fieldsname.UpperFirst() == UPPERFIRST + "_no")
                            {
                                if (list[r].Inputtype != InputControls.None)
                                {
                                    ___result += "                " + list[r].Fieldsname.UpperFirst() + " = txt_" + list[r].Fieldsname.ToLower() + ".Text,\r\n";
                                }
                                else
                                {
                                    ___result += "                " + list[r].Fieldsname.UpperFirst() + " = C" + UPPERFIRST + "_exten.GetNext_No,\r\n";
                                }
                            }
                            else
                            {
                                ___result += "                " + list[r].Fieldsname.UpperFirst() + " = txt_" + list[r].Fieldsname.ToLower() + ".Text,\r\n";
                            }
                        }
                        break;
                }
            }

            ___result += "                Active_id = Core.Stative,\r\n";
            ___result += "                Notes = txt_notes.Text,\r\n";
            ___result += "                User_id = Current.User\r\n";
            ___result += "            };\r\n";
            ___result += "            return fobj;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[CollectData]\r\n";
            ___result += "\r\n";

            #endregion[Collect Data]

            #region[Collect items Data]

            ___result += "        #region[Collect items] \r\n";
            ___result += "\r\n";
            ___result += "        private List<" + UPPERFIRST + "items> Collectitems(string vId) \r\n";
            ___result += "        { \r\n";
            ___result += "\r\n";
            ___result += "            List<" + UPPERFIRST + "items> list = new List<" + UPPERFIRST + "items>(); \r\n";
            ___result += "\r\n";
            ___result += "            for (int r = 0; r < editgrid.RowCount; r++) \r\n";
            ___result += "            { \r\n";
            ___result += "\r\n";
            ___result += "                " + UPPERFIRST + "items obj = new " + UPPERFIRST + "items(); \r\n";
            ___result += "\r\n";
            ___result += "                if ( \r\n";
            ___result += "               (editgrid[" + CAPITAL + "ITEMS.PRODUCT_ID, r].Value + \"\") == \"\" || \r\n";
            ___result += "                (editgrid[" + CAPITAL + "ITEMS.QTY, r].Value + \"\") == \"\"";
            if (obj.STables.Stables_id != "2")
            {
                ___result += " || \r\n                (editgrid[" + CAPITAL + "ITEMS.PRICE, r].Value + \"\") == \"\" \r\n";
            }
            ___result += "                ) \r\n";
            ___result += "                { \r\n";
            ___result += "                    //==LEAVE IT(the empty row).  \r\n";
            ___result += "                } \r\n";
            ___result += "                else \r\n";
            ___result += "                { \r\n";
            ___result += "                    obj." + UPPERFIRST + "items_id = \"\"; \r\n";
            ___result += "                    obj." + UPPERFIRST + "_id = vId; \r\n";

            for (int r = 0; r < sub.Count; r++)
            {
                if (sub[r].Inputtype == InputControls.Lookupbox)
                {
                    ___result += "                    obj." + sub[r].Fieldsname.UpperFirst() + " = C" + (sub[r].Fieldsname.UpperFirst()).Replace("_id", "") + "_exten.GetId_Name(editgrid[" + CAPITAL + "ITEMS." + sub[r].Fieldsname.ToUpper() + ", r].Value + \"\");\r\n";
                }
                else
                {
                    if (sub[r].Inputtype != InputControls.None)
                    {
                        ___result += "                    obj." + sub[r].Fieldsname.UpperFirst() + " = (editgrid[" + CAPITAL + "ITEMS." + sub[r].Fieldsname.ToUpper() + ", r].Value + \"\"); \r\n";
                    }
                }
            }
            ___result += "                    obj.Refered_qty = \"\"; \r\n";
            ___result += "                    obj.Locked = Core.Unlocked; \r\n";
            ___result += "\r\n";
            ___result += "                    list.Add(obj); \r\n";
            ___result += "                } \r\n";
            ___result += "\r\n";
            ___result += "            } \r\n";
            ___result += "\r\n";
            ___result += "            if (list.Count != 0) \r\n";
            ___result += "            { \r\n";
            ___result += "                return list; \r\n";
            ___result += "            } \r\n";
            ___result += "\r\n";
            ___result += "            return null; \r\n";
            ___result += "        } \r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Collect items] \r\n";
            ___result += "\r\n";

            #endregion[Collect items Data]

            #region[Validation]

            ___result += "        #region[Validation]\r\n";
            ___result += "\r\n";
            ___result += "        private bool Validation()\r\n";
            ___result += "        {\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Validate == AutoCode.YES)
                {
                    ___result += "            if (txt_" + list[r].Fieldsname.ToLower() + ".Text.Trim().Length == 0)\r\n";
                    ___result += "            {\r\n";
                    ___result += "                MessageBox.Show(this.FindForm(), \"" + (list[r].Fieldsname.UpperFirst()).Replace("_", " ") + " should not Empty ! \", \"Warning...\", MessageBoxButtons.OK, MessageBoxIcon.Warning);\r\n";
                    ___result += "                txt_" + list[r].Fieldsname.ToLower() + ".Focus();\r\n";
                    ___result += "                return false;\r\n";
                    ___result += "            }\r\n";
                    ___result += "           \r\n";
                }
            }

            ___result += "            if (Core.Stative == Core.Idle)\r\n";
            ___result += "            {\r\n";
            ___result += "                MessageBox.Show(this.FindForm(), \"Select Active or not !\", \"Warning...\", MessageBoxButtons.OK, MessageBoxIcon.Warning);\r\n";
            ___result += "                btn_active.Focus();\r\n";
            ___result += "                return false;\r\n";
            ___result += "            }\r\n";
            ___result += "           \r\n";
            ___result += "            return true;\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Validation]\r\n";
            ___result += "\r\n";

            #endregion[Validation]

            #region[result]

            ___result += "}//cls \r\n";
            ___result += "}//ns \r\n";

            return ___result;

            #endregion[result]

        }

    }//cls
}//ns