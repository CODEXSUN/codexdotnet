using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class MList_designer
    {
        public static void XList_designer(MasterDetails obj)
        {
            string tbl_name = obj.Mastertable.Mastertables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.Mastertablepath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\L" + tbl_name + "_Designer.cs", result);
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

            #region [namespace]

            ___result += "namespace " + vnamespaces + " \r\n";
            ___result += "{ \r\n";
            ___result += "    public partial class L" + UPPERFIRST + ": CxControl\r\n";
            ___result += "    { \r\n";

            #endregion [namespace]

            #region[]
            ___result += "\r\n";
            ___result += "          private F" + UPPERFIRST + " f" + SMALL + " = null;\r\n";
            ___result += "\r\n";
            ___result += "         public L" + UPPERFIRST + "()\r\n";
            ___result += "         {\r\n";
            ___result += "             InitializeComponent();\r\n";
            ___result += "             Initialize();\r\n";
            ___result += "             InitGrid();\r\n";
            ___result += "              List_Option(ListOption.active);\r\n";

            ___result += "             " + UPPERFIRST + "_lookup();\r\n";

            ___result += "         }\r\n";
            ___result += " \r\n";
            #endregion[]

            #region[Private Declare]

            ___result += "        #region[Private Declare] \r\n";
            ___result += " \r\n";
            ___result += "        private XShadowPanel lpanel; \r\n";
            ___result += "        private Panel linner_panel; \r\n";
            ___result += "        private MCheckBox chk_notactive; \r\n";
            ___result += "        private OfficeButton btn_search; \r\n";
            ___result += "        private LookupBox txt_" + SMALL + "_name; \r\n";
            ___result += "        private XLabel lbl_" + SMALL + "_name; \r\n";
            ___result += "        private CloseButton btn_close; \r\n";
            ___result += "        private Header lbl_header; \r\n";
            ___result += "        private OfficeButton btn_print; \r\n";
            ___result += "        private OfficeButton btn_delete; \r\n";
            ___result += "        private OfficeButton btn_edit; \r\n";
            ___result += "        private OfficeButton btn_new; \r\n";
            ___result += "        private OfficeButton btn_refresh; \r\n";
            ___result += "        private ListGridView listgrid; \r\n";
            ___result += " \r\n";
            ___result += "        #endregion[Private Declare] \r\n";
            ___result += " \r\n";
            #endregion[Private Declare]

            ___result += "        #region[Initialize] \r\n";

            ___result += "        private void Initialize() \r\n";
            ___result += "        { \r\n";
            ___result += "            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle(); \r\n";
            ___result += "            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle(); \r\n";
            ___result += "            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle(); \r\n";
            ___result += "            lpanel = new XShadowPanel(); \r\n";
            ___result += "            linner_panel = new Panel(); \r\n";
            ___result += "            chk_notactive = new MCheckBox(); \r\n";
            ___result += "            txt_" + SMALL + "_name = new LookupBox(); \r\n";
            ___result += "            lbl_" + SMALL + "_name = new XLabel(); \r\n";
            ___result += "            btn_close = new CloseButton(); \r\n";
            ___result += "            lbl_header = new Header(); \r\n";
            ___result += "            btn_print = new OfficeButton(); \r\n";
            ___result += "            btn_delete = new OfficeButton(); \r\n";
            ___result += "            btn_edit = new OfficeButton(); \r\n";
            ___result += "            btn_new = new OfficeButton(); \r\n";
            ___result += "            btn_refresh = new OfficeButton(); \r\n";
            ___result += "            listgrid = new ListGridView(); \r\n";
            ___result += "            btn_search = new OfficeButton(); \r\n";
            ___result += "            lpanel.SuspendLayout(); \r\n";
            ___result += "            linner_panel.SuspendLayout(); \r\n";
            ___result += "            ((System.ComponentModel.ISupportInitialize)(listgrid)).BeginInit(); \r\n";
            ___result += "            SuspendLayout(); \r\n";
            ___result += "\r\n";
            ___result += "            lpanel.Name = \"lpanel\"; \r\n";
            ___result += "            lpanel.Dock = DockStyle.Fill; \r\n";
            ___result += "            lpanel.Size = XSize.FPanel; \r\n";
            ___result += "            lpanel.Location =XLayout.FPanel; \r\n";
            ___result += "            lpanel.BackColor = XTheme.FPanel;\r\n";
            ___result += "            lpanel.Controls.Add(linner_panel); \r\n";
            ___result += "            lpanel.Controls.Add(btn_close);\r\n";
            ___result += "            lpanel.Controls.Add(lbl_header);\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Anchor = XAnchor.LTRB; \r\n";
            ___result += "            linner_panel.BackColor =  XTheme.LInnerpanel; \r\n";
            ___result += "            linner_panel.Controls.Add(btn_search); \r\n";
            ___result += "            linner_panel.Controls.Add(chk_notactive); \r\n";
            ___result += "            linner_panel.Controls.Add(txt_" + SMALL + "_name); \r\n";
            ___result += "            linner_panel.Controls.Add(lbl_" + SMALL + "_name); \r\n";
            ___result += "            linner_panel.Controls.Add(btn_print); \r\n";
            ___result += "            linner_panel.Controls.Add(btn_delete); \r\n";
            ___result += "            linner_panel.Controls.Add(btn_edit); \r\n";
            ___result += "            linner_panel.Controls.Add(btn_new); \r\n";
            ___result += "            linner_panel.Controls.Add(btn_refresh); \r\n";
            ___result += "            linner_panel.Controls.Add(listgrid); \r\n";
            ___result += "            linner_panel.Location = XLayout.LInnerPanel; \r\n";
            ___result += "            linner_panel.Name = \"linner_panel\"; \r\n";
            ___result += "            linner_panel.Size = XSize.LInnerPanel;\r\n";
            ___result += "\r\n";
            ___result += "            btn_close.Click += Btn_close_Click; \r\n";
            ___result += "\r\n";
            ___result += "            lbl_header.Text = \""  + ((obj.Mastertable.Alias).Replace("_", " ")).UpperFirst() + "\";\r\n";
            ___result += "\r\n";
            ___result += "            chk_notactive.Anchor = XAnchor.TR;\r\n";
            ___result += "            chk_notactive.AutoSize = true; \r\n";
            ___result += "            chk_notactive.Font = XFont.TxtFont;\r\n";
            ___result += "            chk_notactive.Location = XLayout.ListFirstBtn;\r\n";
            ___result += "            chk_notactive.MouseLocation = new Point(-1, -1); \r\n";
            ___result += "            chk_notactive.Name = \"chk_notactive\"; \r\n";
            ___result += "            chk_notactive.Size = new Size(92, 30); \r\n";
            ___result += "            chk_notactive.TabIndex = 4; \r\n";
            ___result += "            chk_notactive.Text = \"Not Active\"; \r\n";
            ___result += "            chk_notactive.CheckedChanged += new System.EventHandler(Chk_notactive_CheckedChanged); \r\n";
            ___result += "\r\n";
            ___result += "            txt_" + SMALL + "_name.Font = XFont.TxtFont; \r\n";
            ___result += "            txt_" + SMALL + "_name.ForeColor = XFontColor.TxtFontColor; \r\n";
            ___result += "            txt_" + SMALL + "_name.BackColor = XTheme.TxtBackcolor; \r\n";
            ___result += "            txt_" + SMALL + "_name.Name = \"txt_" + SMALL + "_name\"; \r\n";
            ___result += "            txt_" + SMALL + "_name.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor; \r\n";
            ___result += "            txt_" + SMALL + "_name.Size = XSize.TwoText; \r\n";
            ___result += "            txt_" + SMALL + "_name.Anchor = XAnchor.LTR; \r\n";
            ___result += "            txt_" + SMALL + "_name.Location = XLayout.FirstText; \r\n";
            ___result += "            txt_" + SMALL + "_name.TabIndex = 5; \r\n";
            ___result += "\r\n";
            ___result += "            lbl_" + SMALL + "_name.Font = XFont.Font_10B; \r\n";
            ___result += "            lbl_" + SMALL + "_name.Name = \"lbl_" + SMALL + "_name\"; \r\n";
            ___result += "            lbl_" + SMALL + "_name.Text = \"" + ((obj.Mastertable.Alias).Replace("_", " ")).UpperFirst() + "\";\r\n";
            ___result += "            lbl_" + SMALL + "_name.TextAlign = ContentAlignment.MiddleCenter; \r\n";
            ___result += "            lbl_" + SMALL + "_name.ForeColor = XFontColor.Lbl_ForeColor; \r\n";
            ___result += "            lbl_" + SMALL + "_name.Size = XSize.OneLabel; \r\n";
            ___result += "            lbl_" + SMALL + "_name.Location = XLayout.FirstLabel; \r\n";
            ___result += "\r\n";
            ___result += "            btn_search.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_search.Location = new Point(txt_" + SMALL + "_name.Right + 10 ,txt_" + SMALL + "_name.Top);\r\n";
            ___result += "            btn_search.Size = new Size(75, 26); \r\n";
            ___result += "            btn_search.TabIndex = 1;\r\n";
            ___result += "            btn_search.Name = \"btn_search\";\r\n";
            ___result += "            btn_search.Text = \"&Search\";\r\n";
            ___result += "            btn_search.Themes = XTheme.YellowBtn;\r\n";
            ___result += "            btn_search.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_search.Click += Btn_search_Click;\r\n";

            ___result += "\r\n";

            ___result += "        #region[btn Properties] \r\n";

            ___result += "\r\n";
            ___result += "            btn_refresh.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_refresh.Location = XLayout.BtnLocation(chk_notactive.Location);\r\n";
            ___result += "            btn_refresh.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_refresh.TabIndex = 1;\r\n";
            ___result += "            btn_refresh.Name = \"btn_refresh\";\r\n";
            ___result += "            btn_refresh.Text = \"&Refresh\";\r\n";
            ___result += "            btn_refresh.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_refresh.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_refresh.Click += Btn_refresh_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_new.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_new.Location = XLayout.BtnLocation(btn_refresh.Location);\r\n";
            ___result += "            btn_new.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_new.TabIndex = XTab.Index(btn_refresh.TabIndex);\r\n";
            ___result += "            btn_new.Name = \"btn_new\";\r\n";
            ___result += "            btn_new.Text = \"&New\";\r\n";
            ___result += "            btn_new.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_new.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_new.Click += Btn_new_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_edit.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_edit.Location = XLayout.BtnLocation(btn_new.Location);\r\n";
            ___result += "            btn_edit.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_edit.TabIndex = XTab.Index(btn_new.TabIndex);\r\n";
            ___result += "            btn_edit.Name = \"btn_edit\";\r\n";
            ___result += "            btn_edit.Text = \"&Edit\";\r\n";
            ___result += "            btn_edit.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_edit.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_edit.Click += Btn_edit_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_delete.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_delete.Location = XLayout.BtnLocation(btn_edit.Location);\r\n";
            ___result += "            btn_delete.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_delete.TabIndex = XTab.Index(btn_edit.TabIndex);\r\n";
            ___result += "            btn_delete.Name = \"btn_delete\";\r\n";
            ___result += "            btn_delete.Text = \"&Delete\";\r\n";
            ___result += "            btn_delete.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_delete.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_delete.Click += Btn_delete_Click;\r\n";
            ___result += "\r\n";
            ___result += "            btn_print.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_print.Location = XLayout.BtnLocation(btn_delete.Location);\r\n";
            ___result += "            btn_print.Size = XSize.BtnOne;\r\n";
            ___result += "            btn_print.TabIndex = XTab.Index(btn_delete.TabIndex);\r\n";
            ___result += "            btn_print.Name = \"btn_print\";\r\n";
            ___result += "            btn_print.Text = \"&Print\";\r\n";
            ___result += "            btn_print.Themes = XTheme.BlueBtn;\r\n";
            ___result += "            btn_print.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_print.Click += Btn_print_Click;\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[btn Properties] \r\n";

            ___result += "\r\n";
            ___result += "        #region[List Grid] \r\n";
            ___result += "\r\n";

            ___result += "            listgrid.AllowUserToAddRows = false; \r\n";
            ___result += "            listgrid.AllowUserToDeleteRows = false; \r\n";
            ___result += "            listgrid.AllowUserToOrderColumns = true; \r\n";
            ___result += "            listgrid.AllowUserToResizeRows = false; \r\n";
            ___result += "            dataGridViewCellStyle1.BackColor = Color.White; \r\n";
            ___result += "            dataGridViewCellStyle1.Font = XFont.Font_10R; \r\n";
            ___result += "            dataGridViewCellStyle1.ForeColor = Color.Black; \r\n";
            ___result += "            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255,255,204); \r\n";
            ___result += "            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252,0,11); \r\n";
            ___result += "            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True; \r\n";
            ___result += "            listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1; \r\n";
            ___result += "            listgrid.Anchor = XAnchor.LTRB;\r\n";
            ___result += "            listgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; \r\n";
            ___result += "            listgrid.BackgroundColor = Color.White; \r\n";
            ___result += "            listgrid.BorderStyle = BorderStyle.Fixed3D; \r\n";
            ___result += "            listgrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom; \r\n";
            ___result += "            listgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom; \r\n";
            ___result += "            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter; \r\n";
            ___result += "            dataGridViewCellStyle2.BackColor = Color.FromArgb(132,192,96); \r\n";
            ___result += "            dataGridViewCellStyle2.Font = new Font(\"Microsoft Sans Serif\", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); \r\n";
            ___result += "            dataGridViewCellStyle2.ForeColor = Color.White; \r\n";
            ___result += "            dataGridViewCellStyle2.Padding = new Padding(3); \r\n";
            ___result += "            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight; \r\n";
            ___result += "            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText; \r\n";
            ___result += "            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True; \r\n";
            ___result += "            listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2; \r\n";
            ___result += "            listgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; \r\n";
            ___result += "            listgrid.Cursor = Cursors.Default; \r\n";
            ___result += "            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft; \r\n";
            ___result += "            dataGridViewCellStyle3.BackColor = Color.White; \r\n";
            ___result += "            dataGridViewCellStyle3.Font = XFont.Font_10R; \r\n";
            ___result += "            dataGridViewCellStyle3.ForeColor = Color.Black; \r\n";
            ___result += "            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255,255,204); \r\n";
            ___result += "            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252,0,11); \r\n";
            ___result += "            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False; \r\n";
            ___result += "            listgrid.DefaultCellStyle = dataGridViewCellStyle3; \r\n";
            ___result += "            listgrid.EnableHeadersVisualStyles = false; \r\n";
            ___result += "            listgrid.GridColor = Color.SeaGreen; \r\n";
            ___result += "            listgrid.MultiSelect = false; \r\n";
            ___result += "            listgrid.Name = \"listgrid\"; \r\n";
            ___result += "            listgrid.ReadOnly = true; \r\n";
            ___result += "            listgrid.RowHeadersVisible = false; \r\n";
            ___result += "            listgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; \r\n";
            ___result += "            listgrid.Location = XLayout.ListView; \r\n";
            ___result += "            listgrid.Size = XSize.ListView; \r\n";
            ___result += "            listgrid.StandardTab = true; \r\n";
            ___result += "            listgrid.TabIndex = 0; \r\n";
            ___result += "\r\n";
            ___result += "        #endregion[List Grid] \r\n";
            ___result += "\r\n";

            ___result += "            AutoScaleDimensions = new SizeF(6F, 13F); \r\n";
            ___result += "            AutoScaleMode = AutoScaleMode.Font; \r\n";
            ___result += "            Controls.Add(lpanel); \r\n";
            ___result += "            Name = \"L" + UPPERFIRST + "\"; \r\n";
            ___result += "            Size = new Size(1000, 600); \r\n";
            ___result += "            lpanel.ResumeLayout(false); \r\n";
            ___result += "            linner_panel.ResumeLayout(false); \r\n";
            ___result += "            linner_panel.PerformLayout(); \r\n";
            ___result += "            ((System.ComponentModel.ISupportInitialize)(listgrid)).EndInit(); \r\n";
            ___result += "            ResumeLayout(false); \r\n";
            ___result += " \r\n";
            ___result += "        } \r\n";
            ___result += " \r\n";
            ___result += "        #endregion[Initialize] \r\n";
            ___result += " \r\n";


            #region[result]

            ___result += "    }//cls \r\n";
            ___result += "}//ns \r\n";

            return ___result;

            #endregion[result]

        }
    }//cls
}//ns
