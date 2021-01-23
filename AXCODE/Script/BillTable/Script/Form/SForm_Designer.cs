using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SForm_Design
    {
        public static void XForm_Design(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Formfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\F" + tbl_name + "_Designer.cs", result);
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

           // string xDAL = "DAL";

            #endregion []

            #region [Conclusion]

            ___result += "// " + CVersion_exten.Get_Current_Version() + "\r\n";
            ___result += "// Auto Generated\r\n";
            ___result += "// " + DateTime.Now + "\r\n";
            ___result += "// last update : " + DateTime.Now.ToString("dd-MM-yyyy") + "\r\n";
            ___result += "\r\n";

            #endregion [Conclusion]

            #region[using ]

            ___result += "using System;\r\n";
            ___result += "using System.Windows.Forms;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "using System.Drawing;\r\n";
            ___result += "using System.ComponentModel;\r\n";
            ___result += "\r\n";
            ___result += "\r\n";

            #endregion[using ]

            #region[namespace ]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{ \r\n";
            ___result += "    public partial class F" + UPPERFIRST + " : UserControl \r\n";
            ___result += "    { \r\n";
            ___result += "        public F" + UPPERFIRST + "() \r\n";
            ___result += "        {\r\n";
            ___result += "            InitializeComponent();\r\n";
            ___result += "            Initialize();\r\n";
            ___result += "            InitGrid();\r\n";
            ___result += "            Setactives();\r\n";
            ___result += "            SetFocus(); \r\n";

            #region[add Lookup]

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype == InputControls.Lookupbox)
                {
                    ___result += "            " + list[r].Fieldsname.UpperFirst().Replace("_id", "") + "_lookup(); \r\n";
                }
            }
            ___result += "        }\r\n";
            ___result += "        \r\n";
            #endregion[add Lookup]

            #endregion[namespace ]

            #region[Private Variable] 

            ___result += "        #region [Private Declare]\r\n";
            ___result += "\r\n";
            ___result += "        private Timer splitTimer;\r\n";
            ___result += "        private SplitContainer split_container;\r\n";
            ___result += "        private XShadowPanel fpanel;\r\n";
            ___result += "        private Panel finner_panel;\r\n";
            ___result += "        private CloseButton btn_close;\r\n";
            ___result += "        private Header lbl_header;\r\n";
            ___result += "        private OfficeButton btn_list;\r\n";
            ___result += "        private OfficeButton btn_new;\r\n";
            ___result += "        private OfficeButton btn_edit;\r\n";
            ___result += "        private OfficeButton btn_delete;\r\n";
            ___result += "        private OfficeButton btn_print;\r\n";
            ___result += "        private OfficeButton btn_splitter;\r\n";
            ___result += "\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Placement == AutoCode.AboveGrid)
                    {
                        ___result += "        private " + InputControls.Get(list[r].Inputtype) + " txt_" + list[r].Fieldsname.ToLower() + ";\r\n";
                        ___result += "        private XLabel lbl_" + list[r].Fieldsname.ToLower() + ";\r\n";
                    }
                }
            }

            ___result += "        private EditGridView editgrid;\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Placement == AutoCode.BelowGrid)
                    {
                        ___result += "        private " + InputControls.Get(list[r].Inputtype) + " txt_" + list[r].Fieldsname.ToLower() + ";\r\n";
                        ___result += "        private XLabel lbl_" + list[r].Fieldsname.ToLower() + ";\r\n";
                    }
                }
            }

            ___result += "\r\n";
            ___result += "        private RichTextBox txt_notes;\r\n";
            ___result += "        private XLabel lbl_notes;\r\n";
            ___result += "        private OfficeButton btn_save;\r\n";
            ___result += "        private OfficeButton btn_active;\r\n";
            ___result += "\r\n";
            ___result += "        #endregion [Private Declare]\r\n";
            ___result += "\r\n";

            #endregion[Declare Private]

            #region [Initialize]

            ___result += "        private void Initialize() \r\n";
            ___result += "        { \r\n";
            ___result += "\r\n";

            #region[declare new]

            ___result += "            #region[declare new]\r\n";
            ___result += "\r\n";
            ___result += "            components = new Container();\r\n";
            ___result += "            splitTimer = new Timer(components);\r\n";
            ___result += "            split_container = new SplitContainer();\r\n";
            ___result += "            fpanel = new XShadowPanel();\r\n";
            ___result += "            finner_panel = new Panel();\r\n";
            ___result += "            btn_list = new OfficeButton();\r\n";
            ___result += "            btn_new = new OfficeButton();\r\n";
            ___result += "            btn_edit = new OfficeButton();\r\n";
            ___result += "            btn_delete = new OfficeButton();\r\n";
            ___result += "            btn_print = new OfficeButton();\r\n";
            ___result += "            btn_splitter = new OfficeButton();\r\n";
            ___result += "            lbl_header = new Header();\r\n";
            ___result += "            btn_close = new CloseButton();\r\n";
            ___result += "\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Placement == AutoCode.AboveGrid)
                    {
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + " = new " + InputControls.Get(list[r].Inputtype) + "();\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + " = new XLabel();\r\n";
                    }
                }
            }

            ___result += "            editgrid = new EditGridView();\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Placement == AutoCode.BelowGrid)
                    {
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + " = new " + InputControls.Get(list[r].Inputtype) + "();\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + " = new XLabel();\r\n";
                    }
                }
            }

            ___result += "\r\n";
            ___result += "            txt_notes = new RichTextBox();\r\n";
            ___result += "            lbl_notes = new XLabel();\r\n";
            ___result += "            btn_save = new OfficeButton();\r\n";
            ___result += "            btn_active = new OfficeButton();\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[declare new]\r\n";
            ___result += "\r\n";

            #endregion[declare new]

            #region[container suspend]

            ___result += "            #region[container suspend]\r\n";
            ___result += "\r\n";
            ___result += "            ((ISupportInitialize)(split_container)).BeginInit();\r\n";
            ___result += "            ((ISupportInitialize)(editgrid)).BeginInit();\r\n";
            ___result += "            split_container.Panel1.SuspendLayout();\r\n";
            ___result += "            split_container.Panel2.SuspendLayout();\r\n";
            ___result += "            split_container.SuspendLayout();\r\n";
            ___result += "            fpanel.SuspendLayout();\r\n";
            ___result += "            finner_panel.SuspendLayout();\r\n";
            ___result += "            SuspendLayout();\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[container suspend]\r\n";
            ___result += "\r\n";

            #endregion[container suspend]

            #region[splitTimer]

            ___result += "            #region[splitTimer]\r\n";
            ___result += "\r\n";
            ___result += "            splitTimer.Interval = 2;\r\n";
            ___result += "            splitTimer.Tick += new EventHandler(SplitTimer_Tick);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[splitTimer]\r\n";
            ___result += "\r\n";

            #endregion[splitTimer]

            #region[split_container]

            ___result += "            #region[split_container]\r\n";
            ___result += "\r\n";
            ___result += "            split_container.Dock = DockStyle.Fill;\r\n";
            ___result += "            split_container.Location = new Point(0, 0);\r\n";
            ___result += "            split_container.Name = \"split_container\";\r\n";
            ___result += "            split_container.BackColor = XTheme.Splitcontainer_colour;\r\n";
            ___result += "            split_container.Size = XSize.FSplitcontainer;\r\n";
            ___result += "            split_container.SplitterDistance = XSize.Screen_Width;\r\n";
            ___result += "            split_container.TabIndex = XTab.Splitcontainer;\r\n";
            ___result += "\r\n";
            ___result += "            // split_container.Panel1\r\n";
            ___result += "\r\n";
            ___result += "            split_container.Panel1.Controls.Add(fpanel);\r\n";
            ___result += "\r\n";

            #region[split_container.Panel2]

            ___result += "            #region[split_container.Panel2]\r\n";
            ___result += "\r\n";
            ___result += "            split_container.Panel2.Controls.Add(btn_print);\r\n";
            ___result += "            split_container.Panel2.Controls.Add(btn_delete);\r\n";
            ___result += "            split_container.Panel2.Controls.Add(btn_edit);\r\n";
            ___result += "            split_container.Panel2.Controls.Add(btn_new);\r\n";
            ___result += "            split_container.Panel2.Controls.Add(btn_list);\r\n";
            ___result += "            split_container.Panel2.Controls.Add(btn_splitter);\r\n";
            ___result += "\r\n";
            ___result += "            btn_list.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_list.Location =  XLayout.FormFirstBtn;\r\n";
            ___result += "            btn_list.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_list.TabIndex = 1;\r\n";
            ___result += "            btn_list.Name = \"btn_list\";\r\n";
            ___result += "            btn_list.Text = \"&List\";\r\n";
            ___result += "            btn_list.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_list.Click += Btn_list_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_new.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_new.Location = XLayout.BtnLocation(btn_list.Location);\r\n";
            ___result += "            btn_new.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_new.TabIndex = XTab.Index(btn_list.TabIndex);\r\n";
            ___result += "            btn_new.Name = \"btn_new\";\r\n";
            ___result += "            btn_new.Text = \"&New\";\r\n";
            ___result += "            btn_new.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_new.Click += Btn_new_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_edit.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_edit.Location = XLayout.BtnLocation(btn_new.Location);\r\n";
            ___result += "            btn_edit.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_edit.TabIndex = XTab.Index(btn_new.TabIndex);\r\n";
            ___result += "            btn_edit.Name = \"btn_edit\";\r\n";
            ___result += "            btn_edit.Text = \"&Edit\";\r\n";
            ___result += "            btn_edit.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_edit.Click += Btn_edit_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_delete.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_delete.Location = XLayout.BtnLocation(btn_edit.Location);\r\n";
            ___result += "            btn_delete.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_delete.TabIndex = XTab.Index(btn_edit.TabIndex);\r\n";
            ___result += "            btn_delete.Name = \"btn_delete\";\r\n";
            ___result += "            btn_delete.Text = \"&Delete\";\r\n";
            ___result += "            btn_delete.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_delete.Click += Btn_delete_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_print.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_print.Location = XLayout.BtnLocation(btn_delete.Location);\r\n";
            ___result += "            btn_print.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_print.TabIndex = XTab.Index(btn_delete.TabIndex);\r\n";
            ___result += "            btn_print.Name = \"btn_print\";\r\n";
            ___result += "            btn_print.Text = \"&Print\";\r\n";
            ___result += "            btn_print.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_print.Click += Btn_print_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_splitter.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_splitter.Location = XLayout.Splitter;\r\n";
            ___result += "            btn_splitter.Size = XSize.Splitter;\r\n";
            ___result += "            btn_splitter.TabIndex = XTab.Index(btn_print.TabIndex);\r\n";
            ___result += "            btn_splitter.Name = \"btn_splitter\";\r\n";
            ___result += "            btn_splitter.Text = \"⁞⁞\";\r\n";
            ___result += "            btn_splitter.Themes = XTheme.WhiteBtn;\r\n";
            ___result += "            btn_splitter.Click += new EventHandler(Btn_splitter_Click);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[split_container.Panel2]\r\n";
            ___result += "\r\n";

            #endregion[split_container.Panel2]

            ___result += "            #endregion[split_container]\r\n";
            ___result += "\r\n";

            #endregion[split_container]

            #region[fpanel]

            ___result += "            #region[fpanel]\r\n";
            ___result += "\r\n";
            ___result += "            fpanel.Name = \"fpanel\";\r\n";
            ___result += "            fpanel.Anchor = XAnchor.LTR;\r\n";
            ___result += "            fpanel.Size =  XSize.FPanel;\r\n";
            ___result += "            fpanel.Location = XLayout.FPanel;\r\n";
            ___result += "            fpanel.BackColor = XTheme.FPanel;\r\n";
            ___result += "            fpanel.Controls.Add(finner_panel);\r\n";
            ___result += "            fpanel.Controls.Add(btn_close);\r\n";
            ___result += "            fpanel.Controls.Add(lbl_header);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[fpanel]\r\n";
            ___result += "\r\n";

            #endregion[fpanel]

            #region[finner_panel]

            ___result += "            #region[finner_panel]\r\n";
            ___result += "\r\n";
            ___result += "            finner_panel.Anchor = XAnchor.LTR;\r\n";
            ___result += "            finner_panel.Cursor = Cursors.Default;\r\n";
            ___result += "            finner_panel.Name = \"finner_panel\";\r\n";
            ___result += "            finner_panel.Size = XSize.FInnerPanel;\r\n";
            ___result += "            finner_panel.Location = XLayout.FInnerPanel;\r\n";
            ___result += "            finner_panel.BackColor = XTheme.FInnerpanel;\r\n";
            ___result += "            finner_panel.AutoScroll = true;\r\n";
            ___result += "\r\n";

            #region[adding controls]

            ___result += "            #region[adding controls]\r\n";
            ___result += "\r\n";

            ___result += "            finner_panel.Controls.Add(txt_notes);\r\n";
            ___result += "            finner_panel.Controls.Add(lbl_notes);\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    ___result += "            finner_panel.Controls.Add(txt_" + list[r].Fieldsname.ToLower() + ");\r\n";
                    ___result += "            finner_panel.Controls.Add(lbl_" + list[r].Fieldsname.ToLower() + ");\r\n";
                }
            }


            ___result += "            finner_panel.Controls.Add(editgrid);\r\n";
            ___result += "            finner_panel.Controls.Add(btn_save);\r\n";
            ___result += "            finner_panel.Controls.Add(btn_active);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[adding controls]\r\n";
            ___result += "\r\n";

            #endregion[adding btn] 

            #region[Properties of Header]

            ___result += "            #region[Header]\r\n";
            ___result += "\r\n";
            ___result += "            btn_close.Click += new EventHandler(Btn_close_Click);\r\n";
            ___result += "\r\n";
            ___result += "            lbl_header.Text = \"" + ((obj.STables.Stables_name).Replace("_", " ")).UpperFirst() + "\";\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[Header]\r\n";
            ___result += "\r\n";

            #endregion[Header] 

            #region[Properties of control Above Grid]

            ___result += "            #region[Properties of control]\r\n";

            string lastfield = ""; int lastrow = 0;
            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Placement == AutoCode.AboveGrid)
                    {

                        #region[lbl Properties]

                        string hlblp = "";

                        ___result += "\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Font = XFont.Font_10B;\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Name = \"lbl_" + list[r].Fieldsname.ToLower() + "\";\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Text = \"   " + (ChangeCase.UpperFirst(list[r].Displayname.ToLower())).Replace("_", " ") + "\";\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".TextAlign = ContentAlignment.MiddleLeft;\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".ForeColor = XFontColor.Lbl_ForeColor;\r\n";

                        switch (list[r].Width)
                        {
                            case AutoCode.C1:
                                ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";

                                //switch (list[r].Cposition)
                                //{
                                //    case AutoCode.P1:
                                hlblp = AutoCode.R1_Label;
                                //        break;
                                //}

                                break;

                            case AutoCode.C2:
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";
                                }
                                else
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.TwoLabel;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:

                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_2Label_1;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_2Label_1;
                                        }
                                        break;

                                    case AutoCode.P2:

                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_2Label_2;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_2Label_2;
                                        }

                                        break;
                                }

                                break;

                            case AutoCode.C3:
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";
                                }
                                else
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.ThreeLabel;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_3Label_1;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_3Label_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_3Label_2;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_3Label_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_3Label_3;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_3Label_3;
                                        }
                                        break;
                                }

                                break;

                            case AutoCode.C4:
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";
                                }
                                else
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.FourLabel;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_1;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_2;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_3;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_3;
                                        }
                                        break;

                                    case AutoCode.P4:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_4;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_4;
                                        }
                                        break;
                                }

                                break;
                        }

                        if ((list[r].Inputtype == InputControls.TEXTBOX_FIRST) || (list[r].Inputtype == InputControls.LOOKUPBOX_FIRST))
                        {
                            ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Location =XLayout.FirstLabel;\r\n";
                        }
                        else
                        {
                            ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Location =XLayout." + hlblp + "(lbl_" + list[r - 1].Fieldsname.ToLower() + ".Location);\r\n";
                        }

                        #endregion[LBL Properties]

                        #region[Text Properties]

                        string htxtp = "";


                        ___result += "\r\n";
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Font = XFont.TxtFont;\r\n";
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".ForeColor = XFontColor.TxtFontColor;\r\n";
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".BackColor = XTheme.TxtBackcolor;\r\n";

                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Name = \"txt_" + list[r].Fieldsname.ToLower() + "\";\r\n";

                        switch (list[r].Inputtype)
                        {
                            case InputControls.DATEBOX:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".CustomFormat = \"" + InputControls.Datebox_format + "\";\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Format = DateTimePickerFormat.Custom;\r\n";
                                break;
                            case InputControls.DATETIMEBOX:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".CustomFormat = \"" + InputControls.Datetimebox_format + "\";\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Format = DateTimePickerFormat.Custom;\r\n";
                                break;
                            case InputControls.TIMEBOX:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".CustomFormat = \"" + InputControls.Timebox_format + "\";\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Format = DateTimePickerFormat.Custom;\r\n";
                                break;
                            default:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;\r\n";
                                switch (list[r].Alignto)
                                {
                                    case AutoCode.Left:
                                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TextAlign = HorizontalAlignment.Left;\r\n";
                                        break;
                                    case AutoCode.Right:
                                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TextAlign = HorizontalAlignment.Right;\r\n";
                                        break;
                                    case AutoCode.Center:
                                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TextAlign = HorizontalAlignment.Center;\r\n";
                                        break;
                                }
                                if (list[r].Readonly == AutoCode.YES)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".ReadOnly = true;\r\n";
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Cursor = Cursors.No;\r\n";
                                }
                                break;
                        }

                        switch (list[r].Width)
                        {
                            case AutoCode.C1:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneText;\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";

                                htxtp = AutoCode.R1_Text;

                                break;

                            case AutoCode.C2:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.TwoText;\r\n";

                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                                }
                                else
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_2Text_1;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_2Text_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_2Text_2;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_2Text_2;
                                        }
                                        break;
                                }

                                break;

                            case AutoCode.C3:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.ThreeText;\r\n";
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                                }
                                else
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";
                                }
                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_3Text_1;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_3Text_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_3Text_2;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_3Text_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_3Text_3;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_3Text_3;
                                        }
                                        break;
                                }

                                break;

                            case AutoCode.C4:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.FourText;\r\n";
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                                }
                                else
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_1;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_2;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_3;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_3;
                                        }
                                        break;

                                    case AutoCode.P4:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_4;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_4;
                                        }
                                        break;
                                }

                                break;
                        }


                        if ((list[r].Inputtype == InputControls.TEXTBOX_FIRST) || (list[r].Inputtype == InputControls.LOOKUPBOX_FIRST))
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Location =XLayout.FirstText;\r\n";
                        }
                        else
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Location =XLayout." + htxtp + "(txt_" + list[r - 1].Fieldsname.ToLower() + ".Location);\r\n";
                        }

                        if (list[r].Inputtype == InputControls.TEXTBOX_FIRST)/////// tab index
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TabIndex = XTab.Txt_TabIndex;\r\n";
                        }
                        else
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TabIndex = XTab.Index(txt_" + list[r - 1].Fieldsname.ToLower() + ".TabIndex);\r\n";
                        }

                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Enter += new EventHandler(Txt_" + list[r].Fieldsname.ToLower() + "_Enter);\r\n";
                        ___result += "\r\n";
                        
                        #endregion[Text Properties]

                        lastfield = list[r].Fieldsname.ToLower(); // takes last field to next
                        lastrow = r;
                    }
                }
            }

            #endregion[Properties of control Above Grid]

            #region[Edit grid]

            ___result += "            editgrid.Location = new Point(XLayout.H_left, lbl_" + lastfield + ".Bottom + 10); \r\n";
            ___result += "            editgrid.Name = \"editgrid\"; \r\n";
            ___result += "            editgrid.Size = new Size(finner_panel.Width - 50, 250); \r\n";
            ___result += "            editgrid.TabIndex = XTab.Index(txt_" + lastfield.ToLower() + ".TabIndex);\r\n";
            ___result += "            editgrid.RowsLimit = 12; \r\n";
            ___result += "            Point p = new Point(editgrid.Left , editgrid.Bottom); \r\n";
            ___result += "\r\n";

            #endregion[Edit grid]

            #region[Properties of control Below Grid]

            for (int r = lastrow; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    if (list[r].Placement == AutoCode.BelowGrid)
                    {

                        #region[lbl Properties]

                        string hlblp = "";

                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Font = XFont.Font_10B;\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Name = \"lbl_" + list[r].Fieldsname.ToLower() + "\";\r\n";

                        if (list[r].Cposition != AutoCode.C1)
                        {
                            ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Text = \"" + (ChangeCase.UpperFirst(list[r].Displayname.ToLower())).Replace("_", " ") + "\";\r\n";
                        }
                        else
                        {
                            ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Text = \"   " + (ChangeCase.UpperFirst(list[r].Displayname.ToLower())).Replace("_", " ") + "\";\r\n";
                        }
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".TextAlign = ContentAlignment.MiddleLeft;\r\n";
                        ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".ForeColor = XFontColor.Lbl_ForeColor;\r\n";

                        switch (list[r].Width)
                        {
                            case AutoCode.C1:
                                ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";

                                //switch (list[r].Cposition)
                                //{
                                //    case AutoCode.P1:
                                hlblp = AutoCode.R1_Label;
                                //        break;
                                //}

                                break;

                            case AutoCode.C2:
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";
                                }
                                else
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.TwoLabel;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:

                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_2Label_1;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_2Label_1;
                                        }
                                        break;

                                    case AutoCode.P2:

                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_2Label_2;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_2Label_2;
                                        }

                                        break;
                                }

                                break;

                            case AutoCode.C3:
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";
                                }
                                else
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.ThreeLabel;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_3Label_1;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_3Label_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_3Label_2;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_3Label_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_3Label_3;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_3Label_3;
                                        }
                                        break;
                                }

                                break;

                            case AutoCode.C4:
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneLabel;\r\n";
                                }
                                else
                                {
                                    ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.FourLabel;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_1;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_2;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_3;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_3;
                                        }
                                        break;

                                    case AutoCode.P4:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            hlblp = AutoCode.R1_4Label_4;
                                        }
                                        else
                                        {
                                            hlblp = AutoCode.R2_4Label_4;
                                        }
                                        break;
                                }

                                break;
                        }

                        if (r == lastrow+1)
                        {
                            ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Location =XLayout." + hlblp + "(p);\r\n";
                        }
                        else
                        {
                            ___result += "            lbl_" + list[r].Fieldsname.ToLower() + ".Location =XLayout." + hlblp + "(lbl_" + list[r - 1].Fieldsname.ToLower() + ".Location);\r\n";
                        }

                        #endregion[LBL Properties]

                        #region[Text Properties]

                        string htxtp = "";


                        ___result += "\r\n";
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Font = XFont.TxtFont;\r\n";
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".ForeColor = XFontColor.TxtFontColor;\r\n";
                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".BackColor = XTheme.TxtBackcolor;\r\n";

                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Name = \"txt_" + list[r].Fieldsname.ToLower() + "\";\r\n";

                        switch (list[r].Inputtype)
                        {
                            case InputControls.DATEBOX:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".CustomFormat = \"" + InputControls.Datebox_format + "\";\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Format = DateTimePickerFormat.Custom;\r\n";
                                break;
                            case InputControls.DATETIMEBOX:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".CustomFormat = \"" + InputControls.Datetimebox_format + "\";\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Format = DateTimePickerFormat.Custom;\r\n";
                                break;
                            case InputControls.TIMEBOX:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".CustomFormat = \"" + InputControls.Timebox_format + "\";\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Format = DateTimePickerFormat.Custom;\r\n";
                                break;
                            default:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;\r\n";
                                if (list[r].Readonly == AutoCode.YES)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".ReadOnly = true;\r\n";
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Cursor = Cursors.No;\r\n";
                                }

                                switch (list[r].Alignto)
                                {
                                    case AutoCode.Left:
                                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TextAlign = HorizontalAlignment.Left;\r\n";
                                        break;
                                    case AutoCode.Right:
                                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TextAlign = HorizontalAlignment.Right;\r\n";
                                        break;
                                    case AutoCode.Center:
                                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TextAlign = HorizontalAlignment.Center;\r\n";
                                        break;
                                }
                                break;
                        }

                        switch (list[r].Width)
                        {
                            case AutoCode.C1:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.OneText;\r\n";
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";

                                htxtp = AutoCode.R1_Text;

                                break;

                            case AutoCode.C2:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.TwoText;\r\n";

                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                                }
                                else
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_2Text_1;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_2Text_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_2Text_2;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_2Text_2;
                                        }
                                        break;
                                }

                                break;

                            case AutoCode.C3:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.ThreeText;\r\n";
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                                }
                                else
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";
                                }
                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_3Text_1;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_3Text_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_3Text_2;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_3Text_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_3Text_3;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_3Text_3;
                                        }
                                        break;
                                }

                                break;

                            case AutoCode.C4:
                                ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Size =  XSize.FourText;\r\n";
                                if (list[r].Cposition == AutoCode.P1)
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LT;\r\n";
                                }
                                else
                                {
                                    ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Anchor = XAnchor.LTR;\r\n";
                                }

                                switch (list[r].Cposition)
                                {
                                    case AutoCode.P1:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_1;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_1;
                                        }
                                        break;

                                    case AutoCode.P2:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_2;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_2;
                                        }
                                        break;

                                    case AutoCode.P3:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_3;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_3;
                                        }
                                        break;

                                    case AutoCode.P4:
                                        if (list[r].Rposition == AutoCode.SAME_ROW)
                                        {
                                            htxtp = AutoCode.R1_4Text_4;
                                        }
                                        else
                                        {
                                            htxtp = AutoCode.R2_4Text_4;
                                        }
                                        break;
                                }

                                break;
                        }


                        if (r == lastrow + 1)
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Location =XLayout." + htxtp + "(p);\r\n";
                        }
                        else
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Location =XLayout." + htxtp + "(txt_" + list[r - 1].Fieldsname.ToLower() + ".Location);\r\n";
                        }

                        if (list[r].Inputtype == InputControls.TEXTBOX_BELOWGRIDFIRST)/////// tab index
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TabIndex = XTab.Index(editgrid.TabIndex);\r\n";
                        }
                        else
                        {
                            ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".TabIndex = XTab.Index(txt_" + list[r - 1].Fieldsname.ToLower() + ".TabIndex);\r\n";
                        }

                        ___result += "            txt_" + list[r].Fieldsname.ToLower() + ".Enter += new EventHandler(Txt_" + list[r].Fieldsname.ToLower() + "_Enter);\r\n";
                        ___result += "\r\n";

                        #endregion[Text Properties]

                        lastfield = list[r].Fieldsname.ToLower(); // takes last field to next

                    }
                }
            }

            #endregion[Properties of control Below Grid]

            #region[Notes Properties]

            ___result += "\r\n";
            ___result += "            lbl_notes.Font = XFont.Font_10B;\r\n";
            ___result += "            lbl_notes.ForeColor = XFontColor.Lbl_ForeColor;\r\n";
            ___result += "            lbl_notes.Location = XLayout.LblNotes;\r\n";
            ___result += "            lbl_notes.Size = XSize.LblNotes;\r\n";
            ___result += "            lbl_notes.Anchor = XAnchor.LB;\r\n";
            ___result += "            lbl_notes.Name = \"lbl_notes\";\r\n";
            ___result += "            lbl_notes.Text = \"   Notes\";\r\n";
            ___result += "            lbl_notes.TextAlign = ContentAlignment.MiddleLeft;\r\n";
            ___result += "            lbl_notes.Click += new EventHandler(Lbl_notes_Click);\r\n";
            ___result += "\r\n";
            ___result += "            txt_notes.Font = Theme.txtFont;\r\n";
            ___result += "            txt_notes.ForeColor = Theme.txtForeColor;\r\n";
            ___result += "            txt_notes.BackColor = Theme.White;\r\n";
            ___result += "            txt_notes.Location = XLayout.TxtNotes;\r\n";
            ___result += "            txt_notes.Size =  XSize.TxtNotes;\r\n";
            ___result += "            txt_notes.Name = \"txt_notes\";\r\n";
            ___result += "            txt_notes.Anchor = XAnchor.LRB;\r\n";
            ___result += "            txt_notes.TabIndex = XTab.Index(txt_notes.TabIndex);\r\n";
            ___result += "            txt_notes.Enter += new EventHandler(Txt_notes_Enter);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[Properties of control]\r\n";
            ___result += "\r\n";

            #endregion[Notes Properties]
            
            #region[Properties of btn]

            ___result += "            #region[Properties of btn]\r\n";
            ___result += "\r\n";
            ___result += "            btn_save.Anchor = XAnchor.RB;\r\n";
            ___result += "            btn_save.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_save.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_save.Location = XLayout.BtnSave;\r\n";
            ___result += "            btn_save.TabIndex = XTab.Index(txt_" + lastfield + ".TabIndex);\r\n";
            ___result += "            btn_save.Name = \"btn_save\";\r\n";
            ___result += "            btn_save.Text = \"&SAVE\";\r\n";
            ___result += "            btn_save.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_save.Click += new EventHandler(Btn_save_click);\r\n";
            ___result += "\r\n";
            ___result += "            btn_active.Anchor = XAnchor.RB;\r\n";
            ___result += "            btn_active.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_active.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_active.Location = XLayout.BtnActive;\r\n";
            ___result += "            btn_active.TabIndex = XTab.Index(btn_save.TabIndex);\r\n";
            ___result += "            btn_active.Name = \"btn_active\";\r\n";
            ___result += "            btn_active.Text = \"&Active\";\r\n";
            ___result += "            btn_active.Click += new EventHandler(Btn_active_Click);\r\n";
            ___result += "\r\n";
            ___result += "            txt_notes.TabIndex = btn_active.TabIndex + 1;\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[Properties of btn]\r\n";
            ___result += "\r\n";

            #endregion[Properties of btn]

            ___result += "            #endregion[finner_panel]\r\n";
            ___result += "\r\n";

            #endregion[finner_panel]

            #region [F" + UPPERFIRST + "]

            ___result += "            #region [F" + UPPERFIRST + "]\r\n";
            ___result += "\r\n";
            ___result += "            this.AutoScaleDimensions = new SizeF(6F, 13F);\r\n";
            ___result += "            this.AutoScaleMode = AutoScaleMode.Font;\r\n";
            ___result += "            this.Controls.Add(this.split_container);\r\n";
            ___result += "            this.Name = \"f" + UPPERFIRST + "\";\r\n";
            ___result += "            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, ClientSize.Height);\r\n";
            ___result += "\r\n";
            ___result += "            this.split_container.Panel1.ResumeLayout(false);\r\n";
            ___result += "            this.split_container.Panel2.ResumeLayout(false);\r\n";
            ___result += "            ((System.ComponentModel.ISupportInitialize)(editgrid)).EndInit();\r\n";
            ___result += "            ((ISupportInitialize)(this.split_container)).EndInit();\r\n";
            ___result += "            this.split_container.ResumeLayout(false);\r\n";
            ___result += "            this.fpanel.ResumeLayout(false);\r\n";
            ___result += "            this.finner_panel.ResumeLayout(false);\r\n";
            ___result += "            this.finner_panel.PerformLayout();\r\n";
            ___result += "            this.ResumeLayout(false);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion [Fpost]\r\n";
            ___result += "        }\r\n";

            #endregion [Fpost]

            #endregion[Initialize]

            #region[Init Grid ]
            List<SFieldsItems> sub = obj.SFieldsItems;


            ___result += "  \r\n";
            ___result += "         #region[Init Grid]\r\n";
            ___result += "\r\n";
            ___result += "         private void InitGrid()\r\n";
            ___result += "         {\r\n";

            ___result += "            editgrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(Editgrid_RowsRemoved);\r\n";
            ___result += "            editgrid.CellValidating += new DataGridViewCellValidatingEventHandler(Editgrid_CellValidating);\r\n";
            ___result += "            editgrid.CellValueChanged += new DataGridViewCellEventHandler(Editgrid_CellValueChanged);\r\n";
            ___result += "            editgrid.CurrentCellChanged += new EventHandler(Editgrid_CurrentCellChanged);\r\n";


            ___result += "\r\n";

            ___result += "            DataGridViewTextBoxColumn col_" + UPPERFIRST + "items_Id = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_" + UPPERFIRST + "items_Id.Name = " + CAPITAL + "ITEMS." + CAPITAL + "ITEMS_ID;\r\n";
            ___result += "            col_" + UPPERFIRST + "items_Id.HeaderText = \"" + CAPITAL + "ITEMS_ID \";\r\n";
            ___result += "            col_" + UPPERFIRST + "items_Id.Visible = false; \r\n";
            ___result += "            col_" + UPPERFIRST + "items_Id.Width = 100;\r\n";
            ___result += "            col_" + UPPERFIRST + "items_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_" + UPPERFIRST + "items_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            editgrid.Columns.Add(col_" + UPPERFIRST + "items_Id );\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn col_slno = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_slno.Name = Core.SLNO;\r\n";
            ___result += "            col_slno.HeaderText = \"S.NO\";\r\n";
            ___result += "            //col_slno.Visible = false; \r\n";
            ___result += "            col_slno.ReadOnly = true;\r\n";
            ___result += "            col_slno.Width = 50;\r\n";
            ___result += "            col_slno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_slno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            editgrid.Columns.Add(col_slno);\r\n";
            ___result += "\r\n";

            for (int r = 0; r < sub.Count; r++)
            {
                if (sub[r].Inputtype != InputControls.None)
                {
                    string field = (sub[r].Fieldsname.ToLower()).UpperFirst();

                    ___result += "            DataGridViewTextBoxColumn col_" + field + " = new DataGridViewTextBoxColumn();\r\n";
                    ___result += "            col_" + field + ".Name = " + CAPITAL + "ITEMS." + sub[r].Fieldsname + ";\r\n";
                    ___result += "            col_" + field + ".HeaderText = \"" + sub[r].Displayname.Replace("_", " ") + "\";\r\n";
                    ___result += "            //col_" + field + ".Visible = false; \r\n";
                    ___result += "            col_" + field + ".Width = " + sub[r].Width + ";\r\n";
                    ___result += "            col_" + field + ".DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;\r\n";
                    ___result += "            col_" + field + ".AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
                    ___result += "            editgrid.Columns.Add(col_" + field + ");\r\n";
                    ___result += "\r\n";
                }
            }
            //___result += "            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();\r\n";
            //___result += "            col_Notes.Name = " + CAPITAL + "ITEMS.NOTES ;\r\n";
            //___result += "            col_Notes.HeaderText = \"NOTES\";\r\n";
            //___result += "            col_Notes.Visible = false; \r\n";
            //___result += "            col_Notes.Width = 200;\r\n";
            //___result += "            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            //___result += "            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            //___result += "            editgrid.Columns.Add(col_Notes );\r\n";
            //___result += "\r\n";
            //___result += "            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();\r\n";
            //___result += "            col_Active_Id.Name = " + CAPITAL + "ITEMS.ACTIVE_ID ;\r\n";
            //___result += "            col_Active_Id.HeaderText = \"ACTIVE ID\";\r\n";
            //___result += "            col_Active_Id.Visible = false; \r\n";
            //___result += "            col_Active_Id.Width = 200;\r\n";
            //___result += "            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            //___result += "            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            //___result += "            editgrid.Columns.Add(col_Active_Id );\r\n";
            //___result += "\r\n";
            //___result += "            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();\r\n";
            //___result += "            col_User_Id.Name = " + CAPITAL + "ITEMS.USER_ID ;\r\n";
            //___result += "            col_User_Id.HeaderText = \"ENTRY BY\";\r\n";
            //___result += "            //col_User_Id.Visible = false; \r\n";
            //___result += "            col_User_Id.Width = 120;\r\n";
            //___result += "            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            //___result += "            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            //___result += "            editgrid.Columns.Add(col_User_Id );\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            colFiller.Name = \"FILLER\";\r\n";
            ___result += "            colFiller.HeaderText = \"\";\r\n";
            ___result += "            colFiller.ReadOnly = true;\r\n";
            ___result += "            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;\r\n";
            ___result += "            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;\r\n";
            ___result += "            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;\r\n";
            ___result += "            editgrid.Columns.Add(colFiller);\r\n";
            ___result += "\r\n";
            ___result += "            }\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[Init Grid]\r\n";
            ___result += "\r\n";

            #endregion[Init Grid]

            #region[result]

            ___result += "}//cls \r\n";
            ___result += "}//ns \r\n";

            return ___result;

            #endregion[result]

        }
        //
    }//cls
}//ns