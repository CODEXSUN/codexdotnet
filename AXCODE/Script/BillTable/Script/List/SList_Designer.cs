using System;
using System.Collections.Generic;
using CXLIB;
using System.IO;

namespace AXCODE
{
    public class SList_designer
    {
        public static void XList_designer(BillTable obj)
        {
            string tbl_name = obj.STables.Stables_name;

            tbl_name = tbl_name.Remove((tbl_name).Length - 4).UpperFirst();

            string vpath = CodeIT.NPath + obj.SPath.Listfolder;

            vpath = CDir.CheckDir(vpath);

            string result = XCreate(obj);

            File.WriteAllText(@"" + vpath + "\\L" + tbl_name + "_Designer.cs", result);
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
            ___result += "using System.Drawing;\r\n";
            ___result += "using System.Windows.Forms;\r\n";
            ___result += "using CXLIB;\r\n";
            ___result += "\r\n";

            #endregion[using]

            #region [namespace]

            ___result += "namespace " + vnamespaces + "\r\n";
            ___result += "{\r\n";
            ___result += "    public partial class L" + UPPERFIRST + "\r\n";
            ___result += "    {\r\n";

            #endregion [namespace]

            #region[]

            ___result += "\r\n";
            ___result += "          private F" + UPPERFIRST + " f" + SMALL + " = null;\r\n";
            ___result += "          private bool constructed_flag = false;\r\n";
            ___result += "\r\n";
            ___result += "         public L" + UPPERFIRST + "()\r\n";
            ___result += "         {\r\n";
            ___result += "             InitializeComponent();\r\n";
            ___result += "             Initialize();\r\n";
            ___result += "             InitGrid();\r\n";
            ___result += "             List_Option(ListOption.active);\r\n";
            ___result += "             No_lookup();\r\n";
            //___result += "             Date_lookup();\r\n";
            ___result += "             Party_lookup();\r\n";
            //___result += "             Getno_panel.Visible = false;\r\n";
            ___result += "             constructed_flag = true;\r\n";
            ___result += "             rdo_unrefer.Checked = true;\r\n";
            ___result += "         }\r\n";
            ___result += "\r\n";

            #endregion[]

            #region[Private Declare]

            ___result += "        #region[Private Declare]\r\n";
            ___result += "\r\n";
            ___result += "        private XShadowPanel lpanel;\r\n";
            ___result += "        private Panel linner_panel;\r\n";
            ___result += "        private CloseButton btn_close;\r\n";
            ___result += "        private Header lbl_header;\r\n";
            ___result += "\r\n";
            ___result += "        private XLabel lbl_no;\r\n";
            ___result += "        private LookupBox txt_no;\r\n";
            ___result += "        private XLabel lbl_date;\r\n";
            ___result += "        private xDatepicker txt_datePicker;\r\n";
            ___result += "        private XTextBox txt_date;\r\n";
            ___result += "        private XLabel lbl_dateTo;\r\n";
            ___result += "        private xDatepicker txt_TodatePicker;\r\n";
            ___result += "        private XTextBox txt_Todate;\r\n";
            ___result += "        private XLabel lbl_party;\r\n";
            ___result += "        private LookupBox txt_party;\r\n";
            ___result += "        private OfficeButton btn_search;\r\n";
            ___result += "\r\n";
            ___result += "        private MRadioButton rdo_unrefer;\r\n";
            ___result += "        private MRadioButton rdo_refer;\r\n";
            ___result += "        private MRadioButton rdo_showall;\r\n";
            ___result += "        private MRadioButton rdo_notactive;\r\n";
            ___result += "\r\n";
            //___result += "        private OfficeButton btn_quick;\r\n";
            //___result += "        private Panel Getno_panel;\r\n";
            //___result += "        private ShadowBox Getno_innerpanel;\r\n";
            //___result += "        private XTextBox txt_getno;\r\n";
            //___result += "        private XLabel lbl_getno;\r\n";
            //___result += "        private OfficeButton btn_generate;\r\n";
            //___result += "\r\n";
            ___result += "        private OfficeButton btn_refresh;\r\n";
            ___result += "        private OfficeButton btn_new;\r\n";
            ___result += "        private OfficeButton btn_edit;\r\n";
            ___result += "        private OfficeButton btn_delete;\r\n";
            ___result += "        private OfficeButton btn_print;\r\n";
            ___result += "\r\n";
            ___result += "        private ListGridView listgrid;\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Private Declare]\r\n";
            ___result += "\r\n";

            #endregion[Private Declare]

            #region[Initialize]

            ___result += "        #region[Initialize]\r\n";
            ___result += "\r\n";
            ___result += "        private void Initialize()\r\n";
            ___result += "        {\r\n";
            ___result += "\r\n";
            ___result += "            lpanel = new XShadowPanel();\r\n";
            ___result += "            linner_panel = new Panel();\r\n";
            ___result += "            btn_close = new CloseButton();\r\n";
            ___result += "            lbl_header = new Header();\r\n";
            ___result += "\r\n";
            ___result += "            rdo_unrefer = new MRadioButton();\r\n";
            ___result += "            rdo_refer = new MRadioButton();\r\n";
            ___result += "            rdo_showall = new MRadioButton();\r\n";
            ___result += "            rdo_notactive = new MRadioButton();\r\n";
            ___result += "\r\n";
            ___result += "            txt_no = new LookupBox();\r\n";
            ___result += "            lbl_no = new XLabel();\r\n";
            ___result += "            txt_date = new XTextBox();\r\n";
            ___result += "            txt_datePicker = new xDatepicker();\r\n";
            ___result += "            lbl_date = new XLabel();\r\n";
            ___result += "            txt_Todate = new XTextBox();\r\n";
            ___result += "            txt_TodatePicker = new xDatepicker();\r\n";
            ___result += "            lbl_dateTo = new XLabel();\r\n";
            ___result += "            txt_party = new LookupBox();\r\n";
            ___result += "            lbl_party = new XLabel();\r\n";
            ___result += "            btn_search = new OfficeButton();\r\n";
            //___result += "\r\n";
            //___result += "            btn_quick = new OfficeButton();\r\n";
            //___result += "            Getno_panel = new Panel();\r\n";
            //___result += "            Getno_innerpanel = new ShadowBox();\r\n";
            //___result += "            txt_getno = new XTextBox();\r\n";
            //___result += "            lbl_getno = new XLabel();\r\n";
            //___result += "            btn_generate = new OfficeButton();\r\n";
            ___result += "\r\n";
            ___result += "            btn_refresh = new OfficeButton();\r\n";
            ___result += "            btn_new = new OfficeButton();\r\n";
            ___result += "            btn_edit = new OfficeButton();\r\n";
            ___result += "            btn_delete = new OfficeButton();\r\n";
            ___result += "            btn_print = new OfficeButton();\r\n";
            ___result += "\r\n";
            ___result += "            listgrid = new ListGridView();\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();\r\n";
            ___result += "            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();\r\n";
            ___result += "            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();\r\n";
            ___result += "\r\n";
            ___result += "            lpanel.SuspendLayout();\r\n";
            ___result += "            linner_panel.SuspendLayout();\r\n";
            ___result += "            ((System.ComponentModel.ISupportInitialize)(listgrid)).BeginInit();\r\n";
            ___result += "            SuspendLayout();\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Location = XLayout.LInnerPanel;\r\n";
            ___result += "            linner_panel.Name = \"linner_panel\";\r\n";
            ___result += "            linner_panel.Size = XSize.LInnerPanel;\r\n";
            ___result += "\r\n";
            ___result += "            btn_close.Click += Btn_close_Click;\r\n";
            ___result += "\r\n";
            ___result += "            lbl_header.Text = \"" + (obj.STables.Alias.Replace("_", " ")).UpperFirst() + "\";\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Initialize]\r\n";
            ___result += "\r\n";

            #endregion[Initialize]

            #region[Add Control]

            ___result += "            #region[Add Control]\r\n";
            ___result += "\r\n";
            ___result += "            lpanel.Name = \"lpanel\";\r\n";
            ___result += "            lpanel.Dock = DockStyle.Fill;\r\n";
            ___result += "            lpanel.Size = XSize.FPanel;\r\n";
            ___result += "            lpanel.Location = XLayout.FPanel;\r\n";
            ___result += "            lpanel.BackColor = XTheme.FPanel;\r\n";
            ___result += "            lpanel.Controls.Add(linner_panel);\r\n";
            ___result += "            lpanel.Controls.Add(btn_close);\r\n";
            ___result += "            lpanel.Controls.Add(lbl_header);\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Anchor = XAnchor.LTRB;\r\n";
            ___result += "            linner_panel.BackColor = XTheme.LInnerpanel;\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Controls.Add(txt_no);\r\n";
            ___result += "            linner_panel.Controls.Add(lbl_no);\r\n";
            ___result += "            linner_panel.Controls.Add(txt_date);\r\n";
            ___result += "            linner_panel.Controls.Add(txt_datePicker);\r\n";
            ___result += "            linner_panel.Controls.Add(lbl_date);\r\n";
            ___result += "            linner_panel.Controls.Add(txt_Todate);\r\n";
            ___result += "            linner_panel.Controls.Add(txt_TodatePicker);\r\n";
            ___result += "            linner_panel.Controls.Add(lbl_dateTo);\r\n";

            ___result += "            linner_panel.Controls.Add(txt_party);\r\n";
            ___result += "            linner_panel.Controls.Add(lbl_party);\r\n";
            ___result += "            linner_panel.Controls.Add(btn_search);\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Controls.Add(rdo_unrefer);\r\n";
            ___result += "            linner_panel.Controls.Add(rdo_refer);\r\n";
            ___result += "            linner_panel.Controls.Add(rdo_showall);\r\n";
            ___result += "            linner_panel.Controls.Add(rdo_notactive);\r\n";
            //___result += "\r\n";
            //___result += "            linner_panel.Controls.Add(btn_quick);\r\n";
            //___result += "            linner_panel.Controls.Add(Getno_panel);\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Controls.Add(btn_refresh);\r\n";
            ___result += "            linner_panel.Controls.Add(btn_new);\r\n";
            ___result += "            linner_panel.Controls.Add(btn_edit);\r\n";
            ___result += "            linner_panel.Controls.Add(btn_delete);\r\n";
            ___result += "            linner_panel.Controls.Add(btn_print);\r\n";
            ___result += "\r\n";
            ___result += "            linner_panel.Controls.Add(listgrid);\r\n";


            ___result += "\r\n";
            ___result += "            #endregion[Add Control]\r\n";
            ___result += "\r\n";

            #endregion[Add Control]

            #region[Search]

            ___result += "            #region[Search]\r\n";
            ___result += "\r\n";
            ___result += "            lbl_no.Font = XFont.Font_10B;\r\n";
            ___result += "            lbl_no.Name = \"lbl_no\";\r\n";
            ___result += "            lbl_no.Text = \"No\";\r\n";
            ___result += "            lbl_no.TextAlign = ContentAlignment.MiddleCenter;\r\n";
            ___result += "            lbl_no.ForeColor = XFontColor.Lbl_ForeColor;\r\n";
            ___result += "            lbl_no.Size = new Size(40, 28);\r\n";
            ___result += "            lbl_no.Location = XLayout.FirstLabel;\r\n";
            ___result += "\r\n";
            ___result += "            txt_no.Font = XFont.TxtFont;\r\n";
            ___result += "            txt_no.ForeColor = XFontColor.TxtFontColor;\r\n";
            ___result += "            txt_no.BackColor = XTheme.TxtBackcolor;\r\n";
            ___result += "            txt_no.Name = \"txt_no\";\r\n";
            ___result += "            txt_no.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;\r\n";
            ___result += "            txt_no.Size = new Size(120, 28);\r\n";
            ___result += "            txt_no.Anchor = XAnchor.LT;\r\n";
            ___result += "            txt_no.Location = new Point(lbl_no.Right - 1, lbl_no.Top);\r\n";
            ___result += "            txt_no.TabIndex = 6;\r\n";
            ___result += "\r\n";


            ___result += "            lbl_date.Font = XFont.Font_10B;\r\n";
            ___result += "            lbl_date.Name = \"lbl_date\";\r\n";
            ___result += "            lbl_date.Text = \"Date\";\r\n";
            ___result += "            lbl_date.TextAlign = ContentAlignment.MiddleCenter;\r\n";
            ___result += "            lbl_date.ForeColor = XFontColor.Lbl_ForeColor;\r\n";
            ___result += "            lbl_date.Size = new Size(50, 28);\r\n";
            ___result += "            lbl_date.Location = new Point(txt_no.Right + 10, txt_no.Top);\r\n";
            ___result += "\r\n";
            ___result += "            txt_date.Font = XFont.TxtFont;\r\n";
            ___result += "            txt_date.ForeColor = XFontColor.TxtFontColor;\r\n";
            ___result += "            txt_date.BackColor = XTheme.TxtBackcolor;\r\n";
            ___result += "            txt_date.Name = \"txt_date\";\r\n";
            ___result += "            txt_date.Size = new Size(140, 28);\r\n";
            ___result += "            txt_date.Anchor = XAnchor.LT;\r\n";
            ___result += "            txt_date.Location = new Point(lbl_date.Right - 1, lbl_date.Top);\r\n";
            ___result += "            txt_date.TabIndex = 7;\r\n";
            ___result += "\r\n";
            ___result += "            txt_datePicker.Font = XFont.TxtFont;\r\n";
            ___result += "            txt_datePicker.ForeColor = XFontColor.TxtFontColor;\r\n";
            ___result += "            txt_datePicker.BackColor = XTheme.TxtBackcolor;\r\n";
            ___result += "            txt_datePicker.Name = \"txt_datePicker\";\r\n";
            ___result += "            txt_datePicker.CustomFormat = \"  dd -MM-yyyy\";\r\n";
            ___result += "            txt_datePicker.Format = DateTimePickerFormat.Custom;\r\n";
            ___result += "            txt_datePicker.Size = new Size(170, 28);\r\n";
            ___result += "            txt_datePicker.Anchor = XAnchor.LT;\r\n";
            ___result += "            txt_datePicker.Location = new Point(lbl_date.Right - 1, lbl_date.Top);\r\n";
            ___result += "            txt_datePicker.TabIndex = 7;\r\n";
            ___result += "            txt_datePicker.TextChanged += Txt_datePicker_TextChanged;\r\n";
            ___result += "\r\n";
            ___result += "            lbl_dateTo.Font = XFont.Font_10B;\r\n";
            ___result += "            lbl_dateTo.Name = \"lbl_date\";\r\n";
            ___result += "            lbl_dateTo.Text = \"To\";\r\n";
            ___result += "            lbl_dateTo.TextAlign = ContentAlignment.MiddleCenter;\r\n";
            ___result += "            lbl_dateTo.ForeColor = XFontColor.Lbl_ForeColor;\r\n";
            ___result += "            lbl_dateTo.Size = new Size(50, 28);\r\n";
            ___result += "            lbl_dateTo.Location = new Point(txt_datePicker.Right + 10, lbl_date.Top);\r\n";
            ___result += "\r\n";
            ___result += "            txt_Todate.Font = XFont.TxtFont;\r\n";
            ___result += "            txt_Todate.ForeColor = XFontColor.TxtFontColor;\r\n";
            ___result += "            txt_Todate.BackColor = XTheme.TxtBackcolor;\r\n";
            ___result += "            txt_Todate.Name = \"txt_dateTo\";\r\n";
            ___result += "            txt_Todate.Size = new Size(140, 28);\r\n";
            ___result += "            txt_Todate.Anchor = XAnchor.LT;\r\n";
            ___result += "            txt_Todate.Location = new Point(lbl_dateTo.Right - 1, lbl_date.Top);\r\n";
            ___result += "            txt_Todate.TabIndex = 7;\r\n";
            ___result += "\r\n";
            ___result += "            txt_TodatePicker.Font = XFont.TxtFont;\r\n";
            ___result += "            txt_TodatePicker.ForeColor = XFontColor.TxtFontColor;\r\n";
            ___result += "            txt_TodatePicker.BackColor = XTheme.TxtBackcolor;\r\n";
            ___result += "            txt_TodatePicker.Name = \"txt_dateTopicker\";\r\n";
            ___result += "            txt_TodatePicker.CustomFormat = \"  dd -MM-yyyy\";\r\n";
            ___result += "            txt_TodatePicker.Format = DateTimePickerFormat.Custom;\r\n";
            ___result += "            txt_TodatePicker.Size = new Size(170, 28);\r\n";
            ___result += "            txt_TodatePicker.Anchor = XAnchor.LT;\r\n";
            ___result += "            txt_TodatePicker.Location = new Point(lbl_dateTo.Right - 1, lbl_date.Top);\r\n";
            ___result += "            txt_TodatePicker.TabIndex = 7;\r\n";
            ___result += "            txt_TodatePicker.TextChanged += Txt_TodatePicker_TextChanged;\r\n";
            ___result += "\r\n";
            ___result += "            lbl_party.Font = XFont.Font_10B;\r\n";
            ___result += "            lbl_party.Name = \"lbl_party\";\r\n";
            ___result += "            lbl_party.Text = \"Party\";\r\n";
            ___result += "            lbl_party.TextAlign = ContentAlignment.MiddleCenter;\r\n";
            ___result += "            lbl_party.ForeColor = XFontColor.Lbl_ForeColor;\r\n";
            ___result += "            lbl_party.Size = new Size(80, 28);\r\n";
            ___result += "            lbl_party.Location = new Point(txt_TodatePicker.Right + 10, txt_datePicker.Top);\r\n";
            ___result += "\r\n";
            ___result += "            txt_party.Font = XFont.TxtFont;\r\n";
            ___result += "            txt_party.ForeColor = XFontColor.TxtFontColor;\r\n";
            ___result += "            txt_party.BackColor = XTheme.TxtBackcolor;\r\n";
            ___result += "            txt_party.Name = \"txt_party\";\r\n";
            ___result += "            txt_party.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;\r\n";
            ___result += "            txt_party.Size = new Size(600, 28);\r\n";
            ___result += "            txt_party.Anchor = XAnchor.LT;\r\n";
            ___result += "            txt_party.Location = new Point(lbl_party.Right - 1, lbl_party.Top);\r\n";
            ___result += "            txt_party.TabIndex = 8;\r\n";
            ___result += "\r\n";
            ___result += "            btn_search.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_search.Location = new Point(txt_party.Right + 10, txt_party.Top);\r\n";
            ___result += "            btn_search.Size = new Size(75, 26);\r\n";
            ___result += "            btn_search.TabIndex = 1;\r\n";
            ___result += "            btn_search.Name = \"btn_search\";\r\n";
            ___result += "            btn_search.Text = \"&Search\";\r\n";
            ___result += "            btn_search.Themes = XTheme.YellowBtn;\r\n";
            ___result += "            btn_search.Anchor = XAnchor.TR;\r\n";
            ___result += "            btn_search.Click += Btn_search_Click;\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[Search]\r\n";
            ___result += "\r\n";

            #endregion[Search]

            #region[Radio btn]

            ___result += "            #region[Radio btn]\r\n";
            ___result += "\r\n";
            ___result += "            rdo_unrefer.Anchor = XAnchor.TR;\r\n";
            ___result += "            rdo_unrefer.AutoSize = false;\r\n";
            ___result += "            rdo_unrefer.Font = XFont.TxtFont;\r\n";
            ___result += "            rdo_unrefer.Location = new Point(XSize.FPanel_width - 160, 60);\r\n";
            ___result += "            rdo_unrefer.MouseLocation = new Point(-1, -1);\r\n";
            ___result += "            rdo_unrefer.Name = \"rdo_unrefer\";\r\n";
            ___result += "            rdo_unrefer.Size = new Size(200, 30);\r\n";
            ___result += "            rdo_unrefer.TabIndex = 2;\r\n";
            ___result += "            rdo_unrefer.Text = \"UN " + AutoCode.GetCaption(obj.STables.Stables_id, "rdo_unrefer") + "\";\r\n";
            ___result += "            rdo_unrefer.CheckedChanged += new EventHandler(Rdo_unrefer_CheckedChanged);\r\n";
            ___result += "\r\n";
            ___result += "            rdo_refer.Anchor = XAnchor.TR;\r\n";
            ___result += "            rdo_refer.AutoSize = false;\r\n";
            ___result += "            rdo_refer.Font = XFont.TxtFont;\r\n";
            ___result += "            rdo_refer.Location = new Point(rdo_unrefer.Left, rdo_unrefer.Bottom + 20);\r\n";
            ___result += "            rdo_refer.MouseLocation = new Point(-1, -1);\r\n";
            ___result += "            rdo_refer.Name = \"rdo_refer\";\r\n";
            ___result += "            rdo_refer.Size = new Size(200, 30);\r\n";
            ___result += "            rdo_refer.TabIndex = 3;\r\n";
            ___result += "            rdo_refer.Text = \" " + AutoCode.GetCaption(obj.STables.Stables_id, "rdo_refer") + "\";\r\n";
            ___result += "            rdo_refer.CheckedChanged += new EventHandler(Rdo_refer_CheckedChanged);\r\n";
            ___result += "\r\n";
            ___result += "            rdo_showall.Anchor = XAnchor.TR;\r\n";
            ___result += "            rdo_showall.AutoSize = false;\r\n";
            ___result += "            rdo_showall.Font = XFont.TxtFont;\r\n";
            ___result += "            rdo_showall.Location = new Point(rdo_refer.Left, rdo_refer.Bottom + 20);\r\n";
            ___result += "            rdo_showall.MouseLocation = new Point(-1, -1);\r\n";
            ___result += "            rdo_showall.Name = \"rdo_showall\";\r\n";
            ___result += "            rdo_showall.Size = new Size(200, 30);\r\n";
            ___result += "            rdo_showall.TabIndex = 4;\r\n";
            ___result += "            rdo_showall.Text = \" SHOW ALL\";\r\n";
            ___result += "            rdo_showall.CheckedChanged += new EventHandler(Rdo_showall_CheckedChanged);\r\n";
            ___result += "\r\n";
            ___result += "            rdo_notactive.Anchor = XAnchor.TR;\r\n";
            ___result += "            rdo_notactive.AutoSize = false;\r\n";
            ___result += "            rdo_notactive.Font = XFont.TxtFont;\r\n";
            ___result += "            rdo_notactive.Location = new Point(rdo_showall.Left, rdo_showall.Bottom + 20);\r\n";
            ___result += "            rdo_notactive.MouseLocation = new Point(-1, -1);\r\n";
            ___result += "            rdo_notactive.Name = \"rdo_notactive\";\r\n";
            ___result += "            rdo_notactive.Size = new Size(200, 30);\r\n";
            ___result += "            rdo_notactive.TabIndex = 6;\r\n";
            ___result += "            rdo_notactive.Text = \"NOT ACTIVE\";\r\n";
            ___result += "            rdo_notactive.CheckedChanged += new EventHandler(Rdo_notactive_CheckedChanged);\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[Radio btn]\r\n";
            ___result += "\r\n";

            #endregion[Radio btn]

            #region[btn Properties]

            ___result += "        #region[btn Properties]\r\n";
            ___result += "\r\n";
            ___result += "            btn_refresh.Font = XFont.BtnFont;\r\n";
            ___result += "            btn_refresh.Location = XLayout.BtnLocation(rdo_notactive.Location);\r\n";
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
            //___result += "            btn_quick.Font = XFont.BtnFont;\r\n";
            //___result += "            btn_quick.Location = XLayout.BtnLocation(btn_delete.Location);\r\n";
            //___result += "            btn_quick.Size = XSize.BtnOne;\r\n";
            //___result += "            btn_quick.TabIndex = XTab.Index(btn_delete.TabIndex);\r\n";
            //___result += "            btn_quick.Name = \"btn_quick\";\r\n";
            //___result += "            btn_quick.Text = \"&Quick " + AutoCode.GetCaption(obj.STables.Stables_id, "btn_quick") + "\";\r\n";
            //___result += "            btn_quick.Themes = XTheme.PinkBtn;\r\n";
            //___result += "            btn_quick.Anchor = XAnchor.TR;\r\n";
            //___result += "            btn_quick.Click += Btn_quick_Click;\r\n";
            //___result += "\r\n";
            ___result += "        #endregion[btn Properties]\r\n";
            ___result += "\r\n";

            #endregion[btn Properties]

            #region[Get no Panel]

            //___result += "            #region[Get no Panel]\r\n";
            //___result += "\r\n";
            //___result += "            Getno_panel.Size = new Size(300, 150);\r\n";
            //___result += "            Getno_panel.Location = new Point(btn_print.Left - 250, btn_print.Bottom - 40);\r\n";
            //___result += "            //Getno_panel.BackColor = XTheme.FPanel;\r\n";
            //___result += "            Getno_panel.BackColor = Color.Orange;\r\n";
            //___result += "            Getno_panel.Controls.Add(Getno_innerpanel);\r\n";
            //___result += "            Getno_innerpanel.Controls.Add(txt_getno);\r\n";
            //___result += "            Getno_innerpanel.Controls.Add(lbl_getno);\r\n";
            //___result += "            Getno_innerpanel.Controls.Add(btn_generate);\r\n";
            //___result += "\r\n";
            //___result += "            Getno_innerpanel.Size = new Size(295, 145);\r\n";
            //___result += "            Getno_innerpanel.Location = new Point(2, 2);\r\n";
            //___result += "            Getno_innerpanel.BackColor = Color.White;\r\n";
            //___result += "\r\n";
            //___result += "            lbl_getno.Font = XFont.Font_10B;\r\n";
            //___result += "            lbl_getno.Name = \"lbl_getno\";\r\n";
            //___result += "            lbl_getno.Text = \"No\";\r\n";
            //___result += "            lbl_getno.TextAlign = ContentAlignment.MiddleCenter;\r\n";
            //___result += "            lbl_getno.ForeColor = XFontColor.Lbl_ForeColor;\r\n";
            //___result += "            lbl_getno.Size = new Size(150, 28);\r\n";
            //___result += "            lbl_getno.Location = new Point(80, 20);\r\n";
            //___result += "            lbl_getno.BorderStyle = BorderStyle.None;\r\n";
            //___result += "            txt_getno.Font = XFont.TxtFont;\r\n";
            //___result += "            txt_getno.ForeColor = XFontColor.TxtFontColor;\r\n";
            //___result += "            txt_getno.BackColor = XTheme.TxtBackcolor;\r\n";
            //___result += "            txt_getno.Name = \"txt_getno\";\r\n";
            //___result += "            txt_getno.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;\r\n";
            //___result += "            txt_getno.Size = new Size(150, 28);\r\n";
            //___result += "            txt_getno.Anchor = XAnchor.LT;\r\n";
            //___result += "            txt_getno.Location = new Point(lbl_getno.Left, lbl_getno.Bottom);\r\n";
            //___result += "\r\n";
            //___result += "            btn_generate.Font = XFont.BtnFont;\r\n";
            //___result += "            btn_generate.Location = new Point(lbl_getno.Left, lbl_getno.Bottom + 40);\r\n";
            //___result += "            btn_generate.Size = new Size(150, 30);\r\n";
            //___result += "            btn_generate.TabIndex = XTab.Index(btn_print.TabIndex);\r\n";
            //___result += "            btn_generate.Name = \"btn_generate\";\r\n";
            //___result += "            btn_generate.Text = \"&Generate\";\r\n";
            //___result += "            btn_generate.Themes = XTheme.RedBtn;\r\n";
            //___result += "            btn_generate.Anchor = XAnchor.TR;\r\n";
            //___result += "            btn_generate.Click += Btn_generate_Click;\r\n";
            //___result += "\r\n";
            //___result += "            #endregion[Get no Panel]\r\n";
            //___result += "\r\n";
            #endregion[Get no Panel]

            #region[List Grid]

            ___result += "        #region[List Grid]\r\n";
            ___result += "\r\n";
            ___result += "            listgrid.AllowUserToAddRows = false;\r\n";
            ___result += "            listgrid.AllowUserToDeleteRows = false;\r\n";
            ___result += "            listgrid.AllowUserToOrderColumns = true;\r\n";
            ___result += "            listgrid.AllowUserToResizeRows = false;\r\n";
            ___result += "            dataGridViewCellStyle1.BackColor = Color.White;\r\n";
            ___result += "            dataGridViewCellStyle1.Font = XFont.Font_10R;\r\n";
            ___result += "            dataGridViewCellStyle1.ForeColor = Color.Black;\r\n";
            ___result += "            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 204);\r\n";
            ___result += "            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 0, 11);\r\n";
            ___result += "            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;\r\n";
            ___result += "            listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;\r\n";
            ___result += "            listgrid.Anchor = XAnchor.LTRB;\r\n";
            ___result += "            listgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;\r\n";
            ___result += "            listgrid.BackgroundColor = Color.White;\r\n";
            ___result += "            listgrid.BorderStyle = BorderStyle.Fixed3D;\r\n";
            ___result += "            listgrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom;\r\n";
            ___result += "            listgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;\r\n";
            ___result += "            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            dataGridViewCellStyle2.BackColor = Color.FromArgb(132, 192, 96);\r\n";
            ___result += "            dataGridViewCellStyle2.Font = new Font(\"Microsoft Sans Serif\", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));\r\n";
            ___result += "            dataGridViewCellStyle2.ForeColor = Color.White;\r\n";
            ___result += "            dataGridViewCellStyle2.Padding = new Padding(3);\r\n";
            ___result += "            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;\r\n";
            ___result += "            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;\r\n";
            ___result += "            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;\r\n";
            ___result += "            listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;\r\n";
            ___result += "            listgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;\r\n";
            ___result += "            listgrid.Cursor = Cursors.Default;\r\n";
            ___result += "            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;\r\n";
            ___result += "            dataGridViewCellStyle3.BackColor = Color.White;\r\n";
            ___result += "            dataGridViewCellStyle3.Font = XFont.Font_10R;\r\n";
            ___result += "            dataGridViewCellStyle3.ForeColor = Color.Black;\r\n";
            ___result += "            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 204);\r\n";
            ___result += "            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252, 0, 11);\r\n";
            ___result += "            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;\r\n";
            ___result += "            listgrid.DefaultCellStyle = dataGridViewCellStyle3;\r\n";
            ___result += "            listgrid.EnableHeadersVisualStyles = false;\r\n";
            ___result += "            listgrid.GridColor = Color.SeaGreen;\r\n";
            ___result += "            listgrid.MultiSelect = false;\r\n";
            ___result += "            listgrid.Name = \"listgrid\";\r\n";
            ___result += "            listgrid.ReadOnly = true;\r\n";
            ___result += "            listgrid.RowHeadersVisible = false;\r\n";
            ___result += "            listgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;\r\n";
            ___result += "            listgrid.Location = XLayout.ListView;\r\n";
            ___result += "            listgrid.Size = XSize.ListView;\r\n";
            ___result += "            listgrid.StandardTab = true;\r\n";
            ___result += "            listgrid.TabIndex = 0;\r\n";
            ___result += "\r\n";
            ___result += "        #endregion[List Grid]\r\n";
            ___result += "\r\n";

            #endregion[List Grid]

            #region[List]

            ___result += "#region[List]\r\n";
            ___result += "\r\n";
            ___result += "            AutoScaleDimensions = new SizeF(6F, 13F);\r\n";
            ___result += "            AutoScaleMode = AutoScaleMode.Font;\r\n";
            ___result += "            Controls.Add(lpanel);\r\n";
            ___result += "            Name = \"L" + UPPERFIRST + "\";\r\n";
            ___result += "            Size = new Size(1000, 600);\r\n";
            ___result += "            lpanel.ResumeLayout(false);\r\n";
            ___result += "            linner_panel.ResumeLayout(false);\r\n";
            ___result += "            linner_panel.PerformLayout();\r\n";
            ___result += "            ((System.ComponentModel.ISupportInitialize)(listgrid)).EndInit();\r\n";
            ___result += "            ResumeLayout(false);\r\n";
            ___result += "\r\n";
            ___result += "        }\r\n";
            ___result += "\r\n";
            ___result += "#endregion[List]\r\n";
            ___result += "\r\n";
            #endregion[List]

            #region[Init Grid ]

            ___result += "         #region[Init Grid]\r\n";
            ___result += "\r\n";
            ___result += "         private void InitGrid()\r\n";
            ___result += "         {\r\n";
            ___result += "            listgrid.RowAction += Listgrid_RowAction;\r\n";
            ___result += "\r\n";

            ___result += "            DataGridViewTextBoxColumn col_" + UPPERFIRST + "_Id = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.Name = " + CAPITAL + "." + CAPITAL + "_ID;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.HeaderText = \"" + CAPITAL + "_ID \";\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.Visible = false;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.Width = 100;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_" + UPPERFIRST + "_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_" + UPPERFIRST + "_Id);\r\n";
            ___result += "\r\n";

            for (int r = 0; r < list.Count; r++)
            {
                if (list[r].Inputtype != InputControls.None)
                {
                    string field = (list[r].Fieldsname.ToLower()).UpperFirst();

                    ___result += "            DataGridViewTextBoxColumn col_" + field + " = new DataGridViewTextBoxColumn();\r\n";
                    ___result += "            col_" + field + ".Name = " + CAPITAL + "." + list[r].Fieldsname + ";\r\n";
                    ___result += "            col_" + field + ".HeaderText = \"" + list[r].Displayname.Replace("_", " ") + "\";\r\n";
                    ___result += "            //col_" + field + ".Visible = false;\r\n";
                    if (field == "Party_id")
                    {
                        ___result += "            col_" + field + ".Width = 300;\r\n";
                        ___result += "            col_" + field + ".DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;\r\n";
                    }
                    else
                    {
                        ___result += "            col_" + field + ".Width = " + Find.TxtLength_Point(list[r].Displayname) + ";\r\n";
                        ___result += "            col_" + field + ".DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
                    }

                    ___result += "            col_" + field + ".AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
                    ___result += "            listgrid.Columns.Add(col_" + field + ");\r\n";
                    ___result += "\r\n";
                }
            }

            //___result += "            DataGridViewTextBoxColumn col_Notes = new DataGridViewTextBoxColumn();\r\n";
            //___result += "            col_Notes.Name = " + CAPITAL + ".NOTES ;\r\n";
            //___result += "            col_Notes.HeaderText = \"NOTES\";\r\n";
            //___result += "            col_Notes.Visible = false;\r\n";
            //___result += "            col_Notes.Width = 200;\r\n";
            //___result += "            col_Notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            //___result += "            col_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            //___result += "            listgrid.Columns.Add(col_Notes );\r\n";
            //___result += "\r\n";
            //___result += "            DataGridViewTextBoxColumn col_Active_Id = new DataGridViewTextBoxColumn();\r\n";
            //___result += "            col_Active_Id.Name = " + CAPITAL + ".ACTIVE_ID ;\r\n";
            //___result += "            col_Active_Id.HeaderText = \"ACTIVE ID\";\r\n";
            //___result += "            col_Active_Id.Visible = false;\r\n";
            //___result += "            col_Active_Id.Width = 200;\r\n";
            //___result += "            col_Active_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            //___result += "            col_Active_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            //___result += "            listgrid.Columns.Add(col_Active_Id );\r\n";
            //___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn col_grid = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_grid.Name = GRID.CELL;\r\n";
            ___result += "            col_grid.HeaderText = \"STATUS\";\r\n";
            ___result += "            //col_grid.Visible = false;\r\n";
            ___result += "            col_grid.Width = 120;\r\n";
            ___result += "            col_grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_grid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_grid);\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn col_User_Id = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            col_User_Id.Name = " + CAPITAL + ".USER_ID;\r\n";
            ___result += "            col_User_Id.HeaderText = \"ENTRY BY\";\r\n";
            ___result += "            //col_User_Id.Visible = false;\r\n";
            ___result += "            col_User_Id.Width = 120;\r\n";
            ___result += "            col_User_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;\r\n";
            ___result += "            col_User_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;\r\n";
            ___result += "            listgrid.Columns.Add(col_User_Id);\r\n";
            ___result += "\r\n";
            ___result += "            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();\r\n";
            ___result += "            colFiller.Name = \"FILLER\";\r\n";
            ___result += "            colFiller.HeaderText = \"\";\r\n";
            ___result += "            colFiller.ReadOnly = true;\r\n";
            ___result += "            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;\r\n";
            ___result += "            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;\r\n";
            ___result += "            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;\r\n";
            ___result += "            listgrid.Columns.Add(colFiller);\r\n";
            ___result += "\r\n";
            ___result += "            }\r\n";
            ___result += "\r\n";
            ___result += "            #endregion[Init Grid]\r\n";
            ___result += "\r\n";

            #endregion[Init Grid]

            #region[result]

            ___result += "    }//cls\r\n";
            ___result += "}//ns\r\n";

            return ___result;

            #endregion[result]

        }
    }//cls
}//ns
