// Version : 2.1.0.0 dt : 04-12-2018
// Auto Generated
// last update : 05-12-2018 09:57:54 PM

using System;
using System.Drawing;
using System.Windows.Forms;
using CXLIB;

namespace AXCODE
{
    public partial class LMastertables : UserControl
    {

        private FMtables fmtables = null;
        private bool constructed_flag = false;

        public LMastertables()
        {
            InitializeComponent();
            Initialize();
            InitGrid();
            List_Option(ListOption.showall);
            No_lookup();
            Party_lookup();
            constructed_flag = true;
            rdo_showall.Checked = true;
        }

        #region[Private Declare]

        private XShadowPanel lpanel;
        private Panel linner_panel;
        private CloseButton btn_close;
        private Header lbl_header;

        private XLabel lbl_database;
        private LookupBox txt_database;
        private XLabel lbl_mtables;
        private LookupBox txt_mtables;

        private OfficeButton btn_search;
        private OfficeButton btn_generate;

        private MRadioButton rdo_showall;
        private MRadioButton rdo_notactive;
        private OfficeButton btn_refresh;
        private OfficeButton btn_new;
        private OfficeButton btn_edit;
        private OfficeButton btn_delete;

        private ListGridView listgrid;

        #endregion[Private Declare]

        #region[Initialize]

        private void Initialize()
        {

            lpanel = new XShadowPanel();
            linner_panel = new Panel();
            btn_close = new CloseButton();
            lbl_header = new Header();

            rdo_showall = new MRadioButton();
            rdo_notactive = new MRadioButton();

            txt_database = new LookupBox();
            lbl_database = new XLabel();
            txt_mtables = new LookupBox();
            lbl_mtables = new XLabel();
            btn_search = new OfficeButton();
            btn_generate = new OfficeButton();

            btn_refresh = new OfficeButton();
            btn_new = new OfficeButton();
            btn_edit = new OfficeButton();
            btn_delete = new OfficeButton();

            listgrid = new ListGridView();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            lpanel.SuspendLayout();
            linner_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(listgrid)).BeginInit();
            SuspendLayout();

            linner_panel.Location = XLayout.LInnerPanel;
            linner_panel.Name = "linner_panel";
            linner_panel.Size = XSize.LInnerPanel;

            btn_close.Click += Btn_close_Click;

            lbl_header.Text = "Mtables";

            #endregion[Initialize]

            #region[Add Control]

            lpanel.Name = "lpanel";
            lpanel.Dock = DockStyle.Fill;
            lpanel.Size = XSize.FPanel;
            lpanel.Location = XLayout.FPanel;
            lpanel.BackColor = XTheme.FPanel;
            lpanel.Controls.Add(linner_panel);
            lpanel.Controls.Add(btn_close);
            lpanel.Controls.Add(lbl_header);

            linner_panel.Anchor = XAnchor.LTRB;
            linner_panel.BackColor = XTheme.LInnerpanel;

            linner_panel.Controls.Add(txt_database);
            linner_panel.Controls.Add(lbl_database);
            linner_panel.Controls.Add(txt_mtables);
            linner_panel.Controls.Add(lbl_mtables);
            linner_panel.Controls.Add(btn_search);
            linner_panel.Controls.Add(btn_generate);

            linner_panel.Controls.Add(rdo_showall);
            linner_panel.Controls.Add(rdo_notactive);

            linner_panel.Controls.Add(btn_refresh);
            linner_panel.Controls.Add(btn_new);
            linner_panel.Controls.Add(btn_edit);
            linner_panel.Controls.Add(btn_delete);

            linner_panel.Controls.Add(listgrid);

            #endregion[Add Control]

            #region[Search]

            lbl_database.Font = XFont.Font_10B;
            lbl_database.Name = "lbl_no";
            lbl_database.Text = "No";
            lbl_database.TextAlign = ContentAlignment.MiddleCenter;
            lbl_database.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_database.Size = new Size(40, 28);
            lbl_database.Location = XLayout.FirstLabel;

            txt_database.Font = XFont.TxtFont;
            txt_database.ForeColor = XFontColor.TxtFontColor;
            txt_database.BackColor = XTheme.TxtBackcolor;
            txt_database.Name = "txt_no";
            txt_database.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_database.Size = new Size(120, 28);
            txt_database.Anchor = XAnchor.LT;
            txt_database.Location = new Point(lbl_database.Right - 1, lbl_database.Top);
            txt_database.TabIndex = 6;

            lbl_mtables.Font = XFont.Font_10B;
            lbl_mtables.Name = "lbl_party";
            lbl_mtables.Text = "Party";
            lbl_mtables.TextAlign = ContentAlignment.MiddleCenter;
            lbl_mtables.ForeColor = XFontColor.Lbl_ForeColor;
            lbl_mtables.Size = new Size(80, 28);
            lbl_mtables.Location = new Point(txt_database.Right + 10, txt_database.Top);

            txt_mtables.Font = XFont.TxtFont;
            txt_mtables.ForeColor = XFontColor.TxtFontColor;
            txt_mtables.BackColor = XTheme.TxtBackcolor;
            txt_mtables.Name = "txt_party";
            txt_mtables.ReadOnlyBackColor = XTheme.TxtReadonlyBackcolor;
            txt_mtables.Size = new Size(600, 28);
            txt_mtables.Anchor = XAnchor.LTR;
            txt_mtables.Location = new Point(lbl_mtables.Right - 1, lbl_mtables.Top);
            txt_mtables.TabIndex = 8;

            btn_search.Font = XFont.BtnFont;
            btn_search.Location = new Point(txt_mtables.Right + 10, txt_mtables.Top);
            btn_search.Size = new Size(75, 26);
            btn_search.TabIndex = 1;
            btn_search.Name = "btn_search";
            btn_search.Text = "&Search";
            btn_search.Themes = XTheme.YellowBtn;
            btn_search.Anchor = XAnchor.TR;
            btn_search.Click += Btn_search_Click;


            btn_generate.Font = XFont.BtnFont;
            btn_generate.Location = new Point(btn_search.Right + 50, btn_search.Top);
            btn_generate.Size = new Size(75, 26);
            btn_generate.TabIndex = 1;
            btn_generate.Name = "btn_generate";
            btn_generate.Text = "&Generate";
            btn_generate.Themes = XTheme.RedBtn;
            btn_generate.Anchor = XAnchor.TR;
            btn_generate.Click += Btn_generate_Click;    

            #endregion[Search]

            #region[Radio btn]

            rdo_showall.Anchor = XAnchor.TR;
            rdo_showall.AutoSize = false;
            rdo_showall.Font = XFont.TxtFont;
            rdo_showall.Location = new Point(XSize.FPanel_width - 160, 60);
            rdo_showall.MouseLocation = new Point(-1, -1);
            rdo_showall.Name = "rdo_showall";
            rdo_showall.Size = new Size(200, 30);
            rdo_showall.TabIndex = 4;
            rdo_showall.Text = " SHOW ALL";
            rdo_showall.CheckedChanged += new EventHandler(Rdo_showall_CheckedChanged);

            rdo_notactive.Anchor = XAnchor.TR;
            rdo_notactive.AutoSize = false;
            rdo_notactive.Font = XFont.TxtFont;
            rdo_notactive.Location = new Point(rdo_showall.Left, rdo_showall.Bottom + 20);
            rdo_notactive.MouseLocation = new Point(-1, -1);
            rdo_notactive.Name = "rdo_notactive";
            rdo_notactive.Size = new Size(200, 30);
            rdo_notactive.TabIndex = 6;
            rdo_notactive.Text = "NOT ACTIVE";
            rdo_notactive.CheckedChanged += new EventHandler(Rdo_notactive_CheckedChanged);

            #endregion[Radio btn]

            #region[btn Properties]

            btn_refresh.Font = XFont.BtnFont;
            btn_refresh.Location = XLayout.BtnLocation(rdo_notactive.Location);
            btn_refresh.Size = XSize.BtnOne;
            btn_refresh.TabIndex = 1;
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Text = "&Refresh";
            btn_refresh.Themes = XTheme.BlueBtn;
            btn_refresh.Anchor = XAnchor.TR;
            btn_refresh.Click += Btn_refresh_Click;

            btn_new.Font = XFont.BtnFont;
            btn_new.Location = XLayout.BtnLocation(btn_refresh.Location);
            btn_new.Size = XSize.BtnOne;
            btn_new.TabIndex = XTab.Index(btn_refresh.TabIndex);
            btn_new.Name = "btn_new";
            btn_new.Text = "&New";
            btn_new.Themes = XTheme.BlueBtn;
            btn_new.Anchor = XAnchor.TR;
            btn_new.Click += Btn_new_Click;

            btn_edit.Font = XFont.BtnFont;
            btn_edit.Location = XLayout.BtnLocation(btn_new.Location);
            btn_edit.Size = XSize.BtnOne;
            btn_edit.TabIndex = XTab.Index(btn_new.TabIndex);
            btn_edit.Name = "btn_edit";
            btn_edit.Text = "&Edit";
            btn_edit.Themes = XTheme.BlueBtn;
            btn_edit.Anchor = XAnchor.TR;
            btn_edit.Click += Btn_edit_Click;

            btn_delete.Font = XFont.BtnFont;
            btn_delete.Location = XLayout.BtnLocation(btn_edit.Location);
            btn_delete.Size = XSize.BtnOne;
            btn_delete.TabIndex = XTab.Index(btn_edit.TabIndex);
            btn_delete.Name = "btn_delete";
            btn_delete.Text = "&Delete";
            btn_delete.Themes = XTheme.BlueBtn;
            btn_delete.Anchor = XAnchor.TR;
            btn_delete.Click += Btn_delete_Click;

            #endregion[btn Properties]

            #region[List Grid]

            listgrid.AllowUserToAddRows = false;
            listgrid.AllowUserToDeleteRows = false;
            listgrid.AllowUserToOrderColumns = true;
            listgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = XFont.Font_10R;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            listgrid.Anchor = XAnchor.LTRB;
            listgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listgrid.BackgroundColor = Color.White;
            listgrid.BorderStyle = BorderStyle.Fixed3D;
            listgrid.CellBorderStyle = DataGridViewCellBorderStyle.Custom;
            listgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(132, 192, 96);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            listgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            listgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listgrid.Cursor = Cursors.Default;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = XFont.Font_10R;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(252, 0, 11);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            listgrid.DefaultCellStyle = dataGridViewCellStyle3;
            listgrid.EnableHeadersVisualStyles = false;
            listgrid.GridColor = Color.SeaGreen;
            listgrid.MultiSelect = false;
            listgrid.Name = "listgrid";
            listgrid.ReadOnly = true;
            listgrid.RowHeadersVisible = false;
            listgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listgrid.Location = XLayout.ListView;
            listgrid.Size = XSize.ListView;
            listgrid.StandardTab = true;
            listgrid.TabIndex = 0;

            #endregion[List Grid]

            #region[List]

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lpanel);
            Name = "LMtables";
            Size = new Size(1000, 600);
            lpanel.ResumeLayout(false);
            linner_panel.ResumeLayout(false);
            linner_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(listgrid)).EndInit();
            ResumeLayout(false);

        }

        #endregion[List]

        #region[Init Grid]

        private void InitGrid()
        {
            listgrid.RowAction += Listgrid_RowAction;

            DataGridViewTextBoxColumn col_Mtables_Id = new DataGridViewTextBoxColumn();
            col_Mtables_Id.Name = MASTERTABLES.MASTERTABLES_ID;
            col_Mtables_Id.HeaderText = "MTABLES_ID ";
            //col_Mtables_Id.Visible = false;
            col_Mtables_Id.Width = 150;
            col_Mtables_Id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Mtables_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Mtables_Id);

            DataGridViewTextBoxColumn col_Databases_id = new DataGridViewTextBoxColumn();
            col_Databases_id.Name = MASTERTABLES.DATABASES_ID;
            col_Databases_id.HeaderText = "DATABASES ID";
            //col_Databases_id.Visible = false;
            col_Databases_id.Width = 208;
            col_Databases_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Databases_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Databases_id);

            DataGridViewTextBoxColumn col_Mtables_name = new DataGridViewTextBoxColumn();
            col_Mtables_name.Name = MASTERTABLES.MASTERTABLES_NAME;
            col_Mtables_name.HeaderText = "MTABLES NAME";
            //col_Mtables_name.Visible = false;
            col_Mtables_name.Width = 258;
            col_Mtables_name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Mtables_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Mtables_name);

            DataGridViewTextBoxColumn col_Alias = new DataGridViewTextBoxColumn();
            col_Alias.Name = MASTERTABLES.ALIAS;
            col_Alias.HeaderText = "ALIAS";
            //col_Alias.Visible = false;
            col_Alias.Width = 150;
            col_Alias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Alias.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Alias);

            DataGridViewTextBoxColumn col_Namespaces_id = new DataGridViewTextBoxColumn();
            col_Namespaces_id.Name = MASTERTABLES.NAMESPACES_ID;
            col_Namespaces_id.HeaderText = "NAMESPACES ID";
            //col_Namespaces_id.Visible = false;
            col_Namespaces_id.Width = 250;
            col_Namespaces_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_Namespaces_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_Namespaces_id);

            DataGridViewTextBoxColumn col_grid = new DataGridViewTextBoxColumn();
            col_grid.Name = GRID.CELL;
            col_grid.HeaderText = "STATUS";
            //col_grid.Visible = false;
            col_grid.Width = 120;
            col_grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_grid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            listgrid.Columns.Add(col_grid);

            DataGridViewTextBoxColumn colFiller = new DataGridViewTextBoxColumn();
            colFiller.Name = "FILLER";
            colFiller.HeaderText = "";
            colFiller.ReadOnly = true;
            colFiller.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            colFiller.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listgrid.Columns.Add(colFiller);

        }

        #endregion[Init Grid]

    }//cls
}//ns
